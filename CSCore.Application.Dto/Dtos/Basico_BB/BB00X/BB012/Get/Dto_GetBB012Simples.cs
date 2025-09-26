using CSCore.Application.Dto.Dtos.Basico_AA.AA00X;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get;
using CSCore.Domain.CS_Models.Staticas.AA;

namespace CSBS101._82Application.Dto.BB00X.BB012.Get
{
    public class Dto_GetBB012Simples
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
        //csicp_aa143
        public string? bb012_LCEspecial_ID { get; set; }

        //csicp_aa046_TpGov
        public int? bb012_TpGovId { get; set; }

        public Dto_GetBB01206Simples? NavEnderecoSimples { get; set; }

    }
}



