using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB001Repository(AppDbContext context) : IBB001Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_BB001> CreateAsync(CSICP_BB001 entity)
        {
            ValidaCpfCnpj(entity);
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

 

        public async Task<CSICP_BB001?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_BB001>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive)
        {
            IQueryable<CSICP_BB001> q1 = CreateBaseQuery(tenant).AsQueryable();
            q1 = FiltraQuandoExisteFiltros(search, searchCode, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_BB001> RemoveAsync(CSICP_BB001 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB001> UpdateAsync(CSICP_BB001 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB001> ChangeActive(CSICP_BB001 entity)
        {
            entity.Bb001Isactive = !entity.Bb001Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_BB001> FiltraQuandoExisteFiltros(string? search, int? searchCode, bool? isActive, IQueryable<CSICP_BB001> query)
        {
            if (search != null)
            {
                query = query
                   .Where(bb001 => (bb001.Bb001Nomefantasia ?? "").Contains(search ?? "") ||
                          (bb001.Bb001Razaosocial ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                    .Where(bb001 => bb001.Bb001Codigoempresa.ToString()!.Equals(searchCode.ToString() ?? ""));
            }

            if (isActive != null)
            {
                query = query
                    .Where(bb001 => bb001.Bb001Isactive == isActive);
            }

            return query;
        }



        private IQueryable<CSICP_BB001> CreateBaseQuery(int tenant)
        {
            return _appDbContext.E9ACSICP_BB001s
                .AsSplitQuery()
                .AsNoTracking()
                .Include(d => d.Bb001RamoempresaNavigation)
                .Include(d => d.Bb001Pais)
                .Include(d => d.Bb001Uf)
                .Include(d => d.Cidade)
                .Where(e => e.TenantId == tenant)
                .OrderBy(e => e.Bb001Descricaooficial);
        }

        private async Task<CSICP_BB001?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        private static void ValidaCpfCnpj(CSICP_BB001 entity)
        {

            if (entity.Bb001Cnpj != null && entity.Bb001Cnpj != "0" && entity.Bb001Cnpj != "")
            {
                bool valido = ValidaCnpj.CnpjValido(entity.Bb001Cnpj);
                if (valido == false) throw new Exception("O CNPJ informado é inválido.");
            }
        }
    }
}
