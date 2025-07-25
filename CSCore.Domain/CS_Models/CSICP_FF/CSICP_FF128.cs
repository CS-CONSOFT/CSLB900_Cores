using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF128
{
    public int TenantId { get; set; }

    public string Ff128Id { get; set; } = null!;

    public string? Ff128CobradorId { get; set; }

    public string? Ff128AgcobradorId { get; set; }

    public DateTime? Ff128Dtregistro { get; set; }

    public string? Ff128Tituloid { get; set; }

    public DateTime? Ff128Dtprevisao { get; set; }

    public string? Ff128Mensagem { get; set; }

    public bool? Ff128Isactive { get; set; }

    public string? Ff127Id { get; set; }

    public int? Ff128Diasatrasoent { get; set; }

    public int? Ff128SitcobrancaentId { get; set; }

    public int? Ff128Sitcobranca { get; set; }

    public int? Ff128SituacaosaiId { get; set; }

    public string? Ff128Categoriaid { get; set; }

    public DateTime? Ff128Dtlimitevisita { get; set; }

    public DateTime? Ff128HoraRegistro { get; set; }

    public virtual CSICP_FF127? Ff127 { get; set; }

    public virtual CSICP_FF998? Ff128Sitcobrancaent { get; set; }

    public virtual CSICP_FF102? Ff128Titulo { get; set; }
}
