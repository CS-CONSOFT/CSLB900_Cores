using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.CG.CG021
{
    public class DtoCreateCG021 : IConverteParaEntidade<Osusr8dwCsicpCg021>
    {
        public string? Cg021FilialId { get; set; }

        public string? Cg021LoteId { get; set; }

        public int? Cg021Nrolancamento { get; set; }

        public int? Cg021Seq { get; set; }

        public string? Cg021ConsolidarFilialId { get; set; }

        public DateTime? Cg021Data { get; set; }

        public string? Cg021ContacontabilId { get; set; }

        public int? Cg021Debcre { get; set; }

        public string? Cg021Nrodocumento { get; set; }

        public decimal? Cg021Valorlancto { get; set; }

        public string? Cg021HistoricoId { get; set; }

        public string? Cg021Historico { get; set; }

        public string? Cg021CtagerencialN2Id { get; set; }

        public string? Cg021CtagerencialN3Id { get; set; }

        public string? Cg021CtagerencialN4Id { get; set; }

        public string? Cg021TiposaldoId { get; set; }

        public int? Cg021Consolidar { get; set; }

        public bool? Cg021Isconsolidado { get; set; }

        public string? Cg021Contacontabil { get; set; }

        public decimal? Cg021Valorlanctoant { get; set; }

        public string? Cg021ProjetoId { get; set; }

        public string? Nn010Id { get; set; }

        public string? Nn015Id { get; set; }

        public long? Cg021Protocolo { get; set; }

        public int? Cg021Sequencia { get; set; }

        public Osusr8dwCsicpCg021 ToEntity(int tenant, string? id)
        {
            return new Osusr8dwCsicpCg021
            {
                TenantId = tenant,
                Cg021Id = id!,
                Cg021LoteId = this.Cg021LoteId,
                Cg021FilialId = this.Cg021FilialId,
                Cg021Nrolancamento = this.Cg021Nrolancamento,
                Cg021Seq = this.Cg021Seq,
                Cg021Sequencia = this.Cg021Sequencia,
                Cg021Data = this.Cg021Data,
                Cg021Contacontabil = this.Cg021Contacontabil,
                Cg021ContacontabilId = this.Cg021ContacontabilId,
                Cg021HistoricoId = this.Cg021HistoricoId,
                Cg021Historico = this.Cg021Historico,
                Cg021Debcre = this.Cg021Debcre,
                Cg021Valorlancto = this.Cg021Valorlancto,
                Cg021Valorlanctoant = this.Cg021Valorlanctoant,
                Cg021Nrodocumento = this.Cg021Nrodocumento,
                Cg021TiposaldoId = this.Cg021TiposaldoId,
                Cg021ProjetoId = this.Cg021ProjetoId,
                Cg021CtagerencialN2Id = this.Cg021CtagerencialN2Id,
                Cg021CtagerencialN3Id = this.Cg021CtagerencialN3Id,
                Cg021CtagerencialN4Id = this.Cg021CtagerencialN4Id,
                Cg021Protocolo = this.Cg021Protocolo,
                Cg021Consolidar = this.Cg021Consolidar,
                Cg021ConsolidarFilialId = this.Cg021ConsolidarFilialId,
                Cg021Isconsolidado = this.Cg021Isconsolidado,
                Nn010Id = this.Nn010Id,
                Nn015Id = this.Nn015Id
            };
        }
    }
}