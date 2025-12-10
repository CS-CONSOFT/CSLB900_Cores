using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.CG.CG05X.CG051
{
    public class DtoCreateUpdateCG051 : IConverteParaEntidade<Osusr8dwCsicpCg051>
    {
        public long? Cg051Eventotpid { get; set; }

        public long? Cg051Parametrotpid { get; set; }

        public bool? Flobrigatorio { get; set; }

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