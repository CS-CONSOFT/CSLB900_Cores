using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF119;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF119RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF119>(appDbContext, "Ff119Id"), IFF119Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<RepoDtoCSICP_FF119?> GetByIdAsync(int in_tenant, long in_ff119Id)
        {
            IQueryable<RepoDtoCSICP_FF119> query = GetQueryBase(in_tenant);
            RepoDtoCSICP_FF119? cSICP_FF119 = await query.FirstOrDefaultAsync(e => e.Ff119Id == in_ff119Id);
            return cSICP_FF119;
        }

        public async Task<(List<RepoDtoCSICP_FF119>, int)> GetListAsync(int in_tenant, string in_ff112Id, int in_page, int in_pageSize)
        {
            IQueryable<RepoDtoCSICP_FF119> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_ff112Id, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_page, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<RepoDtoCSICP_FF119> FiltraQuandoExisteFiltro(string in_ff112Id, IQueryable<RepoDtoCSICP_FF119> query)
        {
            if (in_ff112Id != null)
                query = query.Where(e => e.Ff112Id == in_ff112Id);

            return query;
        }

        private IQueryable<RepoDtoCSICP_FF119> GetQueryBase(int in_tenant)
        {
            return from ff119 in _appDbContext.OsusrE9aCsicpFf119s
                   .AsNoTracking()
                   
                   join ff112Reg in _appDbContext.OsusrE9aCsicpFf112Regs
                   on ff119.Ff119Regid equals ff112Reg.Id into ff112Reg_join
                   from ff112Reg in ff112Reg_join.DefaultIfEmpty()

                   where ff119.TenantId == in_tenant

                   select new RepoDtoCSICP_FF119
                   {
                       Ff119Id = ff119.Ff119Id,
                       TenantId = ff119.TenantId,
                       Ff112Id = ff119.Ff112Id,
                       Ff119Regid = ff119.Ff119Regid,
                       Ff119Posicaode = ff119.Ff119Posicaode,
                       Ff119Posicaoate = ff119.Ff119Posicaoate,
                       Ff119Conteudo = ff119.Ff119Conteudo,
                       Ff119Descricao = ff119.Ff119Descricao,

                       NavFF112Reg = ff112Reg != null ? new OsusrE9aCsicpFf112Reg
                       {
                           Id = ff112Reg.Id,
                           Label = ff112Reg.Label,
                           Order = ff112Reg.Order,
                           IsActive = ff112Reg.IsActive,
                           TipoRegistro = ff112Reg.TipoRegistro,
                       } : null
                   };
        }
    }
}