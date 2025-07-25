using CSCore.Domain;
using CSCore.Domain.Interfaces.BB.Estabelecimento;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB001ImageRepository(AppDbContext context) : IBB001ImgRepository
    {
        private readonly AppDbContext _appDbContext = context;
        public async Task<CSICP_BB001Img> CreateAsync(CSICP_BB001Img entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<CSICP_BB001Img>> GetAllByParentId(string parentId, int tenant)
        {
            return await CreateBaseQueryParent(tenant, parentId).Include(e => e.StatusNavigation).ToListAsync();
        }

        public async Task<CSICP_BB001Img?> GetEntityAsync(string pkId, int tenant)
        {
            return await CreateBaseQuery(tenant, pkId).FirstOrDefaultAsync();
        }

        public async Task<CSICP_BB001Img> RemoveAsync(CSICP_BB001Img entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private IQueryable<CSICP_BB001Img> CreateBaseQueryParent(int tenant, string BB001_ID)
        {
            return _appDbContext.E9ACSICP_BB001Imgs
                 .Where(c => c.Empresaid == BB001_ID)
                 .Where(c => c.TenantId == tenant)
                 .AsQueryable();
        }

        private IQueryable<CSICP_BB001Img> CreateBaseQuery(int tenant, string pkId)
        {
            return _appDbContext.E9ACSICP_BB001Imgs
                 .Where(c => c.Id == pkId)
                 .Where(c => c.TenantId == tenant)
                 .AsQueryable();
        }

        public async Task GetBB001UpdateImgPadrao(int tenant, string Id, string estabLogadoId)
        {
            using (var trans = await _appDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    CSICP_BB001Img? cSICP_BB001ImgPadrao = await _appDbContext.E9ACSICP_BB001Imgs
                        .Where(c => c.TenantId == tenant)
                        .Where(c => c.Id == Id)
                        .FirstOrDefaultAsync();

                    if (cSICP_BB001ImgPadrao == null)
                        throw new Exception($"Imagem com Id {Id} não encontrada.");

                    List<CSICP_BB001Img> cSICP_BB001Imgs = await _appDbContext.E9ACSICP_BB001Imgs
                        .Where(c => c.TenantId == tenant)
                        .Where(c => c.Isactive == true)
                        .Where(c => c.Status == cSICP_BB001ImgPadrao.Status)
                        .Where(c => c.Empresaid == estabLogadoId)
                        .ToListAsync();

                    foreach (CSICP_BB001Img cSICP_BB001Img in cSICP_BB001Imgs)
                    {
                        cSICP_BB001Img.Isactive = false;
                        _appDbContext.Update(cSICP_BB001Img);
                        await _appDbContext.SaveChangesAsync();
                    }

                    cSICP_BB001ImgPadrao.Isactive = !cSICP_BB001ImgPadrao.Isactive;
                    _appDbContext.Update(cSICP_BB001ImgPadrao);
                    await _appDbContext.SaveChangesAsync();
                    await trans.CommitAsync();
                }
                catch (Exception)
                {
                    await trans.RollbackAsync();
                    throw;
                }
            }

        }
    }
}
