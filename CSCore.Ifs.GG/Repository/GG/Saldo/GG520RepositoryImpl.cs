using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.CS_QueryFilters.Specific;
using CSCore.Domain.Interfaces.GG.Saldo;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG.Saldo
{
    public class GG520RepositoryImpl(
        AppDbContext appDbContext,
        IGenerateProtocolo generateProtocolo,
        ICS_GenerateId cS_GenerateId) : RepositorioBaseImpl<CSICP_GG520>(appDbContext), IGG520Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly IGenerateProtocolo _generateProtocolo = generateProtocolo;
        private readonly ICS_GenerateId _cS_GenerateId = cS_GenerateId;

        public async Task<string> GeraSaldo(GG520GeraSaldoParametros gG520GeraSaldoParametros)
        {
            var saldoParaGerar = await GeraSaldoBase(gG520GeraSaldoParametros);
            _appDbContext.Add(saldoParaGerar);
            await _appDbContext.SaveChangesAsync();
            return saldoParaGerar.Id;
        }

        //isso daqui é usado ao criar um kardex
        public async Task<CSICP_GG520> GeraSaldoSemCommit(GG520GeraSaldoParametros gG520GeraSaldoParametros)
        {
            var saldoParaGerar = await GeraSaldoBase(gG520GeraSaldoParametros);
            return saldoParaGerar;
        }


        //produto-por-codigo-barra
        public async Task<(IEnumerable<CSICP_GG520>, IEnumerable<CSICP_GG520>)> PesquisProdutoPorCodigo(
            int in_tenant, string in_almoxID, string? in_almoxIDSaida, string in_estabID, int n_codBarra)
        {
            IQueryable<CSICP_GG520> query = GetQueryGG520ParaProdutoPorCodigo(in_tenant, in_almoxID, in_estabID, n_codBarra);

            List<CSICP_GG520> Saldos_Almoxarifado1 = await query.ToListAsync();
            List<CSICP_GG520> Saldos_Almoxarifado2 = [];

            if (in_almoxIDSaida != null)
            {
                IQueryable<CSICP_GG520> query_lista_Saida
                    = GetQueryGG520ParaProdutoPorCodigo(in_tenant, in_almoxIDSaida, in_estabID, n_codBarra);
                Saldos_Almoxarifado2 = await query_lista_Saida.ToListAsync();
            }

            return (Saldos_Almoxarifado1, Saldos_Almoxarifado2);
        }


        public async Task<IEnumerable<CSICP_GG520>> GetListParaProdutosComKardexESaldos(
            string Kardex_ID, int tenant)
        {
            var query = from _gg520 in _appDbContext.OsusrE9aCsicpGg520s

                        join _gg001 in _appDbContext.CSICP_GG001s
                        on _gg520.Gg520Almoxid equals _gg001.Id into _gg001Join
                        from _gg001 in _gg001Join.DefaultIfEmpty()

                        where _gg520.TenantId == tenant
                        where _gg520.Gg520KardexId == Kardex_ID

                        select new CSICP_GG520
                        {
                            TenantId = _gg520.TenantId,
                            Id = _gg520.Id,
                            Gg520Saldo = _gg520.Gg520Saldo,
                            Gg520KardexId = _gg520.Gg520KardexId,
                            Gg520Almoxid = _gg520.Gg520Almoxid,
                            Gg520Descricaosaldo = _gg520.Gg520Descricaosaldo,
                            Gg520NsNumerosaldo = _gg520.Gg520NsNumerosaldo,
                            Gg520Filialid = _gg520.Gg520Filialid,
                            Gg520Filial = _gg520.Gg520Filial,
                            Gg520Produto = _gg520.Gg520Produto,
                            Gg520Lote = _gg520.Gg520Lote,
                            Gg520DescricaoLote = _gg520.Gg520DescricaoLote,
                            Gg520Ultinventario = _gg520.Gg520Ultinventario,
                            Gg520ItemEmContagem = _gg520.Gg520ItemEmContagem,
                            Gg520Ultrecebimento = _gg520.Gg520Ultrecebimento,
                            Gg520Qtdultrecebto = _gg520.Gg520Qtdultrecebto,
                            Gg520UltimaVenda = _gg520.Gg520UltimaVenda,
                            Gg520QtdeUltVenda = _gg520.Gg520QtdeUltVenda,
                            Gg520DataValidade = _gg520.Gg520DataValidade,
                            Gg520EstqMinimo = _gg520.Gg520EstqMinimo,
                            Gg520Estoquemaximo = _gg520.Gg520Estoquemaximo,
                            Gg520Superpromocao = _gg520.Gg520Superpromocao,
                            NavGG001Almox = _gg001 != null ? new CSICP_GG001
                            {
                                Gg001Codigoalmox = _gg001.Gg001Codigoalmox,
                                Gg001Descalmox = _gg001.Gg001Descalmox
                            } : null
                        };


            List<CSICP_GG520> CSICP_GG520List = await query.ToListAsync();
            return CSICP_GG520List;
        }


        private IQueryable<CSICP_GG520> GetQueryGG520ParaProdutoPorCodigo(int in_tenant, string in_almox_id, string in_estabID, int n_codBarra)
        {
            return from _gg520 in _appDbContext.OsusrE9aCsicpGg520s

                   join _gg008Kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes
                   on _gg520.Gg520KardexId equals _gg008Kdx.Gg008Kardexid into _gg008KdxJoin
                   from _gg008Kdx in _gg008KdxJoin.DefaultIfEmpty()

                   join _gg019Cod in _appDbContext.OsusrE9aCsicpGg019s
                   on _gg008Kdx.Gg008Produtoid equals _gg019Cod.Gg019Produtoid into _gg019CodJoin
                   from _gg019Cod in _gg019CodJoin.DefaultIfEmpty()

                   join _gg008 in _appDbContext.OsusrE9aCsicpGg008s
                   on _gg008Kdx.Gg008Produtoid equals _gg008.Id into _gg008Join
                   from _gg008 in _gg008Join.DefaultIfEmpty()

                   join _gg006 in _appDbContext.OsusrE9aCsicpGg006s
                   on _gg008.Gg008Marcaid equals _gg006.Id into _gg006Join
                   from _gg006 in _gg006Join.DefaultIfEmpty()

                   join _gg005 in _appDbContext.OsusrE9aCsicpGg005s
                   on _gg008.Gg008Artigoid equals _gg005.Id into _gg005Join
                   from _gg005 in _gg005Join.DefaultIfEmpty()

                   join _gg016Linha in _appDbContext.OsusrE9aCsicpGg016s
                   on _gg520.Gg520Gradelinhaid equals _gg016Linha.Id into _gg016Join
                   from _gg016Linha in _gg016Join.DefaultIfEmpty()

                   join _gg016Coluna in _appDbContext.OsusrE9aCsicpGg016s
                   on _gg520.Gg520Gradecolunaid equals _gg016Coluna.Id into _gg016ColunaJoin
                   from _gg016Coluna in _gg016ColunaJoin.DefaultIfEmpty()

                   join _gg004 in _appDbContext.OsusrE9aCsicpGg004s
                   on _gg008.Gg008Classeid equals _gg004.Id into _gg004Join
                   from _gg004 in _gg004Join.DefaultIfEmpty()

                   join _gg003 in _appDbContext.OsusrE9aCsicpGg003s
                   on _gg008.Gg008Grupoid equals _gg003.Id into _gg003Join
                   from _gg003 in _gg003Join.DefaultIfEmpty()


                   where _gg520.TenantId == in_tenant
                   where _gg520.Gg520Filialid == in_estabID
                   where _gg520.Gg520Almoxid == in_almox_id
                   where _gg520.Gg520Saldo > 0
                   where _gg019Cod.Gg019CodigoBarras == n_codBarra

                   select new CSICP_GG520
                   {
                       TenantId = _gg520.TenantId,
                       Id = _gg520.Id,
                       Gg520Saldo = _gg520.Gg520Saldo,
                       Gg520KardexId = _gg520.Gg520KardexId,
                       Gg520Almoxid = _gg520.Gg520Almoxid,
                       Gg520Descricaosaldo = _gg520.Gg520Descricaosaldo,
                       Gg520NsNumerosaldo = _gg520.Gg520NsNumerosaldo,
                       Gg520Filialid = _gg520.Gg520Filialid,
                       Gg520Filial = _gg520.Gg520Filial,
                       Gg520Produto = _gg520.Gg520Produto,
                       NavGG016Gradecoluna = _gg016Coluna != null ? new CSICP_GG016
                       {
                           TenantId = _gg016Coluna.TenantId,
                           Id = _gg016Coluna.Id,
                           Gg016Grade = _gg016Coluna.Gg016Grade,
                           Gg016Descricao = _gg016Coluna.Gg016Descricao,
                       } : null,
                       NavGG016Gradlinha = _gg016Linha != null ? new CSICP_GG016
                       {
                           TenantId = _gg016Linha.TenantId,
                           Id = _gg016Linha.Id,
                           Gg016Grade = _gg016Linha.Gg016Grade,
                           Gg016Descricao = _gg016Linha.Gg016Descricao,
                       } : null,
                       Nav_GG008Kardex = new CSICP_GG008Kdx
                       {
                           TenantId = _gg008Kdx.TenantId,
                           Gg008Kardexid = _gg008Kdx.Gg008Kardexid,
                           Gg008Filialid = _gg008Kdx.Gg008Filialid,
                           Gg008Produtoid = _gg008Kdx.Gg008Produtoid,
                           Gg008Codalmoxpadrao = _gg008Kdx.Gg008Codalmoxpadrao,
                           Gg008Codalmtransf = _gg008Kdx.Gg008Codalmtransf,
                           Gg008Almoxpadraoid = _gg008Kdx.Gg008Almoxpadraoid,
                           Gg008Almoxtransfid = _gg008Kdx.Gg008Almoxtransfid,
                           Gg008Unidade = _gg008Kdx.Gg008Unidade,
                           Gg008Unidsecundaria = _gg008Kdx.Gg008Unidsecundaria,
                           Gg008Unvendavarejoid = _gg008Kdx.Gg008Unvendavarejoid,
                           Gg008Uncompravarejoid = _gg008Kdx.Gg008Uncompravarejoid,
                           Gg008Unvendaatacadoid = _gg008Kdx.Gg008Unvendaatacadoid,
                           Gg008FatorConversao = _gg008Kdx.Gg008FatorConversao,
                           Gg008AliquotaIpi = _gg008Kdx.Gg008AliquotaIpi,
                           Gg008AliquotaIcms = _gg008Kdx.Gg008AliquotaIcms,
                           Gg008AliqIcmsReduzidaPdv = _gg008Kdx.Gg008AliqIcmsReduzidaPdv,
                           Gg008AliquotaIss = _gg008Kdx.Gg008AliquotaIss,
                           Gg008Margemlucrosai = _gg008Kdx.Gg008Margemlucrosai,
                           Gg008Margemlucroent = _gg008Kdx.Gg008Margemlucroent,
                           Gg008CalculaIrrf = _gg008Kdx.Gg008CalculaIrrf,
                           Gg008CalculaInss = _gg008Kdx.Gg008CalculaInss,
                           Gg008PercCsll = _gg008Kdx.Gg008PercCsll,
                           Gg008PercCofins = _gg008Kdx.Gg008PercCofins,
                           Gg008PercPis = _gg008Kdx.Gg008PercPis,
                           Gg008IcmsPauta = _gg008Kdx.Gg008IcmsPauta,
                           Gg008IpiPauta = _gg008Kdx.Gg008IpiPauta,
                           Gg008Qtdpedidocompra = _gg008Kdx.Gg008Qtdpedidocompra,
                           Gg008EstoqueMinimo = _gg008Kdx.Gg008EstoqueMinimo,
                           Gg008EstoqueMaximo = _gg008Kdx.Gg008EstoqueMaximo,
                           Gg008TempoReposicao = _gg008Kdx.Gg008TempoReposicao,
                           Gg008PontoPedido = _gg008Kdx.Gg008PontoPedido,
                           Gg008LoteEconomico = _gg008Kdx.Gg008LoteEconomico,
                           Gg008GrauAtendimento = _gg008Kdx.Gg008GrauAtendimento,
                           Gg008PercTolerancia = _gg008Kdx.Gg008PercTolerancia,
                           Gg008Abc = _gg008Kdx.Gg008Abc,
                           Gg008PercComissao = _gg008Kdx.Gg008PercComissao,
                           Gg008DataFabricacao = _gg008Kdx.Gg008DataFabricacao,
                           Gg008DataValidade = _gg008Kdx.Gg008DataValidade,
                           Gg008DiasValidade = _gg008Kdx.Gg008DiasValidade,
                           Gg008CustoMedio = _gg008Kdx.Gg008CustoMedio,
                           Gg008PrecoReposicao = _gg008Kdx.Gg008PrecoReposicao,
                           Gg008PercDescItem = _gg008Kdx.Gg008PercDescItem,
                           Gg008Prcpromocional = _gg008Kdx.Gg008Prcpromocional,
                           Gg008QtdPromocional = _gg008Kdx.Gg008QtdPromocional,
                           Gg008FatorLucro = _gg008Kdx.Gg008FatorLucro,
                           Gg008PrcVendavarejo = _gg008Kdx.Gg008PrcVendavarejo,
                           Gg008PrcVndMercado = _gg008Kdx.Gg008PrcVndMercado,
                           Gg008Ultreajprcvenda = _gg008Kdx.Gg008Ultreajprcvenda,
                           Gg008PrecoVendaLiq = _gg008Kdx.Gg008PrecoVendaLiq,
                           Gg008Vlrmargemlucro = _gg008Kdx.Gg008Vlrmargemlucro,
                           Gg008Alteraprcvenda = _gg008Kdx.Gg008Alteraprcvenda,
                           Gg008PrecoCusto = _gg008Kdx.Gg008PrecoCusto,
                           Gg008Ultreajprccusto = _gg008Kdx.Gg008Ultreajprccusto,
                           Gg008PrecoCustoReal = _gg008Kdx.Gg008PrecoCustoReal,
                           Gg008CentroCusto = _gg008Kdx.Gg008CentroCusto,
                           Gg008Ccustoid = _gg008Kdx.Gg008Ccustoid,
                           Gg008ContaContabil = _gg008Kdx.Gg008ContaContabil,
                           Gg008ClasseContabil = _gg008Kdx.Gg008ClasseContabil,
                           Gg008FornecedorCanal = _gg008Kdx.Gg008FornecedorCanal,
                           Gg008Fornecedorpadrao = _gg008Kdx.Gg008Fornecedorpadrao,
                           Gg008Contaid = _gg008Kdx.Gg008Contaid,
                           Gg008Periodicidadeinv = _gg008Kdx.Gg008Periodicidadeinv,
                           Gg008ControlaSaldo = _gg008Kdx.Gg008ControlaSaldo,
                           Gg008ControleLote = _gg008Kdx.Gg008ControleLote,
                           Gg008ControleGrade = _gg008Kdx.Gg008ControleGrade,
                           Gg008Anuente = _gg008Kdx.Gg008Anuente,
                           Gg008Restricao = _gg008Kdx.Gg008Restricao,
                           Gg008Grupocomprasid = _gg008Kdx.Gg008Grupocomprasid,
                           Gg008Permsldnegativo = _gg008Kdx.Gg008Permsldnegativo,
                           Gg008Minutaautomatica = _gg008Kdx.Gg008Minutaautomatica,
                           Gg008Requisautomatica = _gg008Kdx.Gg008Requisautomatica,
                           Gg008DataDesativacao = _gg008Kdx.Gg008DataDesativacao,
                           Gg008Localizfixa = _gg008Kdx.Gg008Localizfixa,
                           Gg008Diversos = _gg008Kdx.Gg008Diversos,
                           Gg008AliqDifPis = _gg008Kdx.Gg008AliqDifPis,
                           Gg008AliqDifCofins = _gg008Kdx.Gg008AliqDifCofins,
                           Gg008EanTributavel = _gg008Kdx.Gg008EanTributavel,
                           Gg008Untributavelid = _gg008Kdx.Gg008Untributavelid,
                           Gg008FatorUnidade = _gg008Kdx.Gg008FatorUnidade,
                           Gg008ValorPis = _gg008Kdx.Gg008ValorPis,
                           Gg008ValorCofins = _gg008Kdx.Gg008ValorCofins,
                           Gg008IsActive = _gg008Kdx.Gg008IsActive,
                           Gg008TipoConversaoId = _gg008Kdx.Gg008TipoConversaoId,
                           Gg008TipoprazoId = _gg008Kdx.Gg008TipoprazoId,
                           Gg008TpContribuicaoId = _gg008Kdx.Gg008TpContribuicaoId,
                           Gg008RiControlequalidade = _gg008Kdx.Gg008RiControlequalidade,
                           Gg008AliquotaIrpj = _gg008Kdx.Gg008AliquotaIrpj,
                           Gg008RetencaoAliqInss = _gg008Kdx.Gg008RetencaoAliqInss,
                           Gg008RetencaoAliqIrrf = _gg008Kdx.Gg008RetencaoAliqIrrf,
                           Gg008DescontoSuframa = _gg008Kdx.Gg008DescontoSuframa,
                           Gg008Timestamp = _gg008Kdx.Gg008Timestamp,
                           Gg008Plucro = _gg008Kdx.Gg008Plucro,
                           Gg008IsctrlGondola = _gg008Kdx.Gg008IsctrlGondola,
                           Gg008Qmediaconsumo = _gg008Kdx.Gg008Qmediaconsumo,
                           Gg008Vmediaconsumo = _gg008Kdx.Gg008Vmediaconsumo,
                           Gg008Dtultprocle = _gg008Kdx.Gg008Dtultprocle,
                           Gg008VuncompraCmedio = _gg008Kdx.Gg008VuncompraCmedio,
                           Gg008VuncompraReposicao = _gg008Kdx.Gg008VuncompraReposicao,
                           Gg008VuncompraPrcvenda = _gg008Kdx.Gg008VuncompraPrcvenda,
                           Gg008VuncompraPrcmercado = _gg008Kdx.Gg008VuncompraPrcmercado,
                           Gg008VuncompraPrccusto = _gg008Kdx.Gg008VuncompraPrccusto,
                           Gg008VuncompraCustoreal = _gg008Kdx.Gg008VuncompraCustoreal,
                           Gg008VuncompraVlrmarglucro = _gg008Kdx.Gg008VuncompraVlrmarglucro,
                           Gg008Moedaid = _gg008Kdx.Gg008Moedaid,
                           Gg008Vmoeda = _gg008Kdx.Gg008Vmoeda,
                           Gg008Prcecommerce = _gg008Kdx.Gg008Prcecommerce,
                           Gg008Auditasn = _gg008Kdx.Gg008Auditasn,
                           Gg008Possuisaldo = _gg008Kdx.Gg008Possuisaldo,
                           Gg008Ultrecebimento = _gg008Kdx.Gg008Ultrecebimento,
                           Gg008Qtdultrecebto = _gg008Kdx.Gg008Qtdultrecebto,
                           Gg008UltimaVenda = _gg008Kdx.Gg008UltimaVenda,
                           Gg008QtdeUltVenda = _gg008Kdx.Gg008QtdeUltVenda,
                           Gg008TpcbarratribId = _gg008Kdx.Gg008TpcbarratribId,

                           NavGG008Produto = _gg008 != null ? new CSICP_GG008
                           {
                               TenantId = _gg520.TenantId,
                               Id = _gg008.Id,
                               Gg008Codgproduto = _gg008.Gg008Codgproduto,
                               Gg008Descreduzida = _gg008.Gg008Descreduzida,
                               NavMarcaProdutoGG006 = _gg006 != null ? new CSICP_GG006
                               {
                                   TenantId = _gg520.TenantId,
                                   Id = _gg006.Id,
                                   Gg006Descmarca = _gg006.Gg006Descmarca,
                                   Gg006Codigomarca = _gg006.Gg006Codigomarca,
                               } : null,
                               NavArtigoProdutoGG005 = _gg005 != null ? new CSICP_GG005
                               {
                                   TenantId = _gg520.TenantId,
                                   Id = _gg005.Id,
                                   Gg005Descartigo = _gg005.Gg005Descartigo,
                                   Gg005Codigoartigo = _gg005.Gg005Codigoartigo,
                               } : null,
                               NavClasseProdutoGG004 = _gg004 != null ? new CSICP_GG004
                               {
                                   TenantId = _gg520.TenantId,
                                   Id = _gg004.Id,
                                   Gg004Descclasse = _gg004.Gg004Descclasse,
                                   Gg004Codigoclasse = _gg004.Gg004Codigoclasse,
                               } : null,
                               NavGrupoProdutoGG003 = _gg003 != null ? new CSICP_GG003
                               {
                                   TenantId = _gg520.TenantId,
                                   Id = _gg003.Id,
                                   Gg003Descgrupo = _gg003.Gg003Descgrupo,
                                   Gg003Codigogrupo = _gg003.Gg003Codigogrupo,
                               } : null,

                           } : null
                       }
                   };
        }

        private async Task<CSICP_GG520> GeraSaldoBase(GG520GeraSaldoParametros gG520GeraSaldoParametros)
        {
            var query = from _gg001 in _appDbContext.CSICP_GG001s
                        where _gg001.TenantId == gG520GeraSaldoParametros.Tenant_ID
                        where _gg001.Id == gG520GeraSaldoParametros.gg001_almoxID
                        select new CSICP_GG001
                        {
                            Id = _gg001.Id,
                            Gg001Descnspadrao = _gg001.Gg001Descnspadrao,
                            Gg001Filialid = _gg001.Gg001Filialid,
                        };

            CSICP_GG001? almox = await query.FirstOrDefaultAsync();
            if (almox is null)
                throw new KeyNotFoundException("Erro ao tentar criar Saldo: Almoxarifado informado não existe no sistema!");

            if (almox.Gg001Filialid != gG520GeraSaldoParametros.bb001_filialID)
                throw new Exception("Erro ao tentar criar Saldo: Empresa/Filial do almoxarifado selecionado é diferente da empresa do produto para o qual está sendo gerado o saldo");


            if (gG520GeraSaldoParametros.prmNumeroSerie is null || gG520GeraSaldoParametros.prmNumeroSerie == 0)
            {
                decimal protocolo = await _generateProtocolo.Fcn_Protocolo15(gG520GeraSaldoParametros.bb001_filialID, "NS",gG520GeraSaldoParametros.Tenant_ID);
                gG520GeraSaldoParametros.prmNumeroSerie = protocolo;
            }

            var descricao = gG520GeraSaldoParametros.prmDescricao is null
                || gG520GeraSaldoParametros.prmDescricao == "" ? almox.Gg001Descnspadrao : gG520GeraSaldoParametros.prmDescricao;
            string id = _cS_GenerateId.GenerateUuId();
            CSICP_GG520 saldoParaGerar = new CSICP_GG520
            {
                Id = id,
                Gg520Filialid = gG520GeraSaldoParametros.bb001_filialID,
                Gg520Almoxid = gG520GeraSaldoParametros.gg001_almoxID,
                Gg520Saldo = 0,
                Gg520NsNumerosaldo = gG520GeraSaldoParametros.prmNumeroSerie,
                Gg520Descricaosaldo = descricao,
                Gg520KardexId = gG520GeraSaldoParametros.gg008_kdxID,
                Gg520Lote = gG520GeraSaldoParametros.lote,
                Gg520Sublote = gG520GeraSaldoParametros.subLote,
                Gg520DescricaoLote = gG520GeraSaldoParametros.descricaoLote,
                Gg520Gradelinhaid = gG520GeraSaldoParametros.gradeLinhaID,
                Gg520Gradecolunaid = gG520GeraSaldoParametros.gradeColunaID,
                Gg520Exibiremconsulta = gG520GeraSaldoParametros.prm_ExbirEmConsulta,
                Gg520Localizacaowms = gG520GeraSaldoParametros.prm_LocalizacaoWMS,
                Gg520Contaid = gG520GeraSaldoParametros.contaID,
                Gg520Usuarioid = gG520GeraSaldoParametros.usuarioID,
                Gg520Ispdv = gG520GeraSaldoParametros.isPDV,
                Gg520VfuturaSaldoid = gG520GeraSaldoParametros.Prm_SaldoId_Origem_VendaFutura,
                Gg520Timestamp = DateTime.UtcNow.ToLocalTime()
            };

            return saldoParaGerar;
        }

        public async Task<CSICP_GG520?> GetByIdAsync(string gg520_saldoID, int tenant)
        {
            IQueryable<CSICP_GG520> query = CriaQueryBase(tenant);

            CSICP_GG520? entidadeEncontrada = await query.FirstOrDefaultAsync(e => e.Id == gg520_saldoID);
            if (entidadeEncontrada is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);
            return entidadeEncontrada;
        }

        public async Task<(IEnumerable<CSICP_GG520>, int)> GetListAsync(
            string Produto_ID, string Kardex_ID, int tenant, int pageSize, int page, bool isActive)
        {
            IQueryable<CSICP_GG520> query = CriaQueryBase(tenant);
            query = query.Where(e => e.Gg520KardexId == Kardex_ID);
            query = query.Where(e => e.Gg520KardexId != null &&
                    _appDbContext.OsusrE9aCsicpGg008Kdxes
                        .Any(kdx => kdx.Gg008Kardexid == e.Gg520KardexId && kdx.Gg008Produtoid == Produto_ID));

            query = query.Where(e => e.Gg520Isactive == isActive);




            var queryCount = query;
            int count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);
            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_GG520> CriaQueryBase(int tenant)
        {
            return from gg520 in _appDbContext.OsusrE9aCsicpGg520s
                   where gg520.TenantId == tenant

                   join kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes
                     on gg520.Gg520KardexId equals kdx.Gg008Kardexid into kdxJoin
                   from kdx in kdxJoin.DefaultIfEmpty()

                   join cbr in _appDbContext.OsusrE9aCsicpGg019s
                     on gg520.Gg520CodbarrasId equals cbr.Id into cbrJoin
                   from cbr in cbrJoin.DefaultIfEmpty()

                   select new CSICP_GG520
                   {
                       TenantId = gg520.TenantId,
                       Id = gg520.Id,
                       Gg520Filialid = gg520.Gg520Filialid,
                       Gg520KardexId = gg520.Gg520KardexId,
                       Gg520Almoxid = gg520.Gg520Almoxid,
                       Gg520NsNumerosaldo = gg520.Gg520NsNumerosaldo,
                       Gg520Descricaosaldo = gg520.Gg520Descricaosaldo,
                       Gg520Filial = gg520.Gg520Filial,
                       Gg520Codalmoxarifado = gg520.Gg520Codalmoxarifado,
                       Gg520Produto = gg520.Gg520Produto,
                       Gg520Saldo = gg520.Gg520Saldo,
                       Gg520Qtdcomprometida = gg520.Gg520Qtdcomprometida,
                       Gg520QtdProducao = gg520.Gg520QtdProducao,
                       Gg520QtdEmpenho = gg520.Gg520QtdEmpenho,
                       Gg520QtdReserva = gg520.Gg520QtdReserva,
                       Gg520Qnpt = gg520.Gg520Qnpt,
                       Gg520Qtnp = gg520.Gg520Qtnp,
                       Gg520Ultinventario = gg520.Gg520Ultinventario,
                       Gg520Ultfechamento = gg520.Gg520Ultfechamento,
                       Gg520Qtdultfechamento = gg520.Gg520Qtdultfechamento,
                       Gg520ItemEmContagem = gg520.Gg520ItemEmContagem,
                       Gg520Proxinventario = gg520.Gg520Proxinventario,
                       Gg520Ultrecebimento = gg520.Gg520Ultrecebimento,
                       Gg520Qtdultrecebto = gg520.Gg520Qtdultrecebto,
                       Gg520UltimaVenda = gg520.Gg520UltimaVenda,
                       Gg520QtdeUltVenda = gg520.Gg520QtdeUltVenda,
                       Gg520Qtdpedidocompra = gg520.Gg520Qtdpedidocompra,
                       Gg520Lote = gg520.Gg520Lote,
                       Gg520Sublote = gg520.Gg520Sublote,
                       Gg520DescricaoLote = gg520.Gg520DescricaoLote,
                       Gg520Compraid = gg520.Gg520Compraid,
                       Gg520CodgFornecedor = gg520.Gg520CodgFornecedor,
                       Gg520Contaid = gg520.Gg520Contaid,
                       Gg520Usuarioid = gg520.Gg520Usuarioid,
                       Gg520DataFabricacao = gg520.Gg520DataFabricacao,
                       Gg520DataValidade = gg520.Gg520DataValidade,
                       Gg520DiasValidade = gg520.Gg520DiasValidade,
                       Gg520Docto = gg520.Gg520Docto,
                       Gg520Serie = gg520.Gg520Serie,
                       Gg520Compraentrada = gg520.Gg520Compraentrada,
                       Gg520Gradelinhaid = gg520.Gg520Gradelinhaid,
                       Gg520Gradecolunaid = gg520.Gg520Gradecolunaid,
                       Gg520Codggradelinha = gg520.Gg520Codggradelinha,
                       Gg520Codggradecoluna = gg520.Gg520Codggradecoluna,
                       Gg520EstqMinimo = gg520.Gg520EstqMinimo,
                       Gg520Estoquemaximo = gg520.Gg520Estoquemaximo,
                       Gg520Localizacaowms = gg520.Gg520Localizacaowms,
                       Gg520Superpromocao = gg520.Gg520Superpromocao,
                       Gg520Periodicidadeinv = gg520.Gg520Periodicidadeinv,
                       Gg520Exibiremconsulta = gg520.Gg520Exibiremconsulta,
                       Gg520Saldozerodesabautom = gg520.Gg520Saldozerodesabautom,
                       Gg520Permitetroca = gg520.Gg520Permitetroca,
                       Gg520Vbcstret = gg520.Gg520Vbcstret,
                       Gg520Vicmsstret = gg520.Gg520Vicmsstret,
                       Gg520Isactive = gg520.Gg520Isactive,
                       Gg520CodbarrasId = gg520.Gg520CodbarrasId,
                       Gg520Timestamp = gg520.Gg520Timestamp,
                       Gg520Ispdv = gg520.Gg520Ispdv,
                       Gg520Vicmssubstituto = gg520.Gg520Vicmssubstituto,
                       Gg520VfuturaSaldoid = gg520.Gg520VfuturaSaldoid,
                       NavGG001Almox = gg520.NavGG001Almox,
                       Gg520Codbarras = cbr ?? null,
                       NavGG016Gradecoluna = gg520.NavGG016Gradecoluna,
                       NavGG016Gradlinha = gg520.NavGG016Gradlinha,
                       Nav_GG008Kardex = kdx ?? null
                   };
        }

        public async Task<IEnumerable<CSICP_GG520>> GetListaSaldoPorKardex(string Kardex_ID, int tenant)
        {
            var query = from gg520 in appDbContext.OsusrE9aCsicpGg520s
                        where gg520.TenantId == tenant
                        where gg520.Gg520KardexId == Kardex_ID
                        where gg520.Gg520Isactive == true
                        select new CSICP_GG520
                        {
                            Id = gg520.Id,
                            Gg520Filialid = gg520.Gg520Filialid,
                            Gg520KardexId = gg520.Gg520KardexId,
                            Gg520Almoxid = gg520.Gg520Almoxid,
                            Gg520NsNumerosaldo = gg520.Gg520NsNumerosaldo,
                            Gg520Descricaosaldo = gg520.Gg520Descricaosaldo,
                            Gg520Ultinventario = gg520.Gg520Ultinventario,
                            Gg520ItemEmContagem = gg520.Gg520ItemEmContagem,
                            Gg520Ultrecebimento = gg520.Gg520Ultrecebimento,
                            Gg520Qtdultrecebto = gg520.Gg520Qtdultrecebto,
                            Gg520UltimaVenda = gg520.Gg520UltimaVenda,
                            Gg520QtdeUltVenda = gg520.Gg520QtdeUltVenda,
                            Gg520DescricaoLote = gg520.Gg520DescricaoLote,
                            Gg520DataValidade = gg520.Gg520DataValidade,
                            Gg520EstqMinimo = gg520.Gg520EstqMinimo,
                            Gg520Estoquemaximo = gg520.Gg520Estoquemaximo,
                            Gg520Superpromocao = gg520.Gg520Superpromocao,
                            Gg520Lote = gg520.Gg520Lote,
                            Gg520Saldo = gg520.Gg520Saldo
                        };

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<CSICP_GG520>> GetListSaldosCandidatos(
            int tenant, string? kardexId, string? almoxId, string? gg520Id_master)
        {
            if (kardexId is null) throw new KeyNotFoundException("Nav kardex nulo");
            if (almoxId is null) throw new KeyNotFoundException("Nav almox nulo");
            if (gg520Id_master is null) throw new KeyNotFoundException("Nav saldo nulo");
            var query = from GG520 in _appDbContext.OsusrE9aCsicpGg520s
                        where GG520.TenantId == tenant
                        where GG520.Gg520KardexId == kardexId
                        where GG520.Gg520Almoxid == almoxId
                        where GG520.Gg520NsNumerosaldo > 0
                        where GG520.Gg520Isactive == true
                        where GG520.Id != gg520Id_master

                        join GG008KDX in _appDbContext.OsusrE9aCsicpGg008Kdxes
                        on GG520.Gg520KardexId equals GG008KDX.Gg008Kardexid into GG008KDXJoin
                        from GG008KDX in GG008KDXJoin.DefaultIfEmpty()

                        join GG008 in _appDbContext.OsusrE9aCsicpGg008s
                        on GG008KDX.Gg008Produtoid equals GG008.Id into GG008Join
                        from GG008 in GG008Join.DefaultIfEmpty()

                        select new CSICP_GG520
                        {
                            Id = GG520.Id,
                            TenantId = GG520.TenantId,
                            Gg520KardexId = GG520.Gg520KardexId,
                            Gg520Almoxid = GG520.Gg520Almoxid,
                            Gg520NsNumerosaldo = GG520.Gg520NsNumerosaldo,
                            Gg520Saldo = GG520.Gg520Saldo,
                            Gg520Descricaosaldo = GG520.Gg520Descricaosaldo,
                            Gg520DescricaoLote = GG520.Gg520DescricaoLote,
                            Nav_GG008Kardex = GG008KDX != null ? new CSICP_GG008Kdx
                            {
                                NavGG008Produto = GG008 != null ? new CSICP_GG008
                                {
                                    Id = GG008.Id,
                                    TenantId = GG008.TenantId,
                                    Gg008Codgproduto = GG008.Gg008Codgproduto,
                                    Gg008Descreduzida = GG008.Gg008Descreduzida,
                                } : null,
                            } : null,
                        };
            return await query.ToListAsync();
        }



    }
}


