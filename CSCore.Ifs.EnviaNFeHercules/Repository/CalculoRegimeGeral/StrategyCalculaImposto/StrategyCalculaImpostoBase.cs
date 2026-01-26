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

        public static decimal GetTipoCalculoImposto(
    EnumTipoCalculoImposto enumTipoCalculoImposto,
    decimal DD061_CurrentImposto,
    decimal VlrBaseCalcImposto,
    decimal dd061_vICMSUFDest,
    decimal dd061_vFCP,
    decimal dd061_vFCPUFDest,
    decimal N39_vICMSMono)
        {
            ICalculaImposto tipoCalculoImpost = enumTipoCalculoImposto switch
            {
                EnumTipoCalculoImposto.PIS => new StrategyCalculaImpostoPIS(),
                EnumTipoCalculoImposto.COFINS => new StrategyCalculaImpostoCOFINS(),
                EnumTipoCalculoImposto.ISS => new StrategyCalculaImpostoISS(),
                EnumTipoCalculoImposto.II => new StrategyCalculaImpostoII(),
                EnumTipoCalculoImposto.ICMS => new StrategyCalculaImpostoICMS(dd061_vICMSUFDest, dd061_vFCP, dd061_vFCPUFDest, N39_vICMSMono),
                EnumTipoCalculoImposto.None => new StrategyNoneCalcula(),
                _ => throw new NotImplementedException($"Tipo de Cálculo de Imposto {enumTipoCalculoImposto} não implementado."),
            };
            return tipoCalculoImpost.CalculaImposto(DD061_CurrentImposto, VlrBaseCalcImposto);
        }

        /// <summary>
        /// Determina o EnumTipoCalculoImposto com base no ID do imposto e nas entidades correspondentes.
        /// Isso é usado no padrão Strategy para selecionar a estratégia correta de cálculo de imposto.
        /// </summary>
        public static EnumTipoCalculoImposto GetEnumTipoCalculoImposto(
            int? DD061_Imposto_ID,
            int? Entities_ICMS,
            int? Entities_PIS,
            int? Entities_COFINS,
            int? Entities_ISS,
            int? Entities_II)
        {
            return DD061_Imposto_ID switch
            {
                var id when id == Entities_PIS => EnumTipoCalculoImposto.PIS,
                var id when id == Entities_COFINS => EnumTipoCalculoImposto.COFINS,
                var id when id == Entities_ISS => EnumTipoCalculoImposto.ISS,
                var id when id == Entities_II => EnumTipoCalculoImposto.II,
                var id when id == Entities_ICMS => EnumTipoCalculoImposto.ICMS,
                _ => EnumTipoCalculoImposto.None,
            };
        }
    }
}
