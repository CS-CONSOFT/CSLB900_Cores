using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.StrategyCalculaImposto.Estrategias
{
    public class StrategyCalculaImpostoICMS : ICalculaImposto
    {
        private readonly decimal _vICMSUFDest;
        private readonly decimal _vFCP;
        private readonly decimal _vFCPUFDest;
        private readonly decimal _vICMSMono;

        public StrategyCalculaImpostoICMS(decimal? vICMSUFDest, decimal? vFCP, decimal? vFCPUFDest, decimal? vICMSMono)
        {
            _vICMSUFDest = vICMSUFDest ?? 0m;
            _vFCP = vFCP ?? 0m;
            _vFCPUFDest = vFCPUFDest ?? 0m;
            _vICMSMono = vICMSMono ?? 0m;
        }

        public decimal CalculaImposto(decimal? DD061_ValorImposto, decimal? VlrBaseCalcImposto)
        {
            return (VlrBaseCalcImposto ?? 0m)
                - (DD061_ValorImposto ?? 0m)
                - _vICMSUFDest
                - _vFCP
                - _vFCPUFDest
                - _vICMSMono;
        }

    }
}