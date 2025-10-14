using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG037;

namespace FF105Financeiro.C82Application.Mapper
{
    public static class GG037Mapper
    {
        public static DtoGetGG037 ToDtoGet(this CSICP_GG037 entity)
        {
            return new DtoGetGG037
            {
                TenantId = entity.TenantId,
                Gg037Id = entity.Gg037Id,
                Gg037FilialId = entity.Gg037FilialId,
                Gg037InventarioId = entity.Gg037InventarioId,
                Gg037SaldoId = entity.Gg037SaldoId,
                Gg037QtdNconfirmidade = entity.Gg037QtdNconfirmidade,
                Gg037GeradoListaInv = entity.Gg037GeradoListaInv,
            };
        }
    }
}
