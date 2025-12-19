using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG05X.CG054
{
    public class DtoCreateUpdateCG054 : IConverteParaEntidade<Osusr8dwCsicpCg054>
    {
        [Required(ErrorMessage = "O ID do tipo de evento é obrigatório")]
        public long Cg054Eventotpid { get; set; }

        [Required(ErrorMessage = "O ID do valor é obrigatório")]
        public long Cg054Valortpid { get; set; }

        public Osusr8dwCsicpCg054 ToEntity(int tenant, string? _)
        {
            return new Osusr8dwCsicpCg054
            {
                TenantId = tenant,
                Cg054Eventotpid = this.Cg054Eventotpid,
                Cg054Valortpid = this.Cg054Valortpid
            };
        }
    }
}
