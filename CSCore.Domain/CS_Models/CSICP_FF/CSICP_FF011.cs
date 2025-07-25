using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF011
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Ff011Codigo { get; set; }

    public int? Ff011DiasAtrasosDe { get; set; }

    public int? Ff011DiasAtrasosAte { get; set; }

    public string? Ff011Tipocobrancaid { get; set; }

    public string? Ff011Categoriaid { get; set; }

    public int? Ff011SitcobrancaentId { get; set; }

    public int? Ff011SituacaoentId { get; set; }

    public int? Ff011SituacaosaiId { get; set; }

    public virtual CSICP_FF998? Ff011Sitcobrancaent { get; set; }
}
