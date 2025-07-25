using System;
using System.Collections.Generic;


namespace CSCore.Domain.CS_Models.CSICP_SYS.Depreciadas_Tabelas;

public partial class Csicp_Sy008
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy008Userid { get; set; }

    public int? Sy008RestricaoestatId { get; set; }

    public Csicp_Sy004Rest? Sy008Restricaoestat { get; set; }

    public Csicp_Sy001? Sy008User { get; set; }
}
