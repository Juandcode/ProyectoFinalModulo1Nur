namespace ProyectoFinalModulo1.CanalEnvio
{
    public class CorreoCanal : Canal
    {
        public CorreoCanal(IMediatorCanal mediator) : base(mediator)
        {
            this.Name = "Correo";
        }
    }
}