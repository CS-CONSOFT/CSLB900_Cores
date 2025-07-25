using System.ComponentModel.DataAnnotations;

namespace CSBS101.C82Application.Dto.BB00X.BB00X.BB001
{
    public class Dto_CreateUpdateBB001
    {
        [Required(ErrorMessage = "Bb001Codigoempresa precisa ser passado!")]
        public int Bb001Codigoempresa { get; set; }

        [MaxLength(60, ErrorMessage = "Razão social não pode ter mais que 60 caracteres.")]
        public string? Bb001Razaosocial { get; set; }

        [MaxLength(60, ErrorMessage = "Endereço não pode ter mais que 60 caracteres.")]
        public string? Bb001Endereco { get; set; }

        [MaxLength(255, ErrorMessage = "Complemento não pode ter mais que 255 caracteres.")]
        public string? Bb001Complemento { get; set; }

        [MaxLength(10, ErrorMessage = "Número residencial não pode ter mais que 10 caracteres.")]
        public string? Bb001Numresidencial { get; set; }

        [MaxLength(30, ErrorMessage = "Bairro não pode ter mais que 30 caracteres.")]
        public string? Bb001Bairro { get; set; }

        public int? Bb001Cep { get; set; }

        public string? Bb001Cnpj { get; set; }

        [MaxLength(14, ErrorMessage = "Inscrição estadual não pode ter mais que 14 caracteres.")]
        public string? Bb001Inscestadual { get; set; }

        [Range(0, 999999999999, ErrorMessage = "Inscrição na junta inválida.")]
        public decimal? Bb001Inscjunta { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data de inscrição inválida.")]
        public DateTime? Bb001Datainscricao { get; set; }

        [MaxLength(60, ErrorMessage = "Nome fantasia não pode ter mais que 60 caracteres.")]
        public string? Bb001Nomefantasia { get; set; }

        [MaxLength(20, ErrorMessage = "Telefone não pode ter mais que 20 caracteres.")]
        public string? Bb001Telefone { get; set; }

        [MaxLength(20, ErrorMessage = "Fax não pode ter mais que 20 caracteres.")]
        public string? Bb001Fax { get; set; }

        [MaxLength(60, ErrorMessage = "Slogan da empresa 1 não pode ter mais que 60 caracteres.")]
        public string? Bb001Slogamempresa1 { get; set; }

        [MaxLength(60, ErrorMessage = "Slogan da empresa 2 não pode ter mais que 60 caracteres.")]
        public string? Bb001Slogamempresa2 { get; set; }

        [MaxLength(250, ErrorMessage = "E-mail não pode ter mais que 250 caracteres.")]
        public string? Bb001Email { get; set; }

        [MaxLength(40, ErrorMessage = "Homepage não pode ter mais que 40 caracteres.")]
        public string? Bb001Homepage { get; set; }

        public int? Bb001Ramoempresa { get; set; }

        [MaxLength(36, ErrorMessage = "Grupo da empresa não pode ter mais que 36 caracteres.")]
        public string? Bb002Grupoempresa { get; set; }

        public int? Bb001Codgclienteaux { get; set; }

        public int? Bb001Almoxpadrao { get; set; }

        public int? Bb001Almoxtransfer { get; set; }

        public int? Bb001Bddistribuida { get; set; }

        public int? Bb001Cnaefiscal { get; set; }

        [MaxLength(20, ErrorMessage = "SUFRAMA não pode ter mais que 20 caracteres.")]
        public string? Bb001Suframaemp { get; set; }

        [MaxLength(14, ErrorMessage = "Inscrição municipal não pode ter mais que 14 caracteres.")]
        public string? Bb001Inscmunicipal { get; set; }

        [MaxLength(36, ErrorMessage = "ID do país não pode ter mais que 36 caracteres.")]
        public string? Bb001Paisid { get; set; }

        [MaxLength(36, ErrorMessage = "ID da cidade não pode ter mais que 36 caracteres.")]
        public string? Cidadeid { get; set; }

        [MaxLength(36, ErrorMessage = "UFID não pode ter mais que 36 caracteres.")]
        public string? Bb001Ufid { get; set; }

        [MaxLength(100, ErrorMessage = "Nome oficial não pode ter mais que 100 caracteres.")]
        public string? Bb001Nomeoficial { get; set; }

        [Range(0, 99999999999999, ErrorMessage = "CPF inválido.")]
        public decimal? Bb001CpfOficial { get; set; }

        [Range(0, 999999999, ErrorMessage = "Código do cartório inválido.")]
        public decimal? Bb001Codgcartorio { get; set; }

        [MaxLength(100, ErrorMessage = "Nome do substituto não pode ter mais que 100 caracteres.")]
        public string? Bb001Nomesubstituto { get; set; }

        [MaxLength(50, ErrorMessage = "Descrição oficial não pode ter mais que 50 caracteres.")]
        public string? Bb001Descricaooficial { get; set; }

        public int? Bb001Capitalmunicipio { get; set; }

        [MaxLength(50, ErrorMessage = "Cor hexadecimal não pode ter mais que 50 caracteres.")]
        public string? Bb001Cor1Hexa { get; set; }

        [MaxLength(50, ErrorMessage = "Cor hexadecimal não pode ter mais que 50 caracteres.")]
        public string? Bb001Cor2Hexa { get; set; }

        public int? Bb001IdiomaId { get; set; }

        public bool? Bb001Isactive { get; set; }

        [MaxLength(36, ErrorMessage = "Token não pode ter mais que 36 caracteres.")]
        public string? Bb001Token { get; set; }

        [MaxLength(50, ErrorMessage = "Usuários IRC não pode ter mais que 50 caracteres.")]
        public string? Bb001Usuariosirc { get; set; }

        [MaxLength(50, ErrorMessage = "Senha do IRC não pode ter mais que 50 caracteres.")]
        public string? Bb001Senhasirc { get; set; }

        public int? Bb001Tenantfiscal { get; set; }

        [MaxLength(36, ErrorMessage = "Token do E-Sitef não pode ter mais que 36 caracteres.")]
        public string? Bb001TokenEsitef { get; set; }

        [MaxLength(200, ErrorMessage = "URL da Google Play não pode ter mais que 200 caracteres.")]
        //[Url(ErrorMessage = "URL inválida.")]
        public string? Bb001UrlGoogleplay { get; set; }

        [MaxLength(200, ErrorMessage = "URL da App Store não pode ter mais que 200 caracteres.")]
        //[Url(ErrorMessage = "URL inválida.")]
        public string? Bb001UrlAppstore { get; set; }

        [MaxLength(36, ErrorMessage = "CIX não pode ter mais que 36 caracteres.")]
        public string? Bb001Cix { get; set; }

        [MaxLength(50, ErrorMessage = "Chave APL não pode ter mais que 50 caracteres.")]
        public string? Bb001ChaveApl { get; set; }

        [MaxLength(600, ErrorMessage = "AutToken não pode ter mais que 600 caracteres.")]
        public string? Bb001AutToken { get; set; }

        [MaxLength(36, ErrorMessage = "Token CSPix não pode ter mais que 36 caracteres.")]
        public string? Bb001TokenCspix { get; set; }
    }
}
