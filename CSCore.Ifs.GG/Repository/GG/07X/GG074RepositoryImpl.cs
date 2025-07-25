using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.Interfaces.GG._07X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._07X
{
    public class GG074RepositoryImpl(AppDbContext appDbContext) 
        : RepositorioBaseImpl<CSICP_GG074>(appDbContext, "Gg074Id"), IGG074Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG074?> GetByIdAsync(int tenant, long idGG073)
        {
            IQueryable<CSICP_GG074> query = CriaQueryBase(tenant);
            query = query.Where(e => e.Gg074Id == idGG073);

            CSICP_GG074? csicpGg030Entity = await query.FirstOrDefaultAsync();

            return csicpGg030Entity;
        }


        public async Task<(IEnumerable<CSICP_GG074>, int)> GetListAsync(int tenant, string? GG073_ID, int pageSize, int page)
        {
            IQueryable<CSICP_GG074> query = CriaQueryBase(tenant);
            if (GG073_ID is not null)
                query = query.Where(e => e.Gg073Id == GG073_ID);

            query = query.PaginacaoNoBanco(page, pageSize);

            int count = query.GetCountTotal();

            List<CSICP_GG074> listaCSICP_GG074 = await query.ToListAsync();
            return (listaCSICP_GG074, count);
        }

        private IQueryable<CSICP_GG074> CriaQueryBase(int tenant)
        {
            IQueryable<CSICP_GG074> query = from _CSICP_GG074 in _appDbContext.OsusrE9aCsicpGg074s
                                            where _CSICP_GG074.TenantId == tenant


                                            join _CSICP_GG073 in _appDbContext.OsusrE9aCsicpGg073s
                                            on _CSICP_GG074.Gg073Id equals _CSICP_GG073.Gg073Id into _CSICP_GG073Join
                                            from _CSICP_GG073 in _CSICP_GG073Join.DefaultIfEmpty()

                                            join _gg008kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes
                                            on _CSICP_GG074.Gg074KardexId equals _gg008kdx.Gg008Kardexid into _gg008kdxJoin
                                            from _gg008kdx in _gg008kdxJoin.DefaultIfEmpty()

                                            join _gg008 in _appDbContext.OsusrE9aCsicpGg008s
                                            on _gg008kdx.Gg008Produtoid equals _gg008.Id into _gg008Joined
                                            from _gg008 in _gg008Joined.DefaultIfEmpty()

                                            join _gg520 in _appDbContext.OsusrE9aCsicpGg520s
                                            on _CSICP_GG074.Gg074Saldoid equals _gg520.Id into _gg520Join
                                            from _gg520 in _gg520Join.DefaultIfEmpty()

                                            join _gg007 in _appDbContext.OsusrE9aCsicpGg007s
                                            on _CSICP_GG074.Gg074UnId equals _gg007.Id into _gg007Join
                                            from _gg007 in _gg007Join.DefaultIfEmpty()

                                            join _gg072stq in _appDbContext.OsusrE9aCsicpGg072Stqs
                                            on _CSICP_GG074.Gg074Statusestqid equals _gg072stq.Id into _gg072stqJoin
                                            from _gg072stq in _gg072stqJoin.DefaultIfEmpty()

                                            join _gg073tpmov in _appDbContext.OsusrE9aCsicpGg073Tmovs
                                            on _CSICP_GG074.Gg074Tmovid equals _gg073tpmov.Id into _gg073tpmovJoin
                                            from _gg073tpmov in _gg073tpmovJoin.DefaultIfEmpty()


                                            select new CSICP_GG074
                                            {
                                                TenantId = _CSICP_GG074.TenantId,
                                                Gg074Id = _CSICP_GG074.Gg074Id,
                                                Gg073Id = _CSICP_GG074.Gg073Id,
                                                Gg074Codbarrasalfa = _CSICP_GG074.Gg074Codbarrasalfa,
                                                Gg074KardexId = _CSICP_GG074.Gg074KardexId,
                                                Gg074Saldoid = _CSICP_GG074.Gg074Saldoid,
                                                Gg074UnId = _CSICP_GG074.Gg074UnId,
                                                Gg074Qtd = _CSICP_GG074.Gg074Qtd,
                                                Gg074Vunitario = _CSICP_GG074.Gg074Vunitario,
                                                Gg074Statusestqid = _CSICP_GG074.Gg074Statusestqid,
                                                Gg074Tmovid = _CSICP_GG074.Gg074Tmovid,
                                                Gg074Tproduto = _CSICP_GG074.Gg074Tproduto,
                                                NavGG007 = _gg007 != null ? new CSICP_GG007
                                                {
                                                    TenantId = _gg007.TenantId,
                                                    Id = _gg007.Id,
                                                    Gg007Filial = _gg007.Gg007Filial,
                                                    Gg007Filialid = _gg007.Gg007Filialid,
                                                    Gg007Unidade = _gg007.Gg007Unidade,
                                                    Gg007Descricao = _gg007.Gg007Descricao,
                                                    Gg007IsActive = _gg007.Gg007IsActive,
                                                    Gg007FormavendaId = _gg007.Gg007FormavendaId,
                                                    Gg007Qdecimais = _gg007.Gg007Qdecimais,
                                                } : null,
                                                NavGG008Kdx = _gg008kdx != null ? new CSICP_GG008Kdx
                                                {
                                                    TenantId = _gg008kdx.TenantId,
                                                    Gg008Kardexid = _gg008kdx.Gg008Kardexid,
                                                    Gg008Filialid = _gg008kdx.Gg008Filialid,
                                                    Gg008Produtoid = _gg008kdx.Gg008Produtoid,
                                                    Gg008Codalmoxpadrao = _gg008kdx.Gg008Codalmoxpadrao,
                                                    Gg008Codalmtransf = _gg008kdx.Gg008Codalmtransf,
                                                    Gg008Almoxpadraoid = _gg008kdx.Gg008Almoxpadraoid,
                                                    Gg008Almoxtransfid = _gg008kdx.Gg008Almoxtransfid,
                                                    Gg008Unidade = _gg008kdx.Gg008Unidade,
                                                    Gg008Unidsecundaria = _gg008kdx.Gg008Unidsecundaria,
                                                    Gg008Unvendavarejoid = _gg008kdx.Gg008Unvendavarejoid,
                                                    Gg008Uncompravarejoid = _gg008kdx.Gg008Uncompravarejoid,
                                                    Gg008Unvendaatacadoid = _gg008kdx.Gg008Unvendaatacadoid,
                                                    Gg008FatorConversao = _gg008kdx.Gg008FatorConversao,
                                                    Gg008AliquotaIpi = _gg008kdx.Gg008AliquotaIpi,
                                                    Gg008AliquotaIcms = _gg008kdx.Gg008AliquotaIcms,
                                                    Gg008AliqIcmsReduzidaPdv = _gg008kdx.Gg008AliqIcmsReduzidaPdv,
                                                    Gg008AliquotaIss = _gg008kdx.Gg008AliquotaIss,
                                                    Gg008Margemlucrosai = _gg008kdx.Gg008Margemlucrosai,
                                                    Gg008Margemlucroent = _gg008kdx.Gg008Margemlucroent,
                                                    Gg008CalculaIrrf = _gg008kdx.Gg008CalculaIrrf,
                                                    Gg008CalculaInss = _gg008kdx.Gg008CalculaInss,
                                                    Gg008PercCsll = _gg008kdx.Gg008PercCsll,
                                                    Gg008PercCofins = _gg008kdx.Gg008PercCofins,
                                                    Gg008PercPis = _gg008kdx.Gg008PercPis,
                                                    Gg008IcmsPauta = _gg008kdx.Gg008IcmsPauta,
                                                    Gg008IpiPauta = _gg008kdx.Gg008IpiPauta,
                                                    Gg008Qtdpedidocompra = _gg008kdx.Gg008Qtdpedidocompra,
                                                    Gg008EstoqueMinimo = _gg008kdx.Gg008EstoqueMinimo,
                                                    Gg008EstoqueMaximo = _gg008kdx.Gg008EstoqueMaximo,
                                                    Gg008TempoReposicao = _gg008kdx.Gg008TempoReposicao,
                                                    Gg008PontoPedido = _gg008kdx.Gg008PontoPedido,
                                                    Gg008LoteEconomico = _gg008kdx.Gg008LoteEconomico,
                                                    Gg008GrauAtendimento = _gg008kdx.Gg008GrauAtendimento,
                                                    Gg008PercTolerancia = _gg008kdx.Gg008PercTolerancia,
                                                    Gg008Abc = _gg008kdx.Gg008Abc,
                                                    Gg008PercComissao = _gg008kdx.Gg008PercComissao,
                                                    Gg008DataFabricacao = _gg008kdx.Gg008DataFabricacao,
                                                    Gg008DataValidade = _gg008kdx.Gg008DataValidade,
                                                    Gg008DiasValidade = _gg008kdx.Gg008DiasValidade,
                                                    Gg008CustoMedio = _gg008kdx.Gg008CustoMedio,
                                                    Gg008PrecoReposicao = _gg008kdx.Gg008PrecoReposicao,
                                                    Gg008PercDescItem = _gg008kdx.Gg008PercDescItem,
                                                    Gg008Prcpromocional = _gg008kdx.Gg008Prcpromocional,
                                                    Gg008QtdPromocional = _gg008kdx.Gg008QtdPromocional,
                                                    Gg008FatorLucro = _gg008kdx.Gg008FatorLucro,
                                                    Gg008PrcVendavarejo = _gg008kdx.Gg008PrcVendavarejo,
                                                    Gg008PrcVndMercado = _gg008kdx.Gg008PrcVndMercado,
                                                    Gg008Ultreajprcvenda = _gg008kdx.Gg008Ultreajprcvenda,
                                                    Gg008PrecoVendaLiq = _gg008kdx.Gg008PrecoVendaLiq,
                                                    Gg008Vlrmargemlucro = _gg008kdx.Gg008Vlrmargemlucro,
                                                    Gg008Alteraprcvenda = _gg008kdx.Gg008Alteraprcvenda,
                                                    Gg008PrecoCusto = _gg008kdx.Gg008PrecoCusto,
                                                    Gg008Ultreajprccusto = _gg008kdx.Gg008Ultreajprccusto,
                                                    Gg008PrecoCustoReal = _gg008kdx.Gg008PrecoCustoReal,
                                                    Gg008CentroCusto = _gg008kdx.Gg008CentroCusto,
                                                    Gg008Ccustoid = _gg008kdx.Gg008Ccustoid,
                                                    Gg008ContaContabil = _gg008kdx.Gg008ContaContabil,
                                                    Gg008ClasseContabil = _gg008kdx.Gg008ClasseContabil,
                                                    Gg008FornecedorCanal = _gg008kdx.Gg008FornecedorCanal,
                                                    Gg008Fornecedorpadrao = _gg008kdx.Gg008Fornecedorpadrao,
                                                    Gg008Contaid = _gg008kdx.Gg008Contaid,
                                                    Gg008Periodicidadeinv = _gg008kdx.Gg008Periodicidadeinv,
                                                    Gg008ControlaSaldo = _gg008kdx.Gg008ControlaSaldo,
                                                    Gg008ControleLote = _gg008kdx.Gg008ControleLote,
                                                    Gg008ControleGrade = _gg008kdx.Gg008ControleGrade,
                                                    Gg008Anuente = _gg008kdx.Gg008Anuente,
                                                    Gg008Restricao = _gg008kdx.Gg008Restricao,
                                                    Gg008Grupocomprasid = _gg008kdx.Gg008Grupocomprasid,
                                                    Gg008Permsldnegativo = _gg008kdx.Gg008Permsldnegativo,
                                                    Gg008Minutaautomatica = _gg008kdx.Gg008Minutaautomatica,
                                                    Gg008Requisautomatica = _gg008kdx.Gg008Requisautomatica,
                                                    Gg008DataDesativacao = _gg008kdx.Gg008DataDesativacao,
                                                    Gg008Localizfixa = _gg008kdx.Gg008Localizfixa,
                                                    Gg008Diversos = _gg008kdx.Gg008Diversos,
                                                    Gg008AliqDifPis = _gg008kdx.Gg008AliqDifPis,
                                                    Gg008AliqDifCofins = _gg008kdx.Gg008AliqDifCofins,
                                                    Gg008EanTributavel = _gg008kdx.Gg008EanTributavel,
                                                    Gg008Untributavelid = _gg008kdx.Gg008Untributavelid,
                                                    Gg008FatorUnidade = _gg008kdx.Gg008FatorUnidade,
                                                    Gg008ValorPis = _gg008kdx.Gg008ValorPis,
                                                    Gg008ValorCofins = _gg008kdx.Gg008ValorCofins,
                                                    Gg008IsActive = _gg008kdx.Gg008IsActive,
                                                    Gg008TipoConversaoId = _gg008kdx.Gg008TipoConversaoId,
                                                    Gg008TipoprazoId = _gg008kdx.Gg008TipoprazoId,
                                                    Gg008TpContribuicaoId = _gg008kdx.Gg008TpContribuicaoId,
                                                    Gg008RiControlequalidade = _gg008kdx.Gg008RiControlequalidade,
                                                    Gg008AliquotaIrpj = _gg008kdx.Gg008AliquotaIrpj,
                                                    Gg008RetencaoAliqInss = _gg008kdx.Gg008RetencaoAliqInss,
                                                    Gg008RetencaoAliqIrrf = _gg008kdx.Gg008RetencaoAliqIrrf,
                                                    Gg008DescontoSuframa = _gg008kdx.Gg008DescontoSuframa,
                                                    Gg008Timestamp = _gg008kdx.Gg008Timestamp,
                                                    Gg008Plucro = _gg008kdx.Gg008Plucro,
                                                    Gg008IsctrlGondola = _gg008kdx.Gg008IsctrlGondola,
                                                    Gg008Qmediaconsumo = _gg008kdx.Gg008Qmediaconsumo,
                                                    Gg008Vmediaconsumo = _gg008kdx.Gg008Vmediaconsumo,
                                                    Gg008Dtultprocle = _gg008kdx.Gg008Dtultprocle,
                                                    Gg008VuncompraCmedio = _gg008kdx.Gg008VuncompraCmedio,
                                                    Gg008VuncompraReposicao = _gg008kdx.Gg008VuncompraReposicao,
                                                    Gg008VuncompraPrcvenda = _gg008kdx.Gg008VuncompraPrcvenda,
                                                    Gg008VuncompraPrcmercado = _gg008kdx.Gg008VuncompraPrcmercado,
                                                    Gg008VuncompraPrccusto = _gg008kdx.Gg008VuncompraPrccusto,
                                                    Gg008VuncompraCustoreal = _gg008kdx.Gg008VuncompraCustoreal,
                                                    Gg008VuncompraVlrmarglucro = _gg008kdx.Gg008VuncompraVlrmarglucro,
                                                    Gg008Moedaid = _gg008kdx.Gg008Moedaid,
                                                    Gg008Vmoeda = _gg008kdx.Gg008Vmoeda,
                                                    Gg008Prcecommerce = _gg008kdx.Gg008Prcecommerce,
                                                    Gg008Auditasn = _gg008kdx.Gg008Auditasn,
                                                    Gg008Possuisaldo = _gg008kdx.Gg008Possuisaldo,
                                                    Gg008Ultrecebimento = _gg008kdx.Gg008Ultrecebimento,
                                                    Gg008Qtdultrecebto = _gg008kdx.Gg008Qtdultrecebto,
                                                    Gg008UltimaVenda = _gg008kdx.Gg008UltimaVenda,
                                                    Gg008QtdeUltVenda = _gg008kdx.Gg008QtdeUltVenda,
                                                    Gg008TpcbarratribId = _gg008kdx.Gg008TpcbarratribId,
                                                    NavGG008Produto = _gg008 != null ? new CSICP_GG008
                                                    {
                                                        Gg008Descreduzida = _gg008.Gg008Descreduzida,
                                                        Gg008Codgproduto = _gg008.Gg008Codgproduto
                                                    } : null,
                                                } : null,
                                                NavGG072Stq = _gg072stq != null ? _gg072stq : null,
                                                NavGG073 = _CSICP_GG073 != null ? new CSICP_GG073
                                                {
                                                    TenantId = _CSICP_GG073.TenantId,
                                                    Gg073Id = _CSICP_GG073.Gg073Id,
                                                    Gg073Estabid = _CSICP_GG073.Gg073Estabid,
                                                    Gg073DataMovimento = _CSICP_GG073.Gg073DataMovimento,
                                                    Gg073Usuarioid = _CSICP_GG073.Gg073Usuarioid,
                                                    Gg073Observacao = _CSICP_GG073.Gg073Observacao,
                                                    Gg073Ccustoid = _CSICP_GG073.Gg073Ccustoid,
                                                    Gg073Almoxmovd = _CSICP_GG073.Gg073Almoxmovd,
                                                    Gg073Dhregistro = _CSICP_GG073.Gg073Dhregistro,
                                                    Gg073Statusid = _CSICP_GG073.Gg073Statusid,
                                                    Gg073Tmovid = _CSICP_GG073.Gg073Tmovid,
                                                    Gg073Valorizarporid = _CSICP_GG073.Gg073Valorizarporid,
                                                    Gg073Tmovimento = _CSICP_GG073.Gg073Tmovimento,
                                                    Gg073Protocolonro = _CSICP_GG073.Gg073Protocolonro,
                                                    Gg073Almoxmovsaida = _CSICP_GG073.Gg073Almoxmovsaida,
                                                    Gg073QtdeItens = _CSICP_GG073.Gg073QtdeItens,
                                                    Gg073IdOrig = _CSICP_GG073.Gg073IdOrig,
                                                    Dd190Obraid = _CSICP_GG073.Dd190Obraid,
                                                } : null,
                                                NavGG073TpMov = _gg073tpmov != null ? _gg073tpmov : null,
                                                NavGG520 = _gg520 != null ? new CSICP_GG520
                                                {
                                                    TenantId = _gg520.TenantId,
                                                    Id = _gg520.Id,
                                                    Gg520Filialid = _gg520.Gg520Filialid,
                                                    Gg520KardexId = _gg520.Gg520KardexId,
                                                    Gg520Almoxid = _gg520.Gg520Almoxid,
                                                    Gg520NsNumerosaldo = _gg520.Gg520NsNumerosaldo,
                                                    Gg520Descricaosaldo = _gg520.Gg520Descricaosaldo,
                                                    Gg520Filial = _gg520.Gg520Filial,
                                                    Gg520Codalmoxarifado = _gg520.Gg520Codalmoxarifado,
                                                    Gg520Produto = _gg520.Gg520Produto,
                                                    Gg520Saldo = _gg520.Gg520Saldo,
                                                    Gg520Qtdcomprometida = _gg520.Gg520Qtdcomprometida,
                                                    Gg520QtdProducao = _gg520.Gg520QtdProducao,
                                                    Gg520QtdEmpenho = _gg520.Gg520QtdEmpenho,
                                                    Gg520QtdReserva = _gg520.Gg520QtdReserva,
                                                    Gg520Qnpt = _gg520.Gg520Qnpt,
                                                    Gg520Qtnp = _gg520.Gg520Qtnp,
                                                    Gg520Ultinventario = _gg520.Gg520Ultinventario,
                                                    Gg520Ultfechamento = _gg520.Gg520Ultfechamento,
                                                    Gg520Qtdultfechamento = _gg520.Gg520Qtdultfechamento,
                                                    Gg520ItemEmContagem = _gg520.Gg520ItemEmContagem,
                                                    Gg520Proxinventario = _gg520.Gg520Proxinventario,
                                                    Gg520Ultrecebimento = _gg520.Gg520Ultrecebimento,
                                                    Gg520Qtdultrecebto = _gg520.Gg520Qtdultrecebto,
                                                    Gg520UltimaVenda = _gg520.Gg520UltimaVenda,
                                                    Gg520QtdeUltVenda = _gg520.Gg520QtdeUltVenda,
                                                    Gg520Qtdpedidocompra = _gg520.Gg520Qtdpedidocompra,
                                                    Gg520Lote = _gg520.Gg520Lote,
                                                    Gg520Sublote = _gg520.Gg520Sublote,
                                                    Gg520DescricaoLote = _gg520.Gg520DescricaoLote,
                                                    Gg520Compraid = _gg520.Gg520Compraid,
                                                    Gg520CodgFornecedor = _gg520.Gg520CodgFornecedor,
                                                    Gg520Contaid = _gg520.Gg520Contaid,
                                                    Gg520Usuarioid = _gg520.Gg520Usuarioid,
                                                    Gg520DataFabricacao = _gg520.Gg520DataFabricacao,
                                                    Gg520DataValidade = _gg520.Gg520DataValidade,
                                                    Gg520DiasValidade = _gg520.Gg520DiasValidade,
                                                    Gg520Docto = _gg520.Gg520Docto,
                                                    Gg520Serie = _gg520.Gg520Serie,
                                                    Gg520Compraentrada = _gg520.Gg520Compraentrada,
                                                    Gg520Gradelinhaid = _gg520.Gg520Gradelinhaid,
                                                    Gg520Gradecolunaid = _gg520.Gg520Gradecolunaid,
                                                    Gg520Codggradelinha = _gg520.Gg520Codggradelinha,
                                                    Gg520Codggradecoluna = _gg520.Gg520Codggradecoluna,
                                                    Gg520EstqMinimo = _gg520.Gg520EstqMinimo,
                                                    Gg520Estoquemaximo = _gg520.Gg520Estoquemaximo,
                                                    Gg520Localizacaowms = _gg520.Gg520Localizacaowms,
                                                    Gg520Superpromocao = _gg520.Gg520Superpromocao,
                                                    Gg520Periodicidadeinv = _gg520.Gg520Periodicidadeinv,
                                                    Gg520Exibiremconsulta = _gg520.Gg520Exibiremconsulta,
                                                    Gg520Saldozerodesabautom = _gg520.Gg520Saldozerodesabautom,
                                                    Gg520Permitetroca = _gg520.Gg520Permitetroca,
                                                    Gg520Vbcstret = _gg520.Gg520Vbcstret,
                                                    Gg520Vicmsstret = _gg520.Gg520Vicmsstret,
                                                    Gg520Isactive = _gg520.Gg520Isactive,
                                                    Gg520CodbarrasId = _gg520.Gg520CodbarrasId,
                                                    Gg520Timestamp = _gg520.Gg520Timestamp,
                                                    Gg520Ispdv = _gg520.Gg520Ispdv,
                                                    Gg520Vicmssubstituto = _gg520.Gg520Vicmssubstituto,
                                                    Gg520VfuturaSaldoid = _gg520.Gg520VfuturaSaldoid,
                                                } : null
                                            };
            return query;
        }


    }
}



