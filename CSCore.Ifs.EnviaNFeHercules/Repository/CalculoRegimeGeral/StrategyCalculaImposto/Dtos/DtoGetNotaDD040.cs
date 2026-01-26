using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.StrategyCalculaImposto.Dtos
{
    public record DtoGetNotaDD040(int? Bb001TptributacaoId, string? Bb012_RFEspecial_ID, int? DD040_TPDEBCREID, string? ID, DateTime DD040_Data_Emissao, int? TipoNotaID)
    {
        public bool TpDebCreVazio() => DD040_TPDEBCREID == null;

    }
    
}
