using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB028
{
    public class Dto_CreateUpdateBB028
    {
        public int? Bb028Codigo { get; set; }

        [StringLength(60, ErrorMessage = "O nome do responsável não pode exceder 60 caracteres.")]
        public string? Bb028Nomeresponsavel { get; set; }

        [StringLength(30, ErrorMessage = "O nome reduzido não pode exceder 30 caracteres.")]
        public string? Bb028Nomereduzido { get; set; }

        [StringLength(20, ErrorMessage = "O telefone não pode exceder 20 caracteres.")]
        public string? Bb028Telefone { get; set; }

        [StringLength(20, ErrorMessage = "O fax não pode exceder 20 caracteres.")]
        public string? Bb028Fax { get; set; }

        [StringLength(20, ErrorMessage = "O celular não pode exceder 20 caracteres.")]
        public string? Bb028Celular { get; set; }

        [StringLength(80, ErrorMessage = "A homepage não pode exceder 80 caracteres.")]
        public string? Bb028Homepage { get; set; }

        [StringLength(250, ErrorMessage = "O email não pode exceder 250 caracteres.")]
        public string? Bb028Email { get; set; }

        [StringLength(14, ErrorMessage = "O CNPJ não pode exceder 14 caracteres.")]
        public string? Bb028Cnpj { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "A inscrição estadual deve ser um valor válido.")]
        public decimal? Bb028Inscestadual { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "A inscrição municipal deve ser um valor válido.")]
        public decimal? Bb028Inscmunicipal { get; set; }

        [StringLength(1, ErrorMessage = "O campo de geração de pagamento deve ter apenas 1 caractere.")]
        public string? Bb028Geracpagar { get; set; }

        public decimal? Bb028Coms1 { get; set; }
        public decimal? Bb028Coms2 { get; set; }
        public decimal? Bb028Coms3 { get; set; }
        public decimal? Bb028Coms4 { get; set; }
        public decimal? Bb028Coms5 { get; set; }

        [StringLength(30, ErrorMessage = "O nome do banco não pode exceder 30 caracteres.")]
        public string? Bb028Nomebanco { get; set; }

        [StringLength(20, ErrorMessage = "A agência não pode exceder 20 caracteres.")]
        public string? Bb028Agencia { get; set; }

        [StringLength(20, ErrorMessage = "A conta não pode exceder 20 caracteres.")]
        public string? Bb028Conta { get; set; }

        [StringLength(250, ErrorMessage = "A observação não pode exceder 250 caracteres.")]
        public string? Bb028Observacao { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data de nascimento inválida.")]
        public DateTime? Bb028Datanasc { get; set; }

        [StringLength(36, ErrorMessage = "O campo ContaFornid não pode exceder 36 caracteres.")]
        public string? Bb028Contafornid { get; set; }

        public int? Bb028TipoId { get; set; }
    }
}
