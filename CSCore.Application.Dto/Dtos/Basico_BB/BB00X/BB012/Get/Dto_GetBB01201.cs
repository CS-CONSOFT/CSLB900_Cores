using CSBS101._82Application.Dto.BB00X.BB006;
using CSBS101._82Application.Dto.BB00X.BB011;
using CSBS101._82Application.Dto.BB00X.BB01X.BB010;
using CSBS101._82Application.Dto.BB00X.BB025;
using CSBS101._82Application.Dto.BB00X.BB029;
using CSBS101._82Application.Dto.BB00X.BB037;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB008;
using CSCore.Domain;


namespace CSBS101._82Application.Dto.BB00X.BB012.Get
{
    public class Dto_GetBB01201
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
        public Dto_GetBB010_Zona_Exibicao? NavBB010_Zona { get; set; }
        public Dto_GetBB010_Zona_Exibicao? NavBB010_EntregaMontagem { get; set; }
        public Dto_GetBB010_Zona_Exibicao? NavBB010_VendaRota { get; set; }
        public Dto_GetBB011? NavBB011_Atividade { get; set; }
        public Dto_GetBB006_Exibicao? NavBB006_BancoPadrao { get; set; }
        public CSICP_Statica? NavRevenda { get; set; }
        public CSICP_Statica? NavRequisicao { get; set; }
        public Dto_GetBB025_Exibicao? NavBB025_NatOperacao { get; set; }
        public Dto_GetBB008_Exibicao? NavBB008_CondPagamento { get; set; }
        public Dto_GetBB029? NavBB029_Categoria { get; set; }
        public CSICP_Bb01201Con? NavBB01201_Convenio { get; set; }
        public CSICP_Bb01201Tger? NavBB01201_TpGeracao { get; set; }
        public CSICP_Bb01201Jur? NavBB01201_SitEspecial { get; set; }
        public Dto_GetBB037? NavBB037_DiaVencimento { get; set; }

    }
}
