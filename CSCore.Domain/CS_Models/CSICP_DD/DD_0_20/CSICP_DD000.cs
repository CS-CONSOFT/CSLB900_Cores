using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.NFS;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD000
{
    public int TenantId { get; set; }

    public string Dd000ConfigId { get; set; } = null!;

    [ForeignKey("NavDD000Filial")]
    public string? Dd000FilialId { get; set; }

    [ForeignKey("NavDD000PvCcusto")]
    public string? Dd000PvCcustoId { get; set; }
    
    [ForeignKey("NavDD000PvAgcobrador")]
    public string? Dd000PvAgcobradorId { get; set; }

    [ForeignKey("NavDD000PvNatoperacao")]
    public string? Dd000PvNatoperacaoId { get; set; }

    [ForeignKey("NavDD000PvConta")]
    public string? Dd000PvContaId { get; set; }

    [ForeignKey("NavDD000CtrlSerieNf")]
    public string? Dd000CtrlSerieNfId { get; set; }

    [ForeignKey("NavDD000CtrlSerieCf")]
    public string? Dd000CtrlSerieCfId { get; set; }

    [ForeignKey("NavDD000CtrlSerieNfce")]
    public string? Dd000CtrlSerieNfceId { get; set; }

    [ForeignKey("NavDD000PdCcusto")]
    public string? Dd000PdCcustoId { get; set; }

    [ForeignKey("NavDD000PdAgcobrador")]
    public string? Dd000PdAgcobradorId { get; set; }

    [ForeignKey("NavDD000PdNatoperacao")]
    public string? Dd000PdNatoperacaoId { get; set; }

    [ForeignKey("NavDD000PdvCcusto")]
    public string? Dd000PdvCcustoId { get; set; }

    [ForeignKey("NavDD000PdvAgcobrador")]
    public string? Dd000PdvAgcobradorId { get; set; }

    [ForeignKey("NavDD000PdvNatoperacao")]
    public string? Dd000PdvNatoperacaoId { get; set; }

    [ForeignKey("NavDD000CtCcusto")]
    public string? Dd000CtCcustoId { get; set; }

    [ForeignKey("NavDD000CtAgcobrador")]
    public string? Dd000CtAgcobradorId { get; set; }

    [ForeignKey("NavDD000CtNatoperacao")]
    public string? Dd000CtNatoperacaoId { get; set; }

    public int? Dd000Qtddiasvalcotacao { get; set; }

    public int? Dd000Qtddiasvalprevenda { get; set; }

    [ForeignKey("NavDD000QualRegraAplicar")]
    public int? Dd000Qualregraaplicar { get; set; }

    [ForeignKey("NavDD000AmbNfe")]
    public int? Dd000AmbNfeId { get; set; }

    [ForeignKey("NavDD000VersaoNfe")]
    public int? Dd000VersaoNfeId { get; set; }

    [ForeignKey("NavDD000LcertDigital")]
    public int? Dd000LcertdigitalId { get; set; }

    [NotMapped]
    public byte[]? Dd000Arqcertdigitalbinario { get; set; }

    public string? Dd000Arqcertdigital { get; set; }

    public string? Dd000Senhacertdigital { get; set; }

    [ForeignKey("NavDD000NdCcusto")]
    public string? Dd000NdCcustoId { get; set; }

    [ForeignKey("NavDD000NdAgcobrador")]
    public string? Dd000NdAgcobradorId { get; set; }

    [ForeignKey("NavDD000NdNatoperacao")]
    public string? Dd000NdNatoperacaoId { get; set; }

    [ForeignKey("NavDD000DcCcusto")]
    public string? Dd000DcCcustoId { get; set; }

    [ForeignKey("NavDD000DcAgcobrador")]
    public string? Dd000DcAgcobradorId { get; set; }

    [ForeignKey("NavDD000DcNatoperacao")]
    public string? Dd000DcNatoperacaoId { get; set; }

    [ForeignKey("NavDD000DisCcusto")]
    public string? Dd000DisCcustoId { get; set; }

    [ForeignKey("NavDD000DisAgcobrador")]
    public string? Dd000DisAgcobradorId { get; set; }

    [ForeignKey("NavDD000DisNatoperacao")]
    public string? Dd000DisNatoperacaoId { get; set; }

    [ForeignKey("NavDD000ZoneTime")]
    public int? Dd000ZonetimeId { get; set; }

    [ForeignKey("NavDD000CpCcusto")]
    public string? Dd000CpCcustoId { get; set; }

    [ForeignKey("NavDD000CpAgcobrador")]
    public string? Dd000CpAgcobradorId { get; set; }

    [ForeignKey("NavDD000CpCondpagto")]
    public string? Dd000CpCondpagtoId { get; set; }

    [ForeignKey("NavDD000CpFormapagto")]
    public string? Dd000CpFormapagtoId { get; set; }

    public int? Dd000CpDiaVencto { get; set; }

    [ForeignKey("NavDD000UfOrgao")]
    public string? Dd000UfOrgaoId { get; set; }

    public int? Dd000Qtddiasvaletiq { get; set; }

    public bool? Dd000NfeConjugada { get; set; }

    [ForeignKey("NavDD000OrigPcomissao")]
    public int? Dd000OrigPcomissaoId { get; set; }

    [ForeignKey("NavDD000FormaPcom")]
    public int? Dd000FormaPcomId { get; set; }

    [ForeignKey("NavDD000ComEspecie")]
    public string? Dd000Comespecieid { get; set; }

    public bool? Dd000NfsIsmultiplo { get; set; }

    [ForeignKey("NavDD000NfsPadrao")]
    public int? Dd000NfsPadraoId { get; set; }

    [ForeignKey("NavDD000NfsRegEspTrib")]
    public int? Dd000NfsRegesptribId { get; set; }

    [ForeignKey("NavDD000NfsOtpSN")]
    public int? Dd000NfsOtpsnId { get; set; }

    [ForeignKey("NavDD000NfsIncCult")]
    public int? Dd000NfsInccultId { get; set; }

    public string? Dd000NfsCodintegrcliente { get; set; }

    public string? Dd000NfsUrlWsInvoicy { get; set; }

    public string? Dd000NfsAlvaraempresa { get; set; }

    [ForeignKey("NavDD000NfsNatOp")]
    public int? Dd000NfsNatop { get; set; }

    public string? Dd000PdvWebRptNfceId { get; set; }

    public string? Dd000PdvWebRptNfeId { get; set; }

    public string? Dd000PdvWebRptNfId { get; set; }

    public string? Dd000Tokenacessows { get; set; }

    public bool? Dd000Isenviows { get; set; }

    public bool? Dd000Isusaambiente { get; set; }

    public bool? Dd000Isusaprojeto { get; set; }

    public decimal? Dd000Vmetadiamonitor { get; set; }

    public decimal? Dd000Qmetadiamonitor { get; set; }

    public bool? Dd000Iscomissaogerente { get; set; }

    public decimal? Dd000Valormincomissao { get; set; }

    public bool? Dd000Exibepvfaturada { get; set; }

    public bool? Dd000Isdataemissaooriginal { get; set; }

    [ForeignKey("NavDD000RegraLimiteDesconto")]
    public int? Dd000RegralimitedescontoId { get; set; }

    public decimal? Dd000Vlrmaxarredondvenda { get; set; }

    public bool? Dd000Isusacomanda { get; set; }

    public bool? Dd000Ishabilitapvexpress { get; set; }

    [ForeignKey("NavDD000Formapgt")]
    public string? Dd000FormapgtId { get; set; }

    public bool? Dd000Isusavendareprimida { get; set; }

    public bool? Dd000Ishabilitaperfalmox { get; set; }

    public bool? Dd000Isvendadeposito { get; set; }

    public bool? Dd000Ispermitesaldonegativo { get; set; }

    public bool? Dd000Iscontigencianfce { get; set; }

    public string? Dd000SatAssinaturaac { get; set; }

    public string? Dd000SatCodigoativacao { get; set; }

    [ForeignKey("NavDD000AlmoxPadraoTroca")]
    public string? Dd000Almoxpadraotrocaid { get; set; }

    [ForeignKey("NavDD000CtrlContigenciaNfce")]
    public string? Dd000CtrlContigenciaNfcei { get; set; }

    public bool? Dd000Isusavaloresretido { get; set; }

    public bool? Dd000Iscalculavolume { get; set; }

    public int? Dd000Tipoimportbibliotec { get; set; }

    public int? Dd000Tipoinsercaoprod { get; set; }

    public string? Dd000CorreiosUsuario { get; set; }

    public string? Dd000CorreiosSenha { get; set; }

    public string? Dd000Urlcorreios { get; set; }

    public bool? Dd000Iscanccomentrega { get; set; }

    // ========== NAVIGATION PROPERTIES ==========

    // Forma de Pagamento Comissão
    public CSICP_DD000Fcom? NavDD000FormaPcom { get; set; }

    // Estabelecimento/Filial
    public CSICP_BB001? NavDD000Filial { get; set; }

    // Centros de Custo
    public CSICP_Bb005? NavDD000PvCcusto { get; set; }
    public CSICP_Bb005? NavDD000PdCcusto { get; set; }
    public CSICP_Bb005? NavDD000PdvCcusto { get; set; }
    public CSICP_Bb005? NavDD000CtCcusto { get; set; }
    public CSICP_Bb005? NavDD000NdCcusto { get; set; }
    public CSICP_Bb005? NavDD000DcCcusto { get; set; }
    public CSICP_Bb005? NavDD000DisCcusto { get; set; }
    public CSICP_Bb005? NavDD000CpCcusto { get; set; }

    // Agentes Cobradores
    public CSICP_Bb006? NavDD000PvAgcobrador { get; set; }
    public CSICP_Bb006? NavDD000PdAgcobrador { get; set; }
    public CSICP_Bb006? NavDD000PdvAgcobrador { get; set; }
    public CSICP_Bb006? NavDD000CtAgcobrador { get; set; }
    public CSICP_Bb006? NavDD000NdAgcobrador { get; set; }
    public CSICP_Bb006? NavDD000DcAgcobrador { get; set; }
    public CSICP_Bb006? NavDD000DisAgcobrador { get; set; }
    public CSICP_Bb006? NavDD000CpAgcobrador { get; set; }

    // Naturezas de Operação
    public CSICP_Bb025? NavDD000PvNatoperacao { get; set; }
    public CSICP_Bb025? NavDD000PdNatoperacao { get; set; }
    public CSICP_Bb025? NavDD000PdvNatoperacao { get; set; }
    public CSICP_Bb025? NavDD000CtNatoperacao { get; set; }
    public CSICP_Bb025? NavDD000NdNatoperacao { get; set; }
    public CSICP_Bb025? NavDD000DcNatoperacao { get; set; }
    public CSICP_Bb025? NavDD000DisNatoperacao { get; set; }

    // Conta
    public CSICP_BB012? NavDD000PvConta { get; set; }

    // Séries de Notas
    public CSICP_Aa013? NavDD000CtrlSerieNf { get; set; }
    public CSICP_Aa013? NavDD000CtrlSerieCf { get; set; }
    public CSICP_Aa013? NavDD000CtrlSerieNfce { get; set; }
    public CSICP_Aa013? NavDD000CtrlContigenciaNfce { get; set; }

    // Condição de Pagamento
    public CSICP_Bb008? NavDD000CpCondpagto { get; set; }

    // Formas de Pagamento
    public CSICP_Bb026? NavDD000CpFormapagto { get; set; }
    public CSICP_Bb026? NavDD000Formapgt { get; set; }

    // UF
    public CSICP_Aa027? NavDD000UfOrgao { get; set; }

    // Espécie de Título
    public CSICP_FF003? NavDD000ComEspecie { get; set; }

    // Almoxarifado
    public CSICP_GG001? NavDD000AlmoxPadraoTroca { get; set; }

    // Estáticas (para os IDs que são int e representam valores estáticos)
    public CSICP_DD000Rneg? NavDD000QualRegraAplicar { get; set; }
    public CSICP_DD903Anfe? NavDD000AmbNfe { get; set; }
    public CSICP_DD905Vnfe? NavDD000VersaoNfe { get; set; }
    public CSICP_DD907? NavDD000LcertDigital { get; set; }
    public CSICP_DD000Tdz? NavDD000ZoneTime { get; set; }
    public CSICP_DD000Ocom? NavDD000OrigPcomissao { get; set; }
    public Osusr66cCsicpNfsPadrao? NavDD000NfsPadrao { get; set; } //Qual é a tabela? (nfsPadrao)
    public Osusr66cCsicpNfsRegtrib? NavDD000NfsRegEspTrib { get; set; }
    public Osusr66cCsicpNfsOptsn? NavDD000NfsOtpSN { get; set; }
    public Osusr66cCsicpNfsInccult? NavDD000NfsIncCult { get; set; }
    public Osusr66cCsicpNfsNatoper? NavDD000NfsNatOp { get; set; }
    public CSICP_DD000Rdesc? NavDD000RegraLimiteDesconto { get; set; }
}
