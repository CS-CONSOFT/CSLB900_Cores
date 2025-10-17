using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG037
{
    public class DtoGetGG037
    {
        public int TenantId { get; set; }

        public string Gg037Id { get; set; } = null!;

        public string? Gg037FilialId { get; set; }

        public string? Gg037InventarioId { get; set; }

        public string? Gg037SaldoId { get; set; }

        public decimal? Gg037QtdNconfirmidade { get; set; }

        public bool? Gg037GeradoListaInv { get; set; }
    }
}
