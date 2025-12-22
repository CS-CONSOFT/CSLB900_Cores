using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.NFS;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD000
{
    public int TenantId { get; set; }

    public string Dd000ConfigId { get; set; } = null!;

    public string? Dd000FilialId { get; set; }

    public string? Dd000PvCcustoId { get; set; }

    public string? Dd000PvAgcobradorId { get; set; }

    public string? Dd000PvNatoperacaoId { get; set; }

    public string? Dd000PvContaId { get; set; }

    public string? Dd000CtrlSerieNfId { get; set; }

    public string? Dd000CtrlSerieCfId { get; set; }

    public string? Dd000CtrlSerieNfceId { get; set; }

    public string? Dd000PdCcustoId { get; set; }

    public string? Dd000PdAgcobradorId { get; set; }

    public string? Dd000PdNatoperacaoId { get; set; }

    public string? Dd000PdvCcustoId { get; set; }

    public string? Dd000PdvAgcobradorId { get; set; }

    public string? Dd000PdvNatoperacaoId { get; set; }

    public string? Dd000CtCcustoId { get; set; }

    public string? Dd000CtAgcobradorId { get; set; }

    public string? Dd000CtNatoperacaoId { get; set; }

    public int? Dd000Qtddiasvalcotacao { get; set; }

    public int? Dd000Qtddiasvalprevenda { get; set; }

    public int? Dd000Qualregraaplicar { get; set; }

    public int? Dd000AmbNfeId { get; set; }

    public int? Dd000VersaoNfeId { get; set; }

    public int? Dd000LcertdigitalId { get; set; }

    public byte[]? Dd000Arqcertdigitalbinario { get; set; }

    public string? Dd000Arqcertdigital { get; set; }

    public string? Dd000Senhacertdigital { get; set; }

    public string? Dd000NdCcustoId { get; set; }

    public string? Dd000NdAgcobradorId { get; set; }

    public string? Dd000NdNatoperacaoId { get; set; }

    public string? Dd000DcCcustoId { get; set; }

    public string? Dd000DcAgcobradorId { get; set; }

    public string? Dd000DcNatoperacaoId { get; set; }

    public string? Dd000DisCcustoId { get; set; }

    public string? Dd000DisAgcobradorId { get; set; }

    public string? Dd000DisNatoperacaoId { get; set; }

    public int? Dd000ZonetimeId { get; set; }

    public string? Dd000CpCcustoId { get; set; }

    public string? Dd000CpAgcobradorId { get; set; }

    public string? Dd000CpCondpagtoId { get; set; }

    public string? Dd000CpFormapagtoId { get; set; }

    public int? Dd000CpDiaVencto { get; set; }

    public string? Dd000UfOrgaoId { get; set; }

    public int? Dd000Qtddiasvaletiq { get; set; }

    public bool? Dd000NfeConjugada { get; set; }

    public int? Dd000OrigPcomissaoId { get; set; }

    public int? Dd000FormaPcomId { get; set; }

    public string? Dd000Comespecieid { get; set; }

    public bool? Dd000NfsIsmultiplo { get; set; }

    public int? Dd000NfsPadraoId { get; set; }

    public int? Dd000NfsRegesptribId { get; set; }

    public int? Dd000NfsOtpsnId { get; set; }

    public int? Dd000NfsInccultId { get; set; }

    public string? Dd000NfsCodintegrcliente { get; set; }

    public string? Dd000NfsUrlWsInvoicy { get; set; }

    public string? Dd000NfsAlvaraempresa { get; set; }

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

    public int? Dd000RegralimitedescontoId { get; set; }

    public decimal? Dd000Vlrmaxarredondvenda { get; set; }

    public bool? Dd000Isusacomanda { get; set; }

    public bool? Dd000Ishabilitapvexpress { get; set; }

    public string? Dd000FormapgtId { get; set; }

    public bool? Dd000Isusavendareprimida { get; set; }

    public bool? Dd000Ishabilitaperfalmox { get; set; }

    public bool? Dd000Isvendadeposito { get; set; }

    public bool? Dd000Ispermitesaldonegativo { get; set; }

    public bool? Dd000Iscontigencianfce { get; set; }

    public string? Dd000SatAssinaturaac { get; set; }

    public string? Dd000SatCodigoativacao { get; set; }

    public string? Dd000Almoxpadraotrocaid { get; set; }

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
