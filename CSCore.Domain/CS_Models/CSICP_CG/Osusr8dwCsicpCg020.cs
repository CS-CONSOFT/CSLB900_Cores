using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg020
{
    public int TenantId { get; set; }

    public string Cg020Id { get; set; } = null!;

    public string? Cg020FilialId { get; set; }

    public int? Cg020Ano { get; set; }

    public int? Cg020Mes { get; set; }

    public int? Cg020Lote { get; set; }

    public DateTime? Cg020Datainicio { get; set; }

    public DateTime? Cg020Datafinal { get; set; }

    public int? Cg020Ultlancto { get; set; }

    public int? Cg020Qtdlanctos { get; set; }

    public decimal? Cg020Totaldebito { get; set; }

    public decimal? Cg020Totalcredito { get; set; }

    public decimal? Cg020Difdebcre { get; set; }

    public decimal? Cg020Gtdebcre { get; set; }

    public string? Cg020TiposaldoId { get; set; }

    public int? Cg020SituacaoloteId { get; set; }

    public string? Cg020ConsolidadoFilialId { get; set; }

    public int? Cg020UltSeq { get; set; }

    //public virtual Osusr8dwCsicpCg992? Cg020Situacaolote { get; set; }

    //public virtual Osusr8dwCsicpCg008? Cg020Tiposaldo { get; set; }

    //public virtual ICollection<Osusr8dwCsicpCg021> Osusr8dwCsicpCg021s { get; set; } = new List<Osusr8dwCsicpCg021>();

    //public virtual ICollection<Osusr8dwCsicpCg022> Osusr8dwCsicpCg022s { get; set; } = new List<Osusr8dwCsicpCg022>();
}
