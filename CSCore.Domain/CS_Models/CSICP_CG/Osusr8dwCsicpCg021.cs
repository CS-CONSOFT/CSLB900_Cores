using CSCore.Domain.CS_Models.CSICP_NN;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg021
{
    public int TenantId { get; set; }

    public string Cg021Id { get; set; } = null!;

    public string? Cg021FilialId { get; set; }

    public string? Cg021LoteId { get; set; }

    public int? Cg021Nrolancamento { get; set; }

    public int? Cg021Seq { get; set; }

    public string? Cg021ConsolidarFilialId { get; set; }

    public DateTime? Cg021Data { get; set; }

    public string? Cg021ContacontabilId { get; set; }

    public int? Cg021Debcre { get; set; }

    public string? Cg021Nrodocumento { get; set; }

    public decimal? Cg021Valorlancto { get; set; }

    public string? Cg021HistoricoId { get; set; }

    public string? Cg021Historico { get; set; }

    public string? Cg021CtagerencialN2Id { get; set; }

    public string? Cg021CtagerencialN3Id { get; set; }

    public string? Cg021CtagerencialN4Id { get; set; }

    public string? Cg021TiposaldoId { get; set; }

    public int? Cg021Consolidar { get; set; }

    public bool? Cg021Isconsolidado { get; set; }

    public string? Cg021Contacontabil { get; set; }

    public decimal? Cg021Valorlanctoant { get; set; }

    public string? Cg021ProjetoId { get; set; }

    public string? Nn010Id { get; set; }

    public string? Nn015Id { get; set; }

    public long? Cg021Protocolo { get; set; }

    public int? Cg021Sequencia { get; set; }

    public virtual Osusr8dwCsicpCg006? Cg021ContacontabilNavigation { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg021CtagerencialN2 { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg021CtagerencialN3 { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg021CtagerencialN4 { get; set; }

    public virtual Osusr8dwCsicpCg993? Cg021DebcreNavigation { get; set; }

    public virtual Osusr8dwCsicpCg020? Cg021Lote { get; set; }

    public virtual Osusr8dwCsicpCg007? Cg021Projeto { get; set; }

    public virtual Osusr8dwCsicpCg070? Cg021ProtocoloNavigation { get; set; }

    public virtual Osusr8dwCsicpCg008? Cg021Tiposaldo { get; set; }

    public virtual OsusrE9aCsicpNn010? Nn010 { get; set; }

    public virtual CSICP_NN015? Nn015 { get; set; }

    public virtual ICollection<Osusr8dwCsicpCg022> Osusr8dwCsicpCg022s { get; set; } = new List<Osusr8dwCsicpCg022>();

    public virtual ICollection<Osusr8dwCsicpCg074> Osusr8dwCsicpCg074s { get; set; } = new List<Osusr8dwCsicpCg074>();
}
