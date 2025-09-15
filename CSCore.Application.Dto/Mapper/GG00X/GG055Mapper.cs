using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG055;
using CSCore.Domain.CS_Models.CSICP_GG;
using GG104Materiais.C82Application.Mapper.GG008;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG055Mapper
    {
        public static DtoGetGG055 ToDtoGetGG055(this CSICP_GG055 entity)
        {
            return new DtoGetGG055
            {
                TenantId = entity.TenantId,
                Gg055Id = entity.Gg055Id,
                Gg054Id = entity.Gg054Id,
                Gg055Codgproduto = entity.Gg055Codgproduto,
                Gg055Codgbarras = entity.Gg055Codgbarras,
                Gg055ProdutoId = entity.Gg055ProdutoId,
                Gg055Saldoid = entity.Gg055Saldoid,
                Gg055KdxId = entity.Gg055KdxId,
                Gg055Unidade = entity.Gg055Unidade,
                Gg055Gradelinhaid = entity.Gg055Gradelinhaid,
                Gg055Gradecolunaid = entity.Gg055Gradecolunaid,
                Gg055Lote = entity.Gg055Lote,
                Gg055Sublote = entity.Gg055Sublote,
                Gg055Quantidade = entity.Gg055Quantidade,
                Gg055Status = entity.Gg055Status,
                Gg055UsuarioId = entity.Gg055UsuarioId,
                Gg055DataInc = entity.Gg055DataInc,
                Gg055HoraInc = entity.Gg055HoraInc,
                Gg055UsuarioAlt = entity.Gg055UsuarioAlt,
                Gg055DataAlt = entity.Gg055DataAlt,
                Gg055HoraAlt = entity.Gg055HoraAlt,
                Gg055Criarexcid = entity.Gg055Criarexcid,
                Nav_Gg008Kdx = entity.Nav_Gg008Kdx?.ToDtoGetSimples(),
                Nav_GG520Saldo = entity.Nav_GG520Saldo?.ToDtoGetSimples()
            };
        }
    }
}
