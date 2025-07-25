using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF043
{
    public int TenantId { get; set; }

    public long Ff043Id { get; set; }

    public long? Ff042Id { get; set; }

    public int? Ff043Parcela { get; set; }

    public DateTime? Ff043DataVencto { get; set; }

    public decimal? Ff043ValorParcela { get; set; }

    public DateTime? Ff043DataVenctoOri { get; set; }

    public string? Ff043Pfxtitulo { get; set; }

    public decimal? Ff043Titulo { get; set; }

    public string? Ff043Sfxtitulo { get; set; }

    public string? Ff043TituloCpId { get; set; }

    public virtual CSICP_FF042? Ff042 { get; set; }

    public virtual CSICP_FF102? Ff043TituloCp { get; set; }
}
