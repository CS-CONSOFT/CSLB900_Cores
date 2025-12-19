using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG08X.CG082
{
    public class DtoGetCG082Padrao
    {
        public int TenantId { get; set; }

        public long Cg082Id { get; set; }

        public long? Cg082Contrelregid { get; set; }

        public string? Cg082Contcontaid { get; set; }

        public DateTime? Cg082Dateinicial { get; set; }

        public DateTime? Cg082Datefinal { get; set; }
    }
}
