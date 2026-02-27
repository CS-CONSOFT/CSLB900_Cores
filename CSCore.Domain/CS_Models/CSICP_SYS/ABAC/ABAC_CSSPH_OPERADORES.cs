using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

public partial class ABAC_CSSPH_OPERADORES
{
    public string Id { get; set; } = null!;

    [Column("OPERATOR_CODE")]
    public string? Operator { get; set; }

    public string? Description { get; set; }

    [Column("EXAMPLE_USAGE")]
    [MaxLength(200)]
    public string? EXAMPLE_USAGE { get; set; }


    [Column("OBSERVATIONS")]
    [MaxLength(200)]
    public string? OBSERVATIONS { get; set; }
}
