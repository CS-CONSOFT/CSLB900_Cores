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

    public int? Bb027bOrigemId { get; set; }

    public int? Bb027bCstIcmsId { get; set; }

    public int? Bb027bCstIpiId { get; set; }

    public int? Bb027bCstPisId { get; set; }

    public int? Bb027bNatBcCredPis { get; set; }

    public int? Bb027bCstCofinsId { get; set; }

    public int? Bb027bNatBcCredCofins { get; set; }

    public string? Bb027bInformacoesnf { get; set; }

    public string? Bb027bInformacoesipi { get; set; }

    public string? Bb027bInformacoespis { get; set; }

    public string? Bb027bInformacoescofins { get; set; }

    [ForeignKey("NavBB027bModbc")]
    public int? Bb027bModbcId { get; set; }

    [ForeignKey("NavBB027bMotdesoneracao")]
    public int? Bb027bMotdesoneracaoid { get; set; }

    public string? Bb027bUfDestId { get; set; }

    public int? Bb027bClassecontaId { get; set; }

    public int? Bb027bModalbcIcmsStId { get; set; }

    public decimal? Bb027bAliquota { get; set; }

    public decimal? Bb027bReducaobase { get; set; }

    public int? Bb027bMp255Id { get; set; }

    public decimal? Bb027bReducaobcst { get; set; }

    [ForeignKey("NavBB027ImpCFOPStatica")]
    public int? Bb027bCfopStaticaId { get; set; }

    public int? Bb027bCenquadIpiId { get; set; }

    public decimal? Bb027bAliqInternauf { get; set; }

    public string? Bb027bHashid { get; set; }

    public bool? Bb027bIsvicmsdesSubtrai { get; set; }

    [ForeignKey("NavBB027bFcalcicmsdes")]
    public int? Bb027bFcalcicmsdesId { get; set; }

    public decimal? Bb027bPicmsDiferido { get; set; }

    public int? Bb027bVicmsdesonsubId { get; set; }

    public int? Bb027cIndpres { get; set; }

    public string? Bb027bCbenef { get; set; }

    public decimal? Bb027bPpropocaodestino { get; set; }

    public long? Bb027bRfclasstribId { get; set; }

    public string? Bb027bRflcId { get; set; }

    public int? Bb027bTpdebcreid { get; set; }

    public decimal? Bb027bPaliqefetregIbsUf { get; set; }

    public decimal? Bb027bPaliqefetregIbsMun { get; set; }

    public decimal? Bb027bPcredpresIbsUf { get; set; }

    public decimal? Bb027bPcredpresIbsMun { get; set; }

    public decimal? Bb027bPcredpresCbs { get; set; }

    public decimal? Bb027bPdifCbs { get; set; }

    public decimal? Bb027bPaliqefetregCbs { get; set; }

    public decimal? Bb027bPdifIbs { get; set; }

    public long? Bb027bIsRfclasstribId2 { get; set; }

    public decimal? Bb027bPreducaoibs { get; set; }

    public decimal? Bb027bPreducaocbs { get; set; }

    public int? Bb027bCcredpreid { get; set; }



    // Navegações existentes
    public CSICP_Bb027Fdesen? NavBB027bFcalcicmsdes { get; set; }
    public CSICP_Bb027Modal? NavBB027bModbc { get; set; }
    public CSICP_Bb027Motivo? NavBB027bMotdesoneracao { get; set; }

    // Navegações para CSICP_Statica
    public CSICP_Statica? NavBB027ImpBaixaEstoque { get; set; }
    public CSICP_Statica? NavBB027ImpGeraCReceber { get; set; }
    public CSICP_Statica? NavBB027ImpAtualizaPrCompra { get; set; }
    public CSICP_Statica? NavBB027ImpCalcSubstituicao { get; set; }
    public CSICP_Statica? NavBB027ImpCalculaISS { get; set; }
    public CSICP_Statica? NavBB027ImpAgregaSubsTrib { get; set; }
    public CSICP_Statica? NavBB027ImpDIFA { get; set; }
    public CSICP_Statica? NavBB027ImpICST { get; set; }
    public CSICP_Statica? NavBB027ImpIRRF { get; set; }
    public CSICP_Statica? NavBB027ImpPIS { get; set; }
    public CSICP_Statica? NavBB027ImpCOFINS { get; set; }
    public CSICP_Statica? NavBB027ImpIRPJ { get; set; }
    public CSICP_Statica? NavBB027ImpICMSDiferido { get; set; }
    public CSICP_Statica? NavBB027ImpGeraEstatistica { get; set; }
    public CSICP_Statica? NavBB027ImpCalcAjusteICMS { get; set; }
    public CSICP_Statica? NavBB027ImpCalcIS { get; set; }

    // Navegações para outras tabelas BB027
    public CSICP_Bb027Entsai? NavBB027ImpEntsai { get; set; }
    public CSICP_Bb027Cicm? NavBB027ImpCalcICMS { get; set; }
    public CSICP_Bb027Cicm? NavBB027ImpCalcIPI { get; set; }
    public CSICP_Bb027Sipi? NavBB027ImpSomaIPIBaseICMS { get; set; }
    public CSICP_Bb027Bcalc? NavBB027ImpIPIBruto { get; set; }
    public CSICP_Bb027Bcalc? NavBB027ImpBaseICMSBrutaLiq { get; set; }
    public CSICP_Bb027Bcalc? NavBB027ImpBaseSubsBrutaLiq { get; set; }

    // Navegações para SPED
    public Osusr66cSpedInCfop? NavBB027ImpCFOPStatica { get; set; }
    public Osusr66cSpedInCfop? NavBB027ImpCFOPForaEstado { get; set; }
    public Osusr66cSpedInCodAjuste? NavBB027ImpCodgAjusteICMS { get; set; }

    // Navegação para BB027 pai
    public CSICP_Bb027? NavBB027ImpTransacao { get; set; }

    // Navegação para Regime
    public CSICP_AA030Regime? NavBB027ImpRegime { get; set; }
}
