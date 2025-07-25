using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD201
{
    public int TenantId { get; set; }

    public long Dd201Id { get; set; }

    public long? Dd190Obraid { get; set; }

    public long? Dd200Checklistid { get; set; }

    public decimal? Dd201Qtdhrtarefa { get; set; }

    public decimal? Dd201Qtdhrexec { get; set; }

    public virtual CSICP_DD190? Dd190Obra { get; set; }

    public virtual CSICP_DD200? Dd200Checklist { get; set; }
}
