using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG028
{
    public class DtoCreateUpdateGG028 : IConverteParaEntidade<CSICP_GG028>
    {

        public string? Gg028Filialid { get; set; }

        public int? Gg028Filial { get; set; }

        public string? Gg028Protocolnumber { get; set; }

        public string? Gg028Origemprograma { get; set; }

        public string? Gg028OrigemPkid { get; set; }

        public DateTime? Gg028DataMovimento { get; set; }

        public DateTime? Gg028DataReferente { get; set; }

        public string? Gg028Almoxid { get; set; }

        public string? Gg028KardexId { get; set; }

        public string? Gg028Produtoid { get; set; }

        public string? Gg028Saldoid { get; set; }

        public string? Gg028Transacaoid { get; set; }

        //public string? Gg028Tipomovimentoid { get; set; }

        public string? Gg028Contaid { get; set; }

        public string? Gg028Usuarioid { get; set; }

        public decimal? Gg028QtdMovimento { get; set; }

        public decimal? Gg028ValorUnitario { get; set; }

        public decimal? Gg028SaldoAnterior { get; set; }

        public string? Gg028DocProtocolnumber { get; set; }

        public string? Gg028DoctoId { get; set; }

        public int? Gg028NPdv { get; set; }

        public decimal? Gg028NfOuCupom { get; set; }

        public int? Gg028EntsaidaId { get; set; }

        public int? Gg028NaturezaId { get; set; }

        public CSICP_GG028 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG028
            {
                TenantId = tenant,
                Id = id!,
                Gg028Filialid = this.Gg028Filialid,
                Gg028Filial = this.Gg028Filial,
                Gg028Protocolnumber = this.Gg028Protocolnumber,
                Gg028Origemprograma = this.Gg028Origemprograma,
                Gg028OrigemPkid = this.Gg028OrigemPkid,
                Gg028DataMovimento = this.Gg028DataMovimento,
                Gg028DataReferente = this.Gg028DataReferente,
                Gg028Almoxid = this.Gg028Almoxid,
                Gg028KardexId = this.Gg028KardexId,
                Gg028Produtoid = this.Gg028Produtoid,
                Gg028Saldoid = this.Gg028Saldoid,
                Gg028Transacaoid = this.Gg028Transacaoid,
                Gg028Contaid = this.Gg028Contaid,
                Gg028Usuarioid = this.Gg028Usuarioid,
                Gg028QtdMovimento = this.Gg028QtdMovimento,
                Gg028ValorUnitario = this.Gg028ValorUnitario,
                Gg028SaldoAnterior = this.Gg028SaldoAnterior,
                Gg028DocProtocolnumber = this.Gg028DocProtocolnumber,
                Gg028DoctoId = this.Gg028DoctoId,
                Gg028NPdv = this.Gg028NPdv,
                Gg028NfOuCupom = this.Gg028NfOuCupom,
                Gg028EntsaidaId = this.Gg028EntsaidaId,
                Gg028NaturezaId = this.Gg028NaturezaId,

            };
        }
    }
}

