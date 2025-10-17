using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public interface IFF141Repository : IRepositorioBase<CSICP_FF141>
    {
        Task<(List<CSICP_FF141>, int)> GetListAsync(int in_tenant, long in_ff140_id, int in_pageNumber, int in_pageSize);
        Task<CSICP_FF141> GetByIdAsync(int in_tenant, long in_ff141_id);
    }

    public class FF141RepositoryImpl : RepositorioBaseImpl<CSICP_FF141>, IFF141Repository
    {
        private AppDbContext AppDbContext;

        public FF141RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Ff141Id")
        {
            AppDbContext = appDbContext;
        }

        public async Task<CSICP_FF141> GetByIdAsync(int in_tenant, long in_ff141_id)
        {
            return await AppDbContext.OsusrE9aCsicpFf141s
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.TenantId == in_tenant && e.Ff141Id == in_ff141_id) ?? 
                throw new KeyNotFoundException();
        }

        public async Task<(List<CSICP_FF141>, int)> GetListAsync(int in_tenant, long in_ff140_id, int in_pageNumber, int in_pageSize)
        {
            var q = AppDbContext.OsusrE9aCsicpFf141s
                .AsNoTracking()
                .Where(e => e.TenantId == in_tenant && e.Ff140RdId == in_ff140_id)
                ;

            var qc = q;
            int count = await qc.CountAsync();

            q = q.PaginacaoNoBanco(in_pageNumber, in_pageSize);
            return (await q.ToListAsync(), count);
        }
    }
}
