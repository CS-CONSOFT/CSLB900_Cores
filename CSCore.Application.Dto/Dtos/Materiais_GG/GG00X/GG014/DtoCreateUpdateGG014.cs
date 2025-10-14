using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG014
{
    public class DtoCreateUpdateGG014 : IConverteParaEntidade<CSICP_GG014>
    {
        public string? Gg014Filialid { get; set; }

        public string? Gg014Linha { get; set; }
        public bool? Gg014IsActive { get; set; }
        public CSICP_GG014 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG014
            {
                TenantId = tenant,
                Id = id!,
                Gg014Filialid = this.Gg014Filialid,
                Gg014Linha = this.Gg014Linha,
                Gg014IsActive = Gg014IsActive,
            };
        }
    }
}
