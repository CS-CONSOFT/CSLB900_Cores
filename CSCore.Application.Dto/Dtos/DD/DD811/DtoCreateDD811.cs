using CSCore.Domain.CS_Models.CSICP_DD;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.DD.DD811
{
    public record DtoCreateDD811 : IConverteParaEntidade<CSICP_DD811>
    {
        public int? Dd811CfopId { get; init; }
        public int? Dd811CstIcmsId { get; init; }
        public int? Dd811CstPisId { get; init; }
        public int? Dd811CstCofinsId { get; init; }
        public int? Dd811CstIpiId { get; init; }
        public string? Dd811Anotacao { get; init; }

        public CSICP_DD811 ToEntity(int tenant, string? id)
        {
            return new CSICP_DD811
            {
                TenantId = tenant,
                Dd811Id = id ?? string.Empty,
                Dd811CfopId = this.Dd811CfopId,
                Dd811CstIcmsId = this.Dd811CstIcmsId,
                Dd811CstPisId = this.Dd811CstPisId,
                Dd811CstCofinsId = this.Dd811CstCofinsId,
                Dd811CstIpiId = this.Dd811CstIpiId,
                Dd811Anotacao = this.Dd811Anotacao
            };
        }
    }
}