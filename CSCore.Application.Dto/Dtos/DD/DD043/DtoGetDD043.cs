using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Dto.DD.DD043
{
    public class DtoGetDD043
    {
        public int TenantId { get; set; }

        public string Dd043Id { get; set; } = null!;

        public string? Dd042Id { get; set; }

        public int? Dd043Parcela { get; set; }

        public DateTime? Dd043DataVencto { get; set; }

        public decimal? Dd043ValorParcela { get; set; }

        public string? Dd043NoCartao { get; set; }

        public int? Dd043Banco { get; set; }

        public decimal? Dd043Agencia { get; set; }

        public string? Dd043Dvagencia { get; set; }

        public decimal? Dd043Conta { get; set; }

        public string? Dd043Dvconta { get; set; }

        public int? Dd043Cheque { get; set; }

        public decimal? Dd043Rg { get; set; }

        public string? Dd043Telefone { get; set; }

        public bool? Dd043Compensacao { get; set; }

        public bool? Dd043ChequeTerceiro { get; set; }

        public DateTime? Dd043DataVenctoOri { get; set; }

        public string? Dd043UsuarioidAltdtvc { get; set; }
    }
}
