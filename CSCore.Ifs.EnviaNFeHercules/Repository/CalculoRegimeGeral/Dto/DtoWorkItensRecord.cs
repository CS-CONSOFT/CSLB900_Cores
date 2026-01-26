namespace CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.Dto
{
    public record class DtoWorkItensRecord
    {
        public int? numero { get; init; }
        public decimal? ncm { get; init; }
        public string? nbs { get; init; }
        public string? cst { get; init; }
        public string? cClassTrib { get; init; }
        public decimal? baseCalculo { get; init; }
        public decimal? quantidade { get; init; }
        public string? unidade { get; init; }
        public ImpostoSeletivoDto? impostoSeletivo { get; init; }
        public TributacaoRegularDto? tributacaoRegular { get; init; }

        public DtoWorkItensRecord() { }

        public DtoWorkItensRecord(
            int? numero,
            decimal? ncm,
            string? nbs,
            string? cst,
            string? cClassTrib,
            decimal? baseCalculo,
            decimal? quantidade,
            string? unidade,
            ImpostoSeletivoDto? impostoSeletivo,
            TributacaoRegularDto? tributacaoRegular
        )
        {
            this.numero = numero;
            this.ncm = ncm;
            this.nbs = nbs;
            this.cst = NormalizeCst(cst);
            this.cClassTrib = NormalizeCClassTrib(cClassTrib);
            this.baseCalculo = NormalizeDecimal(baseCalculo);
            this.quantidade = quantidade;
            this.unidade = unidade;
            this.impostoSeletivo = impostoSeletivo;
            this.tributacaoRegular = tributacaoRegular;
        }

        private static string NormalizeCst(string? value) =>
            (string.IsNullOrWhiteSpace(value) ? "0" : value).PadLeft(3, '0');

        private static string NormalizeCClassTrib(string? value) =>
            (string.IsNullOrWhiteSpace(value) ? "0" : value).PadLeft(6, '0');

#warning DELETAR
        private static decimal? NormalizeDecimal(decimal? value) =>
            value < 0 ? value * (-1) : value;
    };

    public record class ImpostoSeletivoDto
    {
        public string? cst { get; init; }
        public decimal? baseCalculo { get; init; }
        public decimal? quantidade { get; init; }
        public string? unidade { get; init; }
        public decimal? impostoInformado { get; init; }
        public string? cClassTrib { get; init; }

        public ImpostoSeletivoDto() { }

        public ImpostoSeletivoDto(
            string? cst,
            decimal? baseCalculo,
            decimal? quantidade,
            string? unidade,
            decimal? impostoInformado,
            string? cClassTrib
        )
        {
            this.cst = NormalizeCst(cst);
            this.baseCalculo = baseCalculo;
            this.quantidade = quantidade;
            this.unidade = unidade;
            this.impostoInformado = impostoInformado;
            this.cClassTrib = NormalizeCClassTrib(cClassTrib);
        }

        private static string NormalizeCst(string? value) =>
            (value?.ToString() ?? "0").PadLeft(3, '0');

        private static string NormalizeCClassTrib(string? value) =>
            (string.IsNullOrWhiteSpace(value) ? "0" : value).PadLeft(6, '0');
    };

    public record TributacaoRegularDto(
        string? cst,
        string? cClassTrib
    );
}
