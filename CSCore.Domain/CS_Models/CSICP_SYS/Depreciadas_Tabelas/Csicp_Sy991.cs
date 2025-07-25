using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class Csicp_Sy991
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Userid { get; set; }

    public string? Usuarioid { get; set; }

    public string? Funcionalidadechave { get; set; }

    public string? Operacao { get; set; }

    public string? Registroid { get; set; }

    public string? EstacaoIp { get; set; }

    public string? EstacaoNome { get; set; }

    public DateTime? Datahora { get; set; }

    public string? Usuarionome { get; set; }

    public string? Filialid { get; set; }

    public ICollection<Csicp_Sy992> OsusrE9aCsicpSy992s { get; set; } = new List<Csicp_Sy992>();

    public Csicp_Sy001? Usuario { get; set; }
}
