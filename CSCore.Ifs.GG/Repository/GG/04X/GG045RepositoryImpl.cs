using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.Interfaces.GG._04X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.BaixaSaldo;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CSCore.Ifs.Repository.GG._04X
{
    public class GG045RepositoryImpl(AppDbContext appDbContext, IBaixaSaldo baixaSaldo) : RepositorioBaseImpl<CSICP_GG045>(appDbContext, "Gg045Id"),
        IGG045Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly IBaixaSaldo _baixaSaldo = baixaSaldo;
        public async Task<CSICP_GG045?> GetByIdAsync(int tenant, string id)
        {
            IQueryable<CSICP_GG045> query = CriaQueryBase(tenant);
            query = query.Where(e => e.Gg045Id == id);

            CSICP_GG045? csicpGg030Entity = await query.FirstOrDefaultAsync();
            if (csicpGg030Entity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return csicpGg030Entity;
        }

        public async Task<(IEnumerable<CSICP_GG045>, int)> GetListAsync(int tenant, int pageSize, int page,
            string? SearchDescricao, string? VSerieNF, string? VNumNF, DateTime DataInicial, DateTime DataFinal)
        {
            IQueryable<CSICP_GG045> query = CriaQueryBase(tenant);

            query = FiltrosNecessariosEntidade(query, SearchDescricao, VSerieNF, VNumNF, DataInicial, DataFinal);
            query = query.PaginacaoNoBanco(page, pageSize);

            int count = query.GetCountTotal();

            List<CSICP_GG045> listaCSICP_GG045 = await query.ToListAsync();
            return (listaCSICP_GG045, count);
        }

        public async Task ProcessarTransferenciaDeSaldo(
            int in_tenant,
            string in_gg045_id,
            int in_StID_csicp_gg045_Stat_Aberto,
            int in_StID_csicp_gg045_Stat_Transferido,
            int in_StID_csicp_gg046_Stat_Saida,
            int in_Prm_EntSaida_GG073EntSaida_Entrada_ID,
            int in_StID_EntSai_GG073_Saida_ID,
            int in_StID_EntSai_GG028_Saida_ID,
            int in_StID_EntSai_GG028_Entrada_ID,
            int in_StID_Gg028NatId,
            int in_StID_StaticaSimNao_SIM_id)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {

                CSICP_GG045 transferenciaSaldo = await GetTransferenciaSaldoGG045(in_tenant, in_gg045_id);

                if (MovimentoAberto(in_StID_csicp_gg045_Stat_Aberto, transferenciaSaldo.Gg045Statid) == false)
                    throw new Exception(
                        "Erro ao tentar processar movimento de Transferencia:" +
                        transferenciaSaldo.Gg045Protocolnumber + " - " + transferenciaSaldo.Gg045Descricao +
                        ", o mesmo deve está aberto!"
                        );

                List<CSICP_GG046> listaTransferenciaSaldoEntradas =
                    await GetListTransferenciaSaldoEntrada(in_tenant, in_gg045_id, in_StID_csicp_gg045_Stat_Aberto);

                for (int i = 0; i < listaTransferenciaSaldoEntradas.Count; i++)
                {
                    await _baixaSaldo.CS_BaixarSaldo(
                        in_tenant,
                        listaTransferenciaSaldoEntradas[i].Gg046SaldoentId,
                        transferenciaSaldo.Gg045Protocolnumber,
                        "GG045",
                        transferenciaSaldo.Gg045UsuariopropId,
                        listaTransferenciaSaldoEntradas[i].Gg046Id,
                        transferenciaSaldo.Gg045Id,
                        transferenciaSaldo.Gg045Datamovto ?? DateTime.UtcNow.ToLocalTime(),
                        listaTransferenciaSaldoEntradas[i].Gg046Qtd ?? 0,
                        //staticas
                        in_Prm_EntSaida_GG073EntSaida_Entrada_ID,
                        in_StID_EntSai_GG073_Saida_ID,
                        in_StID_EntSai_GG028_Saida_ID,
                        in_StID_EntSai_GG028_Entrada_ID,
                        in_StID_Gg028NatId,
                        in_StID_StaticaSimNao_SIM_id);

                    listaTransferenciaSaldoEntradas[i].Gg046StatId = in_StID_csicp_gg045_Stat_Transferido;
                    listaTransferenciaSaldoEntradas[i].Gg046Isnovo = false;
                    listaTransferenciaSaldoEntradas[i].Nav_Gg250Saldoent = null; // Limpa a navegação para evitar problemas de carregamento desnecessário
                    _appDbContext.Update(listaTransferenciaSaldoEntradas[i]);
                }

                transferenciaSaldo.Gg045Statid = in_StID_csicp_gg045_Stat_Transferido;
                _appDbContext.Update(transferenciaSaldo);
                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        private async Task<List<CSICP_GG046>> GetListTransferenciaSaldoEntrada(int in_tenant, string in_gg045_id, int in_StID_csicp_gg045_Stat_Aberto)
        {
            var query = from CSICP_GG046 in _appDbContext.OsusrE9aCsicpGg046s
                        where CSICP_GG046.TenantId == in_tenant
                        && CSICP_GG046.Gg045Id == in_gg045_id
                        && CSICP_GG046.Gg046StatId == in_StID_csicp_gg045_Stat_Aberto

                        join gg520 in _appDbContext.OsusrE9aCsicpGg520s
                        on CSICP_GG046.Gg046SaldoentId equals gg520.Id into gg520Join
                        from gg520 in gg520Join.DefaultIfEmpty()

                        select new CSICP_GG046
                        {
                            TenantId = CSICP_GG046.TenantId,
                            Gg046Id = CSICP_GG046.Gg046Id,
                            Gg046Seq = CSICP_GG046.Gg046Seq,
                            Gg045Id = CSICP_GG046.Gg045Id,
                            Gg046SaldoentId = CSICP_GG046.Gg046SaldoentId,
                            Gg046Qtd = CSICP_GG046.Gg046Qtd,
                            Gg046StatId = CSICP_GG046.Gg046StatId,
                            Gg046EntsaiId = CSICP_GG046.Gg046EntsaiId,
                            Gg046Isnovo = CSICP_GG046.Gg046Isnovo,
                            Gg046Descricaosaldo = CSICP_GG046.Gg046Descricaosaldo,
                            Gg046Codbarrasalfa = CSICP_GG046.Gg046Codbarrasalfa,
                            Nav_Gg250Saldoent = gg520 != null ? new CSICP_GG520
                            {
                                Id = gg520.Id,
                                TenantId = gg520.TenantId,
                                Gg520KardexId = gg520.Gg520KardexId,
                                Gg520Almoxid = gg520.Gg520Almoxid,
                                Gg520NsNumerosaldo = gg520.Gg520NsNumerosaldo,
                                Gg520Saldo = gg520.Gg520Saldo,
                                Gg520DescricaoLote = gg520.Gg520DescricaoLote,
                                Gg520Descricaosaldo = gg520.Gg520Descricaosaldo,
                            } : null,
                        };

            var listaTransferenciaSaldoEntradas = await query.ToListAsync();
            return listaTransferenciaSaldoEntradas;
        }


        private async Task<CSICP_GG045> GetTransferenciaSaldoGG045(int in_tenant, string in_gg045_id)
        {
            var query = from _CSICP_GG045 in _appDbContext.OsusrE9aCsicpGg045s
                        where _CSICP_GG045.TenantId == in_tenant && _CSICP_GG045.Gg045Id == in_gg045_id
                        select new CSICP_GG045
                        {
                            TenantId = _CSICP_GG045.TenantId,
                            Gg045Id = _CSICP_GG045.Gg045Id,
                            Gg045EstabelecimentoId = _CSICP_GG045.Gg045EstabelecimentoId,
                            Gg045Saldoid = _CSICP_GG045.Gg045Saldoid,
                            Gg045Qtd = _CSICP_GG045.Gg045Qtd,
                            Gg045Protocolnumber = _CSICP_GG045.Gg045Protocolnumber,
                            Gg045Datamovto = _CSICP_GG045.Gg045Datamovto,
                            Gg045UsuariopropId = _CSICP_GG045.Gg045UsuariopropId,
                            Gg045Descricao = _CSICP_GG045.Gg045Descricao,
                            Cc040Id = _CSICP_GG045.Cc040Id,
                            Gg045Statid = _CSICP_GG045.Gg045Statid,
                            Cc060Id = _CSICP_GG045.Cc060Id,

                        };
            var transferenciaSaldo = await query.FirstOrDefaultAsync();
            if (transferenciaSaldo is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);
            return transferenciaSaldo;
        }
        private static bool MovimentoAberto(int in_StID_csicp_gg045_Stat_Aberto, int? gg045StatusId)
        {
            return gg045StatusId == in_StID_csicp_gg045_Stat_Aberto;
        }
        private IQueryable<CSICP_GG045> CriaQueryBase(int tenant)
        {
            IQueryable<CSICP_GG045> query = from _CSICP_GG045 in _appDbContext.OsusrE9aCsicpGg045s
                                            where _CSICP_GG045.TenantId == tenant

                                            join GG520 in _appDbContext.OsusrE9aCsicpGg520s
                                            on _CSICP_GG045.Gg045Saldoid equals GG520.Id into GG520Join
                                            from GG520 in GG520Join.DefaultIfEmpty()

                                            join GG008KDX in _appDbContext.OsusrE9aCsicpGg008Kdxes
                                            on GG520.Gg520KardexId equals GG008KDX.Gg008Kardexid into GG008KDXJoin
                                            from GG008KDX in GG008KDXJoin.DefaultIfEmpty()

                                            join GG008 in _appDbContext.OsusrE9aCsicpGg008s
                                            on GG008KDX.Gg008Produtoid equals GG008.Id into GG008Join
                                            from GG008 in GG008Join.DefaultIfEmpty()

                                            select new CSICP_GG045
                                            {
                                                TenantId = _CSICP_GG045.TenantId,
                                                Gg045Id = _CSICP_GG045.Gg045Id,
                                                Gg045EstabelecimentoId = _CSICP_GG045.Gg045EstabelecimentoId,
                                                Gg045Saldoid = _CSICP_GG045.Gg045Saldoid,
                                                Gg045Qtd = _CSICP_GG045.Gg045Qtd,
                                                Gg045Protocolnumber = _CSICP_GG045.Gg045Protocolnumber,
                                                Gg045Datamovto = _CSICP_GG045.Gg045Datamovto,
                                                Gg045UsuariopropId = _CSICP_GG045.Gg045UsuariopropId,
                                                Gg045Descricao = _CSICP_GG045.Gg045Descricao,
                                                Cc040Id = _CSICP_GG045.Cc040Id,
                                                Gg045Statid = _CSICP_GG045.Gg045Statid,
                                                Cc060Id = _CSICP_GG045.Cc060Id,
                                                Gg045Saldo = GG520 != null ? new CSICP_GG520
                                                {
                                                    TenantId = GG520.TenantId,
                                                    Gg520KardexId = GG520.Gg520KardexId,
                                                    Gg520Almoxid = GG520.Gg520Almoxid,
                                                    Gg520NsNumerosaldo = GG520.Gg520NsNumerosaldo,
                                                    Gg520Saldo = GG520.Gg520Saldo,
                                                    Gg520DescricaoLote = GG520.Gg520DescricaoLote,
                                                    Gg520Descricaosaldo = GG520.Gg520Descricaosaldo,
                                                    Nav_GG008Kardex = GG008KDX != null ? new CSICP_GG008Kdx
                                                    {
                                                        NavGG008Produto = GG008 != null ? new CSICP_GG008
                                                        {
                                                            TenantId = GG008.TenantId,
                                                            Gg008Codgproduto = GG008.Gg008Codgproduto,
                                                            Gg008Descreduzida = GG008.Gg008Descreduzida,
                                                        } : null,
                                                    } : null,
                                                } : null,

                                            };
            return query;
        }

        private static IQueryable<CSICP_GG045> FiltrosNecessariosEntidade
         (IQueryable<CSICP_GG045> query, string? SearchDescricao, string? VSerieNF, string? VNumNF, DateTime DataInicial, DateTime DataFinal)
        {
            query = query.Where(e => e.Gg045Datamovto >= DataInicial && e.Gg045Datamovto <= DataFinal);

            if (SearchDescricao is not null) query.Where(e => e.Gg045Descricao != null && e.Gg045Descricao.Contains(SearchDescricao));

            return query;
        }


    }
}
