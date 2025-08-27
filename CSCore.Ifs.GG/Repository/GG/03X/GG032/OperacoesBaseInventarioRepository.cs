using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032
{
    public abstract class OperacoesBaseInventarioRepository
    {
        protected virtual async Task<CSICP_GG032> GetInventarioParaTrabalhoAsync(int tenantId, string idInventario, AppDbContext appDbContext)
        {
            return await appDbContext.OsusrE9aCsicpGg032s
                .FindAsync(tenantId, idInventario) ?? throw new Exception("Inventário não encontrado!");
        }

        protected virtual bool InventarioStatusDifenteBloqueado(int Parametro_csicp_gg032_Sta_Bloqueado_ID, CSICP_GG032 gg032inventario)
        {
            return gg032inventario.Gg032StatusId != Parametro_csicp_gg032_Sta_Bloqueado_ID;
        }

        protected virtual bool InventarioStatusDiferenteDeSolicitado(int Parametro_csicp_gg032_Sta_Solicitado_ID, CSICP_GG032 gg032inventario)
        {
            return gg032inventario.Gg032StatusId != Parametro_csicp_gg032_Sta_Solicitado_ID;
        }

        protected async Task<List<CSICP_GG033>> GetInventarioProdutosAsync(int tenant, string inInventarioID, AppDbContext appDbContext)
        {
            var querygg033 = from _gg033 in appDbContext.OsusrE9aCsicpGg033s
                             where _gg033.TenantId == tenant
                             where _gg033.Gg032Id == inInventarioID
                             select _gg033;

            List<CSICP_GG033> listgg033 = await querygg033.ToListAsync();
            if (listgg033 == null || listgg033.Count == 0)
            {
                throw new Exception("Não foram selecionados produtos para este inventário!");
            }
            return listgg033;
        }

        protected async Task<CSICP_GG520?> GetSaldoParaTrabalhoAsync(int tenant, string inSaldoID, AppDbContext appContext)
        {
            IQueryable<CSICP_GG520> querygg520 = GetQueryGG520(tenant, inSaldoID, appContext);
            CSICP_GG520? saldoEncontrado = await querygg520.FirstOrDefaultAsync();
            return saldoEncontrado;
        }
        private IQueryable<CSICP_GG520> GetQueryGG520(int tenant, string inSaldoID, AppDbContext appContext)
        {
            return from _gg520 in appContext.OsusrE9aCsicpGg520s
                   where _gg520.TenantId == tenant
                   where _gg520.Id == inSaldoID
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
