using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF106
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff106Filialid { get; set; }

    public string? Ff105Id { get; set; }

    public string? Ff102Id { get; set; }

    public bool? Ff106Selecionado { get; set; }

    public string? Ff106Agcobradorid { get; set; }

    public string? Ff106Tipocobrancaid { get; set; }

    public string? Ff106InstCobranca1 { get; set; }

    public string? Ff106InstCobranca2 { get; set; }

    public string? Ff106IdOutroBordero { get; set; }

    public int? Ff106CodgOcorrencia { get; set; }

    public string? Ff106Ocorrencia { get; set; }

    public decimal? Ff106Jurosrecebido { get; set; }

    public decimal? Ff106Multarecebida { get; set; }

    public decimal? Ff106Outrovlrrecebido { get; set; }

    public decimal? Ff106Descconcedido { get; set; }

    public decimal? Ff106Valorpago { get; set; }

    public DateTime? Ff106DataRecto { get; set; }

    public DateTime? Ff106DataCredito { get; set; }

    public string? Nn016IdBxTes { get; set; }

    public DateTime? Ff106DataBxaut { get; set; }

    public DateTime? Ff106DataProtesto { get; set; }

    public int? Ff106Diasprotesto { get; set; }

    public int? Ff106Prazorecto { get; set; }

    public DateTime? Ff106DataLimrecto { get; set; }

    public string? Ff106CodigoErroApi { get; set; }

    public string? Ff106VersaoErroApi { get; set; }

    public string? Ff106MsgErroApi { get; set; }

    public string? Ff106OcorErroApi { get; set; }

    public int? Ff106OcorrenciaApi { get; set; }

    public int? Ff106LiqApi { get; set; }

    public int? Ff106BaixaApi { get; set; }

    // Navs Movidas do RepoDtoFF106
    public CSICP_BB001? NavBB001 { get; set; }
    public CSICP_Bb006? NavBB006 { get; set; }
    public CSICP_Bb009? NavBB009 { get; set; }
    public CSICP_FF102? NavFF102 { get; set; }
    public CSICP_FF105? NavFF105 { get; set; }
    public CSICP_FF112ApiOcorrencium? NavFF112ApiOcorrencia { get; set; }
    public CSICP_FF112ApiBaixa? NavFF112ApiBaixa { get; set; }
    public CSICP_FF112ApiLiquidacao? NavFF112ApiLiquidacao { get; set; }
    
}
