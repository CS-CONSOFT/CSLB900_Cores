using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.TT.TT0XX.TT031
{
    public class DtoGetTT031
    {
        public int TenantId { get; set; }

        public long Tt031Id { get; set; }

        public long? Tt030Id { get; set; }

        public string? CsCodgproduto { get; set; }

        public decimal? CsQtd { get; set; }

        public decimal? CsValor { get; set; }

        public decimal? CsDesc { get; set; }

        public string? Gg008Id { get; set; }

        public string? Gg008kdxId { get; set; }

        public string? Gg520Id { get; set; }

        public string? Campoespecial1 { get; set; }

        public string? Campoespecial2 { get; set; }
        public string? Gg008Descreduzida { get; set; }
        public string? Gg001Descalmox { get; set; }
        public decimal? Gg520NsNumerosaldo { get; set; }
        public string? GG007UnidadeID{ get; set; }
    }
}
