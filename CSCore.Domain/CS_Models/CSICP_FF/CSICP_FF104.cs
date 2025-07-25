using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF104
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff104Filialid { get; set; }

    public string? Ff102Id { get; set; }

    public int? Ff104Filial { get; set; }

    public string? Ff104Pfx { get; set; }

    public decimal? Ff104NoTitulo { get; set; }

    public string? Ff104Sfx { get; set; }

    public decimal? Ff104CiNfNCupom { get; set; }

    public int? Ff104Notafiscal { get; set; }

    public string? Ff104Serienf { get; set; }

    public DateTime? Ff104Dataemissao { get; set; }

    public decimal? Ff104Valornf { get; set; }

    public string? Ff104Contrato { get; set; }

    public int? Ff104Nropdv { get; set; }

    public string? Ff104Renegociacaoid { get; set; }

    public string? Cc040Id { get; set; }

    public string? Cc030Id { get; set; }

    public bool? Ff104IsVinculado { get; set; }

    public string? Dd040Id { get; set; }

    public long? Bf010Id { get; set; }

    public long? Ff040Id { get; set; }

    public long? Ff140Id { get; set; }

    public long? Dd190Id { get; set; }

    public string? Ge012Id { get; set; }

    public string? Ge010Id { get; set; }

    public virtual CSICP_FF040? Ff040 { get; set; }

    public virtual CSICP_FF102? Ff102 { get; set; }

    public virtual CSICP_FF140? Ff140 { get; set; }
}
