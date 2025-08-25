using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF013
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff013Filialid { get; set; }

    public string? Ff013Grupocobrancaid { get; set; }

    public string? Ff013Cobradorid { get; set; }

    public string? Ff013Zonaid { get; set; }

    public string? Ff013Contaid { get; set; }

    public int? Ff013Tpregistro { get; set; }

    public virtual CSICP_FF012? Ff013Grupocobranca { get; set; }

    public class RepoDtoCSICP_FF013 : CSICP_FF013
    {
        // Navs
        public CSICP_BB001? NavBB001 { get; set; }
        public CSICP_FF012? NavFF012 { get; set; }
        public Csicp_Sy001? NavSY001 { get; set; }
        public CSICP_Bb010? NavBB010 { get; set; }
        public CSICP_BB012? NavBB012 { get; set; }
    }
}
