namespace ProyectoFinalModulo1.StrategyProcess
{
    public class Context
    {
        private IStrategyProcess _strategyProcess;

        public void SetStrategy(IStrategyProcess strategyProcess)
        {
            _strategyProcess = strategyProcess;
        }

        public string ShowStrategyProcess(IReport report, string bodyReport)
        {
            return _strategyProcess.MyChoise(report, bodyReport);
        }
    }
}