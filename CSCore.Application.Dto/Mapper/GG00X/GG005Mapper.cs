using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG005;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG005Mapper
    {
        public static DtoGetGG005 ToDtoGet(this CSICP_GG005 entity)
        {
            return new DtoGetGG005
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg005Filial = entity.Gg005Filial,
                Gg005Filialid = entity.Gg005Filialid,
                Gg005Codigoartigo = entity.Gg005Codigoartigo,
                Gg005Descartigo = entity.Gg005Descartigo,
                Gg005Isactive = entity.Gg005Isactive,
                Gg005PesoLe = entity.Gg005PesoLe,
                NavBB001Estabelecimento = entity.NavBB001Estabelecimento,
            };
        }

        public static DtoGetGG005Simples ToDtoGetSemFilial(this CSICP_GG005 entity)
        {
            return new DtoGetGG005Simples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg005Filial = entity.Gg005Filial,
                Gg005Filialid = entity.Gg005Filialid,
                Gg005Codigoartigo = entity.Gg005Codigoartigo,
                Gg005Descartigo = entity.Gg005Descartigo,
                Gg005Isactive = entity.Gg005Isactive,
                Gg005PesoLe = entity.Gg005PesoLe
            };
        }
    }
}
