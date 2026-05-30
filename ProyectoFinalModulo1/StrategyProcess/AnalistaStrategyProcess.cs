using System.Reflection;
using ProyectoFinalModulo1.FormatosReport;
using ProyectoFinalModulo1.Mejoras;

namespace ProyectoFinalModulo1.StrategyProcess
{
    public class AnalistaStrategyProcess: IStrategyProcess
    {
        public override string MyChoise(IReport report, string reportBody)
        {
            
             // Type? formatFileType = Assembly.GetExecutingAssembly().GetTypes()
             //     .FirstOrDefault(t => t.Name.Equals($"{typeReportCreation}Factory"));
             // //
             // if (formatFileType == null) throw new KeyNotFoundException($"No {typeReportCreation} Factory found.");
             //
             // IReportFactory factory = (IReportFactory) Activator.CreateInstance(formatFileType)!;
            
            //IReportFactory factory = new PDFFactory();
            //IReport report = CreateMyChoise(typeReportCreation).CreateReport();
            
            ReportDecorator encabezado = new EncabezadoDecorator();
            encabezado.setTheComponent(report);
            
            ReportDecorator body = new BodyDecorator();
            body.BodyReport = reportBody;
            body.setTheComponent(encabezado);
            
            ReportDecorator footer = new Footer();
            footer.setTheComponent(body);
            
            return footer.MakeReport();
        }
    }
}