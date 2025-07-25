using CSCore.Application.Dto.Dtos.DD;
using CSCore.Domain.CS_Models.CSICP_DD;

namespace CSCore.Application.Dto.Mapper.DD
{
    public static class DD156ExtensionMethods
    {
        public static DtoGetDD156 ToDtoGet(this CSICP_DD156 entity)
        {
            return new DtoGetDD156
            { Dd156Id = entity.Dd156Id,
                Gg008Produtoid = entity.Gg008Produtoid,
                Dd156Regramontgid = entity.Dd156Regramontgid,
                Dd156Vunitmontagem = entity.Dd156Vunitmontagem,
                Dd156Psobrefaturliq = entity.Dd156Psobrefaturliq,
                Dd156Tempoestimado = entity.Dd156Tempoestimado,
                Dd156Qmontador = entity.Dd156Qmontador,
                Dd156Isautomatico = entity.Dd156Isautomatico
            };

        }
    }
}
