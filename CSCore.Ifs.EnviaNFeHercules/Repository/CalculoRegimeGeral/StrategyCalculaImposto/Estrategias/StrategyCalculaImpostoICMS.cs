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

        public StrategyCalculaImpostoICMS(decimal vICMSUFDest, decimal vFCP, decimal vFCPUFDest, decimal vICMSMono)
        {
            _vICMSUFDest = vICMSUFDest;
            _vFCP = vFCP;
            _vFCPUFDest = vFCPUFDest;
            _vICMSMono = vICMSMono;
        }

        public decimal CalculaImposto(decimal DD061_ValorImposto, decimal VlrBaseCalcImposto)
        {
            return VlrBaseCalcImposto
                - DD061_ValorImposto
                - _vICMSUFDest
                - _vFCP
                - _vFCPUFDest
                - _vICMSMono;
        }

    }
}