using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD050
{
    public int TenantId { get; set; }

    public string Dd050Id { get; set; } = null!;

    public string? Dd040Id { get; set; }

    public int? Dd050Filial { get; set; }

    public decimal? Dd050Ci { get; set; }

    public string? Dd050Motivo { get; set; }

    public int? Dd050Tipo { get; set; }

    public DateTime? Dd050DtInclusao { get; set; }

    public DateTime? Dd050HrInclusao { get; set; }

    public string? Dd050Usuarioproprietario { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD050Tipo? Dd050TipoNavigation { get; set; }
}
