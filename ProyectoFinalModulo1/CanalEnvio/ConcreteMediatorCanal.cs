namespace ProyectoFinalModulo1.CanalEnvio
{
    public class ConcreteMediatorCanal : IMediatorCanal
    {
        private List<Canal> canales = new List<Canal>();

        public void Register(Canal canal)
        {
            canales.Add(canal);
        }

        public void Send(Canal canal)
        {
            if (canales.Contains(canal))
            {
                Console.WriteLine($"Report enviado usando el canal {canal} \n");
            }
        }

        public string ShowDetails()
        {
            string msg = string.Empty;
            foreach (Canal canal in canales)
            {
                msg += $"Reporte enviando usando el canal {canal.Name}\n";
            }

            return msg;
        }
    }
}