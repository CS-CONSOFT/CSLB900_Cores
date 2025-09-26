using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._01X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF014;

namespace CSCore.Ifs.FF.Repository.FF01X
{
    public class FF014RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF014>(appDbContext, "Id"), IFF014Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_FF014?> GetByIdAsync(int in_tenantID, string in_ff014ID)
        {
            IQueryable<CSICP_FF014> query = GetQueryBase(in_tenantID);
            CSICP_FF014? CSICP_FF014 = await query.FirstOrDefaultAsync(e => e.Id == in_ff014ID);
            return CSICP_FF014;
        }

        public async Task<(List<CSICP_FF014>, int)> GetListAsync(int in_tenantID, int in_pageNumber, int in_pageSize, 
            string in_filialID, string? in_descricao)
        {
            IQueryable<CSICP_FF014> query = GetQueryBase(in_tenantID);
            query = FiltraQuandoExisteFiltro(in_filialID, in_descricao, query);

            query = query.Where(e => e.Ff014Comissaoid == null); // Somente comissões pai

            var queryCount = query;
            var count = queryCount.Count();

            query = query.OrderBy(e => e.Id);
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_FF014> FiltraQuandoExisteFiltro(string in_filialID, string? in_descricao, IQueryable<CSICP_FF014> query)
        {
            if (!string.IsNullOrEmpty(in_filialID))
                query = query.Where(e => e.Ff014Filialid == in_filialID);

            if (!string.IsNullOrEmpty(in_descricao))
                query = query.Where(e => e.Ff014Descricao != null && e.Ff014Descricao.Contains(in_descricao));

            return query;
        }

        private IQueryable<CSICP_FF014> GetQueryBase(int in_tenantID)
        {
            return _appDbContext.OsusrE9aCsicpFf014s
                   .AsNoTracking()
                   .Where(e => e.TenantId == in_tenantID)
                   .Include(e => e.NavBB001)
                   .Include(e => e.NavFF014ComissaoFilho);
                   
        }
    }
}