using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF112;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF113;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF113RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF113>(appDbContext, "Id"), IFF113Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<RepoDtoCSICP_FF113?> GetByIdAsync(int in_tenant, string in_ff113Id)
        {
            IQueryable<RepoDtoCSICP_FF113> query = GetQueryBase(in_tenant);
            RepoDtoCSICP_FF113? cSICP_FF113 = await query.FirstOrDefaultAsync(e => e.Id == in_ff113Id);
            return cSICP_FF113;
        }

        private IQueryable<RepoDtoCSICP_FF113> GetQueryBase(int in_tenant)
        {
            throw new NotImplementedException();
        }

        public Task<(List<RepoDtoCSICP_FF113>, int)> GetListAsync(
            int in_tenant, int in_page, int in_pageSize, string? in_filialId, DateTime? in_dataRegistroInicio, DateTime? in_dataRegistroFim, int? in_tipo)
        {
            throw new NotImplementedException();
        }
    }
}
