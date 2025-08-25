using CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF014;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Mapper.FF.FF01X
{
    public static class FF014Mapper
    {
        public static DtoGetFF014 ToDtoGet(this CSICP_FF014 entity)
        {
            return new DtoGetFF014
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff014Filialid = entity.Ff014Filialid,
                Ff014Handle = entity.Ff014Handle,
                Ff014Descricao = entity.Ff014Descricao,
                Ff014Comissaoid = entity.Ff014Comissaoid,
                Ff014Diasde = entity.Ff014Diasde,
                Ff014Diasate = entity.Ff014Diasate,
                Ff014Perccomissao = entity.Ff014Perccomissao
            };
        }
    }
}