using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD182
{
    public int TenantId { get; set; }

    public long Dd182Id { get; set; }

    public long? Dd181Id { get; set; }

    public string? Dd182Codgbarras { get; set; }

    public string? Dd182ProdutoId { get; set; }

    public decimal? Dd182Qtd { get; set; }

    public string? Dd182UsuariopropId { get; set; }

    public DateTime? Dd182Datahora { get; set; }

    public bool? Dd182Isactive { get; set; }

    public int? Dd182Criarexcid { get; set; }

    public int? Dd182Modentregaid { get; set; }

    public bool? Dd182Isinseridopdv { get; set; }

    public virtual CSICP_DD181? Dd181 { get; set; }

    public virtual CSICP_DD110Mod? Dd182Modentrega { get; set; }
}
