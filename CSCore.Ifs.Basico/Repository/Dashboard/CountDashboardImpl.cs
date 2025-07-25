using CSCore.Domain;
using CSCore.Domain.Interfaces.Dashboard;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.Dashboard
{
    public class CountDashboardImpl(AppDbContext appDbContext) : ICountDashboardRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        /// <summary>
        /// Retorna os counts para o dashboard.
        /// O parametro de retorno (int int) representa RESPECTIVAMENTE: Count total, numero ativos
        /// </summary>
        /// <param name="tenant"></param>
        /// <returns></returns>
        public async Task<Dictionary<string, (int, int)>> GetCountDashboard(int tenant)
        {
            (int bb031totalCount, int bb031activeCount) = await RecuperaTotalCountEActiveCount<CSICP_Bb031>(tenant, "Bb031Isactive");
            (int bb032totalCount, int bb032activeCount) = await RecuperaTotalCountEActiveCount<CSICP_Bb032>(tenant, "Bb032Isactive");
            (int bb009totalCount, int bb009activeCount) = await RecuperaTotalCountEActiveCount<CSICP_Bb009>(tenant, "Bb009Isactive");
            (int bb037totalCount, int bb037activeCount) = await RecuperaTotalCountEActiveCount<CSICP_Bb037>(tenant, "Bb037Isactive");
            (int bb005totalCount, int bb005activeCount) = await RecuperaTotalCountEActiveCount<CSICP_Bb005>(tenant, "Bb005Isactive");
            (int bb006totalCount, int bb006activeCount) = await RecuperaTotalCountEActiveCount<CSICP_Bb006>(tenant, "Bb006Isactive");
            (int bb007totalCount, int bb007activeCount) = await RecuperaTotalCountEActiveCount<CSICP_BB007>(tenant, "Bb007Isactive");
            (int bb026totalCount, int bb026activeCount) = await RecuperaTotalCountEActiveCount<CSICP_Bb026>(tenant, "Bb026Isactive");
            (int bb008totalCount, int bb008activeCount) = await RecuperaTotalCountEActiveCount<CSICP_Bb008>(tenant, "Bb008Isactive");
            (int bb025totalCount, int bb025activeCount) = await RecuperaTotalCountEActiveCount<CSICP_Bb025>(tenant, "Bb025Isactive");
            (int bb001totalCount, int bb001activeCount) = await RecuperaTotalCountEActiveCount<CSICP_BB001>(tenant, "Bb001Isactive");

            var sy001 = await _appDbContext.OsusrE9aCsicpSy001s
                .Where(e => e.TenantId == tenant)
                .GroupBy(e => e.TenantId)
                .Select(g => new
                {
                    TotalCount = g.Count(),
                })
                .FirstOrDefaultAsync();

            var sy002 = await _appDbContext.OsusrE9aCsicpSy002s
                .Where(e => e.TenantId == tenant)
                .GroupBy(e => e.TenantId)
                .Select(g => new
                {
                    TotalCount = g.Count()
                })
                .FirstOrDefaultAsync();

            var dicionarioComCount = new Dictionary<string, (int, int)>
                {
                    {"bb031count", (bb031totalCount, bb031activeCount)},
                    {"bb032count", (bb032totalCount, bb031activeCount)},
                    {"bb009count", (bb009totalCount, bb009activeCount)},
                    {"bb037count", (bb037totalCount, bb037activeCount)},
                    {"bb005count", (bb005totalCount, bb005activeCount)},
                    {"bb006count", (bb006totalCount, bb006activeCount)},
                    {"bb007count", (bb007totalCount, bb007activeCount)},
                    {"bb026count", (bb026totalCount, bb026activeCount)},
                    {"bb008count", (bb008totalCount, bb008activeCount)},
                    {"bb025count", (bb025totalCount, bb025activeCount)},
                    {"bb001count", (bb001totalCount, bb001activeCount)},
                    {"sy001count", (sy001?.TotalCount ?? 0, -1)},
                    {"sy002count", (sy002?.TotalCount ?? 0, -1)},
                };

            return dicionarioComCount;
        }

        private async Task<(int TotalCount, int ActiveCount)> RecuperaTotalCountEActiveCount<TEntity>(int tenant, string isAtivoNomeProp) where TEntity : class
        {
            var result = await _appDbContext.Set<TEntity>()
               .Where(e => EF.Property<int>(e, "TenantId") == tenant)
               .GroupBy(e => EF.Property<int>(e, "TenantId"))
               .Select(g => new
               {
                   TotalCount = g.Count(),
                   ActiveCount = g.Count(e => EF.Property<bool>(e, isAtivoNomeProp) == true)
               })
               .FirstOrDefaultAsync();

            if (result == null)
            {
                return (0, 0);
            }

            return (result.TotalCount, result.ActiveCount);

        }
    }
}
