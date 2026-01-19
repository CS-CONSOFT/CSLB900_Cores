using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.DD;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.DD.Repository.DD
{
    public class DD000RepositoryImpl : RepositorioBaseImpl<CSICP_DD000>, IDD000Repository
    {
        private readonly AppDbContext _appDbContext;

        public DD000RepositoryImpl(AppDbContext context)
            : base(context, IdIdentifierName: "Dd000ConfigId", TenantIdentifierName: "TenantId")
        {
            _appDbContext = context;
        }

        public async Task<CSICP_DD000?> GetByIdAsync(string InDD000ID, int InTenantID)
        {
            IQueryable <CSICP_DD000> query = GetQueryWithIncludes(InTenantID);
            return await query.FirstOrDefaultAsync(e => e.Dd000ConfigId == InDD000ID);
        }

        public async Task<(List<CSICP_DD000>, int)> GetListAsync(int InTenantID, string? InEstabID, int InPageNumber, int InPageSize)
        {
            IQueryable<CSICP_DD000> query = _appDbContext.OsusrTeiCsicpDd000s
                .Where(e => e.TenantId == InTenantID)
                .AsNoTracking()
                .Include(e => e.NavDD000Filial)
                .Include(e => e.NavDD000CtrlSerieNf)
                .Include(e => e.NavDD000CtrlSerieCf)
                .Include(e => e.NavDD000CtrlSerieNfce)
                .Include(e => e.NavDD000CtrlContigenciaNfce)
                .Include(e => e.NavDD000UfOrgao)
                .Include(e => e.NavDD000AmbNfe)
                .Include(e => e.NavDD000VersaoNfe)
                .Include(e => e.NavDD000LcertDigital)
                .Include(e => e.NavDD000ZoneTime);

            if (!string.IsNullOrWhiteSpace(InEstabID))
                query = query.Where(e => e.Dd000FilialId == InEstabID);

            var count = await query.CountAsync();
            
            query = query.OrderBy(e => e.Dd000ConfigId)
                .PaginacaoNoBanco(InPageNumber, InPageSize);

            List<CSICP_DD000> resultList = await query.ToListAsync();
            return (resultList, count);
        }

        
        private IQueryable<CSICP_DD000> GetQueryWithIncludes(int InTenantID)
        {
            return _appDbContext.OsusrTeiCsicpDd000s
                .Where(e => e.TenantId == InTenantID)
                .AsNoTracking()
                .Include(e => e.NavDD000Filial)
                .Include(e => e.NavDD000CtrlSerieNf)
                .Include(e => e.NavDD000CtrlSerieCf)
                .Include(e => e.NavDD000CtrlSerieNfce)
                .Include(e => e.NavDD000CtrlContigenciaNfce)
                .Include(e => e.NavDD000UfOrgao)
                .Include(e => e.NavDD000AmbNfe)
                .Include(e => e.NavDD000VersaoNfe)
                .Include(e => e.NavDD000LcertDigital)
                .Include(e => e.NavDD000ZoneTime);
        }
    }
}