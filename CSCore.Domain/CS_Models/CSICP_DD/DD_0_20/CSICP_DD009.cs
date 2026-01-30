using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD009
{
    public int TenantId { get; set; }

    public string Dd009Id { get; set; } = null!;

    [ForeignKey("NavBB001EmpresaID_DD009")]
    public string? Dd009Empresaid { get; set; }

    [ForeignKey("NavBB029CategoriaID_DD009")]
    public string? Dd009CategoriaId { get; set; }

    [ForeignKey("NavBB026FormaPagtoID_DD009")]
    public string? Dd009FormapagtoId { get; set; }

    public bool? Dd009Isactive { get; set; }

    public CSICP_BB001? NavBB001EmpresaID_DD009 { get; set; }

    public CSICP_Bb029? NavBB029CategoriaID_DD009 { get; set; }

    public CSICP_Bb026? NavBB026FormaPagtoID_DD009 { get; set; }
}
