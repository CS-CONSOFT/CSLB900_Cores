using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._07X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.GG.Repository.GG.Saldo;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._07X
{
    public class GG071RepositoryImpl(AppDbContext appDbContext, IComparaSaldo comparaSaldo, IGerarTree gerarTree) :
        RepositorioBaseImpl<CSICP_GG071>(appDbContext), IGG071Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly IComparaSaldo _comparaSaldo = comparaSaldo;
        private readonly IGerarTree _gerarTree = gerarTree;
        public async Task<CSICP_GG071?> GetByIdAsync(int tenant, long id)
        {
            IQueryable<CSICP_GG071> query = CriaQueryBase(tenant);
            query = query.Where(e => e.Gg071Id == id);

            CSICP_GG071? csicpGg030Entity = await query.FirstOrDefaultAsync();

            return csicpGg030Entity;
        }

        public async Task<(IEnumerable<CSICP_GG071>, int)> GetListAsync(int tenant, int pageSize, int page,
          DateTime DataInicio, DateTime DataFinal, string? Protocolo,
          string? BB005_CentroDeCusto_ID, int? GG071_Status_ID, int? GG041_TpReq_ID, string? SY001_UsuarioID, string? BB001_EstabID)
        {
            IQueryable<CSICP_GG071> query = CriaQueryBase(tenant);

            query = FiltrosNecessariosEntidade(query,
                                                DataInicio,
                                                DataFinal,
                                                Protocolo,
                                                BB005_CentroDeCusto_ID,
                                                GG071_Status_ID,
                                                GG041_TpReq_ID,
                                                SY001_UsuarioID,
                                                BB001_EstabID);

            query = query.PaginacaoNoBanco(page, pageSize);

            int count = query.GetCountTotal();

            List<CSICP_GG071> listaCSICP_GG071 = await query.ToListAsync();
            return (listaCSICP_GG071, count);
        }



        public async Task<(int retCountSaldo, int retCountContagem, bool isOk)> Requisitar_RI_Solicitacao(
            int tenant,
            long g071ID,
            int csicp_gg072_stq_Aberto_id,
            int csicp_gg071_sta_aberto_id,
            int csicp_gg028_tipo_reqInterna_id)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                IQueryable<CSICP_GG071> queryGG071 = GetQueryGG071(g071ID, tenant);

                //teste diferente da versao do outsystem pq o outsystem tava errado, feito pelo agnaldo e valter
                queryGG071 = queryGG071.Where(e => e.Gg071Statusid == csicp_gg071_sta_aberto_id);

                CSICP_GG071? csicpGg071Entity = await queryGG071.FirstOrDefaultAsync();
                if (csicpGg071Entity is null) throw new KeyNotFoundException("A Requisição Interna precisa está aberta!");


                IQueryable<CSICP_GG072> query = GetQueryParaProdutosDaGG071(tenant, g071ID, csicp_gg072_stq_Aberto_id);

                List<CSICP_GG072> csicpGg072List = await query.ToListAsync();

                (int retCountSaldo, int retCountContagem, bool isOk) returnValue = (0, 0, true);

                if (csicpGg072List.Count == 0) throw new Exception("Requisição sem produtos!");

                foreach (var produto in csicpGg072List)
                {
                    if (produto.NavGG520Saidasaldo != null
                        && produto.NavGG520Saidasaldo.Gg520Saldo >= produto.Gg072Quantidade
                        && produto.NavGG520Saidasaldo.Gg520ItemEmContagem == false)
                    {
                        produto.Gg072Qtdsolicitada = produto.Gg072Quantidade;
                        produto.NavGG520Saidasaldo = null;
                        _appDbContext.Update(produto);
                        continue;
                    }
                    returnValue.isOk = false;
                    throw new Exception("Requisição possui produtos sem saldo!");
                }
                await _gerarTree.CriarDocTree(
                    tenant, "RI" + g071ID,
                    csicpGg071Entity.Gg071Protocolnumber,
                    csicp_gg028_tipo_reqInterna_id,
                    null);

                await _appDbContext.SaveChangesAsync();

                await transaction.CommitAsync();
                return returnValue;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }


        public async Task NormalizarRI(int tenant, long g071ID)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateRIStatus(int tenant, long g071ID, int novoStatusGG071id)
        {
            IQueryable<CSICP_GG071> queryGG071 = GetQueryGG071(g071ID, tenant);
            CSICP_GG071? gg071 = await queryGG071.FirstOrDefaultAsync();
            if (gg071 is null)
                throw new KeyNotFoundException("A Requisição Interna não foi encontrada!");

            gg071.Gg071Statusid = novoStatusGG071id;

            _appDbContext.Update(gg071);
            await _appDbContext.SaveChangesAsync();
        }



        public async Task CS_RI_Processa_Baixa(
            int in_tenant,
            string in_usuarioID,
            long in_RI_ID_gg071,
            int in_StID_csicp_gg071_sta_solicitado,
            int in_StID_csicp_gg071_sta_erro,
            int in_StID_gg028_natOperacao_ReqInterna_ID,
            int in_StIDgg073_ent_saida_saida_ID,
            int in_StIDgg028_ent_saida_saida_ID,
            int in_StIDgg028_ent_saida_ent_ID,
            int in_StID_csicp_gg072_stq_Inventario,
            int in_StID_csicp_gg072_stq_SemSaldo,
            int in_StID_csicp_gg072_stq_Erro,
            int in_StID_csicp_gg072_stq_Baixado,
            int in_StID_csicp_gg071_StatusId_Erro,
            int in_StID_csicp_gg071_StatusId_Atentido,
            int in_StID_estatica_sim_id)
        {
            using (var transaction = await _appDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    IQueryable<CSICP_GG071> query = GetQueryGG071(in_RI_ID_gg071, in_tenant);

                    CSICP_GG071? cSICP_GG071 = await query.FirstOrDefaultAsync();
                    if (cSICP_GG071 is null) throw new KeyNotFoundException("A RI não foi encontrada!");

                    if (cSICP_GG071.Gg071Statusid != in_StID_csicp_gg071_sta_solicitado
                        && cSICP_GG071.Gg071Statusid != in_StID_csicp_gg071_sta_erro)
                        throw new Exception("Status precisa estar solicitado!");

                    IQueryable<CSICP_GG072> query_gg072 = GetQueryGG072(in_RI_ID_gg071, in_tenant);

                    List<CSICP_GG072> listaGG072 = await query_gg072.ToListAsync();

                    bool flagComprometeSaldo = false;
                    foreach (var currentGG072 in listaGG072)
                    {
                        if (currentGG072.Gg072Saidasaldoid is null) continue;
                        (CSICP_GG520? saldoAtual, int comprometeSaldo) =
                            await _comparaSaldo.CS_RI_CompSaldo(
                                in_tenant,
                                currentGG072.Gg072Saidasaldoid,
                                currentGG072.Gg072Entradasaldoid!,
                                currentGG072.Gg072Quantidade ?? -1,
                                currentGG072.Gg072Id.ToString(),
                                cSICP_GG071.Gg071DataMovimento ?? DateTime.Now,
                                in_usuarioID,
                                cSICP_GG071.Gg071Protocolnumber ?? "",
                                "RI" + cSICP_GG071.Gg071Id,
                                -1,
                                in_StIDgg073_ent_saida_saida_ID,
                                in_StIDgg028_ent_saida_saida_ID,
                                in_StIDgg028_ent_saida_ent_ID,
                                in_StID_gg028_natOperacao_ReqInterna_ID,
                                in_StID_estatica_sim_id
                                );

                        await GerenciaBaixaSaldo(
                            currentGG072,
                            in_StID_csicp_gg072_stq_Inventario,
                            in_StID_csicp_gg072_stq_SemSaldo,
                            in_StID_csicp_gg072_stq_Erro,
                            in_StID_csicp_gg072_stq_Baixado,
                            comprometeSaldo);
                    }

                    if (flagComprometeSaldo is true) cSICP_GG071.Gg071Statusid = in_StID_csicp_gg071_StatusId_Erro;
                    else cSICP_GG071.Gg071Statusid = in_StID_csicp_gg071_StatusId_Atentido;

                    _appDbContext.Update(cSICP_GG071);
                    await _appDbContext.SaveChangesAsync();

                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
                }
            };
        }

        public async Task ExcluirRI(int tenant, long g071ID, long csicp_gg071_sta_aberto_id)
        {
            IQueryable<CSICP_GG071> cSICP_GG071s = GetQueryGG071(g071ID, tenant)
                .Where(e => e.Gg071Statusid == csicp_gg071_sta_aberto_id);

            CSICP_GG071? csicpGg071Entity = await cSICP_GG071s.FirstOrDefaultAsync();
            if (csicpGg071Entity is null) throw new KeyNotFoundException("A Requisição Interna precisa está aberta!");
            _appDbContext.Remove(csicpGg071Entity);
            await _appDbContext.SaveChangesAsync();
        }
        public async Task CancelarRI(
            int tenant,
            long g071ID,
            int csicp_gg071_sta_aberto_id,
            int csicp_gg071_sta_solicitado_id,
            int csicp_gg071_sta_cancelado_id)
        {
            using (var transaction = await _appDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    IQueryable<CSICP_GG071> query = GetGG071ParaCancelar(
               tenant, g071ID, csicp_gg071_sta_aberto_id, csicp_gg071_sta_solicitado_id);

                    CSICP_GG071? csicpGg071Entity = await query.FirstOrDefaultAsync();
                    if (csicpGg071Entity is null) throw new KeyNotFoundException("A Requisição Interna precisa está aberta!");

                    IQueryable<CSICP_GG072> queryProdutos = GetQueryGG072ProdutosParaCancelar(tenant, g071ID);

                    List<CSICP_GG072> listaProdutos = await queryProdutos.ToListAsync();
                    if (listaProdutos is null || listaProdutos.Count == 0)
                        throw new KeyNotFoundException("A Requisição Interna não possui produtos!");

                    foreach (var produto in listaProdutos)
                    {
                        produto.Dd080Id = null;
                        _appDbContext.Update(produto);
                    }

                    csicpGg071Entity.Gg071Statusid = csicp_gg071_sta_cancelado_id;
                    _appDbContext.Update(csicpGg071Entity);

                    await _appDbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
                }
            }
        }






        private async Task GerenciaBaixaSaldo(
            CSICP_GG072 currentGG072,
            int csicp_gg072_stq_Inventario,
            int csicp_gg072_stq_SemSaldo,
            int csicp_gg072_stq_Erro,
            int csicp_gg072_stq_Baixado,
            int comprometeSaldo)
        {
            if (ComprometeuSaldo(comprometeSaldo))
            {
                currentGG072.Gg072Statusestqid = comprometeSaldo switch
                {
                    1 => csicp_gg072_stq_Inventario,
                    2 => csicp_gg072_stq_SemSaldo,
                    3 => csicp_gg072_stq_SemSaldo,
                    _ => (int?)csicp_gg072_stq_Baixado,
                };
                _appDbContext.Update(currentGG072);
            }

            if (NaoComprometeuSaldo(comprometeSaldo))
            {
                currentGG072.Gg072QtdAnterior = currentGG072.Gg072Quantidade.ToString();
                currentGG072.Gg072Statusestqid = csicp_gg072_stq_Baixado;
                _appDbContext.Update(currentGG072);
            }
            await _appDbContext.SaveChangesAsync();
        }

        private static bool ComprometeuSaldo(int comprometeSaldo)
        {
            return comprometeSaldo == 0;
        }

        private static bool NaoComprometeuSaldo(int comprometeSaldo)
        {
            return comprometeSaldo != 0;
        }

        private IQueryable<CSICP_GG072> GetQueryParaProdutosDaGG071(int tenant, long g071ID, int csicp_gg072_stq_Aberto_id)
        {
            return from _gg072 in _appDbContext.OsusrE9aCsicpGg072s
                   where _gg072.TenantId == tenant
                   where _gg072.Gg071Id == g071ID
                   where _gg072.Gg072Statusestqid == csicp_gg072_stq_Aberto_id

                   join _gg520 in _appDbContext.OsusrE9aCsicpGg520s
                   on _gg072.Gg072Saidasaldoid equals _gg520.Id into _gg520Join
                   from _gg520 in _gg520Join.DefaultIfEmpty()

                   select new CSICP_GG072
                   {
                       TenantId = _gg072.TenantId,
                       Gg072Id = _gg072.Gg072Id,
                       Gg071Id = _gg072.Gg071Id,
                       Gg072Codbarrasalfa = _gg072.Gg072Codbarrasalfa,
                       Gg072KardexId = _gg072.Gg072KardexId,
                       Gg072Saidasaldoid = _gg072.Gg072Saidasaldoid,
                       Gg072UnId = _gg072.Gg072UnId,
                       Gg072Quantidade = _gg072.Gg072Quantidade,
                       Gg072ValorUnitario = _gg072.Gg072ValorUnitario,
                       Gg072QtdAnterior = _gg072.Gg072QtdAnterior,
                       Gg072Entradasaldoid = _gg072.Gg072Entradasaldoid,
                       Gg072UnSecId = _gg072.Gg072UnSecId,
                       Gg072UnSecTipoconvId = _gg072.Gg072UnSecTipoconvId,
                       Gg072UnSecFatorconv = _gg072.Gg072UnSecFatorconv,
                       Gg072UnSecQtde = _gg072.Gg072UnSecQtde,
                       Gg072Statusestqid = _gg072.Gg072Statusestqid,
                       Dd080Id = _gg072.Dd080Id,
                       Gg072Qtdsolicitada = _gg072.Gg072Qtdsolicitada,
                       NavGG520Saidasaldo = _gg520 != null ? new CSICP_GG520
                       {
                           Id = _gg520.Id,
                           TenantId = _gg520.TenantId,
                           Gg520Saldo = _gg520.Gg520Saldo,
                           Gg520ItemEmContagem = _gg520.Gg520ItemEmContagem,
                       } : null
                   };
        }
        private IQueryable<CSICP_GG072> GetQueryGG072ProdutosParaCancelar(int tenant, long g071ID)
        {
            return from _gg072 in _appDbContext.OsusrE9aCsicpGg072s
                   where _gg072.TenantId == tenant
                   where _gg072.Gg071Id == g071ID
                   select new CSICP_GG072
                   {
                       TenantId = _gg072.TenantId,
                       Gg072Id = _gg072.Gg072Id,
                       Gg071Id = _gg072.Gg071Id,
                       Gg072Codbarrasalfa = _gg072.Gg072Codbarrasalfa,
                       Gg072KardexId = _gg072.Gg072KardexId,
                       Gg072Saidasaldoid = _gg072.Gg072Saidasaldoid,
                       Gg072UnId = _gg072.Gg072UnId,
                       Gg072Quantidade = _gg072.Gg072Quantidade,
                       Gg072ValorUnitario = _gg072.Gg072ValorUnitario,
                       Gg072QtdAnterior = _gg072.Gg072QtdAnterior,
                       Gg072Entradasaldoid = _gg072.Gg072Entradasaldoid,
                       Gg072UnSecId = _gg072.Gg072UnSecId,
                       Gg072UnSecTipoconvId = _gg072.Gg072UnSecTipoconvId,
                       Gg072UnSecFatorconv = _gg072.Gg072UnSecFatorconv,
                       Gg072UnSecQtde = _gg072.Gg072UnSecQtde,
                       Gg072Statusestqid = _gg072.Gg072Statusestqid,
                       Dd080Id = _gg072.Dd080Id,
                       Gg072Qtdsolicitada = _gg072.Gg072Qtdsolicitada,
                   };
        }

        private IQueryable<CSICP_GG071> GetGG071ParaCancelar(
            int tenant, long g071ID, int csicp_gg071_sta_aberto_id, int csicp_gg071_sta_solicitado_id)
        {
            return from _gg071 in _appDbContext.OsusrE9aCsicpGg071s
                   where _gg071.TenantId == tenant
                   where _gg071.Gg071Id == g071ID
                   where _gg071.Gg071Statusid == csicp_gg071_sta_aberto_id ||
                         _gg071.Gg071Statusid == csicp_gg071_sta_solicitado_id
                   select new CSICP_GG071
                   {
                       TenantId = _gg071.TenantId,
                       Gg071Id = _gg071.Gg071Id,
                       Gg071Estabid = _gg071.Gg071Estabid,
                       Gg071Protocolnumber = _gg071.Gg071Protocolnumber,
                       Gg071DataMovimento = _gg071.Gg071DataMovimento,
                       Gg071Usuarioid = _gg071.Gg071Usuarioid,
                       Gg071Observacao = _gg071.Gg071Observacao,
                       Gg071Ccustoid = _gg071.Gg071Ccustoid,
                       Gg071NoDocto = _gg071.Gg071NoDocto,
                       Gg071Statusid = _gg071.Gg071Statusid,
                       Dd070Id = _gg071.Dd070Id,
                       Gg071Almoxsaidaid = _gg071.Gg071Almoxsaidaid,
                       Gg071Almoxentid = _gg071.Gg071Almoxentid,
                       Gg071AtendenteUsuarioid = _gg071.Gg071AtendenteUsuarioid,
                       Gg071Datendimento = _gg071.Gg071Datendimento,
                       Gg071Tpreqid = _gg071.Gg071Tpreqid,
                   };
        }

        private IQueryable<CSICP_GG072> GetQueryGG072(long Prm_RI_ID_gg071, int tenant)
        {
            return from _gg072 in _appDbContext.OsusrE9aCsicpGg072s
                   where _gg072.TenantId == tenant
                   where _gg072.Gg071Id == Prm_RI_ID_gg071
                   select new CSICP_GG072
                   {
                       TenantId = _gg072.TenantId,
                       Gg072Id = _gg072.Gg072Id,
                       Gg071Id = _gg072.Gg071Id,
                       Gg072Codbarrasalfa = _gg072.Gg072Codbarrasalfa,
                       Gg072KardexId = _gg072.Gg072KardexId,
                       Gg072Saidasaldoid = _gg072.Gg072Saidasaldoid,
                       Gg072UnId = _gg072.Gg072UnId,
                       Gg072Quantidade = _gg072.Gg072Quantidade,
                       Gg072ValorUnitario = _gg072.Gg072ValorUnitario,
                       Gg072QtdAnterior = _gg072.Gg072QtdAnterior,
                       Gg072Entradasaldoid = _gg072.Gg072Entradasaldoid,
                       Gg072UnSecId = _gg072.Gg072UnSecId,
                       Gg072UnSecTipoconvId = _gg072.Gg072UnSecTipoconvId,
                       Gg072UnSecFatorconv = _gg072.Gg072UnSecFatorconv,
                       Gg072UnSecQtde = _gg072.Gg072UnSecQtde,
                       Gg072Statusestqid = _gg072.Gg072Statusestqid,
                       Dd080Id = _gg072.Dd080Id,
                       Gg072Qtdsolicitada = _gg072.Gg072Qtdsolicitada,
                   };
        }

        private IQueryable<CSICP_GG071> GetQueryGG071(long Prm_RI_ID_gg071, int tenant)
        {
            return from _gg071 in _appDbContext.OsusrE9aCsicpGg071s
                   where _gg071.TenantId == tenant
                   where _gg071.Gg071Id == Prm_RI_ID_gg071
                   select new CSICP_GG071
                   {
                       TenantId = _gg071.TenantId,
                       Gg071Id = _gg071.Gg071Id,
                       Gg071Estabid = _gg071.Gg071Estabid,
                       Gg071Protocolnumber = _gg071.Gg071Protocolnumber,
                       Gg071DataMovimento = _gg071.Gg071DataMovimento,
                       Gg071Usuarioid = _gg071.Gg071Usuarioid,
                       Gg071Observacao = _gg071.Gg071Observacao,
                       Gg071Ccustoid = _gg071.Gg071Ccustoid,
                       Gg071NoDocto = _gg071.Gg071NoDocto,
                       Gg071Statusid = _gg071.Gg071Statusid,
                       Dd070Id = _gg071.Dd070Id,
                       Gg071Almoxsaidaid = _gg071.Gg071Almoxsaidaid,
                       Gg071Almoxentid = _gg071.Gg071Almoxentid,
                       Gg071AtendenteUsuarioid = _gg071.Gg071AtendenteUsuarioid,
                       Gg071Datendimento = _gg071.Gg071Datendimento,
                       Gg071Tpreqid = _gg071.Gg071Tpreqid,

                   };
        }

      
        private IQueryable<CSICP_GG071> CriaQueryBase(int tenant)
        {
            IQueryable<CSICP_GG071> query = _appDbContext.OsusrE9aCsicpGg071s
                .Include(e => e.NavBB001Estab)
                .Include(e => e.NavBB005CentroCusto)
                .Include(e => e.NavGG071Status)
                .Include(e => e.NavGG071TipoReq)
                .Include(e => e.NavUsuarioProprietarioSY001)
                .Include(e => e.NavAtendenteUsuarioSY001)
                .Include(e => e.NavGg071Almoxent)
                .Include(e => e.NavGg071Almoxsaida)
                  .Where(e => e.TenantId == tenant)
                .AsNoTracking();
            return query;
        }

        private static IQueryable<CSICP_GG071> FiltrosNecessariosEntidade
            (IQueryable<CSICP_GG071> query, DateTime DataInicio, DateTime DataFinal, string? Protocolo,
            string? BB005_CentroDeCusto_ID, int? GG071_Status_ID, int? GG041_TpReq_ID,
            string? SY001_UsuarioID, string? BB001_EstabID
            )
        {
            query = query.Where(e => e.Gg071DataMovimento >= DataInicio && e.Gg071DataMovimento <= DataFinal);

            if (Protocolo is not null) query.Where(e => e.Gg071Protocolnumber != null && e.Gg071Protocolnumber.Contains(Protocolo));

            if (BB005_CentroDeCusto_ID is not null) query.Where(e => e.Gg071Ccustoid != null && e.Gg071Ccustoid == BB005_CentroDeCusto_ID);

            if (GG071_Status_ID is not null) query.Where(e => e.Gg071Statusid != null && e.Gg071Statusid == GG071_Status_ID);

            if (GG041_TpReq_ID is not null) query.Where(e => e.Gg071Tpreqid != null && e.Gg071Tpreqid == GG041_TpReq_ID);

            if (SY001_UsuarioID is not null) query.Where(e => e.Gg071Usuarioid != null && e.Gg071Usuarioid == SY001_UsuarioID);

            if (BB001_EstabID is not null) query.Where(e => e.Gg071Estabid != null && e.Gg071Estabid == BB001_EstabID);

            return query;
        }

    }
}

