using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.NN.Dto;
using CSCore.Application.Dto.Mapper.FF.FF1XX;
using CSCore.Domain.CS_Models.CSICP_NN;
using CSCore.Domain.EstaticasLabel.GG;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.NN.NN016
{
    public class NN016RepositoryImpl : RepositorioBaseImpl<CSICP_NN016>, INN016Repository
    {
        private readonly AppDbContext _appDbContext;

        public NN016RepositoryImpl(AppDbContext appDbContext)
            : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<CSICP_NN016?> GetByIdAsync(int tenant, string id)
        {
            var query = _appDbContext.OsusrE9aCsicpNn016s
                .Where(e => e.TenantId == tenant && e.Nn016Id == id)
                .Include(e => e.NavFF102Sit)
                .Include(e => e.NavFF102Titulo)
                    .ThenInclude(e => e.NavBB001)
                .Include(e => e.NavFF102Titulo)
                    .ThenInclude(e => e.NavBB012);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<(IEnumerable<CSICP_NN016>, int)> GetListAsync(int tenant,string NN015_ID, int page, int pageSize)
        {
            var query = _appDbContext.OsusrE9aCsicpNn016s.Where(e => e.TenantId == tenant).Where(e => e.Nn016CrcpId == NN015_ID)
                 .Include(e => e.NavFF102Sit)
                .Include(e => e.NavFF102Titulo)
                  .Include(e => e.NavFF102Titulo)
                    .ThenInclude(e => e.NavBB001)
                .Include(e => e.NavFF102Titulo)
                    .ThenInclude(e => e.NavBB012)
                   .AsNoTracking();

            var queryCount = query;
            var count = queryCount.Count();
            query = query.OrderBy(e => e.Nn016CrcpId);
            query = query.PaginacaoNoBanco(page, pageSize);

           
            return (await query.ToListAsync(), count);
        }

        public async Task<IEnumerable<CSICP_NN016>> GetListAsyncPorNN015ParaBaixaContasaReceberPagar(int tenant, string InNN015)
        {
            var idAberto = await _appDbContext.OsusrE9aCsicpFf102Sits
                .Where(e => e.Label!.Equals(Entities.FF102_Sit.Aberto))
                .Select(e => e.Id).FirstOrDefaultAsync();

            var idBxParcial = await _appDbContext.OsusrE9aCsicpFf102Sits
                .Where(e => e.Label!.Equals(Entities.FF102_Sit.BxParcial))
                .Select(e => e.Id).FirstOrDefaultAsync();

            var query = _appDbContext.OsusrE9aCsicpNn016s
                .Where(e => e.TenantId == tenant)
                .Where(e => e.Nn016CrcpId == InNN015)
                .Where(e => e.Nn016SituacaotitId == idAberto || e.Nn016SituacaotitId == idBxParcial)
                  .AsNoTracking();

            query = query.OrderBy(e => e.Nn016CrcpId);

            var lista = await query.ToListAsync();
            return lista;
        }
    }
}
