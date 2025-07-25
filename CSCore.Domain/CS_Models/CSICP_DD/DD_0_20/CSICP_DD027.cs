using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD027
{
    public int TenantId { get; set; }

    public long Dd027Id { get; set; }

    public string? Dd025Planejmetaid { get; set; }

    public string? Dd027Estabid { get; set; }

    public long? Dd026Metaid { get; set; }

    public string? Dd027Grupoprodid { get; set; }

    public string? Dd027Vendedorid { get; set; }

    public decimal? Dd027Vvendabruta { get; set; }

    public decimal? Dd027Vdevolucao { get; set; }

    public decimal? Dd027Vvendaliq { get; set; }

    public int? Dd027Qcobclientes { get; set; }

    public virtual CSICP_DD025? Dd025Planejmeta { get; set; }

    public virtual CSICP_DD026? Dd026Meta { get; set; }
}
