

namespace CSCore.Domain;

public partial class CSICP_BB01201
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Bb012Zonaid { get; set; }

    public string? Bb012Atividadeid { get; set; }

    public decimal? Bb012Limitecredito { get; set; }

    public decimal? Bb012Limcreditosecun { get; set; }

    public decimal? Bb012Limiteccredito { get; set; }

    public decimal? Bb012Diavenctocartao { get; set; }

    public string? Bb012Contaconvenio { get; set; }

    public decimal? Bb012Diaspagtoconv { get; set; }

    public string? Bb012Padraobancoid { get; set; }

    public string? Bb012Bcoagenciaconta { get; set; }

    public int? Bb012Revenda { get; set; }

    public decimal? Bb012TaxaAdministracaoCon { get; set; }

    public int? Bb012Requisicao { get; set; }

    public string? Bb012Contacontabil { get; set; }

    public string? Bb012Historicocontabilid { get; set; }

    public decimal? Bb012Contratocartao { get; set; }

    public DateTime? Bb012Datacontratocartao { get; set; }

    public DateTime? Bb012Dtvalidadecartao { get; set; }

    public string? Bb012Modalidadecredcartao { get; set; }

    public decimal? Bb012Perclimcredito { get; set; }

    public decimal? Bb012Prazoentregafornec { get; set; }

    public string? Bb012Condpagtofornec { get; set; }

    public string? Bb012Natoperacaoid { get; set; }

    public string? Bb012Condpagtoid { get; set; }

    public string? Bb012Textonotaid { get; set; }

    public string? Bb012GrauRisco { get; set; }

    public string? Bb012ClasseCredito { get; set; }

    public DateTime? Bb012Dtvalidcadastro { get; set; }

    public decimal? Bb012PercIcms { get; set; }

    public string? Bb012Codgcategoria { get; set; }

    public string? Bb012Categoriaid { get; set; }

    public decimal? Bb012Limitecredparcela { get; set; }

    public decimal? Bb012NumUltFatura { get; set; }

    public decimal? Bb012Totcompracarnet { get; set; }

    public decimal? Bb012ValorEntrada { get; set; }

    public decimal? Bb012MaiorCompra { get; set; }

    public decimal? Bb012MenorCompra { get; set; }

    public decimal? Bb012Totdiasatraso { get; set; }

    public decimal? Bb012MaiorAtraso { get; set; }

    public decimal? Bb012MenorAtraso { get; set; }

    public decimal? Bb012Mediadeatraso { get; set; }

    public decimal? Bb012Maiorsaldo { get; set; }

    public decimal? Bb012Numcompras { get; set; }

    public DateTime? Bb012Dtprimcompra { get; set; }

    public DateTime? Bb012Dtultcompra { get; set; }

    public decimal? Bb012Vlrmaiorpagto { get; set; }

    public decimal? Bb012Numpagtodia { get; set; }

    public decimal? Bb012Numpagtoatraso { get; set; }

    public decimal? Bb012Saldodevedor { get; set; }

    public decimal? Bb012Saldopedido { get; set; }

    public decimal? Bb012Qtdtitprotestado { get; set; }

    public DateTime? Bb012Ultprotesto { get; set; }

    public decimal? Bb012Qtdchqdevolvido { get; set; }

    public DateTime? Bb012Ultchqdevolvido { get; set; }

    public int? Bb012ConvenioId { get; set; }

    public int? Bb012TipogeracaoId { get; set; }

    public int? Bb012SitespecialId { get; set; }

    public string? Bb012Entmtgrotaid { get; set; }

    public string? Bb012Vendarotaid { get; set; }

    public string? Bb012Diavenctoid { get; set; }

    public string? Bb012Codgbcodebconta { get; set; }

    public CSICP_Bb010? BB010_Zona { get; set; }
    public CSICP_Bb011? BB011_Atividade { get; set; }
    public CSICP_Bb006? BB006_BancoPadrao { get; set; }
    public CSICP_Statica? Revenda { get; set; }
    public CSICP_Statica? Requisicao { get; set; }
    public CSICP_Bb025? BB025_NatOperacao { get; set; }
    public CSICP_Bb008? BB008_CondPagamento { get; set; }
    public CSICP_Bb029? BB029_Categoria { get; set; }
    public CSICP_Bb01201Con? BB01201_Convenio { get; set; }
    public CSICP_Bb01201Tger? BB01201_TpGeracao { get; set; }
    public CSICP_Bb01201Jur? BB01201_SitEspecial { get; set; }
    public CSICP_Bb010? BB010_EntregaMontagem { get; set; }
    public CSICP_Bb010? BB010_VendaRota { get; set; }
    public CSICP_Bb037? BB037_DiaVencimento { get; set; }

    //public CSICP_BB012 IdNavigation { get; set; } = null!;
}
