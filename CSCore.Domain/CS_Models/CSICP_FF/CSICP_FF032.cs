using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF032
{
    public int TenantId { get; set; }

    public string Ff032Id { get; set; } = null!;

    public string? Ff032Estabid { get; set; }

    public string? Ff032Protocolnumber { get; set; }

    public DateTime? Ff032DataMovimento { get; set; }

    public string? Ff032Contaid { get; set; }

    public string? Ff032Tituloid { get; set; }

    public string? Ff032Texto { get; set; }

    public decimal? Ff032Vlrabertotit { get; set; }

    public string? Ff032UsuarioProprId { get; set; }

    public DateTime? Ff032Dinclusao { get; set; }

    public string? Ff032UsuarioAlt { get; set; }

    public DateTime? Ff032Dalteracao { get; set; }

    public int? Ff032Statusid { get; set; }

    public int? Ff032Tiporegistro { get; set; }

    public virtual CSICP_FF102? Ff032Titulo { get; set; }
}
