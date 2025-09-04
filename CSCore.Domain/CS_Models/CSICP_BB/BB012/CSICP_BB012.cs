
using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.CS_Models.Staticas.AA;
using CSCore.Domain.DELETAR;

namespace CSCore.Domain;

public partial class CSICP_BB012 
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb012Codigo { get; set; }

    public string? Bb012NomeCliente { get; set; }

    public string? Bb012NomeFantasia { get; set; }

    public DateTime? Bb012DataAniversario { get; set; }

    public DateTime? Bb012DataCadastro { get; set; }

    public string? Bb012Telefone { get; set; } = default;

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

    public int Bb012ModrelacaoId { get; set; } = -1;

    public long? Bb012Sequence { get; set; }

    public DateTime? Bb012Dultalteracao { get; set; }

    public string? Bb012Estabcadid { get; set; }

    public string? Bb012Keyacess { get; set; }

    public string? Bb012IdIndicador { get; set; }

    public int? Bb012Countappmcon { get; set; }

    public int? Bb012Oricadastroid { get; set; }

    //csicp_aa143
    public string? bb012_RFEspecial_ID { get; set; }

    //csicp_aa146_TpGov
    public int? bb012_TpGovId { get; set; }

    public CSICP_BB012? Bb012IdIndicadorNavigation { get; set; }

    public CSICP_BB01201? OsusrE9aCsicpBb01201 { get; set; }

    public CSICP_BB01202? Nav_BB01202 { get; set; }
    public CSICP_BB01206? NavBB01206 { get; set; }

    public CSICP_BB01205? OsusrE9aCsicpBb01205 { get; set; }

    public CSICP_Bb012Mrel? BB012_ModeloRelacao { get; set; }
    public CSICP_Bb012Stacta? BB012_StatusConta { get; set; }
    public CSICP_Bb012Tpcta? BB012_TipoConta { get; set; }
    public CSICP_Bb012Gructa? BB012_GrupoConta { get; set; }
    public CSICP_Bb012Clacta? BB012_ClasseConta { get; set; }
    public CSICP_Bb012Sitcta? BB012_SitConta { get; set; }
    public CSICP_Bb012Mcred? BB012_MCred { get; set; }
    public CSICP_BB001? BB012_EstabelecimentoCadastro { get; set; }
    public CSICP_AA143? Nav_AA143 { get; set; }
    public CSICP_AA146_TP_GOV? Nav_AA146_TP_GOV { get; set; }
}
