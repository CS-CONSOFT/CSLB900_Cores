using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD092
{
    public int TenantId { get; set; }

    public long Dd092Id { get; set; }

    public string? Dd092EstabId { get; set; }

    public string? Dd092Protocolo { get; set; }

    public DateTime? Dd092Data { get; set; }

    public DateTime? Dd092Datasaida { get; set; }

    public string? Dd092RotaId { get; set; }

    public int? Dd092Qnfs { get; set; }

    public int? Dd092Tfaturasnfs { get; set; }

    public int? Dd092Ttitulos { get; set; }

    public string? Dd092VeiculoId { get; set; }

    public string? Dd092MotoristaId { get; set; }

    public int? Dd092Statusid { get; set; }

    public virtual CSICP_DD092stum? Dd092Status { get; set; }
}
