using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.StrategyCalculaImposto.Estrategias
{
    public class StrategyCalculaImpostoII : ICalculaImposto
    {
        public decimal CalculaImposto(decimal DD061_ValorImposto, decimal VlrBaseCalcImposto)
        => VlrBaseCalcImposto + DD061_ValorImposto;
    }
}
