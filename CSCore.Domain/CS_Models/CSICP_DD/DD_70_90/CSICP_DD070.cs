using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CSCore.Domain.CS_Models.Staticas.AA;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD070
{
    public int TenantId { get; set; }

    public string Dd070Id { get; set; } = null!;

    public string? Dd070Empresaid { get; set; }

    public int? Dd070Filial { get; set; }

    public int? Dd070TipoatendimentoId { get; set; }

    public int? Dd070TipoMovimento { get; set; }

    public string? Dd070Serie { get; set; }

    public int? Dd070NoNf { get; set; }

    public int? Dd070NoPedido { get; set; }

    public int? Dd070NoEstacao { get; set; }

    public int? Dd070NoPdv { get; set; }

    public string? Dd070SerieCupom { get; set; }

    public int? Dd070NoCupom { get; set; }

    public DateTime? Dd070DataEmissao { get; set; }

    public DateTime? Dd070Datahoraemissao { get; set; }

    public string? Dd070ContaId { get; set; }

    public string? Dd070ContarealId { get; set; }

    public string? Dd070AvalistaId { get; set; }

    public string? Dd070CcustoId { get; set; }

    public string? Dd070AgcobradorId { get; set; }

    public string? Dd070CondPagtoId { get; set; }

    public string? Dd070ResponsavelId { get; set; }

    public string? Dd070CompContaId { get; set; }

    public string? Dd070NatoperacaoId { get; set; }

    public string? Dd070AlmoxdestinoId { get; set; }

    public int? Dd070CodgCcusto { get; set; }

    public int? Dd070CodgAgcobrador { get; set; }

    public int? Dd070CodgCondPagto { get; set; }

    public int? Dd070Codrespvendedor { get; set; }

    public int? Dd070Codrespcomprador { get; set; }

    public string? Dd070Codnatoperacao { get; set; }

    public int? Dd070Codalmoxdestino { get; set; }

    public decimal? Dd070Perc1Desconto { get; set; }

    public decimal? Dd070Perc2Desconto { get; set; }

    public decimal? Dd070Perc3Desconto { get; set; }

    public decimal? Dd070Perc4Desconto { get; set; }

    public decimal? Dd070Perc5Desconto { get; set; }

    public decimal? Dd070TotalDescsuframa { get; set; }

    public decimal? Dd070TotalBruto { get; set; }

    public decimal? Dd070TotalFrete { get; set; }

    public decimal? Dd070Arredondamento { get; set; }

    public int? Dd070FreteCifFob { get; set; }

    public decimal? Dd070TotalSeguro { get; set; }

    public decimal? Dd070TotalOutdespesas { get; set; }

    public decimal? Dd070Desconto { get; set; }

    public decimal? Dd070Acrescimo { get; set; }

    public decimal? Dd070TotalLiquido { get; set; }

    public decimal? Dd070TotalServico { get; set; }

    public decimal? Dd070Percdescservico { get; set; }

    public decimal? Dd070Vlrdescservico { get; set; }

    public decimal? Dd070Totliqservico { get; set; }

    public decimal? Dd070TotalprodEServ { get; set; }

    public decimal? Dd070ValorEntrada { get; set; }

    public int? Dd070QtdeParcelas { get; set; }

    public decimal? Dd070Vlrafinanciar { get; set; }

    public string? Dd070Texto { get; set; }

    public int? Dd070QtdVolumes { get; set; }

    public string? Dd070Especie { get; set; }

    public string? Dd070Marca { get; set; }

    public string? Dd070Nvol { get; set; }

    public decimal? Dd070PesoLiquido { get; set; }

    public decimal? Dd070PesoBruto { get; set; }

    public DateTime? Dd070DataSaida { get; set; }

    public DateTime? Dd070HoraSaida { get; set; }

    public string? Dd070Codtabelapreco { get; set; }

    public int? Dd070NumeroPreco { get; set; }

    public string? Dd070UsuarioImp { get; set; }

    public DateTime? Dd070DataImpressao { get; set; }

    public DateTime? Dd070HoraImpressao { get; set; }

    public int? Dd070NumImpressoes { get; set; }

    public string? Dd070NroContrato { get; set; }

    public decimal? Dd070NroRomaneio { get; set; }

    public string? Dd070Empenho { get; set; }

    public string? Dd070Processo { get; set; }

    public decimal? Dd070NoRequisicao { get; set; }

    public int? Dd070Comissao { get; set; }

    public DateTime? Dd070DataMovimento { get; set; }

    public int? Dd070Situacao { get; set; }

    public string? Dd070PrazoEntrega { get; set; }

    public decimal? Dd070CiOrcamento { get; set; }

    public int? Dd070CodgAtendente { get; set; }

    public string? Dd070UsuarioAtendenteid { get; set; }

    public string? Dd070UsuarioProprId { get; set; }

    public int? Dd070ClassecontaId { get; set; }

    public int? Dd070Statusestoque { get; set; }

    public decimal? Dd070Vbc { get; set; }

    public decimal? Dd070Vicms { get; set; }

    public decimal? Dd070Vbcst { get; set; }

    public decimal? Dd070Vst { get; set; }

    public decimal? Dd070Vii { get; set; }

    public decimal? Dd070Vipi { get; set; }

    public decimal? Dd070Vpis { get; set; }

    public decimal? Dd070Vcofins { get; set; }

    public decimal? Dd070Vfcp { get; set; }

    public decimal? Dd070Vfcpst { get; set; }

    public decimal? Dd070Vfcpstret { get; set; }

    public decimal? Dd070Vipidevol { get; set; }

    public decimal? Dd070TotValorAproxImp { get; set; }

    public decimal? Dd070ServVcofins { get; set; }

    public decimal? Dd070ServVbc { get; set; }

    public decimal? Dd070ServViss { get; set; }

    public decimal? Dd070ServVpis { get; set; }

    public int? Dd070ServDcompet { get; set; }

    public decimal? Dd070ServVissret { get; set; }

    public decimal? Dd070ServVoutro { get; set; }

    public decimal? Dd070ServVdescincond { get; set; }

    public decimal? Dd070ServVdesccond { get; set; }

    public int? Dd070ServCregtrib { get; set; }

    public bool? Dd070FlagRegra { get; set; }

    public DateTime? Dd070Datavalidade { get; set; }

    public decimal? Dd070NroPvDav { get; set; }

    public int? Processid { get; set; }

    public int? Dd070CfnfId { get; set; }

    public int? Dd040TpnotaId { get; set; }

    public string? Dd070CtrlSerieNfId { get; set; }

    public string? Dd070Protocolnumber { get; set; }

    public bool? Dd070Isaprovacao { get; set; }

    public int? Dd070Indpres { get; set; }

    public string? Dd070Finnfe { get; set; }

    public decimal? Dd070Vicmsdeson { get; set; }

    public decimal? Dd070Vfcpufdest { get; set; }

    public decimal? Dd070Vicmsufdest { get; set; }

    public decimal? Dd070Vicmsufremet { get; set; }

    public bool? Dd070Isvendacasada { get; set; }

    public string? Dd070Arquitetoid { get; set; }

    public string? Dd070Natop { get; set; }

    public int? Dd070Transcomtef { get; set; }

    public int? Dd070Modalidadefrete { get; set; }

    public bool? Dd0070IsPvResultante { get; set; }

    public string? Dd070PvGrupadaId { get; set; }

    public long? Dd070Romaneioid { get; set; }

    public bool? Dd070Isromdiverg { get; set; }

    public bool? Dd070Ismarcado { get; set; }

    public bool? Dd070Isorigemcotacao { get; set; }

    public int? Dd070Motdesoneracaoid { get; set; }

    public decimal? Dd070Picmsdesonerado { get; set; }

    public int? Dd070VicmsdesonsubId { get; set; }

    public string? Dd070CnpjMarketplace { get; set; }

    public string? Dd070Marketplace { get; set; }

    public string? Dd070Chavecashback { get; set; }

    public decimal? W06b1Qbcmono { get; set; }

    public decimal? W06cVicmsmono { get; set; }

    public decimal? W06c1Qbcmonoreten { get; set; }

    public decimal? W06dVicmsmonoreten { get; set; }

    public decimal? W06d1Qbcmonoret { get; set; }

    public decimal? W06eVicmsmonoret { get; set; }

    public int? Dd070Origemregpv { get; set; }

    public string? Dd070Keyecommerce { get; set; }

    //---------------------Reforma Tributária---------------------//

    [Column("W33_VIS", TypeName = "decimal(15,2)")]
    public decimal? W33_VIS { get; set; }

    [Column("W35_VBCIBSCBS", TypeName = "decimal(15,2)")]
    public decimal? W35_VBCIBSCBS { get; set; }

    [Column("W38_IBSUF_VDIF", TypeName = "decimal(15,2)")]
    public decimal? W38_IBSUF_VDIF { get; set; }

    [Column("W39_IBSUF_VDEVTRIB", TypeName = "decimal(15,2)")]
    public decimal? W39_IBSUF_VDEVTRIB { get; set; }

    [Column("W41_VIBSUF", TypeName = "decimal(15,2)")]
    public decimal? W41_VIBSUF { get; set; }

    [Column("W43_IBSMUN_VDIF", TypeName = "decimal(15,2)")]
    public decimal? W43_IBSMUN_VDIF { get; set; }

    [Column("W44_IBSMUN__VDEVTRIB", TypeName = "decimal(15,2)")]
    public decimal? W44_IBSMUN__VDEVTRIB { get; set; }

    [Column("W46_VIBSMUN", TypeName = "decimal(15,2)")]
    public decimal? W46_VIBSMUN { get; set; }

    [Column("W47_VIBSTOT", TypeName = "decimal(15,2)")]
    public decimal? W47_VIBSTOT { get; set; }

    [Column("W48_VCREDPRES", TypeName = "decimal(15,2)")]
    public decimal? W48_VCREDPRES { get; set; }

    [Column("W49_VCREDPRESCONDSUS", TypeName = "decimal(15,2)")]
    public decimal? W49_VCREDPRESCONDSUS { get; set; }

    [Column("W53_CBS_VDIF", TypeName = "decimal(15,2)")]
    public decimal? W53_CBS_VDIF { get; set; }

    [Column("W54_CBS_VDEVTRIB", TypeName = "decimal(15,2)")]
    public decimal? W54_CBS_VDEVTRIB { get; set; }

    [Column("W56_VCBS", TypeName = "decimal(15,2)")]
    public decimal? W56_VCBS { get; set; }

    [Column("W56A_CBS_VCREDPRES", TypeName = "decimal(15,2)")]
    public decimal? W56A_CBS_VCREDPRES { get; set; }

    [Column("W56B_CBS_VCREDPRESCONDSUS", TypeName = "decimal(15,2)")]
    public decimal? W56B_CBS_VCREDPRESCONDSUS { get; set; }

    [Column("W58_VTOTIBSMONO", TypeName = "decimal(15,2)")]
    public decimal? W58_VTOTIBSMONO { get; set; }

    [Column("W59_VTOTCBSMONO", TypeName = "decimal(15,2)")]
    public decimal? W59_VTOTCBSMONO { get; set; }

// Define foreign key to OsusrE9aCsicpAa145Tpdebcre
    [ForeignKey("NavAa145Tpdebcre")]

    [Column("DD070_TPDEBCREID", TypeName = "int")]
    public int? DD070_TPDEBCREID { get; set; }
    public OsusrE9aCsicpAa145Tpdebcre? NavAa145Tpdebcre { get; set; }
// foreign key definition end

    [Column("W59B_VCBSMONORETEN", TypeName = "decimal(15,2)")]
    public decimal? W59B_VCBSMONORETEN { get; set; }

    [Column("W59C_VIBSMONORETEN", TypeName = "decimal(15,2)")]
    public decimal? W59C_VIBSMONORETEN { get; set; }

    [Column("W59D_VCBSMONORET", TypeName = "decimal(15,2)")]
    public decimal? W59D_VCBSMONORET { get; set; }

    [Column("W60_VTOTNF", TypeName = "decimal(15,2)")]
    public decimal? W60_VTOTNF { get; set; }

    [Column("B33_PREDUTOR", TypeName = "decimal(7,4)")]
    public decimal? B33_PREDUTOR { get; set; }

// define foreign key to OsusrE9aCsicpAa149Tpopgov
    [ForeignKey("NavAa149Tpopgov")]
    [Column("B34_TPOPERGOVID", TypeName = "int")]
    public int? B34_TPOPERGOVID { get; set; }
    public OsusrE9aCsicpAa149Tpopgov? NavAa149Tpopgov { get; set; }
// foreign key definition end

    //-------------------------------------------------------//

    public virtual CSICP_DD040Tnt? Dd040Tpnota { get; set; }

    public virtual CSICP_DD999Nfcf? Dd070Cfnf { get; set; }

    public virtual CSICP_DD040Ipre? Dd070IndpresNavigation { get; set; }

    public virtual CSICP_DD041Frete? Dd070ModalidadefreteNavigation { get; set; }

    public virtual CSICP_DD070Sit? Dd070SituacaoNavigation { get; set; }

    public virtual CSICP_DD070Estq? Dd070StatusestoqueNavigation { get; set; }

    public virtual CSICP_DD070Tpate? Dd070Tipoatendimento { get; set; }

    public virtual CSICP_DD070W? OsusrTeiCsicpDd070W { get; set; }
}
