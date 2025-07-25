using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD066
{
    public int TenantId { get; set; }

    public string Dd066Id { get; set; } = null!;

    public string? Dd051Id { get; set; }

    public string? Dd066UsuarioId { get; set; }

    public DateTime? Dd066Datahora { get; set; }

    public string? Dd066Mensagem { get; set; }

    public byte[]? Dd066Objeto { get; set; }

    public int? Dd066Tpobjeto { get; set; }

    public int? Dd066Order { get; set; }

    public virtual CSICP_DD051? Dd051 { get; set; }

    public virtual CSICP_DD066Tp? Dd066TpobjetoNavigation { get; set; }
}
