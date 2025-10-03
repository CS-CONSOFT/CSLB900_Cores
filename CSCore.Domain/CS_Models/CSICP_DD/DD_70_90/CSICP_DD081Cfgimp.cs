using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.CS_Models.Staticas.AA;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD081Cfgimp
{
    public int TenantId { get; set; }

    public string Dd080Id { get; set; } = null!;

    public string? Dd081Bb027Id { get; set; }

    public string? Dd081Bb027bCfgimpId { get; set; }

    public string? Dd081Bb027bCodgcst { get; set; }

    public int? Dd081Bb027bRegimeId { get; set; }

    public int? Dd081Bb027bOrigemId { get; set; }

    public int? Dd081Bb027bCstIcmsId { get; set; }

    public int? Dd081Bb027bCstIpiId { get; set; }

    public int? Dd081Bb027bCstPisId { get; set; }

    public int? Dd081NatBcCredPis { get; set; }

    public int? Dd081Bb027bCstCofinsId { get; set; }

    public int? Dd081NatBcCredCofins { get; set; }

    public string? Dd081Bb027bInfornf { get; set; }

    public string? Dd081Bb027bInforipi { get; set; }

    public string? Dd081Bb027bInforpis { get; set; }

    public string? Dd081Bb027bInforcofins { get; set; }

    public int? Dd081Bb027bModbcId { get; set; }

    public int? Dd081Bb027bMotdesoneracao { get; set; }

    public string? Dd081Bb027bUfDestId { get; set; }

    public int? Dd081Bb027bClassecontaId { get; set; }

    public int? Dd081Bb027bCfopStaticaId { get; set; }

    public int? Dd081Bb027bModalbcIcmsSt { get; set; }

    public decimal? Dd081Bb027bAliquota { get; set; }

    public decimal? Dd081Bb027bReducaobase { get; set; }

    public int? Dd081Bb027bMp255Id { get; set; }

    public decimal? Dd081Bb027bReducaobcst { get; set; }

    public int? Dd081Bb027CfopId { get; set; }

    public int? Dd081Bb027bCfopExcecaoId { get; set; }

    public int? Dd081Bb027bCenquadIpiId { get; set; }

    public decimal? Dd081Bb027bAliqInternauf { get; set; }

    public int? Dd081Bb027bIndpres { get; set; }

    //---------Reforma Tributária----------//
// Define relacionamento com OsusrE9aCsicpAa144
    [ForeignKey("NavCsicpAa144")]

    [Column("UB13UB14_RFCLASSTRIB_ID", TypeName = "bigint")]
    public long? Ub13Ub14RfclasstribId { get; set; }
    public OsusrE9aCsicpAa144? NavCsicpAa144 { get; set; }

// fim relacionamento

// Define relacionamento com OsusrE9aCsicpAa143
    [ForeignKey("NavCsicpAa143")]

    [Column("DD081_RFLC_ID", TypeName = "nvarchar(36)")]
    public string? Dd061RflcId { get; set; }
    public CSICP_AA143? NavCsicpAa143 { get; set; }

// fim relacionamento

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

    [Column("DD081_RF_BB027_ID", TypeName = "nvarchar(36)")]
    public string? Dd061RfBb027Id { get; set; }
    public CSICP_Bb027? CSICP_BB027 { get; set; }
    // fim relacionamento

    // Define relacionamento com CSICP_BB027_imp
    [ForeignKey("CSICP_BB027_imp")]
    [Column("DD081_RF_BB027B_CFGIMP_ID", TypeName = "nvarchar(36)")]
    public string? Dd061RfBb027bCfgimpId { get; set; }
    public CSICP_Bb027Imp? CSICP_BB027_imp { get; set; }
    // Fim relacionamento
    //-------------------------------------------------------//

    public virtual CSICP_DD080 Dd080 { get; set; } = null!;

    public virtual CSICP_DD040Ipre? Dd081Bb027bIndpresNavigation { get; set; }
}
