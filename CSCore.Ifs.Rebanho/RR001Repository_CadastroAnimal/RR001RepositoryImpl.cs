using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X;
using CSCore.Domain.Interfaces.RR._00X.IRR001;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.Rebanho.RR001Repository_CadastroAnimal
{
    public class RR001RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr001>, IRR001Repository
    {
        private readonly AppDbContext _appDbContext;
        public RR001RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr001?> GetByIdAsync(int In_TenantID, string In_IDRR001)
        {
            return await _appDbContext.OsusrTo3CsicpRr001s
                .FirstOrDefaultAsync(e => e.TenantId == In_TenantID && e.Id == In_IDRR001);
        }

        public async Task<(List<OsusrTo3CsicpRr001>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR001 prm)
        {
            IQueryable<OsusrTo3CsicpRr001> query = GetQueryBase(In_TenantID);

            var totalCount = await query.CountAsync();
            var items = await query.ToListAsync();

            return (items, totalCount);
        }

        private IQueryable<OsusrTo3CsicpRr001> GetQueryBase(int In_TenantID)
        {
            return _appDbContext.OsusrTo3CsicpRr001s
                .AsNoTracking()
                .Where(e => e.TenantId == In_TenantID)
                .Include(e => e.NavRR001Ativo)
                .Include(e => e.NavRR001Cat)
                .Include(e => e.NavRR001Categoria);
        }
    }
}
