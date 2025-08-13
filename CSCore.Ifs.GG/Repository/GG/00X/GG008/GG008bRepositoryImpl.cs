using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._00X.GG008;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._00X.GG008
{
    public class GG008bRepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseImpl<CSICP_GG008b>(appDbContext), IGG008bRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG008b> GetByIdAsync(string gg008KdxID, string produtoGG008_ID, int tenant)
        {
            IQueryable<CSICP_GG008b> query = CriaQueryBaseParaGG008b(produtoGG008_ID, tenant);
            query = query.Where(e => e.Id == gg008KdxID);
            CSICP_GG008b? csicpGg008bEntity = await query.FirstOrDefaultAsync();

            if (csicpGg008bEntity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return csicpGg008bEntity;
        }



        public async Task<(IEnumerable<CSICP_GG008b>, int)> GetListAsync(int tenant, string produtoGG008_ID, int pageSize, int page)
        {
            IQueryable<CSICP_GG008b> query = CriaQueryBaseParaGG008b(produtoGG008_ID, tenant);

            var queryCount = query;
            int count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_GG008b> CriaQueryBaseParaGG008b(string produtoGG008_ID, int tenant)
        {
            IQueryable<CSICP_GG008b> query = from gg008b in _appDbContext.OsusrE9aCsicpGg008bs
                                             where gg008b.TenantId == tenant
                                             where gg008b.Gg008bProdutoid == produtoGG008_ID

                                             join gg006 in _appDbContext.OsusrE9aCsicpGg006s
                                             on gg008b.Gg008bMarcaid equals gg006.Id

                                             orderby gg008b.Gg008bDatavigor descending

                                             select new CSICP_GG008b
                                             {
                                                 TenantId = gg008b.TenantId,
                                                 Id = gg008b.Id,
                                                 Gg008bSeq = gg008b.Gg008bSeq,
                                                 Gg008bRefsimilar = gg008b.Gg008bRefsimilar,
                                                 Gg008bDatavigor = gg008b.Gg008bDatavigor,
                                                 Gg008bMarcaid = gg008b.Gg008bMarcaid,
                                                 Gg008bFilialid = gg008b.Gg008bFilialid,
                                                 Gg008bCodgproduto = gg008b.Gg008bCodgproduto,
                                                 Gg008bCodgmarca = gg008b.Gg008bCodgmarca,
                                                 Gg008bProdutoid = gg008b.Gg008bProdutoid,
                                                 NavGg006Marca = new CSICP_GG006
                                                 {
                                                     Id = gg006.Id,
                                                     Gg006Codigomarca = gg006.Gg006Codigomarca,
                                                     Gg006Descmarca = gg006.Gg006Descmarca,
                                                 }
                                             };
            return query;
        }
    }
}
