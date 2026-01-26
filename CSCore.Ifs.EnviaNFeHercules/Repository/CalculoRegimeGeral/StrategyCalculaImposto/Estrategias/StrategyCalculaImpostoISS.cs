using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.StrategyCalculaImposto.Estrategias
{
    public class StrategyCalculaImpostoISS : ICalculaImposto
    {
        public decimal CalculaImposto(decimal? DD061_ValorImposto, decimal? VlrBaseCalcImposto) 
            => (VlrBaseCalcImposto ?? 0m) - (DD061_ValorImposto ?? 0m);
    }
}
