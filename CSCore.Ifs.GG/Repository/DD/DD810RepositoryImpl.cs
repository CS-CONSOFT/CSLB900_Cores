using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.DD;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.DD
{
    public class DD810RepositoryImpl(AppDbContext appDbContext) : IDD810Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_DD810?> GetByIdAsync(string InDD810ID, int InTenantID)
        {
            return await _appDbContext.OsusrTeiCsicpDd810s
                .AsNoTracking()
                .Include(e => e.NavDD810_CFOP_Saida)
                .Include(e => e.NavDD810_CFOP_Entrada)
                .Where(e => e.TenantId == InTenantID && e.Dd810Id == InDD810ID)
                .FirstOrDefaultAsync();
        }

        public async Task<(List<CSICP_DD810>, int)> GetListAsync(int InTenantID, int InPageNumber, int InPageSize)
        {
            IQueryable<CSICP_DD810> query = _appDbContext.OsusrTeiCsicpDd810s
                .Where(e => e.TenantId == InTenantID)
                .AsNoTracking()
                .Include(e => e.NavDD810_CFOP_Saida)
                .Include(e => e.NavDD810_CFOP_Entrada);

            var count = await query.CountAsync();

            query = query.OrderBy(e => e.Dd810Id)
                .PaginacaoNoBanco(InPageNumber, InPageSize);

            List<CSICP_DD810> resultList = await query.ToListAsync();
            return (resultList, count);
        }

        public async Task<string?> GetCfopCodigoByCfopId(int cfopId)
        {
            var cfop = await _appDbContext.Osusr66cSpedInCfops
                .AsNoTracking()
                .Where(c => c.Id == cfopId)
                .FirstOrDefaultAsync();

            return cfop?.Codigo;
        }

        public async Task<CSICP_DD810> CreateAsync(CSICP_DD810 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_DD810> UpdateAsync(CSICP_DD810 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_DD810> RemoveAsync(CSICP_DD810 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}