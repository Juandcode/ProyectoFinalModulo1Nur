namespace ProyectoFinalModulo1.FormatosReport
{
    public class ExcelReport: IReport
    {
        public string BodyReport { get; set; }

        public string MakeReport()
        {
            return $"report information: {Guid.NewGuid()}.csv";
        }
    }
}