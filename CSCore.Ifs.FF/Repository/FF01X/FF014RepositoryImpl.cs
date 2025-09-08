using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._01X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF014;

namespace CSCore.Ifs.FF.Repository.FF01X
{
    public class FF014RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF014>(appDbContext, "Id"), IFF014Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<RepoDtoCSICP_FF014?> GetByIdAsync(int in_tenantID, string in_ff014ID)
        {
            IQueryable<RepoDtoCSICP_FF014> query = GetQueryBase(in_tenantID);
            RepoDtoCSICP_FF014? CSICP_FF014 = await query.FirstOrDefaultAsync(e => e.Id == in_ff014ID);
            return CSICP_FF014;
        }

        public async Task<(List<RepoDtoCSICP_FF014>, int)> GetListAsync(int in_tenantID, int in_pageNumber, int in_pageSize, 
            string? in_filialID, string? in_descricao, string? in_comissaoID)
        {
            IQueryable<RepoDtoCSICP_FF014> query = GetQueryBase(in_tenantID);
            query = FiltraQuandoExisteFiltro(in_filialID, in_descricao, in_comissaoID, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<RepoDtoCSICP_FF014> FiltraQuandoExisteFiltro(string? in_filialID, string? in_descricao, 
            string? in_comissaoID, IQueryable<RepoDtoCSICP_FF014> query)
        {
            if (!string.IsNullOrEmpty(in_filialID))
                query = query.Where(e => e.Ff014Filialid == in_filialID);

            if (!string.IsNullOrEmpty(in_descricao))
                query = query.Where(e => e.Ff014Descricao != null && e.Ff014Descricao.Contains(in_descricao));

            if (!string.IsNullOrEmpty(in_comissaoID))
                query = query.Where(e => e.Ff014Comissaoid == in_comissaoID);

            return query;
        }

        private IQueryable<RepoDtoCSICP_FF014> GetQueryBase(int in_tenantID)
        {
            return from ff014 in _appDbContext.OsusrE9aCsicpFf014s
                   .AsNoTracking()
                   
                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff014.Ff014Filialid equals bb001.Id into bb001_join
                   from bb001 in bb001_join.DefaultIfEmpty()

                   join ff014Pai in _appDbContext.OsusrE9aCsicpFf014s
                   on ff014.Ff014Comissaoid equals ff014Pai.Id into ff014Pai_join
                   from ff014Pai in ff014Pai_join.DefaultIfEmpty()

                   where ff014.TenantId == in_tenantID
                   select new RepoDtoCSICP_FF014
                   {
                       TenantId = ff014.TenantId,
                       Id = ff014.Id,
                       Ff014Filialid = ff014.Ff014Filialid,
                       Ff014Handle = ff014.Ff014Handle,
                       Ff014Descricao = ff014.Ff014Descricao,
                       Ff014Comissaoid = ff014.Ff014Comissaoid,
                       Ff014Diasde = ff014.Ff014Diasde,
                       Ff014Diasate = ff014.Ff014Diasate,
                       Ff014Perccomissao = ff014.Ff014Perccomissao,

                       NavBB001 = bb001 != null ? new CSICP_BB001
                       {
                           TenantId = bb001.TenantId,
                           Id = bb001.Id,
                           Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                           Bb001Razaosocial = bb001.Bb001Razaosocial,
                           Bb001Nomefantasia = bb001.Bb001Nomefantasia,
                           Bb001Cnpj = bb001.Bb001Cnpj
                       } : null,

                       NavFF014ComissaoPai = ff014Pai != null ? new CSICP_FF014
                       {
                           TenantId = ff014Pai.TenantId,
                           Id = ff014Pai.Id,
                           Ff014Filialid = ff014Pai.Ff014Filialid,
                           Ff014Handle = ff014Pai.Ff014Handle,
                           Ff014Descricao = ff014Pai.Ff014Descricao,
                           Ff014Comissaoid = ff014Pai.Ff014Comissaoid,
                           Ff014Diasde = ff014Pai.Ff014Diasde,
                           Ff014Diasate = ff014Pai.Ff014Diasate,
                           Ff014Perccomissao = ff014Pai.Ff014Perccomissao
                       } : null
                   };
        }
    }
}