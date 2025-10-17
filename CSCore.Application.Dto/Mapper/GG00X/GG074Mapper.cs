using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG074;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Application.Dto.Mapper.GG00X;
using CSCore.Application.Dto.Mapper.GG00X;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG074Mapper
    {
        public static DtoGetGG074 ToDtoGet(this CSICP_GG074 entity)
        {
            return new DtoGetGG074
            {
                TenantId = entity.TenantId,
                Gg074Id = entity.Gg074Id,
                Gg073Id = entity.Gg073Id,
                Gg074Codbarrasalfa = entity.Gg074Codbarrasalfa,
                Gg074KardexId = entity.Gg074KardexId,
                Gg074Saldoid = entity.Gg074Saldoid,
                Gg074UnId = entity.Gg074UnId,
                Gg074Qtd = entity.Gg074Qtd,
                Gg074Vunitario = entity.Gg074Vunitario,
                Gg074Statusestqid = entity.Gg074Statusestqid,
                Gg074Tmovid = entity.Gg074Tmovid,
                Gg074Tproduto = entity.Gg074Tproduto,
                NavGG073 = entity.NavGG073?.ToDtoGet(),
                NavGG008Kdx = entity.NavGG008Kdx?.ToDtoGet(),
                NavGG520 = entity.NavGG520?.ToDtoGetSimples(),
                NavGG007 = entity.NavGG007?.ToDtoGetSimples(),
                NavGG072Stq = entity.NavGG072Stq,
                NavGG073TpMov = entity.NavGG073TpMov,
            };
        }
    }
}


