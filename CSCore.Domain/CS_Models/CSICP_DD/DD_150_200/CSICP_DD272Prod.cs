using CSCore.Domain.CS_Models.CSICP_DD.DD_40_60;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD272Prod
{
    public int TenantId { get; set; }

    public string Dd272Id { get; set; } = null!;

    public string? Dd270Id { get; set; }

    public string? Dd272AttrNitem { get; set; }

    public string? Dd272Cprod { get; set; }

    public string? Dd272Cean { get; set; }

    public string? Dd272Xprod { get; set; }

    public string? Dd272Ncm { get; set; }

    public string? Dd272Extipi { get; set; }

    public string? Dd272Cfop { get; set; }

    public string? Dd272Ucom { get; set; }

    public string? Dd272Qcom { get; set; }

    public string? Dd272Vuncom { get; set; }

    public string? Dd272Vprod { get; set; }

    public string? Dd272Ceantrib { get; set; }

    public string? Dd272Utrib { get; set; }

    public string? Dd272Qtrib { get; set; }

    public string? Dd272Vuntrib { get; set; }

    public string? Dd272Vfrete { get; set; }

    public string? Dd272Vseg { get; set; }

    public string? Dd272Vdesc { get; set; }

    public string? Dd272Voutro { get; set; }

    public string? Dd272Indtot { get; set; }

    public string? Dd272KardexId { get; set; }

    public string? Dd272SaldoId { get; set; }

    public string? Dd272Bb027Id { get; set; }

    public string? Dd272Infadprod { get; set; }

    public string? Dd272Xped { get; set; }

    public int? Dd272AtrNitemnum { get; set; }

    public string? Dd272Indescala { get; set; }

    public int? Dd272Ierelevanteid { get; set; }

    public string? Dd272Cnpjfabricante { get; set; }

    public string? Dd272Nomefabricante { get; set; }

    public string? Dd060Id { get; set; }

    public virtual CSICP_DD060? Dd060 { get; set; }

    public virtual CSICP_DD270? Dd270 { get; set; }
}
