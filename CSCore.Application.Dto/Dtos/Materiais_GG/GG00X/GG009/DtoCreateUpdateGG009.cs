using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG009
{
    public class DtoCreateUpdateGG009 : IConverteParaEntidade<CSICP_GG009>
    {
        public string? Gg009Filiald { get; set; }

        public string? Gg009Codigopadrao { get; set; }

        public string? Gg009Descpadrao { get; set; }
        public bool? Gg009IsActive { get; set; }
        public CSICP_GG009 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG009
            {
                TenantId = tenant,
                Id = id!,
                Gg009Filial = 0,
                Gg009Filiald = this.Gg009Filiald,
                Gg009Codigopadrao = this.Gg009Codigopadrao,
                Gg009Descpadrao = this.Gg009Descpadrao,
                Gg009IsActive = Gg009IsActive,
            };

        }
    }
}
