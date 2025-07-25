using CSCore.Domain.CS_Models.CSICP_GG;
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
    public class GG046RepositoryImpl(AppDbContext appDbContext) : RepositorioBaseImpl<OsusrE9aCsicpGg046>(appDbContext, "Gg046Id"), 
        IGG046Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<OsusrE9aCsicpGg046?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg046s
                    .AsSplitQuery()
                    .Where(e => e.TenantId == tenant && e.Gg046Id == id)
                    .AsNoTracking()
                    .FirstOrDefaultAsync();
        }

        public async Task<(IEnumerable<OsusrE9aCsicpGg046>, int)> GetListAsync(int tenant, int pageSize, int page)
        {

            IQueryable<OsusrE9aCsicpGg046> q1 = _appDbContext.OsusrE9aCsicpGg046s
                .AsSplitQuery()
                .Where(e => e.TenantId == tenant).AsNoTracking();

            var queryCount = q1;
            var count = queryCount.Count();

            q1 = q1.PaginacaoNoBanco(page, pageSize);

            return (await q1.ToListAsync(), count);
        }
        public async Task<IEnumerable<OsusrE9aCsicpGg046>> GetListPeloGG045Async(int tenant, string gg045Id)
        {
            var query = from gg046 in _appDbContext.OsusrE9aCsicpGg046s
                        where gg046.TenantId == tenant
                            && gg046.Gg045Id == gg045Id
                        select new OsusrE9aCsicpGg046
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
                            Gg046Codbarrasalfa = gg046.Gg046Codbarrasalfa
                        };
            return await query.ToListAsync();
        }

    }
}
