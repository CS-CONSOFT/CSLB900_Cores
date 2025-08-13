namespace CSCore.Ex
{
    public class DtoApiResponse<T>
    {
        public string TraceID { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public T Data { get; set; }
        public string? CaminhoEndpoint { get; set; }
        public object? HeadersRequisicao { get; set; }
        
        
    }
}
