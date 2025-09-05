using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG032
{
    public CSICP_GG032()
    {
    }

    public CSICP_GG032(
        CSICP_GG032 entidadeOriginal,
        string protocolo,
        string id,
        int tipoInventarioFiscal,
        int statusConcluido)
    {
        TenantId = entidadeOriginal.TenantId;
        Id = id;
        Gg032Filialid = entidadeOriginal.Gg032Filialid;
        Gg032Usuarioid = entidadeOriginal.Gg032Usuarioid;
        Gg032Filial = entidadeOriginal.Gg032Filial;
        Gg032Datamovimento = entidadeOriginal.Gg032Datamovimento;
        Gg032Observacao = "Inventário gerado pela rotina de gerar inventário fiscal";
        Gg032Almoxid = entidadeOriginal.Gg032Almoxid;
        Gg032Codgalmox = entidadeOriginal.Gg032Codgalmox;
        Gg032Totalcusto = entidadeOriginal.Gg032Totalcusto;
        Gg032Totalcreal = entidadeOriginal.Gg032Totalcreal;
        Gg032Totalcmedio = entidadeOriginal.Gg032Totalcmedio;
        Gg032Totalvenda = entidadeOriginal.Gg032Totalvenda;
        Gg032DataHoraBloqueado = entidadeOriginal.Gg032DataHoraBloqueado;
        Gg032DataHoraProcessado = entidadeOriginal.Gg032DataHoraProcessado;
        Gg032QtosPodutos = entidadeOriginal.Gg032QtosPodutos;
        Gg032QtosNaoconform = entidadeOriginal.Gg032QtosNaoconform;
        Gg032QtosNaoinventariado = entidadeOriginal.Gg032QtosNaoinventariado;
        Gg032QtdRegraNconf = entidadeOriginal.Gg032QtdRegraNconf;
        Gg032TipoinventarioId = tipoInventarioFiscal;
        Gg032StatusId = statusConcluido;
        Gg032Protocolnumber = protocolo;
        NavGG032Status = null;
        NavSy001Usuario = null;
        NavGG032Tinventario = null;
    }

    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Gg032Filialid { get; set; }

    public string? Gg032Usuarioid { get; set; }

    public int? Gg032Filial { get; set; }

    public DateTime? Gg032Datamovimento { get; set; }

    public string? Gg032Observacao { get; set; }

    public string? Gg032Almoxid { get; set; }

    public int? Gg032Codgalmox { get; set; }

    public decimal? Gg032Totalcusto { get; set; }

    public decimal? Gg032Totalcreal { get; set; }

    public decimal? Gg032Totalcmedio { get; set; }

    public decimal? Gg032Totalvenda { get; set; }

    public DateTime? Gg032DataHoraBloqueado { get; set; }

    public DateTime? Gg032DataHoraProcessado { get; set; }

    public int? Gg032QtosPodutos { get; set; }

    public int? Gg032QtosNaoconform { get; set; }

    public int? Gg032QtosNaoinventariado { get; set; }

    public decimal? Gg032QtdRegraNconf { get; set; }

    public int? Gg032TipoinventarioId { get; set; }

    public int? Gg032StatusId { get; set; }

    public string? Gg032Protocolnumber { get; set; }

    public OsusrE9aCsicpGg032Stum? NavGG032Status { get; set; }

    public Csicp_Sy001? NavSy001Usuario { get; set; }

    public OsusrE9aCsicpGg032Tpinv? NavGG032Tinventario { get; set; }



}
