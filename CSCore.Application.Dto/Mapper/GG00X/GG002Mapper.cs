using CSCore.Domain.CS_Models.CSICP_GG;
using GG104Materiais.C82Application.Dto.GG00X.GG002;

namespace GG104Materiais.C82Application.Mapper
{
    public static class GG002Mapper
    {
        public static DtoGetGG002 ToDtoGet(this CSICP_GG002 entity)
        {
            return new DtoGetGG002
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg002Filial = entity.Gg002Filial,
                Gg002Filialid = entity.Gg002Filialid,
                Gg002Desctipoproduto = entity.Gg002Desctipoproduto,
                Gg002PermiteVendas = entity.Gg002PermiteVendas,
                Gg002PermiteCompras = entity.Gg002PermiteCompras,
                Gg002Isactive = entity.Gg002Isactive,
                Gg002TipoprodId = entity.Gg002TipoprodId,
                NavSpedTipoItem = entity.NavSpedTipoItem,
            };
        }
    }
}


