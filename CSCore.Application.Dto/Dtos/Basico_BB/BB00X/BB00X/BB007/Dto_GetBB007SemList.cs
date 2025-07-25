using CSBS101._82Application.Dto.BB00X.BB005;
using CSBS101._82Application.Dto.BB00X.BB031;
using CSBS101._82Application.Dto.BB00X.BB032;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;

namespace CSBS101.C82Application.Dto.BB00X.BB00X.BB007
{
    public class Dto_GetBB007SemList
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        //public int? Bb007Filial { get; set; }

        public int? Bb007Codigo { get; set; }

        public string? Bb007Responsavel { get; set; }

        public string? Bb007Nomereduzido { get; set; }

        public int? Bb007Classificacao { get; set; }

        public string? Bb007UsuarioId { get; set; }

        public string? Bb007Codgsupervisor { get; set; }

        public string? Bb007Codggerente { get; set; }

        public int? Bb007Geracpagar { get; set; }

        public decimal? Bb007Coms1 { get; set; }

        public decimal? Bb007Coms2 { get; set; }

        public decimal? Bb007Coms3 { get; set; }

        public decimal? Bb007Coms4 { get; set; }

        public decimal? Bb007Coms5 { get; set; }

        public int? Bb007Basecomicms { get; set; }

        public int? Bb007Basecomicmsret { get; set; }

        public int? Bb007Basecomipi { get; set; }

        public int? Bb007Basecomfrete { get; set; }

        public int? Bb007Basecomacrfinan { get; set; }

        public int? Bb007Basecomdespesas { get; set; }

        public int? Bb007Basecomseguro { get; set; }

        public decimal? Bb007Maxdescvenda { get; set; }

        public int? Bb007Codgccusto { get; set; }

        public int? Bb007Codgalmox { get; set; }

        public int? Bb007Codgatividade { get; set; }

        public string? Bb007Senha { get; set; }

        public string? Bb007Nomebanco { get; set; }

        public string? Bb007Agencia { get; set; }

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

        public DateTime? Bb007Dtadmissao { get; set; }

        public DateTime? Bb007Dtdemissao { get; set; }

        public string? Bb007Codgregiao { get; set; }

        public string? Bb007Faixaautorizacao { get; set; }

        public string? Bb007Ccustoid { get; set; }

        public string? Bb007Almoxid { get; set; }

        public string? Empresaid { get; set; }

        public bool? Bb007Isactive { get; set; }

        public string? Bb007Contafornid { get; set; }

        public string? Bb007Cpf { get; set; }

        public Dto_GetBB005? NavBb007Ccusto { get; set; }
        public Dto_GetBB001Simples? NavBb001Exibicao { get; set; }

        public Dto_GetBB007SemListSimples? NavBb007CodggerenteNavigation { get; set; }

        public Dto_GetBB007SemListSimples? NavBb007CodgsupervisorNavigation { get; set; }

        public Dto_GetBB031? NavBb031Funcao { get; set; }

        public Dto_GetBB032? NavBb032Cargo { get; set; }

    }
}


public class Dto_GetBB007SemListSimples
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb007Codigo { get; set; }

    public string? Bb007Responsavel { get; set; }

    //public string? Bb007Nomereduzido { get; set; }

}
