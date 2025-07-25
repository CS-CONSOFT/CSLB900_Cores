using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF117
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff117FilialId { get; set; }

    public string? Ff117TituloId { get; set; }

    public string? Ff117UsuarioProp { get; set; }

    public DateTime? Ff117Dataregistro { get; set; }

    public decimal? Ff117Valoremaberto { get; set; }

    public decimal? Ff117Multa { get; set; }

    public decimal? Ff117Juros { get; set; }

    public decimal? Ff117Desconto { get; set; }

    public decimal? Ff117Valorliquido { get; set; }

    public int? Ff117Diasatraso { get; set; }

    public string? Ff117Observacao { get; set; }

    public string? Ff117Baixapdvid { get; set; }

    public bool? Ff117Pago { get; set; }

    public bool? Ff117Isactive { get; set; }

    public string? Ff117Protocolnumber { get; set; }

    public virtual CSICP_FF102? Ff117Titulo { get; set; }
}
