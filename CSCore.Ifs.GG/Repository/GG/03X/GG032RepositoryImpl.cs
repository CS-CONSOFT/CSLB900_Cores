using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_QueryFilters.GG032;
using CSCore.Domain.Interfaces.GG._03X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.Extrato;
using CSCore.Ifs.GG.Repository.GG._03X;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._03X
{
    public enum TIPO_ACAO_INVENTARIO
    {
        BLOQUEAR = 1,
        DESBLOQUEAR = 2
    }



    public class ValoresGG032Totais
    {
        public decimal TotalCusto { get; set; }
        public decimal TotalCustoReal { get; set; }
        public decimal TotalCustoMedio { get; set; }
        public decimal TotalCustoVenda { get; set; }
        public int TotalListaSaldo { get; set; }
    }



    public class GG032RepositoryImpl(
        AppDbContext appDbContext,
        IGeraExtrato geraExtrato,
        ICS_GenerateId generateId,
        IGerarInventarioEmMassa gerarInventarioEmMassa) :
        RepositorioBaseImpl<CSICP_GG032>(appDbContext), IGG032Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly IGeraExtrato _geraExtrato = geraExtrato;
        private readonly ICS_GenerateId _generateId = generateId;
        private readonly IGerarInventarioEmMassa _gerarInventarioEmMassa = gerarInventarioEmMassa;


        public async Task<CSICP_GG032?> GetByIdAsync(int tenant, string id)
        {
            IQueryable<CSICP_GG032> query = CriaQueryBase(tenant);
            query = query.Where(e => e.Id == id);

            CSICP_GG032? csicpGg030Entity = await query.FirstOrDefaultAsync();
            if (csicpGg030Entity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return csicpGg030Entity;
        }

        public async Task<(IEnumerable<CSICP_GG032>, int)> GetListAsync(int tenant, int pageSize, int page,
             string? search,
             int? codigo,
             int? GG032Status_ID,
             DateTime DataInicial,
             DateTime DataFinal
            )
        {
            IQueryable<CSICP_GG032> query = CriaQueryBase(tenant);

            query = FiltraQuandoExisteFiltros(query, search, GG032Status_ID, DataInicial, DataFinal);

            if (codigo is not null)
            {
                query = query.Where(e => e.Gg032Codgalmox == codigo);
            }

            query = query.PaginacaoNoBanco(page, pageSize);



            int count = query.GetCountTotal();

            List<CSICP_GG032> listaCSICP_GG032 = await query.ToListAsync();
            return (listaCSICP_GG032, count);
        }

        /// <summary>
        /// Bloqueia ou desbloqueia o inventário. 
        /// 1 - bloquear || 2 - desbloquear
        /// </summary>
        public async Task CS_BloquearDesbloquearInventario(
            int tenant, string in_InventarioId,
            int in_StID_gg032_Sta_Bloqueado_ID,
            int in_StID_csicp_gg032_Sta_Solicitado_ID,
            int in_tipoAcaoInventario)
        {
            var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {

                /*
                    1	Bloqueado	
                    2	Solicitado	
                    3	Concluído	
                 */
                CSICP_GG032 gg032inventario = await GetInventarioParaTrabalhoAsync(tenant, in_InventarioId);

                if (EhAcaoDesbloquear(in_tipoAcaoInventario) &&
                    InventarioStatusDifenteBloqueado(in_StID_gg032_Sta_Bloqueado_ID, gg032inventario))
                    throw new Exception("Inventário deve estar como BLOQUEADO para poder ser desbloqueado!");

                if (EhAcaoBloquear(in_tipoAcaoInventario) &&
                    InventarioStatusDiferenteDeSolicitado(in_StID_csicp_gg032_Sta_Solicitado_ID, gg032inventario))
                    throw new Exception("Inventário deve estar como SOLICITADO para poder ser bloqueado!");

                List<CSICP_GG033> listgg033 = await GetInventarioProdutosAsync(tenant, gg032inventario);

                foreach (var gg033item in listgg033)
                {
                    CSICP_GG520? saldoEncontrado = await GetSaldoParaTrabalhoAsync(tenant, gg033item);

                    if (saldoEncontrado == null) continue;


                    saldoEncontrado.Gg520ItemEmContagem = EhAcaoBloquear(in_tipoAcaoInventario) ? true : false;
                    gg033item.Gg033Saldoestoque = saldoEncontrado.Gg520Saldo;

                    _appDbContext.OsusrE9aCsicpGg520s.Update(saldoEncontrado);
                    _appDbContext.OsusrE9aCsicpGg033s.Update(gg033item);
                }

                gg032inventario.Gg032StatusId = EhAcaoBloquear(in_tipoAcaoInventario) ? in_StID_gg032_Sta_Bloqueado_ID : in_StID_csicp_gg032_Sta_Solicitado_ID;
                gg032inventario.Gg032DataHoraBloqueado = DateTime.Now.ToLocalTime();

                _appDbContext.OsusrE9aCsicpGg032s.Update(gg032inventario);
                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }


        public async Task<string> CS_GeradorInventarioEmMassa(
            int in_tenantId, int in_StID_EntitiesGG001TAlmox_Virtual, bool isQtdZero, FiltroProdutoRequest request)
        {
            return await _gerarInventarioEmMassa
                .CS_GeradorInventarioEmMassa(in_tenantId, isQtdZero, in_StID_EntitiesGG001TAlmox_Virtual, request);
        }


        public async Task CS_InventarioProcessar(
            int tenant,
            string in_InventarioId,
            int in_StID_GG032_Sta_Bloqueado_ID,
            int in_StID_GG032_Sta_Concluido_ID,
            int in_StID_GG028_EntSaida_Saida_ID,
            int in_StID_GG028_EntSaida_Entrada_ID,
            int in_StID_GG028_Nat_Inventario_ID)
        {
            var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                CSICP_GG032 gg032inventario = await GetInventarioParaTrabalhoAsync(tenant, in_InventarioId);

                if (InventarioStatusDifenteBloqueado(in_StID_GG032_Sta_Bloqueado_ID, gg032inventario))
                    throw new Exception("Inventário deve estar como BLOQUEADO para poder ser processado!");

                List<CSICP_GG033> listgg033 = await GetInventarioProdutosAsync(tenant, gg032inventario);

                await ProcessaProdutosInventarioEAtualizaSaldoEProdutoAsync
                    (tenant, in_StID_GG028_EntSaida_Saida_ID, in_StID_GG028_EntSaida_Entrada_ID,
                    in_StID_GG028_Nat_Inventario_ID, gg032inventario, listgg033);

                gg032inventario.Gg032StatusId = in_StID_GG032_Sta_Concluido_ID;
                gg032inventario.Gg032QtosPodutos = listgg033.Count;
                gg032inventario.Gg032DataHoraProcessado = DateTime.Now.ToLocalTime();


                _appDbContext.Update(gg032inventario);
                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }

        }



        private async Task ProcessaProdutosInventarioEAtualizaSaldoEProdutoAsync(
            int tenant, int in_StID_EntSaida_Saida_ID, int in_StID_EntSaida_Entrada_ID,
            int in_StID_Nat_Inventario_ID, CSICP_GG032 gg032inventario, List<CSICP_GG033> listgg033)
        {
            foreach (var currProduto in listgg033)
            {
                if (ProdutoNaoEstaMarcadoParaInventariar(currProduto))
                {
                    gg032inventario.Gg032QtosNaoinventariado += 1;
                    continue;
                }

                if (ProdutoNaoFoiAlterado(currProduto))
                    throw new Exception($"Algum produto não foi alterado, não é possível processar o inventário!");

                CSICP_GG520? saldoEncontrado = await GetSaldoParaTrabalhoAsync(tenant, currProduto);
                if (saldoEncontrado is null) continue;

                currProduto.Gg033Qtdajuste = QuantidadeInventarioEhIgualSaldo(currProduto, saldoEncontrado) ? 0
                 : QuantidadeInventarioEhMaiorQueSaldo(currProduto, saldoEncontrado)
                 ? currProduto.Gg033Qtdinventario - saldoEncontrado.Gg520Saldo
                 : saldoEncontrado.Gg520Saldo - currProduto.Gg033Qtdinventario;

                currProduto.Gg033Entsai
                    = QuantidadeInventarioEhMenorQueSaldo(currProduto, saldoEncontrado) ? "S" : "E";


                currProduto.Gg033Datareferente = DateTime.Now.ToLocalTime();

                var V_SaldoAnteriorProduto = saldoEncontrado.Gg520Saldo;

                saldoEncontrado.Gg520ItemEmContagem = false;
                saldoEncontrado.Gg520Ultinventario = DateTime.Now.ToLocalTime();

                saldoEncontrado.Gg520Saldo = EhEntrada(currProduto)
                    ? saldoEncontrado.Gg520Saldo + currProduto.Gg033Qtdajuste ?? 0
                    : saldoEncontrado.Gg520Saldo - currProduto.Gg033Qtdajuste ?? 0;

                saldoEncontrado.NavGG001Almox = null;
                saldoEncontrado.NavGG016Gradecoluna = null;
                saldoEncontrado.NavGG016Gradlinha = null;
                saldoEncontrado.Nav_GG008Kardex = null;

                _appDbContext.Update(saldoEncontrado);
                await _appDbContext.SaveChangesAsync();

                await _geraExtrato.CS_CriaExtratoOrigem(
                        inTenant: tenant,
                        inGG028_ORIGEMPROGRAMA: "GG032",
                        inGG028_ORIGEM_PKID: currProduto.Id,
                        inGG028_ORIGEM_DOC_PKID: gg032inventario.Id,
                        inGG028_DATA_MOVIMENTO: gg032inventario.Gg032Datamovimento,
                        inGG028_ALMOXID: gg032inventario.Gg032Almoxid,
                        inGG028_SALDOID: currProduto.Gg033Saldoid,
                        inGG028_TRANSACAOID: null,
                        inGG028_CONTAID: null,
                        inGG028_USUARIOID: gg032inventario.Gg032Usuarioid,
                        inGG028_QTD_MOVIMENTO: currProduto.Gg033Qtdajuste,
                        inGG028_VALOR_UNITARIO: currProduto.Gg033Precocusto,
                        inGG028_SALDO_ANTERIOR: V_SaldoAnteriorProduto,
                        inGG028_N_PDV: null,
                        inProtocolo_Documento: gg032inventario.Gg032Protocolnumber,
                        inGG028_NF_OU_CUPOM: null,
                        inEntSaida_ID: EhEntrada(currProduto) ? in_StID_EntSaida_Entrada_ID : in_StID_EntSaida_Saida_ID,
                        inNatureza_ID: in_StID_Nat_Inventario_ID
                    );


                if (NaoEstaEmConformidade(gg032inventario, currProduto))
                    InvetarioGeraLista_NC_PI(gg032inventario, currProduto);


                _appDbContext.Update(currProduto);
            }
        }

        private void InvetarioGeraLista_NC_PI(CSICP_GG032 gg032inventario, CSICP_GG033 currProduto)
        {
            var id = _generateId.GenerateUuId();
            gg032inventario.Gg032QtosNaoconform += 1;
            var gg037 = new CSICP_GG037
            {
                Gg037Id = id,
                Gg037FilialId = gg032inventario.Gg032Filialid,
                Gg037InventarioId = gg032inventario.Id,
                Gg037SaldoId = currProduto.Gg033Saldoid,
                Gg037QtdNconfirmidade = currProduto.Gg033Qtdajuste,
                Gg037GeradoListaInv = true
            };

            var id_2 = _generateId.GenerateUuId();
            var gg036 = new CSICP_GG036
            {
                Id = id_2,
                Gg036Filialid = gg032inventario.Gg032Filialid,
                Gg036Saldoid = currProduto.Gg033Saldoid,
                Gg036Dataregistro = DateTime.Now.ToLocalTime(),
                Gg036Mensagem = "GERADO DE LISTA DE NÃO CONFORMIDADE",

            };

            _appDbContext.Add(gg037);
            _appDbContext.Add(gg036);
        }

        private static bool NaoEstaEmConformidade(CSICP_GG032 gg032inventario, CSICP_GG033 currProduto)
        {
            return EstaEmConformidade(gg032inventario, currProduto) == false;
        }

        private static bool EstaEmConformidade(CSICP_GG032 gg032inventario, CSICP_GG033 currProduto)
        {
            return EhSaida(currProduto) &&
                                    (gg032inventario.Gg032QtdRegraNconf * -1) < (currProduto.Gg033Qtdajuste * -1);
        }

        private static bool EhEntrada(CSICP_GG033 currProduto)
        {
            return currProduto.Gg033Entsai == "E";
        }

        private static bool EhSaida(CSICP_GG033 currProduto)
        {
            return currProduto.Gg033Entsai == "S";
        }

        private static bool QuantidadeInventarioEhIgualSaldo(CSICP_GG033 currProduto, CSICP_GG520 saldoEncontrado)
        {
            return currProduto.Gg033Qtdinventario == saldoEncontrado.Gg520Saldo;
        }

        private static bool QuantidadeInventarioEhMaiorQueSaldo(CSICP_GG033 currProduto, CSICP_GG520 saldoEncontrado)
        {
            return currProduto.Gg033Qtdinventario > saldoEncontrado.Gg520Saldo;
        }

        private static bool QuantidadeInventarioEhMenorQueSaldo(CSICP_GG033 currProduto, CSICP_GG520 saldoEncontrado)
        {
            return currProduto.Gg033Qtdinventario < saldoEncontrado.Gg520Saldo;
        }

        private static bool ProdutoNaoFoiAlterado(CSICP_GG033 currProduto)
        {
            return currProduto.Gg033Alterado == false;
        }

        private static bool ProdutoNaoEstaMarcadoParaInventariar(CSICP_GG033 current)
        {
            return current.Gg033Naoinventariar == true;
        }

        private static IQueryable<CSICP_GG032> FiltraQuandoExisteFiltros
           (IQueryable<CSICP_GG032> query,
           string? search,
           int? GG032Status_ID,
           DateTime DataInicial,
           DateTime DataFinal
           )
        {
            query = query
                .Where(e => e.Gg032Datamovimento >= DataInicial && e.Gg032Datamovimento <= DataFinal);

            if (search is not null)
            {
                query = query.Where(e => e.Gg032Protocolnumber != null &&
                                    e.Gg032Protocolnumber.Contains(search));

            }

            if (GG032Status_ID is not null)
                query = query.Where(e => e.Gg032StatusId == GG032Status_ID);


            return query;
        }

        private async Task<CSICP_GG520?> GetSaldoParaTrabalhoAsync(int tenant, CSICP_GG033 gg033item)
        {
            IQueryable<CSICP_GG520> querygg520 = GetQueryGG520(tenant, gg033item);
            CSICP_GG520? saldoEncontrado = await querygg520.FirstOrDefaultAsync();
            return saldoEncontrado;
        }


        private async Task<CSICP_GG032> GetInventarioParaTrabalhoAsync(int tenant, string Parametro_InventarioId)
        {
            var queryInventario = CriaQueryBase(tenant);
            queryInventario = queryInventario.Where(e => e.Id == Parametro_InventarioId);

            CSICP_GG032 gg032inventario = await queryInventario.FirstOrDefaultAsync()
                ?? throw new KeyNotFoundException("Inventário não foi encontrado!");
            return gg032inventario;
        }

        private async Task<List<CSICP_GG033>> GetInventarioProdutosAsync(int tenant, CSICP_GG032 gg032inventario)
        {
            var querygg033 = from _gg033 in _appDbContext.OsusrE9aCsicpGg033s
                             where _gg033.TenantId == tenant
                             where _gg033.Gg032Id == gg032inventario.Id
                             select _gg033;

            List<CSICP_GG033> listgg033 = await querygg033.ToListAsync();
            if (listgg033 == null || !listgg033.Any())
            {
                throw new Exception("Não foram selecionados produtos para este inventário!");
            }
            return listgg033;
        }

        private static bool InventarioStatusDiferenteDeSolicitado(int Parametro_csicp_gg032_Sta_Solicitado_ID, CSICP_GG032 gg032inventario)
        {
            return gg032inventario.Gg032StatusId != Parametro_csicp_gg032_Sta_Solicitado_ID;
        }

        private static bool EhAcaoBloquear(int in_tipoAcaoInventario)
        {
            return in_tipoAcaoInventario == (int)TIPO_ACAO_INVENTARIO.BLOQUEAR;
        }

        private static bool EhAcaoDesbloquear(int in_tipoAcaoInventario)
        {
            return in_tipoAcaoInventario == (int)TIPO_ACAO_INVENTARIO.DESBLOQUEAR;
        }

        private static bool InventarioStatusDifenteBloqueado(int Parametro_csicp_gg032_Sta_Bloqueado_ID, CSICP_GG032 gg032inventario)
        {
            return gg032inventario.Gg032StatusId != Parametro_csicp_gg032_Sta_Bloqueado_ID;
        }


        private IQueryable<CSICP_GG032> CriaQueryBase(int tenant)
        {
            IQueryable<CSICP_GG032> query = from _CSICP_GG032 in _appDbContext.OsusrE9aCsicpGg032s
                                            where _CSICP_GG032.TenantId == tenant

                                            join _CSICP_BB012 in _appDbContext.OsusrE9aCsicpBb012s
                                            on _CSICP_GG032.Gg032Usuarioid equals _CSICP_BB012.Id into _CSICP_BB012_joined
                                            from _CSICP_BB012 in _CSICP_BB012_joined.DefaultIfEmpty()

                                            join _OsusrE9aCsicpGg032Stum in _appDbContext.OsusrE9aCsicpGg032Sta
                                            on _CSICP_GG032.Gg032StatusId equals _OsusrE9aCsicpGg032Stum.Id into _OsusrE9aCsicpGg032Stum_joined
                                            from _OsusrE9aCsicpGg032Stum in _OsusrE9aCsicpGg032Stum_joined.DefaultIfEmpty()


                                            select new CSICP_GG032
                                            {
                                                TenantId = _CSICP_GG032.TenantId,
                                                Id = _CSICP_GG032.Id,
                                                Gg032Filialid = _CSICP_GG032.Gg032Filialid,
                                                Gg032Usuarioid = _CSICP_GG032.Gg032Usuarioid,
                                                Gg032Filial = _CSICP_GG032.Gg032Filial,
                                                Gg032Datamovimento = _CSICP_GG032.Gg032Datamovimento,
                                                Gg032Observacao = _CSICP_GG032.Gg032Observacao,
                                                Gg032Almoxid = _CSICP_GG032.Gg032Almoxid,
                                                Gg032Codgalmox = _CSICP_GG032.Gg032Codgalmox,
                                                Gg032Totalcusto = _CSICP_GG032.Gg032Totalcusto,
                                                Gg032Totalcreal = _CSICP_GG032.Gg032Totalcreal,
                                                Gg032Totalcmedio = _CSICP_GG032.Gg032Totalcmedio,
                                                Gg032Totalvenda = _CSICP_GG032.Gg032Totalvenda,
                                                Gg032DataHoraBloqueado = _CSICP_GG032.Gg032DataHoraBloqueado,
                                                Gg032DataHoraProcessado = _CSICP_GG032.Gg032DataHoraProcessado,
                                                Gg032QtosPodutos = _CSICP_GG032.Gg032QtosPodutos,
                                                Gg032QtosNaoconform = _CSICP_GG032.Gg032QtosNaoconform,
                                                Gg032QtosNaoinventariado = _CSICP_GG032.Gg032QtosNaoinventariado,
                                                Gg032QtdRegraNconf = _CSICP_GG032.Gg032QtdRegraNconf,
                                                Gg032TipoinventarioId = _CSICP_GG032.Gg032TipoinventarioId,
                                                Gg032StatusId = _CSICP_GG032.Gg032StatusId,
                                                Gg032Protocolnumber = _CSICP_GG032.Gg032Protocolnumber,
                                                NavGG032Status = _OsusrE9aCsicpGg032Stum,
                                                NavBB012Usuario = _CSICP_BB012 != null ? new CSICP_BB012
                                                {
                                                    TenantId = _CSICP_BB012.TenantId,
                                                    Id = _CSICP_BB012.Id,
                                                    Bb012NomeCliente = _CSICP_BB012.Bb012NomeCliente,
                                                    Bb012NomeFantasia = _CSICP_BB012.Bb012NomeFantasia,
                                                    Bb012Codigo = _CSICP_BB012.Bb012Codigo
                                                } : null
                                            };
            return query;
        }

        private IQueryable<CSICP_GG520> GetQueryGG520(int tenant, CSICP_GG033 gg033item)
        {
            return from _gg520 in _appDbContext.OsusrE9aCsicpGg520s
                   where _gg520.TenantId == tenant
                   where _gg520.Id == gg033item.Gg033Saldoid
                   select new CSICP_GG520
                   {
                       Id = _gg520.Id,
                       TenantId = _gg520.TenantId,
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
                   };
        }

    }
}

