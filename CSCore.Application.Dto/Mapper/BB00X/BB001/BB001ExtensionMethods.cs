using CSBS101._82Application.Dto.BB00X.BB001;
using CSBS101._82Application.Dto.BB00X.BB001.BB001Cnae;
using CSBS101._82Application.Dto.BB00X.BB001.BB001Images;
using CSBS101._82Application.Dto.BB00X.BB001.BB001Spls;
using CSBS101._82Application.Dto.BB00X.BB001.BB001Xml;
using CSBS101._82Application.Mapper.AA00X.AA028;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB00X.BB001;
using System.ComponentModel.DataAnnotations;


namespace CSBS101._82Application.Mapper.BB00X.BB00X.BB001
{
    public static class BB001ExtensionMethods
    {
        public static Dto_GetBB001 ToDtoGet(this CSICP_BB001 entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "O objeto 'entity' não pode ser nulo.");
            }

            return new Dto_GetBB001
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb001Cor1Hexa = entity.Bb001Cor1Hexa,
                Bb001Cor2Hexa = entity.Bb001Cor2Hexa,
                Bb001IdiomaId = entity.Bb001IdiomaId,
                Bb001Isactive = entity.Bb001Isactive,
                Bb001AutToken = entity.Bb001AutToken,
                Bb001Token = entity.Bb001Token,
                Bb001Usuariosirc = entity.Bb001Usuariosirc,
                Bb001Senhasirc = entity.Bb001Senhasirc,
                Bb001Tenantfiscal = entity.Bb001Tenantfiscal,
                Bb001TokenEsitef = entity.Bb001TokenEsitef,
                Bb001TokenCspix = entity.Bb001TokenCspix,
                Bb001UrlGoogleplay = entity.Bb001UrlGoogleplay,
                Bb001UrlAppstore = entity.Bb001UrlAppstore,
                Bb001Cix = entity.Bb001Cix,
                Bb001ChaveApl = entity.Bb001ChaveApl,
                Bb001Codigoempresa = entity.Bb001Codigoempresa,
                Bb001Razaosocial = entity.Bb001Razaosocial,
                Bb001Endereco = entity.Bb001Endereco,
                Bb001Complemento = entity.Bb001Complemento,
                Bb001Numresidencial = entity.Bb001Numresidencial,
                Bb001Bairro = entity.Bb001Bairro,
                Bb001Cep = entity.Bb001Cep,
                Bb001Cnpj = entity.Bb001Cnpj,
                Bb001Inscestadual = entity.Bb001Inscestadual,
                Bb001Inscjunta = entity.Bb001Inscjunta,
                Bb001Datainscricao = entity.Bb001Datainscricao,
                Bb001Nomefantasia = entity.Bb001Nomefantasia,
                Bb001Telefone = entity.Bb001Telefone,
                Bb001Fax = entity.Bb001Fax,
                Bb001Slogamempresa1 = entity.Bb001Slogamempresa1,
                Bb001Slogamempresa2 = entity.Bb001Slogamempresa2,
                Bb001Email = entity.Bb001Email,
                Bb001Homepage = entity.Bb001Homepage,
                Bb001Ramoempresa = entity.Bb001Ramoempresa,
                Bb002Grupoempresa = entity.Bb002Grupoempresa,
                Bb001Codgclienteaux = entity.Bb001Codgclienteaux,
                Bb001Almoxpadrao = entity.Bb001Almoxpadrao,
                Bb001Almoxtransfer = entity.Bb001Almoxtransfer,
                Bb001Bddistribuida = entity.Bb001Bddistribuida,
                Bb001Cnaefiscal = entity.Bb001Cnaefiscal,
                Bb001Suframaemp = entity.Bb001Suframaemp,
                Bb001Inscmunicipal = entity.Bb001Inscmunicipal,
                Bb001Paisid = entity.Bb001Paisid,
                Cidadeid = entity.Cidadeid,
                Bb001Ufid = entity.Bb001Ufid,
                Bb001Nomeoficial = entity.Bb001Nomeoficial,
                Bb001CpfOficial = entity.Bb001CpfOficial,
                Bb001Nomesubstituto = entity.Bb001Nomesubstituto,
                Bb001Descricaooficial = entity.Bb001Descricaooficial,
                Bb001Capitalmunicipio = entity.Bb001Capitalmunicipio,
                Bb001Codgcartorio = entity.Bb001Codgcartorio,
                NavEnderecamento = new Dto_Enderecamento
                {
                    UF = entity.Bb001Uf,
                    Cidade = entity.Cidade,
                    Pais = entity.Bb001Pais
                },
                NavRamoEmpresa = entity.Bb001RamoempresaNavigation,
                BB001_IsRegimeRegular = entity.BB001_IsRegimeRegular,
            };
        }

        public static Dto_GetBB001_Exibicao ToDtoGetExibicao(this CSICP_BB001 entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "O objeto 'entity' não pode ser nulo.");
            }

            return new Dto_GetBB001_Exibicao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb001Codigoempresa = entity.Bb001Codigoempresa,
                Bb001Razaosocial = entity.Bb001Razaosocial,
                BB001_IsRegimeRegular = entity.BB001_IsRegimeRegular,
            };
        }


        public static Dto_GetBB001 ToDtoGet(this CSICP_BB001 entity,
            List<Dto_GetSplsFromBB001> ListaSimples,
            List<Dto_GetCnaeFromBB001> ListaCnaeFromBB001,
            List<Dto_GetImageFromBB001> ListaImageFromBB001,
            List<Dto_GetXmlFromBB001> ListaXmlFromBB001 )
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "O objeto 'entity' não pode ser nulo.");
            }

            return new Dto_GetBB001
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb001Cor1Hexa = entity.Bb001Cor1Hexa,
                Bb001Cor2Hexa = entity.Bb001Cor2Hexa,
                Bb001IdiomaId = entity.Bb001IdiomaId,
                Bb001Isactive = entity.Bb001Isactive,
                Bb001AutToken = entity.Bb001AutToken,
                Bb001Token = entity.Bb001Token,
                Bb001Usuariosirc = entity.Bb001Usuariosirc,
                Bb001Senhasirc = entity.Bb001Senhasirc,
                Bb001Tenantfiscal = entity.Bb001Tenantfiscal,
                Bb001TokenEsitef = entity.Bb001TokenEsitef,
                Bb001TokenCspix = entity.Bb001TokenCspix,
                Bb001UrlGoogleplay = entity.Bb001UrlGoogleplay,
                Bb001UrlAppstore = entity.Bb001UrlAppstore,
                Bb001Cix = entity.Bb001Cix,
                Bb001ChaveApl = entity.Bb001ChaveApl,
                Bb001Codigoempresa = entity.Bb001Codigoempresa,
                Bb001Razaosocial = entity.Bb001Razaosocial,
                Bb001Endereco = entity.Bb001Endereco,
                Bb001Complemento = entity.Bb001Complemento,
                Bb001Numresidencial = entity.Bb001Numresidencial,
                Bb001Bairro = entity.Bb001Bairro,
                Bb001Cep = entity.Bb001Cep,
                Bb001Cnpj = entity.Bb001Cnpj,
                Bb001Inscestadual = entity.Bb001Inscestadual,
                Bb001Inscjunta = entity.Bb001Inscjunta,
                Bb001Datainscricao = entity.Bb001Datainscricao,
                Bb001Nomefantasia = entity.Bb001Nomefantasia,
                Bb001Telefone = entity.Bb001Telefone,
                Bb001Fax = entity.Bb001Fax,
                Bb001Slogamempresa1 = entity.Bb001Slogamempresa1,
                Bb001Slogamempresa2 = entity.Bb001Slogamempresa2,
                Bb001Email = entity.Bb001Email,
                Bb001Homepage = entity.Bb001Homepage,
                Bb001Ramoempresa = entity.Bb001Ramoempresa,
                Bb002Grupoempresa = entity.Bb002Grupoempresa,
                Bb001Codgclienteaux = entity.Bb001Codgclienteaux,
                Bb001Almoxpadrao = entity.Bb001Almoxpadrao,
                Bb001Almoxtransfer = entity.Bb001Almoxtransfer,
                Bb001Bddistribuida = entity.Bb001Bddistribuida,
                Bb001Cnaefiscal = entity.Bb001Cnaefiscal,
                Bb001Suframaemp = entity.Bb001Suframaemp,
                Bb001Inscmunicipal = entity.Bb001Inscmunicipal,
                Bb001Paisid = entity.Bb001Paisid,
                Cidadeid = entity.Cidadeid,
                Bb001Ufid = entity.Bb001Ufid,
                Bb001Nomeoficial = entity.Bb001Nomeoficial,
                Bb001CpfOficial = entity.Bb001CpfOficial,
                Bb001Nomesubstituto = entity.Bb001Nomesubstituto,
                Bb001Descricaooficial = entity.Bb001Descricaooficial,
                Bb001Capitalmunicipio = entity.Bb001Capitalmunicipio,
                Bb001Codgcartorio = entity.Bb001Codgcartorio,
                NavEnderecamento = new Dto_Enderecamento
                {
                    UF = entity.Bb001Uf,
                    Cidade = entity.Cidade,
                    Pais = entity.Bb001Pais
                },
                NavRamoEmpresa = entity.Bb001RamoempresaNavigation,
                NavListAXML = ListaXmlFromBB001,
                NavListCnaes = ListaCnaeFromBB001,
                NavListImages = ListaImageFromBB001,
                NavListSimples = ListaSimples,
                BB001_IsRegimeRegular = entity.BB001_IsRegimeRegular,
            };
        }

        public static Dto_GetBB001Simples ToDtoGetSimples(this CSICP_BB001 entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "O objeto 'entity' não pode ser nulo.");
            }

            return new Dto_GetBB001Simples
            {
                Id = entity.Id,
                Bb001Codigoempresa = entity.Bb001Codigoempresa,
                Bb001Razaosocial = entity.Bb001Razaosocial,
                Bb001Nomefantasia = entity.Bb001Nomefantasia,
                BB001_IsRegimeRegular = entity.BB001_IsRegimeRegular
            };
        }

        public static Dto_GetBB001ListSimples ToDtoGetBB001ListSimples(this CSICP_BB001 entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "O objeto 'entity' não pode ser nulo.");
            }
            return new Dto_GetBB001ListSimples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb001Codigoempresa = entity.Bb001Codigoempresa,
                Bb001Razaosocial = entity.Bb001Razaosocial,
                Bb001Endereco = entity.Bb001Endereco,
                Bb001Complemento = entity.Bb001Complemento,
                Bb001Numresidencial = entity.Bb001Numresidencial,
                Bb001Bairro = entity.Bb001Bairro,
                Bb001Cep = entity.Bb001Cep,
                Bb001Cnpj = entity.Bb001Cnpj,
                Bb001Inscestadual = entity.Bb001Inscestadual,
                Bb001Inscjunta = entity.Bb001Inscjunta,
                Bb001Datainscricao = entity.Bb001Datainscricao,
                Bb001Nomefantasia = entity.Bb001Nomefantasia,
                Bb001Telefone = entity.Bb001Telefone,
                Bb001Fax = entity.Bb001Fax,
                Bb001Slogamempresa1 = entity.Bb001Slogamempresa1,
                Bb001Slogamempresa2 = entity.Bb001Slogamempresa2,
                Bb001Email = entity.Bb001Email,
                Bb001Homepage = entity.Bb001Homepage,
                Bb001Ramoempresa = entity.Bb001Ramoempresa,
                Bb002Grupoempresa = entity.Bb002Grupoempresa,
                Bb001Codgclienteaux = entity.Bb001Codgclienteaux,
                Bb001Almoxpadrao = entity.Bb001Almoxpadrao,
                Bb001Almoxtransfer = entity.Bb001Almoxtransfer,
                Bb001Bddistribuida = entity.Bb001Bddistribuida,
                Bb001Cnaefiscal = entity.Bb001Cnaefiscal,
                Bb001Suframaemp = entity.Bb001Suframaemp,
                Bb001Inscmunicipal = entity.Bb001Inscmunicipal,
                Bb001Paisid = entity.Bb001Paisid,
                Cidadeid = entity.Cidadeid,
                Bb001Ufid = entity.Bb001Ufid,
                Bb001Nomeoficial = entity.Bb001Nomeoficial,
                Bb001CpfOficial = entity.Bb001CpfOficial,
                Bb001Codgcartorio = entity.Bb001Codgcartorio,
                Bb001Nomesubstituto = entity.Bb001Nomesubstituto,
                Bb001Descricaooficial = entity.Bb001Descricaooficial,
                Bb001Capitalmunicipio = entity.Bb001Capitalmunicipio,
                Bb001Cor1Hexa = entity.Bb001Cor1Hexa,
                Bb001Cor2Hexa = entity.Bb001Cor2Hexa,
                Bb001IdiomaId = entity.Bb001IdiomaId,
                Bb001Isactive = entity.Bb001Isactive,
                Bb001Token = entity.Bb001Token,
                Bb001Usuariosirc = entity.Bb001Usuariosirc,
                Bb001Senhasirc = entity.Bb001Senhasirc,
                Bb001Tenantfiscal = entity.Bb001Tenantfiscal,
                Bb001TokenEsitef = entity.Bb001TokenEsitef,
                Bb001UrlGoogleplay = entity.Bb001UrlGoogleplay,
                Bb001UrlAppstore = entity.Bb001UrlAppstore,
                Bb001Cix = entity.Bb001Cix,
                Bb001ChaveApl = entity.Bb001ChaveApl,
                Bb001AutToken = entity.Bb001AutToken,
                Bb001TokenCspix = entity.Bb001TokenCspix,
                    BB001_IsRegimeRegular = entity.BB001_IsRegimeRegular
            };
        }

        public static CSICP_BB001 ToEntity(this Dto_CreateUpdateBB001 dto, string InConfigID, string InEmpresaID, int InTenantID)
        {
            return new CSICP_BB001
            {
                Bb001Cor1Hexa = dto.Bb001Cor1Hexa,
                Bb001Cor2Hexa = dto.Bb001Cor2Hexa,
                Bb001IdiomaId = dto.Bb001IdiomaId,
                Bb001Isactive = true,
                Bb001AutToken = dto.Bb001AutToken,
                Bb001Token = dto.Bb001Token,
                Bb001Usuariosirc = dto.Bb001Usuariosirc,
                Bb001Senhasirc = dto.Bb001Senhasirc,
                Bb001Tenantfiscal = dto.Bb001Tenantfiscal,
                Bb001TokenEsitef = dto.Bb001TokenEsitef,
                Bb001TokenCspix = dto.Bb001TokenCspix,
                Bb001UrlGoogleplay = dto.Bb001UrlGoogleplay,
                Bb001UrlAppstore = dto.Bb001UrlAppstore,
                Bb001Cix = dto.Bb001Cix,
                Bb001ChaveApl = dto.Bb001ChaveApl,
                Bb001Codigoempresa = dto.Bb001Codigoempresa,
                Bb001Razaosocial = dto.Bb001Razaosocial,
                Bb001Endereco = dto.Bb001Endereco,
                Bb001Complemento = dto.Bb001Complemento,
                Bb001Numresidencial = dto.Bb001Numresidencial,
                Bb001Bairro = dto.Bb001Bairro,
                Bb001Cep = dto.Bb001Cep,
                Bb001Cnpj = dto.Bb001Cnpj,
                Bb001Inscestadual = dto.Bb001Inscestadual,
                Bb001Inscjunta = dto.Bb001Inscjunta,
                Bb001Datainscricao = dto.Bb001Datainscricao,
                Bb001Nomefantasia = dto.Bb001Nomefantasia,
                Bb001Telefone = dto.Bb001Telefone,
                Bb001Fax = dto.Bb001Fax,
                Bb001Slogamempresa1 = dto.Bb001Slogamempresa1,
                Bb001Slogamempresa2 = dto.Bb001Slogamempresa2,
                Bb001Email = dto.Bb001Email,
                Bb001Homepage = dto.Bb001Homepage,
                Bb001Ramoempresa = dto.Bb001Ramoempresa,
                Bb002Grupoempresa = dto.Bb002Grupoempresa,
                Bb001Codgclienteaux = dto.Bb001Codgclienteaux,
                Bb001Almoxpadrao = dto.Bb001Almoxpadrao,
                Bb001Almoxtransfer = dto.Bb001Almoxtransfer,
                Bb001Bddistribuida = dto.Bb001Bddistribuida,
                Bb001Cnaefiscal = dto.Bb001Cnaefiscal,
                Bb001Suframaemp = dto.Bb001Suframaemp,
                Bb001Inscmunicipal = dto.Bb001Inscmunicipal,
                Bb001Paisid = dto.Bb001Paisid,
                Cidadeid = dto.Cidadeid,
                Bb001Ufid = dto.Bb001Ufid,
                Bb001Nomeoficial = dto.Bb001Nomeoficial,
                Bb001CpfOficial = dto.Bb001CpfOficial,
                Bb001Nomesubstituto = dto.Bb001Nomesubstituto,
                Bb001Descricaooficial = dto.Bb001Descricaooficial,
                Bb001Capitalmunicipio = dto.Bb001Capitalmunicipio,
                Bb001Codgcartorio = dto.Bb001Codgcartorio,
                BB001_IsRegimeRegular = dto.BB001_IsRegimeRegular,
                NavBB001Cfgfi = dto.CSICP_BB001Cfgfi?.ToEntity(confgID: InConfigID, emrpesaID: InEmpresaID, tenantID: InTenantID),
            };
        }

        public static DtoGet_BB001paraMDFe ToDtoGetBB001paraNFe(this CSICP_BB001 entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "O objeto 'entity' não pode ser nulo.");
            }
            return new DtoGet_BB001paraMDFe
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb001Codigoempresa = entity.Bb001Codigoempresa,
                Bb001Razaosocial = entity.Bb001Razaosocial,
                Bb001Endereco = entity.Bb001Endereco,
                Bb001Complemento = entity.Bb001Complemento,
                Bb001Numresidencial = entity.Bb001Numresidencial,
                Bb001Bairro = entity.Bb001Bairro,
                Bb001Cep = entity.Bb001Cep,
                Bb001Cnpj = entity.Bb001Cnpj,
                Bb001Inscestadual = entity.Bb001Inscestadual,
                Bb001Inscjunta = entity.Bb001Inscjunta,
                Bb001Datainscricao = entity.Bb001Datainscricao,
                Bb001Nomefantasia = entity.Bb001Nomefantasia,
                Bb001Telefone = entity.Bb001Telefone,
                Bb001Fax = entity.Bb001Fax,
                Bb001Slogamempresa1 = entity.Bb001Slogamempresa1,
                Bb001Slogamempresa2 = entity.Bb001Slogamempresa2,
                Bb001Email = entity.Bb001Email,
                Bb001Homepage = entity.Bb001Homepage,
                Bb001Ramoempresa = entity.Bb001Ramoempresa,
                Bb002Grupoempresa = entity.Bb002Grupoempresa,
                Bb001Codgclienteaux = entity.Bb001Codgclienteaux,
                Bb001Almoxpadrao = entity.Bb001Almoxpadrao,
                Bb001Almoxtransfer = entity.Bb001Almoxtransfer,
                Bb001Bddistribuida = entity.Bb001Bddistribuida,
                Bb001Cnaefiscal = entity.Bb001Cnaefiscal,
                Bb001Suframaemp = entity.Bb001Suframaemp,
                Bb001Inscmunicipal = entity.Bb001Inscmunicipal,
                Bb001Paisid = entity.Bb001Paisid,
                Cidadeid = entity.Cidadeid,
                Bb001Ufid = entity.Bb001Ufid,
                Bb001Nomeoficial = entity.Bb001Nomeoficial,
                Bb001CpfOficial = entity.Bb001CpfOficial,
                Bb001Codgcartorio = entity.Bb001Codgcartorio,
                Bb001Nomesubstituto = entity.Bb001Nomesubstituto,
                Bb001Descricaooficial = entity.Bb001Descricaooficial,
                Bb001Capitalmunicipio = entity.Bb001Capitalmunicipio,
                Bb001Cor1Hexa = entity.Bb001Cor1Hexa,
                Bb001Cor2Hexa = entity.Bb001Cor2Hexa,
                Bb001IdiomaId = entity.Bb001IdiomaId,
                Bb001Isactive = entity.Bb001Isactive,
                Bb001Token = entity.Bb001Token,
                Bb001Usuariosirc = entity.Bb001Usuariosirc,
                Bb001Senhasirc = entity.Bb001Senhasirc,
                Bb001Tenantfiscal = entity.Bb001Tenantfiscal,
                Bb001TokenEsitef = entity.Bb001TokenEsitef,
                Bb001UrlGoogleplay = entity.Bb001UrlGoogleplay,
                Bb001UrlAppstore = entity.Bb001UrlAppstore,
                Bb001Cix = entity.Bb001Cix,
                Bb001ChaveApl = entity.Bb001ChaveApl,
                Bb001AutToken = entity.Bb001AutToken,
                Bb001TokenCspix = entity.Bb001TokenCspix,
                BB001_IsRegimeRegular = entity.BB001_IsRegimeRegular,
                NavAA028CidadebyBB001 = entity.Cidade?.ToDtoGetAA028paraMDFe(),
                NavBB001Cfgfi = entity.NavBB001Cfgfi?.ToDtoGetBB001paraNFe(),
            };
        }

        public static DtoGet_BB001CfgFiparaMDFe ToDtoGetBB001paraNFe(this CSICP_BB001Cfgfi entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "O objeto 'entity' não pode ser nulo.");
            }
            return new DtoGet_BB001CfgFiparaMDFe
            {
                TenantId = entity.TenantId,
                Bb001CfgId = entity.Bb001CfgId,
                Bb001EmpresaId = entity.Bb001EmpresaId,
                Bb001TptributacaoId = entity.Bb001TptributacaoId,
                Bb001PercIcms = entity.Bb001PercIcms,
                Bb001PercCsllBc = entity.Bb001PercCsllBc,
                Bb001PercCsllBcServico = entity.Bb001PercCsllBcServico,
                Bb001PercIrpjBc = entity.Bb001PercIrpjBc,
                Bb001PercIrpjBcServico = entity.Bb001PercIrpjBcServico,
                Bb001NaturezapjId = entity.Bb001NaturezapjId,
                Bb001TpatividadeId = entity.Bb001TpatividadeId,
                Bb001Regimetributarioid = entity.Bb001Regimetributarioid,
                NavAA030byBB001Regimetributario = entity.Bb001Regimetributario,
            };
        }
    }
}






