using CSCore.Application.Dto.Dtos.CG.CG006;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Mapper.CG.CG00X
{
    public static class CG006Mapper
    {
        public static DtoGetCG006 ToDtoGet(this Osusr8dwCsicpCg006 entity)
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
                //Cg006ConsolidaLancto = entity.Cg006ConsolidaLancto,
                Cg006AmarracaoNivel2 = entity.Cg006AmarracaoNivel2,
                Cg006AmarracaoNivel3 = entity.Cg006AmarracaoNivel3,
                Cg006AmarracaoNivel4 = entity.Cg006AmarracaoNivel4,
                //Cg006LanctoN2obrig = entity.Cg006LanctoN2obrig,
                //Cg006LanctoN3obrig = entity.Cg006LanctoN3obrig,
                //Cg006LanctoN4obrig = entity.Cg006LanctoN4obrig,
                Cg006Isactive = entity.Cg006Isactive,
                //NavBB001_CG006 = entity.NavBB001_CG006,
                //NavCG003_Grupo = entity.NavCG003_Grupo,
                //NavCG005_Historico = entity.NavCG005_Historico,
                //NavCG006_Superior = entity.NavCG006_Superior
            };
        }
    }
}