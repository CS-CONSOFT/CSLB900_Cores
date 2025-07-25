using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class CSICP_BB01205
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Bb012Filial { get; set; }

    public string? Bb012Login { get; set; }

    public decimal? Bb012Qtdeusuario { get; set; }

    public string? Bb012Categoriaatendimento { get; set; }

    public decimal? Bb012Diapagamento { get; set; }

    public decimal? Bb012Qtdusuariopdvn { get; set; }

    public decimal? Bb012Qtdusuariopdvf { get; set; }

    public decimal? Bb012Qtdhrscontrato { get; set; }

    public decimal? Bb012Qtdhrsexcedente { get; set; }

    public decimal? Bb012Valorhrexcedente { get; set; }

    public string? Bb012Empresaid { get; set; }

    public CSICP_BB012 IdNavigation { get; set; } = null!;
}
