using System.Reflection;
using ProyectoFinalModulo1.FormatosReport;
using ProyectoFinalModulo1.Roles;

namespace ProyectoFinalModulo1.StrategyProcess
{
    public abstract class IStrategyProcess
    {
        public abstract string MyChoise(IReport report, string reportBody);
        
    }
}