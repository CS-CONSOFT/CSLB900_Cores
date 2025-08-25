using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.Interfaces.GG._03X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._03X
{
    public class GG033RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_GG033>(appDbContext), IGG033Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_GG033?> GetByIdAsync(string id, int tenant)
        {
            IQueryable<CSICP_GG033> query = CriaQueryBase(tenant);
            query = query.Where(e => e.Id == id);

            CSICP_GG033? csicpGG033Entity = await query.FirstOrDefaultAsync();
            if (csicpGG033Entity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return csicpGG033Entity;
        }


        public async Task<(IEnumerable<CSICP_GG033>, int)> GetListAsync
            (int tenant,
            string? search,
            string? GG032_ID,
            int pageSize, int page)
        {
            IQueryable<CSICP_GG033> query = CriaQueryBase(tenant);

            query = FiltraQuandoExisteFiltros(query, search, GG032_ID);

            query = query.PaginacaoNoBanco(page, pageSize);

            int count = query.GetCountTotal();

            List<CSICP_GG033> listaCSICP_GG033 = await query.ToListAsync();
            return (listaCSICP_GG033, count);
        }

        private IQueryable<CSICP_GG033> CriaQueryBase(int tenant)
        {
            IQueryable<CSICP_GG033> query = from _CSICP_GG033 in _appDbContext.OsusrE9aCsicpGg033s
                                            where _CSICP_GG033.TenantId == tenant

                                            join gg520 in _appDbContext.OsusrE9aCsicpGg520s
                                            on _CSICP_GG033.Gg033Saldoid equals gg520.Id into gg520Join
                                            from gg520 in gg520Join.DefaultIfEmpty()

                                            join gg008kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes
                                            on gg520.Gg520KardexId equals gg008kdx.Gg008Kardexid into gg008kdxJoin
                                            from gg008kdx in gg008kdxJoin.DefaultIfEmpty()

                                            join gg008 in _appDbContext.OsusrE9aCsicpGg008s
                                            on gg008kdx.Gg008Produtoid equals gg008.Id into gg008Join
                                            from gg008 in gg008Join.DefaultIfEmpty()

                                            select new CSICP_GG033
                                            {
                                                TenantId = _CSICP_GG033.TenantId,
                                                Id = _CSICP_GG033.Id,
                                                Gg033Filialid = _CSICP_GG033.Gg033Filialid,
                                                Gg032Id = _CSICP_GG033.Gg032Id,
                                                Gg033Saldoid = _CSICP_GG033.Gg033Saldoid,
                                                Gg033Produto = _CSICP_GG033.Gg033Produto,
                                                Gg033Codigobarras = _CSICP_GG033.Gg033Codigobarras,
                                                Gg033Datareferente = _CSICP_GG033.Gg033Datareferente,
                                                Gg033Qtdinventario = _CSICP_GG033.Gg033Qtdinventario,
                                                Gg033Saldoestoque = _CSICP_GG033.Gg033Saldoestoque,
                                                Gg033Qtdajuste = _CSICP_GG033.Gg033Qtdajuste,
                                                Gg033Entsai = _CSICP_GG033.Gg033Entsai,
                                                Gg033Precocusto = _CSICP_GG033.Gg033Precocusto,
                                                Gg033Precocustoreal = _CSICP_GG033.Gg033Precocustoreal,
                                                Gg033Precocustomedio = _CSICP_GG033.Gg033Precocustomedio,
                                                Gg033Precovenda = _CSICP_GG033.Gg033Precovenda,
                                                Gg033Datafechanterior = _CSICP_GG033.Gg033Datafechanterior,
                                                Gg033Qtdfechanterior = _CSICP_GG033.Gg033Qtdfechanterior,
                                                Gg033Naoinventariar = _CSICP_GG033.Gg033Naoinventariar,
                                                Gg033Alterado = _CSICP_GG033.Gg033Alterado,
                                                Gg033NnGrupoId = _CSICP_GG033.Gg033NnGrupoId,
                                                Gg033NnClasseId = _CSICP_GG033.Gg033NnClasseId,
                                                Gg033NnMarcaId = _CSICP_GG033.Gg033NnMarcaId,
                                                Gg033NnArtigoId = _CSICP_GG033.Gg033NnArtigoId,
                                                Gg033NnLinhaId = _CSICP_GG033.Gg033NnLinhaId,
                                                Gg033NnSubgrupoId = _CSICP_GG033.Gg033NnSubgrupoId,
                                                Gg033QuemdigitouUserId = _CSICP_GG033.Gg033QuemdigitouUserId,
                                                Gg033QuemcontouUserid = _CSICP_GG033.Gg033QuemcontouUserid,
                                                Gg033Posicao = _CSICP_GG033.Gg033Posicao,
                                                Gg033Codbarrasalfa = _CSICP_GG033.Gg033Codbarrasalfa,
                                                NavGG033_Saldo = gg520 != null ? new CSICP_GG520
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
                                                    Nav_GG008Kardex = gg008kdx != null ? new CSICP_GG008Kdx
                                                    {
                                                        TenantId = gg008kdx.TenantId,
                                                        Gg008Kardexid = gg008kdx.Gg008Kardexid,
                                                        NavGG008Produto = gg008 != null ? new CSICP_GG008
                                                        {
                                                            TenantId = gg008.TenantId,
                                                            Id = gg008.Id,
                                                            Gg008Descreduzida = gg008.Gg008Descreduzida,
                                                            Gg008Codgproduto = gg008.Gg008Codgproduto
                                                        } : null
                                                    } : null
                                                } : null
                                            };


            return query;
        }


        private static IQueryable<CSICP_GG033> FiltraQuandoExisteFiltros
            (IQueryable<CSICP_GG033> query,
            string? search,
            string? GG032_ID
            )
        {
            if (search is not null)
            {

            }

            if (GG032_ID is not null)
                query = query.Where(e => e.Gg032Id == GG032_ID);


            return query;
        }


    }
}

