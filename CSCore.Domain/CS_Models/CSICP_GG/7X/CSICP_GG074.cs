using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG074
{
    public int TenantId { get; set; }

    public long Gg074Id { get; set; }

    public string? Gg073Id { get; set; }

    public string? Gg074Codbarrasalfa { get; set; }

    public string? Gg074KardexId { get; set; }

    public string Gg074Saldoid { get; set; } = null!;

    public string? Gg074UnId { get; set; }

    public decimal Gg074Qtd { get; set; } = -1;

    public decimal? Gg074Vunitario { get; set; }

    public int Gg074Statusestqid { get; set; } = -1;

    public int? Gg074Tmovid { get; set; }

    public decimal? Gg074Tproduto { get; set; }

    public CSICP_GG073? NavGG073 { get; set; }
    public CSICP_GG008Kdx? NavGG008Kdx { get; set; }
    public CSICP_GG520? NavGG520 { get; set; }
    public CSICP_GG007? NavGG007 { get; set; }
    public CSICP_GG072Stq? NavGG072Stq { get; set; }
    public OsusrE9aCsicpGg073Tmov? NavGG073TpMov { get; set; }

    //public int? CS_Gg008Permsldnegativo { get; set; }
}
