using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.Staticas.FF;

public partial class CSICP_FF112ApiOcorrencium
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public string? CodgOcorrencia { get; set; }

    public int? BancoApi { get; set; }
}
