using System;
using System.Collections.Generic;

namespace CSCore.Domain.DELETAR;

public partial class OsusrE9aCsicpBb012
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb012Codigo { get; set; }

    public string? Bb012NomeCliente { get; set; }

    public string? Bb012NomeFantasia { get; set; }

    public DateTime? Bb012DataAniversario { get; set; }

    public DateTime? Bb012DataCadastro { get; set; }

    public string? Bb012Telefone { get; set; }

    public string? Bb012Faxcelular { get; set; }

    public string? Bb012HomePage { get; set; }

    public string? Bb012Email { get; set; }

    public DateTime? Bb012DataEntradaSit { get; set; }

    public DateTime? Bb012DataSaidaSit { get; set; }

    public string? Bb012Descricao { get; set; }

    public bool? Bb012IsActive { get; set; }

    public int? Bb012TipoContaId { get; set; }

    public int? Bb012GrupocontaId { get; set; }

    public int? Bb012ClassecontaId { get; set; }

    public int? Bb012StatuscontaId { get; set; }

    public int? Bb012SitContaId { get; set; }

    public int? Bb012ModrelacaoId { get; set; }

    public long? Bb012Sequence { get; set; }

    public DateTime? Bb012Dultalteracao { get; set; }

    public string? Bb012Estabcadid { get; set; }

    public string? Bb012Keyacess { get; set; }

    public string? Bb012IdIndicador { get; set; }

    public int? Bb012Countappmcon { get; set; }

    public int? Bb012Oricadastroid { get; set; }

    public string? Bb012LcespecialId { get; set; }

    public int? Bb012Tpgovid { get; set; }

    public string? Bb012RflcespecialId { get; set; }

    public string? Bb012LcespecialIdExclui { get; set; }

    public virtual OsusrE9aCsicpBb012? Bb012IdIndicadorNavigation { get; set; }

    public virtual ICollection<OsusrE9aCsicpBb012> InverseBb012IdIndicadorNavigation { get; set; } = new List<OsusrE9aCsicpBb012>();

    public virtual ICollection<OsusrTeiCsicpCc040> OsusrTeiCsicpCc040s { get; set; } = new List<OsusrTeiCsicpCc040>();

    public virtual ICollection<OsusrTeiCsicpDd040> OsusrTeiCsicpDd040Dd040Avalista { get; set; } = new List<OsusrTeiCsicpDd040>();

    public virtual ICollection<OsusrTeiCsicpDd040> OsusrTeiCsicpDd040Dd040CompConta { get; set; } = new List<OsusrTeiCsicpDd040>();

    public virtual ICollection<OsusrTeiCsicpDd040> OsusrTeiCsicpDd040Dd040Conta { get; set; } = new List<OsusrTeiCsicpDd040>();

    public virtual ICollection<OsusrTeiCsicpDd040> OsusrTeiCsicpDd040Dd040Contareals { get; set; } = new List<OsusrTeiCsicpDd040>();

    public virtual ICollection<OsusrTeiCsicpDd070> OsusrTeiCsicpDd070Dd070Avalista { get; set; } = new List<OsusrTeiCsicpDd070>();

    public virtual ICollection<OsusrTeiCsicpDd070> OsusrTeiCsicpDd070Dd070CompConta { get; set; } = new List<OsusrTeiCsicpDd070>();

    public virtual ICollection<OsusrTeiCsicpDd070> OsusrTeiCsicpDd070Dd070Conta { get; set; } = new List<OsusrTeiCsicpDd070>();

    public virtual ICollection<OsusrTeiCsicpDd070> OsusrTeiCsicpDd070Dd070Contareals { get; set; } = new List<OsusrTeiCsicpDd070>();
}
