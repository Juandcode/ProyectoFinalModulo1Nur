using System.Reflection;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.OpenApi;
using ProyectoFinalModulo1.Roles;
using ProyectoFinalModulo1.StrategyProcess;

namespace ProyectoFinalModulo1.FormatosReport
{
    public abstract class IReportFactory
    {
        public abstract IReport CreateReport();
    }
}