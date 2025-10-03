using CSCore.Domain.CS_Models.CSICP_DD;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD061
{
    public int TenantId { get; set; }

    public string Dd061Id { get; set; } = null!;

    public string? Dd060Id { get; set; }

    public int? Dd061ImpostoId { get; set; }

    public string? Dd061Produtoid { get; set; }

    public int? Dd061Codgproduto { get; set; }

    public string? Dd061ImpostoidGeneric { get; set; }

    public string? Dd061CodgImposto { get; set; }

    public string? Dd061Cst { get; set; }

    public string? Dd061Cfop { get; set; }

    public string? Dd061Descimposto { get; set; }

    public decimal? Dd061ValorContabil { get; set; }

    public decimal? Dd061BaseCalculo { get; set; }

    public decimal? Dd061Aliquota { get; set; }

    public decimal? Dd061Valorimposto { get; set; }

    public decimal? Dd061Percreducbase { get; set; }

    public decimal? Dd061Vredbcicms { get; set; }

    public decimal? Dd061Isento { get; set; }

    public decimal? Dd061Outros { get; set; }

    public decimal? Dd061Cancelamentos { get; set; }

    public decimal? Dd061Descontos { get; set; }

    public decimal? Dd061Lucroestimado { get; set; }

    public decimal? Dd061Vltribaux { get; set; }

    public decimal? Dd061Predbcst { get; set; }

    public decimal? Dd061Vbcst { get; set; }

    public decimal? Dd061Picmsst { get; set; }

    public decimal? Dd061Vicmsst { get; set; }

    public decimal? Dd061Vbcfcp { get; set; }

    public decimal? Dd061Pfcp { get; set; }

    public decimal? Dd061Vfcp { get; set; }

    public decimal? Dd061Vbcfcpst { get; set; }

    public decimal? Dd061Pfcpst { get; set; }

    public decimal? Dd061Vfcpst { get; set; }

    public int? Dd061Agregasubtribut { get; set; }

    public decimal? Dd061QtdTributada { get; set; }

    public decimal? Dd061VlrUnidade { get; set; }

    public decimal? Dd061VlrImposto { get; set; }

    public int? Dd061SomaIpiBaseId { get; set; }

    public int? Dd061BaseliqbrutaId { get; set; }

    public decimal? Dd061Vbcstret { get; set; }

    public decimal? Dd061Vicmsstret { get; set; }

    public decimal? Dd061Vbcfcpstret { get; set; }

    public decimal? Dd061Pfcpstret { get; set; }

    public decimal? Dd061Vfcpstret { get; set; }

    public decimal? Dd061Vsuframa { get; set; }

    public decimal? Dd061Psuframa { get; set; }

    public decimal? Dd061Vbcsuframa { get; set; }

    public decimal? Dd061VicmsDesonerado { get; set; }

    public decimal? Dd061VpautaIcms { get; set; }

    public decimal? Dd061Vbcufdest { get; set; }

    public decimal? Dd061Picmsufdest { get; set; }

    public decimal? Dd061Picmsinter { get; set; }

    public decimal? Dd061Picmsinterpart { get; set; }

    public decimal? Dd061Vbcfcpufdest { get; set; }

    public decimal? Dd061Pfcpufdest { get; set; }

    public decimal? Dd061Vfcpufdest { get; set; }

    public decimal? Dd061Vicmsufremet { get; set; }

    public decimal? Dd061Vicmsufdest { get; set; }

    public decimal? Dd061Pcredsn { get; set; }

    public decimal? Dd061Vcredicmssn { get; set; }

    public string? Dd061Impostodevol { get; set; }

    public decimal? Dd061Pdevol { get; set; }

    public string? Dd061Ipi { get; set; }

    public decimal? Dd061Vipidevol { get; set; }

    public decimal? Dd061Vbcefet { get; set; }

    public decimal? Dd061Picmsefet { get; set; }

    public decimal? Dd061Vicmsefet { get; set; }

    public decimal? Dd061Predbcefet { get; set; }

    public decimal? Dd061Pst { get; set; }

    public decimal? Dd061Vicmssubstituto { get; set; }

    public decimal? Dd061Vicmsop { get; set; }

    public decimal? Dd061Pdif { get; set; }

    public decimal? Dd061Vicmsdif { get; set; }

    public decimal? N37aQbcmono { get; set; }

    public decimal? N38Adremicms { get; set; }

    public decimal? N39Vicmsmono { get; set; }

    public decimal? N39aQbcmonoreten { get; set; }

    public decimal? N40Adremicmsreten { get; set; }

    public decimal? N41Vicmsmonoreten { get; set; }

    public decimal? N47Predadrem { get; set; }

    public string? N48Motredadrem { get; set; }

    public decimal? N41aVicmsmonoop { get; set; }

    public decimal? N42Pdif { get; set; }

    public decimal? N43Vicmsmonodif { get; set; }

    public decimal? N43aQbcmonoret { get; set; }

    public decimal? N44Adremicmsret { get; set; }

    public decimal? N45Vicmsmonoret { get; set; }


  //-------Reforma Tributária-------//

[Column("UB16_VBC", TypeName = "decimal(37,2)")]
public decimal? UB16_VBC { get; set; }

// Define the foreign key relationship CSICP_AA027
  [ForeignKey("NavAa027")]

  [Column("UB17_UFID", TypeName = "nvarchar(36)")]
  public string? UB17_UFID { get; set; }

  public CSICP_Aa027? NavAa027 { get; set; }
  // Fim da foreign key

// Define the foreign key relationship CSICP_AA028
  [ForeignKey("NavAa028")]

  [Column("UB36_MUNICIPIOID", TypeName = "nvarchar(36)")]
  public string? UB36_MUNICIPIOID { get; set; }
  public CSICP_Aa028? NavAa028 { get; set; }
  // Fim da foreign key


  [Column("UB18_37_56_PIBSCBS", TypeName = "decimal(7,4)")]
public decimal? UB18_37_56_PIBSCBS { get; set; }

[Column("UB22_41_60_PDIF", TypeName = "decimal(7,4)")]
public decimal? UB22_41_60_PDIF { get; set; }

[Column("UB23_42_61_VDIF", TypeName = "decimal(37,2)")]
public decimal? UB23_42_61_VDIF { get; set; }

[Column("UB25_44_63_VDEVTRIB", TypeName = "decimal(37,2)")]
public decimal? UB25_44_63_VDEVTRIB { get; set; }

[Column("UB27_46_65_PREDALIQ", TypeName = "decimal(7,4)")]
public decimal? UB27_46_65_PREDALIQ { get; set; }

[Column("UB28_47_66_PALIQEFET", TypeName = "decimal(7,4)")]
public decimal? UB28_47_66_PALIQEFET { get; set; }

[Column("UB35_54_67_VIBSCBS", TypeName = "decimal(37,2)")]
public decimal? UB35_54_67_VIBSCBS { get; set; }

[Column("UB75_80_PCREDPRES", TypeName = "decimal(7,4)")]
public decimal? UB75_80_PCREDPRES { get; set; }

[Column("UB76_81_VCREDPRES", TypeName = "decimal(37,2)")]
public decimal? UB76_81_VCREDPRES { get; set; }

[Column("UB77_82_VCREDPRESCONDSUS", TypeName = "decimal(37,2)")]
public decimal? UB77_82_VCREDPRESCONDSUS { get; set; }

[Column("UB85_QBCMONO", TypeName = "decimal(15,4)")]
public decimal? UB85_QBCMONO { get; set; }

[Column("UB86_ADREMIBS", TypeName = "decimal(7,4)")]
public decimal? UB86_ADREMIBS { get; set; }

[Column("UB87_ADREMCBS", TypeName = "decimal(7,4)")]
public decimal? UB87_ADREMCBS { get; set; }

[Column("UB71_72A_72C_PIBSCBS", TypeName = "decimal(7,4)")]
public decimal? UB71_72A_72C_PIBSCBS { get; set; }

[Column("UB72_72B_72D_VTRIBREGIBS", TypeName = "decimal(15,2)")]
public decimal? UB72_72B_72D_VTRIBREGIBS { get; set; }

[Column("UB82B_82D_82F_PIBS", TypeName = "decimal(7,4)")]
public decimal? UB82B_82D_82F_PIBS { get; set; }

[Column("UB82C_82E_82G_VIBS", TypeName = "decimal(15,2)")]
public decimal? UB82C_82E_82G_VIBS { get; set; }

[Column("UB88_VIBSMONO", TypeName = "decimal(15,2)")]
public decimal? UB88_VIBSMONO { get; set; }

[Column("UB88_VCBSMONO", TypeName = "decimal(15,2)")]
public decimal? UB88_VCBSMONO { get; set; }

[Column("UB91_QBCMONORETEN", TypeName = "decimal(15,4)")]
public decimal? UB91_QBCMONORETEN { get; set; }

[Column("UB92_ADREMIBSRETEN", TypeName = "decimal(7,4)")]
public decimal? UB92_ADREMIBSRETEN { get; set; }

[Column("UB93_VIBSMONORETEN", TypeName = "decimal(15,2)")]
public decimal? UB93_VIBSMONORETEN { get; set; }

[Column("UB93A_ADREMCBSRETEN", TypeName = "decimal(7,4)")]
public decimal? UB93A_ADREMCBSRETEN { get; set; }

[Column("UB93B_VCBSMONORETEN", TypeName = "decimal(15,2)")]
public decimal? UB93B_VCBSMONORETEN { get; set; }

[Column("UB95_QBCMONORET", TypeName = "decimal(15,4)")]
public decimal? UB95_QBCMONORET { get; set; }

[Column("UB96_ADREMIBSRET", TypeName = "decimal(7,4)")]
public decimal? UB96_ADREMIBSRET { get; set; }

[Column("UB97_VIBSMONORET", TypeName = "decimal(15,2)")]
public decimal? UB97_VIBSMONORET { get; set; }

[Column("UB98_ADREMCBSRET", TypeName = "decimal(7,4)")]
public decimal? UB98_ADREMCBSRET { get; set; }

[Column("UB98A_VCBSMONORET", TypeName = "decimal(15,2)")]
public decimal? UB98A_VCBSMONORET { get; set; }

[Column("UB100_PDIFIBS", TypeName = "decimal(7,4)")]
public decimal? UB100_PDIFIBS { get; set; }

[Column("UB101_VIBSMONODIF", TypeName = "decimal(15,2)")]
public decimal? UB101_VIBSMONODIF { get; set; }

[Column("UB102_PDIFCBS", TypeName = "decimal(7,4)")]
public decimal? UB102_PDIFCBS { get; set; }

[Column("UB103_VCBSMONODIF", TypeName = "decimal(15,2)")]
public decimal? UB103_VCBSMONODIF { get; set; }

[Column("UB104_VTOTIBSMONOITEM", TypeName = "decimal(15,2)")]
public decimal? UB104_VTOTIBSMONOITEM { get; set; }

[Column("UB105_VTOTCBSMONOITEM", TypeName = "decimal(15,2)")]
public decimal? UB105_VTOTCBSMONOITEM { get; set; }

[Column("UB05_VBCIS", TypeName = "decimal(15,2)")]
public decimal? UB05_VBCIS { get; set; }

[Column("UB06_PIS", TypeName = "decimal(7,4)")]
public decimal? UB06_PIS { get; set; }

[Column("UB06_PISESPEC", TypeName = "decimal(7,4)")]
public decimal? UB06_PISESPEC { get; set; }

[Column("UB10_QTRIB", TypeName = "decimal(15,4)")]
public decimal? UB10_QTRIB { get; set; }

[Column("UB11_VIS", TypeName = "decimal(15,2)")]
public decimal? UB11_VIS { get; set; }

[Column("UB107_108_VIBS", TypeName = "decimal(15,2)")]
public decimal? UB107_108_VIBS { get; set; }

[Column("UB110_TPCREDPRESIBSZFM", TypeName = "nvarchar(1)")]
public string? UB110_TPCREDPRESIBSZFM { get; set; }

[Column("UB111_VCREDPRESIBSZFM", TypeName = "decimal(15,2)")]
public decimal? UB111_VCREDPRESIBSZFM { get; set; }

[Column("RF_MemoriaCalculo", TypeName = "nvarchar(500)")]
public string? RF_MemoriaCalculo { get; set; }

    //-------------------------------------------------------//

    public CSICP_AA037Imp? NavAA037Imp { get; set; }
    public virtual CSICP_DD060? Dd060 { get; set; }
}
