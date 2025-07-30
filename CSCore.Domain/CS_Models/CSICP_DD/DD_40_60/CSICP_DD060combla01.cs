using CSCore.Domain.CS_Models.CSICP_DD.DD_40_60;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD060combla01
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Dd060Id { get; set; }

    public string? La02Cprodanp { get; set; }

    public string? La03Descanp { get; set; }

    public decimal? La03aPglp { get; set; }

    public decimal? La03bPgnn { get; set; }

    public decimal? La03cPgni { get; set; }

    public decimal? La03dVpart { get; set; }

    public string? La04Codif { get; set; }

    public decimal? La05Qtemp { get; set; }

    public decimal? La17Pbio { get; set; }

    public string? La06Ufcons { get; set; }

    public virtual CSICP_DD060? Dd060 { get; set; }
}
