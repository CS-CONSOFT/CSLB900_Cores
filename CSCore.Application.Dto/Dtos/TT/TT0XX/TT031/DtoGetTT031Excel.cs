using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.TT.TT0XX.TT031
{
    public class DtoGetTT031Excel
    {
        public int TenantId { get; set; }

        public long Tt031Id { get; set; }

        public string? CsCodgproduto { get; set; }

        public decimal? CsQtd { get; set; }

        public decimal? CsValor { get; set; }

        public decimal? CsDesc { get; set; }
    }
}
