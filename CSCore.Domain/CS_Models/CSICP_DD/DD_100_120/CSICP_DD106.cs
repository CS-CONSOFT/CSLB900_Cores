using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD106
{
    public int TenantId { get; set; }

    public long Dd106Id { get; set; }

    public string? Dd101Id { get; set; }

    public string? Dd106Logradouro { get; set; }

    public string? Dd106Numero { get; set; }

    public string? Dd106Complemento { get; set; }

    public string? Dd106Perimetro { get; set; }

    public string? Dd106Nomebairro { get; set; }

    public int? Dd106Cep { get; set; }

    public string? Dd106PaisId { get; set; }

    public string? Dd106UfId { get; set; }

    public string? Dd106CidadeId { get; set; }

    public virtual CSICP_DD101? Dd101 { get; set; }
}
