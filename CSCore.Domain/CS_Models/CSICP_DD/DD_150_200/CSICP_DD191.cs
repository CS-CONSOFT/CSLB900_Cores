using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD191
{
    public int TenantId { get; set; }

    public long Dd191Id { get; set; }

    public long? Dd190Obraid { get; set; }

    public string? Dd191Produtoid { get; set; }

    public string? Dd191Saldoid { get; set; }

    public decimal? Dd191Qtdcontratada { get; set; }

    public decimal? Dd191Qtdentregue { get; set; }

    public decimal? Dd191Qtdsolicitada { get; set; }

    public int? Dd191Tipoprodutoid { get; set; }

    public string? Dd191Nroserie { get; set; }

    public virtual CSICP_DD190? Dd190Obra { get; set; }

    public virtual CSICP_DD192Tp? Dd191Tipoproduto { get; set; }
}
