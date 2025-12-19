using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG06X.CG060;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG06X.CG060
{
    public class CG060RepositoryImpl : RepositorioBaseImplV2<Osusr8dwCsicpCg060>, ICG060Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG060RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg060Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<Osusr8dwCsicpCg060?> GetByIdAsync(int InTenantID, long InCG060ID)
        {
            return await _appDbContext.Osusr8dwCsicpCg060s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Cg060Id == InCG060ID)
                .Include(e => e.NavCG050Evento_CG060)
                .Include(e => e.NavCG050EventoTpDeb_CG060)
                .Include(e => e.NavCG050EventoTpCred_CG060)
                .Include(e => e.NavBB001Estab_CG060)
                .FirstOrDefaultAsync();
        }

        public async Task<(List<Osusr8dwCsicpCg060>, int)> GetListAsync(
            int InTenantID,
            string? InDescricao,
            long? InEventoID,
            int InPageNumber, 
            int InPageSize)
        {
            IQueryable<Osusr8dwCsicpCg060> query = _appDbContext.Osusr8dwCsicpCg060s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID)
                .Include(e => e.NavCG050Evento_CG060)
                .Include(e => e.NavCG050EventoTpDeb_CG060)
                .Include(e => e.NavCG050EventoTpCred_CG060)
                .Include(e => e.NavBB001Estab_CG060);

            if (!string.IsNullOrWhiteSpace(InDescricao))
            {
                query = query.Where(e => e.Cg060Txdescricao!.Contains(InDescricao));
            }

            if (InEventoID.HasValue)
            {
                query = query.Where(e => e.Cg060Eventoid == InEventoID.Value);
            }

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.OrderByDescending(e => e.Cg060Id);
            query = query.PaginacaoNoBanco(InPageNumber, InPageSize);

            return (await query.ToListAsync(), count);
        }
    }
}