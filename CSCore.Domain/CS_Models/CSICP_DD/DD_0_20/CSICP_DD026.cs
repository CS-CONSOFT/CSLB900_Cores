using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD026
{
    public int TenantId { get; set; }

    public long Dd026Id { get; set; }

    public string? Dd026Estabid { get; set; }

    public int? Dd026Tpmetaid { get; set; }

    public string? Dd026Ano { get; set; }

    public string? Dd026Mes { get; set; }

    public string? Dd026Vendedorid { get; set; }

    public string? Dd026Grupoprodid { get; set; }

    public decimal? Dd026Vmeta { get; set; }

    public decimal? Dd026Vmetaindividual { get; set; }

    public decimal? Dd026Pcomissao { get; set; }

    public string? Dd025Planejmetaid { get; set; }

    public int? Dd026Qcobclientes { get; set; }

    public virtual CSICP_DD025? Dd025Planejmeta { get; set; }

    public virtual CSICP_DD026Tpm? Dd026Tpmeta { get; set; }
}
