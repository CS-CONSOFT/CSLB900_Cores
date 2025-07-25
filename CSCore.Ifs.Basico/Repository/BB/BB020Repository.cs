using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB020Repository(AppDbContext context) : IBB020Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb020> CreateAsync(CSICP_Bb020 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb020?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb020>> GetListAsync(int tenant)
        {
            IQueryable<CSICP_Bb020> q1 = CreateBaseQuery(tenant).AsQueryable();
            return await q1.ToListAsync();
        }

        public async Task<IEnumerable<CSICP_Bb020>> GetListByFormaPagtoIdAsync(string fPagtoId, int tenant)
        {
            return await CreateBaseQuery(tenant).Where(e => e.Bb020Fpagtoid == fPagtoId).ToListAsync();
        }

        public async Task<IEnumerable<CSICP_Bb020>> GetListTaxaCartaoAdmList(int tenant, string BB019id)
        {
            List<CSICP_Bb020> listTaxaCartao = await CreateBaseQuery(tenant).Where(e => e.Bb019Id == BB019id).ToListAsync();
            return listTaxaCartao;
        }

        public async Task<CSICP_Bb020> RemoveAsync(CSICP_Bb020 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb020> UpdateAsync(CSICP_Bb020 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private IQueryable<CSICP_Bb020> CreateBaseQuery(int tenant)
        {
            return
                _appDbContext.OsusrE9aCsicpBb020s
                .AsSplitQuery()
                .AsNoTracking()
                .Include(e => e.Bb008Condicaodepagamento)
                .Include(e => e.Bb019)
                .Include(e => e.Bb020Fpagto)
                .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Bb020?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}

