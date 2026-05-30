namespace ProyectoFinalModulo1.Mejoras
{
    public abstract class ReportDecorator : IReport
    {
        protected IReport? _report;

        public string BodyReport { get; set; }

        public virtual string MakeReport()
        {
            return _report != null ? _report.MakeReport() : string.Empty;
        }

        public void setTheComponent(IReport report)
        {
            _report = report;
        }
    }
}