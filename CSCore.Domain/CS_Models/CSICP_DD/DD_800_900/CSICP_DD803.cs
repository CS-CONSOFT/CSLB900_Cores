using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD803
{
    public int TenantId { get; set; }

    public string Dd803Id { get; set; } = null!;

    public string? Dd803Estabid { get; set; }

    public string? Dd803Protolnumber { get; set; }

    public string? Dd803Usuariopropid { get; set; }

    public DateTime? Dd803Datahora { get; set; }

    public DateTime? Dd803Dlimiteimp { get; set; }

}
