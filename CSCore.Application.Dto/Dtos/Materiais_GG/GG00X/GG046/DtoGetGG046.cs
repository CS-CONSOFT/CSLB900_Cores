using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG520;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG046
{
    public class DtoGetGG046
    {
        public int TenantId { get; set; }

        public string Gg046Id { get; set; } = null!;

        public int? Gg046Seq { get; set; }

        public string? Gg045Id { get; set; }

        public string? Gg046SaldoentId { get; set; }

        public decimal? Gg046Qtd { get; set; }

        public int? Gg046StatId { get; set; }

        public int? Gg046EntsaiId { get; set; }

        public bool? Gg046Isnovo { get; set; }

        public string? Gg046Descricaosaldo { get; set; }

        public string? Gg046Codbarrasalfa { get; set; }

        public OSUSR_E9A_CSICP_GG046_ES? Gg046Entsai { get; set; }

        public DtoGetGG520Simples? Gg046Saldoent { get; set; }

        public OSUSR_E9A_CSICP_GG045_STAT? Gg046Stat { get; set; }
    }
}
