using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

[Column("UB13UB14_RFCLASSTRIB_ID", TypeName = "bigint")]
public long? Ub13Ub14RfclasstribId { get; set; }

[Column("DD081_RFLC_ID", TypeName = "nvarchar(36)")]
public string? Dd061RflcId { get; set; }

[Column("UB03_IS_RFCLASSTRIB_ID", TypeName = "bigint")]
public long? Ub03IsRfclasstribId { get; set; }

[Column("UB69_70_RFCLASSTRIBREG_ID", TypeName = "bigint")]
public long? Ub6970RfclasstribregId { get; set; }

[Column("UB74_79_CCREDPRESID", TypeName = "int")]
public int? Ub7479Ccredpresid { get; set; }

[Column("DD081_RF_BB027_ID", TypeName = "nvarchar(36)")]
public string? Dd061RfBb027Id { get; set; }

[Column("DD081_RF_BB027B_CFGIMP_ID", TypeName = "nvarchar(36)")]
public string? Dd061RfBb027bCfgimpId { get; set; }

    //-------------------------------------------------------//

    public virtual CSICP_DD080 Dd080 { get; set; } = null!;

    public virtual CSICP_DD040Ipre? Dd081Bb027bIndpresNavigation { get; set; }
}
