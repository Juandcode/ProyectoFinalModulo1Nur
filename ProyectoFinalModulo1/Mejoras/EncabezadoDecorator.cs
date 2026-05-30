namespace ProyectoFinalModulo1.Mejoras
{
    public class EncabezadoDecorator : ReportDecorator
    {
        public override string MakeReport()
        {
            return base.MakeReport() + "\n\n" + AddEncabezado();
        }

        private string AddEncabezado()
        {
            return "Encabezado Añadido";
        }
    }
}