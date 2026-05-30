namespace ProyectoFinalModulo1.CanalEnvio
{
    public class APICanal: Canal
    {
        public APICanal(IMediatorCanal mediator) : base(mediator)
        {
            this.Name = "API";
        }
    }
}