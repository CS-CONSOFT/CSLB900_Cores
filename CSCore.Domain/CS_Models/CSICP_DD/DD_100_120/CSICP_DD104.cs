using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD104
{
    public int TenantId { get; set; }

    public string Dd104ConferenciaId { get; set; } = null!;

    public string? Dd104FilialId { get; set; }

    public string? Dd104ExecEntregaId { get; set; }

    public decimal? Dd104Cbarra { get; set; }

    public string? Dd104KardexId { get; set; }

    public decimal? Dd104Qtd { get; set; }

    public string? Dd104UsuarioproprId { get; set; }

    public DateTime? Dd104Data { get; set; }

    public bool? Dd104Processado { get; set; }

    public bool? Dd104Isactive { get; set; }

    public string? Dd104PnExecent { get; set; }

    public string? Dd104Codbarrasalfa { get; set; }

    public virtual CSICP_DD102? Dd104ExecEntrega { get; set; }
}
