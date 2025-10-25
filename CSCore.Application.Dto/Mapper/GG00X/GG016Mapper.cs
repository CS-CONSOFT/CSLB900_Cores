using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG016;
using FF105Financeiro.C82Application.Dto.GG00X.GG016.GG016e;
using FF105Financeiro.C82Application.Dto.GG00X.GG016.GG016f;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG016Mapper
    {
        public static DtoGetGG016 ToDtoGet(this CSICP_GG016 entity)
        {
            return new DtoGetGG016
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg016Filialid = entity.Gg016Filialid,
                Gg016Filial = entity.Gg016Filial,
                Gg016Grade = entity.Gg016Grade,
                Gg016Descricao = entity.Gg016Descricao,
                Gg016Lincolid = entity.Gg016Lincolid,
                Gg016Ismarcado = entity.Gg016Ismarcado,
                //NavBB001 = entity.NavFilialBB001?.ToDtoGetExibicao(),
                NavCSICP_GG016b = entity.NavCSICP_GG016b
            };
        }

        public static DtoGetGG016Simples ToDtoGetSimples(this CSICP_GG016 entity)
        {
            return new DtoGetGG016Simples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg016Filialid = entity.Gg016Filialid,
                Gg016Filial = entity.Gg016Filial,
                Gg016Grade = entity.Gg016Grade,
                Gg016Descricao = entity.Gg016Descricao,
                Gg016Lincolid = entity.Gg016Lincolid,
                Gg016Ismarcado = entity.Gg016Ismarcado
            };
        }



        public static DtoGetGG016e ToDtoGet(this CSICP_GG016e entity)
        {
            return new DtoGetGG016e
            {
                TenantId = entity.TenantId,
                Gg016eId = entity.Gg016eId,
                Gg016eDescricao = entity.Gg016eDescricao,
                Gg016eDregistro = entity.Gg016eDregistro,
                Gg016eUsuariopropid = entity.Gg016eUsuariopropid,
                NavGetSy001 = entity.NavProprietarioSY001?.ToDtoGetSimples()
            };
        }

        public static DtoGetGG016f ToDtoGet(this CSICP_GG016f entity)
        {
            return new DtoGetGG016f
            {
                TenantId = entity.TenantId,
                Gg016fId = entity.Gg016fId,
                Gg016eId = entity.Gg016eId,
                Gg016fGradelinhaid = entity.Gg016fGradelinhaid,
                Gg016fGradecolunaid = entity.Gg016fGradecolunaid,
                Nav_GG016_VariacaoProduto_C1 = entity.NavGg016fGradelinha?.ToDtoGetSimples(),
                Nav_GG016_VariacaoProduto_C2 = entity.NavGg016fGradecoluna?.ToDtoGetSimples(),
                NavDtoGetBB001 = entity.NavGg016fGradecoluna?.NavFilialBB001?.ToDtoGetSimples()
            };
        }
    }
}
