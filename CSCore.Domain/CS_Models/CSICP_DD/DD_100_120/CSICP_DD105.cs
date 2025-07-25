using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD105
{
    public int TenantId { get; set; }

    public string Dd105OcorrenciaId { get; set; } = null!;

    public string? Dd105FilialId { get; set; }

    public string? Dd105ExecEntregaId { get; set; }

    public string? Dd105CargaId { get; set; }

    public string? Dd105MotivoId { get; set; }

    public string? Dd105Historico { get; set; }

    public string? Dd105UsuariopropId { get; set; }

    public DateTime? Dd105Data { get; set; }

    public bool? Dd105Isfechado { get; set; }

    public bool? Dd105Isactive { get; set; }

    public decimal? Dd105QtdRetorno { get; set; }

    public string? Dd105Protocolnumber { get; set; }

    public bool? Dd105Issync { get; set; }

    public DateTime? Dd105DthrUltsync { get; set; }

    public string? Dd105Chvmobile { get; set; }

    public virtual CSICP_DD102? Dd105ExecEntrega { get; set; }
}
