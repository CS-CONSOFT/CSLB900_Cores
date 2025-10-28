using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public interface IFF136RespositoryImpl : IRepositorioBase<CSICP_FF136>
    {
        Task<(List<CSICP_FF136>, int)> GetListBaixaCartaDeDebito(int tenant, string InFF135_ID, int page, int pageSize);
    }
    public class FF136RespositoryImpl : RepositorioBaseImpl<CSICP_FF136>, IFF136RespositoryImpl
    {
        private AppDbContext AppDbContext;

        public FF136RespositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Ff136RegccredId")
        {
            AppDbContext = appDbContext;
        }

        public async Task<(List<CSICP_FF136>, int)> GetListBaixaCartaDeDebito(int tenant, string InFF135_ID, int page, int pageSize)
        {
            var query = this.AppDbContext.OsusrE9aCsicpFf136s
               .Where(e => e.TenantId == tenant)
               .Where(e => e.Ff136Cdebitoid == InFF135_ID);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.OrderBy(e => e.Ff136Cdebitoid);
            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }
    }
}
