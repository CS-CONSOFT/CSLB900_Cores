using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD812
{
    public int TenantId { get; set; }

    public string Dd812Id { get; set; } = null!;

    public string? Dd812EstabId { get; set; }

    public DateTime? Dd812Dataregistro { get; set; }

    public string? Gg520SaldoId { get; set; }

    public string? Gg008ProdutoId { get; set; }

    public string? Bb012ContaId { get; set; }

    public DateTime? Dd812Datamovto { get; set; }

    public decimal? Dd812Quantidade { get; set; }

    public decimal? Dd812SaldoAnterior { get; set; }

    public string? Dd812Serie { get; set; }

    public int? Dd812NroNfCf { get; set; }

    public string? Dd812NatoperacaoId { get; set; }

    public string? Dd812Entsaida { get; set; }

    public string? Dd060ItemId { get; set; }

    public string? Cc060ItemId { get; set; }
}
