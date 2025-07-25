using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
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

namespace CSCore.Ifs.FF.Repository
{
    public class FF002RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseImpl<CSICP_FF002>(appDbContext, "Id"), IFF002Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<RepoCSICP_FF002?> GetByIdAsync(int tenant, string id)
        {
            IQueryable<RepoCSICP_FF002> query = GetQueryBase(tenant);
            RepoCSICP_FF002? cSICP_FF002 = await query.FirstOrDefaultAsync(e => e.Id == id);
            return cSICP_FF002;
        }

        public async Task<(IEnumerable<RepoCSICP_FF002>, int)> GetListAsync(int tenant, int page, int pageSize,
            string? motivo, int? tipoRegistro)
        {
            IQueryable<RepoCSICP_FF002> query = GetQueryBase(tenant);
            query = FiltraQuandoExisteFiltro(motivo, tipoRegistro, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private static IQueryable<RepoCSICP_FF002> FiltraQuandoExisteFiltro(string? motivo, int? tipoRegistro, 
            IQueryable<RepoCSICP_FF002> query)

        {
            if (motivo != null)
                query = query.Where(e => e.Ff002Motivo!.Equals(motivo));
            if (tipoRegistro != null)
                query = query.Where(e => e.Ff002Tiporegistro!.Equals(tipoRegistro));
            return query;
        }

        private IQueryable<RepoCSICP_FF002> GetQueryBase(int tenant)
        {
            return from ff002 in _appDbContext.OsusrE9aCsicpFf002s

                   join ff002_Mod in _appDbContext.OsusrE9aCsicpF002Mod
                   on ff002.Ff002Tiporegistro equals ff002_Mod.Id into ff002_ff002Mod_join
                   from ff002_Mod in ff002_ff002Mod_join.DefaultIfEmpty()

                   where ff002.TenantId == tenant

                   select new RepoCSICP_FF002
                   {
                       TenantId = ff002.TenantId,
                       Id = ff002.Id,
                       Ff002Codigo = ff002.Ff002Codigo,
                       Ff002Motivo = ff002.Ff002Motivo,
                       Ff002Tiporegistro = ff002.Ff002Tiporegistro,
                       Ff002Peso = ff002.Ff002Peso,

                       NavFF002_Mod = ff002_Mod != null ? new OsusrE9aCsicpFf002Mod
                       { 
                           Id = ff002_Mod.Id,
                           Label = ff002_Mod.Label,
                           Order = ff002_Mod.Order,
                           IsActive = ff002_Mod.IsActive,
                       } : null
                   };
        }
    }
}
