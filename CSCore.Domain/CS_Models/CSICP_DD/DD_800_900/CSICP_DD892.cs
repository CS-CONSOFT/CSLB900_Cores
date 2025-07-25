using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD892
{
    public int TenantId { get; set; }

    public string Dd892Id { get; set; } = null!;

    public int? Dd882Tabelaid { get; set; }

    public string? Dd882TblId { get; set; }

    public string? Dd882Usuarioid { get; set; }

    public DateTime? Dd882Datahora { get; set; }

    public string? Dd882Msg { get; set; }

    public int? Dd882Errsucessid { get; set; }

    public virtual CSICP_DD891Stat? Dd882Errsucess { get; set; }

    public virtual CSICP_DD892Tbl? Dd882Tabela { get; set; }
}
