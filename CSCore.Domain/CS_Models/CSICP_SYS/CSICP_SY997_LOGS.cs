using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_SYS;

public partial class CSICP_SY997_LOGS
{
    public int TenantId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public string? Sy997ExternalId { get; set; } = string.Empty;

    public DateTime? Sy997Datainc { get; set; }

    public string? Sy997Nomeusuario { get; set; } = string.Empty;

    public string? Sy997Mensagem { get; set; } = string.Empty;

    public bool? Sy997Isexibiu { get; set; }

    public string? Sy997Severidade { get; set; } = string.Empty;

    public string? JsonHeader { get; set; } = string.Empty;

    public string? JsonQuery { get; set; } = string.Empty;

    public string? JsonBody { get; set; } = string.Empty;
}
