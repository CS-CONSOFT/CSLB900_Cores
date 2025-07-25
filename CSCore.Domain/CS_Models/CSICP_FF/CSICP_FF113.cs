using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF113
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff113Usuariopropr { get; set; }

    public string? Ff113Filialid { get; set; }

    public string? Ff113RefConfBanco { get; set; }

    public DateTime? Ff113Dataregistro { get; set; }

    public string? Ff113Nota { get; set; }

    public int? Ff113Lote { get; set; }

    public string? Ff113Desclote { get; set; }

    public string? Ff113Borderoid { get; set; }

    public int? Ff113Tipo { get; set; }

    public string? Ff113Retornoid { get; set; }

    public string? Nn015Bxtesourariaid { get; set; }

    public int? Ff113Codgmovtoremessa { get; set; }

    public virtual CSICP_FF105? Ff113Bordero { get; set; }


    public virtual CSICP_FF113? Ff113Retorno { get; set; }
}
