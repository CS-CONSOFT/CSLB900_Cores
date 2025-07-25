using CSCore.Domain.CS_Models.Staticas.PD;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Domain;

public partial class CSICP_Bb017
{
    public int TenantId { get; set; }

    [Key]
    public string Bb017Id { get; set; } = null!;

    public string? Bb017Empresaid { get; set; }

    public string? Bb017Fpagtoid { get; set; }

    public string? Bb017Condicaoid { get; set; }

    public decimal? Bb017Fatoracrescimo { get; set; }

    public decimal? Bb017Fatorsementrada { get; set; }

    public int? Bb017Ordem { get; set; }

    public int? Bb017CmdTefVdId { get; set; }

    public int? Bb017CmdTefCancId { get; set; }

    public int? Bb017Parcliquidadas { get; set; }

    public int? Bb017Entliquidada { get; set; }

    public decimal? Bb017Vacimade { get; set; }

    public CSICP_Bb008? NavBb008Condicao { get; set; }

    public CSICP_Bb026? NavBB026Forma { get; set; }
    public CSICP_PD001Ctef? NavCSICP_PD001Ctef_Cmd_Tef_VD { get; set; }
    public CSICP_PD001Ctef? NavCSICP_PD001Ctef_Cmd_Tef_Canc { get; set; }
    public CSICP_Statica? NavStatica_BB017_EntLiquidada { get; set; } = null;
    public CSICP_Statica? NavStatica_BB017_ParcLiquidadas { get; set; } = null;
}
