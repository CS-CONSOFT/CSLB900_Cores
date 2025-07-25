using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD807
{
    public int TenantId { get; set; }

    public long Dd807Id { get; set; }

    public string? Dd807Descricao { get; set; }

    public string? Dd807Aplicacao { get; set; }

    public int? Dd807Modimpresid { get; set; }

    public int? Dd807Linguagemid { get; set; }

    public bool? Dd80Isactive { get; set; }

    public virtual CSICP_DD807Lg? Dd807Linguagem { get; set; }

    public virtual CSICP_DD807Mod? Dd807Modimpres { get; set; }
}
