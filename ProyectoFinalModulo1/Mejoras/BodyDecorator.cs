namespace ProyectoFinalModulo1.Mejoras
{
    public class BodyDecorator : ReportDecorator
    {
        public override string MakeReport()
        {
            return base.MakeReport() + " \n" + AddBody();
        }

        private string AddBody()
        {
            return base.BodyReport;
        }
    }
}