using CSCore.Application.Dto.Dtos.CG.CG021;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Mapper.CG.CG00X
{
    public static class CG021Mapper
    {
        public static DtoGetCG021 ToDtoGet(this Osusr8dwCsicpCg021 entity)
        {
            return new DtoGetCG021
            {
                TenantId = entity.TenantId,
                Cg021Id = entity.Cg021Id,
                Cg021FilialId = entity.Cg021FilialId,
                Cg021LoteId = entity.Cg021LoteId,
                Cg021Nrolancamento = entity.Cg021Nrolancamento,
                Cg021Seq = entity.Cg021Seq,
                Cg021ConsolidarFilialId = entity.Cg021ConsolidarFilialId,
                Cg021Data = entity.Cg021Data,
                Cg021ContacontabilId = entity.Cg021ContacontabilId,
                Cg021Debcre = entity.Cg021Debcre,
                Cg021Nrodocumento = entity.Cg021Nrodocumento,
                Cg021Valorlancto = entity.Cg021Valorlancto,
                Cg021HistoricoId = entity.Cg021HistoricoId,
                Cg021Historico = entity.Cg021Historico,
                Cg021CtagerencialN2Id = entity.Cg021CtagerencialN2Id,
                Cg021CtagerencialN3Id = entity.Cg021CtagerencialN3Id,
                Cg021CtagerencialN4Id = entity.Cg021CtagerencialN4Id,
                Cg021TiposaldoId = entity.Cg021TiposaldoId,
                Cg021Consolidar = entity.Cg021Consolidar,
                Cg021Isconsolidado = entity.Cg021Isconsolidado,
                Cg021Contacontabil = entity.Cg021Contacontabil,
                Cg021Valorlanctoant = entity.Cg021Valorlanctoant,
                Cg021ProjetoId = entity.Cg021ProjetoId,
                Nn010Id = entity.Nn010Id,
                Nn015Id = entity.Nn015Id,
                Cg021Protocolo = entity.Cg021Protocolo,
                Cg021Sequencia = entity.Cg021Sequencia

            };
        }
    }
}