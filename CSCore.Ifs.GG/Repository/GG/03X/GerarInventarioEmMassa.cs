using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.CS_QueryFilters.GG032;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.Repository.GG._03X;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._03X
{

    public interface IGerarInventarioEmMassa
    {
        Task<string> CS_GeradorInventarioEmMassa(
             int in_tenantId,
             bool in_isQtdZero,
             int in_StID_EntitiesGG001TAlmox_Virtual,
             FiltroProdutoRequest request
             );
    }

    public class GerarInventarioEmMassa(
         AppDbContext appDbContext,
           ICS_GenerateId generateId,
        IGenerateProtocolo generateProtocolo) : IGerarInventarioEmMassa
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly ICS_GenerateId _generateId = generateId;
        private readonly IGenerateProtocolo _generateProtocolo = generateProtocolo;


        public async Task<string> CS_GeradorInventarioEmMassa(
            int in_tenantId,
            bool in_isQtdZero,
            int in_StID_EntitiesGG001TAlmox_Virtual,
            FiltroProdutoRequest request
            )
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                var idCriado = await CS002_Le_Produtos(
                    in_tenantId,
                    in_isQtdZero,
                    request.FilialID,
                    request.UsuarioID,
                    request.GG032_TipoInventarioId,
                    request.GG032_StatusID,
                    request.AlmoxID,
                    in_StID_EntitiesGG001TAlmox_Virtual,
                    request.TipoSaldo,
                    request
                    );

                if (idCriado == "")
                    throw new Exception("Os filtros escolhidos retornaram nenhum produto, o inventario não foi gerado!");

                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();


                return "Movimento Gerado com Sucesso!";

            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }



        private async Task<string> CS002_Le_Produtos(
            int in_tenantID,
            bool in_isQtdZero,
            string in_filialID,
            string? in_usuarioID,
            int in_TpInventarioID,
            int in_StatusID,
            string in_almoxID,
            int in_StID_EntitiesGG001TAlmox_Virtual,
            TIPO_SALDO in_tipoSaldo,
            FiltroProdutoRequest request)
        {
            string inventarioID =
                await CS003_Cria_Movto_Inv(in_tenantID, in_filialID, in_usuarioID, in_TpInventarioID, in_StatusID);

            var valoresTotaisGG032 = new ValoresGG032Totais
            {
                TotalCusto = 0,
                TotalCustoReal = 0,
                TotalCustoMedio = 0,
                TotalCustoVenda = 0
            };
            await CS005_Processa_Lista_Produtos(
                in_tenantID,
                in_filialID,
                in_usuarioID,
                in_almoxID,
                in_StID_EntitiesGG001TAlmox_Virtual,
                in_tipoSaldo,
                inventarioID,
                in_isQtdZero,
                valoresTotaisGG032,
                request);

            if (valoresTotaisGG032.TotalListaSaldo == 0)
                return "";

            CSICP_GG032 gg032inventario = await _appDbContext.OsusrE9aCsicpGg032s
                .Where(e => e.Id == inventarioID).FirstAsync();

            gg032inventario.Gg032Totalcreal = Math.Round(valoresTotaisGG032.TotalCustoReal, 2);
            gg032inventario.Gg032Totalcusto = Math.Round(valoresTotaisGG032.TotalCusto, 2);
            gg032inventario.Gg032Totalcmedio = Math.Round(valoresTotaisGG032.TotalCustoMedio, 2);
            gg032inventario.Gg032Totalvenda = Math.Round(valoresTotaisGG032.TotalCustoVenda, 2);
            gg032inventario.Gg032Almoxid = in_almoxID;

            _appDbContext.Update(gg032inventario);

            return inventarioID;
        }

        private async Task CS005_Processa_Lista_Produtos(
            int in_tenantID,
            string in_filialID,
            string? in_usuarioID,
            string in_almoxID,
            int in_StID_EntitiesGG001TAlmox_Virtual,
            TIPO_SALDO in_tipoSaldo,
            string inventarioID,
            bool in_isQtdZero,
            ValoresGG032Totais valoresTotaisGG032,
            FiltroProdutoRequest request)
        {
            var listaSaldo = await GetListSaldo(
                  in_tenantID,
                  in_filialID,
                  in_almoxID,
                  in_StID_EntitiesGG001TAlmox_Virtual,
                  in_tipoSaldo,
                  request
                  );

            for (int i = 0; i < listaSaldo.Count; i++)
            {
                var currentSaldo = listaSaldo[i];
                CS004_Cria_Det_inv_Aut(
                                           in_tenantID,
                                           inventarioID,
                                           in_filialID,
                                           in_usuarioID,
                                           currentSaldo.Id,
                                           currentSaldo.Gg520Saldo,
                                           i + 1,
                                           in_isQtdZero,
                                           currentSaldo.Nav_GG008Kardex?.NavGG008Produto,
                                           currentSaldo.Nav_GG008Kardex
                                           );

                valoresTotaisGG032.TotalCusto = valoresTotaisGG032.TotalCusto + (currentSaldo.Nav_GG008Kardex?.Gg008PrecoCusto ?? 0) * currentSaldo.Gg520Saldo;
                valoresTotaisGG032.TotalCustoVenda = valoresTotaisGG032.TotalCustoVenda + (currentSaldo.Nav_GG008Kardex?.Gg008PrcVendavarejo ?? 0) * currentSaldo.Gg520Saldo;
                valoresTotaisGG032.TotalCustoReal = valoresTotaisGG032.TotalCustoReal + (currentSaldo.Nav_GG008Kardex?.Gg008PrecoCustoReal ?? 0) * currentSaldo.Gg520Saldo;
                valoresTotaisGG032.TotalCustoMedio = valoresTotaisGG032.TotalCustoMedio + (currentSaldo.Nav_GG008Kardex?.Gg008CustoMedio ?? 0) * currentSaldo.Gg520Saldo;
            }
            valoresTotaisGG032.TotalListaSaldo = listaSaldo.Count;

        }

        private async Task<List<CSICP_GG520>> GetListSaldo(
            int in_tenantId,
            string in_filialID,
            string in_almoxID,
            int in_StID_EntitiesGG001TAlmox_Virtual,
            TIPO_SALDO in_tipoSaldo,
            FiltroProdutoRequest request)
        {
            // Passo 1: Buscar dados simples (flat) do banco
            var querySaldoFlat = from gg520 in _appDbContext.OsusrE9aCsicpGg520s

                                 join gg001 in _appDbContext.CSICP_GG001s
                                    on gg520.Gg520Almoxid equals gg001.Id into gg001Join
                                 from gg001 in gg001Join.DefaultIfEmpty()

                                 join gg008kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes
                                    on gg520.Gg520KardexId equals gg008kdx.Gg008Kardexid into gg008kdxJoin
                                 from gg008kdx in gg008kdxJoin.DefaultIfEmpty()

                                 join gg008 in _appDbContext.OsusrE9aCsicpGg008s
                                    on gg008kdx.Gg008Produtoid equals gg008.Id into gg008Join
                                 from gg008 in gg008Join.DefaultIfEmpty()

                                 where gg520.TenantId == in_tenantId
                                 where gg520.Gg520Filialid == in_filialID
                                 where gg520.Gg520Almoxid == in_almoxID
                                 where gg520.Gg520NsNumerosaldo > 0
                                 where gg520.Gg520Isactive == true
                                 where gg001.Gg001Tipoalmoxarifado != in_StID_EntitiesGG001TAlmox_Virtual
                                 select new
                                 {
                                     gg520.Id,
                                     gg520.Gg520Saldo,
                                     Kardex = gg008kdx,
                                     Produto = gg008
                                 };

            // Passo 2: Aplicar filtros nos dados simples
            if (request.MarcaIds!.Count > 0)
                querySaldoFlat = querySaldoFlat.Where(e =>
                    e.Produto != null && request.MarcaIds.Contains(e.Produto.Gg008Marcaid ?? ""));

            if (request.GrupoIds.Count > 0)
                querySaldoFlat = querySaldoFlat.Where(e =>
                    e.Produto != null && request.GrupoIds.Contains(e.Produto.Gg008Grupoid ?? ""));

            if (request.SubGrupoIds.Count > 0)
                querySaldoFlat = querySaldoFlat.Where(e =>
                    e.Produto != null && request.SubGrupoIds.Contains(e.Produto.Gg008Subgrupoid ?? ""));

            if (request.ClasseIds.Count > 0)
                querySaldoFlat = querySaldoFlat.Where(e =>
                    e.Produto != null && request.ClasseIds.Contains(e.Produto.Gg008Classeid ?? ""));

            if (request.ArtigoIds.Count > 0)
                querySaldoFlat = querySaldoFlat.Where(e =>
                    e.Produto != null && request.ArtigoIds.Contains(e.Produto.Gg008Artigoid ?? ""));

            querySaldoFlat = in_tipoSaldo switch
            {
                TIPO_SALDO.COM_SALDO => querySaldoFlat.Where(e => e.Gg520Saldo > 0),
                TIPO_SALDO.SEM_SALDO => querySaldoFlat.Where(e => e.Gg520Saldo == 0),
                TIPO_SALDO.NEGATIVO_SALDO => querySaldoFlat.Where(e => e.Gg520Saldo < 0),
                _ => querySaldoFlat
            };

            querySaldoFlat = querySaldoFlat.OrderBy(e => e.Produto.Gg008Codgproduto);

            //quando nao precisar atualizar uma entidade, apenas usar os valores para alguma operação, use o as no tracking
            //senao pode ser que seja atualizado o objeto e gere erro de update fantasma
            var flatList = await querySaldoFlat.AsNoTracking().ToListAsync();

            // Passo 3: Montar objetos complexos em memória
            var listaSaldo = flatList.Select(e => new CSICP_GG520
            {
                Id = e.Id,
                Gg520Saldo = e.Gg520Saldo,
                Nav_GG008Kardex = e.Kardex != null ? new CSICP_GG008Kdx
                {
                    Gg008Kardexid = e.Kardex.Gg008Kardexid,
                    Gg008PrecoCusto = e.Kardex.Gg008PrecoCusto,
                    Gg008PrecoCustoReal = e.Kardex.Gg008PrecoCustoReal,
                    Gg008CustoMedio = e.Kardex.Gg008CustoMedio,
                    Gg008PrcVendavarejo = e.Kardex.Gg008PrcVendavarejo,
                    NavGG008Produto = e.Produto != null ? new CSICP_GG008
                    {
                        Id = e.Produto.Id,
                        Gg008Codgproduto = e.Produto.Gg008Codgproduto,
                        Gg008Marcaid = e.Produto.Gg008Marcaid,
                        Gg008Grupoid = e.Produto.Gg008Grupoid,
                        Gg008Subgrupoid = e.Produto.Gg008Subgrupoid,
                        Gg008Classeid = e.Produto.Gg008Classeid,
                        Gg008Artigoid = e.Produto.Gg008Artigoid,
                        Gg008Linhaid = e.Produto.Gg008Linhaid
                    } : null
                } : null
            }).ToList();

            return listaSaldo;
        }

        private async Task<string> CS003_Cria_Movto_Inv(
            int in_tenantID,
            string in_filialID,
            string? in_usuarioID,
            int in_TpInventarioID,
            int in_StatusID)
        {
            decimal protocolo = await _generateProtocolo.Fcn_ProtocoloGeral(in_filialID);
            if (in_usuarioID != null)
            {
                string? usuario = await _appDbContext.OsusrE9aCsicpSy001s
                    .Where(e => e.Id.Equals(in_usuarioID) && e.TenantId == in_tenantID)
                    .Select(e => e.Sy001Usuario)
                    .FirstOrDefaultAsync();

                string idInventario = _generateId.GenerateUuId();
                var inventario = new CSICP_GG032
                {
                    TenantId = in_tenantID,
                    Id = idInventario,
                    Gg032Protocolnumber = protocolo.ToString(),
                    Gg032Filialid = in_filialID,
                    Gg032Datamovimento = DateTime.Now.ToLocalTime().Date,
                    Gg032Observacao = "Gerado via usuario '" + usuario + "'!",
                    Gg032Usuarioid = in_usuarioID,
                    Gg032TipoinventarioId = in_TpInventarioID,
                    Gg032StatusId = in_StatusID
                };
                _appDbContext.Add(inventario);
                await _appDbContext.SaveChangesAsync();
                return idInventario;
            }
            return string.Empty;
        }

        private async Task<int?> CS_GetSequenciaProdutos(string idInventario)
        {
            return await _appDbContext.OsusrE9aCsicpGg033s
                .Where(e => e.Gg032Id!.Equals(idInventario))
                .MaxAsync(e => e.Gg033Posicao);
        }

        private void CS004_Cria_Det_inv_Aut(
            int in_tenantID,
            string in_gg032ID,
            string in_bb001ID,
            string? in_sy001ID,
            string in_gg520ID,
            decimal in_gg520Saldo,
            int in_position,
            bool in_isQtdZero,
            CSICP_GG008? in_produto,
            CSICP_GG008Kdx? in_kardexDoProduto
            )
        {
            var gg033 = new CSICP_GG033
            {
                TenantId = in_tenantID,
                Id = _generateId.GenerateUuId(),
                Gg032Id = in_gg032ID,
                Gg033Filialid = in_bb001ID,
                Gg033Saldoid = in_gg520ID,
                Gg033NnGrupoId = in_produto?.Gg008Grupoid,
                Gg033NnClasseId = in_produto?.Gg008Classeid,
                Gg033NnMarcaId = in_produto?.Gg008Marcaid,
                Gg033NnArtigoId = in_produto?.Gg008Artigoid,
                Gg033NnLinhaId = in_produto?.Gg008Linhaid,
                Gg033NnSubgrupoId = in_produto?.Gg008Subgrupoid,
                Gg033Produto = in_produto?.Gg008Codgproduto,
                Gg033Codigobarras = in_produto?.Gg008Codgproduto,
                Gg033Codbarrasalfa = in_produto?.Gg008Codgproduto.ToString(),
                Gg033Posicao = in_position,
                Gg033Datareferente = DateTime.Now.ToLocalTime().Date,
                Gg033Qtdinventario = in_isQtdZero ? 0 : in_gg520Saldo,
                Gg033Saldoestoque = in_gg520Saldo,
                Gg033Precocusto = in_kardexDoProduto?.Gg008PrecoCusto,
                Gg033Precocustoreal = in_kardexDoProduto?.Gg008PrecoCustoReal,
                Gg033Precocustomedio = in_kardexDoProduto?.Gg008CustoMedio,
                Gg033Precovenda = in_kardexDoProduto?.Gg008PrcVendavarejo,
                Gg033Alterado = true,
                Gg033QuemdigitouUserId = in_sy001ID
            };
            _appDbContext.Entry(in_produto!).State = EntityState.Detached;
            _appDbContext.Entry(in_kardexDoProduto!).State = EntityState.Detached;
            _appDbContext.Add(gg033);

        }
    }
}
