using ProyectoFinalModulo1.FormatosReport;
using ProyectoFinalModulo1.Mejoras;

namespace ProyectoFinalModulo1.StrategyProcess
{
    public class EjecutivoStrategyProcess: IStrategyProcess
    {
        public override string MyChoise(IReport report, string reportBody)
        {
            // IReport report1 = new Report();
            // report1.BodyReport = reportBody;
            // var factory = new PDFFactory();
            // IReport report = factory.CreateReport();
            
            ReportDecorator encabezado = new EncabezadoDecorator();
            encabezado.setTheComponent(report);
            
            ReportDecorator body = new BodyDecorator();
            body.BodyReport = reportBody;
            body.setTheComponent(encabezado);
            
            ReportDecorator footer = new Footer();
            footer.setTheComponent(body);
            
            ReportDecorator marcaDeAgua = new MarcaDeAguaDecorator();
            marcaDeAgua.setTheComponent(footer);
            
            return marcaDeAgua.MakeReport();
        }
    }
}