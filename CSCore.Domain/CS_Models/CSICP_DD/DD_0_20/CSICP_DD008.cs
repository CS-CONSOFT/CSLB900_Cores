using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD008
{
    public int TenantId { get; set; }

    public string Dd008Id { get; set; } = null!;

    [ForeignKey("NavBB001EmpresaID_DD008")]
    public string? Dd008Empresaid { get; set; }
    
    [ForeignKey("NavBB007ResponsavelID_DD008")]
    public string? Dd008ResponsavelId { get; set; }

    [ForeignKey("NavBB032CargoID_DD008")]
    public string? Dd008CargoId { get; set; }

    [ForeignKey("NavBB026FormaPagtoID_DD008")]
    public string? Dd008FormapagtoId { get; set; }

    [ForeignKey("NavBB008CondPagtoID_DD008")]
    public string? Dd008CondpagtoId { get; set; }

    public decimal? Dd008Valorate { get; set; }

    public decimal? Dd008Percdesconto { get; set; }

    public bool? Dd008Isactive { get; set; }

    public CSICP_BB001? NavBB001EmpresaID_DD008 { get; set; }
    public CSICP_BB007? NavBB007ResponsavelID_DD008 { get; set; }
    public CSICP_Bb032? NavBB032CargoID_DD008 { get; set; }
    public CSICP_Bb026? NavBB026FormaPagtoID_DD008 { get; set; }
    public CSICP_Bb008? NavBB008CondPagtoID_DD008 { get; set; }
}
