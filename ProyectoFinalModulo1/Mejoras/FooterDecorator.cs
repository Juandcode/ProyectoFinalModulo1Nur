namespace ProyectoFinalModulo1.Mejoras
{
    public class Footer: ReportDecorator
    {
        public override string MakeReport()
        {
            return base.MakeReport() + " \n" + AddFooter() + "\n";
        }

        private string AddFooter()
        {
            return "Footer Añadido";
        }
    }
}