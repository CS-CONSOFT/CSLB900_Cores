using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG06X.CG063;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG06X.CG063
{
    public class CG063RepositoryImpl : RepositorioBaseImplV2<Osusr8dwCsicpCg063>, ICG063Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG063RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg063Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<Osusr8dwCsicpCg063?> GetByIdAsync(int InTenantID, long InCG063ID)
        {
            return await _appDbContext.Osusr8dwCsicpCg063s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Cg063Id == InCG063ID)
                .Include(e => e.NavCG051PrmEvento_CG063)
                .Include(e => e.NavCG060RegramentoID_CG063)
                .FirstOrDefaultAsync();
        }

        public async Task<(List<Osusr8dwCsicpCg063>, int)> GetListAsync(int InTenantID, int InPageNumber, int InPageSize)
        {
            IQueryable<Osusr8dwCsicpCg063> query = _appDbContext.Osusr8dwCsicpCg063s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID)
                .Include(e => e.NavCG051PrmEvento_CG063)
                .Include(e => e.NavCG060RegramentoID_CG063);

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.OrderByDescending(e => e.Cg063Id);
            query = query.PaginacaoNoBanco(InPageNumber, InPageSize);

            return (await query.ToListAsync(), count);
        }

        public async Task<int> CriarParametrosCG063Async(int InTenantID, long InCG060ID)
        {
            // 1. Busca CG060
            var eventoCg060 = await _appDbContext.Osusr8dwCsicpCg060s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Cg060Id == InCG060ID)
                .FirstOrDefaultAsync();

            if (eventoCg060 == null)
                throw new KeyNotFoundException($"Regramento CG060 com ID {InCG060ID} não encontrado.");

            // 2. Busca CG051 com seus parâmetros (CG052) incluídos
            var listaCg051 = await _appDbContext.Osusr8dwCsicpCg051s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Cg051Eventotpid == eventoCg060.Cg060Eventoid)
                .Include(e => e.NavCG052PrmEvento_CG051)
                .ToListAsync();

            if (!listaCg051.Any())
            {
                throw new KeyNotFoundException(
                    $"Nenhum parâmetro CG051 encontrado para o Evento ID {eventoCg060.Cg060Eventoid}.");
            }

            // 3. Busca CG063 existentes em uma única consulta
            var cg051Ids = listaCg051.Select(c => c.Cg051Id).ToList();

            var cg063Existentes = await _appDbContext.Osusr8dwCsicpCg063s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID
                    && e.Cg063Regramentoid == InCG060ID
                    && e.Cg063Eventopartpid.HasValue
                    && cg051Ids.Contains(e.Cg063Eventopartpid.Value))
                .Select(e => e.Cg063Eventopartpid!.Value)
                .ToListAsync();

            // 4. Cria apenas os que não existem
            var novosRegistros = listaCg051
                .Where(itemCg051 => !cg063Existentes.Contains(itemCg051.Cg051Id))
                .Select(itemCg051 => new Osusr8dwCsicpCg063
                {
                    TenantId = InTenantID,
                    Cg063Regramentoid = InCG060ID,
                    Cg063Eventopartpid = itemCg051.Cg051Id
                    // Use itemCg051.NavCG052PrmEvento_CG051 se precisar dos dados de CG052
                })
                .ToList();

            if (novosRegistros.Any())
            {
                await _appDbContext.Osusr8dwCsicpCg063s.AddRangeAsync(novosRegistros);
                await _appDbContext.SaveChangesAsync();
            }

            return novosRegistros.Count;
        }
    }
}