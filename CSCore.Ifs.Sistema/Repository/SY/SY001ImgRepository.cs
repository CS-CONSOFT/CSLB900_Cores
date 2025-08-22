using CSCore.Domain;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ex.Personalizada;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY001ImgRepository : ISY001ImgRepository
    {
        private AppDbContext _appDbContext;

        public SY001ImgRepository(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy001Img> CreateAsync(Csicp_Sy001Img entity)
        {
            var hasImage = await _appDbContext
                .OsusrE9aCsicpSy001Imgs
                .Where(e => e.TenantId == entity.TenantId && e.UsuarioId == entity.UsuarioId)
                .AnyAsync();
            if(hasImage) throw new ExceptionSemAuditoria("O usuário já possui uma imagem cadastrada.");

            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy001Img?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<Csicp_Sy001Img>> GetListAsync(int tenant, string? search)
        {
            IQueryable<Csicp_Sy001Img> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, q1);
            return await q1.ToListAsync();
        }

        public async Task<Csicp_Sy001Img> RemoveAsync(Csicp_Sy001Img entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy001Img> UpdateAsync(Csicp_Sy001Img entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<Csicp_Sy001Img> ChangeActive(Csicp_Sy001Img entity)
        {
            entity.Ispadrao = !entity.Ispadrao;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<Csicp_Sy001Img> FiltraQuandoExisteFiltros(string? search, IQueryable<Csicp_Sy001Img> query)
        {
            if (search != null)
            {
            }

            return query;
        }


        private IQueryable<Csicp_Sy001Img> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy001Imgs
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<Csicp_Sy001Img?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
