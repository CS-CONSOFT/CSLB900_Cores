using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR009
{
    public class DtoGetRR009Simples
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string Rr001Id { get; set; } = null!;

        public string Rr001Virtualid { get; set; } = null!;
    }
}
