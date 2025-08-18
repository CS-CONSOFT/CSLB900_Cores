using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG045;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG045Mapper
    {
        public static DtoGetGG045 ToDtoGet(this CSICP_GG045 entity, IEnumerable<CSICP_GG520> listaSaldoCandidato,
            IEnumerable<CSICP_GG046> listaPeloGG045)
        {
            return new DtoGetGG045
            {
                TenantId = entity.TenantId,
                Gg045Id = entity.Gg045Id,
                Gg045EstabelecimentoId = entity.Gg045EstabelecimentoId,
                Gg045Saldoid = entity.Gg045Saldoid,
                Gg045Qtd = entity.Gg045Qtd,
                Gg045Protocolnumber = entity.Gg045Protocolnumber,
                Gg045Datamovto = entity.Gg045Datamovto,
                Gg045UsuariopropId = entity.Gg045UsuariopropId,
                Gg045Descricao = entity.Gg045Descricao,
                Cc040Id = entity.Cc040Id,
                Gg045Statid = entity.Gg045Statid,
                Cc060Id = entity.Cc060Id,
                Gg045Stat = entity.Gg045Stat,
                CS_Gg520KardexId = entity.Gg045Saldo?.Gg520KardexId,
                CS_Gg520Almoxid = entity.Gg045Saldo?.Gg520Almoxid,
                CS_Gg520AlmoxCodigo = entity.Gg045Saldo?.NavGG001Almox?.Gg001Codigoalmox.ToString(),
                CS_Gg520AlmoxDesc = entity.Gg045Saldo?.NavGG001Almox?.Gg001Descalmox,
                CS_Gg520Saldo = entity.Gg045Saldo?.Gg520Saldo ?? -1,
                CS_Gg520DescLote = entity.Gg045Saldo?.Gg520DescricaoLote,
                CS_Gg520DescSaldo = entity.Gg045Saldo?.Gg520Descricaosaldo,
                CS_Gg520NS = entity.Gg045Saldo?.Gg520NsNumerosaldo ?? -1,
                CS_Gg008Codgproduto = entity.Gg045Saldo?.Nav_GG008Kardex?.NavGG008Produto?.Gg008Codgproduto,
                CS_Gg008Descreduzida = entity.Gg045Saldo?.Nav_GG008Kardex?.NavGG008Produto?.Gg008Descreduzida,
                CS_Gg520SaldosCandidatos = listaSaldoCandidato.Select(x => x.ToDtoGetGG520ParaGG45()),
                CS_Gg046ListaPeloGG045 = listaPeloGG045.Select(x => x.ToDtoGet()),
                
            };
        }
        public static DtoGetGG045 ToDtoGet(this CSICP_GG045 entity)
        {
            return new DtoGetGG045
            {
                TenantId = entity.TenantId,
                Gg045Id = entity.Gg045Id,
                Gg045EstabelecimentoId = entity.Gg045EstabelecimentoId,
                Gg045Saldoid = entity.Gg045Saldoid,
                Gg045Qtd = entity.Gg045Qtd,
                Gg045Protocolnumber = entity.Gg045Protocolnumber,
                Gg045Datamovto = entity.Gg045Datamovto,
                Gg045UsuariopropId = entity.Gg045UsuariopropId,
                Gg045Descricao = entity.Gg045Descricao,
                Cc040Id = entity.Cc040Id,
                Gg045Statid = entity.Gg045Statid,
                Cc060Id = entity.Cc060Id,
                Gg045Stat = entity.Gg045Stat,
                CS_Gg520KardexId = entity.Gg045Saldo?.Gg520KardexId,
                CS_Gg520Almoxid = entity.Gg045Saldo?.Gg520Almoxid,
                CS_Gg520Saldo = entity.Gg045Saldo?.Gg520Saldo ?? -1,
                CS_Gg008Codgproduto = entity.Gg045Saldo?.Nav_GG008Kardex?.NavGG008Produto?.Gg008Codgproduto,
                CS_Gg008Descreduzida = entity.Gg045Saldo?.Nav_GG008Kardex?.NavGG008Produto?.Gg008Descreduzida,
            };
        }
    }
}


