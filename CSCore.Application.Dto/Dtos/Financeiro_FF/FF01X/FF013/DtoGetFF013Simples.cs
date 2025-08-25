using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF013
{
    public class DtoGetFF013Simples
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = null!;
        public string? Ff013Filialid { get; set; }
        public string? Ff013Grupocobrancaid { get; set; }
        public string? Ff013Cobradorid { get; set; }
        public string? Ff013Zonaid { get; set; }
        public string? Ff013Contaid { get; set; }
        public int? Ff013Tpregistro { get; set; }
    }
}
