using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF141;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Mapper.FF.FF1XX
{
    public static class FF141Mapper
    {
        public static DtoGetFF141 ToDtoGetFF141(this CSICP_FF141 entity)
        {
            if (entity == null) return null!;
            return new DtoGetFF141
            {
                TenantId = entity.TenantId,
                Ff141Id = entity.Ff141Id,
                Ff140RdId = entity.Ff140RdId,
                Ff141Descricao = entity.Ff141Descricao,
                Ff141Vunitario = entity.Ff141Vunitario,
                Ff141Qtd = entity.Ff141Qtd,
                Ff141Total = entity.Ff141Total
            };
        }
    }
}
