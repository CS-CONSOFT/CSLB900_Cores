using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._00X.GG008;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._00X.GG008
{
    public class GG008pRepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseImpl<CSICP_GG008p>(appDbContext), IGG008pRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG008p> GetByIdAsync(string GG008p_id, string produtoGG008Kdx_ID, int tenant)
        {
            IQueryable<CSICP_GG008p> query = CriaQueryBaseParaGG008p(produtoGG008Kdx_ID, tenant);
            CSICP_GG008p? csicpGG008pEntity = await query.FirstOrDefaultAsync();

            if (csicpGG008pEntity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return csicpGG008pEntity;
        }



        public async Task<(IEnumerable<CSICP_GG008p>, int)> GetListAsync(int tenant, string produtoGG008Kdx_ID, int pageSize, int page)
        {
            IQueryable<CSICP_GG008p> query = CriaQueryBaseParaGG008p(produtoGG008Kdx_ID, tenant);

            var queryCount = query;
            int count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_GG008p> CriaQueryBaseParaGG008p(string produtoGG008Kdx_ID, int tenant)
        {
            IQueryable<CSICP_GG008p> query = from GG008p in _appDbContext.OsusrE9aCsicpGg008ps

                                             join gg008kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes
                                             on GG008p.Gg008Id equals gg008kdx.Gg008Produtoid

                                             where GG008p.TenantId == tenant
                                             where gg008kdx.Gg008Kardexid == produtoGG008Kdx_ID

                                             orderby GG008p.Gg008pPrecoBase descending

                                             select new CSICP_GG008p
                                             {
                                                 TenantId = GG008p.TenantId,
                                                 Gg008Id = GG008p.Gg008Id,
                                                 Gg008pPrecoBase = GG008p.Gg008pPrecoBase,
                                                 Gg008pPercVenda1 = GG008p.Gg008pPercVenda1,
                                                 Gg008pPrecoVenda1 = GG008p.Gg008pPrecoVenda1,
                                                 Gg008pPercVenda2 = GG008p.Gg008pPercVenda2,
                                                 Gg008pPrecoVenda2 = GG008p.Gg008pPrecoVenda2,
                                                 Gg008pPercVenda3 = GG008p.Gg008pPercVenda3,
                                                 Gg008pPrecoVenda3 = GG008p.Gg008pPrecoVenda3,
                                                 Gg008pPercVenda4 = GG008p.Gg008pPercVenda4,
                                                 Gg008pPrecoVenda4 = GG008p.Gg008pPrecoVenda4,
                                                 Gg008pPercVenda5 = GG008p.Gg008pPercVenda5,
                                                 Gg008pPrecoVenda5 = GG008p.Gg008pPrecoVenda5,
                                                 Gg008pPercVenda6 = GG008p.Gg008pPercVenda6,
                                                 Gg008pPrecoVenda6 = GG008p.Gg008pPrecoVenda6,
                                                 Gg008pPercVenda7 = GG008p.Gg008pPercVenda7,
                                                 Gg008pPrecoVenda7 = GG008p.Gg008pPrecoVenda7,
                                                 Gg008pPercVenda8 = GG008p.Gg008pPercVenda8,
                                                 Gg008pPrecoVenda8 = GG008p.Gg008pPrecoVenda8,
                                                 Gg008pPercVenda9 = GG008p.Gg008pPercVenda9,
                                                 Gg008pPrecoVenda9 = GG008p.Gg008pPrecoVenda9,
                                             };
            return query;
        }
    }
}
