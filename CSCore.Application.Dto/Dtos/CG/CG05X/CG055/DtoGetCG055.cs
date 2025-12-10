using CSCore.Domain.CS_Models.Staticas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG05X.CG055
{
    public class DtoGetCG055
    {
        public int TenantId { get; set; }

        public long Cg055Id { get; set; }

        public string? Cg055Txcodigo { get; set; }

        public string? Cg055Txdescricao { get; set; }

        public int? Cg055Moduloid { get; set; }

        public OsusrNnxCsicpModulo? NavModuloID_CG055 { get; set; }
    }
}
