using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG05X.CG055
{
    public class DtoCreateUpdateCG055 : IConverteParaEntidade<Osusr8dwCsicpCg055>
    {
        public string? Cg055Txcodigo { get; set; }

        public string? Cg055Txdescricao { get; set; }

        public int? Cg055Moduloid { get; set; }
        public Osusr8dwCsicpCg055 ToEntity(int tenant, string? _)
        {
            return new Osusr8dwCsicpCg055             
            {
                TenantId = tenant,
                Cg055Txcodigo = this.Cg055Txcodigo,
                Cg055Txdescricao = this.Cg055Txdescricao,
                Cg055Moduloid = this.Cg055Moduloid,
            };
        }
    }
}
