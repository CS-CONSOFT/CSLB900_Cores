using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD048
{
    public int TenantId { get; set; }

    public string Dd048Id { get; set; } = null!;

    public string? Dd045Id { get; set; }

    public string? Dd040Id { get; set; }

    public int? Dd048Filial { get; set; }

    public decimal? Dd048Ci { get; set; }

    public int? Dd048Tipo { get; set; }

    public string? Dd048IndOperacao { get; set; }

    public string? Dd048IndEmitente { get; set; }

    public string? Dd048Participante { get; set; }

    public string? Dd048Chaveacesso { get; set; }

    public string? Dd048Serie { get; set; }

    public int? Dd048SubSerie { get; set; }

    public decimal? Dd048NumDocto { get; set; }

    public decimal? Dd048NumEcf { get; set; }

    public string? Dd048ModDocFiscal { get; set; }

    public DateTime? Dd048DtEmisDocto { get; set; }

    public string? Dd048UfId { get; set; }

    public string? Dd048Uf { get; set; }

    public string? Dd048Cnpj { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD045? Dd045 { get; set; }

    public virtual CSICP_DD048Tipo? Dd048TipoNavigation { get; set; }
}
