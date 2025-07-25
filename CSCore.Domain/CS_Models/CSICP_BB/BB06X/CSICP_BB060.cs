
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_Bb060
{
    public int TenantId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Bb060Convenioid { get; set; }

    public string? Bb060Codigo { get; set; }

    public string? Bb060Descricao { get; set; }

    public decimal? Bb060Vbase { get; set; }

    public string? Bb060Ccustoid { get; set; }

    public string? Bb060Usuarioproprieid { get; set; }

    public string? Bb060Agcobradorid { get; set; }

    public string? Bb060Responsavelid { get; set; }

    public string? Bb060Condicaoid { get; set; }

    public string? Bb060Tipocobrancaid { get; set; }

    public string? Bb060Usuarioinc { get; set; }

    public string? Bb060Usuarioalt { get; set; }

    public DateTime? Bb060Dthrinc { get; set; }

    public DateTime? Bb060Dthralt { get; set; }

    public string? Bb060Especieid { get; set; }

    public string? Bb060FpagtoId { get; set; }

    public bool? Bb060Isactive { get; set; }

    public long? Bb060Convmasterid { get; set; }

    public CSICP_Bb006? Bb060Agcobrador { get; set; }
    //public Csicp_Sy001? UsuarioProprietario { get; set; }
    public CSICP_Bb005? Bb060Ccusto { get; set; }

    public CSICP_Bb026? FormaPagamento { get; set; }

    public CSICP_Bb008? Bb060Condicao { get; set; }

    public CSICP_Bb067? Bb060Convmaster { get; set; }

    public CSICP_BB007? Bb060Responsavel { get; set; }

    public CSICP_Bb009? Bb060Tipocobranca { get; set; }

    //public ICollection<CSICP_Bb061> OsusrE9aCsicpBb061s { get; set; } = new List<CSICP_Bb061>();

    //public ICollection<CSICP_Bb065> OsusrE9aCsicpBb065s { get; set; } = new List<CSICP_Bb065>();
}
