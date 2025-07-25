using System;
using System.Collections.Generic;
using CSCore.Domain.CS_Models.CSICP_SYS.Depreciadas_Tabelas;

namespace CSCore.Domain;

public partial class Csicp_Sy004Rest
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public string? Descricao { get; set; }

    public ICollection<Csicp_Sy008> OsusrE9aCsicpSy008s { get; set; } = new List<Csicp_Sy008>();
}
