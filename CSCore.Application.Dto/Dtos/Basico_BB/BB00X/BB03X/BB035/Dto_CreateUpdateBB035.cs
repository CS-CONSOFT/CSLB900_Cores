using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB035
{
    public class Dto_CreateUpdateBB035
    {
        [StringLength(50, ErrorMessage = "O primeiro nome não pode exceder 50 caracteres.")]
        public string? Bb035Primeironome { get; set; }

        [StringLength(50, ErrorMessage = "O sobrenome não pode exceder 50 caracteres.")]
        public string? Bb035Sobrenome { get; set; }

        [StringLength(50, ErrorMessage = "O e-mail não pode exceder 50 caracteres.")]
        public string? Bb035Email { get; set; }

        [StringLength(50, ErrorMessage = "O título não pode exceder 50 caracteres.")]
        public string? Bb035Titulo { get; set; }

        [StringLength(50, ErrorMessage = "O departamento não pode exceder 50 caracteres.")]
        public string? Bb035Departamento { get; set; }


        public DateTime? Bb035DataAniversario { get; set; } = null;

        [StringLength(20, ErrorMessage = "O telefone não pode exceder 20 caracteres.")]
        public string? Bb035Telefone { get; set; }

        [StringLength(20, ErrorMessage = "O outro telefone não pode exceder 20 caracteres.")]
        public string? Bb035Outrotelefone { get; set; }

        [StringLength(20, ErrorMessage = "O celular não pode exceder 20 caracteres.")]
        public string? Bb035Celular { get; set; }

        [StringLength(20, ErrorMessage = "O fax não pode exceder 20 caracteres.")]
        public string? Bb035Fax { get; set; }

        [StringLength(20, ErrorMessage = "O telefone residencial não pode exceder 20 caracteres.")]
        public string? Bb035Telefoneresidencia { get; set; }

        [StringLength(500, ErrorMessage = "A descrição não pode exceder 500 caracteres.")]
        public string? Bb035Descricao { get; set; }

        [StringLength(50, ErrorMessage = "O assistente não pode exceder 50 caracteres.")]
        public string? Bb035Assistente { get; set; }

        [StringLength(20, ErrorMessage = "O telefone do assistente não pode exceder 20 caracteres.")]
        public string? Bb035Telefoneassist { get; set; }

        [StringLength(250, ErrorMessage = "O e-mail secundário não pode exceder 250 caracteres.")]
        public string? Bb035Emailsecundario { get; set; }

        [StringLength(50, ErrorMessage = "O CPF não pode exceder 50 caracteres.")]
        public string? Bb035Cpf { get; set; }

        [Range(0, 99999999999, ErrorMessage = "O RG deve estar no formato numérico válido.")]
        public decimal? Bb035Rg { get; set; }

        [StringLength(20, ErrorMessage = "O órgão expedidor do RG não pode exceder 20 caracteres.")]
        public string? Bb035OrgaoExpedRg { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data de emissão do RG inválida.")]
        public string? Bb035DataEmissaoRg { get; set; }

        public int? Bb035TratamentoId { get; set; }

        public int? Bb035OrigemcontatoId { get; set; }

        public int? Bb035CodgCliente7x { get; set; }

        public short? Bb035SeqCliente7x { get; set; }

    }
}
