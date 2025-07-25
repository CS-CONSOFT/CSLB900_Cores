using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.CS_Models.Staticas.NFS;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG008
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Gg008Filialid { get; set; } = string.Empty!;

    public int? Gg008Filial { get; set; }

    public int? Gg008Codgproduto { get; set; }

    public string? Gg008TipoProduto { get; set; }

    public int? Gg008CodigoGrupo { get; set; }

    public int? Gg008CodigoClasse { get; set; }

    public int? Gg008CodigoArtigo { get; set; }

    public int? Gg008CodigoMarca { get; set; }

    public string? Gg008CodigoPadrao { get; set; }

    public string? Gg008CodigoTipo { get; set; }

    public string? Gg008CodigoQualidade { get; set; }

    public string? Gg008Tipoprodutoid { get; set; }

    public string? Gg008Grupoid { get; set; }

    public string? Gg008Subgrupoid { get; set; }

    public string? Gg008Classeid { get; set; }

    public string? Gg008Artigoid { get; set; }

    public string? Gg008Marcaid { get; set; }

    public string? Gg008Linhaid { get; set; }

    public string? Gg008Padraoid { get; set; }

    public string? Gg008Tipoid { get; set; }

    public string? Gg008Qualidadeid { get; set; }

    public string? Gg008Referencia { get; set; }

    public string? Gg008Complemento { get; set; }

    public string? Gg008Codindustrial { get; set; }

    public int? Gg008Safradiamesinicio { get; set; }

    public int? Gg008SafraDiamesfim { get; set; }

    public int? Gg008Etiqueta { get; set; }

    public int? Gg008Ncm { get; set; }

    public string? Gg008ExNcm { get; set; }

    public string? Gg008Ncmid { get; set; }

    public decimal? Gg008PesoBruto { get; set; }

    public decimal? Gg008PesoLiquido { get; set; }

    public decimal? Gg008Tamanho { get; set; }

    public decimal? Gg008Largura { get; set; }

    public decimal? Gg008Espessura { get; set; }

    public string? Gg008Embalagem1 { get; set; }

    public string? Gg008Embalagem2 { get; set; }

    public decimal? Gg008QtdEmbalagem1 { get; set; }

    public decimal? Gg008QtdEmbalagem2 { get; set; }

    public decimal? Gg008Comprimentoarmaz { get; set; }

    public decimal? Gg008LarguraArmaz { get; set; }

    public decimal? Gg008AlturaArmaz { get; set; }

    public decimal? Gg008FatorArmaz { get; set; }

    public decimal? Gg008Empilhagem { get; set; }

    public string? Gg008Descreduzida { get; set; }

    public int? Gg008UsaNroSerie { get; set; }

    public string? Gg008Refersimilar { get; set; }

    public int? Gg008Przgarancompra { get; set; }

    public int? Gg008Przgaranvenda { get; set; }

    public int? Gg008Servico { get; set; }

    public int? Gg008Montavel { get; set; }

    public string? Gg008Classifvegetal { get; set; }

    public bool? Gg008IsActive { get; set; }

    public int? Gg008EstadofisicoId { get; set; }

    public int? Gg008TpgarantiacompraId { get; set; }

    public int? Gg008TpgarantiavendaId { get; set; }

    public int? Gg008TipokitId { get; set; }

    public int? Gg008PesavelId { get; set; }

    public bool? Gg008Isforalinha { get; set; }

    public DateTime? Gg008Dataforalinha { get; set; }

    public int? Gg008ListservicoId { get; set; }

    public int? Gg008Grpsubgrupoid { get; set; }

    public long? Gg008Sequence { get; set; }

    public DateTime? Gg008Dultalteracao { get; set; }

    public int? Gg008Entregar { get; set; }

    public bool? Gg008Isecommerce { get; set; }

    public string? Gg008AnpId { get; set; }

    public DateTime? Gg008Dregistro { get; set; }

    public string? Gg008Usuariopropid { get; set; }

    public string? Gg008Usuarioaltid { get; set; }

    public int? Gg008Ierelevanteid { get; set; }

    public string? Gg008Cnpjfabricante { get; set; }

    public string? Gg008Nomefabricante { get; set; }

    public decimal? Gg008Vicmsproprio { get; set; }

    //public string? Gg008Descpeqwms1 { get; set; }

    //public string? Gg008Descpeqwms2 { get; set; }

    public string? Gg008Descespecial1 { get; set; }

    public string? Gg008Descespecial2 { get; set; }

    public CSICP_BB001? NavFilialBB001 { get; set; }
    public CSICP_GG002? NavTipodeProdutosGG002 { get; set; }
    public CSICP_GG003? NavGrupoProdutoGG003 { get; set; }
    public CSICP_GG004? NavClasseProdutoGG004 { get; set; }
    public CSICP_GG005? NavArtigoProdutoGG005 { get; set; }
    public CSICP_GG006? NavMarcaProdutoGG006 { get; set; }
    public CSICP_GG009? NavPadraoProdutoGG009 { get; set; }
    public CSICP_GG010? NavTipoPadraoProdutoGG010 { get; set; }
    public CSICP_GG011? NavQualidadeProdutoGG011 { get; set; }
    public CSICP_GG014? NavLinhaProdutoGG014 { get; set; }
    public CSICP_GG015? NavSubGrupoProdutoGG015 { get; set; }
    public CSICP_GG021? NavNCMProdutoGG021 { get; set; }
    public CSICP_GG060? NavGG060_GrpSubGrupo { get; set; }
    public CSICP_GG029? NavGG029_ANP { get; set; }
    public Csicp_Sy001? NavSY001_UsuarioProp { get; set; }
    public Csicp_Sy001? NavSY001_UsuarioAlt { get; set; }
    public CSICP_GG008Efi? NavGG008_EstadoFisico { get; set; }
    public CSICP_GG008Gar? NavGG008_TpGarantiaCompra { get; set; }
    //public CSICP_GG008Kdx? NavGG008_Kardex { get; set; }
    public CSICP_GG008Gar? NavGG008_TpGarantiaVenda { get; set; }
    public CSICP_GG008Kit? NavGG008_TipoKit { get; set; }
    public Osusr66cCsicpNfsLstserv? NavGG008_ListServico { get; set; }
    public CSICP_Statica? NavGG008_Etiqueta { get; set; }
    public CSICP_Statica? NavGG008_Usa_Nro_Serie { get; set; }
    public CSICP_Statica? NavGG008_Servico { get; set; }
    public CSICP_Statica? NavGG008_Montavel { get; set; }
    public CSICP_Statica? NavGG008_Pesavel { get; set; }
    public CSICP_Statica? NavGG008_Entregar { get; set; }
    public SpedCsicpStrelevancium? Navgg008_IERelevante { get; set; }
}
