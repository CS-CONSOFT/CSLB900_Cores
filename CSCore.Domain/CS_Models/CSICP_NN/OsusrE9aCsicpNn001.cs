using CSCore.Domain.CS_Models.Staticas.NN;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_NN;

public partial class OsusrE9aCsicpNn001
{
    public int TenantId { get; set; }

    public string Nn001CtacorrenteId { get; set; } = null!;

    public string? Nn001FilialId { get; set; }

    public string? Nn001Descricao { get; set; }

    public int? Nn001Filial { get; set; }

    public int? Nn001CodCcorrente { get; set; }

    public int? Nn001NroBanco { get; set; }

    public int? Nn001Agencia { get; set; }

    public int? Nn001ContaCorrente { get; set; }

    public string? Nn001Dv { get; set; }

    public DateTime? Nn001Dtaberturaconta { get; set; }

    public decimal? Nn001LimiteCredito { get; set; }

    public decimal? Nn001SaldoAtual { get; set; }

    public decimal? Nn001SaldoCompensado { get; set; }

    public decimal? Nn001ChequesEmitidos { get; set; }

    public decimal? Nn001Chequepredatados { get; set; }

    public decimal? Nn001Predatadosdep { get; set; }

    public decimal? Nn001Predatadoscred { get; set; }

    public decimal? Nn001Predatadosdeb { get; set; }

    public bool? Nn001IsActive { get; set; }

    public int? Nn001Tpcontaid { get; set; }

    public bool? Nn001Ishabilitarpermis { get; set; }

    public int? Nn001Usacix { get; set; }

    public string? Nn001Cix { get; set; }

    public int? Nn001Banco { get; set; }

    public string? Nn001Agcobradorid { get; set; }

    public virtual OsusrE9aCsicpNn001Tp? Nn001Tpconta { get; set; }

    public virtual ICollection<OsusrE9aCsicpNn005> OsusrE9aCsicpNn005s { get; set; } = new List<OsusrE9aCsicpNn005>();

    public virtual ICollection<OsusrE9aCsicpNn010> OsusrE9aCsicpNn010Nn001Ctacorrentes { get; set; } = new List<OsusrE9aCsicpNn010>();

    public virtual ICollection<OsusrE9aCsicpNn010> OsusrE9aCsicpNn010Nn001TransfCcorrs { get; set; } = new List<OsusrE9aCsicpNn010>();

    public virtual ICollection<OsusrE9aCsicpNn011> OsusrE9aCsicpNn011s { get; set; } = new List<OsusrE9aCsicpNn011>();

    public virtual ICollection<CSICP_NN015> OsusrE9aCsicpNn015s { get; set; } = new List<CSICP_NN015>();

    public virtual ICollection<OsusrE9aCsicpNn020> OsusrE9aCsicpNn020s { get; set; } = new List<OsusrE9aCsicpNn020>();
}
