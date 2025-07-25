using CSCore.Domain.CS_Models.CSICP_DD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Dto.DD.DD060
{
    public class DtoGetDD060Comb
    {
        public int TenantId { get; set; }

        public long Id { get; set; }

        public string? Dd060Id { get; set; }

        public string? Indimport { get; set; }

        public string? Cuforig { get; set; }

        public decimal? Porig { get; set; }
    }
}
