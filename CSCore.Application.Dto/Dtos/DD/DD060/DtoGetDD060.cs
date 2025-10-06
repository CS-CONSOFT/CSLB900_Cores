using CSCore.Application.Dto.Dtos.DD.DD061;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008Kdx;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.Staticas.GG;
using EnviaNFeHercules.C82Application.Dto.DD.DD061;
using GG104Materiais.C82Application.Dto.GG00X.GG005;
using GG104Materiais.C82Application.Dto.GG00X.GG006;
using GG104Materiais.C82Application.Dto.GG00X.GG007;
using GG104Materiais.C82Application.Dto.GG00X.GG008;
using GG104Materiais.C82Application.Dto.GG00X.GG021;

namespace EnviaNFeHercules.C82Application.Dto.DD.DD060
{
    public class DtoGetDD060
    {
        public int TenantId { get; set; }

        public string Dd060Id { get; set; } = null!;

        public string? Dd040Id { get; set; }

        public string? Dd060Produtoid { get; set; }

        public string? Dd060Saldoid { get; set; }

        public int? Dd060Codgalmox { get; set; }

        public int? Dd060CodigoProduto { get; set; }

        public decimal? Dd060CodigoBarras { get; set; }

        public int? Dd060Filial { get; set; }

        public decimal? Dd060Ci { get; set; }

        public int? Dd060Sequencia { get; set; }

        public string? Dd060Lote { get; set; }

        public string? Dd060SubLote { get; set; }

        public string? Dd060Localizacao { get; set; }

        public string? Dd060CodgLinha { get; set; }

        public string? Dd060CodgColuna { get; set; }

        public decimal? Dd060Quantidade { get; set; }

        public decimal? Dd060PrecoTabela { get; set; }

        public decimal? Dd060Totalbruto { get; set; }

        public decimal? Dd060VlrDescSt1liq { get; set; }

        public decimal? Dd060Pacrescimo { get; set; }

        public decimal? Dd060Vacrescimo { get; set; }

        public decimal? Dd060PrcTabela2 { get; set; }

        public int? Dd060Tpdesc { get; set; }

        public decimal? Dd060PercDesconto { get; set; }

        public decimal? Dd060ValorDesconto { get; set; }

        public decimal? Dd060PrecoUnitario { get; set; }

        public decimal? Dd060Totliqproduto { get; set; }

        public decimal? Dd060St2Liquido { get; set; }

        public decimal? Dd060TotalDescCascata { get; set; }

        public decimal? Dd060TotalDesconto { get; set; }

        public decimal? Dd060Frete { get; set; }

        public decimal? Dd060Seguro { get; set; }

        public decimal? Dd060Odespesas { get; set; }

        public decimal? Dd060TotalLiquido { get; set; }

        public decimal? Dd060Vdescsuframa { get; set; }

        public decimal? Dd060Vdesccupom { get; set; }

        public string? Dd060Descproduto { get; set; }

        public string? Dd060Descprodsecund { get; set; }

        public string? Dd060UnId { get; set; }

        public string? Dd060Unidade { get; set; }

        public string? Dd060CorSerieMerc { get; set; }

        public string? Dd060ResponsavelId { get; set; }

        public int? Dd060RespVendedor { get; set; }

        public int? Dd060RespComprador { get; set; }

        public decimal? Dd060BaseCalcIcms { get; set; }

        public decimal? Dd060PercIcms { get; set; }

        public decimal? Dd060ValorIcms { get; set; }

        public decimal? Dd060BaseCalcSubst { get; set; }

        public decimal? Dd060PercSubstTrib { get; set; }

        public decimal? Dd060Vlrsubsttribaux { get; set; }

        public decimal? Dd060Vlrsubsttribut { get; set; }

        public decimal? Dd060BaseCalcIpi { get; set; }

        public decimal? Dd060PercIpi { get; set; }

        public decimal? Dd060ValorIpi { get; set; }

        public decimal? Dd060Percreducaobaseicms { get; set; }

        public decimal? Dd060ValorAproxImp { get; set; }

        public decimal? Dd060LucroEstimado { get; set; }

        public decimal? Dd060QtdAnterior { get; set; }

        public decimal? Dd060Cicronologicasai { get; set; }

        public decimal? Dd060Cicronologicaent { get; set; }

        public decimal? Dd060Tamanho { get; set; }

        public decimal? Dd060Largura { get; set; }

        public decimal? Dd060Espessura { get; set; }

        public int? Dd060CodgTransacao { get; set; }

        public string? Dd060Cfop { get; set; }

        public string? Dd060Cst { get; set; }

        public DateTime? Dd060DataMovimento { get; set; }

        public bool? Dd060ItemTrocado { get; set; }

        public string? Dd060Ambiente { get; set; }

        public bool? Dd060GeraMinuta { get; set; }

        public bool? Dd060GeraRequisicao { get; set; }

        public bool? Dd060GeraRequisicaoexterna { get; set; }

        public bool? Dd060Entregar { get; set; }

        public bool? Dd060Transferir { get; set; }

        public int? Dd060Filialtransfsaida { get; set; }

        public int? Dd060Almoxtransfsaida { get; set; }

        public decimal? Dd060PrcVendaOrigin { get; set; }

        public decimal? Dd060Precocusto { get; set; }

        public decimal? Dd060Precocustoreal { get; set; }

        public decimal? Dd060Precocustomedio { get; set; }

        public decimal? Dd060Prccustomedioent { get; set; }

        public string? Dd060UnSecId { get; set; }

        public string? Dd060UnSec { get; set; }

        public int? Dd060UnSecTipoconvId { get; set; }

        public decimal? Dd060UnSecFatorconv { get; set; }

        public decimal? Dd060UnSecQtde { get; set; }

        public decimal? Dd060UnSecValor { get; set; }

        public decimal? Dd060UnSecValorLiquido { get; set; }

        public string? Dd060TransacaoId { get; set; }

        public int? Dd060StatusestoqueId { get; set; }

        public int? Dd060RegraaplicadaId { get; set; }

        public string? Dd060SaldovirtualId { get; set; }

        public decimal? Dd060Saldoanterior { get; set; }

        public decimal? Dd060Saldoatual { get; set; }

        public int? Dd060Baixaestoque { get; set; }

        public int? Dd060Controlasaldo { get; set; }

        public int? Dd060Contsaldograde { get; set; }

        public int? Dd060Contsaldolote { get; set; }

        public int? Dd060Contsaldolocal { get; set; }

        public int? Dd060Permsaldoneg { get; set; }

        public decimal? Dd060Perccomissao { get; set; }

        public decimal? Dd060Valorcomissao { get; set; }

        public string? Dd060SaldotransfId { get; set; }

        public int? Dd060Indtot { get; set; }

        public bool? Dd060Isfixarcalcimp { get; set; }

        public string? Dd060CompContaId { get; set; }

        public bool? Dd060Isservico { get; set; }

        public decimal? Dd060Mlucro { get; set; }

        public decimal? Dd060Precoreposicao { get; set; }

        public string? Dd060UsuariovendId { get; set; }

        public string? Dd060Codbarrasalfa { get; set; }

        public string? Dd060Xped { get; set; }

        public int? Dd060Nitemped { get; set; }

        public string? Dd060Infadprod { get; set; }

        public long? Dd060Ambienteid { get; set; }

        public DateTime? Dd060Dpreventrega { get; set; }

        public DateTime? Dd060Dprevmontagem { get; set; }

        public int? Dd060Modentregaid { get; set; }

        public bool? Dd060Isentregue { get; set; }

        public string? Dd060Fpagtoid { get; set; }

        public string? Dd060Condicaopagtoid { get; set; }

        public string? Dd060Cbenefic { get; set; }

        public int? Dd060Ierelevanteid { get; set; }

        public string? Dd060Cnpjfabricante { get; set; }

        public string? Dd060Nomefabricante { get; set; }

        public int? Dd060Motdesoneracaoid { get; set; }

        public decimal? Dd060Picmsdesonerado { get; set; }

        public decimal? Dd060Vicmsdesonerado { get; set; }

        public int? Dd060VicmsdesonsubId { get; set; }

        public bool? Dd08Ismontar { get; set; }

        public bool? Dd060Isinseridopdv { get; set; }

        public decimal? Dd060CashbackVunvendida { get; set; }

        public decimal? Dd060CashbackPvendaliq { get; set; }

        public decimal? Dd060CashbackVpremio { get; set; }
        public int? Dd060Nroprctabela { get; set; }
        //--------------------Reforma Tributária--------------------//

        public string? DD060_RFTRANSACAO_ID { get; set; }

        //----------------------------------------------------------//

        public DtoGetGG005Simples? NavGG005 { get; set; }
        public DtoGetGG006? NavGG006 { get; set; }
        public DtoGetGG007Simples? NavGG007Unidade { get; set; }
        public DtoGetGG007Simples? NavGG007UnidadeSec { get; set; }
        public DtoGetGG008Simples? NavGG008Produto { get; set; }
        public DtoGetGG008Kdx_Simples? NavGG008Kdx { get; set; }
        public DtoGetGG021Simples_ComGG021Cest? NavGG021 { get; set; }
        public DtoGetDD061CfgImp? NavDD061Cfgimp { get; set; }
        public CSICP_AA031Cstori? NavAA031Cstori { get; set; }
        public CSICP_AA032Csticm? NavAA032Csticm { get; set; }
        public CSICP_AA033Cstipi? NavAA033Cstipi { get; set; }
        public CSICP_AA034Cstpi? NavAA034Cstpi { get; set; }
        public CSICP_AA035Cstcof? CSICP_AA035Cstcof { get; set; }
        public CSICP_AA038Modst? NavAA038Modst { get; set; }
        public CSICP_Bb027Modal? NavBB027Modal { get; set; }
        public CSICP_Bb027Motivo? NavBB027Motivo { get; set; }
        public CSICP_Bb027? NavBB027Reforma { get; set; }
        //public CSICP_DD040? NavDD040NF { get; set; }
        public OsusrE9aCsicpGg021cest? NavGG021Cest { get; set; }
        public SpedCsicpStrelevancium? NavStRelavancium { get; set; }
        public Osusr66cSpedInCenqIpi? NavSpedInCenqIpi { get; set; }
        public Osusr66cSpedInCfop? NavSpedInCfop { get; set; }
        public CSICP_AA143? NavAA143LeiComp { get; set; }
        public OsusrE9aCsicpAa144? NavAA144ClassTrib { get; set; }
        public OsusrE9aCsicpAa144? NavAA144ISClassTrib { get; set; }
        public OsusrE9aCsicpAa144? NavAA144TribReg { get; set; }
        public DtoGetDD060Comb? NavDD060Combs { get; set; }
        public IEnumerable<DtoGetDD060CombLa01> NavListDD060CombsLa01 { get; set; } = [];
        public IEnumerable<DtoGetDD061> NavListDD061 { get; set; } = [];



    }
}
