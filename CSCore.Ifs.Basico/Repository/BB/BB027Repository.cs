using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB027Repository(AppDbContext context) : IBB027Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb027> CreateAsync(CSICP_Bb027 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb027?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb027>> GetListAsync(int tenant, string? search, int? searchCode, int? regimeId)
        {
            IQueryable<CSICP_Bb027> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, q1, regimeId);

            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb027> RemoveAsync(CSICP_Bb027 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb027> UpdateAsync(CSICP_Bb027 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_Bb027> FiltraQuandoExisteFiltros(string? search, int? searchCode, IQueryable<CSICP_Bb027> query, int? regimeId)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb027Descricao ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                   .Where(entity => (entity.Bb027Codigo.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }

            if (regimeId != null)
            {
                query = query.Where(entity => entity.Bb027RegimeId == regimeId);
            }

            return query;
        }


        private IQueryable<CSICP_Bb027> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb027s
                .AsSplitQuery()
                .AsNoTracking()
                 .Include(e => e.NavBB027BaixaEstoque)
                 .Include(e => e.NavBB027GeraCReceber)
                 .Include(e => e.NavBB027AtualizaPrCompra)
                 .Include(e => e.NavBB027CalcSubstituicao)
                 .Include(e => e.NavBB027CalculaISS)
                 .Include(e => e.NavBB027AgregaSubsTrib)
                 .Include(e => e.NavBB027ICST)
                 .Include(e => e.NavBB027IRRF)
                 .Include(e => e.NavBB027PIS)
                 .Include(e => e.NavBB027COFINS)
                 .Include(e => e.NavBB027IRPJ)
                 .Include(e => e.NavBB027ICMSDiferido)
                 .Include(e => e.NavBB027GeraEstatistica)
                 .Include(e => e.NavBB027CalcAjusteICMS)
                 //.Include(e => e.NavBB027CalcIS)
                 .Include(e => e.NavBB027Entsai)
                 .Include(e => e.NavBB027CalcICMS)
                 .Include(e => e.NavBB027CalcIPI)
                 .Include(e => e.NavBB027SomaIPIBaseICMS)
                 .Include(e => e.NavBB027IPIBruto)
                 .Include(e => e.NavBB027BaseICMSBrutaLiq)
                 .Include(e => e.NavBB027BaseSubsBrutaLiq)
                 .Include(e => e.NavBB027CFOPStatica)
                 .Include(e => e.NavBB027CFOPForaEstado)
                 .Include(e => e.NavBB027CodgAjusteICMS)
                 .Include(e => e.NavBB027Tdevolucao)
                 .Include(e => e.NavAA030_BB027Regime)
            .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Bb027?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
