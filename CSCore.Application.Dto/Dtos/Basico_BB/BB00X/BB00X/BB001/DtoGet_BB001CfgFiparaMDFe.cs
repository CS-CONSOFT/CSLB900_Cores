using CSCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB00X.BB001
{
    public class DtoGet_BB001CfgFiparaMDFe
    {
        public int TenantId { get; set; }

        public string Bb001CfgId { get; set; } = null!;

        public string? Bb001EmpresaId { get; set; }

        public int? Bb001TptributacaoId { get; set; }

        public decimal? Bb001PercIcms { get; set; }

        public decimal? Bb001PercCsllBc { get; set; }

        public decimal? Bb001PercCsllBcServico { get; set; }

        public decimal? Bb001PercIrpjBc { get; set; }

        public decimal? Bb001PercIrpjBcServico { get; set; }

        public int? Bb001NaturezapjId { get; set; }

        public int? Bb001TpatividadeId { get; set; }

        public int? Bb001Regimetributarioid { get; set; }

        public CSICP_AA030Regime? NavAA030byBB001Regimetributario { get; set; }
    }
}
