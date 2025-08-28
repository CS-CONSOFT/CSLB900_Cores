using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF116RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF116>(appDbContext, "Id"), IFF116Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<(List<RepoDtoCSICP_FF116>, int)> GetListAsync(
            int in_tenant, string in_ff102Id, int in_pageNumber, int in_pageSize)
        {
            IQueryable<RepoDtoCSICP_FF116> query = GetQueryBase(in_tenant, in_ff102Id);
            
            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<RepoDtoCSICP_FF116> GetQueryBase(int in_tenant, string in_ff102Id)
        {
            return from ff116 in _appDbContext.OsusrE9aCsicpFf116s
                   .AsNoTracking()

                   join ff116TMov in _appDbContext.OsusrE9aCsicpFf116Tmovs
                   on ff116.Ff116Tipomovto equals ff116TMov.Id into ff116TMov_join
                   from ff116TMov in ff116TMov_join.DefaultIfEmpty()

                   join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                   on ff116.Ff116Usuariopropid equals sy001.Id into sy001_join
                   from sy001 in sy001_join.DefaultIfEmpty()

                   join ff102 in _appDbContext.OsusrE9aCsicpFf102s
                   on ff116.Ff102Tituloid equals ff102.Id into ff102_join
                   from ff102 in ff102_join.DefaultIfEmpty()

                   where ff116.TenantId == in_tenant
                         && ff116.Ff102Tituloid == in_ff102Id  //verificar essa sugestão da IA com o Agnaldo e Valter


                   select new RepoDtoCSICP_FF116
                   {
                       TenantId = ff116.TenantId,
                       Id = ff116.Id,
                       Ff116Tipomovto = ff116.Ff116Tipomovto,
                       Ff116Filialid = ff116.Ff116Filialid,
                       Ff116Datamovto = ff116.Ff116Datamovto,
                       Ff116Usuariopropid = ff116.Ff116Usuariopropid,
                       Ff102Tituloid = ff116.Ff102Tituloid,
                       Ff116Datavencto = ff116.Ff116Datavencto,
                       Ff116Novovencto = ff116.Ff116Novovencto,
                       Ff116Protocolnumber = ff116.Ff116Protocolnumber,
                       Ff116Vnovovlr = ff116.Ff116Vnovovlr,
                       Ff116Vvaloranterior = ff116.Ff116Vvaloranterior,
                       Ff116Msg = ff116.Ff116Msg,

                       // Navegação para FF116_TMov
                       NavFF116TMov = ff116TMov != null ? new OsusrE9aCsicpFf116Tmov
                       {
                           Id = ff116TMov.Id,
                           Label = ff116TMov.Label,
                           Order = ff116TMov.Order,
                           IsActive = ff116TMov.IsActive
                       } : null,

                       // Navegação para SY001 (usuário)
                       NavSY001 = sy001 != null ? new Csicp_Sy001
                       {
                           TenantId = sy001.TenantId,
                           Id = sy001.Id,
                           Sy001Usuario = sy001.Sy001Usuario,
                           Sy001Nome = sy001.Sy001Nome
                       } : null,

                       // Navegação para FF102 (título)
                       NavFF102 = ff102 != null ? new CSICP_FF102
                       {
                           TenantId = ff102.TenantId,
                           Id = ff102.Id,
                           Ff102Tiporegistro = ff102.Ff102Tiporegistro,
                           Ff102Filialid = ff102.Ff102Filialid,
                           Ff102Pfx = ff102.Ff102Pfx,
                           Ff102NoTitulo = ff102.Ff102NoTitulo,
                           Ff102Sfx = ff102.Ff102Sfx,
                           Ff102Contaid = ff102.Ff102Contaid,
                           Ff102Contarealid = ff102.Ff102Contarealid,
                       } : null
                   };
        }
    }
}