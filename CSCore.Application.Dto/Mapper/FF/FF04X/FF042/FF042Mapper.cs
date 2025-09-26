using CSCore.Application.Dto.Dtos.Financeiro_FF.FF04X.FF042;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF04X.FF043;
using CSCore.Application.Dto.Mapper.FF.FF04X.FF043;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Mapper.FF.FF04X.FF042
{
    public static class FF042Mapper
    {
        public static DtoGetFF042 ToDtoGet(this CSICP_FF042 entity)
        {
                return new DtoGetFF042
                {
                    TenantId = entity.TenantId,
                    Ff042Id = entity.Ff042Id,
                    Ff040Id = entity.Ff040Id,
                    Ff042Fpagtoid = entity.Ff042Fpagtoid,
                    Ff042ValorPago = entity.Ff042ValorPago,
                    Ff042Qtd = entity.Ff042Qtd,
                    Ff042ValorTotalpago = entity.Ff042ValorTotalpago,
                    Ff042ValorTroco = entity.Ff042ValorTroco,
                    Ff042Condicaoid = entity.Ff042Condicaoid,
                    Ff042Nroparcelas = entity.Ff042Nroparcelas,
                    Ff042Valor1aparcela = entity.Ff042Valor1aparcela,
                    Ff042DataMovimento = entity.Ff042DataMovimento,
                    Ff042ChaveVincId = entity.Ff042ChaveVincId,
                    NavListFF043 = entity.NavListFF043?.Select(e => e.ToDtoGet()).ToList() ?? new List<DtoGetFF043>()
                };
        }
    }
}
