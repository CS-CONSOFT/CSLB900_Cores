namespace CSCore.Ifs.AnaliseDeCredito.ServicosExternos.Dto
{
    public class DtoAutenticacaoRequest
    {
        public string username { get; set; } = "";
        public string password { get; set; } = "";
    }

    public class DtoAutenticacaoResponse
    {
        public string token { get; set; } = "";
        public decimal expiresInSeconds { get; set; } = 0;
    }
}
