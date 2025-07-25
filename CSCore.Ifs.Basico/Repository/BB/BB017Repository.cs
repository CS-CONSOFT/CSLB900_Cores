using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB017Repository(AppDbContext context) : IBB017Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb017> CreateAsync(CSICP_Bb017 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<CSICP_Bb017>> GetListByFormaPagtoIdAsync(string fPagtoId, int tenant)
        {
            return await CreateBaseQuery(tenant).Where(e => e.Bb017Fpagtoid == fPagtoId).ToListAsync();
        }

        public async Task<IEnumerable<CSICP_Bb017>> GetListByCondicaoIdAsync(string condicaoId, int tenant)
        {
            return await CreateBaseQuery(tenant).Where(e => e.Bb017Condicaoid == condicaoId).ToListAsync();
        }

        public async Task<CSICP_Bb017?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb017>> GetListAsync(int tenant, string? in_CondicaoPagamentoID, string? in_FormaPagamentoID)
        {
            IQueryable<CSICP_Bb017> q1 = CreateBaseQuery(tenant).AsQueryable();

            if (in_CondicaoPagamentoID != null) q1 = q1.Where(e => e.Bb017Condicaoid != null && e.Bb017Condicaoid.Equals(in_CondicaoPagamentoID));
            if (in_FormaPagamentoID != null) q1 = q1.Where(e => e.Bb017Fpagtoid != null && e.Bb017Fpagtoid.Equals(in_FormaPagamentoID));

            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb017> RemoveAsync(CSICP_Bb017 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb017> UpdateAsync(CSICP_Bb017 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private IQueryable<CSICP_Bb017> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb017s
                .AsSplitQuery()
                .AsNoTracking()
                .Include(e => e.NavBb008Condicao)
                .Include(e => e.NavCSICP_PD001Ctef_Cmd_Tef_Canc)
                .Include(e => e.NavCSICP_PD001Ctef_Cmd_Tef_VD)
                .Include(e => e.NavStatica_BB017_EntLiquidada)
                .Include(e => e.NavStatica_BB017_ParcLiquidadas)
                .Include(e => e.NavBB026Forma)
                .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Bb017?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Bb017Id == id);
        }
    }
}
