using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008Kdx;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG520;
using CSCore.Domain.CS_Models.CSICP_GG;
using GG104Materiais.C82Application.Dto.GG00X.GG003;
using GG104Materiais.C82Application.Dto.GG00X.GG004;
using GG104Materiais.C82Application.Dto.GG00X.GG005;
using GG104Materiais.C82Application.Dto.GG00X.GG006;
using GG104Materiais.C82Application.Dto.GG00X.GG008;
using GG104Materiais.C82Application.Mapper;
using GG104Materiais.C82Application.Mapper.GG008;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG520Mapper
    {
        public static DtoGetGG520 ToDtoGetGG520(this CSICP_GG520 entity)
        {
            return new DtoGetGG520
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg520Filialid = entity.Gg520Filialid,
                Gg520KardexId = entity.Gg520KardexId,
                Gg520Almoxid = entity.Gg520Almoxid,
                Gg520NsNumerosaldo = entity.Gg520NsNumerosaldo,
                Gg520Descricaosaldo = entity.Gg520Descricaosaldo,
                Gg520Filial = entity.Gg520Filial,
                Gg520Codalmoxarifado = entity.Gg520Codalmoxarifado,
                Gg520Produto = entity.Gg520Produto,
                Gg520Saldo = entity.Gg520Saldo,
                Gg520Qtdcomprometida = entity.Gg520Qtdcomprometida,
                Gg520QtdProducao = entity.Gg520QtdProducao,
                Gg520QtdEmpenho = entity.Gg520QtdEmpenho,
                Gg520QtdReserva = entity.Gg520QtdReserva,
                Gg520Qnpt = entity.Gg520Qnpt,
                Gg520Qtnp = entity.Gg520Qtnp,
                Gg520Ultinventario = entity.Gg520Ultinventario,
                Gg520Ultfechamento = entity.Gg520Ultfechamento,
                Gg520Qtdultfechamento = entity.Gg520Qtdultfechamento,
                Gg520ItemEmContagem = entity.Gg520ItemEmContagem,
                Gg520Proxinventario = entity.Gg520Proxinventario,
                Gg520Ultrecebimento = entity.Gg520Ultrecebimento,
                Gg520Qtdultrecebto = entity.Gg520Qtdultrecebto,
                Gg520UltimaVenda = entity.Gg520UltimaVenda,
                Gg520QtdeUltVenda = entity.Gg520QtdeUltVenda,
                Gg520Qtdpedidocompra = entity.Gg520Qtdpedidocompra,
                Gg520Lote = entity.Gg520Lote,
                Gg520Sublote = entity.Gg520Sublote,
                Gg520DescricaoLote = entity.Gg520DescricaoLote,
                Gg520Compraid = entity.Gg520Compraid,
                Gg520CodgFornecedor = entity.Gg520CodgFornecedor,
                Gg520Contaid = entity.Gg520Contaid,
                Gg520Usuarioid = entity.Gg520Usuarioid,
                Gg520DataFabricacao = entity.Gg520DataFabricacao,
                Gg520DataValidade = entity.Gg520DataValidade,
                Gg520DiasValidade = entity.Gg520DiasValidade,
                Gg520Docto = entity.Gg520Docto,
                Gg520Serie = entity.Gg520Serie,
                Gg520Compraentrada = entity.Gg520Compraentrada,
                Gg520Gradelinhaid = entity.Gg520Gradelinhaid,
                Gg520Gradecolunaid = entity.Gg520Gradecolunaid,
                Gg520Codggradelinha = entity.Gg520Codggradelinha,
                Gg520Codggradecoluna = entity.Gg520Codggradecoluna,
                Gg520EstqMinimo = entity.Gg520EstqMinimo,
                Gg520Estoquemaximo = entity.Gg520Estoquemaximo,
                Gg520Localizacaowms = entity.Gg520Localizacaowms,
                Gg520Superpromocao = entity.Gg520Superpromocao,
                Gg520Periodicidadeinv = entity.Gg520Periodicidadeinv,
                Gg520Exibiremconsulta = entity.Gg520Exibiremconsulta,
                Gg520Saldozerodesabautom = entity.Gg520Saldozerodesabautom,
                Gg520Permitetroca = entity.Gg520Permitetroca,
                Gg520Vbcstret = entity.Gg520Vbcstret,
                Gg520Vicmsstret = entity.Gg520Vicmsstret,
                Gg520Isactive = entity.Gg520Isactive,
                Gg520CodbarrasId = entity.Gg520CodbarrasId,
                Gg520Timestamp = entity.Gg520Timestamp,
                Gg520Ispdv = entity.Gg520Ispdv,
                Gg520Vicmssubstituto = entity.Gg520Vicmssubstituto,
                Gg520VfuturaSaldoid = entity.Gg520VfuturaSaldoid,
                NavGG001Almox = entity.NavGG001Almox?.ToDtoGet(),
                NavGG019Codbarras = entity.Gg520Codbarras?.ToDtoGet(),
                NavGG016Gradecoluna = entity.NavGG016Gradecoluna?.ToDtoGet(),
                NavGG016Gradelinha = entity.NavGG016Gradlinha?.ToDtoGet(),
                NavGG008Kardex = entity.Nav_GG008Kardex?.ToDtoGetExibicao(),
            };
        }

        public static DtoGetSaldoGG520ParaGG45 ToDtoGetGG520ParaGG45(this CSICP_GG520 entity)
        {
            return new DtoGetSaldoGG520ParaGG45
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg520NsNumerosaldo = entity.Gg520NsNumerosaldo,
                Gg520Descricaosaldo = entity.Gg520Descricaosaldo,
                Gg520Descricaolote = entity.Gg520DescricaoLote,
                Gg520Saldo = entity.Gg520Saldo,
                NavGg008Produto = entity.Nav_GG008Kardex?.NavGG008Produto?.ToDtoGetExibicaoSimples()

            };
        }

        public static DtoGetGG520ParaProdutoPorCodigo ToDtoGetGG520Exibicao(this CSICP_GG520 entity)
        {
            return new DtoGetGG520ParaProdutoPorCodigo
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg520Filialid = entity.Gg520Filialid,
                Gg520KardexId = entity.Gg520KardexId,
                Gg520Almoxid = entity.Gg520Almoxid,
                Gg520NsNumerosaldo = entity.Gg520NsNumerosaldo,
                Gg520Descricaosaldo = entity.Gg520Descricaosaldo,
                Gg520Filial = entity.Gg520Filial,
                Gg520Codalmoxarifado = entity.Gg520Codalmoxarifado,
                Gg520Produto = entity.Gg520Produto,
                Gg520Saldo = entity.Gg520Saldo,
                NavGG008Kdx = entity.Nav_GG008Kardex != null ? new DtoGetGG008Kdx_Exibicao
                {
                    TenantId = entity.Nav_GG008Kardex.TenantId,
                    Gg008Kardexid = entity.Nav_GG008Kardex.Gg008Kardexid,
                    Gg008Filialid = entity.Nav_GG008Kardex.Gg008Filialid,
                    Gg008Produtoid = entity.Nav_GG008Kardex.Gg008Produtoid,
                    Gg008Codalmoxpadrao = entity.Nav_GG008Kardex.Gg008Codalmoxpadrao,
                    Gg008Codalmtransf = entity.Nav_GG008Kardex.Gg008Codalmtransf,
                    Gg008Almoxpadraoid = entity.Nav_GG008Kardex.Gg008Almoxpadraoid,
                    Gg008Almoxtransfid = entity.Nav_GG008Kardex.Gg008Almoxtransfid,
                    Gg008Unidade = entity.Nav_GG008Kardex.Gg008Unidade,
                    Gg008Unidsecundaria = entity.Nav_GG008Kardex.Gg008Unidsecundaria,
                    Gg008Unvendavarejoid = entity.Nav_GG008Kardex.Gg008Unvendavarejoid,
                    Gg008Uncompravarejoid = entity.Nav_GG008Kardex.Gg008Uncompravarejoid,
                    Gg008Unvendaatacadoid = entity.Nav_GG008Kardex.Gg008Unvendaatacadoid,
                    Gg008FatorConversao = entity.Nav_GG008Kardex.Gg008FatorConversao,
                    Gg008AliquotaIpi = entity.Nav_GG008Kardex.Gg008AliquotaIpi,
                    Gg008AliquotaIcms = entity.Nav_GG008Kardex.Gg008AliquotaIcms,
                    Gg008AliqIcmsReduzidaPdv = entity.Nav_GG008Kardex.Gg008AliqIcmsReduzidaPdv,
                    Gg008AliquotaIss = entity.Nav_GG008Kardex.Gg008AliquotaIss,
                    Gg008Margemlucrosai = entity.Nav_GG008Kardex.Gg008Margemlucrosai,
                    Gg008Margemlucroent = entity.Nav_GG008Kardex.Gg008Margemlucroent,
                    Gg008CalculaIrrf = entity.Nav_GG008Kardex.Gg008CalculaIrrf,
                    Gg008CalculaInss = entity.Nav_GG008Kardex.Gg008CalculaInss,
                    Gg008PercCsll = entity.Nav_GG008Kardex.Gg008PercCsll,
                    Gg008PercCofins = entity.Nav_GG008Kardex.Gg008PercCofins,
                    Gg008PercPis = entity.Nav_GG008Kardex.Gg008PercPis,
                    Gg008IcmsPauta = entity.Nav_GG008Kardex.Gg008IcmsPauta,
                    Gg008IpiPauta = entity.Nav_GG008Kardex.Gg008IpiPauta,
                    Gg008Qtdpedidocompra = entity.Nav_GG008Kardex.Gg008Qtdpedidocompra,
                    Gg008EstoqueMinimo = entity.Nav_GG008Kardex.Gg008EstoqueMinimo,
                    Gg008EstoqueMaximo = entity.Nav_GG008Kardex.Gg008EstoqueMaximo,
                    Gg008TempoReposicao = entity.Nav_GG008Kardex.Gg008TempoReposicao,
                    Gg008PontoPedido = entity.Nav_GG008Kardex.Gg008PontoPedido,
                    Gg008LoteEconomico = entity.Nav_GG008Kardex.Gg008LoteEconomico,
                    Gg008GrauAtendimento = entity.Nav_GG008Kardex.Gg008GrauAtendimento,
                    Gg008PercTolerancia = entity.Nav_GG008Kardex.Gg008PercTolerancia,
                    Gg008Abc = entity.Nav_GG008Kardex.Gg008Abc,
                    Gg008PercComissao = entity.Nav_GG008Kardex.Gg008PercComissao,
                    Gg008DataFabricacao = entity.Nav_GG008Kardex.Gg008DataFabricacao,
                    Gg008DataValidade = entity.Nav_GG008Kardex.Gg008DataValidade,
                    Gg008DiasValidade = entity.Nav_GG008Kardex.Gg008DiasValidade,
                    Gg008CustoMedio = entity.Nav_GG008Kardex.Gg008CustoMedio,
                    Gg008PrecoReposicao = entity.Nav_GG008Kardex.Gg008PrecoReposicao,
                    Gg008PercDescItem = entity.Nav_GG008Kardex.Gg008PercDescItem,
                    Gg008Prcpromocional = entity.Nav_GG008Kardex.Gg008Prcpromocional,
                    Gg008QtdPromocional = entity.Nav_GG008Kardex.Gg008QtdPromocional,
                    Gg008FatorLucro = entity.Nav_GG008Kardex.Gg008FatorLucro,
                    Gg008PrcVendavarejo = entity.Nav_GG008Kardex.Gg008PrcVendavarejo,
                    Gg008PrcVndMercado = entity.Nav_GG008Kardex.Gg008PrcVndMercado,
                    Gg008Ultreajprcvenda = entity.Nav_GG008Kardex.Gg008Ultreajprcvenda,
                    Gg008PrecoVendaLiq = entity.Nav_GG008Kardex.Gg008PrecoVendaLiq,
                    Gg008Vlrmargemlucro = entity.Nav_GG008Kardex.Gg008Vlrmargemlucro,
                    Gg008Alteraprcvenda = entity.Nav_GG008Kardex.Gg008Alteraprcvenda,
                    Gg008PrecoCusto = entity.Nav_GG008Kardex.Gg008PrecoCusto,
                    Gg008Ultreajprccusto = entity.Nav_GG008Kardex.Gg008Ultreajprccusto,
                    Gg008PrecoCustoReal = entity.Nav_GG008Kardex.Gg008PrecoCustoReal,
                    Gg008CentroCusto = entity.Nav_GG008Kardex.Gg008CentroCusto,
                    Gg008Ccustoid = entity.Nav_GG008Kardex.Gg008Ccustoid,
                    Gg008ContaContabil = entity.Nav_GG008Kardex.Gg008ContaContabil,
                    Gg008ClasseContabil = entity.Nav_GG008Kardex.Gg008ClasseContabil,
                    Gg008FornecedorCanal = entity.Nav_GG008Kardex.Gg008FornecedorCanal,
                    Gg008Fornecedorpadrao = entity.Nav_GG008Kardex.Gg008Fornecedorpadrao,
                    Gg008Contaid = entity.Nav_GG008Kardex.Gg008Contaid,
                    Gg008Periodicidadeinv = entity.Nav_GG008Kardex.Gg008Periodicidadeinv,
                    Gg008ControlaSaldo = entity.Nav_GG008Kardex.Gg008ControlaSaldo,
                    Gg008ControleLote = entity.Nav_GG008Kardex.Gg008ControleLote,
                    Gg008ControleGrade = entity.Nav_GG008Kardex.Gg008ControleGrade,
                    Gg008Anuente = entity.Nav_GG008Kardex.Gg008Anuente,
                    Gg008Restricao = entity.Nav_GG008Kardex.Gg008Restricao,
                    Gg008Grupocomprasid = entity.Nav_GG008Kardex.Gg008Grupocomprasid,
                    Gg008Permsldnegativo = entity.Nav_GG008Kardex.Gg008Permsldnegativo,
                    Gg008Minutaautomatica = entity.Nav_GG008Kardex.Gg008Minutaautomatica,
                    Gg008Requisautomatica = entity.Nav_GG008Kardex.Gg008Requisautomatica,
                    Gg008DataDesativacao = entity.Nav_GG008Kardex.Gg008DataDesativacao,
                    Gg008Localizfixa = entity.Nav_GG008Kardex.Gg008Localizfixa,
                    Gg008Diversos = entity.Nav_GG008Kardex.Gg008Diversos,
                    Gg008AliqDifPis = entity.Nav_GG008Kardex.Gg008AliqDifPis,
                    Gg008AliqDifCofins = entity.Nav_GG008Kardex.Gg008AliqDifCofins,
                    Gg008EanTributavel = entity.Nav_GG008Kardex.Gg008EanTributavel,
                    Gg008Untributavelid = entity.Nav_GG008Kardex.Gg008Untributavelid,
                    Gg008FatorUnidade = entity.Nav_GG008Kardex.Gg008FatorUnidade,
                    Gg008ValorPis = entity.Nav_GG008Kardex.Gg008ValorPis,
                    Gg008ValorCofins = entity.Nav_GG008Kardex.Gg008ValorCofins,
                    Gg008IsActive = entity.Nav_GG008Kardex.Gg008IsActive,
                    Gg008TipoConversaoId = entity.Nav_GG008Kardex.Gg008TipoConversaoId,
                    Gg008TipoprazoId = entity.Nav_GG008Kardex.Gg008TipoprazoId,
                    Gg008TpContribuicaoId = entity.Nav_GG008Kardex.Gg008TpContribuicaoId,
                    Gg008RiControlequalidade = entity.Nav_GG008Kardex.Gg008RiControlequalidade,
                    Gg008AliquotaIrpj = entity.Nav_GG008Kardex.Gg008AliquotaIrpj,
                    Gg008RetencaoAliqInss = entity.Nav_GG008Kardex.Gg008RetencaoAliqInss,
                    Gg008RetencaoAliqIrrf = entity.Nav_GG008Kardex.Gg008RetencaoAliqIrrf,
                    Gg008DescontoSuframa = entity.Nav_GG008Kardex.Gg008DescontoSuframa,
                    Gg008Timestamp = entity.Nav_GG008Kardex.Gg008Timestamp,
                    Gg008Plucro = entity.Nav_GG008Kardex.Gg008Plucro,
                    Gg008IsctrlGondola = entity.Nav_GG008Kardex.Gg008IsctrlGondola,
                    Gg008Qmediaconsumo = entity.Nav_GG008Kardex.Gg008Qmediaconsumo,
                    Gg008Vmediaconsumo = entity.Nav_GG008Kardex.Gg008Vmediaconsumo,
                    Gg008Dtultprocle = entity.Nav_GG008Kardex.Gg008Dtultprocle,
                    Gg008VuncompraCmedio = entity.Nav_GG008Kardex.Gg008VuncompraCmedio,
                    Gg008VuncompraReposicao = entity.Nav_GG008Kardex.Gg008VuncompraReposicao,
                    Gg008VuncompraPrcvenda = entity.Nav_GG008Kardex.Gg008VuncompraPrcvenda,
                    Gg008VuncompraPrcmercado = entity.Nav_GG008Kardex.Gg008VuncompraPrcmercado,
                    Gg008VuncompraPrccusto = entity.Nav_GG008Kardex.Gg008VuncompraPrccusto,
                    Gg008VuncompraCustoreal = entity.Nav_GG008Kardex.Gg008VuncompraCustoreal,
                    Gg008VuncompraVlrmarglucro = entity.Nav_GG008Kardex.Gg008VuncompraVlrmarglucro,
                    Gg008Moedaid = entity.Nav_GG008Kardex.Gg008Moedaid,
                    Gg008Vmoeda = entity.Nav_GG008Kardex.Gg008Vmoeda,
                    Gg008Prcecommerce = entity.Nav_GG008Kardex.Gg008Prcecommerce,
                    Gg008Auditasn = entity.Nav_GG008Kardex.Gg008Auditasn,
                    Gg008Possuisaldo = entity.Nav_GG008Kardex.Gg008Possuisaldo,
                    Gg008Ultrecebimento = entity.Nav_GG008Kardex.Gg008Ultrecebimento,
                    Gg008Qtdultrecebto = entity.Nav_GG008Kardex.Gg008Qtdultrecebto,
                    Gg008UltimaVenda = entity.Nav_GG008Kardex.Gg008UltimaVenda,
                    Gg008QtdeUltVenda = entity.Nav_GG008Kardex.Gg008QtdeUltVenda,
                    Gg008TpcbarratribId = entity.Nav_GG008Kardex.Gg008TpcbarratribId,

                    NavGG008Produto = entity.Nav_GG008Kardex.NavGG008Produto != null ? new DtoGetGG008_Exibicao
                    {
                        TenantId = entity.Nav_GG008Kardex.NavGG008Produto.TenantId,
                        Id = entity.Nav_GG008Kardex.NavGG008Produto.Id,
                        Gg008Codgproduto = entity.Nav_GG008Kardex.NavGG008Produto.Gg008Codgproduto,
                        Gg008Descreduzida = entity.Nav_GG008Kardex.NavGG008Produto.Gg008Descreduzida,
                        NavGrupoProdutoGG003 = entity.Nav_GG008Kardex.NavGG008Produto.NavGrupoProdutoGG003 != null ? new DtoGetGG003_Exibicao
                        {
                            TenantId = entity.Nav_GG008Kardex.NavGG008Produto.NavGrupoProdutoGG003.TenantId,
                            Id = entity.Nav_GG008Kardex.NavGG008Produto.NavGrupoProdutoGG003.Id,
                            Gg003Codigogrupo = entity.Nav_GG008Kardex.NavGG008Produto.NavGrupoProdutoGG003.Gg003Codigogrupo,
                            Gg003Descgrupo = entity.Nav_GG008Kardex.NavGG008Produto.NavGrupoProdutoGG003.Gg003Descgrupo,
                        } : null,
                        NavArtigoProdutoGG005 = entity.Nav_GG008Kardex.NavGG008Produto.NavArtigoProdutoGG005 != null ? new DtoGetGG005_Exibicao
                        {
                            TenantId = entity.Nav_GG008Kardex.NavGG008Produto.NavArtigoProdutoGG005.TenantId,
                            Id = entity.Nav_GG008Kardex.NavGG008Produto.NavArtigoProdutoGG005.Id,
                            Gg005Codigoartigo = entity.Nav_GG008Kardex.NavGG008Produto.NavArtigoProdutoGG005.Gg005Codigoartigo,
                            Gg005Descartigo = entity.Nav_GG008Kardex.NavGG008Produto.NavArtigoProdutoGG005.Gg005Descartigo,
                        } : null,
                        NavClasseProdutoGG004 = entity.Nav_GG008Kardex.NavGG008Produto.NavClasseProdutoGG004 != null ? new DtoGG004_Exibicao
                        {
                            TenantId = entity.Nav_GG008Kardex.NavGG008Produto.NavClasseProdutoGG004.TenantId,
                            Id = entity.Nav_GG008Kardex.NavGG008Produto.NavClasseProdutoGG004.Id,
                            Gg004Codigoclasse = entity.Nav_GG008Kardex.NavGG008Produto.NavClasseProdutoGG004.Gg004Codigoclasse,
                            Gg004Descclasse = entity.Nav_GG008Kardex.NavGG008Produto.NavClasseProdutoGG004.Gg004Descclasse,
                        } : null,
                        NavMarcaProdutoGG006 = entity.Nav_GG008Kardex.NavGG008Produto.NavMarcaProdutoGG006 != null ? new DtoGetGG006_Exibicao
                        {
                            TenantId = entity.Nav_GG008Kardex.NavGG008Produto.NavMarcaProdutoGG006.TenantId,
                            Id = entity.Nav_GG008Kardex.NavGG008Produto.NavMarcaProdutoGG006.Id,
                            Gg006Codigomarca = entity.Nav_GG008Kardex.NavGG008Produto.NavMarcaProdutoGG006.Gg006Codigomarca,
                            Gg006Descmarca = entity.Nav_GG008Kardex.NavGG008Produto.NavMarcaProdutoGG006.Gg006Descmarca
                        } : null,
                    } : null
                } : null
            };
        }

        public static DtoGetGG520Simples ToDtoGetSimples(this CSICP_GG520 entity)
        {
            return new DtoGetGG520Simples
            {
                Id = entity.Id,
                Gg520Filialid = entity.Gg520Filialid,
                Gg520KardexId = entity.Gg520KardexId,
                Gg520Almoxid = entity.Gg520Almoxid,
                Gg520NsNumerosaldo = entity.Gg520NsNumerosaldo,
                Gg520Descricaosaldo = entity.Gg520Descricaosaldo,
                Gg520Ultinventario = entity.Gg520Ultinventario,
                Gg520ItemEmContagem = entity.Gg520ItemEmContagem,
                Gg520Ultrecebimento = entity.Gg520Ultrecebimento,
                Gg520Qtdultrecebto = entity.Gg520Qtdultrecebto,
                Gg520UltimaVenda = entity.Gg520UltimaVenda,
                Gg520Lote = entity.Gg520Lote,
                Gg520Saldo = entity.Gg520Saldo,
                Gg520QtdeUltVenda = entity.Gg520QtdeUltVenda,
                Gg520DescricaoLote = entity.Gg520DescricaoLote,
                Gg520DataValidade = entity.Gg520DataValidade,
                Gg520EstqMinimo = entity.Gg520EstqMinimo,
                Gg520Estoquemaximo = entity.Gg520Estoquemaximo,
                Gg520Superpromocao = entity.Gg520Superpromocao,
                Gg001AlmoxarifadoCodigo = entity.NavGG001Almox?.Gg001Codigoalmox.ToString(),
                Gg001AlmoxarifadoDescricao = entity.NavGG001Almox?.Gg001Descalmox
            };
        }

        public static DtoGetGG520SimplesComProdutoSemKardex ToDtoGetSimplesComProdutoESemKardex(this CSICP_GG520 entity)
        {
            return new DtoGetGG520SimplesComProdutoSemKardex
            {
                Id = entity.Id,
                Gg520Filialid = entity.Gg520Filialid,
                Gg520KardexId = entity.Gg520KardexId,
                Gg520Almoxid = entity.Gg520Almoxid,
                Gg520NsNumerosaldo = entity.Gg520NsNumerosaldo,
                Gg520Descricaosaldo = entity.Gg520Descricaosaldo,
                Gg520Ultinventario = entity.Gg520Ultinventario,
                Gg520ItemEmContagem = entity.Gg520ItemEmContagem,
                Gg520Ultrecebimento = entity.Gg520Ultrecebimento,
                Gg520Qtdultrecebto = entity.Gg520Qtdultrecebto,
                Gg520UltimaVenda = entity.Gg520UltimaVenda,
                Gg520Lote = entity.Gg520Lote,
                Gg520Saldo = entity.Gg520Saldo,
                Gg520QtdeUltVenda = entity.Gg520QtdeUltVenda,
                Gg520DescricaoLote = entity.Gg520DescricaoLote,
                Gg520DataValidade = entity.Gg520DataValidade,
                Gg520EstqMinimo = entity.Gg520EstqMinimo,
                Gg520Estoquemaximo = entity.Gg520Estoquemaximo,
                Gg520Superpromocao = entity.Gg520Superpromocao,
                Gg001AlmoxarifadoCodigo = entity.NavGG001Almox?.Gg001Codigoalmox.ToString(),
                Gg001AlmoxarifadoDescricao = entity.NavGG001Almox?.Gg001Descalmox,
                NavGG520Produto = entity.Nav_GG008Kardex?.NavGG008Produto?.ToDtoGetExibicaoSimples()
            };
        }


        public static DtoGetGG520_2 ToDtoGetPesquisaProduto(this CSICP_GG520 entity)
        {
            return new DtoGetGG520_2
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg520Filialid = entity.Gg520Filialid,
                Gg520KardexId = entity.Gg520KardexId,
                Gg520Almoxid = entity.Gg520Almoxid,
                Gg520NsNumerosaldo = entity.Gg520NsNumerosaldo,
                Gg520Descricaosaldo = entity.Gg520Descricaosaldo,
                Gg520Filial = entity.Gg520Filial,
                Gg520Codalmoxarifado = entity.Gg520Codalmoxarifado,
                Gg520Produto = entity.Gg520Produto,
                NavGG001Almox = entity.NavGG001Almox?.ToDtoGetSimples(),
                NavGG008Kardex = entity.Nav_GG008Kardex?.ToDtoGetExibicao()

            };
        }

        public static DtoGetSaldoGG520 ToDtoGetSaldo520(this CSICP_GG520 entity)
        {
            return new DtoGetSaldoGG520
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg520NsNumerosaldo = entity.Gg520NsNumerosaldo,
                Gg520Descricaosaldo = entity.Gg520Descricaosaldo,
                Gg008Codgproduto = entity.Nav_GG008Kardex!.NavGG008Produto!.Gg008Codgproduto,
                Gg008Descreduzida = entity.Nav_GG008Kardex.NavGG008Produto.Gg008Descreduzida,
                NavMarcaProdutoGG006 = entity.Nav_GG008Kardex.NavGG008Produto.NavMarcaProdutoGG006!.ToDtoGet(),
                NavArtigoProdutoGG005 = entity.Nav_GG008Kardex.NavGG008Produto.NavArtigoProdutoGG005!.ToDtoGet(),
                NavClasseProdutoGG004 = entity.Nav_GG008Kardex.NavGG008Produto.NavClasseProdutoGG004!.ToDtoGet(),
                NavGrupoProdutoGG003 = entity.Nav_GG008Kardex.NavGG008Produto.NavGrupoProdutoGG003!.ToDtoGet(),
            };
        }

        public static DtoGetLimpoGG520 ToDtoGetLimpoGG520(this CSICP_GG520 entity)
        {
            return new DtoGetLimpoGG520
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg520Filialid = entity.Gg520Filialid,
                Gg520KardexId = entity.Gg520KardexId,
                Gg520Almoxid = entity.Gg520Almoxid,
                Gg520NsNumerosaldo = entity.Gg520NsNumerosaldo,
                Gg520Descricaosaldo = entity.Gg520Descricaosaldo,
                Gg520Filial = entity.Gg520Filial,
                Gg520Codalmoxarifado = entity.Gg520Codalmoxarifado,
                Gg520Produto = entity.Gg520Produto,
                Gg520Saldo = entity.Gg520Saldo,
                Gg520Qtdcomprometida = entity.Gg520Qtdcomprometida,
                Gg520QtdProducao = entity.Gg520QtdProducao,
                Gg520QtdEmpenho = entity.Gg520QtdEmpenho,
                Gg520QtdReserva = entity.Gg520QtdReserva,
                Gg520Qnpt = entity.Gg520Qnpt,
                Gg520Qtnp = entity.Gg520Qtnp,
                Gg520Ultinventario = entity.Gg520Ultinventario,
                Gg520Ultfechamento = entity.Gg520Ultfechamento,
                Gg520Qtdultfechamento = entity.Gg520Qtdultfechamento,
                Gg520ItemEmContagem = entity.Gg520ItemEmContagem,
                Gg520Proxinventario = entity.Gg520Proxinventario,
                Gg520Ultrecebimento = entity.Gg520Ultrecebimento,
                Gg520Qtdultrecebto = entity.Gg520Qtdultrecebto,
                Gg520UltimaVenda = entity.Gg520UltimaVenda,
                Gg520QtdeUltVenda = entity.Gg520QtdeUltVenda,
                Gg520Qtdpedidocompra = entity.Gg520Qtdpedidocompra,
                Gg520Lote = entity.Gg520Lote,
                Gg520Sublote = entity.Gg520Sublote,
                Gg520DescricaoLote = entity.Gg520DescricaoLote,
                Gg520Compraid = entity.Gg520Compraid,
                Gg520CodgFornecedor = entity.Gg520CodgFornecedor,
                Gg520Contaid = entity.Gg520Contaid,
                Gg520Usuarioid = entity.Gg520Usuarioid,
                Gg520DataFabricacao = entity.Gg520DataFabricacao,
                Gg520DataValidade = entity.Gg520DataValidade,
                Gg520DiasValidade = entity.Gg520DiasValidade,
                Gg520Docto = entity.Gg520Docto,
                Gg520Serie = entity.Gg520Serie,
                Gg520Compraentrada = entity.Gg520Compraentrada,
                Gg520Gradelinhaid = entity.Gg520Gradelinhaid,
                Gg520Gradecolunaid = entity.Gg520Gradecolunaid,
                Gg520Codggradelinha = entity.Gg520Codggradelinha,
                Gg520Codggradecoluna = entity.Gg520Codggradecoluna,
                Gg520EstqMinimo = entity.Gg520EstqMinimo,
                Gg520Estoquemaximo = entity.Gg520Estoquemaximo,
                Gg520Localizacaowms = entity.Gg520Localizacaowms,
                Gg520Superpromocao = entity.Gg520Superpromocao,
                Gg520Periodicidadeinv = entity.Gg520Periodicidadeinv,
                Gg520Exibiremconsulta = entity.Gg520Exibiremconsulta,
                Gg520Saldozerodesabautom = entity.Gg520Saldozerodesabautom,
                Gg520Permitetroca = entity.Gg520Permitetroca,
                Gg520Vbcstret = entity.Gg520Vbcstret,
                Gg520Vicmsstret = entity.Gg520Vicmsstret,
                Gg520Isactive = entity.Gg520Isactive,
                Gg520CodbarrasId = entity.Gg520CodbarrasId,
                Gg520Timestamp = entity.Gg520Timestamp,
                Gg520Ispdv = entity.Gg520Ispdv,
                Gg520Vicmssubstituto = entity.Gg520Vicmssubstituto,
                Gg520VfuturaSaldoid = entity.Gg520VfuturaSaldoid,
                Gg520Almox = entity.NavGG001Almox?.ToDtoGet(),
                Gg520Gradecoluna = entity.NavGG016Gradecoluna?.ToDtoGet(),
                Gg520Gradelinha = entity.NavGG016Gradlinha?.ToDtoGet(),
            };
        }
    }
}












