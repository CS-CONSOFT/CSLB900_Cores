using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._01X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF011;

namespace CSCore.Ifs.FF.Repository.FF01X
{
    public class FF011RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF011>(appDbContext, "Id"), IFF011Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<RepoDtoCSICP_FF011?> GetByIdAsync(int in_tenantID, string in_ff011ID)
        {
            IQueryable<RepoDtoCSICP_FF011> query = GetQueryBase(in_tenantID);
            RepoDtoCSICP_FF011? CSICP_FF011 = await query.FirstOrDefaultAsync(e => e.Id == in_ff011ID);
            return CSICP_FF011;
        }

        public async Task<(List<RepoDtoCSICP_FF011>, int)> GetListAsync(int in_tenantID, int in_pageNumber, int in_pageSize, 
            string in_estabID, string? in_tipoCobrancaID, string? in_categoriaID)
        {
            IQueryable<RepoDtoCSICP_FF011> query = GetQueryBase(in_tenantID);
            query = FiltraQuandoExisteFiltro(in_estabID, in_tipoCobrancaID, in_categoriaID, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<RepoDtoCSICP_FF011> FiltraQuandoExisteFiltro(string in_estabID, string? in_tipoCobrancaID, string? in_categoriaID, IQueryable<RepoDtoCSICP_FF011> query)
        {
            //if (!string.IsNullOrEmpty(in_estabID))
            //    query = query.Where(e => e.Id == in_estabID);

            if (!string.IsNullOrEmpty(in_tipoCobrancaID))
                query = query.Where(e => e.Ff011Tipocobrancaid == in_tipoCobrancaID);

            if (!string.IsNullOrEmpty(in_categoriaID))
                query = query.Where(e => e.Ff011Categoriaid == in_categoriaID);

            return query;
        }

        private IQueryable<RepoDtoCSICP_FF011> GetQueryBase(int in_tenantID)
        {
            return from ff011 in _appDbContext.OsusrE9aCsicpFf011s
                   .AsNoTracking()
                   
                   join bb009 in _appDbContext.OsusrE9aCsicpBb009s
                   on ff011.Ff011Tipocobrancaid equals bb009.Id into bb009_join
                   from bb009 in bb009_join.DefaultIfEmpty()

                   join bb029 in _appDbContext.OsusrE9aCsicpBb029s
                   on ff011.Ff011Categoriaid equals bb029.Id into bb029_join
                   from bb029 in bb029_join.DefaultIfEmpty()

                   join ff998 in _appDbContext.OsusrE9aCsicpFf998s
                   on ff011.Ff011SitcobrancaentId equals ff998.Id into ff998_join
                   from ff998 in ff998_join.DefaultIfEmpty()

                   join bb012Ent in _appDbContext.OsusrE9aCsicpBb012Sitcta
                   on ff011.Ff011SituacaoentId equals bb012Ent.Id into bb012Ent_join
                   from bb012Ent in bb012Ent_join.DefaultIfEmpty()

                   join bb012Sai in _appDbContext.OsusrE9aCsicpBb012Sitcta
                   on ff011.Ff011SituacaosaiId equals bb012Sai.Id into bb012Sai_join
                   from bb012Sai in bb012Sai_join.DefaultIfEmpty()

                   where ff011.TenantId == in_tenantID
                   select new RepoDtoCSICP_FF011
                   {
                       TenantId = ff011.TenantId,
                       Id = ff011.Id,
                       Ff011Codigo = ff011.Ff011Codigo,
                       Ff011DiasAtrasosDe = ff011.Ff011DiasAtrasosDe,
                       Ff011DiasAtrasosAte = ff011.Ff011DiasAtrasosAte,
                       Ff011Tipocobrancaid = ff011.Ff011Tipocobrancaid,
                       Ff011Categoriaid = ff011.Ff011Categoriaid,
                       Ff011SitcobrancaentId = ff011.Ff011SitcobrancaentId,
                       Ff011SituacaoentId = ff011.Ff011SituacaoentId,
                       Ff011SituacaosaiId = ff011.Ff011SituacaosaiId,

                       NavBB009 = bb009 != null ? new CSICP_Bb009
                       {
                           TenantId = bb009.TenantId,
                           Id = bb009.Id,
                           Bb009Filial = bb009.Bb009Filial,
                           Bb009Codigo = bb009.Bb009Codigo,
                           Bb009Tipocobranca = bb009.Bb009Tipocobranca,
                           Bb009Isactive = bb009.Bb009Isactive
                       } : null,

                       NavBB029 = bb029 != null ? new CSICP_Bb029
                       {
                           TenantId = bb029.TenantId,
                           Id = bb029.Id,
                           Bb029Codgcategoria = bb029.Bb029Codgcategoria,
                           Bb029Categoria = bb029.Bb029Categoria,
                           Bb029IsActive = bb029.Bb029IsActive
                       } : null,

                       NavFF998SitCobrancaEnt = ff998 != null ? new CSICP_FF998
                       {
                           Id = ff998.Id,
                           Label = ff998.Label,
                           Order = ff998.Order,
                           IsActive = ff998.IsActive,
                           Codgcs = ff998.Codgcs
                       } : null,

                       NavBB012SitEnt = bb012Ent != null ? new CSICP_Bb012Sitcta
                       {
                            Id = bb012Ent.Id,
                            Label = bb012Ent.Label,
                            Order = bb012Ent.Order,
                            IsActive = bb012Ent.IsActive,
                            Codgcs = bb012Ent.Codgcs
                       } : null,

                       NavBB012SitSai = bb012Sai != null ? new CSICP_Bb012Sitcta
                       {
                            Id = bb012Sai.Id,
                            Label = bb012Sai.Label,
                            Order = bb012Sai.Order,
                            IsActive = bb012Sai.IsActive,
                            Codgcs = bb012Sai.Codgcs
                       } : null
                   };
        }
    }
}
