using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.Staticas.FF;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF017
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Ff017Tiporegistro { get; set; }

    public string? Ff017Filialid { get; set; }

    public int? Ff017Filial { get; set; }

    public DateTime? Ff017DataRenegociacao { get; set; }

    public string? Ff017Especieid { get; set; }

    public string? Ff017Contaid { get; set; }

    public string? Ff017Ccustoid { get; set; }

    public string? Ff017Agcobradorid { get; set; }

    public string? Ff017Usuarioid { get; set; }

    public string? Ff017Condicaoid { get; set; }

    public string? Ff017Tipocobrancaid { get; set; }

    public string? Ff017Contatomadordivid { get; set; }

    public decimal? Ff017PercJuros { get; set; }

    public decimal? Ff017Multa { get; set; }

    public decimal? Ff017TotalTitulos { get; set; }

    public decimal? Ff017TotalAberto { get; set; }

    public decimal? Ff017TotalJuros { get; set; }

    public decimal? Ff017TotalMulta { get; set; }

    public decimal? Ff017TotalDescontos { get; set; }

    public decimal? Ff017Totrenegociado { get; set; }

    public decimal? Ff017ValorEntrada { get; set; }

    public decimal? Ff017PercEntrada { get; set; }

    public bool? Ff017Aberto { get; set; }

    public string? Ff017Protocolnumber { get; set; }

    public decimal? Ff017Pminvlrentrada { get; set; }

    public decimal? Ff017Vminentrada { get; set; }

    public string? Ff017Valecreditoid { get; set; }

    public int? Ff017Statusvcid { get; set; }

    public string? Ff017Formapagtoid { get; set; }

    public virtual CSICP_FF003? Ff017Especie { get; set; }

    public class RepoDtoCSICP_FF017 : CSICP_FF017
    {
        public CSICP_BB001? NavBB001 { get; set; }
        public CSICP_Bb005? NavBB005 { get; set; }
        public CSICP_Bb006? NavBB006 { get; set; }
        public CSICP_Bb008? NavBB008 { get; set; }
        public CSICP_Bb009? NavBB009 { get; set; }
        public CSICP_BB012? NavBB012 { get; set; }
        public CSICP_Bb026? NavBB026 { get; set; }
        public CSICP_DD125? NavDD125 { get; set; }
        public OsusrE9aCsicpFf107Vc? NavFF107vc { get; set; }
        public CSICP_FF003? NavFF003 { get; set; }
        public Csicp_Sy001? NavSY001 { get; set; }
    }
}
