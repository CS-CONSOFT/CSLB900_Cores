using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.Interfaces.GG._04X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.GG.Repository.GG._04X
{
    public class GG046RepositoryImpl(AppDbContext appDbContext) : RepositorioBaseImpl<CSICP_GG046>(appDbContext, "Gg046Id"), 
        IGG046Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_GG046?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg046s
                    .AsSplitQuery()
                    .Where(e => e.TenantId == tenant && e.Gg046Id == id)
                    .AsNoTracking()
                    .FirstOrDefaultAsync();
        }

        public async Task<(IEnumerable<CSICP_GG046>, int)> GetListAsync(int tenant, int pageSize, int page)
        {

            IQueryable<CSICP_GG046> q1 = _appDbContext.OsusrE9aCsicpGg046s
                .AsSplitQuery()
                .Where(e => e.TenantId == tenant).AsNoTracking();

            var queryCount = q1;
            var count = queryCount.Count();

            q1 = q1.PaginacaoNoBanco(page, pageSize);

            return (await q1.ToListAsync(), count);
        }
        public async Task<IEnumerable<CSICP_GG046>> GetListPeloGG045Async(int tenant, string gg045Id)
        {
            var query = from gg046 in _appDbContext.OsusrE9aCsicpGg046s
                        where gg046.TenantId == tenant
                            && gg046.Gg045Id == gg045Id

                        join gg046Stat in _appDbContext.OsusrE9aCsicpGg045Stats
                        on gg046.Gg046StatId equals gg046Stat.Id into gg046StatJoin
                        from gg046Stat in gg046StatJoin.DefaultIfEmpty()

                        join gg046Entsai in _appDbContext.OsusrE9aCsicpGg046Es
                        on gg046.Gg046EntsaiId equals gg046Entsai.Id into gg046EntsaiJoin
                        from gg046Entsai in gg046EntsaiJoin.DefaultIfEmpty()


                        select new CSICP_GG046
                        {
                            TenantId = gg046.TenantId,
                            Gg046Id = gg046.Gg046Id,
                            Gg046Seq = gg046.Gg046Seq,
                            Gg045Id = gg046.Gg045Id,
                            Gg046SaldoentId = gg046.Gg046SaldoentId,
                            Gg046Qtd = gg046.Gg046Qtd,
                            Gg046StatId = gg046.Gg046StatId,
                            Gg046EntsaiId = gg046.Gg046EntsaiId,
                            Gg046Isnovo = gg046.Gg046Isnovo,
                            Gg046Descricaosaldo = gg046.Gg046Descricaosaldo,
                            Gg046Codbarrasalfa = gg046.Gg046Codbarrasalfa,
                            Gg046Entsai = gg046Entsai != null ? new OSUSR_E9A_CSICP_GG046_ES
                            {
                                Id = gg046Entsai.Id,
                                Label = gg046Entsai.Label,
                                Order = gg046Entsai.Order,
                                IsActive = gg046Entsai.IsActive
                            } : null,
                            Gg046Stat = gg046Stat != null ? new OSUSR_E9A_CSICP_GG045_STAT
                            {
                                Id = gg046Stat.Id,
                                Label = gg046Stat.Label,
                                Order = gg046Stat.Order,
                                IsActive = gg046Stat.IsActive
                            } : null
                        };
            return await query.ToListAsync();
        }

    }
}
