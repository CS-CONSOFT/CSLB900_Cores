using CSBS101._82Application.Dto.BB00X.BB001;
using CSCore.Domain;



namespace CSBS101._82Application.Dto.BB00X.BB012.Get
{
    public class Dto_GetBB012
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = null!;

        public int? Bb012Codigo { get; set; }

        public string? Bb012NomeCliente { get; set; }

        public string? Bb012NomeFantasia { get; set; }

        public DateTime? Bb012DataAniversario { get; set; }

        public DateTime? Bb012DataCadastro { get; set; }

        public string? Bb012Telefone { get; set; } = null;

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

        public Dto_GetBB012_Exibicao? NavBb012IdIndicadorNavigation { get; set; }
        public Dto_GetBB01201? NavGetBB1201 { get; set; }
        public Dto_GetBB01202? NavGetBB1202 { get; set; }
        public Dto_GetBB01206? NavGetBB1206 { get; set; }
        public CSICP_Bb012Mrel? NavBB012_ModeloRelacao { get; set; }
        public CSICP_Bb012Stacta? NavBB012_StatusConta { get; set; }
        public CSICP_Bb012Tpcta? NavBB012_TipoConta { get; set; }
        public CSICP_Bb012Gructa? NavBB012_GrupoConta { get; set; }
        public CSICP_Bb012Clacta? NavBB012_ClasseConta { get; set; }
        public CSICP_Bb012Sitcta? NavBB012_SitConta { get; set; }
        public CSICP_Bb012Mcred? NavBB012_MCred { get; set; }
        public Dto_GetBB001_Exibicao? NavBB012_EstabelecimentoCadastro { get; set; }
    }

    public class Dto_GetBB012_Exibicao
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = null!;

        public int? Bb012Codigo { get; set; }

        public string? Bb012NomeCliente { get; set; }

        //public string? Bb012NomeFantasia { get; set; }
    }
}



