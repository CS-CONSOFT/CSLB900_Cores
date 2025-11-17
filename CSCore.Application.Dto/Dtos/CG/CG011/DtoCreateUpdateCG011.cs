using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.CG.CG011
{
    public class DtoCreateUpdateCG011 : IConverteParaEntidade<Osusr8dwCsicpCg011>
    {
        public string? Cg011NivelctagerId { get; set; }

        public string? Cg011FilialId { get; set; }

        public string? Cg011Codigoplano { get; set; }

        public string? Cg011Descricao { get; set; }

        public string? Cg011Descresumida { get; set; }

        public int? Cg011ClassificacaoId { get; set; }

        public int? Cg011NaturezaId { get; set; }

        public int? Cg011TipocontaId { get; set; }

        public int? Cg011Grau { get; set; }

        public string? Cg011CtasuperiorId { get; set; }

        public string? Cg011Codgreduzido { get; set; }

        public string? Cg011GrupoId { get; set; }

        public DateTime? Cg011Dtiniexistencia { get; set; }

        public string? Cg011AmarracaoNivel2 { get; set; }

        public string? Cg011AmarracaoNivel3 { get; set; }

        public string? Cg011AmarracaoNivel4 { get; set; }

        public bool? Cg011Isactive { get; set; }

        public int? Cg011LanctoN2obrig { get; set; }

        public int? Cg011LanctoN3obrig { get; set; }

        public int? Cg011LanctoN4obrig { get; set; }

        public int? Cg011ConsolidaLancto { get; set; }

        public Osusr8dwCsicpCg011 ToEntity(int tenant, string? id)
        {
            return new Osusr8dwCsicpCg011
            {
                TenantId = tenant,
                Cg011Id = id!,
                Cg011NivelctagerId = this.Cg011NivelctagerId,
                Cg011FilialId = this.Cg011FilialId,
                Cg011Codigoplano = this.Cg011Codigoplano,
                Cg011Descricao = this.Cg011Descricao,
                Cg011Descresumida = this.Cg011Descresumida,
                Cg011ClassificacaoId = this.Cg011ClassificacaoId,
                Cg011NaturezaId = this.Cg011NaturezaId,
                Cg011TipocontaId = this.Cg011TipocontaId,
                Cg011Grau = this.Cg011Grau,
                Cg011CtasuperiorId = this.Cg011CtasuperiorId,
                Cg011Codgreduzido = this.Cg011Codgreduzido,
                Cg011GrupoId = this.Cg011GrupoId,
                Cg011Dtiniexistencia = this.Cg011Dtiniexistencia,
                Cg011AmarracaoNivel2 = this.Cg011AmarracaoNivel2,
                Cg011AmarracaoNivel3 = this.Cg011AmarracaoNivel3,
                Cg011AmarracaoNivel4 = this.Cg011AmarracaoNivel4,
                Cg011Isactive = this.Cg011Isactive,
                Cg011LanctoN2obrig = this.Cg011LanctoN2obrig,
                Cg011LanctoN3obrig = this.Cg011LanctoN3obrig,
                Cg011LanctoN4obrig = this.Cg011LanctoN4obrig,
                Cg011ConsolidaLancto = this.Cg011ConsolidaLancto
            };
        }
    }
}