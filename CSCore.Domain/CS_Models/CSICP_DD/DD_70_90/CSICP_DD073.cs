using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD073
{
    public int TenantId { get; set; }

    public string Dd073Id { get; set; } = null!;

    public string? Dd072Id { get; set; }

    public int? Dd073Parcela { get; set; }

    public DateTime? Dd073DataVencto { get; set; }

    public decimal? Dd073ValorParcela { get; set; }

    public string? Dd073NoCartao { get; set; }

    public int? Dd073Banco { get; set; }

    public decimal? Dd073Agencia { get; set; }

    public string? Dd073Dvagencia { get; set; }

    public decimal? Dd073Conta { get; set; }

    public string? Dd073Dvconta { get; set; }

    public int? Dd073Cheque { get; set; }

    public decimal? Dd073Rg { get; set; }

    public string? Dd073Telefone { get; set; }

    public bool? Dd073Compensacao { get; set; }

    public bool? Dd073ChequeTerceiro { get; set; }

    public DateTime? Dd073DataVenctoOri { get; set; }

    public string? Dd073UsuarioidAltdtvc { get; set; }

    public virtual CSICP_DD072? Dd072 { get; set; }
}
