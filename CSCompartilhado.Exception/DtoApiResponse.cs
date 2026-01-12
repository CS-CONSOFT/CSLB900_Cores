namespace CSCore.Ex
{
    public class DtoApiResponse<T>
    {
        public bool? Success { get; set; }
        public string? Message { get; set; } = string.Empty;
        public T? Data { get; set; }

        public DtoApiResponsePaginacao? Paginacao { get; set; }

    }

    public class DtoApiResponsePaginacao
    {
        public int PaginaAtual { get; set; }
        public int TamanhoPagina { get; set; }
        public int TotalRegistros { get; set; }
        public int TotalPaginas { get; set; }
        public bool TemPaginaAnterior => PaginaAtual > 1;
        public bool TemProximaPagina => PaginaAtual < TotalPaginas;
    }
}
