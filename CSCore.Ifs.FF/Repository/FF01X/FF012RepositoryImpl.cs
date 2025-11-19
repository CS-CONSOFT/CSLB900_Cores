using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._01X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF01X
{
    public class FF012RepositoryImpl(AppDbContext appDbContext) 
        : RepositorioBaseImpl<CSICP_FF012>(appDbContext, "Id"), IFF012Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<(List<CSICP_FF012>, int)> GetListAsync(int in_tenant, int in_pageNumber, int in_pageSize,
            string? in_estabId, int? in_codigoGrupo)
        {
            IQueryable<CSICP_FF012> query = GetQueryBase(in_tenant);

            // Aplicar filtros
            if (!string.IsNullOrEmpty(in_estabId))
                query = query.Where(e => e.Ff012Filialid == in_estabId);

            if (in_codigoGrupo.HasValue)
                query = query.Where(e => e.Ff012CodigoGrupo == in_codigoGrupo);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            List<CSICP_FF012> result = await query.ToListAsync();
            return (result, count);
        }

        public async Task<CSICP_FF012?> GetByIdAsync(int in_tenant, string in_ff012Id)
        {
            IQueryable<CSICP_FF012> query = GetQueryBase(in_tenant);
            return await query.FirstOrDefaultAsync(e => e.Id == in_ff012Id);
        }

        private IQueryable<CSICP_FF012> GetQueryBase(int in_tenant)
        {
            return _appDbContext.OsusrE9aCsicpFf012s
                   .AsNoTracking()
                   .Where(e => e.TenantId == in_tenant)
                   .Include(e => e.NavBB001)
                   .Include(e => e.NavSY001)
                   .Include(e => e.NavFF014ComissaoSuper)
                   .Include(e => e.NavFF014ComissaoCobrador)
                   .Include(e => e.NavFF012GrupoPai);

            /*return from ff012 in _appDbContext.OsusrE9aCsicpFf012s

                   // Join com csicp_bb001 (Estabelecimento)
                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff012.Ff012Filialid equals bb001.Id into bb001_join
                   from bb001 in bb001_join.DefaultIfEmpty()

                   // Join com csicp_sy001 (Usuário Supervisor)
                   join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                   on ff012.Ff012Usuariosuperid equals sy001.Id into sy001_join
                   from sy001 in sy001_join.DefaultIfEmpty()

                   // Join com csicp_ff014 (Comissão Supervisor)
                   join ff014Super in _appDbContext.OsusrE9aCsicpFf014s
                   on ff012.Ff014Comissaosuperid equals ff014Super.Id into ff014Super_join
                   from ff014Super in ff014Super_join.DefaultIfEmpty()

                   // Join com csicp_ff014 (Comissão Cobrador)
                   join ff014Cobrador in _appDbContext.OsusrE9aCsicpFf014s
                   on ff012.Ff014Comissaocobradorid equals ff014Cobrador.Id into ff014Cobrador_join
                   from ff014Cobrador in ff014Cobrador_join.DefaultIfEmpty()

                   // Join com csicp_ff012 (Grupo Pai)
                   join ff012Pai in _appDbContext.OsusrE9aCsicpFf012s
                   on ff012.Ff012Grupopaiid equals ff012Pai.Id into ff012Pai_join
                   from ff012Pai in ff012Pai_join.DefaultIfEmpty()

                   where ff012.TenantId == in_tenant

                   select new CSICP_FF012
                   {
                       TenantId = ff012.TenantId,
                       Id = ff012.Id,
                       Ff012Filialid = ff012.Ff012Filialid,
                       Ff012CodigoGrupo = ff012.Ff012CodigoGrupo,
                       Ff012DescricaoGrupo = ff012.Ff012DescricaoGrupo,
                       Ff012Usuariosuperid = ff012.Ff012Usuariosuperid,
                       Ff014Comissaosuperid = ff012.Ff014Comissaosuperid,
                       Ff014Comissaocobradorid = ff012.Ff014Comissaocobradorid,
                       Ff012Grupopaiid = ff012.Ff012Grupopaiid,

                       NavBB001 = bb001 != null ? new CSICP_BB001
                       {
                           TenantId = bb001.TenantId,
                           Id = bb001.Id,
                           Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                           Bb001Razaosocial = bb001.Bb001Razaosocial,
                       } : null,

                       NavSY001 = sy001 != null ? new Csicp_Sy001
                       {
                           TenantId = sy001.TenantId,
                           Id = sy001.Id,
                           Sy001Usuario = sy001.Sy001Usuario,
                           Sy001Nome = sy001.Sy001Nome,
                       } : null,

                       NavFF014ComissaoSuper = ff014Super != null ? new CSICP_FF014
                       {
                           TenantId = ff014Super.TenantId,
                           Id = ff014Super.Id,
                           Ff014Filialid = ff014Super.Ff014Filialid,
                           Ff014Handle = ff014Super.Ff014Handle,
                           Ff014Descricao = ff014Super.Ff014Descricao,
                           Ff014Comissaoid = ff014Super.Ff014Comissaoid,
                           Ff014Diasde = ff014Super.Ff014Diasde,
                           Ff014Diasate = ff014Super.Ff014Diasate,
                           Ff014Perccomissao = ff014Super.Ff014Perccomissao

                       } : null,

                       NavFF014ComissaoCobrador = ff014Cobrador != null ? new CSICP_FF014
                       {
                           TenantId = ff014Cobrador.TenantId,
                           Id = ff014Cobrador.Id,
                           Ff014Filialid = ff014Cobrador.Ff014Filialid,
                           Ff014Handle = ff014Cobrador.Ff014Handle,
                           Ff014Descricao = ff014Cobrador.Ff014Descricao,
                           Ff014Comissaoid = ff014Cobrador.Ff014Comissaoid,
                           Ff014Diasde = ff014Cobrador.Ff014Diasde,
                           Ff014Diasate = ff014Cobrador.Ff014Diasate,
                           Ff014Perccomissao = ff014Cobrador.Ff014Perccomissao
                       } : null,

                       NavFF012GrupoPai = ff012Pai != null ? new CSICP_FF012
                       {
                           TenantId = ff012Pai.TenantId,
                           Id = ff012Pai.Id,
                           Ff012Filialid = ff012Pai.Ff012Filialid,
                           Ff012CodigoGrupo = ff012Pai.Ff012CodigoGrupo,
                           Ff012DescricaoGrupo = ff012Pai.Ff012DescricaoGrupo,
                           Ff012Usuariosuperid = ff012Pai.Ff012Usuariosuperid,
                           Ff014Comissaosuperid = ff012Pai.Ff014Comissaosuperid,
                           Ff014Comissaocobradorid = ff012Pai.Ff014Comissaocobradorid,
                           Ff012Grupopaiid = ff012Pai.Ff012Grupopaiid,
                       } : null
                   };*/
        }
    }
}