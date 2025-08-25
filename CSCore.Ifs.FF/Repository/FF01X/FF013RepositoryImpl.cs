using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._01X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF013;

namespace CSCore.Ifs.FF.Repository.FF01X
{
    public class FF013RepositoryImpl(AppDbContext appDbContext) 
        : RepositorioBaseImpl<CSICP_FF013>(appDbContext, "Id"), IFF013Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<(List<RepoDtoCSICP_FF013>, int)> GetListAsync(int in_tenant, int in_pageNumber, int in_pageSize,
            string? in_ff012Id)
        {
            IQueryable<RepoDtoCSICP_FF013> query = GetQueryBase(in_tenant);

            // Aplicar filtros
            if (!string.IsNullOrEmpty(in_ff012Id))
                query = query.Where(e => e.Ff013Grupocobrancaid == in_ff012Id);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            List<RepoDtoCSICP_FF013> result = await query.ToListAsync();
            return (result, count);
        }

        public async Task<RepoDtoCSICP_FF013?> GetByIdAsync(int in_tenant, string in_ff013Id)
        {
            IQueryable<RepoDtoCSICP_FF013> query = GetQueryBase(in_tenant);
            return await query.FirstOrDefaultAsync(e => e.Id == in_ff013Id);
        }

        private IQueryable<RepoDtoCSICP_FF013> GetQueryBase(int in_tenant)
        {
            return from ff013 in _appDbContext.OsusrE9aCsicpFf013s

                   //bb001 (Estabelecimento)
                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff013.Ff013Filialid equals bb001.Id into bb001_join
                   from bb001 in bb001_join.DefaultIfEmpty()

                   //ff012 (Grupo de Cobrança)
                   join ff012 in _appDbContext.OsusrE9aCsicpFf012s
                   on ff013.Ff013Grupocobrancaid equals ff012.Id into ff012_join
                   from ff012 in ff012_join.DefaultIfEmpty()

                   //sy001 (Cobrador)
                   join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                   on ff013.Ff013Cobradorid equals sy001.Id into sy001_join
                   from sy001 in sy001_join.DefaultIfEmpty()

                   //bb010 (Zona)
                   join bb010 in _appDbContext.OsusrE9aCsicpBb010s
                   on ff013.Ff013Zonaid equals bb010.Id into bb010_join
                   from bb010 in bb010_join.DefaultIfEmpty()

                   //bb012 (Conta) - Não utilizado no sistema. (Informação do Seu Agnaldo) - 25/08/25
                   join bb012 in _appDbContext.OsusrE9aCsicpBb012s
                   on ff013.Ff013Contaid equals bb012.Id into bb012_join
                   from bb012 in bb012_join.DefaultIfEmpty()

                   where ff013.TenantId == in_tenant

                   select new RepoDtoCSICP_FF013
                   {
                       TenantId = ff013.TenantId,
                       Id = ff013.Id,
                       Ff013Filialid = ff013.Ff013Filialid,
                       Ff013Grupocobrancaid = ff013.Ff013Grupocobrancaid,
                       Ff013Cobradorid = ff013.Ff013Cobradorid,
                       Ff013Zonaid = ff013.Ff013Zonaid,
                       Ff013Contaid = ff013.Ff013Contaid,
                       Ff013Tpregistro = ff013.Ff013Tpregistro,

                       NavBB001 = bb001 != null ? new CSICP_BB001
                       {
                           TenantId = bb001.TenantId,
                           Id = bb001.Id,
                           Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                           Bb001Razaosocial = bb001.Bb001Razaosocial,
                       } : null,

                       NavFF012 = ff012 != null ? new CSICP_FF012
                       {
                           TenantId = ff012.TenantId,
                           Id = ff012.Id,
                           Ff012CodigoGrupo = ff012.Ff012CodigoGrupo,
                           Ff012DescricaoGrupo = ff012.Ff012DescricaoGrupo,
                           Ff012Filialid = ff012.Ff012Filialid,
                           Ff012Usuariosuperid = ff012.Ff012Usuariosuperid,
                           Ff014Comissaosuperid = ff012.Ff014Comissaosuperid,
                           Ff014Comissaocobradorid = ff012.Ff014Comissaocobradorid,
                           Ff012Grupopaiid = ff012.Ff012Grupopaiid,
                       } : null,

                       NavSY001 = sy001 != null ? new Csicp_Sy001
                       {
                           TenantId = sy001.TenantId,
                           Id = sy001.Id,
                           Sy001Usuario = sy001.Sy001Usuario,
                           Sy001Nome = sy001.Sy001Nome,
                       } : null,

                       NavBB010 = bb010 != null ? new CSICP_Bb010
                       {
                           TenantId = bb010.TenantId,
                           Id = bb010.Id,
                           Bb010Codigo = bb010.Bb010Codigo,
                           Bb010Zona = bb010.Bb010Zona,
                           Bb010CodVendedor = bb010.Bb010CodVendedor,
                           Bb010ColPrecoTabela = bb010.Bb010ColPrecoTabela,
                           Bb010Banco01Id = bb010.Bb010Banco01Id,
                           Bb010Banco02Id = bb010.Bb010Banco02Id,
                           Bb010Banco03Id = bb010.Bb010Banco03Id,
                           Bb010CcustoId = bb010.Bb010CcustoId,
                           Bb010Km = bb010.Bb010Km,
                           Bb010FoneContato = bb010.Bb010FoneContato,
                           Bb010Promotor = bb010.Bb010Promotor,
                           Bb010Observacao = bb010.Bb010Observacao,
                           Bb010PeriodoRota = bb010.Bb010PeriodoRota,
                           Bb010PeriodoVisita = bb010.Bb010PeriodoVisita,
                           Bb010TabelaPreco = bb010.Bb010TabelaPreco,
                           Bb010Vendedorid = bb010.Bb010Vendedorid,
                           Bb010Isactive = bb010.Bb010Isactive,
                           Bb010Tiporotaid = bb010.Bb010Tiporotaid,
                           Bb010Cidadeid = bb010.Bb010Cidadeid,
                       } : null,

                       NavBB012 = bb012 != null ? new CSICP_BB012
                       {
                           TenantId = bb012.TenantId,
                           Id = bb012.Id,
                           Bb012Codigo = bb012.Bb012Codigo,
                           Bb012NomeCliente = bb012.Bb012NomeCliente,
                           Bb012GrupocontaId = bb012.Bb012GrupocontaId,
                       } : null
                   };
        }
    }
}