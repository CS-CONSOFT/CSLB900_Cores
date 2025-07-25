using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD800
{
    public int TenantId { get; set; }

    public string Dd800Id { get; set; } = null!;

    public string? Dd800FilialId { get; set; }

    public string? Dd800ProdutoId { get; set; }

    public string? Dd800KardexId { get; set; }

    public int? Dd800Ano { get; set; }

    public int? Dd800Mes { get; set; }

    public DateTime? Dd800Datamov { get; set; }

    public decimal? Dd800VendaTfatur { get; set; }

    public decimal? Dd800VendaTqtd { get; set; }

    public decimal? Dd800VendaempromoTfatur { get; set; }

    public decimal? Dd800VendaempromoTqtd { get; set; }

    public decimal? Dd800CompraTcompra { get; set; }

    public decimal? Dd800CompraTqtd { get; set; }

    public decimal? Dd800TrocaTtroca { get; set; }

    public decimal? Dd800TrocaTqtd { get; set; }

    public decimal? Dd800CancelTfatur { get; set; }

    public decimal? Dd800CancelTqtd { get; set; }
}
