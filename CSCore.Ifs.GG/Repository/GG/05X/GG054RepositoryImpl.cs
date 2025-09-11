using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.CS_QueryFilters.Specific;
using CSCore.Domain.Interfaces.GG._05X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CSCore.Ifs.Repository.GG._05X
{
    public class GG054RepositoryImpl(AppDbContext appDbContext,
        ICS_GenerateId cS_GenerateId,
        IGenerateProtocolo generateProtocolo)
        : RepositorioBaseImpl<CSICP_GG054>(appDbContext),
        IGG054Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly ICS_GenerateId _cS_GenerateId = cS_GenerateId;
        private readonly IGenerateProtocolo _generateProtocolo = generateProtocolo;

        public async Task<CSICP_GG054?> GetByIdAsync(int tenant, long id)
        {
            IQueryable<CSICP_GG054> query = CriaQueryBaseGG054(tenant);
            CSICP_GG054? csicpGg030Entity = await query.FirstOrDefaultAsync(e => e.Gg054Id == id);
            if (csicpGg030Entity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return csicpGg030Entity;
        }


        public async Task<(IEnumerable<CSICP_GG054>, int)> GetListAsync(int tenant, int pageSize, int page,
            string? Search, string? GG001_ID, int? GG054_StatusID, DateTime DataInicial, DateTime DataFinal)
        {
            IQueryable<CSICP_GG054> query = CriaQueryBaseGG054(tenant);

            query = FiltrosNecessariosEntidade(query, Search, GG001_ID, GG054_StatusID, DataInicial, DataFinal);
            query = query.PaginacaoNoBanco(page, pageSize);

            int count = query.GetCountTotal();

            List<CSICP_GG054> listaCSICP_GG054 = await query.ToListAsync();
            return (listaCSICP_GG054, count);


        }

        public async Task GerarInventario(GG054GeraInventarioParametros prm)
        {

            using (var transaction = await _appDbContext.Database.BeginTransactionAsync())
            {
                string bb001_filialID = "";
                try
                {
                    IQueryable<CSICP_GG054> query = CriaQueryBaseGG054(prm.tenant);
                    query = query.Where(e => e.Gg054DocInvent.Equals(prm.DocInventario));
                    query = query.Where(e => e.Gg054Status == prm.IdGG054_Sta_Aberto);

                    List<CSICP_GG054> listaColeta_GG054 = await query.ToListAsync();
                    if (listaColeta_GG054.Count == 0) throw new Exception("Lista de coleta vazia");

                    List<string?> listaAlmoxDistintos = listaColeta_GG054
                        .Select(e => e.Gg054Almox)
                        .Distinct()
                        .ToList();

                    var SelectedAlmoxFilial = listaColeta_GG054.Select(e => new { e.Gg054Almox, e.Gg054Filialid }).FirstOrDefault();

                    bb001_filialID = SelectedAlmoxFilial.Gg054Filialid;

                    if (listaAlmoxDistintos.Count > 1)
                        throw new Exception("Coletas com Almoxarifados Diferentes");



                    string v_GG032_ID = _cS_GenerateId.GenerateUuId();
                    if (MovimentoInventarioIdTaVazio(prm.Prm_GG032_Prt))
                    {
                        decimal protocolo = await _generateProtocolo
                            .Fcn_ProtocoloGeral(bb001_filialID, prm.tenant);
                        CSICP_GG032 entidadeParaSalvar = new CSICP_GG032
                        {
                            Id = v_GG032_ID,
                            TenantId = prm.tenant,
                            Gg032Filialid = bb001_filialID,
                            Gg032Usuarioid = prm.sy001_usuarioID,
                            Gg032Datamovimento = DateTime.Now.ToLocalTime().Date,
                            Gg032Observacao = "Gerado Via Coleta",
                            Gg032Almoxid = SelectedAlmoxFilial?.Gg054Almox,
                            Gg032TipoinventarioId = prm.csicp_gg032_TpInv_NormalID,
                            Gg032StatusId = prm.csicp_gg032_Sta_SolicitadoID,
                            Gg032Protocolnumber = protocolo.ToString()
                        };
                        _appDbContext.Add(entidadeParaSalvar);
                        await _appDbContext.SaveChangesAsync();
                    }



                    if (MovimentoInventarioIdTaVazio(prm.Prm_GG032_Prt) is false)
                    {
                        IQueryable<CSICP_GG032> queryProdutosColetaGG032 = from _CSICP_GG032 in _appDbContext.OsusrE9aCsicpGg032s
                                                                           where _CSICP_GG032.TenantId == prm.tenant
                                                                           where _CSICP_GG032.Gg032Protocolnumber == prm.Prm_GG032_Prt
                                                                           select _CSICP_GG032;
                        CSICP_GG032? GG032Corrente = await queryProdutosColetaGG032.FirstOrDefaultAsync() 
                            ?? throw new KeyNotFoundException("Movimento do inventário não encontrado");
                        v_GG032_ID = GG032Corrente.Id;
                        if (GG032Corrente.Gg032StatusId == prm.csicp_gg032_Sta_SolicitadoID)
                        {
                            throw new Exception("O Inventário precisa está com STATUS Solicitado");
                        }
                    }


                    //PRODUTOS DA COLETA 5,10 -> LISTA DE IDS
                    List<long> gg054_ListaIDS = listaColeta_GG054
                        .Select(gg054 => gg054.Gg054Id)
                    .ToList();


                    IQueryable<CSICP_GG055> queryProdutosColetaGG055 = from _CSICP_GG055 in _appDbContext.OsusrE9aCsicpGg055s
                                                                       where _CSICP_GG055.Gg055Criarexcid == prm.cc081Exec_Criar_ID
                                                                       where _CSICP_GG055.TenantId == prm.tenant

                                                                       join _GG520_SALDO in _appDbContext.OsusrE9aCsicpGg520s
                                                                       on _CSICP_GG055.Gg055Saldoid equals _GG520_SALDO.Id

                                                                       join _GG008_KDX in _appDbContext.OsusrE9aCsicpGg008Kdxes
                                                                       on _CSICP_GG055.Gg055KdxId equals _GG008_KDX.Gg008Kardexid

                                                                       //aqui estamos invocando uma clausula in no sql devido ao parametro lista
                                                                       where gg054_ListaIDS.Contains(_CSICP_GG055.Gg054Id ?? -1)
                                                                       select new CSICP_GG055
                                                                       {
                                                                           TenantId = _CSICP_GG055.TenantId,
                                                                           Gg055Id = _CSICP_GG055.Gg055Id,
                                                                           Gg054Id = _CSICP_GG055.Gg054Id,
                                                                           Gg055Codgproduto = _CSICP_GG055.Gg055Codgproduto,
                                                                           Gg055Codgbarras = _CSICP_GG055.Gg055Codgbarras,
                                                                           Gg055ProdutoId = _CSICP_GG055.Gg055ProdutoId,
                                                                           Gg055Saldoid = _CSICP_GG055.Gg055Saldoid,
                                                                           Gg055KdxId = _CSICP_GG055.Gg055KdxId,
                                                                           Gg055Unidade = _CSICP_GG055.Gg055Unidade,
                                                                           Gg055Gradelinhaid = _CSICP_GG055.Gg055Gradelinhaid,
                                                                           Gg055Gradecolunaid = _CSICP_GG055.Gg055Gradecolunaid,
                                                                           Gg055Lote = _CSICP_GG055.Gg055Lote,
                                                                           Gg055Sublote = _CSICP_GG055.Gg055Sublote,
                                                                           Gg055Quantidade = _CSICP_GG055.Gg055Quantidade,
                                                                           Gg055Status = _CSICP_GG055.Gg055Status,
                                                                           Gg055UsuarioId = _CSICP_GG055.Gg055UsuarioId,
                                                                           Gg055DataInc = _CSICP_GG055.Gg055DataInc,
                                                                           Gg055HoraInc = _CSICP_GG055.Gg055HoraInc,
                                                                           Gg055UsuarioAlt = _CSICP_GG055.Gg055UsuarioAlt,
                                                                           Gg055DataAlt = _CSICP_GG055.Gg055DataAlt,
                                                                           Gg055HoraAlt = _CSICP_GG055.Gg055HoraAlt,
                                                                           Gg055Criarexcid = _CSICP_GG055.Gg055Criarexcid,
                                                                           Nav_GG520Saldo = new CSICP_GG520
                                                                           {
                                                                               Gg520Saldo = _GG520_SALDO.Gg520Saldo
                                                                           },
                                                                           Nav_Gg008Kdx = new CSICP_GG008Kdx
                                                                           {
                                                                               Gg008PrecoCusto = _GG008_KDX.Gg008PrecoCusto,
                                                                               Gg008PrecoCustoReal = _GG008_KDX.Gg008PrecoCustoReal,
                                                                               Gg008CustoMedio = _GG008_KDX.Gg008CustoMedio,
                                                                               Gg008PrcVendavarejo = _GG008_KDX.Gg008PrcVendavarejo
                                                                           }
                                                                       };

                    List<CSICP_GG055> ListaProdutos = await queryProdutosColetaGG055.ToListAsync();
                    var ListaProdutosAgrupados =
                        ListaProdutos.GroupBy(p =>
                        new
                        {
                            p.Gg055ProdutoId,
                            p.Gg055Saldoid,
                            p.Gg055KdxId,
                            p.Gg055Codgproduto,
                            p.Gg055Codgbarras
                        })
                        .Select(g => new
                        {
                            ProdutoID = g.Key.Gg055ProdutoId,
                            SaldoID = g.Key.Gg055Saldoid,
                            KardexID = g.Key.Gg055KdxId,
                            CodigoProduto = g.Key.Gg055Codgproduto,
                            CodigoBarra = g.Key.Gg055Codgbarras,
                            QuantidadeTotal = g.Sum(p => p.Gg055Quantidade),
                            Saldo = g.Max(p => p.Nav_GG520Saldo!.Gg520Saldo),
                            PrecoReposicao = g.Max(p => p.Nav_Gg008Kdx!.Gg008PrecoReposicao),
                            PrecoVenda = g.Max(p => p.Nav_Gg008Kdx!.Gg008PrecoVendaLiq),
                            PrecoReal = g.Max(p => p.Nav_Gg008Kdx!.Gg008PrecoCustoReal),
                            CustoMedio = g.Max(p => p.Nav_Gg008Kdx!.Gg008CustoMedio),
                        }).ToList();



                    foreach (var currentProdutoGrupado in ListaProdutosAgrupados)
                    {
                        string uuid = _cS_GenerateId.GenerateUuId();
                        CSICP_GG033 entidadeGG033 = new()
                        {
                            Id = uuid,
                            TenantId = prm.tenant,
                            Gg032Id = v_GG032_ID,
                            Gg033Filialid = bb001_filialID,
                            Gg033Saldoid = currentProdutoGrupado.SaldoID,
                            Gg033Produto = currentProdutoGrupado.CodigoProduto,
                            Gg033Codbarrasalfa = currentProdutoGrupado.CodigoBarra,
                            Gg033Qtdinventario = currentProdutoGrupado.QuantidadeTotal,
                            Gg033Datareferente = DateTime.UtcNow.ToLocalTime(),
                            Gg033Saldoestoque = currentProdutoGrupado.Saldo,
                            Gg033Precocusto = currentProdutoGrupado.PrecoReposicao,
                            Gg033Precocustoreal = currentProdutoGrupado.PrecoReal,
                            Gg033Precocustomedio = currentProdutoGrupado.CustoMedio,
                            Gg033Precovenda = currentProdutoGrupado.PrecoVenda,
                            Gg033Alterado = true,
                        };
                        _appDbContext.Add(entidadeGG033);
                        await _appDbContext.SaveChangesAsync();
                    }

                    IQueryable<CSICP_GG054> queryGG054 = CriaQueryBaseGG054(prm.tenant);
                    queryGG054 = queryGG054.Where(e => gg054_ListaIDS.Contains(e.Gg054Id));
                    List<CSICP_GG054> listaGG054ParaAtualizar = await queryGG054.ToListAsync();
                    foreach (var currentGG054 in listaGG054ParaAtualizar)
                    {
                        currentGG054.Gg032Id = v_GG032_ID;
                        currentGG054.Gg054Status = prm.GG054Sta_Inventariado_ID;
                        _appDbContext.Update(currentGG054);
                        await _appDbContext.SaveChangesAsync();
                    }
                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
                }
            }
        }

        private static bool MovimentoInventarioIdTaVazio(string Prm_GG032_Prt)
        {
            return string.IsNullOrEmpty(Prm_GG032_Prt);
        }


        private IQueryable<CSICP_GG054> CriaQueryBaseGG054(int tenant)
        {

            IQueryable<CSICP_GG054> query = from _CSICP_GG054 in _appDbContext.OsusrE9aCsicpGg054s
                                            where _CSICP_GG054.TenantId == tenant

                                            join gg001 in _appDbContext.CSICP_GG001s
                                            on _CSICP_GG054.Gg054Almox equals gg001.Id into gg001_join
                                            from gg001 in gg001_join.DefaultIfEmpty()

                                            join gg054_sta in _appDbContext.OsusrE9aCsicpGg054Sta
                                            on _CSICP_GG054.Gg054Status equals gg054_sta.Id into gg054_sta_join
                                            from gg054_sta in gg054_sta_join.DefaultIfEmpty()

                                            select new CSICP_GG054
                                            {

                                                TenantId = _CSICP_GG054.TenantId,
                                                Gg054Id = _CSICP_GG054.Gg054Id,
                                                Gg054Filialid = _CSICP_GG054.Gg054Filialid,
                                                Gg054Protocolnumber = _CSICP_GG054.Gg054Protocolnumber,
                                                Gg054UsuarioId = _CSICP_GG054.Gg054UsuarioId,
                                                Gg054DataColeta = _CSICP_GG054.Gg054DataColeta,
                                                Gg054Observacao = _CSICP_GG054.Gg054Observacao,
                                                Gg054Status = _CSICP_GG054.Gg054Status,
                                                Gg054Almox = _CSICP_GG054.Gg054Almox,
                                                Gg054DataInc = _CSICP_GG054.Gg054DataInc,
                                                Gg054HoraInc = _CSICP_GG054.Gg054HoraInc,
                                                Gg054DataAlt = _CSICP_GG054.Gg054DataAlt,
                                                Gg054HoraAlt = _CSICP_GG054.Gg054HoraAlt,
                                                Gg054UsuarioAlt = _CSICP_GG054.Gg054UsuarioAlt,
                                                Gg032Id = _CSICP_GG054.Gg032Id,
                                                Gg054DocInvent = _CSICP_GG054.Gg054DocInvent,
                                                Gg054Ismarcado = _CSICP_GG054.Gg054Ismarcado,
                                                NavGG001Almox = gg001 == null ? null : new CSICP_GG001
                                                {
                                                    Id = gg001.Id,
                                                    Gg001Descalmox = gg001.Gg001Descalmox,
                                                    Gg001Codigoalmox = gg001.Gg001Codigoalmox
                                                },
                                                Gg054StatusNavigation = gg054_sta != null ? gg054_sta : null
                                            };


            return query;
        }

        private static IQueryable<CSICP_GG054> FiltrosNecessariosEntidade
         (IQueryable<CSICP_GG054> query, string? Search, string? GG001_ID, int? GG054_StatusID, DateTime DataInicial, DateTime DataFinal)
        {
            query = query.Where(e => e.Gg054DataColeta >= DataInicial && e.Gg054DataColeta <= DataFinal);

            if (Search is not null) query.Where(e => e.Gg054Protocolnumber != null && e.Gg054Protocolnumber.Contains(Search) ||
                                                e.Gg054DocInvent != null && e.Gg054DocInvent.Contains(Search));

            if (GG001_ID is not null) query = query.Where(e => e.Gg054Almox == GG001_ID);
            if (GG054_StatusID is not null) query = query.Where(e => e.Gg054Status == GG054_StatusID);

            return query;
        }

    }
}
