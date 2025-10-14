using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG029
{
    public class DtoGetGG029
    {
        public int TenantId { get; set; }

        public string Gg029Id { get; set; } = null!;

        public string? Gg029Codganp { get; set; }

        public string? Gg029Descricao { get; set; }

        public string? Gg029Codif { get; set; }

        public decimal? Gg029Pmixgn { get; set; }

        public decimal? Gg029Pglp { get; set; }

        public decimal? Gg029Pgnn { get; set; }

        public decimal? Gg029Pgni { get; set; }

        public decimal? Gg029Vpart { get; set; }

        public decimal? Gg029Adremicms { get; set; }

        public decimal? Gg029Pbio { get; set; }

        public decimal? Gg029AdremicmsBio { get; set; }
    }
}
