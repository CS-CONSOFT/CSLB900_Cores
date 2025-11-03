using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.CG.CG006
{
    public class DtoCreateUpdateCG006 : IConverteParaEntidade<Osusr8dwCsicpCg006>
    {
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

        public Osusr8dwCsicpCg006 ToEntity(int tenant, string? id)
        {
            return new Osusr8dwCsicpCg006
            {
                TenantId = tenant,
                Cg006Id = id!,
                Cg006FilialId = Cg006FilialId,
                Cg006Codigoplano = Cg006Codigoplano,
                Cg006Descricao = Cg006Descricao,
                Cg006Descresumida = Cg006Descresumida,
                Cg006Grau = Cg006Grau,
                Cg006CtasuperiorId = Cg006CtasuperiorId,
                Cg006NaturezaId = Cg006NaturezaId,
                Cg006TipocontaId = Cg006TipocontaId,
                Cg006GrupoId = Cg006GrupoId,
                Cg006HistoricoId = Cg006HistoricoId,
                Cg006Codgreduzido = Cg006Codgreduzido,
                Cg006Dtiniexistencia = Cg006Dtiniexistencia,
                Cg006ClassificacaoId = Cg006ClassificacaoId,
                //Cg006ConsolidaLancto = Cg006ConsolidaLancto,
                Cg006AmarracaoNivel2 = Cg006AmarracaoNivel2,
                Cg006AmarracaoNivel3 = Cg006AmarracaoNivel3,
                Cg006AmarracaoNivel4 = Cg006AmarracaoNivel4,
                //Cg006LanctoN2obrig = Cg006LanctoN2obrig,
                //Cg006LanctoN3obrig = Cg006LanctoN3obrig,
                //Cg006LanctoN4obrig = Cg006LanctoN4obrig,
                Cg006Isactive = Cg006Isactive
            };
        }
    }
}