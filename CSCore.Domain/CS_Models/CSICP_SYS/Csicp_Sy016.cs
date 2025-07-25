using System;
using System.Collections.Generic;


namespace CSCore.Domain;

public partial class Csicp_Sy016
{
    public string Id { get; set; } = null!;

    public string? Linkusuarioestabecimentoid { get; set; }

    public string? Codigoacesso { get; set; }

    public DateTime? Datacriacao { get; set; }

    public string? Usuariocriacao { get; set; }

    public int? Tipoacessorapidoid { get; set; }

    public DateTime? Dataativacao { get; set; }

    public bool? Isactive { get; set; }

    public int? TenantId { get; set; }

    public Csicp_Sy013? Linkusuarioestabecimento { get; set; }

    public Csicp_Sy016tipo? Tipoacessorapido { get; set; }

}
