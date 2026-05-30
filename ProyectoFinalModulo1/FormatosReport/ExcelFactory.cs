namespace ProyectoFinalModulo1.FormatosReport
{
    public class ExcelFactory: IReportFactory
    {
        public override IReport CreateReport()
        {
            return new ExcelReport();
        }
    }
}