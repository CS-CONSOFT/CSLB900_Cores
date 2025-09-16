using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF127
{
    private CSICP_FF127() { }
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

    public static CSICP_FF127 CreateInstance(
        int tenant,
        string id,
        string protocolo,
        string contaID,
        DateTime dataPrevisao, string mensagem, string sy001CobradorID, string agCobradorId, DateTime dataVisita,
        string sy001ID, string ff001IdMotivo)
    {
        return new CSICP_FF127
        {
            TenantId = tenant,
            Ff127Id = id,
            Ff127Protocolnumber = protocolo,
            Ff127ContaId = contaID,
            Ff127Dtregistro = DateTime.UtcNow.ToLocalTime(),
            Ff127Dtprevisao = dataPrevisao,
            Ff127Mensagem = mensagem,
            Ff127Ispago = false,
            Ff127Isactive = true,
            Ff127CobradorId = sy001CobradorID,
            Ff127AgcobradorId = agCobradorId,
            Ff127Isvisitado = !mensagem.IsNullOrEmpty(),
            Ff127Dtvisita = dataVisita,
            Ff127HoraRegistro = DateTime.UtcNow.ToLocalTime(),
            Ff127UsuarioInc = sy001ID,
            Ff127Motivoid = ff001IdMotivo,
        };
    }
}
