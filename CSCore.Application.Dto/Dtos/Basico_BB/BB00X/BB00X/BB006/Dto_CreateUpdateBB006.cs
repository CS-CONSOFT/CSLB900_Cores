using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB006
{
    public class Dto_CreateUpdateBB006
    {
        [Range(0, int.MaxValue, ErrorMessage = "O campo Bb006Filial deve ser maior ou igual a 0.")]
        public int? Bb006Filial { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O campo Bb006Codgbanco deve ser maior ou igual a 0.")]
        public int? Bb006Codgbanco { get; set; }

        [MaxLength(40, ErrorMessage = "O campo Bb006Banco deve ter no máximo 40 caracteres.")]
        public string? Bb006Banco { get; set; }

        [MaxLength(20, ErrorMessage = "O campo Bb006Nomereduzido deve ter no máximo 20 caracteres.")]
        public string? Bb006Nomereduzido { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo Bb006Nobanco deve ser maior ou igual a 0.")]
        public decimal? Bb006Nobanco { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo Bb006Agencia deve ser maior ou igual a 0.")]
        public decimal? Bb006Agencia { get; set; }

        [MaxLength(2, ErrorMessage = "O campo Bb006AgenciaDv deve ter no máximo 2 caracteres.")]
        public string? Bb006AgenciaDv { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo Bb006Noconta deve ser maior ou igual a 0.")]
        public decimal? Bb006Noconta { get; set; }

        [MaxLength(1, ErrorMessage = "O campo Bb006Contadv deve ter no máximo 1 caractere.")]
        public string? Bb006Contadv { get; set; }

        [MaxLength(1, ErrorMessage = "O campo Bb006Dvagenciacc deve ter no máximo 1 caractere.")]
        public string? Bb006Dvagenciacc { get; set; }

        [MaxLength(60, ErrorMessage = "O campo Bb006Endereco deve ter no máximo 60 caracteres.")]
        public string? Bb006Endereco { get; set; }

        [MaxLength(36, ErrorMessage = "O campo Cidadeid deve ter no máximo 36 caracteres.")]
        public string? Cidadeid { get; set; }

        [MaxLength(20, ErrorMessage = "O campo Bb006Telefone deve ter no máximo 20 caracteres.")]
        public string? Bb006Telefone { get; set; }

        [MaxLength(20, ErrorMessage = "O campo Bb006Fax deve ter no máximo 20 caracteres.")]
        public string? Bb006Fax { get; set; }

        [MaxLength(250, ErrorMessage = "O campo Bb006Email deve ter no máximo 250 caracteres.")]
        public string? Bb006Email { get; set; }

        [MaxLength(60, ErrorMessage = "O campo Bb006Homepage deve ter no máximo 60 caracteres.")]
        public string? Bb006Homepage { get; set; }

        [MaxLength(60, ErrorMessage = "O campo Bb006Contato deve ter no máximo 60 caracteres.")]
        public string? Bb006Contato { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo Bb006Diasretencao deve ser maior ou igual a 0.")]
        public decimal? Bb006Diasretencao { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo Bb006Diasretencaodesc deve ser maior ou igual a 0.")]
        public decimal? Bb006Diasretencaodesc { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo Bb006Saldoatual deve ser maior ou igual a 0.")]
        public decimal? Bb006Saldoatual { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo Bb006Txcobsimples deve ser maior ou igual a 0.")]
        public decimal? Bb006Txcobsimples { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo Bb006Txdesconto deve ser maior ou igual a 0.")]
        public decimal? Bb006Txdesconto { get; set; }

        [MaxLength(20, ErrorMessage = "O campo Bb006Contacontabil deve ter no máximo 20 caracteres.")]
        public string? Bb006Contacontabil { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O campo Bb006Codghistorico deve ser maior ou igual a 0.")]
        public int? Bb006Codghistorico { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo Bb006Limitecredito deve ser maior ou igual a 0.")]
        public decimal? Bb006Limitecredito { get; set; }

        [MaxLength(120, ErrorMessage = "O campo Bb006Msgboleto deve ter no máximo 120 caracteres.")]
        public string? Bb006Msgboleto { get; set; }

        [MaxLength(20, ErrorMessage = "O campo Bb006Codempresabanco deve ter no máximo 20 caracteres.")]
        public string? Bb006Codempresabanco { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O campo Bb006Nroseqremessa deve ser maior ou igual a 0.")]
        public int? Bb006Nroseqremessa { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo Bb006Perccomissao deve ser maior ou igual a 0.")]
        public decimal? Bb006Perccomissao { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O campo Bb006Movtatesouraria deve ser maior ou igual a 0.")]
        public int? Bb006Movtatesouraria { get; set; }

        [MaxLength(30, ErrorMessage = "O campo Bb006Nomeagencia deve ter no máximo 30 caracteres.")]
        public string? Bb006Nomeagencia { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O campo Bb006Classificacao deve ser maior ou igual a 0.")]
        public int? Bb006Classificacao { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O campo Bb006Codgeracaocrec deve ser maior ou igual a 0.")]
        public int? Bb006Codgeracaocrec { get; set; }

        [MaxLength(36, ErrorMessage = "O campo Empresaid deve ter no máximo 36 caracteres.")]
        public string? Empresaid { get; set; }

        [MaxLength(36, ErrorMessage = "O campo Bb006Tipocobrancaid deve ter no máximo 36 caracteres.")]
        public string? Bb006Tipocobrancaid { get; set; }

        [MaxLength(36, ErrorMessage = "O campo Ufid deve ter no máximo 36 caracteres.")]
        public string? Ufid { get; set; }

        [Required(ErrorMessage = "O campo Bb006Isactive é obrigatório.")]
        public bool? Bb006Isactive { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O campo Bb006BancoId deve ser maior ou igual a 0.")]
        public int? Bb006BancoId { get; set; }

        [MaxLength(36, ErrorMessage = "O campo Bb006CodcobradorId deve ter no máximo 36 caracteres.")]
        public string? Bb006CodcobradorId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O campo Bb006ApiId deve ser maior ou igual a 0.")]
        public int? Bb006ApiId { get; set; }
    }
}
