namespace CSCore.Application.Dto.Dtos.Consumidor.Login
{
    public class DtoResponseLogin
    {
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Apelido { get; set; }
        public string? Celular { get; set; }
        public string? email { get; set; }
        public string? IDConta { get; set; }
        public string? ChaveAcesso { get; set; }
        public Endereco? Endereco { get; set; }
    }


    public class Endereco
    {
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Perimetro { get; set; }
        public string? Bairro { get; set; }
        public string? Pais { get; set; }
        public string? UF { get; set; }
        public string? Cidade { get; set; }
        public string? CEP { get; set; }
    }
}
