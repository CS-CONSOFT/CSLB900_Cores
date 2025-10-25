using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG520
{
    public class DtoCreateUpdateGG520 : IConverteParaEntidade<CSICP_GG520>
    {
        public string? Gg520Filialid { get; set; }

        public string? Gg520KardexId { get; set; }

        public string? Gg520Almoxid { get; set; }

        public decimal? Gg520NsNumerosaldo { get; set; }

        public string? Gg520Descricaosaldo { get; set; }

        public int? Gg520Filial { get; set; }

        public int? Gg520Codalmoxarifado { get; set; }

        public int? Gg520Produto { get; set; }

        public decimal Gg520Saldo { get; set; } = -1;

        public decimal? Gg520Qtdcomprometida { get; set; }

        public decimal? Gg520QtdProducao { get; set; }

        public decimal? Gg520QtdEmpenho { get; set; }

        public decimal? Gg520QtdReserva { get; set; }

        public decimal? Gg520Qnpt { get; set; }

        public decimal? Gg520Qtnp { get; set; }

        public DateTime? Gg520Ultinventario { get; set; }

        public DateTime? Gg520Ultfechamento { get; set; }

        public decimal? Gg520Qtdultfechamento { get; set; }

        public bool? Gg520ItemEmContagem { get; set; }

        public DateTime? Gg520Proxinventario { get; set; }

        public DateTime? Gg520Ultrecebimento { get; set; }

        public decimal? Gg520Qtdultrecebto { get; set; }

        public DateTime? Gg520UltimaVenda { get; set; }

        public decimal? Gg520QtdeUltVenda { get; set; }

        public decimal? Gg520Qtdpedidocompra { get; set; }

        public string? Gg520Lote { get; set; }

        public string? Gg520Sublote { get; set; }

        public string? Gg520DescricaoLote { get; set; }

        public string? Gg520Compraid { get; set; }

        public int? Gg520CodgFornecedor { get; set; }

        public string? Gg520Contaid { get; set; }

        public string? Gg520Usuarioid { get; set; }

        public DateTime? Gg520DataFabricacao { get; set; }

        public DateTime? Gg520DataValidade { get; set; }

        public int? Gg520DiasValidade { get; set; }

        public int? Gg520Docto { get; set; }

        public string? Gg520Serie { get; set; }

        public DateTime? Gg520Compraentrada { get; set; }

        public string? Gg520Gradelinhaid { get; set; }

        public string? Gg520Gradecolunaid { get; set; }

        public string? Gg520Codggradelinha { get; set; }

        public string? Gg520Codggradecoluna { get; set; }

        public decimal? Gg520EstqMinimo { get; set; }

        public decimal? Gg520Estoquemaximo { get; set; }

        public string? Gg520Localizacaowms { get; set; }

        public decimal? Gg520Superpromocao { get; set; }

        public int? Gg520Periodicidadeinv { get; set; }

        public bool? Gg520Exibiremconsulta { get; set; }

        public bool? Gg520Saldozerodesabautom { get; set; }

        public bool? Gg520Permitetroca { get; set; }

        public decimal? Gg520Vbcstret { get; set; }

        public decimal? Gg520Vicmsstret { get; set; }

        public bool? Gg520Isactive { get; set; }

        public string? Gg520CodbarrasId { get; set; }

        public DateTime? Gg520Timestamp { get; set; }

        public bool? Gg520Ispdv { get; set; }

        public decimal? Gg520Vicmssubstituto { get; set; }

        public string? Gg520VfuturaSaldoid { get; set; }

        public CSICP_GG520 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG520
            {
                TenantId = tenant,
                Id = id!,
                Gg520Filialid = this.Gg520Filialid,
                Gg520KardexId = this.Gg520KardexId,
                Gg520Almoxid = this.Gg520Almoxid,
                Gg520NsNumerosaldo = this.Gg520NsNumerosaldo,
                Gg520Descricaosaldo = this.Gg520Descricaosaldo,
                Gg520Filial = this.Gg520Filial,
                Gg520Codalmoxarifado = this.Gg520Codalmoxarifado,
                Gg520Produto = this.Gg520Produto,
                Gg520Saldo = this.Gg520Saldo,
                Gg520Qtdcomprometida = this.Gg520Qtdcomprometida,
                Gg520QtdProducao = this.Gg520QtdProducao,
                Gg520QtdEmpenho = this.Gg520QtdEmpenho,
                Gg520QtdReserva = this.Gg520QtdReserva,
                Gg520Qnpt = this.Gg520Qnpt,
                Gg520Qtnp = this.Gg520Qtnp,
                Gg520Ultinventario = this.Gg520Ultinventario,
                Gg520Ultfechamento = this.Gg520Ultfechamento,
                Gg520Qtdultfechamento = this.Gg520Qtdultfechamento,
                Gg520ItemEmContagem = this.Gg520ItemEmContagem,
                Gg520Proxinventario = this.Gg520Proxinventario,
                Gg520Ultrecebimento = this.Gg520Ultrecebimento,
                Gg520Qtdultrecebto = this.Gg520Qtdultrecebto,
                Gg520UltimaVenda = this.Gg520UltimaVenda,
                Gg520QtdeUltVenda = this.Gg520QtdeUltVenda,
                Gg520Qtdpedidocompra = this.Gg520Qtdpedidocompra,
                Gg520Lote = this.Gg520Lote,
                Gg520Sublote = this.Gg520Sublote,
                Gg520DescricaoLote = this.Gg520DescricaoLote,
                Gg520Compraid = this.Gg520Compraid,
                Gg520CodgFornecedor = this.Gg520CodgFornecedor,
                Gg520Contaid = this.Gg520Contaid,
                Gg520Usuarioid = this.Gg520Usuarioid,
                Gg520DataFabricacao = this.Gg520DataFabricacao,
                Gg520DataValidade = this.Gg520DataValidade,
                Gg520DiasValidade = this.Gg520DiasValidade,
                Gg520Docto = this.Gg520Docto,
                Gg520Serie = this.Gg520Serie,
                Gg520Compraentrada = this.Gg520Compraentrada,
                Gg520Gradelinhaid = this.Gg520Gradelinhaid,
                Gg520Gradecolunaid = this.Gg520Gradecolunaid,
                Gg520Codggradelinha = this.Gg520Codggradelinha,
                Gg520Codggradecoluna = this.Gg520Codggradecoluna,
                Gg520EstqMinimo = this.Gg520EstqMinimo,
                Gg520Estoquemaximo = this.Gg520Estoquemaximo,
                Gg520Localizacaowms = this.Gg520Localizacaowms,
                Gg520Superpromocao = this.Gg520Superpromocao,
                Gg520Periodicidadeinv = this.Gg520Periodicidadeinv,
                Gg520Exibiremconsulta = this.Gg520Exibiremconsulta,
                Gg520Saldozerodesabautom = this.Gg520Saldozerodesabautom,
                Gg520Permitetroca = this.Gg520Permitetroca,
                Gg520Vbcstret = this.Gg520Vbcstret,
                Gg520Vicmsstret = this.Gg520Vicmsstret,
                Gg520Isactive = this.Gg520Isactive,
                Gg520CodbarrasId = this.Gg520CodbarrasId,
                Gg520Timestamp = this.Gg520Timestamp,
                Gg520Ispdv = this.Gg520Ispdv,
                Gg520Vicmssubstituto = this.Gg520Vicmssubstituto,
                Gg520VfuturaSaldoid = this.Gg520VfuturaSaldoid,
            };
        }
    }
}
