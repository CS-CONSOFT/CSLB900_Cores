using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF007
{
    public class DtoGetFF007
    {
        public int TenantId { get; set; }
        public long Ff007Id { get; set; }
        public string? Ff007Estabid { get; set; }
        public int? Ff007Diasate { get; set; }
        public decimal? Ff007Pdesconto { get; set; }
        public Dto_GetBB001Simples? NavBB001 { get; set; }
    }
}
