using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi;
using ProyectoFinalModulo1.CanalEnvio;
using ProyectoFinalModulo1.FormatosReport;
using ProyectoFinalModulo1.Roles;
using ProyectoFinalModulo1.StrategyProcess;

namespace ProyectoFinalModulo1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ReportController : Controller
    {
        [HttpPost(Name = nameof(Create))]
        public async Task<IActionResult> Create([FromBody] BodyReportData bodyReportData)
        {
            try
            {
                if (!Enum.TryParse(bodyReportData.roleName, out Roles.Roles role))
                    throw new KeyNotFoundException("Role does not exists.");


                //Crea la instancia de alguna estrategia, IStrategy, puede ser Analista, Ejecutivo, etc
                Type? strategyClass = Assembly.GetExecutingAssembly().GetTypes()
                    .FirstOrDefault(t => t.Name.Equals($"{bodyReportData.roleName}StrategyProcess"));

                if (strategyClass == null) return NotFound($"No {bodyReportData.roleName} Strategy found.");

                IStrategyProcess instanceStrategyProcess = (IStrategyProcess) Activator.CreateInstance(strategyClass)!;


                if (!Enum.TryParse(bodyReportData.TypeReport, out Reports reportType))
                    throw new KeyNotFoundException($"Report type {bodyReportData.TypeReport} does not exists.");

                //Esto crea la instancia del reportFactory PDF, Excel, obteniendo el type mediante reflection, enviandole el nombre del Factory
                Type? formatFileType = Assembly.GetExecutingAssembly().GetTypes()
                    .FirstOrDefault(t => t.Name.Equals($"{bodyReportData.TypeReport}Factory"));
                if (formatFileType == null)
                    throw new KeyNotFoundException($"No {bodyReportData.TypeReport} Factory found.");

                //aplica el patron Factory method
                IReportFactory factoryInstance = (IReportFactory) Activator.CreateInstance(formatFileType)!;
                IReport report = factoryInstance.CreateReport();

                //Aplica el patron strategy
                Context contextStrategy = new Context();
                contextStrategy.SetStrategy(instanceStrategyProcess);
                string data = contextStrategy.ShowStrategyProcess(report, bodyReportData.bodyReport);

                //Aplica el patron mediator para el envio mediante algun canal
                ConcreteMediatorCanal mediatorCanal = new ConcreteMediatorCanal();
                Canal apiCanal = new APICanal(mediatorCanal);
                Canal correoCanal = new CorreoCanal(mediatorCanal);
                mediatorCanal.Register(apiCanal);
                mediatorCanal.Register(correoCanal);

                string canales = mediatorCanal.ShowDetails();

                //devolver toda la informacion
                return Ok(data + "\n" + canales);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}