using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD167
{
    public int TenantId { get; set; }

    public long Dd167Id { get; set; }

    public long? Dd166Id { get; set; }

    public int? Dd167Tpeventoid { get; set; }

    public string? Dd167Usuariopropid { get; set; }

    public DateTime? Dd167Dregistro { get; set; }

    public string? Dd167Msg { get; set; }

    public string? Dd167Sms { get; set; }

    public string? Dd167Email { get; set; }

    public string? Dd167Estabid { get; set; }

    public string? Dd167NotaId { get; set; }

    public string? Dd167PvId { get; set; }

    public string? Dd167PdvId { get; set; }

    public virtual CSICP_DD166? Dd166 { get; set; }

    public virtual CSICP_DD040? Dd167Nota { get; set; }

    public virtual CSICP_DD070? Dd167Pv { get; set; }

    public virtual CSICP_DD168Tp? Dd167Tpevento { get; set; }
}
