using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.CG.CG007
{
    public class DtoCreateUpdateCG007 : IConverteParaEntidade<Osusr8dwCsicpCg007>
    {
        public string? Cg007FilialId { get; set; }

        public string? Cg007Codigo { get; set; }

        public string? Cg007Descricao { get; set; }

        public string? Cg007Objetivo { get; set; }

        public bool? Cg007Isactive { get; set; }

        public DateTime? Cg007DataInicio { get; set; }

        public DateTime? Cg007DataFim { get; set; }

        public string? Cg007UserpropId { get; set; }

        public int? Cg007StatusId { get; set; }

        public Osusr8dwCsicpCg007 ToEntity(int tenant, string? id)
        {
            return new Osusr8dwCsicpCg007
            {
                TenantId = tenant,
                Cg007Id = id!,
                Cg007FilialId = this.Cg007FilialId,
                Cg007Codigo = this.Cg007Codigo,
                Cg007Descricao = this.Cg007Descricao,
                Cg007Objetivo = this.Cg007Objetivo,
                Cg007Isactive = this.Cg007Isactive,
                Cg007DataInicio = this.Cg007DataInicio,
                Cg007DataFim = this.Cg007DataFim,
                Cg007UserpropId = this.Cg007UserpropId,
                Cg007StatusId = this.Cg007StatusId
            };
        }
    }
}