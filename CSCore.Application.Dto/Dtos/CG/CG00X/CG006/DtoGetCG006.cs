using CSBS101._82Application.Dto.BB00X.BB001;
using CSCore.Application.Dto.Dtos.CG.CG00X.CG003;
using CSCore.Application.Dto.Dtos.CG.CG00X.CG004;
using CSCore.Application.Dto.Dtos.CG.CG00X.CG005;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_BB;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Dtos.CG.CG00X.CG006
{
    public class DtoGetCG006
    {
        public int TenantId { get; set; }

        public string Cg006Id { get; set; } = null!;

        public string? Cg006FilialId { get; set; }

        public string? Cg006Codigoplano { get; set; }

        public string? Cg006Descricao { get; set; }

        public string? Cg006Descresumida { get; set; }

        public int? Cg006ClassificacaoId { get; set; }

        public int? Cg006NaturezaId { get; set; }

        public int? Cg006TipocontaId { get; set; }

        public int? Cg006Grau { get; set; }

        public string? Cg006CtasuperiorId { get; set; }

        public int? Cg006Codgreduzido { get; set; }

        public string? Cg006GrupoId { get; set; }

        public string? Cg006HistoricoId { get; set; }

        public DateTime? Cg006Dtiniexistencia { get; set; }

        public string? Cg006AmarracaoNivel2 { get; set; }

        public string? Cg006AmarracaoNivel3 { get; set; }

        public string? Cg006AmarracaoNivel4 { get; set; }

        public bool? Cg006Isactive { get; set; }

        public int? Cg006LanctoN2obrig { get; set; }

        public int? Cg006LanctoN3obrig { get; set; }

        public int? Cg006LanctoN4obrig { get; set; }

        public int? Cg006ConsolidaLancto { get; set; }

        public Dto_GetBB001_Exibicao? NavBB001Estab_CG006 { get; set; }
        public DtoGetCG003Padrao? NavCG003GpContabil_CG006 { get; set; }
        public DtoGetCG004Padrao? NavCG004AmarracaoNivel2_CG006 { get; set; }
        public DtoGetCG004Padrao? NavCG004AmarracaoNivel3_CG006 { get; set; }
        public DtoGetCG004Padrao? NavCG004AmarracaoNivel4_CG006 { get; set; }
        public DtoGetCG005Padrao? NavCG005HistPadrao_CG006 { get; set; }
        public Osusr8dwCsicpCg996? NavCG996TpConta_CG006 { get; set; }
        public Osusr8dwCsicpCg997? NavCG997ClassConta_CG006 { get; set; }
        public Osusr8dwCsicpCg999? NavCG999TpAmarracao_CG006 { get; set; }
        public DtoGetCG006Padrao? NavCG006PlanoContas_ContaSuperior { get; set; }
        public CSICP_Statica? NavStatica_CG006_LancNivel2 { get; set; }
        public CSICP_Statica? NavStatica_CG006_LancNivel3 { get; set; }
        public CSICP_Statica? NavStatica_CG006_LancNivel4 { get; set; }
        public CSICP_Statica? NavStatica_CG006_ConsolidaLanc { get; set; }
    }
}