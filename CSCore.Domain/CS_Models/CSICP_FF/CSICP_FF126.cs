using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF126
{
    public int TenantId { get; set; }

    public string Ff126Id { get; set; } = null!;

    public DateTime? Ff126Dtregistro { get; set; }

    public string Ff126TituloId { get; set; } = string.Empty;

    public int? Ff126Diasatrasoent { get; set; }

    public int? Ff126SitcobrancaEntId { get; set; }

    public int? Ff126Sitcobranca { get; set; }

    public int? Ff126SituacaosaiId { get; set; }

    public string Ff126Mensagem { get; set; } = string.Empty;

    public string? Ff126Propid { get; set; }

    public bool? Ff126Isactive { get; set; }

    public bool? Ff126Ispago { get; set; }

    public DateTime? Ff126Dtpagto { get; set; }

    public bool? Ff126Registrarspc { get; set; }

    public string? Ff126Categoriaid { get; set; }

    public bool? Ff126Iscobrar { get; set; }

    public bool? Ff126Isprimario { get; set; }

    public DateTime? Ff126Horaregistro { get; set; }


    public CSICP_FF102? Ff126Titulo { get; set; }
}
