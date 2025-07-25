using CSBS101._82Application.Dto.BB00X.BB001.BB001Spls;
using CSBS101._82Application.Dto.BB00X.BB001.BB001Xml;
using CSCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB00X.BB001
{
    public class Dto_GetBB001ListSimples
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb001Codigoempresa { get; set; } = null!;

        public string? Bb001Razaosocial { get; set; } = null!;

        public string? Bb001Endereco { get; set; } = null!;

        public string? Bb001Complemento { get; set; } = null!;

        public string? Bb001Numresidencial { get; set; } = null!;

        public string? Bb001Bairro { get; set; } = null!;

        public int? Bb001Cep { get; set; } = null!;

        public string? Bb001Cnpj { get; set; } = null!;

        public string? Bb001Inscestadual { get; set; } = null!;

        public decimal? Bb001Inscjunta { get; set; } = null!;

        public DateTime? Bb001Datainscricao { get; set; } = null!;

        public string? Bb001Nomefantasia { get; set; } = null!;

        public string? Bb001Telefone { get; set; } = null!;

        public string? Bb001Fax { get; set; } = null!;

        public string? Bb001Slogamempresa1 { get; set; } = null!;

        public string? Bb001Slogamempresa2 { get; set; } = null!;

        public string? Bb001Email { get; set; } = null!;

        public string? Bb001Homepage { get; set; } = null!;

        public int? Bb001Ramoempresa { get; set; } = null!;

        public string? Bb002Grupoempresa { get; set; } = null!;

        public int? Bb001Codgclienteaux { get; set; } = null!;

        public int? Bb001Almoxpadrao { get; set; } = null!;

        public int? Bb001Almoxtransfer { get; set; } = null!;

        public int? Bb001Bddistribuida { get; set; } = null!;

        public int? Bb001Cnaefiscal { get; set; } = null!;

        public string? Bb001Suframaemp { get; set; } = null!;

        public string? Bb001Inscmunicipal { get; set; } = null!;

        public string? Bb001Paisid { get; set; } = null!;

        public string? Cidadeid { get; set; } = null!;

        public string? Bb001Ufid { get; set; } = null!;

        public string? Bb001Nomeoficial { get; set; } = null!;

        public decimal? Bb001CpfOficial { get; set; } = null!;

        public decimal? Bb001Codgcartorio { get; set; } = null!;

        public string? Bb001Nomesubstituto { get; set; } = null!;

        public string? Bb001Descricaooficial { get; set; } = null!;

        public int? Bb001Capitalmunicipio { get; set; } = null!;

        public string? Bb001Cor1Hexa { get; set; } = null!;

        public string? Bb001Cor2Hexa { get; set; } = null!;

        public int? Bb001IdiomaId { get; set; } = null!;

        public bool? Bb001Isactive { get; set; } = null!;

        public string? Bb001Token { get; set; } = null!;

        public string? Bb001Usuariosirc { get; set; } = null!;

        public string? Bb001Senhasirc { get; set; } = null!;

        public int? Bb001Tenantfiscal { get; set; } = null!;

        public string? Bb001TokenEsitef { get; set; } = null!;

        public string? Bb001UrlGoogleplay { get; set; } = null!;

        public string? Bb001UrlAppstore { get; set; } = null!;

        public string? Bb001Cix { get; set; } = null!;

        public string? Bb001ChaveApl { get; set; } = null!;

        public string? Bb001AutToken { get; set; } = null!;

        public string? Bb001TokenCspix { get; set; } = null!;

        //public ICollection<Dto_GetXmlFromBB001> NavBB001AXML { get; set; } = new List<Dto_GetXmlFromBB001>();
    }

}
