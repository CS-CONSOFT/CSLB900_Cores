using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF012;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF112;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_FF;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF012;

namespace CSCore.Application.Dto.Mapper.FF.FF01X
{
    public static class FF012Mapper
    {
        public static DtoGetFF012 ToDtoGet(this RepoDtoCSICP_FF012 entity)
        {
            return new DtoGetFF012
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff012Filialid = entity.Ff012Filialid,
                Ff012CodigoGrupo = entity.Ff012CodigoGrupo,
                Ff012DescricaoGrupo = entity.Ff012DescricaoGrupo,
                Ff012Usuariosuperid = entity.Ff012Usuariosuperid,
                Ff014Comissaosuperid = entity.Ff014Comissaosuperid,
                Ff014Comissaocobradorid = entity.Ff014Comissaocobradorid,
                Ff012Grupopaiid = entity.Ff012Grupopaiid,
                NavBB001 = entity.NavBB001?.ToDtoGetExibicao(),
                NavSY001 = entity.NavSY001?.ToDtoGetSimples(),
                NavFF014ComissaoSuper = entity.NavFF014ComissaoSuper?.ToDtoGet(),
                NavFF014ComissaoCobrador = entity.NavFF014ComissaoCobrador?.ToDtoGet(),
                NavFF012GrupoPai = entity.NavFF012GrupoPai?.ToDtoGetSimples()
            };
        }

        public static DtoGetFF012Simples ToDtoGetSimples(this CSICP_FF012 entity)
        {
            return new DtoGetFF012Simples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff012Filialid = entity.Ff012Filialid,
                Ff012CodigoGrupo = entity.Ff012CodigoGrupo,
                Ff012DescricaoGrupo = entity.Ff012DescricaoGrupo,
                Ff012Usuariosuperid = entity.Ff012Usuariosuperid,
                Ff014Comissaosuperid = entity.Ff014Comissaosuperid,
                Ff014Comissaocobradorid = entity.Ff014Comissaocobradorid,
                Ff012Grupopaiid = entity.Ff012Grupopaiid
            };
        }
    }
}