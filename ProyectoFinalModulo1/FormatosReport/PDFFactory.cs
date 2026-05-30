using ProyectoFinalModulo1.StrategyProcess;

namespace ProyectoFinalModulo1.FormatosReport
{
    public class PDFFactory: IReportFactory
    {
        public override IReport CreateReport()
        {
            return new PDFReport();
        }
    }
}