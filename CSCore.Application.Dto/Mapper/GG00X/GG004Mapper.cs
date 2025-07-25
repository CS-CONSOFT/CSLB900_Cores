using CSCore.Domain.CS_Models.CSICP_GG;
using GG104Materiais.C82Application.Dto.GG00X.GG004;

namespace GG104Materiais.C82Application.Mapper
{
    public static class GG004Mapper
    {
        public static DtoGetGG004 ToDtoGet(this CSICP_GG004 entity)
        {
            return new DtoGetGG004
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg004Filial = entity.Gg004Filial,
                Gg004Filialid = entity.Gg004Filialid,
                Gg004Codigoclasse = entity.Gg004Codigoclasse,
                Gg004Descclasse = entity.Gg004Descclasse,
                Gg004Isactive = entity.Gg004Isactive,
                NavBB001Filial = entity.NavBB001Filial,
            };
        }

        public static DtoGetGG004Simples ToDtoGetSemFilial(this CSICP_GG004 entity)
        {
            return new DtoGetGG004Simples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg004Filial = entity.Gg004Filial,
                Gg004Filialid = entity.Gg004Filialid,
                Gg004Codigoclasse = entity.Gg004Codigoclasse,
                Gg004Descclasse = entity.Gg004Descclasse,
                Gg004Isactive = entity.Gg004Isactive
            };
        }
    }
}


