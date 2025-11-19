using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.CG.CG008
{
    public class DtoCreateUpdateCG008 : IConverteParaEntidade<CSICP_CG008>
    {
        public int? Cg008Cod { get; set; }
        public string? Cg008Descricao { get; set; }
        public string? Cg008Descresumida { get; set; }
        public bool? Cg008Isactive { get; set; }
        public CSICP_CG008 ToEntity(int tenantId, string? id)
        {
            return new CSICP_CG008
            {
                TenantId = tenantId,
                Cg008Id = id!,
                Cg008Cod = this.Cg008Cod,
                Cg008Descricao = this.Cg008Descricao,
                Cg008Descresumida = this.Cg008Descresumida,
                Cg008Isactive = this.Cg008Isactive
            };
        }
    }
}