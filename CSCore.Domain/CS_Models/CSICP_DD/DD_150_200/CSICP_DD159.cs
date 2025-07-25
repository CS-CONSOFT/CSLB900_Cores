using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD159
{
    public int TenantId { get; set; }

    public string Dd159Id { get; set; } = null!;

    public int? Dd150Id { get; set; }

    public string? Dd159Logradouro { get; set; }

    public string? Dd159Numero { get; set; }

    public string? Dd159Complemento { get; set; }

    public string? Dd159Perimetro { get; set; }

    public string? Dd159Nomebairro { get; set; }

    public int? Dd159Cep { get; set; }

    public string? Dd159PaisId { get; set; }

    public string? Dd159UfId { get; set; }

    public string? Dd159CidadeId { get; set; }

    public string? Dd159Telefone { get; set; }

    public string? Dd159Sms { get; set; }

    public virtual CSICP_DD150? Dd150 { get; set; }
}
