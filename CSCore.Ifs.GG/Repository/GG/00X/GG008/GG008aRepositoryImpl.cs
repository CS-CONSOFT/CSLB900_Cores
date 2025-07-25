using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._00X.GG008;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._00X.GG008
{
    public class GG008aRepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseImpl<CSICP_GG008a>(appDbContext), IGG008aRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG008a> GetByIdAsync(string gg008a_id, string produtoGG008_ID, int tenant)
        {
            IQueryable<CSICP_GG008a> query = CriaQueryBaseParaGG008a(produtoGG008_ID, tenant);
            CSICP_GG008a? csicpGG008aEntity = await query.FirstOrDefaultAsync();

            if (csicpGG008aEntity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return csicpGG008aEntity;
        }



        public async Task<(IEnumerable<CSICP_GG008a>, int)> GetListAsync(int tenant, string produtoGG008_ID, int pageSize, int page)
        {
            IQueryable<CSICP_GG008a> query = CriaQueryBaseParaGG008a(produtoGG008_ID, tenant);

            var queryCount = query;
            int count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_GG008a> CriaQueryBaseParaGG008a(string produtoGG008_ID, int tenant)
        {
            IQueryable<CSICP_GG008a> query = from GG008a in _appDbContext.OsusrE9aCsicpGg008as
                                             where GG008a.TenantId == tenant
                                             where GG008a.Gg008aProdutoid == produtoGG008_ID

                                             orderby GG008a.Gg08aCaracteristica descending

                                             select new CSICP_GG008a
                                             {
                                                 TenantId = GG008a.TenantId,
                                                 Id = GG008a.Id,
                                                 Gg008aFilialid = GG008a.Gg008aFilialid,
                                                 Gg008aProdutoid = GG008a.Gg008aProdutoid,
                                                 Gg08aFilial = GG008a.Gg08aFilial,
                                                 Gg08aCodgProduto = GG008a.Gg08aCodgProduto,
                                                 Gg08aLinha = GG008a.Gg08aLinha,
                                                 Gg08aCaracteristica = GG008a.Gg08aCaracteristica,
                                                 Gg008aValor = GG008a.Gg008aValor,
                                             };
            return query;
        }
    }
}
