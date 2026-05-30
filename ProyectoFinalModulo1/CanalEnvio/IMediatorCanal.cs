namespace ProyectoFinalModulo1.CanalEnvio
{
    public interface IMediatorCanal
    {
        void Register(Canal canal);
        void Send(Canal canal);
    }
}