using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD019
{
    public int TenantId { get; set; }

    public string Dd019Id { get; set; } = null!;

    public string? Dd019FilialId { get; set; }

    public int? Dd019TipoId { get; set; }

    public string? Dd019AtendimentoId { get; set; }

    public string? Dd019ItematendimentoId { get; set; }

    public string? Dd019UsuariopropId { get; set; }

    public string? Dd019UsuarioGerenteId { get; set; }

    public decimal? Dd019PercDesconto { get; set; }

    public decimal? Dd019Valordescont { get; set; }

    public DateTime? Dd019Dataregistro { get; set; }

    public DateTime? Dd019Dataautorizacao { get; set; }

    public int? Dd019StatusId { get; set; }

    public decimal? Dd019Pdescsolicitado { get; set; }

    public decimal? Dd019Vdescsolicitado { get; set; }

    public string? Dd019Prococolnumber { get; set; }

    public decimal? Dd019Precotabela { get; set; }

    public decimal? Dd019Pvendafinal { get; set; }

    public string? Dd019Motivoid { get; set; }

    public virtual CSICP_DD019Status? Dd019Status { get; set; }

    public virtual CSICP_DD019Tipo? Dd019Tipo { get; set; }
}
