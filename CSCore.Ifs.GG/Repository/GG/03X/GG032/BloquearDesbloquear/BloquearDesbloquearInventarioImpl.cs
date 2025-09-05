using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository.GG._03X;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032
{
    public class BloquearDesbloquearInventarioImpl : OperacoesBaseInventarioRepository, IBloquearDesbloquearInventario
    {
        private readonly AppDbContext _appDbContext;

        public BloquearDesbloquearInventarioImpl(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> BloquearDesbloquearInventario(PrmBloquearDesbloquearInventario InPrmBloqDesbloq)
        {
            var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                /*
                    1	Bloqueado	
                    2	Solicitado	
                    3	Concluído	
                 */
                CSICP_GG032 gg032inventario =
                    await GetInventarioParaTrabalhoAsync(InPrmBloqDesbloq.InTenantID, InPrmBloqDesbloq.InInventarioID, _appDbContext);

                if (EhAcaoDesbloquear(InPrmBloqDesbloq.InTipoAcaoInventario) &&
                    InventarioStatusDifenteBloqueado(InPrmBloqDesbloq.InSTIDCsicpGg032StaBloqueadoID, gg032inventario))
                    throw new Exception("Inventário deve estar como BLOQUEADO para poder ser desbloqueado!");

                if (EhAcaoBloquear(InPrmBloqDesbloq.InTipoAcaoInventario) &&
                    InventarioStatusDiferenteDeSolicitado(InPrmBloqDesbloq.InSTIDCsicpGg032StaSolicitadoID, gg032inventario))
                    throw new Exception("Inventário deve estar como SOLICITADO para poder ser bloqueado!");

                List<CSICP_GG033> listgg033 =
                    await GetInventarioProdutosAsync(InPrmBloqDesbloq.InTenantID, gg032inventario.Id, _appDbContext);

                var saldoIds = listgg033.Select(x => x.Gg033Saldoid).Where(id => !string.IsNullOrEmpty(id)).Distinct().ToList();
                var saldos = await _appDbContext.OsusrE9aCsicpGg520s
                    .Where(s => saldoIds.Contains(s.Id))
                    .ToDictionaryAsync(s => s.Id);

                foreach (var gg033item in listgg033)
                {
                    if (string.IsNullOrEmpty(gg033item.Gg033Saldoid)) continue;
                    if (!saldos.TryGetValue(gg033item.Gg033Saldoid, out var saldoEncontrado)) continue;

                    saldoEncontrado.Gg520ItemEmContagem = EhAcaoBloquear(InPrmBloqDesbloq.InTipoAcaoInventario);
                    gg033item.Gg033Saldoestoque = saldoEncontrado.Gg520Saldo;

                    _appDbContext.OsusrE9aCsicpGg520s.Update(saldoEncontrado);
                    _appDbContext.OsusrE9aCsicpGg033s.Update(gg033item);
                }

                gg032inventario.Gg032StatusId = InPrmBloqDesbloq.InTipoAcaoInventario == 1
                    ? InPrmBloqDesbloq.InSTIDCsicpGg032StaBloqueadoID : InPrmBloqDesbloq.InSTIDCsicpGg032StaSolicitadoID;

                gg032inventario.Gg032DataHoraBloqueado = DateTime.Now.ToLocalTime();

                _appDbContext.OsusrE9aCsicpGg032s.Update(gg032inventario);
                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }


        private static bool EhAcaoBloquear(int in_tipoAcaoInventario)
        {
            return in_tipoAcaoInventario == (int)TIPO_ACAO_INVENTARIO.BLOQUEAR;
        }

        private static bool EhAcaoDesbloquear(int in_tipoAcaoInventario)
        {
            return in_tipoAcaoInventario == (int)TIPO_ACAO_INVENTARIO.DESBLOQUEAR;
        }

    }
}
