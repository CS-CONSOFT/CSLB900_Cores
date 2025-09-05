using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.GerarInventarioFiscal
{
    public class GeraInventarioFiscal : IGeraInventarioFiscal
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICS_GenerateId _generateID;


        public GeraInventarioFiscal(
            AppDbContext appDbContext,
            ICS_GenerateId cS_GenerateId)
        {
            _appDbContext = appDbContext;
            _generateID = cS_GenerateId;
        }

        public async Task<string> Executar(string InOriginalGG032ID, CSICP_GG032 InCopiaGG032, int InTenantID)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                IEnumerable<CSICP_GG033> WorkListGG033 = await _appDbContext.OsusrE9aCsicpGg033s
                   .Where(e => e.Gg032Id == InOriginalGG032ID && e.TenantId == InTenantID)
                   .AsNoTracking()
                   .ToListAsync();

                if (WorkListGG033.Any())
                {
                    List<CSICP_GG033> WorkListCopiaGG033 = WorkListGG033.Select(e =>
                    {
                        string novoIDGG033 = _generateID.GenerateUuId();
                        return new CSICP_GG033(e, novoIDGG033, InCopiaGG032.Id);
                    }).ToList();
                    _appDbContext.AddRange(WorkListCopiaGG033);
                }

                _appDbContext.Add(InCopiaGG032);
                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
                return InCopiaGG032.Id;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }
    }
}
