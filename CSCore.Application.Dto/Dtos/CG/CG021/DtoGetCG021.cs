using CSBS101._82Application.Dto.BB00X.BB001;
using CSCore.Application.Dto.Dtos.CG.CG005;
using CSCore.Application.Dto.Dtos.CG.CG006;
using CSCore.Application.Dto.Dtos.CG.CG007;
using CSCore.Application.Dto.Dtos.CG.CG008;
using CSCore.Application.Dto.Dtos.CG.CG011;
using CSCore.Application.Dto.Dtos.CG.CG020;
using CSCore.Application.Dto.Dtos.NN._015;
using CSCore.Application.Dto.Mapper.NN._015;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.CSICP_NN;

namespace CSCore.Application.Dto.Dtos.CG.CG021
{
    public class DtoGetCG021
    {
        public int TenantId { get; set; }

        public string Cg021Id { get; set; } = null!;

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

        public Dto_GetBB001_Exibicao? NavBB001Estab_CG021 { get; set; }
        public Dto_GetBB001_Exibicao? NavBB001EstabConsolida_CG021 { get; set; }
        public DtoGetCG005Padrao? NavCG005Hist_CG021 { get; set; }
        public DtoGetCG006Padrao? NavCG006ContaContabil_CG021 { get; set; }
        public DtoGetCG007? NavCG007Projeto_CG021 { get; set; }
        public DtoGetCG008Padrao? NavCG008TpSaldo_CG021 { get; set; }
        public csicp_cg993_st? NavCG993DebCre_CG021 { get; set; }
        public DtoGetCG011? NavCG011ContaGerencialN2_CG021 { get; set; }
        public DtoGetCG011? NavCG012ContaGerencialN3_CG021 { get; set; }
        public DtoGetCG011? NavCG013ContaGerencialN4_CG021 { get; set; }
        public DtoGetCG020? NavCG020Lote_CG021 { get; set; }
        public Osusr8dwCsicpCg070? NavCG070Protocolo_CG021 { get; set; }
        public OsusrE9aCsicpNn010? NavNN010_CG021 { get; set; }
        public DtoGetNN015Padrao? NavNN015_CG021 { get; set; }
        public CSICP_Statica? NavStaticConsolidar_CG021 { get; set; }
    }
}