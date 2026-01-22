using CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.StrategyCalculaImposto.Estrategias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.StrategyCalculaImposto
{
    public static class StrategyCalculaImpostoBase
    {
        public static decimal GetTipoCalculoImposto(EnumTipoCalculoImposto enumTipoCalculoImposto)
        {
            ICalculaImposto tipoCalculoImpost = enumTipoCalculoImposto switch
            {
                EnumTipoCalculoImposto.PIS => new StrategyCalculaImpostoPIS(),
                EnumTipoCalculoImposto.COFINS => new StrategyCalculaImpostoCOFINS(),
                EnumTipoCalculoImposto.ISS => new StrategyCalculaImpostoISS(),
                EnumTipoCalculoImposto.II => new StrategyCalculaImpostoII(),
                _ => throw new NotImplementedException($"Tipo de Cálculo de Imposto {enumTipoCalculoImposto} não implementado."),
            };
            return tipoCalculoImpost.CalculaImposto();
        }
    }
}
