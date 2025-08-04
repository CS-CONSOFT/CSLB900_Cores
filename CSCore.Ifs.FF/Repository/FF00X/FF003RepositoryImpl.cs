using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF00X
{
    public class FF003RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseImpl<CSICP_FF003>(appDbContext, "Id"), IFF003Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_FF003?> GetByIdAsync(int tenant, string id)
        {
            IQueryable<CSICP_FF003> query = GetQueryBase(tenant);
            CSICP_FF003? cSICP_FF003 = await query.FirstOrDefaultAsync(e => e.Id == id);
            return cSICP_FF003;
        }
        public async Task<(IEnumerable<CSICP_FF003>, int)> GetListAsync(int tenant, int page, int pageSize, 
            string? descricao, int? tipoEspecie)
        {
            IQueryable<CSICP_FF003> query = GetQueryBase(tenant);
            query = FiltraQuandoExisteFiltro(descricao, tipoEspecie, query);

            query = query.OrderBy(e => e.Ff003Descresumida);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private static IQueryable<CSICP_FF003> FiltraQuandoExisteFiltro(string? descricao, 
            int? tipoEspecie, IQueryable<CSICP_FF003> query)
        {
            if (descricao != null)
                query = query.Where(e => e.Ff003Descricao!.Equals(descricao));
            if (tipoEspecie != null)
                query = query.Where(e => e.NavFF003TpEsp != null && e.NavFF003TpEsp.Id!.Equals(tipoEspecie));

            return query;
        }

        private IQueryable<CSICP_FF003> GetQueryBase(int tenant)
        {
            return from ff003 in _appDbContext.OsusrE9aCsicpFf003s

                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff003.Ff003Filialid equals bb001.Id into bb001_ff003_join
                   from bb001 in bb001_ff003_join.DefaultIfEmpty()

                   join ff003TpEsp in _appDbContext.OsusrE9aCsicpFf003Tpesps
                   on ff003.Ff003Tipoespecie equals ff003TpEsp.Id into ff003TpEsp_ff003_join
                   from ff003TpEsp in ff003TpEsp_ff003_join.DefaultIfEmpty()

                   join ff003Static in _appDbContext.E9ACSICP_Statica
                   on ff003.Ff003Provisao equals ff003Static.Id into ff003Static_ff003_join
                   from ff003Static in ff003Static_ff003_join.DefaultIfEmpty()

                   where ff003.TenantId == tenant

                   select new CSICP_FF003
                   {
                       TenantId = ff003.TenantId,
                       Id = ff003.Id,
                       Ff003Filialid = ff003.Ff003Filialid,
                       Ff003Tipoespecie = ff003.Ff003Tipoespecie,
                       Ff003Codigo = ff003.Ff003Codigo,
                       Ff003Descricao = ff003.Ff003Descricao,
                       Ff003Descresumida = ff003.Ff003Descresumida,
                       Ff003Pfx = ff003.Ff003Pfx,
                       Ff003Provisao = ff003.Ff003Provisao,
                       Ff003Ccustoid = ff003.Ff003Ccustoid,
                       Ff003Lctoenttitulosid = ff003.Ff003Lctoenttitulosid,
                       Ff003Lctobxnormalid = ff003.Ff003Lctobxnormalid,
                       Ff003Lctobxdevolucaoid = ff003.Ff003Lctobxdevolucaoid,
                       Ff003Seqnrotitulo = ff003.Ff003Seqnrotitulo,

                       NavBB001 = bb001 != null ? new CSICP_BB001
                       {
                           TenantId = bb001.TenantId,
                           Id = bb001.Id,
                           Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                           Bb001Razaosocial = bb001.Bb001Razaosocial,
                           Bb001Endereco = bb001.Bb001Endereco,
                           Bb001Complemento = bb001.Bb001Complemento,
                           Bb001Numresidencial = bb001.Bb001Numresidencial,
                           Bb001Bairro = bb001.Bb001Bairro,
                           Bb001Cep = bb001.Bb001Cep,
                           Bb001Cnpj = bb001.Bb001Cnpj,
                           Bb001Inscestadual = bb001.Bb001Inscestadual,
                           Bb001Inscjunta = bb001.Bb001Inscjunta,
                           Bb001Datainscricao = bb001.Bb001Datainscricao,
                           Bb001Nomefantasia = bb001.Bb001Nomefantasia,
                           Bb001Telefone = bb001.Bb001Telefone,
                           Bb001Fax = bb001.Bb001Fax,
                           Bb001Slogamempresa1 = bb001.Bb001Slogamempresa1,
                           Bb001Slogamempresa2 = bb001.Bb001Slogamempresa2,
                           Bb001Email = bb001.Bb001Email,
                           Bb001Homepage = bb001.Bb001Homepage,
                           Bb001Ramoempresa = bb001.Bb001Ramoempresa,
                           Bb002Grupoempresa = bb001.Bb002Grupoempresa,
                           Bb001Codgclienteaux = bb001.Bb001Codgclienteaux,
                           Bb001Almoxpadrao = bb001.Bb001Almoxpadrao,
                           Bb001Almoxtransfer = bb001.Bb001Almoxtransfer,
                           Bb001Bddistribuida = bb001.Bb001Bddistribuida,
                           Bb001Cnaefiscal = bb001.Bb001Cnaefiscal,
                           Bb001Suframaemp = bb001.Bb001Suframaemp,
                           Bb001Inscmunicipal = bb001.Bb001Inscmunicipal,
                           Bb001Paisid = bb001.Bb001Paisid,
                           Cidadeid = bb001.Cidadeid,
                           Bb001Ufid = bb001.Bb001Ufid,
                           Bb001Nomeoficial = bb001.Bb001Nomeoficial,
                           Bb001CpfOficial = bb001.Bb001CpfOficial,
                           Bb001Codgcartorio = bb001.Bb001Codgcartorio,
                           Bb001Nomesubstituto = bb001.Bb001Nomesubstituto,
                           Bb001Descricaooficial = bb001.Bb001Descricaooficial,
                           Bb001Capitalmunicipio = bb001.Bb001Capitalmunicipio,
                           Bb001Cor1Hexa = bb001.Bb001Cor1Hexa,
                           Bb001Cor2Hexa = bb001.Bb001Cor2Hexa,
                           Bb001IdiomaId = bb001.Bb001IdiomaId,
                           Bb001Isactive = bb001.Bb001Isactive,
                           Bb001Token = bb001.Bb001Token,
                           Bb001Usuariosirc = bb001.Bb001Usuariosirc,
                           Bb001Senhasirc = bb001.Bb001Senhasirc,
                           Bb001Tenantfiscal = bb001.Bb001Tenantfiscal,
                           Bb001TokenEsitef = bb001.Bb001TokenEsitef,
                           Bb001UrlGoogleplay = bb001.Bb001UrlGoogleplay,
                           Bb001UrlAppstore = bb001.Bb001UrlAppstore,
                           Bb001Cix = bb001.Bb001Cix,
                           Bb001ChaveApl = bb001.Bb001ChaveApl,
                           Bb001AutToken = bb001.Bb001AutToken,
                           Bb001TokenCspix = bb001.Bb001TokenCspix,
                       } : null,

                       NavFF003TpEsp = ff003TpEsp != null ?  new OsusrE9aCsicpFf003Tpesp
                       {
                           Id = ff003TpEsp.Id,
                           Label = ff003TpEsp.Label,
                           Order = ff003TpEsp.Order,
                           IsActive = ff003TpEsp.IsActive,
                           IdPdv = ff003TpEsp.IdPdv,
                       } : null,

                       NavStatica = ff003Static != null ? new CSICP_Statica
                       {
                           Id = ff003Static.Id,
                           Label = ff003Static.Label,
                           Tiporegistro = ff003Static.Tiporegistro,
                           Order = ff003Static.Order,
                       } : null
                   };
        }
    }
}