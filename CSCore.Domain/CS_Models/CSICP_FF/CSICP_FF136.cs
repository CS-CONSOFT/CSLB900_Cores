using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF136
{
    public int TenantId { get; set; }

    public string Ff136RegccredId { get; set; } = null!;

    public string? Ff136FilialId { get; set; }

    public string? Ff136Cdebitoid { get; set; }

    public string? Ff136Protocolnumber { get; set; }

    [ForeignKey("NavFf136Usuarioprop")]
    public string? Ff136UsuariopropId { get; set; }

    [JsonIgnore]
    public Csicp_Sy001? NavFf136Usuarioprop { get; set; }

    public DateTime? Ff136DataMovto { get; set; }

    public DateTime? Ff136DataCredito { get; set; }

    public decimal? Ff136VlrUtilizado { get; set; }

    public string? Ff136Historico { get; set; }

    public string? Ff136UsoInternoWs { get; set; }

    public int? Ff136Tpmovid { get; set; }

    [ForeignKey("NavFf102")]
    public string? Ff102Id { get; set; }


    public string? Ff103Id { get; set; }

    public int? Ff136Statusid { get; set; }

    [JsonIgnore]
    public CSICP_FF102? NavFf102 { get; set; }
    [JsonIgnore]
    public virtual CSICP_FF103? Ff103 { get; set; }
    [JsonIgnore]
    public virtual CSICP_FF135? Ff136Cdebito { get; set; }
}


