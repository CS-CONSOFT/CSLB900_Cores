namespace CSBS101.C82Application.Dto.CEP
{
    public class DtoGetCep
    {
        public string UFID { get; set; } = null!;

        public string PAISID { get; set; } = null!;

        public string? NATURALIDADE { get; set; }

        public string? NACIONALIDADE { get; set; }

        public string LOGRADOURO { get; set; } = null!;

        public string CIDADEID { get; set; } = null!;

        public string BAIRRO { get; set; } = null!;

        public string CEP { get; set; } = null!;

        public string LOGABREVIADO { get; set; } = null!;

        public string? UFNOME { get; set; }

        public string? CIDADENOME { get; set; }
    }
}
