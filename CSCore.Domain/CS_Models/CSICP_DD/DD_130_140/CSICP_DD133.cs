using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD133
{
    public int TenantId { get; set; }

    public string Dd133Id { get; set; } = null!;

    public string? Dd133EstabelecimentoId { get; set; }

    public DateTime? Dd133Dprocessamento { get; set; }

    public string? Dd133UsuarioId { get; set; }

    public string? Dd133ResponsavelId { get; set; }

    public string? Dd133MontadorId { get; set; }

    public string? Dd133ArquitetoId { get; set; }

    public decimal? Dd133Vcomissao { get; set; }

    public decimal? Dd133Vfaturamento { get; set; }

    public string? Ff102Id { get; set; }

    public DateTime? Dd133DfinalComissao { get; set; }

    public string? Dd133AnomesRef { get; set; }

    public string? Dd133Protocolnumber { get; set; }

    public string? Dd133Loteid { get; set; }

    public DateTime? Dd133DataRef { get; set; }

    public virtual CSICP_DD136? Dd133Lote { get; set; }

    public virtual CSICP_DD158? Dd133Montador { get; set; }
}
