using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD193
{
    public int TenantId { get; set; }

    public long Dd193Id { get; set; }

    public long? Dd192Memcalculoid { get; set; }

    public int? Dd193Parcela { get; set; }

    public DateTime? Dd193DataVencto { get; set; }

    public decimal? Dd193ValorParcela { get; set; }

    public DateTime? Dd193DataVenctoOri { get; set; }

    public string? Dd193Pfxtitulo { get; set; }

    public decimal? Dd193Titulo { get; set; }

    public string? Dd193Sfxtitulo { get; set; }

    public string? Dd193TituloCrId { get; set; }

    public virtual CSICP_DD192? Dd192Memcalculo { get; set; }
}
