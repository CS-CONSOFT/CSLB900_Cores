using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._03X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._03X
{
    public class GG034RepositoryImpl(AppDbContext appDbContext) : RepositorioBaseImpl<CSICP_GG034>(appDbContext), IGG034Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG034?> GetByIdAsync(int tenant, string id)
        {
            IQueryable<CSICP_GG034> query = CriaQueryBase(tenant);
            query = query.Where(e => e.Id == id);

            CSICP_GG034? csicpGg030Entity = await query.FirstOrDefaultAsync();
            if (csicpGg030Entity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return csicpGg030Entity;
        }

        public async Task<(IEnumerable<CSICP_GG034>, int)> GetListAsync(int tenant, int pageSize, int page)
        {
            IQueryable<CSICP_GG034> query = CriaQueryBase(tenant);

            query = query.PaginacaoNoBanco(page, pageSize);

            int count = query.GetCountTotal();

            List<CSICP_GG034> listaCSICP_GG034 = await query.ToListAsync();
            return (listaCSICP_GG034, count);
        }

        private IQueryable<CSICP_GG034> CriaQueryBase(int tenant)
        {
            IQueryable<CSICP_GG034> query = from _CSICP_GG034 in _appDbContext.OsusrE9aCsicpGg034s
                                            where _CSICP_GG034.TenantId == tenant
                                            select _CSICP_GG034;
            return query;
        }
    }
}
