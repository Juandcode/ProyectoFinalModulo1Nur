namespace ProyectoFinalModulo1.Mejoras
{
    public class CifradoDecorator: ReportDecorator
    {
        public override string MakeReport()
        {
            return base.MakeReport() + "\n" + AddCifrado();
        }

        private string AddCifrado()
        {
            return "Cifrado añadido para mas seguridad";
        }
    }
}