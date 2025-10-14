using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG006
{
    public class DtoCreateUpdateGG006 : IConverteParaEntidade<CSICP_GG006>
    {
        public string? Gg006Filial { get; set; }

        public int? Gg006Codigomarca { get; set; }

        public string? Gg006Descmarca { get; set; }
        public bool? Gg006IsActive { get; set; } = true;
        public CSICP_GG006 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG006
            {
                TenantId = tenant,
                Id = id!,
                Gg006Filial = Gg006Filial,

                Gg006Codgfilial = 0,
                Gg006Codigomarca = Gg006Codigomarca,
                Gg006Descmarca = Gg006Descmarca,
                Gg006IsActive = Gg006IsActive,
            };
        }
    }
}
