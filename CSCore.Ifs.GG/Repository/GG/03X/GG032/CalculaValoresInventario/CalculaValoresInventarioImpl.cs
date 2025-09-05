using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.CalculaValoresInventario
{
    public class CalculaValoresInventarioImpl : ICalculaValoresInventario
    {
        private readonly AppDbContext _appDbContext;

        public CalculaValoresInventarioImpl(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<string> Calcular(string InGG032ID, int InTenantID)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                CSICP_GG032 WorkGG032 = await _appDbContext.OsusrE9aCsicpGg032s
                   .Where(e => e.TenantId == InTenantID)
                   .FirstOrDefaultAsync() ?? throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

                IEnumerable<CSICP_GG033> WorkListGG033 = await _appDbContext.OsusrE9aCsicpGg033s
                   .Where(e => e.Gg032Id == InGG032ID && e.TenantId == InTenantID)
                   .AsNoTracking()
                   .ToListAsync();

                if (!WorkListGG033.Any()) throw new InvalidOperationException(HandlerReturnMessages.ENTITY_NOT_FOUND);

                for (var i = 0; i < WorkListGG033.Count(); i++)
                {
                    WorkGG032.Gg032Totalcusto += (WorkListGG033.ElementAt(i).Gg033Precocusto ?? 0) * (WorkListGG033.ElementAt(i).Gg033Qtdinventario ?? 0);
                    WorkGG032.Gg032Totalcreal += (WorkListGG033.ElementAt(i).Gg033Precocustoreal ?? 0) * (WorkListGG033.ElementAt(i).Gg033Qtdinventario ?? 0);
                    WorkGG032.Gg032Totalcmedio += (WorkListGG033.ElementAt(i).Gg033Precocustomedio ?? 0) * (WorkListGG033.ElementAt(i).Gg033Qtdinventario ?? 0);
                    WorkGG032.Gg032Totalvenda += (WorkListGG033.ElementAt(i).Gg033Precovenda ?? 0) * (WorkListGG033.ElementAt(i).Gg033Qtdinventario ?? 0);
                }
                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
                return InGG032ID;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }
    }
}
