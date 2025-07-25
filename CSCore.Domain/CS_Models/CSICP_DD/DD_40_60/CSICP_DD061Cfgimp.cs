using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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

    [Column("UB13UB14_CLASSTRIB_ID", TypeName = "bigint")]
    public long? UB13UB14_CLASSTRIB_ID { get; set; }


    [Column("DD081_LC_ID", TypeName = "nvarchar(72)")]
    public string? DD081_LC_ID { get; set; }


    [Column("UB03_IS_CLASSTRIB_ID", TypeName = "bigint")]
    public long? UB03_IS_CLASSTRIB_ID { get; set; }


    [Column("UB69_70_CLASSTRIBREG_ID", TypeName = "bigint")]
    public long? UB69_70_CLASSTRIBREG_ID { get; set; }


    [Column("UB74_79_CCREDPRESID", TypeName = "int")]
    public int? UB74_79_CCREDPRESID { get; set; }


    [Column("DD081_RF_BB027_ID", TypeName = "nvarchar(72)")]
    public string? DD081_RF_BB027_ID { get; set; }


    [Column("DD081_RF_BB027B_CFGIMP_ID", TypeName = "nvarchar(72)")]
    public string? DD081_RF_BB027B_CFGIMP_ID { get; set; }

    //-------------------------------------------------------//

    public virtual CSICP_DD060 Dd060 { get; set; } = null!;

    public virtual CSICP_DD040Ipre? Dd061Bb027bIndpresNavigation { get; set; }
}
