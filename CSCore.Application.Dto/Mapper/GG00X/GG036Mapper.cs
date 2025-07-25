using CSCore.Domain.CS_Models.CSICP_GG;
using GG104Materiais.C82Application.Dto.GG00X.GG036;
using GG104Materiais.C82Application.Mapper.GG008;

namespace GG104Materiais.C82Application.Mapper
{
    public static class GG036Mapper
    {
        public static DtoGetGG036 ToDtoGet(this CSICP_GG036 entity)
        {
            return new DtoGetGG036
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg036Filialid = entity.Gg036Filialid,
                Gg036Ordem = entity.Gg036Ordem,
                Gg036KardexId = entity.Gg036KardexId,
                Gg036Codigobarras = entity.Gg036Codigobarras,
                Gg036Dataregistro = entity.Gg036Dataregistro,
                Gg036Saldoid = entity.Gg036Saldoid,
                Gg036QtdEstoque = entity.Gg036QtdEstoque,
                Gg036Saldoestoque = entity.Gg036Saldoestoque,
                Gg036Precocusto = entity.Gg036Precocusto,
                Gg036Precocustoreal = entity.Gg036Precocustoreal,
                Gg036Precocustomedio = entity.Gg036Precocustomedio,
                Gg036Precovenda = entity.Gg036Precovenda,
                Gg036Naoinventariar = entity.Gg036Naoinventariar,
                Gg036Inventariado = entity.Gg036Inventariado,
                Gg036Mensagem = entity.Gg036Mensagem,
                Gg036Codbarrasalfa = entity.Gg036Codbarrasalfa
            };
        }
    }
}
