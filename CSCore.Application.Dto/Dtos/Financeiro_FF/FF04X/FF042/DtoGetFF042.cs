using CSCore.Application.Dto.Dtos.Financeiro_FF.FF04X.FF043;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF04X.FF042
{
    public class DtoGetFF042
    {
        public int TenantId { get; set; }

        public long Ff042Id { get; set; }

        public long? Ff040Id { get; set; }

        public string? Ff042Fpagtoid { get; set; }

        public decimal? Ff042ValorPago { get; set; }

        public int? Ff042Qtd { get; set; }

        public decimal? Ff042ValorTotalpago { get; set; }

        public decimal? Ff042ValorTroco { get; set; }

        public string? Ff042Condicaoid { get; set; }

        public int? Ff042Nroparcelas { get; set; }

        public decimal? Ff042Valor1aparcela { get; set; }

        public DateTime? Ff042DataMovimento { get; set; }

        public string? Ff042ChaveVincId { get; set; }

        public List<DtoGetFF043> NavListFF043 { get; set; } = new List<DtoGetFF043>();
    }
}
