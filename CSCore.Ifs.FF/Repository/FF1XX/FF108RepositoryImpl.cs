using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF108RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF108>(appDbContext, "Ff108Id"), IFF108Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<(List<CSICP_FF108>, int)> GetListAsync(int in_tenant,
            string in_ff105Id, int in_pageNumber, int in_pageSize)
        {
            IQueryable<CSICP_FF108> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_ff105Id, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_FF108> FiltraQuandoExisteFiltro(string in_ff105Id, IQueryable<CSICP_FF108> query)
        {
            if(in_ff105Id != null)
                query = query.Where(e => e.Ff105Borderoid!.Equals(in_ff105Id));
            return query;
        }

        private IQueryable<CSICP_FF108> GetQueryBase(int in_tenant)
        {
            return from ff108 in _appDbContext.OsusrE9aCsicpFf108s
                   .AsNoTracking()

                   where ff108.TenantId == in_tenant
                   select new CSICP_FF108
                   {
                       TenantId = ff108.TenantId,
                       Ff108Id = ff108.Ff108Id,
                       Ff105Borderoid = ff108.Ff105Borderoid,
                       Ff108Datahora = ff108.Ff108Datahora,
                       Ff108Mensagem = ff108.Ff108Mensagem,
                       Ff108UsuarioId = ff108.Ff108UsuarioId
                   };
        }
    }
}
