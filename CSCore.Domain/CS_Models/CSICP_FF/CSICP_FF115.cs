using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF115
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff115Filialid { get; set; }

    public string? Ff113Controleid { get; set; }

    public int? Ff115Codgfilial { get; set; }

    public string? Ff115Pfx { get; set; }

    public decimal? Ff115Titulo { get; set; }

    public string? Ff115Sfx { get; set; }

    public decimal? Ff115Conta { get; set; }

    public string? Ff115Nossonumero { get; set; }

    public string? Ff115Codgmovtoretorno { get; set; }

    public DateTime? Ff115Datavencimento { get; set; }

    public decimal? Ff115Valornominaltitulo { get; set; }

    public decimal? Ff115Jurosmultaencargos { get; set; }

    public decimal? Ff115Vlrdescontoconcedido { get; set; }

    public decimal? Ff115Abatimentocancelamento { get; set; }

    public decimal? Ff115Valorpago { get; set; }

    public decimal? Ff115Valorliquido { get; set; }

    public DateTime? Ff115Datacredito { get; set; }

    public string? Ff102TituloId { get; set; }

    public bool? Ff115IsincluirBaixa { get; set; }

    public string? Ff115Codgmovc044 { get; set; }

    public string? Ff115Desccodgmovimento { get; set; }

    public string? Ff115Codgocorrcc047 { get; set; }

    public string? Ff115Desccodgocorrcc047 { get; set; }

    public virtual CSICP_FF102? Ff102Titulo { get; set; }

    public virtual CSICP_FF113? Ff113Controle { get; set; }
}
