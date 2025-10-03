using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.CS_Models.Staticas.AA;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD061Cfgimp
{
    public int TenantId { get; set; }

    public string Dd060Id { get; set; } = null!;

    public string? Dd061Bb027Id { get; set; }

    public string? Dd061Bb027bCfgimpId { get; set; }

    public string? Dd061Bb027bCodgcst { get; set; }

    public int? Dd061Bb027bRegimeId { get; set; }

    public int? Dd061Bb027bOrigemId { get; set; }

    public int? Dd061Bb027bCstIcmsId { get; set; }

    public int? Dd061Bb027bCstIpiId { get; set; }

    public int? Dd061Bb027bCstPisId { get; set; }

    public int? Dd061NatBcCredPis { get; set; }

    public int? Dd061Bb027bCstCofinsId { get; set; }

    public int? Dd061NatBcCredCofins { get; set; }

    public string? Dd061Bb027bInfornf { get; set; }

    public string? Dd061Bb027bInforipi { get; set; }

    public string? Dd061Bb027bInforpis { get; set; }

    public string? Dd061Bb027bInforcofins { get; set; }

    public int? Dd061Bb027bModbcId { get; set; }

    public int? Dd061Bb027bMotdesoneracao { get; set; }

    public string? Dd061Bb027bUfDestId { get; set; }

    public int? Dd061Bb027bClassecontaId { get; set; }

    public int? Dd061Bb027bCfopStaticaId { get; set; }

    public int? Dd061Bb027bModalbcIcmsSt { get; set; }

    public decimal? Dd061Bb027bAliquota { get; set; }

    public decimal? Dd061Bb027bReducaobase { get; set; }

    public int? Dd061Bb027bMp255Id { get; set; }

    public decimal? Dd061Bb027bReducaobcst { get; set; }

    public int? Dd061Bb027CfopId { get; set; }

    public int? Dd061Bb027bCfopExcecaoId { get; set; }

    public int? Dd061Bb027bCenquadIpiId { get; set; }

    public decimal? Dd061Bb027bAliqInternauf { get; set; }

    public int? Dd061Bb027bIndpres { get; set; }

    //---------Reforma Tributária----------//

// Defining the foreign key relationship to OsusrE9aCsicpAa144
    [ForeignKey("NavCsicpAa144")]

    [Column("UB13UB14_RFCLASSTRIB_ID", TypeName = "bigint")]
    public long? Ub13Ub14RfclasstribId { get; set; }
   public OsusrE9aCsicpAa144? NavCsicpAa144 { get; set; }
    // Final foreign key relationship to OsusrE9aCsicpAa144

    // Defining the foreign key relationship to OsusrE9aCsicpAa143

    [ForeignKey("NavCsicpAa143")]

    [Column("DD061_RFLC_ID", TypeName = "nvarchar(36)")]
    public string? Dd061RflcId { get; set; }
   public CSICP_AA143? NavCsicpAa143 { get; set; }
    // Final foreign key relationship to OsusrE9aCsicpAa143

// Define relacionamento com OsusrE9aCsicpAa144

    [ForeignKey("NavCsicpAa144_1")]

    [Column("UB03_IS_RFCLASSTRIB_ID", TypeName = "bigint")]
    public long? Ub03IsRfclasstribId { get; set; }
    public OsusrE9aCsicpAa144? NavCsicpAa144_1 { get; set; }
// fim relacionamento


// Define relacionamento com OsusrE9aCsicpAa144
    [ForeignKey("NavCsicpAa144_2")]

    [Column("UB69_70_RFCLASSTRIBREG_ID", TypeName = "bigint")]
    public long? Ub6970RfclasstribregId { get; set; }
    public OsusrE9aCsicpAa144? NavCsicpAa144_2 { get; set; }
    // fim relacionamento

// Define relacionamento com OsusrE9aCsicpAa150Ccredpre
    [ForeignKey("NavAa150Ccredpre")]
    [Column("UB74_79_CCREDPRESID", TypeName = "int")]
    public int? Ub7479Ccredpresid { get; set; }
   public OsusrE9aCsicpAa150Ccredpre? NavAa150Ccredpre { get; set; }
    // fim relacionamento

   // Define relacionamento com CSICP_BB027
    [ForeignKey("CSICP_BB027")]

    [Column("DD061_RF_BB027_ID", TypeName = "nvarchar(36)")]
    public string? Dd061RfBb027Id { get; set; }
   public CSICP_Bb027? CSICP_BB027 { get; set; }
    // fim relacionamento

   // Define relacionamento com CSICP_BB027_imp
    [ForeignKey("CSICP_BB027_imp")]

    [Column("DD061_RF_BB027B_CFGIMP_ID", TypeName = "nvarchar(36)")]
    public string? Dd061RfBb027bCfgimpId { get; set; }
    public CSICP_Bb027Imp? CSICP_BB027_imp { get; set; }
    // Fim relacionamento
 
    //-------------------------------------------------------//

    public virtual CSICP_DD060 Dd060 { get; set; } = null!;

    public virtual CSICP_DD040Ipre? Dd061Bb027bIndpresNavigation { get; set; }
}
