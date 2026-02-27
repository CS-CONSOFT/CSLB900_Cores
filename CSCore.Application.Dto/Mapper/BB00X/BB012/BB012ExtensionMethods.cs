using CSBS101._82Application.Dto.BB00X.BB012.CreateUpdate;
using CSBS101._82Application.Dto.BB00X.BB012.Get;
using CSBS101._82Application.Dto.BB00X.BB012.Get.BB012C;
using CSBS101._82Application.Dto.BB00X.BB012.Get.BB012J;
using CSBS101._82Application.Dto.BB00X.BB012.Get.BB012M;
using CSBS101._82Application.Dto.BB00X.BB012.Get.BB012Q;
using CSBS101._82Application.Dto.BB00X.BB012.Get.BB1209;
using CSBS101._82Application.Dto.BB00X.BB012.Get.BB1210;
using CSBS101._82Application.Dto.BB00X.BB012.Get.Contatos;
using CSBS101._82Application.Dto.BB00X.BB012.Get.Membros;
using CSBS101._82Application.Dto.BB00X.BB012.Get.Notas;
using CSBS101._82Application.Dto.BB00X.BB012.Get.RetencaoImpostos;
using CSBS101._82Application.ExtensionsMethods.BB00X;
using CSBS101._82Application.ExtensionsMethods.BB00X.BB03X.BB037;
using CSBS101._82Application.Mapper.AA00X.AA025;
using CSBS101._82Application.Mapper.AA00X.AA027;
using CSBS101._82Application.Mapper.AA00X.AA028;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSBS101.C82Application.Dto.BB00X.BB012.Get;
using CSBS101.C82Application.Dto.BB00X.BB012.Get.BB1207;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;
using Microsoft.Identity.Client;

namespace CSBS101._82Application.Mapper.BB00X.BB012
{

    public static class BB012ExtensionMethods
    {

        public static CSICP_BB012 ToBB0012(this Dto_CreateUpdateBB012Completo dto)
        {
            var entity = new CSICP_BB012
            {
                Bb012Codigo = dto.Bb012!.Bb012Codigo,
                Bb012NomeCliente = dto.Bb012.Bb012NomeCliente,
                Bb012NomeFantasia = dto.Bb012.Bb012NomeFantasia,
                Bb012DataAniversario = dto.Bb012.Bb012DataAniversario?.ConverteStringVaziaParaDataNula(),
                Bb012DataCadastro = dto.Bb012.Bb012DataCadastro?.ConverteStringVaziaParaDataNula(),
                Bb012Telefone = dto.Bb012.Bb012Telefone,
                Bb012Faxcelular = dto.Bb012.Bb012Faxcelular,
                Bb012HomePage = dto.Bb012.Bb012HomePage,
                Bb012Email = dto.Bb012.Bb012Email,
                Bb012DataEntradaSit = dto.Bb012.Bb012DataEntradaSit?.ConverteStringVaziaParaDataNula(),
                Bb012DataSaidaSit = dto.Bb012.Bb012DataSaidaSit?.ConverteStringVaziaParaDataNula(),
                Bb012Descricao = dto.Bb012.Bb012Descricao,
                Bb012IsActive = true,
                Bb012TipoContaId = dto.Bb012.Bb012TipoContaId.ConverteIntNuloParaNulo(),
                Bb012GrupocontaId = dto.Bb012.Bb012GrupocontaId,
                Bb012ClassecontaId = dto.Bb012.Bb012ClassecontaId,
                Bb012StatuscontaId = dto.Bb012.Bb012StatuscontaId,
                Bb012SitContaId = dto.Bb012.Bb012SitContaId,
                Bb012ModrelacaoId = dto.Bb012.Bb012ModrelacaoId ?? 0,
                Bb012Sequence = dto.Bb012.Bb012Sequence,
                Bb012Dultalteracao = dto.Bb012.Bb012Dultalteracao?.ConverteStringVaziaParaDataNula(),
                Bb012Estabcadid = dto.Bb012.Bb012Estabcadid,
                Bb012Keyacess = dto.Bb012.Bb012Keyacess,
                Bb012IdIndicador = dto.Bb012.Bb012IdIndicador,
                Bb012Countappmcon = dto.Bb012.Bb012Countappmcon,
                Bb012Oricadastroid = dto.Bb012.Bb012Oricadastroid,
                bb012_RFEspecial_ID = dto.Bb012.bb012_LCEspecial_ID,
                bb012_TpGovId = dto.Bb012.bb012_TpGovId,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static CSICP_BB01201 ToBB001201(this Dto_CreateUpdateBB012Completo dto)
        {
            var entity = new CSICP_BB01201
            {
                Bb012Zonaid = dto.Bb01201!.Bb012Zonaid,
                Bb012Atividadeid = dto.Bb01201.Bb012Atividadeid,
                Bb012Limitecredito = dto.Bb01201.Bb012Limitecredito,
                Bb012Limcreditosecun = dto.Bb01201.Bb012Limcreditosecun,
                Bb012Limiteccredito = dto.Bb01201.Bb012Limiteccredito,
                Bb012Diavenctocartao = dto.Bb01201.Bb012Diavenctocartao,
                Bb012Contaconvenio = dto.Bb01201.Bb012Contaconvenio,
                Bb012Diaspagtoconv = dto.Bb01201.Bb012Diaspagtoconv,
                Bb012Padraobancoid = dto.Bb01201.Bb012Padraobancoid,
                Bb012Bcoagenciaconta = dto.Bb01201.Bb012Bcoagenciaconta,
                Bb012Revenda = dto.Bb01201.Bb012Revenda,
                Bb012TaxaAdministracaoCon = dto.Bb01201.Bb012TaxaAdministracaoCon,
                Bb012Requisicao = dto.Bb01201.Bb012Requisicao,
                Bb012Contacontabil = dto.Bb01201.Bb012Contacontabil,
                Bb012Historicocontabilid = dto.Bb01201.Bb012Historicocontabilid,
                Bb012Contratocartao = dto.Bb01201.Bb012Contratocartao,
                Bb012Datacontratocartao = dto.Bb01201.Bb012Datacontratocartao?.ConverteStringVaziaParaDataNula(),
                Bb012Dtvalidadecartao = dto.Bb01201.Bb012Dtvalidadecartao?.ConverteStringVaziaParaDataNula(),
                Bb012Modalidadecredcartao = dto.Bb01201.Bb012Modalidadecredcartao,
                Bb012Perclimcredito = dto.Bb01201.Bb012Perclimcredito,
                Bb012Prazoentregafornec = dto.Bb01201.Bb012Prazoentregafornec,
                Bb012Condpagtofornec = dto.Bb01201.Bb012Condpagtofornec,
                Bb012Natoperacaoid = dto.Bb01201.Bb012Natoperacaoid,
                Bb012Condpagtoid = dto.Bb01201.Bb012Condpagtoid,
                Bb012Textonotaid = dto.Bb01201.Bb012Textonotaid,
                Bb012GrauRisco = dto.Bb01201.Bb012GrauRisco,
                Bb012ClasseCredito = dto.Bb01201.Bb012ClasseCredito,
                Bb012Dtvalidcadastro = dto.Bb01201.Bb012Dtvalidcadastro?.ConverteStringVaziaParaDataNula(),
                Bb012PercIcms = dto.Bb01201.Bb012PercIcms,
                Bb012Codgcategoria = dto.Bb01201.Bb012Codgcategoria,
                Bb012Categoriaid = dto.Bb01201.Bb012Categoriaid,
                Bb012Limitecredparcela = dto.Bb01201.Bb012Limitecredparcela,
                Bb012NumUltFatura = dto.Bb01201.Bb012NumUltFatura,
                Bb012Totcompracarnet = dto.Bb01201.Bb012Totcompracarnet,
                Bb012ValorEntrada = dto.Bb01201.Bb012ValorEntrada,
                Bb012MaiorCompra = dto.Bb01201.Bb012MaiorCompra,
                Bb012MenorCompra = dto.Bb01201.Bb012MenorCompra,
                Bb012Totdiasatraso = dto.Bb01201.Bb012Totdiasatraso,
                Bb012MaiorAtraso = dto.Bb01201.Bb012MaiorAtraso,
                Bb012MenorAtraso = dto.Bb01201.Bb012MenorAtraso,
                Bb012Mediadeatraso = dto.Bb01201.Bb012Mediadeatraso,
                Bb012Maiorsaldo = dto.Bb01201.Bb012Maiorsaldo,
                Bb012Numcompras = dto.Bb01201.Bb012Numcompras,
                Bb012Dtprimcompra = dto.Bb01201.Bb012Dtprimcompra?.ConverteStringVaziaParaDataNula(),
                Bb012Dtultcompra = dto.Bb01201.Bb012Dtultcompra?.ConverteStringVaziaParaDataNula(),
                Bb012Vlrmaiorpagto = dto.Bb01201.Bb012Vlrmaiorpagto,
                Bb012Numpagtodia = dto.Bb01201.Bb012Numpagtodia,
                Bb012Numpagtoatraso = dto.Bb01201.Bb012Numpagtoatraso,
                Bb012Saldodevedor = dto.Bb01201.Bb012Saldodevedor,
                Bb012Saldopedido = dto.Bb01201.Bb012Saldopedido,
                Bb012Qtdtitprotestado = dto.Bb01201.Bb012Qtdtitprotestado,
                Bb012Ultprotesto = dto.Bb01201.Bb012Ultprotesto?.ConverteStringVaziaParaDataNula(),
                Bb012Qtdchqdevolvido = dto.Bb01201.Bb012Qtdchqdevolvido,
                Bb012Ultchqdevolvido = dto.Bb01201.Bb012Ultchqdevolvido?.ConverteStringVaziaParaDataNula(),
                Bb012ConvenioId = dto.Bb01201.Bb012ConvenioId,
                Bb012TipogeracaoId = dto.Bb01201.Bb012TipogeracaoId,
                Bb012SitespecialId = dto.Bb01201.Bb012SitespecialId,
                Bb012Entmtgrotaid = dto.Bb01201.Bb012Entmtgrotaid,
                Bb012Vendarotaid = dto.Bb01201.Bb012Vendarotaid,
                Bb012Diavenctoid = dto.Bb01201.Bb012Diavenctoid,
                Bb012Codgbcodebconta = dto.Bb01201.Bb012Codgbcodebconta,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static CSICP_BB01202 ToBB001202(this Dto_CreateUpdateBB012Completo dto)
        {
            var entity = new CSICP_BB01202
            {
                Bb012Cnpj = dto.Bb01202!.Bb012Cnpj,
                Bb012Inscestadual = dto.Bb01202.Bb012Inscestadual,
                Bb012Suframa = dto.Bb01202.Bb012Suframa,
                Bb012Regsuframavalido = dto.Bb01202.Bb012Regsuframavalido,
                Bb012Regjuntacomercial = dto.Bb01202.Bb012Regjuntacomercial,
                Bb012Dataregjunta = dto.Bb01202.Bb012Dataregjunta?.ConverteStringVaziaParaDataNula(),
                Bb012Patrimonio = dto.Bb01202.Bb012Patrimonio,
                Bb012CapitalSocial = dto.Bb01202.Bb012CapitalSocial,
                Bb012Cpf = dto.Bb01202.Bb012Cpf,
                Bb012Rg = dto.Bb01202.Bb012Rg,
                Bb012Complementorg = dto.Bb01202.Bb012Complementorg,
                Bb012Emissaorg = dto.Bb01202.Bb012Emissaorg?.ConverteStringVaziaParaDataNula(),
                Bb012Pis = dto.Bb01202.Bb012Pis,
                Bb012Residedesde = dto.Bb01202.Bb012Residedesde?.ConverteStringVaziaParaDataNula(),
                Bb012Nrodependentes = dto.Bb01202.Bb012Nrodependentes,
                Bb012Empadmissao = dto.Bb01202.Bb012Empadmissao?.ConverteStringVaziaParaDataNula(),
                Bb012EmpProfissao = dto.Bb01202.Bb012EmpProfissao,
                Bb012Valorremuneracao = dto.Bb01202.Bb012Valorremuneracao,
                Bb012Outrosrendimentos = dto.Bb01202.Bb012Outrosrendimentos,
                Bb012Origemoutrosrend = dto.Bb01202.Bb012Origemoutrosrend,
                Bb012InscEstSniId = dto.Bb01202.Bb012InscEstSniId,
                Bb012SexoId = dto.Bb01202.Bb012SexoId,
                Bb012EstadocivilId = dto.Bb01202.Bb012EstadocivilId,
                Bb012TipodomicilioId = dto.Bb01202.Bb012TipodomicilioId,
                Bb012Compresid01Id = dto.Bb01202.Bb012Compresid01Id,
                Bb012Compresid02Id = dto.Bb01202.Bb012Compresid02Id,
                Bb012GescolaridadeId = dto.Bb01202.Bb012GescolaridadeId,
                Bb012OcupacaoId = dto.Bb01202.Bb012OcupacaoId,
                Bb012NaturaldeId = dto.Bb01202.Bb012NaturaldeId,
                Bb012TptributacaoId = dto.Bb01202.Bb012TptributacaoId,
                Bb012IdentEstrangeiro = dto.Bb01202.Bb012IdentEstrangeiro,
                Bb012Empresa = dto.Bb01202.Bb012Empresa,
                Bb012EmpEndereco = dto.Bb01202.Bb012EmpEndereco,
                Bb012EmpGrupoId = dto.Bb01202.Bb012EmpGrupoId,
                Bb012Motdesoneracaoid = dto.Bb01202.Bb012Motdesoneracaoid,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static CSICP_BB01206 ToBB1206(this Dto_CreateUpdateBB012Completo dto)
        {
            var entity = new CSICP_BB01206
            {
                Bb012jEnderecoid = null,
                Bb012Logradouro = dto.Bb01206.Bb012Logradouro,
                Bb012Numero = dto.Bb01206.Bb012Numero,
                Bb012Complemento = dto.Bb01206.Bb012Complemento,
                Bb012Bairro = dto.Bb01206.Bb012Bairro,
                Bb012CodigoCidade = dto.Bb01206.Bb012CodigoCidade,
                Bb012Uf = dto.Bb01206.Bb012Uf,
                Bb012Cep = dto.Bb01206.Bb012Cep,
                Bb012CodigoPais = dto.Bb01206.Bb012CodigoPais,
                Bb012EntregaLogradouro = dto.Bb01206.Bb012EntregaLogradouro,
                Bb012EntregaNumero = dto.Bb01206.Bb012EntregaNumero,
                Bb012EntregaComplement = dto.Bb01206.Bb012EntregaComplement,
                Bb012EntregaCodgbairro = dto.Bb01206.Bb012EntregaCodgbairro,
                Bb012EntregaBairro = dto.Bb01206.Bb012EntregaBairro,
                Bb012EntregaCodCidade = dto.Bb01206.Bb012EntregaCodCidade,
                Bb012EntregaUf = dto.Bb01206.Bb012EntregaUf,
                Bb012EntregaCep = dto.Bb01206.Bb012EntregaCep,
                Bb012EntregaPais = dto.Bb01206.Bb012EntregaPais,
                Bb012Perimetro = dto.Bb01206.Bb012Perimetro,
                Bb012EntregaPerimetro = dto.Bb01206.Bb012EntregaPerimetro,
                Bb012Telefone = dto.Bb01206.Bb012Telefone,
                Bb012Celular = dto.Bb01206.Bb012Celular,
                Bb012Email = dto.Bb01206.Bb012Email,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
        public static CSICP_BB01206 ToEntity(this Dto_GetBB01206 dto)
        {
            return new CSICP_BB01206
            {
                TenantId = dto.TenantId,
                Id = dto.Id,
                Bb012Id = dto.Bb012Id,
                Bb012jEnderecoid = dto.Bb012jEnderecoid,
                Bb012Logradouro = dto.Bb012Logradouro,
                Bb012Numero = dto.Bb012Numero,
                Bb012Complemento = dto.Bb012Complemento,
                Bb012Bairro = dto.Bb012Bairro,
                Bb012CodigoCidade = dto.Bb012CodigoCidade,
                Bb012Uf = dto.Bb012Uf,
                Bb012Cep = dto.Bb012Cep,
                Bb012CodigoPais = dto.Bb012CodigoPais,
                Bb012Telefone = dto.Bb012Telefone,
                Bb012Celular = dto.Bb012Celular,
                Bb012Email = dto.Bb012Email,
            };
        }

        public static Dto_GetBB012 ToDtoBB012(this CSICP_BB012 entity)
        {
            return new Dto_GetBB012
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Codigo = entity.Bb012Codigo,
                Bb012NomeCliente = entity.Bb012NomeCliente,
                Bb012NomeFantasia = entity.Bb012NomeFantasia,
                Bb012DataAniversario = entity.Bb012DataAniversario,
                Bb012DataCadastro = entity.Bb012DataCadastro,
                Bb012Telefone = entity.Bb012Telefone,
                Bb012Faxcelular = entity.Bb012Faxcelular,
                Bb012HomePage = entity.Bb012HomePage,
                Bb012Email = entity.Bb012Email,
                Bb012DataEntradaSit = entity.Bb012DataEntradaSit,
                Bb012DataSaidaSit = entity.Bb012DataSaidaSit,
                Bb012Descricao = entity.Bb012Descricao,
                Bb012IsActive = entity.Bb012IsActive,
                Bb012TipoContaId = entity.Bb012TipoContaId,
                Bb012GrupocontaId = entity.Bb012GrupocontaId,
                Bb012ClassecontaId = entity.Bb012ClassecontaId,
                Bb012StatuscontaId = entity.Bb012StatuscontaId,
                Bb012SitContaId = entity.Bb012SitContaId,
                Bb012ModrelacaoId = entity.Bb012ModrelacaoId,
                Bb012Sequence = entity.Bb012Sequence,
                Bb012Dultalteracao = entity.Bb012Dultalteracao,
                Bb012Estabcadid = entity.Bb012Estabcadid,
                Bb012Keyacess = entity.Bb012Keyacess,
                Bb012IdIndicador = entity.Bb012IdIndicador,
                Bb012Countappmcon = entity.Bb012Countappmcon,
                Bb012Oricadastroid = entity.Bb012Oricadastroid,
                NavGetBB1201 = entity.OsusrE9aCsicpBb01201?.ToDtoBB01201(),
                NavGetBB1202 = entity.Nav_BB01202?.ToDtoBB01202(),
                NavGetBB1206 = entity.NavBB01206?.ToDtoBB01206(),
                NavBb012IdIndicadorNavigation = entity.Bb012IdIndicadorNavigation?.ToDtoBB012_Exibicao(),
                NavBB012_ModeloRelacao = entity.BB012_ModeloRelacao,
                NavBB012_StatusConta = entity.BB012_StatusConta,
                NavBB012_TipoConta = entity.BB012_TipoConta,
                NavBB012_GrupoConta = entity.BB012_GrupoConta,
                NavBB012_ClasseConta = entity.BB012_ClasseConta,
                NavBB012_SitConta = entity.BB012_SitConta,
                NavBB012_MCred = entity.BB012_MCred,
                NavBB012_EstabelecimentoCadastro = entity.BB012_EstabelecimentoCadastro?.ToDtoGetExibicao(),
                bb012_LCEspecial_ID = entity.bb012_RFEspecial_ID,
                bb012_TpGovId = entity.bb012_TpGovId,
                NavAA043 = new CSCore.Application.Dto.Dtos.Basico_AA.AA00X.DtoGetAA043
                {
                    TenantId = entity.TenantId,
                    Id = entity?.Nav_AA143?.Id ?? string.Empty,
                    Aa043Artigo = entity?.Nav_AA143?.Aa043Artigo ?? string.Empty,
                    Aa043LcRedacao = entity?.Nav_AA143?.Aa043LcRedacao ?? string.Empty,
                    Aa043Ec = entity?.Nav_AA143?.Aa043Ec ?? string.Empty,
                },
                Nav_AA046_TP_GOV = entity?.Nav_AA146_TP_GOV,
            };
        }

        public static Dto_GetBB012_Exibicao ToDtoBB012_Exibicao(this CSICP_BB012 entity)
        {
            return new Dto_GetBB012_Exibicao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Codigo = entity.Bb012Codigo,
                Bb012NomeCliente = entity.Bb012NomeCliente,
                bb012_LCEspecial_ID = entity.bb012_RFEspecial_ID,
                bb012_TpGovId = entity.bb012_TpGovId,
                NavAA043 = new CSCore.Application.Dto.Dtos.Basico_AA.AA00X.DtoGetAA043
                {
                    TenantId = entity.TenantId,
                    Id = entity?.Nav_AA143?.Id ?? string.Empty,
                    Aa043Artigo = entity?.Nav_AA143?.Aa043Artigo ?? string.Empty,
                    Aa043LcRedacao = entity?.Nav_AA143?.Aa043LcRedacao ?? string.Empty,
                    Aa043Ec = entity?.Nav_AA143?.Aa043Ec ?? string.Empty,
                },
                Nav_AA046_TP_GOV = entity?.Nav_AA146_TP_GOV,
            };
        }




        public static Dto_GetBB012Simples ToDtoBB012Simples(this CSICP_BB012 entity)
        {
            return new Dto_GetBB012Simples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Codigo = entity.Bb012Codigo,
                Bb012NomeCliente = entity.Bb012NomeCliente,
                Bb012NomeFantasia = entity.Bb012NomeFantasia,
                Bb012DataAniversario = entity.Bb012DataAniversario,
                Bb012DataCadastro = entity.Bb012DataCadastro,
                Bb012Telefone = entity.Bb012Telefone,
                Bb012Faxcelular = entity.Bb012Faxcelular,
                Bb012HomePage = entity.Bb012HomePage,
                Bb012Email = entity.Bb012Email,
                Bb012DataEntradaSit = entity.Bb012DataEntradaSit,
                Bb012DataSaidaSit = entity.Bb012DataSaidaSit,
                Bb012Descricao = entity.Bb012Descricao,
                Bb012IsActive = entity.Bb012IsActive,
                Bb012TipoContaId = entity.Bb012TipoContaId,
                Bb012GrupocontaId = entity.Bb012GrupocontaId,
                Bb012ClassecontaId = entity.Bb012ClassecontaId,
                Bb012StatuscontaId = entity.Bb012StatuscontaId,
                Bb012SitContaId = entity.Bb012SitContaId,
                Bb012ModrelacaoId = entity.Bb012ModrelacaoId,
                Bb012Sequence = entity.Bb012Sequence,
                Bb012Dultalteracao = entity.Bb012Dultalteracao,
                Bb012Estabcadid = entity.Bb012Estabcadid,
                Bb012Keyacess = entity.Bb012Keyacess,
                Bb012IdIndicador = entity.Bb012IdIndicador,
                Bb012Countappmcon = entity.Bb012Countappmcon,
                Bb012Oricadastroid = entity.Bb012Oricadastroid,
                bb012_LCEspecial_ID = entity.bb012_RFEspecial_ID,
                bb012_TpGovId = entity.bb012_TpGovId,
                NavEnderecoSimples = entity.NavBB01206?.ToDtoBB01206Simples(),
            };
        }

        public static Dto_GetBB012_Exibicao ToDtoBB012Exibicao(this CSICP_BB012 entity)
        {
            return new Dto_GetBB012_Exibicao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Codigo = entity.Bb012Codigo,
                Bb012NomeCliente = entity.Bb012NomeCliente,
                bb012_LCEspecial_ID = entity.bb012_RFEspecial_ID,
                bb012_TpGovId = entity.bb012_TpGovId,
                NavAA043 = new CSCore.Application.Dto.Dtos.Basico_AA.AA00X.DtoGetAA043
                {
                    TenantId = entity.TenantId,
                    Id = entity?.Nav_AA143?.Id ?? string.Empty,
                    Aa043Artigo = entity?.Nav_AA143?.Aa043Artigo ?? string.Empty,
                    Aa043LcRedacao = entity?.Nav_AA143?.Aa043LcRedacao ?? string.Empty,
                    Aa043Ec = entity?.Nav_AA143?.Aa043Ec ?? string.Empty,
                },
                Nav_AA046_TP_GOV = entity?.Nav_AA146_TP_GOV,

            };
        }

        public static Dto_GetBB012 ToDtoBB012Convenio(this CSICP_BB012 entity)
        {
            return new Dto_GetBB012
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Codigo = entity.Bb012Codigo,
                Bb012NomeCliente = entity.Bb012NomeCliente,
                Bb012NomeFantasia = entity.Bb012NomeFantasia,
                Bb012DataAniversario = entity.Bb012DataAniversario,
                Bb012DataCadastro = entity.Bb012DataCadastro,
                Bb012Telefone = entity.Bb012Telefone,
                Bb012Faxcelular = entity.Bb012Faxcelular,
                Bb012HomePage = entity.Bb012HomePage,
                Bb012Email = entity.Bb012Email,
                Bb012DataEntradaSit = entity.Bb012DataEntradaSit,
                Bb012DataSaidaSit = entity.Bb012DataSaidaSit,
                Bb012Descricao = entity.Bb012Descricao,
                Bb012IsActive = entity.Bb012IsActive,
                Bb012TipoContaId = entity.Bb012TipoContaId,
                Bb012GrupocontaId = entity.Bb012GrupocontaId,
                Bb012ClassecontaId = entity.Bb012ClassecontaId,
                Bb012StatuscontaId = entity.Bb012StatuscontaId,
                Bb012SitContaId = entity.Bb012SitContaId,
                Bb012ModrelacaoId = entity.Bb012ModrelacaoId,
                Bb012Sequence = entity.Bb012Sequence,
                Bb012Dultalteracao = entity.Bb012Dultalteracao,
                Bb012Estabcadid = entity.Bb012Estabcadid,
                Bb012Keyacess = entity.Bb012Keyacess,
                Bb012IdIndicador = entity.Bb012IdIndicador,
                Bb012Countappmcon = entity.Bb012Countappmcon,
                Bb012Oricadastroid = entity.Bb012Oricadastroid,
                NavGetBB1201 = entity.OsusrE9aCsicpBb01201?.ToDtoBB01201(),
                NavGetBB1202 = entity.Nav_BB01202?.ToDtoBB01202(),
                NavGetBB1206 = entity.NavBB01206?.ToDtoBB01206(),
                NavBb012IdIndicadorNavigation = entity.Bb012IdIndicadorNavigation?.ToDtoBB012_Exibicao(),
                NavBB012_ModeloRelacao = entity.BB012_ModeloRelacao,
                NavBB012_StatusConta = entity.BB012_StatusConta,
                NavBB012_TipoConta = entity.BB012_TipoConta,
                NavBB012_GrupoConta = entity.BB012_GrupoConta,
                NavBB012_ClasseConta = entity.BB012_ClasseConta,
                NavBB012_SitConta = entity.BB012_SitConta,
                NavBB012_MCred = entity.BB012_MCred,
                NavBB012_EstabelecimentoCadastro = entity.BB012_EstabelecimentoCadastro?.ToDtoGetExibicao(),
                bb012_LCEspecial_ID = entity.bb012_RFEspecial_ID,
                bb012_TpGovId = entity.bb012_TpGovId,
                NavAA043 = new CSCore.Application.Dto.Dtos.Basico_AA.AA00X.DtoGetAA043
                {
                    TenantId = entity.TenantId,
                    Id = entity?.Nav_AA143?.Id ?? string.Empty,
                    Aa043Artigo = entity?.Nav_AA143?.Aa043Artigo ?? string.Empty,
                    Aa043LcRedacao = entity?.Nav_AA143?.Aa043LcRedacao ?? string.Empty,
                    Aa043Ec = entity?.Nav_AA143?.Aa043Ec ?? string.Empty,
                },
                Nav_AA046_TP_GOV = entity?.Nav_AA146_TP_GOV,
            };
        }



        public static Dto_GetBB012Completo ToDtoGetBB012Completo(this CSICP_BB012 entity)
        {
            return new Dto_GetBB012Completo
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Codigo = entity.Bb012Codigo,
                Bb012NomeCliente = entity.Bb012NomeCliente,
                Bb012NomeFantasia = entity.Bb012NomeFantasia,
                Bb012DataAniversario = entity.Bb012DataAniversario,
                Bb012DataCadastro = entity.Bb012DataCadastro,
                Bb012Telefone = entity.Bb012Telefone,
                Bb012Faxcelular = entity.Bb012Faxcelular,
                Bb012HomePage = entity.Bb012HomePage,
                Bb012Email = entity.Bb012Email,
                Bb012DataEntradaSit = entity.Bb012DataEntradaSit,
                Bb012DataSaidaSit = entity.Bb012DataSaidaSit,
                Bb012Descricao = entity.Bb012Descricao,
                Bb012IsActive = entity.Bb012IsActive,
                Bb012TipoContaId = entity.Bb012TipoContaId,
                Bb012GrupocontaId = entity.Bb012GrupocontaId,
                Bb012ClassecontaId = entity.Bb012ClassecontaId,
                Bb012StatuscontaId = entity.Bb012StatuscontaId,
                Bb012SitContaId = entity.Bb012SitContaId,
                Bb012ModrelacaoId = entity.Bb012ModrelacaoId,
                Bb012Sequence = entity.Bb012Sequence,
                Bb012Dultalteracao = entity.Bb012Dultalteracao,
                Bb012Estabcadid = entity.Bb012Estabcadid,
                Bb012Keyacess = entity.Bb012Keyacess,
                Bb012IdIndicador = entity.Bb012IdIndicador,
                Bb012Countappmcon = entity.Bb012Countappmcon,
                Bb012Oricadastroid = entity.Bb012Oricadastroid,
                NavGetBB1201 = entity.OsusrE9aCsicpBb01201?.ToDtoBB01201(),
                NavGetBB1202 = entity.Nav_BB01202?.ToDtoBB01202(),
                NavGetBB1206 = entity.NavBB01206?.ToDtoBB01206(),
                //NavBb012IdIndicadorNavigation = entity.Bb012IdIndicadorNavigation?.ToDtoBB012(),
                NavBB012_ModeloRelacao = entity.BB012_ModeloRelacao,
                NavBB012_StatusConta = entity.BB012_StatusConta,
                NavBB012_TipoConta = entity.BB012_TipoConta,
                NavBB012_GrupoConta = entity.BB012_GrupoConta,
                NavBB012_ClasseConta = entity.BB012_ClasseConta,
                NavBB012_SitConta = entity.BB012_SitConta,
                NavBB012_MCred = entity.BB012_MCred,
                NavBB012_EstabelecimentoCadastro = entity.BB012_EstabelecimentoCadastro?.ToDtoGetExibicao(),
                bb012_LCEspecial_ID = entity.bb012_RFEspecial_ID,
                bb012_TpGovId = entity.bb012_TpGovId,
                NavAA043 = new CSCore.Application.Dto.Dtos.Basico_AA.AA00X.DtoGetAA043
                {
                    TenantId = entity.TenantId,
                    Id = entity?.Nav_AA143?.Id ?? string.Empty,
                    Aa043Artigo = entity?.Nav_AA143?.Aa043Artigo ?? string.Empty,
                    Aa043LcRedacao = entity?.Nav_AA143?.Aa043LcRedacao ?? string.Empty,
                    Aa043Ec = entity?.Nav_AA143?.Aa043Ec ?? string.Empty,
                },
                Nav_AA046_TP_GOV = entity?.Nav_AA146_TP_GOV,
                //O RESTANTE É COMPLETADO NA CLASSE DE SERVIÇO, APÓS A CHAMADA DO MÉTODO
            };
        }

        public static Dto_GetBB012J ToDtoGetBB012J(this CSICP_BB012j entity)
        {
            return new Dto_GetBB012J
            {
                Id = entity.Id,
                Bb012Id = entity.Bb012Id,
                Bb012jTelefone = entity.Bb012jTelefone,
                Bb012jFax = entity.Bb012jFax,
                Bb012jEmail = entity.Bb012jEmail,
                Bb012jTipoendereco = entity.Bb012jTipoendereco,
                NavTipoEndereco = entity.NavTipoEndereco,
                NavBB1206_Enderecos = entity.NavBB1206_Endereco != null ? entity.NavBB1206_Endereco.ToDtoBB01206() : null,
            };
        }

        public static CSICP_BB012j ToEntity(this Dto_LinkBB012J dto)
        {
            return new CSICP_BB012j
            {
                Bb012Id = null,
                Bb012jTelefone = dto.Bb012jTelefone,
                Bb012jFax = dto.Bb012jFax,
                Bb012jEmail = dto.Bb012jEmail,
                Bb012jTipoendereco = dto.Bb012jTipoendereco
            };
        }

        public static Dto_GetBB012o ToDtoGetBB012o(this CSICP_BB012o entity)
        {
            return new Dto_GetBB012o
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Id = entity.Bb012Id,
                Bb012oCodigo = entity.Bb012oCodigo,
                Bb012oRetem = entity.Bb012oRetem,
                Bb012oPercentual = entity.Bb012oPercentual,
                Bb012oImpostoId = entity.Bb012oImpostoId,
                NavBb012oImposto = entity.NavBb012oImposto,
                NavStatica_Retem = entity.NavStatica_Retem
            };
        }

        public static Dto_GetBB1208 ToDtoGetBB1208(this CSICP_BB01208 entity)
        {
            return new Dto_GetBB1208
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Id = entity.Bb012Id,
                Bb012Contatoid = entity.Bb012Contatoid,
                Bb036Candidatoid = entity.Bb036Candidatoid,
                Bb043Campanhaid = entity.Bb043Campanhaid,
                Bb042Potencialid = entity.Bb042Potencialid,
                Bb040Atividadeid = entity.Bb040Atividadeid,
                Bb041Casoid = entity.Bb041Casoid,
                Concorrenteid = entity.Concorrenteid,
                Bb01208GrauparentId = entity.Bb01208GrauparentId,

                NavCSICP_BB035 = entity.NavCSICP_BB035?.ToDtoGetExibicao(),
                NavCSICP_BB035Gpa = entity.NavCSICP_BB035Gpa,
            };
        }
        public static Dto_GetBB1210 ToDtoGetBB1210(this CSICP_BB01210 entity)
        {
            return new Dto_GetBB1210
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Id = entity.Bb012Id,
                Bb01210Tipo = entity.Bb01210Tipo,
                Bb01210Ano = entity.Bb01210Ano,
                Bb01210Mes = entity.Bb01210Mes,
                Bb01210Vcredsemscore = entity.Bb01210Vcredsemscore,
                Bb01210Vcredcomscore = entity.Bb01210Vcredcomscore,
                Bb01210Vcredmedia = entity.Bb01210Vcredmedia,
                Bb01210Dtregistro = entity.Bb01210Dtregistro,
                JsonCreditpro = entity.JsonCreditpro,
                QtdComportamentoCompras = entity.QtdComportamentoCompras,
                QtdAtrasosfreq = entity.QtdAtrasosfreq,
                QtdAtrasosmoderados = entity.QtdAtrasosmoderados,
                QtdPagtospontuais = entity.QtdPagtospontuais,
                QtdSemprepagaprazo = entity.QtdSemprepagaprazo,
                QtdTitulos = entity.QtdTitulos,
                CteObtemPesoC = entity.CteObtemPesoC,
                CteObtemPesoP = entity.CteObtemPesoP,
                Mediasalarialbairro = entity.Mediasalarialbairro,
                Renda = entity.Renda,
                FFatorajuste = entity.FFatorajuste,
                Wc = entity.Wc,
                We = entity.We,
                Wp = entity.Wp,
                Wr = entity.Wr,
                Scoreclearsale = entity.Scoreclearsale,
                Taxascore = entity.Taxascore,
                CteCgradValorcredito = entity.CteCgradValorcredito,
                CteCgradFatorGradualidade = entity.CteCgradFatorGradualidade,
                CteCgradCreditoUsado = entity.CteCgradCreditoUsado,
                CteCgradCreditoPago = entity.CteCgradCreditoPago,
                CteCgradCreditoEmaberto = entity.CteCgradCreditoEmaberto,
                CteCgradQtdTituloaberto = entity.CteCgradQtdTituloaberto,
                CteCgradMaxDiasPagtoatra = entity.CteCgradMaxDiasPagtoatra,
                CteCgradMaxDiasTitatraso = entity.CteCgradMaxDiasTitatraso,
                CteCrednaopagoPercNaopago = entity.CteCrednaopagoPercNaopago,
                CteAgradDPesoVlrsdivida = entity.CteAgradDPesoVlrsdivida,
                CteAgradDPercVlrsdivida = entity.CteAgradDPercVlrsdivida,
                CteGradualU = entity.CteGradualU,
                CteGradualUWu = entity.CteGradualUWu,
                CteGradualF = entity.CteGradualF,
                CteGradualP = entity.CteGradualP,
                FWf = entity.FWf,
                PWpa = entity.PWpa,
                VlrNovocredito = entity.VlrNovocredito,
            };
        }
        public static Dto_GetBB012C ToDtoGetBB012C(this CSICP_BB012c entity)
        {
            return new Dto_GetBB012C
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Id = entity.Bb012Id,
                Bb012cDescempresa = entity.Bb012cDescempresa,
                Bb012cProprietramo = entity.Bb012cProprietramo,
                Bb012cValorMedia = entity.Bb012cValorMedia,
                Bb012cFone = entity.Bb012cFone,
                Bb012cIsActive = entity.Bb012cIsActive,
            };
        }
        public static CSICP_BB012c ToEntity(this Dto_LinkBB012C dto)
        {
            return new CSICP_BB012c
            {
                Bb012Id = dto.Bb012Id,
                Bb012cDescempresa = dto.Bb012cDescempresa,
                Bb012cProprietramo = dto.Bb012cProprietramo,
                Bb012cValorMedia = dto.Bb012cValorMedia,
                Bb012cFone = dto.Bb012cFone,
                Bb012cIsActive = true,
            };
        }
        public static Dto_GetBB012M ToDtoGetBB012M(this CSICP_BB012m entity)
        {
            return new Dto_GetBB012M
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Id = entity.Bb012Id,
                Bb012Contatoid = entity.Bb012Contatoid,
                Bb012Candidatoid = entity.Bb012Candidatoid,
                Bb043Campanhaid = entity.Bb043Campanhaid,
                Bb042Potencialid = entity.Bb042Potencialid,
                Bb040Atividadeid = entity.Bb040Atividadeid,
                Bb041Casoid = entity.Bb041Casoid,
                Bb012mCodigoCliente = entity.Bb012mCodigoCliente,
                Bb012mDescricao = entity.Bb012mDescricao,
                Bb012mContent = entity.Bb012mContent,
                Bb012mFiletype = entity.Bb012mFiletype,
                Bb012mFilename = entity.Bb012mFilename,
                Bb012mIsActive = entity.Bb012mIsActive,
                Bb012mTipodoctoid = entity.Bb012mTipodoctoid,
                Bb012mDoctoid = entity.Bb012mDoctoid,
                Bb012mDatadocto = entity.Bb012mDatadocto,
                Bb012mPath = entity.Bb012mPath,
                NavBB012MDC = entity.NavBB012MDC,
                NavBB012MTD = entity.NavBB012MTD,
            };
        }
        public static Dto_GetBB1209 ToDtoGetBB1209(this CSICP_BB01209 entity)
        {
            return new Dto_GetBB1209
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Contaid = entity.Bb012Contaid,
                Bb01209Datareg = entity.Bb01209Datareg,
                Bb01209Json = entity.Bb01209Json,
            };
        }
        public static Dto_GetBB012Q ToDtoGetBB012Q(this CSICP_BB012q entity)
        {
            return new Dto_GetBB012Q
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Id = entity.Bb012Id,
                Bb012Agencia = entity.Bb012Agencia,
                Bb012Conta = entity.Bb012Conta,
                Bb012Valorfinanciamento = entity.Bb012Valorfinanciamento,
                Bb012Nomegerente = entity.Bb012Nomegerente,
                Bb012Telefone = entity.Bb012Telefone,
                Bb012Faxcelular = entity.Bb012Faxcelular,
                Bb012Homepage = entity.Bb012Homepage,
                Bb012Email = entity.Bb012Email,
                Bb012qIsActive = entity.Bb012qIsActive,
            };
        }
        public static Dto_GetBB1207Membro ToDtoGetBB1207(this CSICP_BB01207 entity)
        {
            return new Dto_GetBB1207Membro
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012TipoRegMembroconveni = entity.Bb012TipoRegMembroconveni,
                Bb012Id = entity.Bb012Id,
                Bb012Membroid = entity.Bb012Membroid,
                Bb01207IsActive = entity.Bb01207IsActive,
                NavBb012Membro = entity.NavBb012Membro != null ? new DtoGetBB012MembroBB1207
                {
                    Id = entity.NavBb012Membro?.Id,
                    Bb012Codigo = entity.NavBb012Membro?.Bb012Codigo,
                    Bb012NomeCliente = entity.NavBb012Membro?.Bb012NomeCliente,
                    Bb012NomeFantasia = entity.NavBb012Membro?.Bb012NomeFantasia
                } : null
            };
        }

        public static Dto_GetBB01201 ToDtoBB01201(this CSICP_BB01201 entity)
        {
            return new Dto_GetBB01201
            {

                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Zonaid = entity.Bb012Zonaid,
                Bb012Atividadeid = entity.Bb012Atividadeid,
                Bb012Limitecredito = entity.Bb012Limitecredito,
                Bb012Limcreditosecun = entity.Bb012Limcreditosecun,
                Bb012Limiteccredito = entity.Bb012Limiteccredito,
                Bb012Diavenctocartao = entity.Bb012Diavenctocartao,
                Bb012Contaconvenio = entity.Bb012Contaconvenio,
                Bb012Diaspagtoconv = entity.Bb012Diaspagtoconv,
                Bb012Padraobancoid = entity.Bb012Padraobancoid,
                Bb012Bcoagenciaconta = entity.Bb012Bcoagenciaconta,
                Bb012Revenda = entity.Bb012Revenda,
                Bb012TaxaAdministracaoCon = entity.Bb012TaxaAdministracaoCon,
                Bb012Requisicao = entity.Bb012Requisicao,
                Bb012Contacontabil = entity.Bb012Contacontabil,
                Bb012Historicocontabilid = entity.Bb012Historicocontabilid,
                Bb012Contratocartao = entity.Bb012Contratocartao,
                Bb012Datacontratocartao = entity.Bb012Datacontratocartao,
                Bb012Dtvalidadecartao = entity.Bb012Dtvalidadecartao,
                Bb012Modalidadecredcartao = entity.Bb012Modalidadecredcartao,
                Bb012Perclimcredito = entity.Bb012Perclimcredito,
                Bb012Prazoentregafornec = entity.Bb012Prazoentregafornec,
                Bb012Condpagtofornec = entity.Bb012Condpagtofornec,
                Bb012Natoperacaoid = entity.Bb012Natoperacaoid,
                Bb012Condpagtoid = entity.Bb012Condpagtoid,
                Bb012Textonotaid = entity.Bb012Textonotaid,
                Bb012GrauRisco = entity.Bb012GrauRisco,
                Bb012ClasseCredito = entity.Bb012ClasseCredito,
                Bb012Dtvalidcadastro = entity.Bb012Dtvalidcadastro,
                Bb012PercIcms = entity.Bb012PercIcms,
                Bb012Codgcategoria = entity.Bb012Codgcategoria,
                Bb012Categoriaid = entity.Bb012Categoriaid,
                Bb012Limitecredparcela = entity.Bb012Limitecredparcela,
                Bb012NumUltFatura = entity.Bb012NumUltFatura,
                Bb012Totcompracarnet = entity.Bb012Totcompracarnet,
                Bb012ValorEntrada = entity.Bb012ValorEntrada,
                Bb012MaiorCompra = entity.Bb012MaiorCompra,
                Bb012MenorCompra = entity.Bb012MenorCompra,
                Bb012Totdiasatraso = entity.Bb012Totdiasatraso,
                Bb012MaiorAtraso = entity.Bb012MaiorAtraso,
                Bb012MenorAtraso = entity.Bb012MenorAtraso,
                Bb012Mediadeatraso = entity.Bb012Mediadeatraso,
                Bb012Maiorsaldo = entity.Bb012Maiorsaldo,
                Bb012Numcompras = entity.Bb012Numcompras,
                Bb012Dtprimcompra = entity.Bb012Dtprimcompra,
                Bb012Dtultcompra = entity.Bb012Dtultcompra,
                Bb012Vlrmaiorpagto = entity.Bb012Vlrmaiorpagto,
                Bb012Numpagtodia = entity.Bb012Numpagtodia,
                Bb012Numpagtoatraso = entity.Bb012Numpagtoatraso,
                Bb012Saldodevedor = entity.Bb012Saldodevedor,
                Bb012Saldopedido = entity.Bb012Saldopedido,
                Bb012Qtdtitprotestado = entity.Bb012Qtdtitprotestado,
                Bb012Ultprotesto = entity.Bb012Ultprotesto,
                Bb012Qtdchqdevolvido = entity.Bb012Qtdchqdevolvido,
                Bb012Ultchqdevolvido = entity.Bb012Ultchqdevolvido,
                Bb012ConvenioId = entity.Bb012ConvenioId,
                Bb012TipogeracaoId = entity.Bb012TipogeracaoId,
                Bb012SitespecialId = entity.Bb012SitespecialId,
                Bb012Entmtgrotaid = entity.Bb012Entmtgrotaid,
                Bb012Vendarotaid = entity.Bb012Vendarotaid,
                Bb012Diavenctoid = entity.Bb012Diavenctoid,
                Bb012Codgbcodebconta = entity.Bb012Codgbcodebconta,
                NavBB010_Zona = entity.BB010_Zona?.ToDtoGetSimples(),
                NavBB011_Atividade = entity.BB011_Atividade?.ToDtoGet(),
                NavBB006_BancoPadrao = entity.BB006_BancoPadrao?.ToDtoGetExibicao(),
                NavRevenda = entity.Revenda,
                NavRequisicao = entity.Requisicao,
                NavBB025_NatOperacao = entity.BB025_NatOperacao?.ToDtoGetSimples(),
                NavBB008_CondPagamento = entity.BB008_CondPagamento?.ToDtoGetSimples(),
                NavBB029_Categoria = entity.BB029_Categoria?.ToDtoGet(),
                NavBB01201_Convenio = entity.BB01201_Convenio,
                NavBB01201_TpGeracao = entity.BB01201_TpGeracao,
                NavBB01201_SitEspecial = entity.BB01201_SitEspecial,
                NavBB010_EntregaMontagem = entity.BB010_EntregaMontagem?.ToDtoGetSimples(),
                NavBB010_VendaRota = entity.BB010_VendaRota?.ToDtoGetSimples(),
                NavBB037_DiaVencimento = entity.BB037_DiaVencimento?.ToDtoGet()
            };
        }

        public static Dto_GetBB01202 ToDtoBB01202(this CSICP_BB01202 entity)
        {
            return new Dto_GetBB01202
            {
                Id = entity.Id,
                Bb012Cnpj = entity.Bb012Cnpj,
                Bb012Inscestadual = entity.Bb012Inscestadual,
                Bb012Suframa = entity.Bb012Suframa,


                Bb012Regsuframavalido = entity.Bb012Regsuframavalido,
                Bb012Regjuntacomercial = entity.Bb012Regjuntacomercial,
                Bb012Dataregjunta = entity.Bb012Dataregjunta,
                Bb012Patrimonio = entity.Bb012Patrimonio,
                Bb012CapitalSocial = entity.Bb012CapitalSocial,
                Bb012Cpf = entity.Bb012Cpf,
                Bb012Rg = entity.Bb012Rg,
                Bb012Complementorg = entity.Bb012Complementorg,
                Bb012Emissaorg = entity.Bb012Emissaorg,
                Bb012Pis = entity.Bb012Pis,
                Bb012Residedesde = entity.Bb012Residedesde,
                Bb012Nrodependentes = entity.Bb012Nrodependentes,
                Bb012Empadmissao = entity.Bb012Empadmissao,
                Bb012EmpProfissao = entity.Bb012EmpProfissao,
                Bb012Valorremuneracao = entity.Bb012Valorremuneracao,
                Bb012Outrosrendimentos = entity.Bb012Outrosrendimentos,
                Bb012Origemoutrosrend = entity.Bb012Origemoutrosrend,
                Bb012InscEstSniId = entity.Bb012InscEstSniId,
                Bb012SexoId = entity.Bb012SexoId,
                Bb012EstadocivilId = entity.Bb012EstadocivilId,
                Bb012TipodomicilioId = entity.Bb012TipodomicilioId,
                Bb012Compresid01Id = entity.Bb012Compresid01Id,
                Bb012Compresid02Id = entity.Bb012Compresid02Id,
                Bb012GescolaridadeId = entity.Bb012GescolaridadeId,
                Bb012OcupacaoId = entity.Bb012OcupacaoId,
                Bb012NaturaldeId = entity.Bb012NaturaldeId,
                Bb012TptributacaoId = entity.Bb012TptributacaoId,
                Bb012IdentEstrangeiro = entity.Bb012IdentEstrangeiro,
                Bb012Empresa = entity.Bb012Empresa,
                Bb012EmpEndereco = entity.Bb012EmpEndereco,
                Bb012EmpGrupoId = entity.Bb012EmpGrupoId,
                Bb012Motdesoneracaoid = entity.Bb012Motdesoneracaoid,


                NavBB012_RegSUFRAMAValido = entity.BB012_RegSUFRAMAValido,
                NavBB012_Insc_Est_SNI = entity.BB012_Insc_Est_SNI,
                NavBB012_Sexo = entity.BB012_Sexo,
                NavBB012_EstadoCivil = entity.BB012_EstadoCivil,
                NavBB012_Domicilio = entity.BB012_Domicilio,
                NavBB012_ComprovanteResidencia1 = entity.BB012_ComprovanteResidencia1,
                NavBB012_ComprovanteResidencia2 = entity.BB012_ComprovanteResidencia2,
                NavBB012_Escolaridade = entity.BB012_Escolaridade,
                NavBB012_Ocupacao = entity.BB012_Ocupacao,
                NavAA028_NatualDe = entity.AA028_NatualDe is not null ? entity.AA028_NatualDe.ToDtoGetSimples() : null,
                NavBB001_Tributacao = entity.BB001_Tributacao,
                NavBB012_TipoDaEmpresaTrabalho = entity.BB012_TipoDaEmpresaTrabalho,
                NavBB027_MotivoDesoneracao = entity.BB027_MotivoDesoneracao,
            };
        }

        public static Dto_GetBB01206 ToDtoBB01206(this CSICP_BB01206 entity)
        {
            return new Dto_GetBB01206
            {

                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Id = entity.Bb012Id,
                Bb012jEnderecoid = entity.Bb012jEnderecoid,
                Bb012Logradouro = entity.Bb012Logradouro,
                Bb012Numero = entity.Bb012Numero,
                Bb012Complemento = entity.Bb012Complemento,
                Bb012Codgbairro = entity.Bb012Codgbairro,
                Bb012Bairro = entity.Bb012Bairro,
                Bb012CodigoCidade = entity.Bb012CodigoCidade,
                Bb012Uf = entity.Bb012Uf,
                Bb012Cep = entity.Bb012Cep,
                Bb012CodigoPais = entity.Bb012CodigoPais,
                Bb012EntregaLogradouro = entity.Bb012EntregaLogradouro,
                Bb012EntregaNumero = entity.Bb012EntregaNumero,
                Bb012EntregaComplement = entity.Bb012EntregaComplement,
                Bb012EntregaCodgbairro = entity.Bb012EntregaCodgbairro,
                Bb012EntregaBairro = entity.Bb012EntregaBairro,
                Bb012EntregaCodCidade = entity.Bb012EntregaCodCidade,
                Bb012EntregaUf = entity.Bb012EntregaUf,
                Bb012EntregaCep = entity.Bb012EntregaCep,
                Bb012EntregaPais = entity.Bb012EntregaPais,
                Bb012Perimetro = entity.Bb012Perimetro,
                Bb012EntregaPerimetro = entity.Bb012EntregaPerimetro,
                Bb012Telefone = entity.Bb012Telefone,
                Bb012Celular = entity.Bb012Celular,
                Bb012Email = entity.Bb012Email,
                NavAA028_Cidade = entity.AA028_Cidade?.ToDtoGet(),
                NavAA027_UF = entity.AA027_UF?.ToDtoGet(),
                NavAA025_Pais = entity.AA025_Pais?.ToDtoGet(),
            };
        }

        public static Dto_GetBB01206Simples ToDtoBB01206Simples(this CSICP_BB01206 entity)
        {
            return new Dto_GetBB01206Simples
            {

                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Id = entity.Bb012Id,
                Bb012jEnderecoid = entity.Bb012jEnderecoid,
                Bb012Logradouro = entity.Bb012Logradouro,
                Bb012Numero = entity.Bb012Numero,
                Bb012Complemento = entity.Bb012Complemento,
                Bb012Codgbairro = entity.Bb012Codgbairro,
                Bb012Bairro = entity.Bb012Bairro,
                UF_Aa027Sigla = entity.AA027_UF?.Aa027Sigla,
                UF_Descricao = entity.AA027_UF?.Descricao,
                Pais_Aa025Codigopais = entity.AA025_Pais?.Aa025Codigopais,
                Pais_Aa025Descricao = entity.AA025_Pais?.Aa025Descricao,
               
            };
        }

        public static Dto_GetBB01203 ToGetDtoBB01203(this CSICP_BB01203 entity)
        {
            return new Dto_GetBB01203
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Id = entity.Bb012Id,
                Bb012Contatoid = entity.Bb012Contatoid,
                Bb012Candidatoid = entity.Bb012Candidatoid,
                Bb043Campanhaid = entity.Bb043Campanhaid,
                Bb042Potencialid = entity.Bb042Potencialid,
                Bb040Atividadeid = entity.Bb040Atividadeid,
                Bb041Casoid = entity.Bb041Casoid,
                Bb046Concorrenteid = entity.Bb046Concorrenteid,
                Bb012Nota = entity.Bb012Nota,
                Bb01203IsActive = entity.Bb01203IsActive,
            };
        }

        public static Dto_GetBB012_ExibSimples ToDtoGetExibSimples(this CSICP_BB012 entity)
        {
            return new Dto_GetBB012_ExibSimples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Codigo = entity.Bb012Codigo,
                Bb012NomeCliente = entity.Bb012NomeCliente,
            };
        }

        public static Dto_GetBB012Convenio ToDtoGet(this CSICP_BB012 entity)
        {
            return new Dto_GetBB012Convenio
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Codigo = entity.Bb012Codigo,
                Bb012NomeCliente = entity.Bb012NomeCliente,
                Bb012NomeFantasia = entity.Bb012NomeFantasia,
                Bb012DataAniversario = entity.Bb012DataAniversario,
                Bb012DataCadastro = entity.Bb012DataCadastro,
                Bb012Telefone = entity.Bb012Telefone,
                Bb012Faxcelular = entity.Bb012Faxcelular,
                Bb012HomePage = entity.Bb012HomePage,
                Bb012Email = entity.Bb012Email,
                Bb012DataEntradaSit = entity.Bb012DataEntradaSit,
                Bb012DataSaidaSit = entity.Bb012DataSaidaSit,
                Bb012Descricao = entity.Bb012Descricao,
                Bb012IsActive = entity.Bb012IsActive,
                Bb012TipoContaId = entity.Bb012TipoContaId,
                Bb012GrupocontaId = entity.Bb012GrupocontaId,
                Bb012ClassecontaId = entity.Bb012ClassecontaId,
                Bb012StatuscontaId = entity.Bb012StatuscontaId,
                Bb012SitContaId = entity.Bb012SitContaId,
                Bb012ModrelacaoId = entity.Bb012ModrelacaoId,
                Bb012Sequence = entity.Bb012Sequence,
                Bb012Dultalteracao = entity.Bb012Dultalteracao,
                Bb012Estabcadid = entity.Bb012Estabcadid,
                Bb012Keyacess = entity.Bb012Keyacess,
                Bb012IdIndicador = entity.Bb012IdIndicador,
                Bb012Countappmcon = entity.Bb012Countappmcon,
                Bb012Oricadastroid = entity.Bb012Oricadastroid
            };
        }
    }
}


















