using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF007;

namespace CSCore.Ifs.FF.Repository
{
    public class FF007RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF007>(appDbContext, "Ff007Id"), IFF007Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<RepoDtoCSICP_FF007?> GetByIdAsync(int tenant, long id)
        {
            IQueryable<RepoDtoCSICP_FF007> query = GetQueryBase(tenant);
            RepoDtoCSICP_FF007? cSICP_FF007 = await query.FirstOrDefaultAsync(e => e.Ff007Id == id);
            return cSICP_FF007;
        }

        public async Task<(List<RepoDtoCSICP_FF007>, int)> GetListAsync(int tenant, string? estabelecimentoId, int page, int pageSize)
        {
            IQueryable<RepoDtoCSICP_FF007> query = GetQueryBase(tenant);
            query = FiltraQuandoExisteFiltro(estabelecimentoId, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(page, pageSize);
            return (await query.ToListAsync(), count);
        }

        private static IQueryable<RepoDtoCSICP_FF007> FiltraQuandoExisteFiltro(string? estabelecimentoId, IQueryable<RepoDtoCSICP_FF007> query)
        {
            if (estabelecimentoId != null)
                query = query.Where(e => e.Ff007Estabid!.Equals(estabelecimentoId));
            return query;
        }

        private IQueryable<RepoDtoCSICP_FF007> GetQueryBase(int tenant)
        {
            return from ff007 in _appDbContext.OsusrE9aCsicpFf007s

                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff007.Ff007Estabid equals bb001.Id into bb001Join
                   from bb001 in bb001Join.DefaultIfEmpty()

                   where ff007.TenantId == tenant

                   select new RepoDtoCSICP_FF007
                   {
                       TenantId = ff007.TenantId,
                       Ff007Id = ff007.Ff007Id,
                       Ff007Estabid = ff007.Ff007Estabid,
                       Ff007Diasate = ff007.Ff007Diasate,
                       Ff007Pdesconto = ff007.Ff007Pdesconto,

                       NavBB001 = bb001 != null ? new CSICP_BB001
                       {
                           TenantId = bb001.TenantId,
                           Id = bb001.Id,
                           Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                           Bb001Razaosocial = bb001.Bb001Razaosocial,
                       } : null,
                   };
        }
    }
}
















