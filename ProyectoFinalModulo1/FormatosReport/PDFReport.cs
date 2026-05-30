using ProyectoFinalModulo1.StrategyProcess;

namespace ProyectoFinalModulo1.FormatosReport
{
    public class PDFReport: IReport
    {
        public string BodyReport { get; set; }

        public string MakeReport()
        {
            return $"report information: {Guid.NewGuid()}.pdf";
        }
    }
}