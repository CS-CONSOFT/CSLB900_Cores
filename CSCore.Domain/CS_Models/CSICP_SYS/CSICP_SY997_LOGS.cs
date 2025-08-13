using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Domain.CS_Models.CSICP_SYS;

public partial class CSICP_SY997_LOGS
{
    public int TenantId { get; set; }

    [Key]
    public long Id { get; set; }

    public string? Sy997ExternalId { get; set; }

    public DateTime? Sy997Datainc { get; set; }

    public string? Sy997Nomeusuario { get; set; }

    public string? Sy997Mensagem { get; set; }

    public bool? Sy997Isexibiu { get; set; }

    public string? Sy997Severidade { get; set; }
}
