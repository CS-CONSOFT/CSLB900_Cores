using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.DD
{
    public class DtoCreateUpdateDD156 : IConverteParaEntidade<CSICP_DD156>
    {
        public string? Gg008Produtoid { get; set; }

        public int? Dd156Regramontgid { get; set; }

        public decimal? Dd156Vunitmontagem { get; set; }

        public decimal? Dd156Psobrefaturliq { get; set; }

        public int? Dd156Tempoestimado { get; set; }

        public int? Dd156Qmontador { get; set; }

        public bool? Dd156Isautomatico { get; set; }

        public CSICP_DD156 ToEntity(int tenant, string? id)
        {
            return new CSICP_DD156
            {
                TenantId = tenant,
                Dd156Id = id!,
                Gg008Produtoid = Gg008Produtoid,
                Dd156Regramontgid = Dd156Regramontgid,
                Dd156Vunitmontagem = Dd156Vunitmontagem,
                Dd156Psobrefaturliq = Dd156Psobrefaturliq,
                Dd156Tempoestimado = Dd156Tempoestimado,
                Dd156Qmontador = Dd156Qmontador,
                Dd156Isautomatico = Dd156Isautomatico
            };
        }
    }
}
