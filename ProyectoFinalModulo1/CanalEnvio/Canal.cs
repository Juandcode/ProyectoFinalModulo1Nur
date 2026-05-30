namespace ProyectoFinalModulo1.CanalEnvio
{
    public abstract class Canal
    {
        protected IMediatorCanal mediator;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
// Constructor
        public Canal(IMediatorCanal mediator)
        {
            this.mediator = mediator;
        }
    }
}