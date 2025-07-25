using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD078
{
    public int TenantId { get; set; }

    public string Dd078Id { get; set; } = null!;

    public string? Dd075Id { get; set; }

    public string? Dd070Id { get; set; }

    public int? Dd078Filial { get; set; }

    public decimal? Dd078Ci { get; set; }

    public int? Dd078Tipo { get; set; }

    public string? Dd078IndOperacao { get; set; }

    public string? Dd078IndEmitente { get; set; }

    public string? Dd078Participante { get; set; }

    public string? Dd078Chaveacesso { get; set; }

    public string? Dd078Serie { get; set; }

    public int? Dd078SubSerie { get; set; }

    public decimal? Dd078NumDocto { get; set; }

    public decimal? Dd078NumEcf { get; set; }

    public string? Dd078ModDocFiscal { get; set; }

    public DateTime? Dd078DtEmisDocto { get; set; }

    public string? Dd078UfId { get; set; }

    public string? Dd078Uf { get; set; }

    public string? Dd078Cnpj { get; set; }

    public virtual CSICP_DD070? Dd070 { get; set; }

    public virtual CSICP_DD075? Dd075 { get; set; }

    public virtual CSICP_DD048Tipo? Dd078TipoNavigation { get; set; }
}
