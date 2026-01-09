using CSLB900.MSTools.InterfaceBase;
using CSCore.Domain.CS_Models.CSICP_DD;

namespace CSCore.Application.Dto.Dtos.DD.DD811
{
    public record DtoGetListDD811 : IConverteParaDTO<CSICP_DD811, DtoGetListDD811>
    {
        public int TenantId { get; init; }
        public string Dd811Id { get; init; } = null!;
        public int? Dd811CfopId { get; init; }
        public int? Dd811CstIcmsId { get; init; }
        public int? Dd811CstPisId { get; init; }
        public int? Dd811CstCofinsId { get; init; }
        public int? Dd811CstIpiId { get; init; }
        public string? Dd811Anotacao { get; init; }
        public string? Dd811Hashid { get; init; }

        public static DtoGetListDD811 FromEntity(CSICP_DD811 entity)
        {
            return new DtoGetListDD811
            {
                TenantId = entity.TenantId,
                Dd811Id = entity.Dd811Id,
                Dd811CfopId = entity.Dd811CfopId,
                Dd811CstIcmsId = entity.Dd811CstIcmsId,
                Dd811CstPisId = entity.Dd811CstPisId,
                Dd811CstCofinsId = entity.Dd811CstCofinsId,
                Dd811CstIpiId = entity.Dd811CstIpiId,
                Dd811Anotacao = entity.Dd811Anotacao,
                Dd811Hashid = entity.Dd811Hashid
            };
        }
    }
}