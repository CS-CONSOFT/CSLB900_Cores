using CSCore.Domain;

namespace CSBS101._82Application.Dto.AA00X
{
    public class Dto_GetAA028
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Aa028Cidade { get; set; }

        public decimal? Aa028Percicmscontrib { get; set; }

        public decimal? A028Percicmsncontrib { get; set; }

        public decimal? A028Percsubsttribut { get; set; }

        public string? A028Mascinsestadual { get; set; }

        public decimal? A028Percicmsentrada { get; set; }

        public string? A028Mascieimpressao { get; set; }

        public int? Aa028Codgibge { get; set; }

        public int? Aa028Zonafranca { get; set; }

        public int? Aa028Estadobrasil { get; set; }

        public string? Ufid { get; set; }

        public string? Aa028ExportCidadeid { get; set; }

        public string? Aa027ExportUfid { get; set; }

        public CSICP_Aa027? NavUf { get; set; }
        public CSICP_Statica? NavUFBrasil { get; set; }
        public CSICP_Statica? NavZonaFranca { get; set; }
    }

    public class Dto_GetAA028_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Aa028Cidade { get; set; }

        public int? Aa028Codgibge { get; set; }

    }
}
