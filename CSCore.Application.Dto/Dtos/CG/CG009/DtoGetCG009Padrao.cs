using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG009
{
    public class DtoGetCG009Padrao
    {
        public int TenantId { get; set; }

        public string Cg009Id { get; set; } = null!;

        public string? Cg009FilialId { get; set; }

        public string? Cg009TipoSaldoId { get; set; }

        public string? Cg009ContaId { get; set; }

        public int? Cg009Ano { get; set; }

        public int? Cg009Mes { get; set; }

        public decimal? Cg009Totaldebito { get; set; }

        public decimal? Cg009Totalcredito { get; set; }

        public decimal? Cg009Saldo { get; set; }
    }
}
