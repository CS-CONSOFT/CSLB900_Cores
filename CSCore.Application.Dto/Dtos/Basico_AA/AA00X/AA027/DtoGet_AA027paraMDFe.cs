using CSBS101._82Application.Dto.AA00X;
using CSCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Basico_AA.AA00X.AA027
{
    public class DtoGet_AA027paraMDFe
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
        public Dto_GetAA025? NavAA025PaisbyBB001 { get; set; }
    }
}
