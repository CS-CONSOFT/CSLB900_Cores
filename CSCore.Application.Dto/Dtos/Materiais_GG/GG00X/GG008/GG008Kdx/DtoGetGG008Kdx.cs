using CSBS101._82Application.Dto.BB00X.BB003;
using CSBS101._82Application.Dto.BB00X.BB005;
using CSBS101._82Application.Dto.BB00X.BB012.Get;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using CSCore.Domain;
using CSCore.Domain.CS_Models.Staticas.GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG001;
using FF105Financeiro.C82Application.Dto.GG00X.GG007;
using FF105Financeiro.C82Application.Dto.GG00X.GG008.GG008p;

namespace FF105Financeiro.C82Application.Dto.GG00X.GG008.GG008Kdx
{
    public class DtoGetGG008Kdx
    {
        public int TenantId { get; set; }

        public string Gg008Kardexid { get; set; } = null!;

        public string? Gg008Filialid { get; set; }

        public string? Gg008Produtoid { get; set; }

        public int? Gg008Codalmoxpadrao { get; set; }

        public int? Gg008Codalmtransf { get; set; }

        public string? Gg008Almoxpadraoid { get; set; }

        public string? Gg008Almoxtransfid { get; set; }

        public string? Gg008Unidade { get; set; }

        public string? Gg008Unidsecundaria { get; set; }

        public string? Gg008Unvendavarejoid { get; set; }

        public string? Gg008Uncompravarejoid { get; set; }

        public string? Gg008Unvendaatacadoid { get; set; }

        public decimal? Gg008FatorConversao { get; set; }

        public decimal? Gg008AliquotaIpi { get; set; }

        public decimal? Gg008AliquotaIcms { get; set; }

        public decimal? Gg008AliqIcmsReduzidaPdv { get; set; }

        public decimal? Gg008AliquotaIss { get; set; }

        public decimal? Gg008Margemlucrosai { get; set; }

        public decimal? Gg008Margemlucroent { get; set; }

        public int? Gg008CalculaIrrf { get; set; }

        public int? Gg008CalculaInss { get; set; }

        public decimal? Gg008PercCsll { get; set; }

        public decimal? Gg008PercCofins { get; set; }

        public decimal? Gg008PercPis { get; set; }

        public decimal? Gg008IcmsPauta { get; set; }

        public decimal? Gg008IpiPauta { get; set; }

        public decimal? Gg008Qtdpedidocompra { get; set; }

        public decimal? Gg008EstoqueMinimo { get; set; }

        public decimal? Gg008EstoqueMaximo { get; set; }

        public decimal? Gg008TempoReposicao { get; set; }

        public decimal? Gg008PontoPedido { get; set; }

        public decimal? Gg008LoteEconomico { get; set; }

        public decimal? Gg008GrauAtendimento { get; set; }

        public decimal? Gg008PercTolerancia { get; set; }

        public string? Gg008Abc { get; set; }

        public decimal? Gg008PercComissao { get; set; }

        public DateTime? Gg008DataFabricacao { get; set; }

        public DateTime? Gg008DataValidade { get; set; }

        public int? Gg008DiasValidade { get; set; }

        public decimal? Gg008CustoMedio { get; set; }

        public decimal? Gg008PrecoReposicao { get; set; }

        public decimal? Gg008PercDescItem { get; set; }

        public decimal? Gg008Prcpromocional { get; set; }

        public decimal? Gg008QtdPromocional { get; set; }

        public decimal? Gg008FatorLucro { get; set; }

        public decimal? Gg008PrcVendavarejo { get; set; }

        public decimal? Gg008PrcVndMercado { get; set; }

        public DateTime? Gg008Ultreajprcvenda { get; set; }

        public decimal? Gg008PrecoVendaLiq { get; set; }

        public decimal? Gg008Vlrmargemlucro { get; set; }

        public int? Gg008Alteraprcvenda { get; set; }

        public decimal? Gg008PrecoCusto { get; set; }

        public DateTime? Gg008Ultreajprccusto { get; set; }

        public decimal? Gg008PrecoCustoReal { get; set; }

        public int? Gg008CentroCusto { get; set; }

        public string? Gg008Ccustoid { get; set; }

        public string? Gg008ContaContabil { get; set; }

        public string? Gg008ClasseContabil { get; set; }

        public int? Gg008FornecedorCanal { get; set; }

        public int? Gg008Fornecedorpadrao { get; set; }

        public string? Gg008Contaid { get; set; }

        public int? Gg008Periodicidadeinv { get; set; }

        public int? Gg008ControlaSaldo { get; set; }

        public int? Gg008ControleLote { get; set; }

        public int? Gg008ControleGrade { get; set; }

        public int? Gg008Anuente { get; set; }

        public int? Gg008Restricao { get; set; }

        public string? Gg008Grupocomprasid { get; set; }

        public int? Gg008Permsldnegativo { get; set; }

        public int? Gg008Minutaautomatica { get; set; }

        public int? Gg008Requisautomatica { get; set; }

        public DateTime? Gg008DataDesativacao { get; set; }

        public string? Gg008Localizfixa { get; set; }

        public string? Gg008Diversos { get; set; }

        public decimal? Gg008AliqDifPis { get; set; }

        public decimal? Gg008AliqDifCofins { get; set; }

        public decimal? Gg008EanTributavel { get; set; }

        public string? Gg008Untributavelid { get; set; }

        public decimal? Gg008FatorUnidade { get; set; }

        public decimal? Gg008ValorPis { get; set; }

        public decimal? Gg008ValorCofins { get; set; }

        public bool? Gg008IsActive { get; set; }

        public int? Gg008TipoConversaoId { get; set; }

        public int? Gg008TipoprazoId { get; set; }

        public int? Gg008TpContribuicaoId { get; set; }

        public bool? Gg008RiControlequalidade { get; set; }

        public decimal? Gg008AliquotaIrpj { get; set; }

        public decimal? Gg008RetencaoAliqInss { get; set; }

        public decimal? Gg008RetencaoAliqIrrf { get; set; }

        public int? Gg008DescontoSuframa { get; set; }

        public DateTime? Gg008Timestamp { get; set; }

        public decimal? Gg008Plucro { get; set; }

        public bool? Gg008IsctrlGondola { get; set; }

        public decimal? Gg008Qmediaconsumo { get; set; }

        public decimal? Gg008Vmediaconsumo { get; set; }

        public DateTime? Gg008Dtultprocle { get; set; }

        public decimal? Gg008VuncompraCmedio { get; set; }

        public decimal? Gg008VuncompraReposicao { get; set; }

        public decimal? Gg008VuncompraPrcvenda { get; set; }

        public decimal? Gg008VuncompraPrcmercado { get; set; }

        public decimal? Gg008VuncompraPrccusto { get; set; }

        public decimal? Gg008VuncompraCustoreal { get; set; }

        public decimal? Gg008VuncompraVlrmarglucro { get; set; }

        public string? Gg008Moedaid { get; set; }

        public decimal? Gg008Vmoeda { get; set; }

        public decimal? Gg008Prcecommerce { get; set; }

        public int? Gg008Auditasn { get; set; }

        public int? Gg008Possuisaldo { get; set; }

        public DateTime? Gg008Ultrecebimento { get; set; }

        public decimal? Gg008Qtdultrecebto { get; set; }

        public DateTime? Gg008UltimaVenda { get; set; }

        public decimal? Gg008QtdeUltVenda { get; set; }

        public int? Gg008TpcbarratribId { get; set; }

        public Dto_GetBB001Simples? NavBB001Filial { get; set; }
        public DtoGetGG008p? NavGG008pOutrosPrecos { get; set; }
        public DtoGetGG008Simples? NavGG008Produto { get; set; }
        public DtoGetGG001Simples? NavGG001AlmoxarifadoPadrao { get; set; }
        public DtoGetGG001Simples? NavGG001AlmoxarifadoTransferencia { get; set; }
        public DtoGetGG007Simples? NavGG007UNVendaVarejo { get; set; }
        public DtoGetGG007Simples? NavGG007UNCompraVarejo { get; set; }
        public DtoGetGG007Simples? NavGG007UNVendaAtacado { get; set; }
        public DtoGetGG007Simples? NavGG007UNTributavel { get; set; }
        public Dto_GetBB005? NavBB005_CCusto { get; set; }
        public Dto_GetBB003? NavBB003_Moeda { get; set; }
        public Dto_GetBB012Simples? NavBB012_Conta { get; set; }
        public CSICP_GG008Con? NavGG008_Tipo_Conversao { get; set; }
        public CSICP_GG008Gar? NavGG008_TipoPrazo { get; set; }
        public CSICP_GG019Cgbar? NavGG019_tpCBarraTrib { get; set; }
        public OsusrE9aCsicpGg008Tpcon? NavGG008_Tp_Contribuicao { get; set; }
        public CSICP_Statica? NavGG008_AuditaSN { get; set; }
        public CSICP_Statica? NavGG008_Desconto_SUFRAMA { get; set; }
        public CSICP_Statica? NavGG008_Calcula_IRRF { get; set; }
        public CSICP_Statica? NavGG008_Calcula_INSS { get; set; }
        public CSICP_Statica? NavGG008_AlteraPrcVenda { get; set; }
        public CSICP_Statica? NavGG008_Fornecedor_Canal { get; set; }
        public CSICP_Statica? NavGG008_Controla_Saldo { get; set; }
        public CSICP_Statica? NavGG008_Controle_Lote { get; set; }
        public CSICP_Statica? NavGG008_Controle_Grade { get; set; }
        public CSICP_Statica? NavGG008_Anuente { get; set; }
        public CSICP_Statica? NavGG008_Restricao { get; set; }
        public CSICP_Statica? NavGG008_PermSldNegativo { get; set; }
        public CSICP_Statica? NavGG008_MinutaAutomatica { get; set; }
        public CSICP_Statica? NavGG008_RequisAutomatica { get; set; }

    }




}
