namespace ProyectoFinalModulo1.Mejoras
{
    public class MarcaDeAguaDecorator: ReportDecorator
    {
        public override string MakeReport()
        {
            return base.MakeReport() + " \n" + AddMarcaDeAgua() + "\n";
        }

        private string AddMarcaDeAgua()
        {
            return "Marca de agua Añadido";
        }
    }
}