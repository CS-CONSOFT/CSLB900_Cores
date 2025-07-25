using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Materiais_GG.Dto.GG00X.GG060;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG060;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG060Mapper
    {
        public static DtoGetGG060ParaGG003 ToDtoGetParaGG003(this CSICP_GG060 entity)
        {
            return new DtoGetGG060ParaGG003
            {
                TenantId = entity.TenantId,
                Gg060Id = entity.Gg060Id,
                Gg060EstabId = entity.Gg060EstabId,
                Gg060Grupoid = entity.Gg060Grupoid,
                Gg060Subgrupoid = entity.Gg060Subgrupoid,
                Gg060Plucro = entity.Gg060Plucro,
                Gg060Isactive = entity.Gg060Isactive,
                Gg060Dregistro = entity.Gg060Dregistro,
                Gg060Pmaxdesconto = entity.Gg060Pmaxdesconto,
                Gg060Ispadrao = entity.Gg060Ispadrao,
                Nav_FilialBB001 = entity.NavBB001Filial?.ToDtoGetSimples(),
                Nav_Gg015Subgrupo = entity.NavGg015Subgrupo?.ToDtoGet(),
            };
        }

        public static DtoGetGG060ParaGG003 ToDtoGetParaGG003SemFilial(this CSICP_GG060 entity)
        {
            return new DtoGetGG060ParaGG003
            {
                TenantId = entity.TenantId,
                Gg060Id = entity.Gg060Id,
                Gg060EstabId = entity.Gg060EstabId,
                Gg060Grupoid = entity.Gg060Grupoid,
                Gg060Subgrupoid = entity.Gg060Subgrupoid,
                Gg060Plucro = entity.Gg060Plucro,
                Gg060Isactive = entity.Gg060Isactive,
                Gg060Dregistro = entity.Gg060Dregistro,
                Gg060Pmaxdesconto = entity.Gg060Pmaxdesconto,
                Gg060Ispadrao = entity.Gg060Ispadrao,
                Nav_Gg015Subgrupo = entity.NavGg015Subgrupo?.ToDtoGet(),
            };
        }

        public static DtoGetGG060Simples ToDtoGetSimples(this CSICP_GG060 entity)
        {
            return new DtoGetGG060Simples
            {
                TenantId = entity.TenantId,
                Gg060Id = entity.Gg060Id,
                Gg060EstabId = entity.Gg060EstabId,
                Gg060Grupoid = entity.Gg060Grupoid,
                Gg060Subgrupoid = entity.Gg060Subgrupoid,
                Gg060Plucro = entity.Gg060Plucro,
                Gg060Isactive = entity.Gg060Isactive,
                Gg060Dregistro = entity.Gg060Dregistro,
                Gg060Pmaxdesconto = entity.Gg060Pmaxdesconto,
                Gg060Ispadrao = entity.Gg060Ispadrao,
            };
        }
    }
}
