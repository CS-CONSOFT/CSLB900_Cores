using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG05X.CG052
{
    public class DtoCreateUpdateCG052 : IConverteParaEntidade<Osusr8dwCsicpCg052>
    {

        public string? Cg052Txcodigo { get; set; }

        public string? Cg052Txdescricao { get; set; }

        public string? Cg052Txcomando { get; set; }

        public string? Cg052Txtabelas { get; set; }

        public int? Cg052Moduloid { get; set; }

        public Osusr8dwCsicpCg052 ToEntity(int tenant, string? _)
        {
            return new Osusr8dwCsicpCg052
            {
                TenantId = tenant,
                Cg052Txcodigo = this.Cg052Txcodigo,
                Cg052Txdescricao = this.Cg052Txdescricao,
                Cg052Txcomando = this.Cg052Txcomando,
                Cg052Txtabelas = this.Cg052Txtabelas,
                Cg052Moduloid = this.Cg052Moduloid
            };
        }
    }
}
