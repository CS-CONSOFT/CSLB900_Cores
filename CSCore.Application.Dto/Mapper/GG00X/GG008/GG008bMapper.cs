using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008b;
using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Mapper;

namespace CSCore.Application.Dto.Mapper.GG00X.GG008
{
    public static class GG008bMapper
    {
        public static DtoGetGG008b ToDtoGet(this CSICP_GG008b entity)
        {
            return new DtoGetGG008b
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg008bFilialid = entity.Gg008bFilialid,
                Gg008bProdutoid = entity.Gg008bProdutoid,
                Gg008bFilial = entity.Gg008bFilial,
                Gg008bCodgproduto = entity.Gg008bCodgproduto,
                Gg008bSeq = entity.Gg008bSeq,
                Gg008bRefsimilar = entity.Gg008bRefsimilar,
                Gg008bDatavigor = entity.Gg008bDatavigor,
                Gg008bCodgmarca = entity.Gg008bCodgmarca,
                Gg008bMarcaid = entity.Gg008bMarcaid,
                NavGg006Marca = entity.NavGg006Marca?.ToDtoGetSimples(),
            };
        }
    }}
