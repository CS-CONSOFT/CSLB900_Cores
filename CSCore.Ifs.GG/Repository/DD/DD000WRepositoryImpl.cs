using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.DD;
using CSCore.Ifs.Compartilhado.CS_Context;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.DD;

public class DD000WRepositoryImpl : RepositorioBaseImpl<CSICP_DD000W>, IDD000WRepository
{
    private readonly AppDbContext _appDbContext;

    public DD000WRepositoryImpl(AppDbContext context)
        : base(context, IdIdentifierName: "Dd000Id", TenantIdentifierName: "TenantId")
    {
        _appDbContext = context;
    }

    public async Task<CSICP_DD000W?> GetByIdAsync(string dd000Id, int tenantId)
    {
        IQueryable<CSICP_DD000W> query = GetQueryWithIncludes(tenantId);
        return await query.FirstOrDefaultAsync(e => e.Dd000Id == dd000Id);
    }

    public async Task<(List<CSICP_DD000W>, int)> GetListAsync(int tenantId, string? dd000ConfigId, int pageNumber, int pageSize)
    {
        IQueryable<CSICP_DD000W> query = GetQueryWithIncludes(tenantId);

        if (!string.IsNullOrWhiteSpace(dd000ConfigId))
            query = query.Where(e => e.Dd000ConfigId == dd000ConfigId);

        var count = await query.CountAsync();

        query = query.OrderBy(e => e.Dd000Id)
            .PaginacaoNoBanco(pageNumber, pageSize);

        List<CSICP_DD000W> resultList = await query.ToListAsync();
        return (resultList, count);
    }

    private IQueryable<CSICP_DD000W> GetQueryWithIncludes(int tenantId)
    {
        return _appDbContext.OsusrTeiCsicpDd000Ws
            .Where(e => e.TenantId == tenantId)
            .AsNoTracking()
            .Include(e => e.NavDD000Config)
            .Include(e => e.NavDD000Nfcf)
            .Include(e => e.NavDD000Servnfe);
    }
}