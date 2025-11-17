using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.CG.CG070
{
    public class DtoCreateUpdateCG070 : IConverteParaEntidade<Osusr8dwCsicpCg070>
    {
        public DateTime? Cg070Datahora { get; set; }

        public int? Cg070Continstatusinterid { get; set; }

        public bool? Cg070Processalista { get; set; }

        public Osusr8dwCsicpCg070 ToEntity(int tenant, string? id)
        {
            return new Osusr8dwCsicpCg070
            {
                TenantId = tenant,
                Cg070Datahora = this.Cg070Datahora,
                Cg070Continstatusinterid = this.Cg070Continstatusinterid,
                Cg070Processalista = this.Cg070Processalista
            };
        }
    }
}