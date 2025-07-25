using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class Csicp_Sy999
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy999Usuarioid { get; set; }

    public string? Sy999Criadopor { get; set; }

    public DateTime? Sy999Datainc { get; set; }

    public DateTime? Sy999Horainc { get; set; }

    public string? Sy999Alteradopor { get; set; }

    public DateTime? Sy999Dataalt { get; set; }

    public DateTime? Sy999Horaalt { get; set; }

    public Csicp_Sy001? Sy999Usuario { get; set; }
}
