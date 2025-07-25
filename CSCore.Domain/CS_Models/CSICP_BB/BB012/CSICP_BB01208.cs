
namespace CSCore.Domain;

public partial class CSICP_BB01208
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Bb012Id { get; set; }

    public string? Bb012Contatoid { get; set; }

    public string? Bb036Candidatoid { get; set; }

    public string? Bb043Campanhaid { get; set; }

    public string? Bb042Potencialid { get; set; }

    public string? Bb040Atividadeid { get; set; }

    public string? Bb041Casoid { get; set; }

    public bool? Bb01208IsActive { get; set; }

    public string? Concorrenteid { get; set; }

    public int? Bb01208GrauparentId { get; set; }

    //public int? Bb01208CodgCliente7x { get; set; }

    //public short? Bb01208SeqCliente7x { get; set; }

    //public int? Bb01208OrigemcontatoId { get; set; }

    public CSICP_Bb035? NavCSICP_BB035 { get; set; }
    public CSICP_Bb035Gpa? NavCSICP_BB035Gpa { get; set; }
}
