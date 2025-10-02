using CSCore.Domain.CS_Models.Staticas.GG;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG071
{
    public int TenantId { get; set; }

    public long Gg071Id { get; set; }

    [ForeignKey("NavBB001Estab")]
    public string? Gg071Estabid { get; set; }
    public CSICP_BB001? NavBB001Estab { get; set; }

    public string? Gg071Protocolnumber { get; set; }

    public DateTime? Gg071DataMovimento { get; set; }

    [ForeignKey("NavUsuarioProprietarioSY001")]
    public string? Gg071Usuarioid { get; set; }
    public Csicp_Sy001? NavUsuarioProprietarioSY001 { get; set; }

    public string? Gg071Observacao { get; set; }

    [ForeignKey("NavBB005CentroCusto")]
    public string? Gg071Ccustoid { get; set; }
    public CSICP_Bb005? NavBB005CentroCusto { get; set; }

    public string? Gg071NoDocto { get; set; }

    [ForeignKey("NavGG071Status")]
    public int? Gg071Statusid { get; set; }
    public OsusrE9aCsicpGg071Stum? NavGG071Status { get; set; }


    public string? Dd070Id { get; set; }

    [ForeignKey("NavGg071Almoxsaida")]
    public string? Gg071Almoxsaidaid { get; set; }
    public CSICP_GG001? NavGg071Almoxsaida { get; set; }


    [ForeignKey("NavGg071Almoxent")]
    public string? Gg071Almoxentid { get; set; }
    public CSICP_GG001? NavGg071Almoxent { get; set; }


    [ForeignKey("NavAtendenteUsuarioSY001")]
    public string? Gg071AtendenteUsuarioid { get; set; }
    public Csicp_Sy001? NavAtendenteUsuarioSY001 { get; set; }

    public DateTime? Gg071Datendimento { get; set; }


    [ForeignKey("NavGG071TipoReq")]
    public int? Gg071Tpreqid { get; set; }
    public OsusrE9aCsicpGg041Tpreq? NavGG071TipoReq { get; set; }

    public DateTime? Gg071Dhsolicitacao { get; set; }

    }
