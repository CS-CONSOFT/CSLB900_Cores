using CSBS101._82Application.Dto.AA00X;

namespace CSBS101._82Application.Dto.BB00X.BB012.Get
{
    public class Dto_GetBB01206
    {
        public int TenantId { get; set; }

        public string? Id { get; set; } = string.Empty;
        public string? Bb012Id { get; set; }

        public string? Bb012jEnderecoid { get; set; }

        public string? Bb012Logradouro { get; set; }

        public string? Bb012Numero { get; set; }

        public string? Bb012Complemento { get; set; }

        public string? Bb012Codgbairro { get; set; }

        public string? Bb012Bairro { get; set; }

        public string? Bb012CodigoCidade { get; set; }

        public string? Bb012Uf { get; set; }

        public int? Bb012Cep { get; set; }

        public string? Bb012CodigoPais { get; set; }

        public string? Bb012EntregaLogradouro { get; set; }

        public string? Bb012EntregaNumero { get; set; }

        public string? Bb012EntregaComplement { get; set; }

        public string? Bb012EntregaCodgbairro { get; set; }

        public string? Bb012EntregaBairro { get; set; }

        public string? Bb012EntregaCodCidade { get; set; }

        public string? Bb012EntregaUf { get; set; }

        public int? Bb012EntregaCep { get; set; }

        public string? Bb012EntregaPais { get; set; }

        public string? Bb012Perimetro { get; set; }

        public string? Bb012EntregaPerimetro { get; set; }

        public string? Bb012Telefone { get; set; }

        public string? Bb012Celular { get; set; }

        public string? Bb012Email { get; set; }
        public Dto_GetAA028? NavAA028_Cidade { get; set; } = null;
        public Dto_GetAA027? NavAA027_UF { get; set; }
        public Dto_GetAA025? NavAA025_Pais { get; set; }

    }
}
