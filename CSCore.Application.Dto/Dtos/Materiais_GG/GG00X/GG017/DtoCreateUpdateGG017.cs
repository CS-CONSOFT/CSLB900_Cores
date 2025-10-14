using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG017
{
    public class DtoCreateUpdateGG017 : IConverteParaEntidade<CSICP_GG017>
    {
        public string? Gg017Desccategoria { get; set; }

        public long? Gg017CategoriapaiId { get; set; }

        public CSICP_GG017 ToEntity(int tenant, string? _)
        {
            return new CSICP_GG017
            {
                TenantId = tenant,
                Gg017Desccategoria = this.Gg017Desccategoria,
                Gg017CategoriapaiId = this.Gg017CategoriapaiId,
            };
        }
    }
}
