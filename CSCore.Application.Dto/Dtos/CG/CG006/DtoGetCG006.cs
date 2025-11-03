using CSCore.Application.Dto.Dtos.CG.CG005;
using CSCore.Domain.CS_Models.CSICP_BB;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Dtos.CG.CG006
{
    public class DtoGetCG006
    {
        public int TenantId { get; set; }

        public string Cg006Id { get; set; } = null!;

        public string? Cg006FilialId { get; set; }

        public string? Cg006Codigoplano { get; set; }

        public string? Cg006Descricao { get; set; }

        public string? Cg006Descresumida { get; set; }

        public int? Cg006Grau { get; set; }

        public string? Cg006CtasuperiorId { get; set; }

        public int? Cg006NaturezaId { get; set; }

        public int? Cg006TipocontaId { get; set; }

        public string? Cg006GrupoId { get; set; }

        public string? Cg006HistoricoId { get; set; }

        public int? Cg006Codgreduzido { get; set; }

        public DateTime? Cg006Dtiniexistencia { get; set; }

        public int? Cg006ClassificacaoId { get; set; }

        public bool? Cg006ConsolidaLancto { get; set; }

        public string? Cg006AmarracaoNivel2 { get; set; }

        public string? Cg006AmarracaoNivel3 { get; set; }

        public string? Cg006AmarracaoNivel4 { get; set; }

        public bool? Cg006LanctoN2obrig { get; set; }

        public bool? Cg006LanctoN3obrig { get; set; }

        public bool? Cg006LanctoN4obrig { get; set; }

        public bool? Cg006Isactive { get; set; }

        public CSICP_BB001? NavBB001_CG006 { get; set; }

        public CSICP_CG003? NavCG003_Grupo { get; set; }

        public DtoGetCG005? NavCG005_Historico { get; set; }

        public Osusr8dwCsicpCg006? NavCG006_Superior { get; set; }
    }
}