using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG070;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG070Mapper
    {
        public static DtoGetGG070 ToDtoGet(this CSICP_GG070 entity)
        {
            return new DtoGetGG070
            {
                TenantId = entity.TenantId,
                Gg070Id = entity.Gg070Id,
                Gg070EstabId = entity.Gg070EstabId,
                Gg070Produtoid = entity.Gg070Produtoid,
                Gg070Motivoid = entity.Gg070Motivoid,
                Gg070Grupoid = entity.Gg070Grupoid,
                Gg070Subgrupoid = entity.Gg070Subgrupoid,
                Gg070Classeid = entity.Gg070Classeid,
                Gg070Marcaid = entity.Gg070Marcaid,
                Gg070Artigoid = entity.Gg070Artigoid,
                Gg070Peso = entity.Gg070Peso,
                Gg070Usuariopropid = entity.Gg070Usuariopropid,
                Gg070Nomecliente = entity.Gg070Nomecliente,
                Gg070Qtdregistrada = entity.Gg070Qtdregistrada,
                Gg070Unvendavarejoid = entity.Gg070Unvendavarejoid,
                Gg070Pvenda = entity.Gg070Pvenda,
                Gg070Pcusto = entity.Gg070Pcusto,
                Gg070Pcreal = entity.Gg070Pcreal,
                Gg070Dregistro = entity.Gg070Dregistro,
                Gg070Saldoprod = entity.Gg070Saldoprod,
                Gg070Descproduto = entity.Gg070Descproduto,
                Gg070Produto = entity.Gg070Produto,
                Gg070Unvendavarejo = entity.Gg070Unvendavarejo,
            };
        }
    }
}

