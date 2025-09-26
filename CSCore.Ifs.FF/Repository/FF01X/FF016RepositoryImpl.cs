using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.FF._01X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF01X
{
    public class FF016RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF016>(appDbContext, "Id"), IFF016Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_FF016?> GetByIdAsync(int in_tenant, string in_ff016Id)
        {
            IQueryable<CSICP_FF016> query = GetQueryBase(in_tenant);
            CSICP_FF016? cSICP_FF016 = await query.FirstOrDefaultAsync(e => e.Id == in_ff016Id);
            return cSICP_FF016;
        }

        private IQueryable<CSICP_FF016> GetQueryBase(int in_tenant)
        {
            return from ff016 in _appDbContext.OsusrE9aCsicpFf016s
                   .AsNoTracking()

                   join ff016Email in _appDbContext.OsusrE9aCsicpFf016Emails
                   on ff016.Ff016EmailsdestId equals ff016Email.Id into ff016Email_join
                   from ff016Email in ff016Email_join.DefaultIfEmpty()

                   where ff016.TenantId == in_tenant
                   select new CSICP_FF016
                   {
                       TenantId = ff016.TenantId,
                       Id = ff016.Id,
                       Ff016DescricaoCarta = ff016.Ff016DescricaoCarta,
                       Ff016Texto = ff016.Ff016Texto,
                       Ff016EmailsdestId = ff016.Ff016EmailsdestId,
                       Ff016Textocarta = ff016.Ff016Textocarta,

                       NavFF016Email = ff016Email != null ? new OsusrE9aCsicpFf016Email
                       {
                           Id = ff016Email.Id,
                           Label = ff016Email.Label,
                           Order = ff016Email.Order,
                           IsActive = ff016Email.IsActive
                       } : null,
                   };
        }

        public async Task<(List<CSICP_FF016>, int)> GetListAsync(
            int in_tenant, string? in_descricaoCarta, int in_pageNumber, int in_pageSize)
        {
            IQueryable<CSICP_FF016> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_descricaoCarta, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_FF016> FiltraQuandoExisteFiltro(
            string? in_descricaoCarta, IQueryable<CSICP_FF016> query)
        {
            if (!string.IsNullOrEmpty(in_descricaoCarta))
                query = query.Where(e => e.Ff016DescricaoCarta!.Contains(in_descricaoCarta));
            
            return query;
        }
    }
}