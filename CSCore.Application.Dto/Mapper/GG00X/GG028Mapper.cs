using CSBS101._82Application.ExtensionsMethods.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG028;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSSY103.C82Application.Mapper;
using GG104Materiais.C82Application.Mapper;
using GG104Materiais.C82Application.Mapper.GG008;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG028Mapper
    {
        public static DtoGetGG028ComIncludes ToDtoGet(this RepoGetCSICP_GG028 entity)
        {
            return new DtoGetGG028ComIncludes
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg028Filialid = entity.Gg028Filialid,
                Gg028Filial = entity.Gg028Filial,
                Gg028Protocolnumber = entity.Gg028Protocolnumber,
                Gg028Origemprograma = entity.Gg028Origemprograma,
                Gg028OrigemPkid = entity.Gg028OrigemPkid,
                Gg028DataMovimento = entity.Gg028DataMovimento,
                Gg028DataReferente = entity.Gg028DataReferente,
                Gg028Almoxid = entity.Gg028Almoxid,
                Gg028KardexId = entity.Gg028KardexId,
                Gg028Produtoid = entity.Gg028Produtoid,
                Gg028Saldoid = entity.Gg028Saldoid,
                Gg028Transacaoid = entity.Gg028Transacaoid,
                Gg028Contaid = entity.Gg028Contaid,
                Gg028Usuarioid = entity.Gg028Usuarioid,
                Gg028QtdMovimento = entity.Gg028QtdMovimento,
                Gg028ValorUnitario = entity.Gg028ValorUnitario,
                Gg028SaldoAnterior = entity.Gg028SaldoAnterior,
                Gg028DocProtocolnumber = entity.Gg028DocProtocolnumber,
                Gg028DoctoId = entity.Gg028DoctoId,
                Gg028NPdv = entity.Gg028NPdv,
                Gg028NfOuCupom = entity.Gg028NfOuCupom,
                Gg028EntsaidaId = entity.Gg028EntsaidaId,
                Gg028NaturezaId = entity.Gg028NaturezaId,

                NavBB012_Cliente = entity.NavBB012_Cliente?.ToDtoBB012_Exibicao(),
                NavBB027 = entity.NavBB027?.ToDtoGetSimples(),
                NavGG001_Almox = entity.NavGG001_Almox?.ToDtoGetSimples(),
                NavSY001_Usuario = entity.NavSY001_Usuario?.ToDtoGetSimples(),
                Nav_GG008_Produto = entity.Nav_GG008_Produto?.ToDtoGetSimples(),
                Nav_GG028_EntSaida = entity.Nav_GG028_EntSaida,
                Nav_GG028_Nat = entity.Nav_GG028_Nat,
                Nav_GG520_Saldo = entity.Nav_GG520_Saldo?.ToDtoGetSimples(),

            };
        }

        public static DtoGetGG028 ToDtoGet(this RepoDtoExtrato entity)
        {
            return new DtoGetGG028
            {
                TenantId = entity.Extrato!.TenantId,
                Id = entity.Extrato!.Id,
                Gg028Filialid = entity.Extrato!.Gg028Filialid,
                Gg028Filial = entity.Extrato!.Gg028Filial,
                Gg028Protocolnumber = entity.Extrato!.Gg028Protocolnumber,
                Gg028Origemprograma = entity.Extrato!.Gg028Origemprograma,
                Gg028OrigemPkid = entity.Extrato!.Gg028OrigemPkid,
                Gg028DataMovimento = entity.Extrato!.Gg028DataMovimento,
                Gg028DataReferente = entity.Extrato!.Gg028DataReferente,
                Gg028Almoxid = entity.Extrato!.Gg028Almoxid,
                Gg028KardexId = entity.Extrato!.Gg028KardexId,
                Gg028Produtoid = entity.Extrato!.Gg028Produtoid,
                Gg028Saldoid = entity.Extrato!.Gg028Saldoid,
                Gg028Transacaoid = entity.Extrato!.Gg028Transacaoid,
                Gg028Contaid = entity.Extrato!.Gg028Contaid,
                Gg028Usuarioid = entity.Extrato!.Gg028Usuarioid,
                Gg028QtdMovimento = entity.Extrato!.Gg028QtdMovimento,
                Gg028ValorUnitario = entity.Extrato!.Gg028ValorUnitario,
                Gg028SaldoAnterior = entity.Extrato!.Gg028SaldoAnterior,
                Gg028DocProtocolnumber = entity.Extrato!.Gg028DocProtocolnumber,
                Gg028DoctoId = entity.Extrato!.Gg028DoctoId,
                Gg028NPdv = entity.Extrato!.Gg028NPdv,
                Gg028NfOuCupom = entity.Extrato!.Gg028NfOuCupom,
                Gg028EntsaidaId = entity.Extrato!.Gg028EntsaidaId,
                Gg028NaturezaId = entity.Extrato!.Gg028NaturezaId,
                CS_GG008_DescricaoReduzida = entity.DescricaoReduzidaProduto,
                CS_GG008_CodigoProduto = entity.CodigoProduto,
                Natureza = entity.Natureza,
                NF_Cupom = entity.NF_Cupom,
                Nome_Usuario = entity.Nome_Usuario,
                Almoxarifado_NS = entity.Almoxarifado_NS,
                TipoMovimento = entity.TipoMovimento,
                CodigoProduto = entity.CodigoProduto,
            };
        }
    }
}
