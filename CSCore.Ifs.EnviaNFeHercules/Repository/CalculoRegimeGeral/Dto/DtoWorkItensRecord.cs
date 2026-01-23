namespace CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.Dto
{
    public record DtoWorkItensRecord(
        int? Numero,
        decimal? Ncm,
        string? Nbs,
        int? Cst,
        int? CClassTrib,
        decimal? BaseCalculo,
        decimal? Quantidade,
        string? Unidade,
        ImpostoSeletivoDto? ImpostoSeletivo,
        TributacaoRegularDto? TributacaoRegular
    );

    public record ImpostoSeletivoDto(
        int? Cst,
        decimal? BaseCalculo,
        decimal? Quantidade,
        string? Unidade,
        decimal? ImpostoInformado
    );

    public record TributacaoRegularDto(
        string? Cst,
        string? CClassTrib
    );
}
