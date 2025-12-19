using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.Staticas.AA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_Bb027Imp
{
    public int TenantId { get; set; }

    public string Bb027bId { get; set; } = null!;

    [ForeignKey("NavBB027ImpTransacao")]
    public string? Bb027Id { get; set; }

    public int? Bb027bImpostosId { get; set; }

    public int? Bb027bCodgfilial { get; set; }

    public int? Bb027bCodgtransacao { get; set; }

    public string? Bb027bCodgcst { get; set; }

    [ForeignKey("NavBB027ImpRegime")]
    public int? Bb027bRegimeId { get; set; }

    [ForeignKey("NavBB027ImpOrigem")]
    public int? Bb027bOrigemId { get; set; }

    [ForeignKey("NavBB027ImpCstIcms")]
    public int? Bb027bCstIcmsId { get; set; }

    [ForeignKey("NavBB027ImpCstIpi")]
    public int? Bb027bCstIpiId { get; set; }

    [ForeignKey("NavBB027ImpCstPis")]
    public int? Bb027bCstPisId { get; set; }

    [ForeignKey("NavBB027ImpNatBcCredPis")]
    public int? Bb027bNatBcCredPis { get; set; }

    [ForeignKey("NavBB027ImpCstCofins")]
    public int? Bb027bCstCofinsId { get; set; }

    [ForeignKey("NavBB027ImpNatBcCredCofins")]
    public int? Bb027bNatBcCredCofins { get; set; }

    public string? Bb027bInformacoesnf { get; set; }

    public string? Bb027bInformacoesipi { get; set; }

    public string? Bb027bInformacoespis { get; set; }

    public string? Bb027bInformacoescofins { get; set; }

    [ForeignKey("NavBB027bModbc")]
    public int? Bb027bModbcId { get; set; }

    [ForeignKey("NavBB027bMotdesoneracao")]
    public int? Bb027bMotdesoneracaoid { get; set; }

    [ForeignKey("NavBB027ImpUfDest")]
    public string? Bb027bUfDestId { get; set; }

    [ForeignKey("NavBB027ImpClasseConta")]
    public int? Bb027bClassecontaId { get; set; }

    [ForeignKey("NavBB027ImpModalbcIcmsSt")]
    public int? Bb027bModalbcIcmsStId { get; set; }

    public decimal? Bb027bAliquota { get; set; }

    public decimal? Bb027bReducaobase { get; set; }

    [ForeignKey("NavBB027ImpMp255")]
    public int? Bb027bMp255Id { get; set; }

    public decimal? Bb027bReducaobcst { get; set; }

    [ForeignKey("NavBB027ImpCFOPStatica")]
    public int? Bb027bCfopStaticaId { get; set; }

    [ForeignKey("NavBB027ImpCenquadIpi")]
    public int? Bb027bCenquadIpiId { get; set; }

    public decimal? Bb027bAliqInternauf { get; set; }

    public string? Bb027bHashid { get; set; }

    public bool? Bb027bIsvicmsdesSubtrai { get; set; }

    [ForeignKey("NavBB027bFcalcicmsdes")]
    public int? Bb027bFcalcicmsdesId { get; set; }

    public decimal? Bb027bPicmsDiferido { get; set; }

    [ForeignKey("NavBB027ImpVicmsdesonSub")]
    public int? Bb027bVicmsdesonsubId { get; set; }

    [ForeignKey("NavBB027ImpIndpres")]
    public int? Bb027cIndpres { get; set; }

    public string? Bb027bCbenef { get; set; }

    public decimal? Bb027bPpropocaodestino { get; set; }

    [ForeignKey("NavBB027ImpRfClasstrib")]
    public long? Bb027bRfclasstribId { get; set; }

    [ForeignKey("NavBB027ImpRflc")]
    public string? Bb027bRflcId { get; set; }

    [ForeignKey("NavBB027ImpTpDebCre")]
    public int? Bb027bTpdebcreid { get; set; }

    public decimal? Bb027bPaliqefetregIbsUf { get; set; }

    public decimal? Bb027bPaliqefetregIbsMun { get; set; }

    public decimal? Bb027bPcredpresIbsUf { get; set; }

    public decimal? Bb027bPcredpresIbsMun { get; set; }

    public decimal? Bb027bPcredpresCbs { get; set; }

    public decimal? Bb027bPdifCbs { get; set; }

    public decimal? Bb027bPaliqefetregCbs { get; set; }

    public decimal? Bb027bPdifIbs { get; set; }

    [ForeignKey("NavBB027ImpRfClasstrib2")]
    public long? Bb027bIsRfclasstribId2 { get; set; }

    public decimal? Bb027bPreducaoibs { get; set; }

    public decimal? Bb027bPreducaocbs { get; set; }

    [ForeignKey("NavBB027ImpCCredPre")]
    public int? Bb027bCcredpreid { get; set; }

    // Navegações existentes
    public CSICP_Bb027Fdesen? NavBB027bFcalcicmsdes { get; set; }
    public CSICP_Bb027Modal? NavBB027bModbc { get; set; }
    public CSICP_Bb027Motivo? NavBB027bMotdesoneracao { get; set; }


    // ========== NAVEGAÇÕES ==========

    public CSICP_Bb027? NavBB027ImpTransacao { get; set; }

    public CSICP_AA030Regime? NavBB027ImpRegime { get; set; }

    public CSICP_AA031Cstori? NavBB027ImpOrigem { get; set; }

    public CSICP_AA032Csticm? NavBB027ImpCstIcms { get; set; }

    public CSICP_AA033Cstipi? NavBB027ImpCstIpi { get; set; }

    public CSICP_AA034Cstpi? NavBB027ImpCstPis { get; set; }

    public Osusr66cSpedInNatBc? NavBB027ImpNatBcCredPis { get; set; }

    public CSICP_AA035Cstcof? NavBB027ImpCstCofins { get; set; }

    public Osusr66cSpedInNatBc? NavBB027ImpNatBcCredCofins { get; set; }

    public CSICP_Aa027? NavBB027ImpUfDest { get; set; }

    public CSICP_Bb012Clacta? NavBB027ImpClasseConta { get; set; }

    public CSICP_AA038Modst? NavBB027ImpModalbcIcmsSt { get; set; }

    public CSICP_AA39Mp255? NavBB027ImpMp255 { get; set; }

    public Osusr66cSpedInCfop? NavBB027ImpCFOPStatica { get; set; }

    public Osusr66cSpedInCenqIpi? NavBB027ImpCenquadIpi { get; set; }

    public CSICP_Statica? NavBB027ImpVicmsdesonSub { get; set; }

    public CSICP_DD040Ipre? NavBB027ImpIndpres { get; set; }

    public OsusrE9aCsicpAa144? NavBB027ImpRfClasstrib { get; set; }

    public CSICP_AA143? NavBB027ImpRflc { get; set; }

    public OsusrE9aCsicpAa145Tpdebcre? NavBB027ImpTpDebCre { get; set; }

    public OsusrE9aCsicpAa144? NavBB027ImpRfClasstrib2 { get; set; }

    public CSICP_Statica? NavBB027ImpCCredPre { get; set; }
}
