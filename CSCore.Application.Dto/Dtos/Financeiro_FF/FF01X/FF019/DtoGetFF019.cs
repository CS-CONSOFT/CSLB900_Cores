using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF019
{
    public class DtoGetFF019
    {
        public int TenantId { get; set; }

        public long Ff019Id { get; set; }

        public string? Ff000Id { get; set; }

        public string? Ff019FpagtoId { get; set; }

        public string? Ff019Condicaoid { get; set; }

        public virtual CSICP_FF000? Ff000 { get; set; }
    }
}
