



using CSBS101._82Application.Dto.BB00X.BB001.BB001Cnae;
using CSBS101._82Application.Dto.BB00X.BB001.BB001Images;
using CSBS101._82Application.Dto.BB00X.BB001.BB001Spls;
using CSBS101._82Application.Dto.BB00X.BB001.BB001Xml;
using CSCore.Domain;

namespace CSBS101._82Application.Dto.BB00X.BB001
{
    public class Dto_GetBB001
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
        public bool? BB001_IsRegimeRegular { get; set; }

        public CSICP_Statica? NavRamoEmpresa { get; set; } = null!;

        public Dto_Enderecamento? NavEnderecamento { get; set; } = null!;

        public List<Dto_GetCnaeFromBB001>? NavListCnaes { get; set; } = [];
        public List<Dto_GetImageFromBB001>? NavListImages { get; set; } = [];
        public List<Dto_GetSplsFromBB001>? NavListSimples { get; set; } = [];
        public List<Dto_GetXmlFromBB001>? NavListAXML { get; set; } = [];
        public Dto_GetBB001Cfgfis? NavCfgfis { get; set; } = null;

    }

    public class Dto_GetBB001Cfgfis {
        public int TenantId { get; set; }

        public string Bb001CfgId { get; set; } = null!;

        public string? Bb001EmpresaId { get; set; }

        public int? Bb001TptributacaoId { get; set; }

        public decimal? Bb001PercIcms { get; set; }

        public decimal? Bb001PercCsllBc { get; set; }

        public decimal? Bb001PercCsllBcServico { get; set; }

        public decimal? Bb001PercIrpjBc { get; set; }

        public decimal? Bb001PercIrpjBcServico { get; set; }

        public int? Bb001NaturezapjId { get; set; }

        public int? Bb001TpatividadeId { get; set; }

        public int? Bb001Regimetributarioid { get; set; }
        public bool? BB001_IsRegimeRegular { get; set; }
    }   
    public class Dto_GetBB001_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb001Codigoempresa { get; set; } = null!;

        public string? Bb001Razaosocial { get; set; } = null!;
        public bool? BB001_IsRegimeRegular { get; set; }
    }
}
