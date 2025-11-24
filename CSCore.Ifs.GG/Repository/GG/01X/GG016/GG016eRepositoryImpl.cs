using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._01X;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._01X
{
    public class GG016eRepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG016e>(appDbContext, "Gg016eId"),
        IGG016eRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_GG016e?> GetByIdAsync(long id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg016es
                .AsSplitQuery()
                 .Where(e => e.TenantId == tenant)
                 .Where(e => e.Gg016eId == id)
                 .Include(e => e.NavProprietarioSY001)
                 .FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<CSICP_GG016e>> GetListAsync(int tenant, string? search)
        {
            IQueryable<CSICP_GG016e> query = _appDbContext.OsusrE9aCsicpGg016es
                .AsSplitQuery()
                 .Where(e => e.TenantId == tenant)
                 .Include(e => e.NavProprietarioSY001)
                 .AsQueryable();

            query = FiltraQuandoExisteFiltros(search, query);

            return await query.ToListAsync();
        }

        private static IQueryable<CSICP_GG016e> FiltraQuandoExisteFiltros(string? search, IQueryable<CSICP_GG016e> query)
        {
            if (search != null)
            {
                query = query.Where(entity => (entity.Gg016eDescricao ?? "").Contains(search ?? ""));
            }

            return query;
        }

        public async override Task<CSICP_GG016e?> RemoveAsync(long id, int tenant)
        {
            return await base.RemoveAsync(id, tenant);
        }
    }
}

