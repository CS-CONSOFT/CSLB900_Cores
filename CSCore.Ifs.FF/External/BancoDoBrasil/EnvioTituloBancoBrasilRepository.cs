using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.EstaticasLabel.GG;
using CSCore.Domain.Interfaces.Estatica;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.External.BancoDoBrasil.Interface;
using CSCore.Ifs.FF.External.BancoDoBrasil.Interface.Impl;
using CSCore.Ifs.FF.External.Parametros;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.External.BancoDoBrasil
{
    enum TIPO_REGISTRO_FF102
    {
        CONTAS_RECEBER = 1,
        CARTAO_CREDITO = 2,
        CONTAS_PAGAR = 3,
    }

    public enum TIPO_BANCO
    {
        BB = 1,
        BRADESCO = 2
    }

    enum CNAB_STATUS
    {
        OK = 1,
        ERRO = -1
    }


    public class RepoDtoCfgCnabCompleto
    {
        public CSICP_FF112? Ff112 { get; set; }
        public CSICP_FF113? Ff113 { get; set; }
        public OsusrE9aCsicpFf112C026? Ff112_C026 { get; set; }
        public OsusrE9aCsicpFf112C028? Ff112_C028 { get; set; }
        public OsusrE9aCsicpFf112C006? Ff112_C006 { get; set; }
        public OsusrE9aCsicpFf112C029? Ff112_C029 { get; set; }
        public OsusrE9aCsicpFf112C007? Ff112_C007 { get; set; }
        public OsusrE9aCsicpFf112C008? Ff112_C008 { get; set; }
        public OsusrE9aCsicpFf112C004? Ff112_C004 { get; set; }
        public OsusrE9aCsicpFf112C009? Ff112_C009 { get; set; }
        public OsusrE9aCsicpFf112C010? Ff112_C010 { get; set; }
        public OsusrE9aCsicpFf112G005? Ff112_G005 { get; set; }
        public OsusrE9aCsicpFf112G025? Ff112_G025 { get; set; }
        public CSICP_FF102_C021? Ff102_C021 { get; set; }
        public CSICP_FF102_G073? Ff102_G073 { get; set; }
        public CSICP_FF102_C018? Ff102_C018 { get; set; }
        public OsusrE9aCsicpFf112OrgNeg? Ff112_Org_Neg { get; set; }
    }



    public class EnvioTituloBancoBrasilRepository(
        IRefitBancoBrasil refitBancoBrasil,
        AppDbContext appDbContext,
        IFF102Repository iFF102Repository,
        IStaticaLabelRepository staticaLabelRepository
        ) : BancoDoBrasilServiceBaseImpl(refitBancoBrasil), IBancoBrasilEnvioTitulos
    {
        private readonly IRefitBancoBrasil _refitBancoBrasil = refitBancoBrasil;
        private readonly IStaticaLabelRepository _staticaLabelRepository = staticaLabelRepository;
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly IFF102Repository _iFF102Repository = iFF102Repository;

        public async Task CS01_Envio_Titulos(string in_ff102ID, int in_tenantID)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                //pega o titulo
                RepoDtoCSICP_FF102 getTitulo =
                    await _iFF102Repository.GetByIdAsync(
                    in_tenantID,
                    in_ff102ID,
                    in_tipoRegistro: null) ?? throw new KeyNotFoundException("RepoDtoCSICP_FF102 não encontrado");

                //pega o cnab
                ReturnCnab returnCnab = await CS_Ret_CfgCNAB(getTitulo.Ff102Agcobradorid ?? "");

                //atualiza parte da ff102
                CS_Atualiza_Titulos(getTitulo, returnCnab);

                //atualiza a ff112 faixa nro remessa
                decimal? seqRemessa = CS51_At_Seq_Remessa(returnCnab.CSICP_FF112Faixa);

                var in_StID_csicp_ff112_cnab_APIPRD = await _staticaLabelRepository.GetIDStaticaByLabel<OsusrE9aCsicpFf112Cnab>(Entities.ff112_cnab.APIPRD);

                if (EhProducao(
                    returnCnab.CSICP_FF112Completo.Ff112?.Ff112CnabId,
                    in_StID_csicp_ff112_cnab_APIPRD)) await CS51_Registrar_Envio(in_ff102ID, in_tenantID);

                //autentica no Banco do Brasil
                var (estabAuthToken, estabChaveAPL) = await GetBB001AuthToken(returnCnab);
                if (estabAuthToken == null || estabChaveAPL == null)
                    throw new KeyNotFoundException();

                

                CriaBoletoRequest criaBoletoReq = await MontaParametrosCriaBoletoReq(getTitulo, returnCnab, seqRemessa);

                //cria boleto
                string tokenAutenticacaoComBearer = await ObterTokenAutenticacao(in_tokenAutenticacao: estabAuthToken, null);
                var in_retornoCriaBoleto = await CS51_Cria_Boleto(tokenAutenticacaoComBearer, criaBoletoReq, estabChaveAPL);

                var in_StID_csicp_ff120_trackApi_FinalizadoEnvio
                    = await _staticaLabelRepository.GetIDStaticaByLabel<CSICP_FF120TrackApi>(Entities.FF120_TRACKAPI.FinalizadoEnvio);
                if (EhProducao(
                    returnCnab.CSICP_FF112Completo.Ff112?.Ff112CnabId,
                    in_StID_csicp_ff112_cnab_APIPRD))
                    await CS51_Registrar_Finalizacao(in_ff102ID, in_tenantID, in_StID_csicp_ff120_trackApi_FinalizadoEnvio);


                PrmAtualizaTitulo prmAtualizaTitulo = new PrmAtualizaTitulo
                {
                    in_ff102ForUpdate = getTitulo,
                    in_retornoCriaBoleto = in_retornoCriaBoleto,
                    in_hashFF102 = getTitulo.Ff102HashId ?? "",
                    in_valorJuros = getTitulo.Ff102cpValorJurosDia ?? 0,
                    in_valorMulta = getTitulo.Ff102cpValorMulta ?? 0,
                    in_tipoCobrancaID = getTitulo.Ff102Tipocobrancaid,
                    in_apiID = returnCnab.CSICP_BB006Banco.CSICP_BB006Banco?.Bb006ApiId ?? 0,
                    in_StID_csicp_ff120_trackApi_FinalizadoEnvio = in_StID_csicp_ff120_trackApi_FinalizadoEnvio
                };
                //atualiza outra parte da ff102
                CS52_Atualiza_Titulo(prmAtualizaTitulo);

                //comita salvando a ff102 e a ff112
                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }





        /*METODOS PRIVADOS*/


        private async Task<CriaBoletoRequest> MontaParametrosCriaBoletoReq(
            RepoDtoCSICP_FF102 getTitulo,
            ReturnCnab returnCnab,
            decimal? seqRemessa)
        {


            var in_StId_csicp_ff112_C026_naoProtestar = await _staticaLabelRepository.csicp_ff112_cnab(Entities.ff112_C026.NaoProtestar);
            var in_StId_csicp_ff112_C026_negativacaoSemProtesto = await _staticaLabelRepository.csicp_ff112_cnab(Entities.ff112_C026.NegativacaosemProtesto);
            var in_StId_csicp_ff112_C026_cancelamentoProtestoAutomatico = await _staticaLabelRepository.csicp_ff112_cnab(Entities.ff112_C026.CancelamentoProtestoAutomatico);
            var in_StId_csicp_bb012_GruCta_Outros = await _staticaLabelRepository.csicp_bb012_GruCta(Entities.csicp_bb012_GruCta.Outros);
            var criaBoletoReq = new CriaBoletoRequest
            {
                NumeroConvenio = long.Parse(returnCnab.CSICP_FF112Completo.Ff112.Ff112Convenio ?? "0"),
                NumeroCarteira = int.Parse(returnCnab.CSICP_FF112Completo.Ff112.Ff112Nrocarteira ?? "0"),
                NumeroVariacaoCarteira = int.Parse(returnCnab.CSICP_FF112Completo.Ff112.Ff112Varcarteira ?? "0"),
                CodigoModalidade = int.Parse(returnCnab.CSICP_FF112Completo.Ff112_C006?.Conteudo ?? "0"),

                DataEmissao = StringUtils.FormatarDataCustom(
                        getTitulo.Ff102DataEmissao, Prm_Separador: ".", Prm_Tam_Ano: 4),

                DataVencimento = StringUtils.FormatarDataCustom(
                        getTitulo.Ff102DataEmissao, Prm_Separador: ".", Prm_Tam_Ano: 4),

                ValorOriginal = getTitulo.Ff102VlLiqTitulo,
                ValorAbatimento = 0,

                QuantidadeDiasProtesto = ObterPrazoProtestoOuZero(
                        returnCnab.CSICP_FF112Completo.Ff112.Ff112Codgprotesto ?? 0,
                        returnCnab.CSICP_FF112Completo.Ff112.Ff112Prazoprotesto ?? 0,
                        in_StId_csicp_ff112_C026_naoProtestar,
                        in_StId_csicp_ff112_C026_negativacaoSemProtesto,
                        in_StId_csicp_ff112_C026_cancelamentoProtestoAutomatico
                        ),

                QuantidadeDiasNegativacao = returnCnab.CSICP_FF112Completo.Ff112.Ff112Prazonegativacao ?? 0,
                OrgaoNegativador = int.Parse(returnCnab.CSICP_FF112Completo.Ff112_Org_Neg?.CodgBb ?? "0"),
                NumeroDiasLimiteRecebimento = returnCnab.CSICP_FF112Completo.Ff112.Ff112Prazorecbto ?? 0,
                CodigoAceite = returnCnab.CSICP_FF112Completo.Ff112_C029?.Conteudo,
                CodigoTipoTitulo = 2,
                DescricaoTipoTitulo = "DM",
                IndicadorPermissaoRecebimentoParcial = "N",
                NumeroTituloBeneficiario = Gera_Hash(),

                CampoUtilizacaoBeneficiario = StringUtils.FixaTamanhoValor(
                        valor: getTitulo.NavBB001?.Bb001Codigoempresa.ToString(),
                        lengthMax: 3) + "" + getTitulo.Ff102Pfx + "" + getTitulo.Ff102NoTitulo + "" + getTitulo.Ff102Sfx,


                NumeroTituloCliente = "000" + returnCnab.CSICP_FF112Completo.Ff112.Ff112Convenio + "" +
                                            StringUtils.FixaTamanhoValor(
                                                valor: seqRemessa.ToString(),
                                                lengthMax: 10,
                                                isDecimal: true),


                MensagemBloquetoOcorrencia = returnCnab.CSICP_FF112Completo.Ff112.Ff112Mensagem1,
                Desconto = new Desconto
                {
                    Tipo = int.Parse(returnCnab.CSICP_FF112Completo.Ff102_C021?.Conteudo ?? "0"),
                    Porcentagem = 0
                },
                JurosMora = new JurosMora
                {
                    Tipo = int.Parse(returnCnab.CSICP_FF112Completo.Ff102_C018?.Conteudo ?? "0"),

                    Porcentagem = decimal.Parse(returnCnab.CSICP_FF112Completo.Ff102_C018?.Conteudo ?? "0") == 2
                            ? returnCnab.CSICP_FF112Completo.Ff112.Ff112PercJuros ?? 0
                            : 0,

                    Valor = decimal.Parse(returnCnab.CSICP_FF112Completo.Ff102_C018?.Conteudo ?? "0") == 1
                            ? returnCnab.CSICP_FF112Completo.Ff112.Ff112ValorJuros ?? 0
                            : 0,

                },
                Multa = new Multa
                {
                    Tipo = int.Parse(returnCnab.CSICP_FF112Completo.Ff102_G073?.Conteudo ?? "0"),

                    Porcentagem = decimal.Parse(returnCnab.CSICP_FF112Completo.Ff102_G073?.Conteudo ?? "0") == 2
                            ? returnCnab.CSICP_FF112Completo.Ff112.Ff112PercMulta ?? 0
                            : 0,

                    Valor = decimal.Parse(returnCnab.CSICP_FF112Completo.Ff102_G073?.Conteudo ?? "0") == 1
                            ? returnCnab.CSICP_FF112Completo.Ff112.Ff112ValorMulta
                            : 0,

                    Data = StringUtils.FormatarDataCustom(
                            getTitulo.Ff102DataVencimento.AddDays(1), Prm_Separador: ".", Prm_Tam_Ano: 4)
                },
                Pagador = new Pagador
                {
                    TipoInscricao =
                        getTitulo.NavBB012?.Bb012GrupocontaId == in_StId_csicp_bb012_GruCta_Outros ? 1 : 2,

                    NumeroInscricao =
                        //se for "Outros" (Grupo de Conta Outros) pega o CPF,
                        getTitulo.NavBB012?.Bb012GrupocontaId == in_StId_csicp_bb012_GruCta_Outros

                        //passa o cpf de decimal pra string e depois de string pra long
                        ? long.Parse(getTitulo.NavBB012?.Nav_BB01202?.Bb012Cpf.ToString() ?? "0")


                        : getTitulo.NavBB012?.Nav_BB01202?.Bb012Cnpj != null

                            ? long.Parse(getTitulo.NavBB012?.Nav_BB01202?.Bb012Cnpj ?? "0")

                            : 0,

                    Nome = getTitulo.NavBB012?.Bb012NomeCliente ?? "",
                    Endereco = getTitulo.NavBB012?.NavBB01206?.Bb012Logradouro ?? "",
                    Bairro = getTitulo.NavBB012?.NavBB01206?.Bb012Bairro ?? "",
                    Cep = getTitulo.NavBB012?.NavBB01206?.Bb012Cep ?? 0,
                    //Cidade = getTitulo.nav ?? "",
                    //Uf = getTitulo.Ff102cpUf ?? ""m
                    Telefone = getTitulo.NavBB012?.Bb012Telefone
                },
                IndicadorPix = returnCnab.CSICP_FF112Completo.Ff112_C006?.Conteudo == "1" ? "S" : "N",
            };
            return criaBoletoReq;
        }

        /// <summary>
        /// Retorna 0 se o código de protesto for "Não Protestar", 
        /// "Negativação sem Protesto" ou "Cancelamento Protesto Automático",
        /// caso contrário retorna o prazo de protesto informado.
        /// </summary>
        /// <param name="in_ff112codgProtesto">Código de protesto a ser verificado.</param>
        /// <param name="in_StId_csicp_ff112_C026_prazoProtesto">Prazo de protesto a ser retornado caso não seja nenhum dos códigos especiais.</param>
        /// <param name="in_StId_csicp_ff112_C026_naoProtestar">Valor do código "Não Protestar".</param>
        /// <param name="in_StId_csicp_ff112_C026_negativacaoSemProtesto">Valor do código "Negativação sem Protesto".</param>
        /// <param name="in_StId_csicp_ff112_C026_cancelamentoProtestoAutomatico">Valor do código "Cancelamento Protesto Automático".</param>
        /// <returns>0 ou o prazo de protesto.</returns>
        private static int ObterPrazoProtestoOuZero(
            int in_ff112codgProtesto,
            int in_ff112_prazoProtesto,
            int in_StId_csicp_ff112_C026_naoProtestar,
            int in_StId_csicp_ff112_C026_negativacaoSemProtesto,
            int in_StId_csicp_ff112_C026_cancelamentoProtestoAutomatico)
        {
            if (in_ff112codgProtesto == in_StId_csicp_ff112_C026_naoProtestar ||
                in_ff112codgProtesto == in_StId_csicp_ff112_C026_negativacaoSemProtesto ||
                in_ff112codgProtesto == in_StId_csicp_ff112_C026_cancelamentoProtestoAutomatico)
                return 0;

            return in_ff112_prazoProtesto;
        }

        private async Task<(string? authToken, string? chaveAPL)> GetBB001AuthToken(ReturnCnab returnCnab)
        {

            //autentica no Banco do Brasil
            var value = await _appDbContext.E9ACSICP_BB001s
                .Where(e => e.Id == returnCnab.CSICP_FF112Completo.Ff112.Ff112Filialid)
                .Select(e => new
                {
                    e.Bb001AutToken,
                    e.Bb001ChaveApl
                })
                .FirstOrDefaultAsync();
            return (value?.Bb001AutToken, value?.Bb001ChaveApl);
        }


        private static bool EhProducao(int? in_cnab_ff112_cnabID, int in_StID_csicp_ff112_cnab_APIPRD)
        {
            return in_cnab_ff112_cnabID == in_StID_csicp_ff112_cnab_APIPRD;
        }

        private async Task<RetornoCriaBoleto> CS51_Cria_Boleto(
            string in_token,
            CriaBoletoRequest criaBoletoReq,
            string in_Chave_Aut_APP)
        {
            var apiCriaBoletoResponse = await _refitBancoBrasil.IncluiBoletoBancario(
                             gwdevappkey: in_Chave_Aut_APP,
                             authorization: "Bearer " + in_token,
                             requisicao: criaBoletoReq
                             );

            var in_retornoCriaBoleto = apiCriaBoletoResponse.Content
                ?? throw new Exception("Erro ao criar boleto no Banco do Brasil: " + apiCriaBoletoResponse.Error?.Content);

            return in_retornoCriaBoleto;
        }

      

        private async Task CS51_Registrar_Finalizacao(string in_ff102ID, int tenantID, int in_StID_csicp_ff120_trackApi_FinalizadoEnvio)
        {
            var ff120_Final = new CSICP_FF120
            {
                TenantId = tenantID,
                Ff102Id = in_ff102ID,
                Ff120Datahora = DateTime.UtcNow.ToLocalTime(),
                Ff120TrilhaapiId = in_StID_csicp_ff120_trackApi_FinalizadoEnvio,
                Ff120Texto = "ERP Finalizando Envio.",
                Ff102 = null
            };
            _appDbContext.Add(ff120_Final);
            await _appDbContext.SaveChangesAsync();
        }

        private async Task CS51_Registrar_Envio(string in_ff102ID, int tenantID)
        {
            var in_StID_csicp_ff120_trackApi_Enviando
                = await _staticaLabelRepository.csicp_ff120_trackApi(Entities.FF120_TRACKAPI.Enviando);
            var ff120_Envia = new CSICP_FF120
            {
                TenantId = tenantID,
                Ff102Id = in_ff102ID,
                Ff120Datahora = DateTime.UtcNow.ToLocalTime(),
                Ff120TrilhaapiId = in_StID_csicp_ff120_trackApi_Enviando,
                Ff120Texto = "ERP enviando Boleto." + "000"
            };
            _appDbContext.Add(ff120_Envia);
            await _appDbContext.SaveChangesAsync();
        }


        class ReturnCnab
        {
            public RepoDtoCfgCnabCompleto CSICP_FF112Completo { get; set; } = null!;
            public CSICP_Bb006Banco CSICP_BB006Banco { get; set; } = null!;
            public CSICP_FF112Faixa CSICP_FF112Faixa { get; set; } = null!;
            public CNAB_STATUS Status { get; set; } = CNAB_STATUS.ERRO;
        }
        private async Task<ReturnCnab> CS_Ret_CfgCNAB(string in_agenteCobradorID)
        {
            CSICP_Bb006Banco ret_GetBanco = await CS51_Recupera_Banco();
            RepoDtoCfgCnabCompleto getCfgCNAB = await CS51_Recupera_CfgCNAB(in_agenteCobradorID);
            CSICP_FF112Faixa faixa = await _appDbContext.OsusrE9aCsicpFf112Faixas
               .Where(f => f.Ff112Id == getCfgCNAB.Ff112.Id && f.Ff112Isactive == true)
               .FirstOrDefaultAsync() ?? throw new KeyNotFoundException("CSICP_FF112Faixa não encontrada!");

            return new ReturnCnab
            {
                CSICP_FF112Completo = getCfgCNAB,
                CSICP_BB006Banco = ret_GetBanco,
                CSICP_FF112Faixa = faixa,
                Status = CNAB_STATUS.OK
            };
        }

        private async Task<RepoDtoCfgCnabCompleto> CS51_Recupera_CfgCNAB(string in_agCobradorID)
        {
            var tipoOperacaoID = await _staticaLabelRepository.GetIDStaticaByLabel<OsusrE9aCsicpFf112G028>(Entities.FF112_G028.R);
            return await (from ff112 in _appDbContext.OsusrE9aCsicpFf112s
                          join ff113 in _appDbContext.OsusrE9aCsicpFf113s on ff112.Id equals ff113.Ff113RefConfBanco into ff113Join
                          from ff113 in ff113Join.DefaultIfEmpty()
                          join ff112_c026 in _appDbContext.OsusrE9aCsicpFf112C026s on ff112.Ff112Codgprotesto equals ff112_c026.Id into ff112_c026Join
                          from ff112_c026 in ff112_c026Join.DefaultIfEmpty()
                          join ff112_c028 in _appDbContext.OsusrE9aCsicpFf112C028s on ff112.Ff112Codgbaixadevolucao equals ff112_c028.Id into ff112_c028Join
                          from ff112_c028 in ff112_c028Join.DefaultIfEmpty()
                          join ff112_c006 in _appDbContext.OsusrE9aCsicpFf112C006s on ff112.Ff112Carteira equals ff112_c006.Id into ff112_c006Join
                          from ff112_c006 in ff112_c006Join.DefaultIfEmpty()
                          join ff112_c029 in _appDbContext.OsusrE9aCsicpFf112C029s on ff112.Ff112IdentAceite equals ff112_c029.Id into ff112_c029Join
                          from ff112_c029 in ff112_c029Join.DefaultIfEmpty()
                          join ff112_c007 in _appDbContext.OsusrE9aCsicpFf112C007s on ff112.Ff112Cadastramento equals ff112_c007.Id into ff112_c007Join
                          from ff112_c007 in ff112_c007Join.DefaultIfEmpty()
                          join ff112_c008 in _appDbContext.OsusrE9aCsicpFf112C008s on ff112.Ff112Documento equals ff112_c008.Id into ff112_c008Join
                          from ff112_c008 in ff112_c008Join.DefaultIfEmpty()
                          join ff112_c004 in _appDbContext.OsusrE9aCsicpFf112C004s on ff113.Ff113Codgmovtoremessa equals ff112_c004.Id into ff112_c004Join
                          from ff112_c004 in ff112_c004Join.DefaultIfEmpty()
                          join ff112_c009 in _appDbContext.OsusrE9aCsicpFf112C009s on ff112.Ff112Emissaobloqueto equals ff112_c009.Id into ff112_c009Join
                          from ff112_c009 in ff112_c009Join.DefaultIfEmpty()
                          join ff112_c010 in _appDbContext.OsusrE9aCsicpFf112C010s on ff112.Ff112Distribuicaobloqueto equals ff112_c010.Id into ff112_c010Join
                          from ff112_c010 in ff112_c010Join.DefaultIfEmpty()
                          join ff112_g005 in _appDbContext.OsusrE9aCsicpFf112G005s on ff112.Ff112Tipoinscricao equals ff112_g005.Id into ff112_g005Join
                          from ff112_g005 in ff112_g005Join.DefaultIfEmpty()
                          join ff112_g025 in _appDbContext.OsusrE9aCsicpFf112G025s on ff112.Ff112Tiposervico equals ff112_g025.Id into ff112_g025Join
                          from ff112_g025 in ff112_g025Join.DefaultIfEmpty()
                          join ff102_c021 in _appDbContext.OsusrE9aCsicpFf102C021s on ff112.Ff112CnabCodDesconto equals ff102_c021.Id into ff102_c021Join
                          from ff102_c021 in ff102_c021Join.DefaultIfEmpty()
                          join ff102_g073 in _appDbContext.OsusrE9aCsicpFf102G073s on ff112.Ff112CnabCodMulta equals ff102_g073.Id into ff102_g073Join
                          from ff102_g073 in ff102_g073Join.DefaultIfEmpty()
                          join ff102_c018 in _appDbContext.OsusrE9aCsicpFf102C018s on ff112.Ff112CnabCodJurosMora equals ff102_c018.Id into ff102_c018Join
                          from ff102_c018 in ff102_c018Join.DefaultIfEmpty()
                          join ff112_org_neg in _appDbContext.OsusrE9aCsicpFf112OrgNegs on ff112.Ff112OrgaoNeg equals ff112_org_neg.Id into ff112_org_negJoin
                          from ff112_org_neg in ff112_org_negJoin.DefaultIfEmpty()
                          where ff112.Ff112Bancoid == in_agCobradorID
                             && ff112.Ff112Tipooperacao == tipoOperacaoID
                             && ff112.IsActive == true
                          select new RepoDtoCfgCnabCompleto
                          {
                              Ff112 = ff112,
                              Ff113 = ff113,
                              Ff112_C026 = ff112_c026,
                              Ff112_C028 = ff112_c028,
                              Ff112_C006 = ff112_c006,
                              Ff112_C029 = ff112_c029,
                              Ff112_C007 = ff112_c007,
                              Ff112_C008 = ff112_c008,
                              Ff112_C004 = ff112_c004,
                              Ff112_C009 = ff112_c009,
                              Ff112_C010 = ff112_c010,
                              Ff112_G005 = ff112_g005,
                              Ff112_G025 = ff112_g025,
                              Ff102_C021 = ff102_c021,
                              Ff102_G073 = ff102_g073,
                              Ff102_C018 = ff102_c018,
                              Ff112_Org_Neg = ff112_org_neg
                          })
                   .FirstOrDefaultAsync() ?? throw new KeyNotFoundException("getCfgCNAB não encontrado!");
        }

        private async Task<CSICP_Bb006Banco> CS51_Recupera_Banco()
        {
            return await (from banco in _appDbContext.OsusrE9aCsicpBb006Bancos
                          join bb006 in _appDbContext.OsusrE9aCsicpBb006s
                              on banco.Id equals bb006.Bb006BancoId into joined
                          from bb006 in joined.DefaultIfEmpty()
                          where bb006 == null
                          select new CSICP_Bb006Banco
                          {
                              Id = banco.Id,
                              Nrobanco = banco.Nrobanco,
                              Nomedobanco = banco.Nomedobanco,
                              Paginanainternet = banco.Paginanainternet,
                              Dvbanco = banco.Dvbanco,
                              CSICP_BB006Banco = bb006
                          })
                    .FirstOrDefaultAsync() ?? throw new KeyNotFoundException("CSICP_Bb006Banco não encontrado!");
        }

        private void CS_Atualiza_Titulos(CSICP_FF102 in_ff102ForUpdate, ReturnCnab in_returnCnab)
        {
            ReturnCalcJurosMulta returnCalcJurosMulta = CS_Calc_Juros_multa_Tit(in_returnCnab, in_ff102ForUpdate);
            in_ff102ForUpdate.Ff102CnabCodMulta = returnCalcJurosMulta.CnabCodMulta;
            in_ff102ForUpdate.Ff102CnabCodJurosMora = returnCalcJurosMulta.CnabCodJurosMora;
            in_ff102ForUpdate.Ff102CnabCodDesconto = returnCalcJurosMulta.CnabCodDesconto;
            in_ff102ForUpdate.Ff102cpValorMulta = returnCalcJurosMulta.ValorMulta;
            in_ff102ForUpdate.Ff102PercMulta = returnCalcJurosMulta.PercMulta;
            in_ff102ForUpdate.Ff102cpValorJurosDia = returnCalcJurosMulta.ValorJuros;
            in_ff102ForUpdate.Ff102PercJurosAtr = returnCalcJurosMulta.PercJuros;
            in_ff102ForUpdate.Ff102Dtimestamp = DateTime.UtcNow.ToLocalTime();
        }

        private decimal CS51_At_Seq_Remessa(CSICP_FF112Faixa in_ff112FaixaForUpdate)
        {
            if (in_ff112FaixaForUpdate.Ff112NossonroAtual == 0 || in_ff112FaixaForUpdate.Ff112NossonroAtual >= in_ff112FaixaForUpdate.Ff112Avisonossonro)
                in_ff112FaixaForUpdate.Ff112NossonroAtual = 1;
            else
                in_ff112FaixaForUpdate.Ff112NossonroAtual++;
            return in_ff112FaixaForUpdate.Ff112NossonroAtual ?? 0;
        }

        private static string Gera_Hash() => StringUtils.GeneratePassword(15, true);


        class PrmAtualizaTitulo
        {
            public CSICP_FF102 in_ff102ForUpdate { get; set; } = null!;
            public RetornoCriaBoleto in_retornoCriaBoleto { get; set; } = null!;
            public string in_hashFF102 { get; set; } = null!;
            public decimal in_valorJuros { get; set; }
            public decimal in_valorMulta { get; set; }
            public string? in_tipoCobrancaID { get; set; }
            public int in_apiID { get; set; }
            public int in_StID_csicp_ff120_trackApi_FinalizadoEnvio { get; set; }
        }
        private void CS52_Atualiza_Titulo(PrmAtualizaTitulo in_prmAtualizaTitulo)
        {
            var jurosDia = 0;
            var valorMulta = 0;

            in_prmAtualizaTitulo.in_ff102ForUpdate.Ff102HashId = in_prmAtualizaTitulo.in_hashFF102;
            in_prmAtualizaTitulo.in_ff102ForUpdate.Ff102NoTitulocliente = in_prmAtualizaTitulo.in_retornoCriaBoleto.Numero;
            in_prmAtualizaTitulo.in_ff102ForUpdate.Ff102CodigoBarras = in_prmAtualizaTitulo.in_retornoCriaBoleto.CodigoBarraNumerico;
            in_prmAtualizaTitulo.in_ff102ForUpdate.Ff102Linhadigital = in_prmAtualizaTitulo.in_retornoCriaBoleto.LinhaDigitavel;
            in_prmAtualizaTitulo.in_ff102ForUpdate.Ff102ApiId = in_prmAtualizaTitulo.in_apiID;
            in_prmAtualizaTitulo.in_ff102ForUpdate.Ff102PixQrcode = in_prmAtualizaTitulo.in_retornoCriaBoleto.CS_QrCode.Emv;
            in_prmAtualizaTitulo.in_ff102ForUpdate.Ff102Txid = in_prmAtualizaTitulo.in_retornoCriaBoleto.CS_QrCode.TxId;

            in_prmAtualizaTitulo.in_ff102ForUpdate.Ff102cpValorJurosDia = in_prmAtualizaTitulo.in_valorJuros > 0
                    ? in_prmAtualizaTitulo.in_valorJuros
                    : Math.Round(in_prmAtualizaTitulo.in_ff102ForUpdate.Ff102VlLiqTitulo * jurosDia / 100m, 2);

            in_prmAtualizaTitulo.in_ff102ForUpdate.Ff102cpValorMulta = in_prmAtualizaTitulo.in_valorMulta > 0
                        ? in_prmAtualizaTitulo.in_valorMulta
                        : valorMulta;

            in_prmAtualizaTitulo.in_ff102ForUpdate.Ff102Tipocobrancaid = in_prmAtualizaTitulo.in_tipoCobrancaID;
            in_prmAtualizaTitulo.in_ff102ForUpdate.Ff102Observacao = in_prmAtualizaTitulo.in_ff102ForUpdate.Ff102Observacao + " " + in_prmAtualizaTitulo.in_retornoCriaBoleto.CS_QrCode.Url;
            in_prmAtualizaTitulo.in_ff102ForUpdate.Ff102NoTitulocliente = in_prmAtualizaTitulo.in_retornoCriaBoleto.Numero;
            in_prmAtualizaTitulo.in_ff102ForUpdate.Ff102TrilhaApiid = in_prmAtualizaTitulo.in_StID_csicp_ff120_trackApi_FinalizadoEnvio;

        }


        class ReturnCalcJurosMulta
        {
            public decimal ValorJuros { get; set; }
            public decimal PercJuros { get; set; }
            public decimal ValorMulta { get; set; }
            public decimal PercMulta { get; set; }
            public int CnabCodMulta { get; set; }
            public int CnabCodJurosMora { get; set; }
            public int CnabCodDesconto { get; set; }
        }
        private ReturnCalcJurosMulta CS_Calc_Juros_multa_Tit(ReturnCnab in_returnCnab, CSICP_FF102 in_ff102)
        {
            ReturnCalcJurosMulta returnCalcJurosMulta = new ReturnCalcJurosMulta();
            decimal percMulta = in_returnCnab.CSICP_FF112Completo?.Ff112?.Ff112PercMulta ?? 0m;

            if (in_returnCnab.CSICP_FF112Completo?.Ff102_G073?.Conteudo == "2")
                returnCalcJurosMulta.ValorMulta = percMulta * in_ff102.Ff102VlLiqTitulo != 0m
                ? Math.Round(percMulta * in_ff102.Ff102VlLiqTitulo / 100m, 2)
                : 0m;
            else
                returnCalcJurosMulta.ValorMulta = in_returnCnab?.CSICP_FF112Completo?.Ff112.Ff112ValorMulta ?? 0m;

            returnCalcJurosMulta.PercMulta = in_returnCnab?.CSICP_FF112Completo?.Ff112.Ff112PercMulta ?? 0m;

            returnCalcJurosMulta.ValorJuros =
                (in_returnCnab?.CSICP_FF112Completo?.Ff112?.Ff112PercJuros ?? 0m) * in_ff102.Ff102VlLiqTitulo == 0m
                ? 0m
                : Math.Round(
                    (in_returnCnab?.CSICP_FF112Completo?.Ff112?.Ff112PercJuros ?? 0m) * in_ff102.Ff102VlLiqTitulo / 100m / 30m,
                    2
                );

            returnCalcJurosMulta.CnabCodMulta = in_returnCnab?.CSICP_FF112Completo?.Ff112.Ff112CnabCodMulta ?? 0;
            returnCalcJurosMulta.CnabCodJurosMora = in_returnCnab?.CSICP_FF112Completo?.Ff112.Ff112CnabCodJurosMora ?? 0;
            returnCalcJurosMulta.CnabCodDesconto = in_returnCnab?.CSICP_FF112Completo?.Ff112.Ff112CnabCodDesconto ?? 0;
            return returnCalcJurosMulta;
        }
    }
}
