
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Domain;

public partial class CSICP_BB007
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb007Filial { get; set; }

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

    public CSICP_Bb005? Bb007Ccusto { get; set; }
    public CSICP_BB001? Bb001Empresa { get; set; }

    public CSICP_BB007? Bb007CodggerenteNavigation { get; set; }

    public CSICP_BB007? Bb007CodgsupervisorNavigation { get; set; }
    public CSICP_Bb031? Bb031Funcao { get; set; }

    public CSICP_Bb032? Bb032Cargo { get; set; }

    public CSICP_GG001? CSICP_GG001 { get; set; }


    //public ICollection<CSICP_BB007c> OsusrE9aCsicpBb007cs { get; set; } = new List<CSICP_BB007c>();

    //public ICollection<CSICP_BB007d> OsusrE9aCsicpBb007ds { get; set; } = new List<CSICP_BB007d>();

    //public ICollection<CSICP_Bb010> OsusrE9aCsicpBb010s { get; set; } = new List<CSICP_Bb010>();

    //public ICollection<CSICP_Bb060> OsusrE9aCsicpBb060s { get; set; } = new List<CSICP_Bb060>();
}
