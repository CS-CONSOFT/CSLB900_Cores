using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG031;
using CSCore.Domain.CS_Models.CSICP_GG;
using GG104Materiais.C82Application.Mapper.GG008;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG031Mapper
    {
        public static DtoGetGG031 ToDtoGet(this RepoDto_CSICP_GG031 entity)
        {
            return new DtoGetGG031
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg031Filialid = entity.Gg031Filialid,
                Gg030Id = entity.Gg030Id,
                Gg031KardexId = entity.Gg031KardexId,
                Gg031Produto = entity.Gg031Produto,
                Gg031Produtoid = entity.Gg031Produtoid,
                Gg031Codigobarra = entity.Gg031Codigobarra,
                Gg031DataReferente = entity.Gg031DataReferente,
                Gg031PercAjuste = entity.Gg031PercAjuste,
                Gg031PrcAnterior = entity.Gg031PrcAnterior,
                Gg031PrcMovimento = entity.Gg031PrcMovimento,
                Gg031PrcCalculado = entity.Gg031PrcCalculado,
                Gg031PrecoajusteId = entity.Gg031PrecoajusteId,
                Gg031Codbarrasalfa = entity.Gg031Codbarrasalfa,
                Nav_GG030 = entity.Nav_GG030?.ToDtoGet(),
                Nav_BB001 = entity.Nav_BB001?.ToDtoGetExibicao(),
                Nav_GG008 = entity.Nav_GG008?.ToDtoGetExibicaoSimples(),
                Nav_GG008_Kdx = entity.Nav_GG008_Kdx?.ToDtoGetSimples(),
                Nav_GG023_Val = entity.Nav_GG023_Val
            };
        }

        public static DtoGetGG031 ToDtoGet(this CSICP_GG031 entity)
        {
            return new DtoGetGG031
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg031Filialid = entity.Gg031Filialid,
                Gg030Id = entity.Gg030Id,
                Gg031KardexId = entity.Gg031KardexId,
                Gg031Produto = entity.Gg031Produto,
                Gg031Produtoid = entity.Gg031Produtoid,
                Gg031Codigobarra = entity.Gg031Codigobarra,
                Gg031DataReferente = entity.Gg031DataReferente,
                Gg031PercAjuste = entity.Gg031PercAjuste,
                Gg031PrcAnterior = entity.Gg031PrcAnterior,
                Gg031PrcMovimento = entity.Gg031PrcMovimento,
                Gg031PrcCalculado = entity.Gg031PrcCalculado,
                Gg031PrecoajusteId = entity.Gg031PrecoajusteId,
                Gg031Codbarrasalfa = entity.Gg031Codbarrasalfa,
            };
        }
    }
}
