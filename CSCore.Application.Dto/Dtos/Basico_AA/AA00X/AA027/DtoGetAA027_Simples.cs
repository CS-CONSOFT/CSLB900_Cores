using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Basico_AA.AA00X.AA027
{
    public class DtoGetAA027_Simples
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
    }
}
