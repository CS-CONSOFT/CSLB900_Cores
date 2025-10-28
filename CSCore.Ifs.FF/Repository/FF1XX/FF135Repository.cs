using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public interface IFF135Repository
    {
        Task<CSICP_FF135> GetById(int tenant, string id);
        Task<(List<CSICP_FF135>, int)> GetListCartaDeDebito(int tenant, DateTime DataInicial, DateTime DataFinal, string BB012_ContaID, int status, int page, int pageSize);
    }
    public class FF135Repository : IFF135Repository
    {
        private readonly AppDbContext appDbContext;

        public FF135Repository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<CSICP_FF135> GetById(int tenant, string id)
        {
            var WorkFF135 = await this.appDbContext.OsusrE9aCsicpFf135s
                .Where(e => e.TenantId == tenant)
                .Where(e => e.Ff135CartadebitoId == id)
                .FirstOrDefaultAsync() ?? throw new Exception("Registro não encontrado");


            return WorkFF135;
        }

        public async Task<(List<CSICP_FF135>, int)> GetListCartaDeDebito(int tenant, DateTime DataInicial, DateTime DataFinal, string BB012_ContaID, int status, int page, int pageSize)
        {

            var query = this.appDbContext.OsusrE9aCsicpFf135s
                .Where(e => e.TenantId == tenant)
                .Where(e => e.Ff135DataMovto >= DataInicial)
                .Where(e => e.Ff135DataMovto <= DataFinal)
                .Where(e => e.Ff135Statusid <= status)
                .Where(e => e.Ff135ContafornecId == BB012_ContaID);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.OrderBy(e => e.Ff135CartadebitoId);
            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }
    }
}
