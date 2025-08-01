using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF00X
{
    public class FF001RepositoryImpl(AppDbContext appDbContext) : 
        RepositorioBaseImpl<CSICP_FF001>(appDbContext, "Id"), IFF001Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_FF001?> GetByIdAsync(int tenant, string id)
        {
            IQueryable<CSICP_FF001> query = GetQueryBase(tenant);
            CSICP_FF001? cSICP_FF001 = await query.FirstOrDefaultAsync(e => e.Id == id);
            return cSICP_FF001;
        }

        public async Task<(IEnumerable<CSICP_FF001>, int)> GetListAsync(int tenant, int page, int pageSize,
            string? descFeriado, string? nomeDoDia, string? razaoSocial, string? prmEmpresaId)
        {
            IQueryable<CSICP_FF001> query = GetQueryBase(tenant);
            query = FiltraQuandoExisteFiltro(descFeriado, nomeDoDia, razaoSocial, prmEmpresaId, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private static IQueryable<CSICP_FF001> FiltraQuandoExisteFiltro(string? descFeriado, string? nomeDoDia, string? razaoSocial, 
            string? prmEmpresaId, IQueryable<CSICP_FF001> query)
        {
            if (descFeriado != null)
                query = query.Where(e => e.Ff001Descferiado!.Equals(descFeriado));
            if (nomeDoDia != null)
                query = query.Where(e => e.Ff001NomeDoDia!.Equals(nomeDoDia));
            if (razaoSocial != null)
                query = query.Where(e => e.NavBB001 != null && e.NavBB001.Bb001Razaosocial!.Equals(razaoSocial));
            if (prmEmpresaId != null)
                query = query.Where(e => e.Ff001Filialid!.Equals(prmEmpresaId));
            return query;
        }

        private IQueryable<CSICP_FF001> GetQueryBase(int tenant)
        {
            return from ff001 in _appDbContext.OsusrE9aCsicpFf001s

                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff001.Ff001Filialid equals bb001.Id into bb001_ff001_join
                   from bb001 in bb001_ff001_join.DefaultIfEmpty()

                   where ff001.TenantId == tenant

                   select new CSICP_FF001
                   {
                       TenantId = ff001.TenantId,
                       Id = ff001.Id,
                       Ff001Filialid = ff001.Ff001Filialid,
                       Ff001Filial = ff001.Ff001Filial,
                       Ff001Data = ff001.Ff001Data,
                       Ff001Descferiado = ff001.Ff001Descferiado,
                       Ff001NomeDoDia = ff001.Ff001NomeDoDia,

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
                       } : null
                   };
        }
    }
}






