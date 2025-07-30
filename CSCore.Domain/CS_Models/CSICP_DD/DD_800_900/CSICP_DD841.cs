using CSCore.Domain.CS_Models.CSICP_DD;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD841
{
    public int TenantId { get; set; }

    public long Dd841Id { get; set; }

    public long? Dd841RascunhovfeId { get; set; }

    public string? Dd841ProdutoVendaId { get; set; }

    public string? Dd841Codbarrasalfa { get; set; }

    public string? Dd841Descricao { get; set; }

    public string? Dd841SaldoId { get; set; }

    public string? Dd841Unidadeid { get; set; }

    public decimal? Dd841Qtd { get; set; }

    public int? Dd841Modentregaid { get; set; }

    public virtual CSICP_DD110Mod? Dd841Modentrega { get; set; }

    public virtual CSICP_DD060? Dd841ProdutoVenda { get; set; }

    public virtual CSICP_DD840? Dd841Rascunhovfe { get; set; }
}
