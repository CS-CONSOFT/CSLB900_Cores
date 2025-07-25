using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD015
{
    public int TenantId { get; set; }

    public string Dd015Id { get; set; } = null!;

    public string? Dd014Id { get; set; }

    public string? Dd015CodgverbaId { get; set; }

    public string? Dd015Descverba { get; set; }

    public decimal? Dd015Percentual { get; set; }

    public decimal? Dd015Valorverba { get; set; }

    public int? Dd015Frequencia { get; set; }

    public int? Dd015Forma { get; set; }

    public virtual CSICP_DD014? Dd014 { get; set; }

    public virtual CSICP_DD902Forma? Dd015FormaNavigation { get; set; }

    public virtual CSICP_DD901Freq? Dd015FrequenciaNavigation { get; set; }
}
