using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF107;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF107RepositoryImpl(AppDbContext appDbContext) 
        : RepositorioBaseImpl<CSICP_FF107>(appDbContext, "Id"), IFF107Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<(List<RepoDtoCSICP_FF107>, int)> GetListAsync(int in_tenant, int in_pageNumber, int in_pageSize,
            string? in_ff102Id)
        {
            IQueryable<RepoDtoCSICP_FF107> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_ff102Id, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            List<RepoDtoCSICP_FF107> result = await query.ToListAsync();
            return (result, count);
        }

        private IQueryable<RepoDtoCSICP_FF107> FiltraQuandoExisteFiltro(
            string? in_ff102Id, IQueryable<RepoDtoCSICP_FF107> query)
        {
            if (!string.IsNullOrEmpty(in_ff102Id))
                query = query.Where(e => e.Ff102Tituloid == in_ff102Id);

            return query;
        }

        private IQueryable<RepoDtoCSICP_FF107> GetQueryBase(int in_tenant)
        {
            return from ff107 in _appDbContext.OsusrE9aCsicpFf107s
                   .AsNoTracking()

                   //bb001 (Estabelecimento)
                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff107.Ff107Filialid equals bb001.Id into bb001_join
                   from bb001 in bb001_join.DefaultIfEmpty()

                   //ff102 (Título)
                   join ff102 in _appDbContext.OsusrE9aCsicpFf102s
                   on ff107.Ff102Tituloid equals ff102.Id into ff102_join
                   from ff102 in ff102_join.DefaultIfEmpty()

                   //sy001 (Usuário)
                   join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                   on ff107.Ff107Usuarioproprid equals sy001.Id into sy001_join
                   from sy001 in sy001_join.DefaultIfEmpty()

                   //ff002 (Motivo)
                   join ff002 in _appDbContext.OsusrE9aCsicpFf002s
                   on ff107.Ff107Motivoid equals ff002.Id into ff002_join
                   from ff002 in ff002_join.DefaultIfEmpty()

                   where ff107.TenantId == in_tenant

                   select new RepoDtoCSICP_FF107
                   {
                       TenantId = ff107.TenantId,
                       Id = ff107.Id,
                       Ff107Tpregistro = ff107.Ff107Tpregistro,
                       Ff107Filialid = ff107.Ff107Filialid,
                       Ff107Filial = ff107.Ff107Filial,
                       Ff102Tituloid = ff107.Ff102Tituloid,
                       Ff107Pfx = ff107.Ff107Pfx,
                       Ff107Titulo = ff107.Ff107Titulo,
                       Ff107Sfx = ff107.Ff107Sfx,
                       Ff107Codgcliforn = ff107.Ff107Codgcliforn,
                       Ff107Tipolctocontabil = ff107.Ff107Tipolctocontabil,
                       Ff107Tipomovto = ff107.Ff107Tipomovto,
                       Ff107Datamovto = ff107.Ff107Datamovto,
                       Ff107Usuarioproprid = ff107.Ff107Usuarioproprid,
                       Ff107Responsavel = ff107.Ff107Responsavel,
                       Ff107Motivoid = ff107.Ff107Motivoid,
                       Ff107Codgmotivo = ff107.Ff107Codgmotivo,
                       Ff107Descmotivo = ff107.Ff107Descmotivo,
                       Ff107Valor = ff107.Ff107Valor,
                       Ff107Observacao = ff107.Ff107Observacao,
                       Ff107Protocolnumber = ff107.Ff107Protocolnumber,

                       NavBB001 = bb001 != null ? new CSICP_BB001
                       {
                           TenantId = bb001.TenantId,
                           Id = bb001.Id,
                           Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                           Bb001Razaosocial = bb001.Bb001Razaosocial,
                       } : null,

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
                           Ff102DataEmissao = ff102.Ff102DataEmissao,
                           Ff102DataVencimento = ff102.Ff102DataVencimento,
                           Ff102ValorTitulo = ff102.Ff102ValorTitulo,
                           Ff102Situacao = ff102.Ff102Situacao,
                           Ff102Situacaoid = ff102.Ff102Situacaoid,
                       } : null,

                       NavSY001 = sy001 != null ? new Csicp_Sy001
                       {
                           TenantId = sy001.TenantId,
                           Id = sy001.Id,
                           Sy001Usuario = sy001.Sy001Usuario,
                           Sy001Nome = sy001.Sy001Nome,
                       } : null,

                       NavFF002 = ff002 != null ? new CSICP_FF002
                       {
                           TenantId = ff002.TenantId,
                           Id = ff002.Id,
                           Ff002Tiporegistro = ff002.Ff002Tiporegistro,
                           Ff002Codigo = ff002.Ff002Codigo,
                           Ff002Motivo = ff002.Ff002Motivo,
                       } : null
                   };
        }
    }
}