using CSCore.Domain;

namespace CSBS101._82Application.Dto.AA00X
{
    public class Dto_GetAA027
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Aa027Sigla { get; set; }

        public string? Descricao { get; set; }

        public decimal? Aa027Percicmscontrib { get; set; }

        public decimal? Aa027Percicmsncontrib { get; set; }

        public decimal? Aa027Percsubsttribut { get; set; }

        public string? Aa027Mascinsestadual { get; set; }

        public decimal? Aa027Percicmsentrada { get; set; }

        public string? Aa027Mascieimpressao { get; set; }

        public int? Aa027Codigoibge { get; set; }

        public string? Paisid { get; set; }

        public string? Regiaoid { get; set; }

        public string? Aa027Naturalidade { get; set; }

        public string? Aa027ExportUfid { get; set; }

        public string? Aa025ExportPaisid { get; set; }

        public string? Aa026ExportRegiaoid { get; set; }
        public CSICP_Aa025? Pais { get; set; }

        public CSICP_Aa026? Regiao { get; set; }
    }
}
