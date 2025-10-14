using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG007;

namespace FF105Financeiro.C82Application.Mapper
{
    public static class GG007Mapper
    {
        public static DtoGetGG007 ToDtoGet(this CSICP_GG007 entity)
        {
            return new DtoGetGG007
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg007Filial = entity.Gg007Filial,
                Gg007Filialid = entity.Gg007Filialid,
                Gg007Unidade = entity.Gg007Unidade,
                Gg007Descricao = entity.Gg007Descricao,
                Gg007IsActive = entity.Gg007IsActive,
                Gg007FormavendaId = entity.Gg007FormavendaId,
                Gg007Qdecimais = entity.Gg007Qdecimais,
                NavGg007Formavenda = entity.NavGG007FraFormaVenda,
                NavGg007Filial = entity.NavGg007Filial?.ToDtoGetSimples()
            };
        }

        public static DtoGetGG007Simples ToDtoGetSimples(this CSICP_GG007 entity)
        {
            return new DtoGetGG007Simples
            {
                Id = entity.Id,
                Gg007Unidade = entity.Gg007Unidade,
                Gg007Descricao = entity.Gg007Descricao,
            };
        }


    }
}

