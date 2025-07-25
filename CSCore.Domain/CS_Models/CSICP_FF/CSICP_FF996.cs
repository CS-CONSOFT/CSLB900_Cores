using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF996
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Ff102Id { get; set; }

    public string? Ff103Id { get; set; }

    public DateTime? Ff996Datainc { get; set; }

    public DateTime? Ff996Horainc { get; set; }

    public bool? Ff996Isprocessado { get; set; }

    public string? Ff996Json { get; set; }

    public string? Transactionid { get; set; }

    public string? Ff996Mensagem { get; set; }

    public int? Ff996Statusid { get; set; }

    public decimal? Ff996Vlrpago { get; set; }

    public string? Endtoendid { get; set; }

    public DateTime? Ff996Dtpagto { get; set; }

    public virtual CSICP_FF102? Ff102 { get; set; }

    public virtual CSICP_FF103? Ff103 { get; set; }
}
