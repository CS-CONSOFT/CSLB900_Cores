using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD132Controle
{
    public int TenantId { get; set; }

    public long Dd132CtrId { get; set; }

    public int? Dd132CtrMes { get; set; }

    public int? Dd132CtrAno { get; set; }

    public int? Dd132CtrStatus { get; set; }

    public DateTime? Dd132CtrDataCalculo { get; set; }

    public DateTime? Dd132HoraInicio { get; set; }

    public DateTime? Dd132HoraFinal { get; set; }

    public virtual CSICP_DD132Status? Dd132CtrStatusNavigation { get; set; }
}
