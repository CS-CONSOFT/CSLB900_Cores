using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD893
{
    public int TenantId { get; set; }

    public string Dd893Id { get; set; } = null!;

    public int? Dd883Tabelaid { get; set; }

    public string? Dd883TblId { get; set; }

    public string? Dd883Usuarioid { get; set; }

    public DateTime? Dd883Datahora { get; set; }

    public bool? Dd883Istransf { get; set; }

    public string? Dd883Hash { get; set; }

    public string? Dd883Estabid { get; set; }

    public virtual CSICP_DD892Tbl? Dd883Tabela { get; set; }
}
