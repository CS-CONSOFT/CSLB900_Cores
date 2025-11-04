using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.CG.CG006;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Mapper.CG.CG00X
{
    public static class CG006Mapper
    {
        public static DtoGetCG006 ToDtoGet(this CSICP_CG006 entity)
        {
            return new DtoGetCG006
            {
                TenantId = entity.TenantId,
                Cg006Id = entity.Cg006Id,
                Cg006FilialId = entity.Cg006FilialId,
                Cg006Codigoplano = entity.Cg006Codigoplano,
                Cg006Descricao = entity.Cg006Descricao,
                Cg006Descresumida = entity.Cg006Descresumida,
                Cg006Grau = entity.Cg006Grau,
                Cg006CtasuperiorId = entity.Cg006CtasuperiorId,
                Cg006NaturezaId = entity.Cg006NaturezaId,
                Cg006TipocontaId = entity.Cg006TipocontaId,
                Cg006GrupoId = entity.Cg006GrupoId,
                Cg006HistoricoId = entity.Cg006HistoricoId,
                Cg006Codgreduzido = entity.Cg006Codgreduzido,
                Cg006Dtiniexistencia = entity.Cg006Dtiniexistencia,
                Cg006ClassificacaoId = entity.Cg006ClassificacaoId,
                Cg006ConsolidaLancto = entity.Cg006ConsolidaLancto,
                Cg006AmarracaoNivel2 = entity.Cg006AmarracaoNivel2,
                Cg006AmarracaoNivel3 = entity.Cg006AmarracaoNivel3,
                Cg006AmarracaoNivel4 = entity.Cg006AmarracaoNivel4,
                Cg006LanctoN2obrig = entity.Cg006LanctoN2obrig,
                Cg006LanctoN3obrig = entity.Cg006LanctoN3obrig,
                Cg006LanctoN4obrig = entity.Cg006LanctoN4obrig,
                Cg006Isactive = entity.Cg006Isactive,
                NavBB001Estab_CG006 = entity.NavBB001Estab_CG006?.ToDtoGetExibicao(),
                NavCG003GpContabil_CG006 = entity.NavCG003GpContabil_CG006?.ToDtoGetPadrao(),
                NavCG005HistPadrao_CG006 = entity.NavCG005HistPadrao_CG006?.ToDtoGetPadrao(),
                NavCG006PlanoContas_ContaSuperior = entity.NavCG006PlanoContas_ContaSuperior?.ToDtoGetPadrao(),
                NavCG004AmarracaoNivel2_CG006 = entity.NavCG004AmarracaoNivel2_CG006?.ToDtoGetPadrao(),
                NavCG004AmarracaoNivel3_CG006 = entity.NavCG004AmarracaoNivel3_CG006?.ToDtoGetPadrao(),
                NavCG004AmarracaoNivel4_CG006 = entity.NavCG004AmarracaoNivel4_CG006?.ToDtoGetPadrao(),
                NavCG996TpConta_CG006 = entity.NavCG996TpConta_CG006,
                NavCG997ClassConta_CG006 = entity.NavCG997ClassConta_CG006,
                NavCG999TpAmarracao_CG006 = entity.NavCG999TpAmarracao_CG006,
                NavStatica_CG006_LancNivel2 = entity.NavStatica_CG006_LancNivel2,
                NavStatica_CG006_LancNivel3 = entity.NavStatica_CG006_LancNivel3,
                NavStatica_CG006_LancNivel4 = entity.NavStatica_CG006_LancNivel4,
                NavStatica_CG006_ConsolidaLanc = entity.NavStatica_CG006_ConsolidaLanc


            };
        }

        public static DtoGetCG006Padrao ToDtoGetPadrao(this CSICP_CG006 entity)
        {
            return new DtoGetCG006Padrao
            {
                TenantId = entity.TenantId,
                Cg006Id = entity.Cg006Id,
                Cg006FilialId = entity.Cg006FilialId,
                Cg006Codigoplano = entity.Cg006Codigoplano,
                Cg006Descricao = entity.Cg006Descricao,
                Cg006Descresumida = entity.Cg006Descresumida,
                Cg006Grau = entity.Cg006Grau,
                Cg006CtasuperiorId = entity.Cg006CtasuperiorId,
                Cg006NaturezaId = entity.Cg006NaturezaId,
                Cg006TipocontaId = entity.Cg006TipocontaId,
                Cg006GrupoId = entity.Cg006GrupoId,
                Cg006HistoricoId = entity.Cg006HistoricoId,
                Cg006Codgreduzido = entity.Cg006Codgreduzido,
                Cg006Dtiniexistencia = entity.Cg006Dtiniexistencia,
                Cg006ClassificacaoId = entity.Cg006ClassificacaoId,
                Cg006ConsolidaLancto = entity.Cg006ConsolidaLancto,
                Cg006AmarracaoNivel2 = entity.Cg006AmarracaoNivel2,
                Cg006AmarracaoNivel3 = entity.Cg006AmarracaoNivel3,
                Cg006AmarracaoNivel4 = entity.Cg006AmarracaoNivel4,
                Cg006LanctoN2obrig = entity.Cg006LanctoN2obrig,
                Cg006LanctoN3obrig = entity.Cg006LanctoN3obrig,
                Cg006LanctoN4obrig = entity.Cg006LanctoN4obrig,
                Cg006Isactive = entity.Cg006Isactive
            };
        }
    }
}