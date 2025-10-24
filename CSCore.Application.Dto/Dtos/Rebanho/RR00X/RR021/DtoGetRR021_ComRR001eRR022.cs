using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR001;
using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR022;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR021
{
    public class DtoGetRR021_ComRR001eRR022
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = null!;
        public string? Rr021Loteid { get; set; }
        public string? Rr021Animalid { get; set; }
        public DateTime? Rr021Dtregistro { get; set; }
        // Navegações
        public DtoGetRR001Padrao? NavRR001Animal { get; set; }
        public DtoGetRR022Padrao? NavRR022ControlePeso { get; set; }
    }
}
