using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD113
{
    public int TenantId { get; set; }

    public string Dd113Id { get; set; } = null!;

    public string? Dd113CargaId { get; set; }

    public int? Dd113Tipolancto { get; set; }

    public int? Dd113Seq { get; set; }

    public string? Dd113DespesaId { get; set; }

    public decimal? Dd113Valor { get; set; }

    public decimal? Dd113Pcomissao { get; set; }

    public decimal? Dd113Vcomissao { get; set; }

    public long? Dd113Romaneioid { get; set; }

    public virtual CSICP_DD110? Dd113Carga { get; set; }

    public virtual CSICP_DD111? Dd113Despesa { get; set; }

    public virtual CSICP_DD092? Dd113Romaneio { get; set; }
}
