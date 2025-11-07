using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_RR;

public partial class OsusrTo3CsicpRr022
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    [ForeignKey("NavRR021LoteXAnimal_RR022")]
    public string? Rr022Loteid { get; set; }

    [ForeignKey("NavRR001Animal_RR022")]
    public string? Rr022Animalid { get; set; }

    public DateTime? Rr022Dtpeso { get; set; }

    public int? Rr022Idadediasatual { get; set; }

    public decimal? Rr022Peso { get; set; }

    public DateTime? Rr001Dtultpeso { get; set; }

    public decimal? Rr001Ultpeso { get; set; }

    public int? Rr022Idadediasult { get; set; }

    public decimal? Rr022Gmd { get; set; }

    public decimal? Rr022Gpd { get; set; }

    public DateTime? Rr022Dthrregistro { get; set; }

    public string? Rr022Usuarioid { get; set; }

    public bool? Rr022IsProcessado { get; set; }

    public OsusrTo3CsicpRr001? NavRR001Animal_RR022 { get; set; }

    public OsusrTo3CsicpRr021? NavRR021LoteXAnimal_RR022 { get; set; }
}
