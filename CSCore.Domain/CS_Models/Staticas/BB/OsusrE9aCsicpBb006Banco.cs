using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class CSICP_Bb006Banco
{
    public int Id { get; set; }

    public string? Nrobanco { get; set; }

    public string? Nomedobanco { get; set; }

    public string? Paginanainternet { get; set; }

    public string? Dvbanco { get; set; }
    public CSICP_Bb006? CSICP_BB006Banco { get; set; }
}
