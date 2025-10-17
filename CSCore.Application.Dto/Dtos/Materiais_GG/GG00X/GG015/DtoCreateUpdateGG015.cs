using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG015
{
    public class DtoCreateUpdateGG015 : IConverteParaEntidade<CSICP_GG015>
    {
        public string? Gg015Filialid { get; set; }

        public string? Gg015Subgrupo { get; set; }
        public string GG003_GrupoID { get; set; } = string.Empty;

        public bool? Gg015IsActive { get; set; }

        public CSICP_GG015 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG015
            {
                TenantId = tenant,
                Id = id!,
                Gg015Filialid = this.Gg015Filialid,
                Gg015Subgrupo = this.Gg015Subgrupo,
                Gg015IsActive = this.Gg015IsActive,
            };
        }
    }
}
