using CSBS101._82Application.Dto.BB00X.BB024;
using CSBS101._82Application.Dto.BB00X.BB027;
using CSCore.Domain;

namespace CSBS101._82Application.Dto.BB00X.BB025
{
    public class Dto_GetBB025
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb025Filial { get; set; }

        public string? Bb025Codigo { get; set; }

        public string? Bb025Descricao { get; set; }

        public int? Bb025GeraDuplicata { get; set; }

        public int? Bb025UsaTabelaPreco { get; set; }

        public int? Bb025Codtptransacao { get; set; }

        public string? Bb025Transacaoid { get; set; }

        public int? Bb025GrupoContabil { get; set; }

        public string? Bb025Moddoctofiscal { get; set; }

        public string? Bb025Cfopdentroestado { get; set; }

        public string? Bb025Cfopforaestado { get; set; }

        public int? Bb025Baixaestoque { get; set; }

        public string? Empresaid { get; set; }

        public bool? Bb025Isactive { get; set; }

        public int? Bb025ModdoctofiscalId { get; set; }

        public int? Bb025Valorizarprecoid { get; set; }

        public Dto_GetBB027? NavBb025Transacao { get; set; }
        public Osusr66cSpedInAjIcm? NavSpedICMS { get; set; }
        public List<Dto_GetBB024>? NavListbb024_Natureza_CFOP { get; set; } = [];
    }

    public class Dto_GetBB025_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Bb025Codigo { get; set; }

        public string? Bb025Descricao { get; set; }
    }
}
