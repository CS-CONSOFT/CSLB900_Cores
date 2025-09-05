using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.FF._01X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF017;

namespace CSCore.Ifs.FF.Repository.FF01X
{
    public class FF017RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF017>(appDbContext, "Id"), IFF017Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<RepoDtoCSICP_FF017?> GetByIdAsync(int in_tenant, string in_ff017Id)
        {
            IQueryable<RepoDtoCSICP_FF017> query = GetQueryBase(in_tenant);
            RepoDtoCSICP_FF017? cSICP_FF017 = await query.AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync(e => e.Id == in_ff017Id);
            return cSICP_FF017;
        }

        private IQueryable<RepoDtoCSICP_FF017> GetQueryBase(int in_tenant)
        {
            return from ff017 in _appDbContext.OsusrE9aCsicpFf017s
                   .AsNoTracking()

                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff017.Ff017Filialid equals bb001.Id into bb001_ff017_join
                   from bb001 in bb001_ff017_join.DefaultIfEmpty()

                   join bb005 in _appDbContext.OsusrE9aCsicpBb005s
                   on ff017.Ff017Ccustoid equals bb005.Id into bb005_ff017_join
                   from bb005 in bb005_ff017_join.DefaultIfEmpty()

                   join bb006 in _appDbContext.OsusrE9aCsicpBb006s
                   on ff017.Ff017Agcobradorid equals bb006.Id into bb006_ff017_join
                   from bb006 in bb006_ff017_join.DefaultIfEmpty()

                   join bb008 in _appDbContext.OsusrE9aCsicpBb008s
                   on ff017.Ff017Condicaoid equals bb008.Id into bb008_ff017_join
                   from bb008 in bb008_ff017_join.DefaultIfEmpty()

                   join bb009 in _appDbContext.OsusrE9aCsicpBb009s
                   on ff017.Ff017Tipocobrancaid equals bb009.Id into bb009_ff017_join
                   from bb009 in bb009_ff017_join.DefaultIfEmpty()

                   join bb012 in _appDbContext.OsusrE9aCsicpBb012s
                   on ff017.Ff017Contaid equals bb012.Id into bb012_ff017_join
                   from bb012 in bb012_ff017_join.DefaultIfEmpty()

                   join bb026 in _appDbContext.OsusrE9aCsicpBb026s
                   on ff017.Ff017Formapagtoid equals bb026.Id into bb026_ff017_join
                   from bb026 in bb026_ff017_join.DefaultIfEmpty()

                   join dd125 in _appDbContext.OsusrTeiCsicpDd125s
                   on ff017.Ff017Valecreditoid equals dd125.Dd125CartacredId into dd125_ff017_join
                   from dd125 in dd125_ff017_join.DefaultIfEmpty()

                   join ff003 in _appDbContext.OsusrE9aCsicpFf003s
                   on ff017.Ff017Especieid equals ff003.Id into ff003_ff017_join
                   from ff003 in ff003_ff017_join.DefaultIfEmpty()

                   join ff107vc in _appDbContext.OsusrE9aCsicpFf107Vcs
                   on ff017.Ff017Statusvcid equals ff107vc.Id into ff107vc_ff017_join
                   from ff107vc in ff107vc_ff017_join.DefaultIfEmpty()

                   join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                   on ff017.Ff017Usuarioid equals sy001.Id into sy001_ff017_join
                   from sy001 in sy001_ff017_join.DefaultIfEmpty()

                   where ff017.TenantId == in_tenant
                   select new RepoDtoCSICP_FF017
                   {
                       TenantId = ff017.TenantId,
                       Id = ff017.Id,
                       Ff017Tiporegistro = ff017.Ff017Tiporegistro,
                       Ff017Filialid = ff017.Ff017Filialid,
                       Ff017Filial = ff017.Ff017Filial,
                       Ff017DataRenegociacao = ff017.Ff017DataRenegociacao,
                       Ff017Especieid = ff017.Ff017Especieid,
                       Ff017Contaid = ff017.Ff017Contaid,
                       Ff017Ccustoid = ff017.Ff017Ccustoid,
                       Ff017Agcobradorid = ff017.Ff017Agcobradorid,
                       Ff017Usuarioid = ff017.Ff017Usuarioid,
                       Ff017Condicaoid = ff017.Ff017Condicaoid,
                       Ff017Tipocobrancaid = ff017.Ff017Tipocobrancaid,
                       Ff017Contatomadordivid = ff017.Ff017Contatomadordivid,
                       Ff017PercJuros = ff017.Ff017PercJuros,
                       Ff017Multa = ff017.Ff017Multa,
                       Ff017TotalTitulos = ff017.Ff017TotalTitulos,
                       Ff017TotalAberto = ff017.Ff017TotalAberto,
                       Ff017TotalJuros = ff017.Ff017TotalJuros,
                       Ff017TotalMulta = ff017.Ff017TotalMulta,
                       Ff017TotalDescontos = ff017.Ff017TotalDescontos,
                       Ff017Totrenegociado = ff017.Ff017Totrenegociado,
                       Ff017ValorEntrada = ff017.Ff017ValorEntrada,
                       Ff017PercEntrada = ff017.Ff017PercEntrada,
                       Ff017Aberto = ff017.Ff017Aberto,
                       Ff017Protocolnumber = ff017.Ff017Protocolnumber,
                       Ff017Pminvlrentrada = ff017.Ff017Pminvlrentrada,
                       Ff017Vminentrada = ff017.Ff017Vminentrada,
                       Ff017Valecreditoid = ff017.Ff017Valecreditoid,
                       Ff017Statusvcid = ff017.Ff017Statusvcid,
                       Ff017Formapagtoid = ff017.Ff017Formapagtoid,

                       NavBB001 = bb001 != null ? new CSICP_BB001
                       {
                           TenantId = bb001.TenantId,
                           Id = bb001.Id,
                           Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                           Bb001Razaosocial = bb001.Bb001Razaosocial,
                       } : null,

                       NavBB005 = bb005 != null ? new CSICP_Bb005
                       {
                           TenantId = bb005.TenantId,
                           Id = bb005.Id,
                           Bb005Codigo = bb005.Bb005Codigo,
                           Bb005Nomeccusto = bb005.Bb005Nomeccusto,
                       } : null,

                       NavBB006 = bb006 != null ? new CSICP_Bb006
                       {
                           TenantId = bb006.TenantId,
                           Id = bb006.Id,
                           Bb006Codgbanco = bb006.Bb006Codgbanco,
                           Bb006Banco = bb006.Bb006Banco
                       } : null,

                       NavBB008 = bb008 != null ? new CSICP_Bb008
                       {
                           TenantId = bb008.TenantId,
                           Id = bb008.Id,
                           Bb008Codigo = bb008.Bb008Codigo,
                           Bb008Condicao = bb008.Bb008Condicao,
                       } : null,

                       NavBB009 = bb009 != null ? new CSICP_Bb009
                       {
                           TenantId = bb009.TenantId,
                           Id = bb009.Id,
                           Bb009Codigo = bb009.Bb009Codigo,
                           Bb009Tipocobranca = bb009.Bb009Tipocobranca,
                       } : null,

                       NavBB012 = bb012 != null ? new CSICP_BB012
                       {
                           TenantId = bb012.TenantId,
                           Id = bb012.Id,
                           Bb012Codigo = bb012.Bb012Codigo,
                           Bb012NomeCliente = bb012.Bb012NomeCliente,
                       } : null,

                       NavBB026 = bb026 != null ? new CSICP_Bb026
                       {
                           TenantId = bb026.TenantId,
                           Id = bb026.Id,
                           Bb026Codigo = bb026.Bb026Codigo,
                           Bb026Formapagamento = bb026.Bb026Formapagamento,
                       } : null,

                       NavDD125 = dd125 != null ? new CSICP_DD125
                       {
                           TenantId = dd125.TenantId,
                           Dd125CartacredId = dd125.Dd125CartacredId,
                           Dd125FilialId = dd125.Dd125FilialId,
                           Dd120TrocaId = dd125.Dd120TrocaId,
                           Dd125ContaId = dd125.Dd125ContaId,
                           Dd125DataMovto = dd125.Dd125DataMovto,
                           Dd125Vcarta = dd125.Dd125Vcarta,
                           Dd125VsaldoCarta = dd125.Dd125VsaldoCarta,
                           Dd125UsuariopropId = dd125.Dd125UsuariopropId,
                           Dd125StatusId = dd125.Dd125StatusId,
                           Dd125Email = dd125.Dd125Email,
                           Dd125Sms = dd125.Dd125Sms,
                           Dd125Protocolnumber = dd125.Dd125Protocolnumber,
                           Dd125Islock = dd125.Dd125Islock,
                           Dd125Tiporegid = dd125.Dd125Tiporegid
                       } : null,

                       NavFF003 = ff003 != null ? new CSICP_FF003
                       {
                           TenantId = ff003.TenantId,
                           Id = ff003.Id,
                           Ff003Codigo = ff003.Ff003Codigo,
                           Ff003Descricao = ff003.Ff003Descricao
                       } : null,

                       NavSY001 = sy001 != null ? new Csicp_Sy001
                       {
                           TenantId = sy001.TenantId,
                           Id = sy001.Id,
                           Sy001Usuario = sy001.Sy001Usuario,
                           Sy001Nome = sy001.Sy001Nome
                       } : null,

                       NavFF107vc = ff107vc != null ? new OsusrE9aCsicpFf107Vc
                       {
                           Id = ff107vc.Id,
                           Label = ff107vc.Label,
                           Order = ff107vc.Order,
                           IsActive = ff107vc.IsActive,
                           CodgCs = ff107vc.CodgCs
                       } : null
                   };
        }

        public async Task<(List<RepoDtoCSICP_FF017>, int)> GetListAsync(int in_tenant, string in_estabId, DateTime? in_dataInicial, DateTime? in_dataFinal, int in_page, int in_pageSize)
        {
            IQueryable<RepoDtoCSICP_FF017> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_estabId, in_dataInicial, in_dataFinal, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_page, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<RepoDtoCSICP_FF017> FiltraQuandoExisteFiltro(string in_estabId, DateTime? in_dataInicial, DateTime? in_dataFinal, IQueryable<RepoDtoCSICP_FF017> query)
        {
            if (in_estabId != null)
                query = query.Where(e => e.Id!.Equals(in_estabId));

            if (in_dataInicial != null)
                query = query.Where(e => e.Ff017DataRenegociacao >= in_dataInicial);
            if (in_dataFinal != null)
                query = query.Where(e => e.Ff017DataRenegociacao <= in_dataFinal);
            //tem outros filtros? Perguntar ao Agnaldo.
            return query;
        }
    }
}
