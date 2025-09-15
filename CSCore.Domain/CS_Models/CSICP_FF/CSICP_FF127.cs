using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF127
{
    public int TenantId { get; set; }

    public string Ff127Id { get; set; } = null!;

    public string? Ff127Protocolnumber { get; set; }

    public string? Ff127ContaId { get; set; }

    public DateTime? Ff127Dtregistro { get; set; }

    public DateTime? Ff127Dtprevisao { get; set; }

    public string? Ff127Mensagem { get; set; }

    public bool? Ff127Ispago { get; set; }

    public bool? Ff127Isactive { get; set; }

    public string? Ff127CobradorId { get; set; }

    public string? Ff127AgcobradorId { get; set; }

    public bool? Ff127Isvisitado { get; set; }

    public DateTime? Ff127Dtvisita { get; set; }

    public DateTime? Ff127HoraRegistro { get; set; }

    public string? Ff127UsuarioInc { get; set; }

    public string? Ff127Motivoid { get; set; }

    public CSICP_FF002? NavFF002Motivo { get; set; }
    public CSICP_BB012? NavBB012Conta { get; set; }
    public CSICP_Bb006? NavBB006AgCobrador { get; set; }
    public Csicp_Sy001? NavSY001Cobrador { get; set; }
}
