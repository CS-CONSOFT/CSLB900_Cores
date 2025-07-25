using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB007
{
    public class Dto_CreateUpdateBB007
    {
        public string? Bb007Filial { get; set; }

        public int? Bb007Codigo { get; set; }

        [StringLength(60, ErrorMessage = "O campo Responsável deve ter no máximo 60 caracteres.")]
        public string? Bb007Responsavel { get; set; }

        [StringLength(30, ErrorMessage = "O campo Nome Reduzido deve ter no máximo 30 caracteres.")]
        public string? Bb007Nomereduzido { get; set; }

        public int? Bb007Classificacao { get; set; }

        [StringLength(36, ErrorMessage = "O campo Usuário ID deve ter no máximo 36 caracteres.")]
        public string? Bb007UsuarioId { get; set; }

        [StringLength(36, ErrorMessage = "O campo Código Supervisor deve ter no máximo 36 caracteres.")]
        public string? Bb007Codgsupervisor { get; set; }

        [StringLength(36, ErrorMessage = "O campo Código Gerente deve ter no máximo 36 caracteres.")]
        public string? Bb007Codggerente { get; set; }

        public int? Bb007Geracpagar { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo Comissão 1 deve ser maior ou igual a 0.")]
        public decimal? Bb007Coms1 { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo Comissão 2 deve ser maior ou igual a 0.")]
        public decimal? Bb007Coms2 { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo Comissão 3 deve ser maior ou igual a 0.")]
        public decimal? Bb007Coms3 { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo Comissão 4 deve ser maior ou igual a 0.")]
        public decimal? Bb007Coms4 { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo Comissão 5 deve ser maior ou igual a 0.")]
        public decimal? Bb007Coms5 { get; set; }

        public int? Bb007Basecomicms { get; set; }
        public int? Bb007Basecomicmsret { get; set; }
        public int? Bb007Basecomipi { get; set; }
        public int? Bb007Basecomfrete { get; set; }
        public int? Bb007Basecomacrfinan { get; set; }
        public int? Bb007Basecomdespesas { get; set; }
        public int? Bb007Basecomseguro { get; set; }

        [Range(0, 100, ErrorMessage = "O campo Máximo de Desconto deve ser entre 0 e 100.")]
        public decimal? Bb007Maxdescvenda { get; set; }

        public int? Bb007Codgccusto { get; set; }
        public int? Bb007Codgalmox { get; set; }
        public int? Bb007Codgatividade { get; set; }

        [StringLength(20, ErrorMessage = "O campo Senha deve ter no máximo 20 caracteres.")]
        public string? Bb007Senha { get; set; }

        [StringLength(30, ErrorMessage = "O campo Nome Banco deve ter no máximo 30 caracteres.")]
        public string? Bb007Nomebanco { get; set; }

        [StringLength(20, ErrorMessage = "O campo Agência deve ter no máximo 20 caracteres.")]
        public string? Bb007Agencia { get; set; }

        [StringLength(20, ErrorMessage = "O campo Conta deve ter no máximo 20 caracteres.")]
        public string? Bb007Conta { get; set; }

        public string? Bb007Coreregistro { get; set; }
        public int? Bb007Vinculocliente { get; set; }
        public string? Bb007Observacao { get; set; }
        public int? Bb007Nrohandheld { get; set; }
        public string? Bb007Userhandheld { get; set; }
        public string? Bb007Senhahandheld { get; set; }
        public int? Bb007Handheldsuperv { get; set; }
        public string? Bb007Imphandheld { get; set; }
        public string? Bb007Nomeusuario { get; set; }
        public string? Bb031Funcaoid { get; set; }
        public string? Bb032Cargoid { get; set; }
        public string? Bb007Dtadmissao { get; set; }
        public string? Bb007Dtdemissao { get; set; }
        public string? Bb007Codgregiao { get; set; }
        public string? Bb007Faixaautorizacao { get; set; }
        public string? Bb007Ccustoid { get; set; }
        public string? Bb007Almoxid { get; set; }
        //public string? Empresaid { get; set; }
        public bool? Bb007Isactive { get; set; }
        public string? Bb007Contafornid { get; set; }

        [StringLength(11, ErrorMessage = "O campo CPF deve ter no máximo 11 caracteres.")]
        public string? Bb007Cpf { get; set; }

    }
}
