using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG05X.CG052
{
    public class DtoGetCG052Padrao
    {
        public int TenantId { get; set; }

        public long Cg052Id { get; set; }

        public string? Cg052Txcodigo { get; set; }

        public string? Cg052Txdescricao { get; set; }

        public string? Cg052Txcomando { get; set; }

        public string? Cg052Txtabelas { get; set; }

        public int? Cg052Moduloid { get; set; }
    }
}
