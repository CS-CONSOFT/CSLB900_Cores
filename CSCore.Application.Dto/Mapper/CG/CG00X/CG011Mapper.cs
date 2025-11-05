using CSCore.Application.Dto.Dtos.CG.CG011;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Mapper.CG.CG00X
{
    public static class CG011Mapper
    {
        public static DtoGetCG011 ToDtoGet(this Osusr8dwCsicpCg011 entity)
        {
            return new DtoGetCG011
            {
                TenantId = entity.TenantId,
                Cg011Id = entity.Cg011Id,
                Cg011NivelctagerId = entity.Cg011NivelctagerId,
                Cg011FilialId = entity.Cg011FilialId,
                Cg011Codigoplano = entity.Cg011Codigoplano,
                Cg011Descricao = entity.Cg011Descricao,
                Cg011Descresumida = entity.Cg011Descresumida,
                Cg011ClassificacaoId = entity.Cg011ClassificacaoId,
                Cg011NaturezaId = entity.Cg011NaturezaId,
                Cg011TipocontaId = entity.Cg011TipocontaId,
                Cg011Grau = entity.Cg011Grau,
                Cg011CtasuperiorId = entity.Cg011CtasuperiorId,
                Cg011Codgreduzido = entity.Cg011Codgreduzido,
                Cg011GrupoId = entity.Cg011GrupoId,
                Cg011Dtiniexistencia = entity.Cg011Dtiniexistencia,
                Cg011AmarracaoNivel2 = entity.Cg011AmarracaoNivel2,
                Cg011AmarracaoNivel3 = entity.Cg011AmarracaoNivel3,
                Cg011AmarracaoNivel4 = entity.Cg011AmarracaoNivel4,
                Cg011Isactive = entity.Cg011Isactive,
                Cg011LanctoN2obrig = entity.Cg011LanctoN2obrig,
                Cg011LanctoN3obrig = entity.Cg011LanctoN3obrig,
                Cg011LanctoN4obrig = entity.Cg011LanctoN4obrig,
                Cg011ConsolidaLancto = entity.Cg011ConsolidaLancto
            };
        }
    }
}