using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.CS_QueryFilters;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB035Repository(AppDbContext context) : IBB035Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb035> CreateAsync(CSICP_Bb035 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_Bb035End> CreateUpdateBB035End(CSICP_Bb035End entity, bool isUpdate = false)
        {
            if (isUpdate) _appDbContext.Update(entity);
            else _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> UpdateAsync
            (CSICP_Bb035End entityEnderecocsicp_bb035end,
            CSICP_Bb035 entidade_csicp_bb035,
             bool isUpdate = false
            )
        {
            using (var transaction = await _appDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    _appDbContext.Update(entidade_csicp_bb035);


                    if (isUpdate) _appDbContext.Update(entityEnderecocsicp_bb035end);
                    else _appDbContext.Add(entityEnderecocsicp_bb035end);

                    await _appDbContext.SaveChangesAsync();

                    await transaction.CommitAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
                }
            }
        }

        public async Task<CSICP_Bb035?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<(IEnumerable<CSICP_Bb035>, int)> GetListAsync(int tenant, string? search, bool? isActive, FiltrosTextoIsAtivo parametrosBaseFiltro)
        {
            IQueryable<CSICP_Bb035> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, isActive, q1);

            var queryCount = q1;
            int count = queryCount.Count();

            q1 = q1.PaginacaoNoBanco(parametrosBaseFiltro.PageNumber, parametrosBaseFiltro.PageSize);

            q1 = q1.OrderBy(e => e.Bb035Primeironome);

            return (await q1.ToListAsync(), count);
        }

        public async Task<CSICP_Bb035> RemoveAsync(CSICP_Bb035 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb035> UpdateAsync(CSICP_Bb035 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_Bb035> ChangeActive(CSICP_Bb035 entity)
        {
            entity.Bb035IsActive = !entity.Bb035IsActive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb035> FiltraQuandoExisteFiltros(string? search, bool? isActive, IQueryable<CSICP_Bb035> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb035Primeironome ?? "").Contains(search ?? "") ||
                    (entity.Bb035Descricao ?? "").Contains(search ?? ""));
            }


            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb035IsActive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_Bb035> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb035s
            .AsNoTracking()
            .Include(e => e.NavCSICP_BB035Trat)
            .Include(e => e.NavCSICP_BB035Origem)
            .Include(e => e.NavCSICP_BB035End)

            .Where(e => e.TenantId == tenant)
            .OrderBy(e => e.Bb035Descricao);
        }

        private async Task<CSICP_Bb035?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }


    }
}
