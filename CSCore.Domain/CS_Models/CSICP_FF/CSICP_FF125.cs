using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF125
{
    public int TenantId { get; set; }

    public string Ff125Id { get; set; } = null!;

    public string? Ff125ContaId { get; set; }

    public DateTime? Ff125Dtregistro { get; set; }

    public int? Ff125Qtdtitulos { get; set; }

    public decimal? Ff125Totalaberto { get; set; }

    public string? Ff125Cobradorid { get; set; }

    public string? Ff125AgcobradorId { get; set; }

    public string? Ff125Mensagem { get; set; }

    public DateTime? Ff125Dtprevisaogeral { get; set; }

    public bool? Ff125Isactive { get; set; }

    public string? Ff125Categoriaid { get; set; }

    public int? Ff125StatusId { get; set; }

    public int? Ff125SitcobentId { get; set; }

    public bool? Ff125Ismarcado { get; set; }

    public bool? Ff125Iscobrado { get; set; }

    public DateTime? Ff125Dtcobranca { get; set; }

    public string? Ff125ContaAvalista { get; set; }

    public string? Ff125Motivoid { get; set; }

    public int? Ff125Sitcobranca { get; set; }

    public decimal? Ff125Latitude { get; set; }

    public decimal? Ff125Longitude { get; set; }

    public CSICP_BB012? NavBB012Conta { get; set; }
    public CSICP_FF002? NavFF002Motivo { get; set; }
}
