using CSCore.Domain;

namespace CSCore.Application.Dto.Dtos.Consumidor.Profissional
{
    public class DtoGetProfissional
    {
        public string? bb055_Id { get; set; } = string.Empty;
        public string? BB055_Nome { get; set; } = string.Empty;
        public string? BB055_EMail { get; set; } = string.Empty;
        public string? BB055_Telefone { get; set; } = string.Empty;
        public bool? BB055_Is_Active { get; set; } = true;
        public string? BB055_Logradouro { get; set; } = string.Empty;
        public string? BB055_Numero { get; set; } = string.Empty;
        public string? BB055_Complemento { get; set; } = string.Empty;
        public string? BB055_Perimetro { get; set; } = string.Empty;
        public string? BB055_Bairro { get; set; } = string.Empty;
        public string? BB055_CidadeID { get; set; } = string.Empty;
        public string? BB055_UF_ID { get; set; } = string.Empty;
        public int? BB055_CEP { get; set; } = 0;
        public string? BB055_PaisID { get; set; } = string.Empty;
        public string? BB055_NomeContato { get; set; } = string.Empty;
        public string? BB055_Celular_Contato { get; set; } = string.Empty;
        public string? BB055_EMail_Contato { get; set; } = string.Empty;
        public string? BB055_URL_Logo { get; set; } = string.Empty;
        public string? BB055_URL_Avatar { get; set; } = string.Empty;
        public string? BB055_DesEspecialidade { get; set; } = string.Empty;
        public string? BB055_URL_SeloQld { get; set; } = string.Empty;
        public decimal? bb055_RateMedia { get; set; } = 0;
        public string Cidade { get; set; } = string.Empty;
        public string UF { get; set; } = string.Empty;

        public CSICP_Aa027? Nav_CSICP_AA027 { get; set; }
        public CSICP_Aa028? Nav_CSICP_AA028 { get; set; }
    }
}


