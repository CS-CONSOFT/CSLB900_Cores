using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Application.Dto.Dtos.CG.CG05X.CG051
{
    public class DtoCreateUpdateCG051 : IConverteParaEntidade<Osusr8dwCsicpCg051>
    {
        [Required(ErrorMessage = "O ID do tipo de evento é obrigatório")]
        public long Cg051Eventotpid { get; set; }

        [Required(ErrorMessage = "O ID do parâmetro é obrigatório")]
        public long Cg051Parametrotpid { get; set; }

        [Required(ErrorMessage = "O campo 'Flobrigatorio' é obrigatório")]
        public bool? Flobrigatorio { get; set; } //verificar

        public Osusr8dwCsicpCg051 ToEntity(int tenant, string? _)
        {
            return new Osusr8dwCsicpCg051
            {
                TenantId = tenant,
                Cg051Eventotpid = this.Cg051Eventotpid,
                Cg051Parametrotpid = this.Cg051Parametrotpid,
                Flobrigatorio = this.Flobrigatorio
            };
        }
    }
}