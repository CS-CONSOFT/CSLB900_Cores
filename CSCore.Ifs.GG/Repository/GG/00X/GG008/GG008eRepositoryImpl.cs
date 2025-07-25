using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._00X.GG008;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._00X.GG008
{
    public class GG008eRepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseImpl<CSICP_GG008e>(appDbContext, "Gg008eId"), IGG008eRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_GG008e> GetByIdAsync(string GG008e_id, string produtoGG008_ID, int tenant)
        {
            IQueryable<CSICP_GG008e> query = CriaQueryBaseParaGG008e(produtoGG008_ID, tenant);
            query = query.Where(e => e.Gg008eId == long.Parse(GG008e_id));
            CSICP_GG008e? csicpGG008eEntity = await query.FirstOrDefaultAsync();

            if (csicpGG008eEntity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return csicpGG008eEntity;
        }

        public async Task<(IEnumerable<CSICP_GG008e>, int)> GetListAsync(int tenant, string produtoGG008_ID, int pageSize, int page)
        {
            IQueryable<CSICP_GG008e> query = CriaQueryBaseParaGG008e(produtoGG008_ID, tenant);

            var queryCount = query;
            int count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_GG008e> CriaQueryBaseParaGG008e(string produtoGG008_ID, int tenant)
        {
            IQueryable<CSICP_GG008e> query = from GG008e in _appDbContext.OsusrE9aCsicpGg008es
                                             where GG008e.TenantId == tenant
                                             where GG008e.Gg008eProdutoid == produtoGG008_ID

                                             orderby GG008e.Gg008eSeq descending

                                             select new CSICP_GG008e
                                             {
                                                 TenantId = GG008e.TenantId,
                                                 Gg008eId = GG008e.Gg008eId,
                                                 Gg008eSeq = GG008e.Gg008eSeq,
                                                 Gg008eDescricao = GG008e.Gg008eDescricao,
                                                 Gg008eCodigo = GG008e.Gg008eCodigo,
                                                 Gg008eProdutoid = GG008e.Gg008eProdutoid,
                                             };
            return query;
        }
    }
}