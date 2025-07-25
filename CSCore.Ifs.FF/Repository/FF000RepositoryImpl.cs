using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CSCore.Ifs.FF.Repository
{
    public class FF000RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseImpl<CSICP_FF000>(appDbContext, "Ff000Id"), IFF000Repository
    {

        //fiz uma mudança no repositorio sub modulo, isso deve ser deletado
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_FF000?> GetByIdAsync(int tenant, string id)
        {
            IQueryable<CSICP_FF000> query = GetQueryBase(tenant);
            CSICP_FF000? cSICP_FF000 = await query.FirstOrDefaultAsync(e => e.Ff000Id == id);
            return cSICP_FF000;
        }

        public async Task<(IEnumerable<CSICP_FF000>, int)> GetListAsync(int tenant, int page, int pageSize,
            string? razaoSocial, string? usuario, string? estabelecimentoId)
        {
            IQueryable<CSICP_FF000> query = GetQueryBase(tenant);
            query = FiltraQuandoExisteFiltro(razaoSocial, usuario, estabelecimentoId, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private static IQueryable<CSICP_FF000> FiltraQuandoExisteFiltro(string? razaoSocial, string? usuario,
            string? estabelecimentoId, IQueryable<CSICP_FF000> query)
        {
            if (estabelecimentoId != null)
                query = query.Where(e => e.Ff000EstabId!.Equals(estabelecimentoId));

            if (razaoSocial != null)
                query = query.Where(e => e.NavBB001 != null && e.NavBB001!.Bb001Razaosocial!.Equals(razaoSocial));

            if (usuario != null)
                query = query.Where(e => e.NavSy001 != null && e.NavSy001!.Sy001Usuario!.Equals(usuario));

            if (usuario != null)
                query = query.Where(e => e.NavSy001_2 != null && e.NavSy001_2!.Sy001Usuario!.Equals(usuario));
            return query;
        }

        private IQueryable<CSICP_FF000> GetQueryBase(int tenant)
        {
            return from ff000 in _appDbContext.OsusrE9aCsicpFf000s

                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff000.Ff000EstabId equals bb001.Id into bb001_ff000_join
                   from bb001 in bb001_ff000_join.DefaultIfEmpty()

                   join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                   on ff000.Ff000N1AutorizadorId equals sy001.Id into sy001_ff000_join
                   from sy001 in sy001_ff000_join.DefaultIfEmpty()

                   join sy001_2 in _appDbContext.OsusrE9aCsicpSy001s
                   on ff000.Ff000N1AusenciaId equals sy001_2.Id into sy001_2_ff000_join
                   from sy001_2 in sy001_2_ff000_join.DefaultIfEmpty()

                   join ff000BaseCalc in _appDbContext.OsusrE9aCsicpFf000Basecalcs
                   on ff000.Ff000BasecalcId equals ff000BaseCalc.Id into ff000BaseCalc_ff000_join
                   from ff000BaseCalc in ff000BaseCalc_ff000_join.DefaultIfEmpty()

                   where ff000.TenantId == tenant

                   select new CSICP_FF000
                   {
                       TenantId = ff000.TenantId,
                       Ff000Id = ff000.Ff000Id,
                       Ff000EstabId = ff000.Ff000EstabId,
                       Ff000N1Vacimade = ff000.Ff000N1Vacimade,
                       Ff000N1AutorizadorId = ff000.Ff000N1AutorizadorId,
                       Ff000N1AusenciaId = ff000.Ff000N1AusenciaId,
                       Ff000N2Vacimade = ff000.Ff000N2Vacimade,
                       Ff000N2AutorizadorId = ff000.Ff000N2AutorizadorId,
                       Ff000N2AusenciaId = ff000.Ff000N2AusenciaId,
                       Ff000N3Vacimade = ff000.Ff000N3Vacimade,
                       Ff000N3AutorizadorId = ff000.Ff000N3AutorizadorId,
                       Ff000N3AusenciaId = ff000.Ff000N3AusenciaId,
                       Ff000N4Vacimade = ff000.Ff000N4Vacimade,
                       Ff000N4AutorizadorId = ff000.Ff000N4AutorizadorId,
                       Ff000N4AusenciaId = ff000.Ff000N4AusenciaId,
                       Ff000N5Vacimade = ff000.Ff000N5Vacimade,
                       Ff000N5AutorizadorId = ff000.Ff000N5AutorizadorId,
                       Ff000N5AusenciaId = ff000.Ff000N5AusenciaId,
                       Ff000BasecalcId = ff000.Ff000BasecalcId,
                       Ff000PercJuros = ff000.Ff000PercJuros,
                       Ff000PercMulta = ff000.Ff000PercMulta,
                       Ff000Diascarjuros = ff000.Ff000Diascarjuros,
                       Ff000Diascarmulta = ff000.Ff000Diascarmulta,
                       Ff000Diasbloqueio = ff000.Ff000Diasbloqueio,
                       Ff000Diasbloqmovto = ff000.Ff000Diasbloqmovto,
                       Ff000Diasretroagirvencto = ff000.Ff000Diasretroagirvencto,
                       Ff000Diasavancarvencto = ff000.Ff000Diasavancarvencto,
                       Ff000Isdesabfcconfaut = ff000.Ff000Isdesabfcconfaut,
                       Ff000PercCorrmonetaria = ff000.Ff000PercCorrmonetaria,
                       Ff000PercHonorarios = ff000.Ff000PercHonorarios,
                       Ff000Renccustoid = ff000.Ff000Renccustoid,
                       Ff000Renagcobradorid = ff000.Ff000Renagcobradorid,
                       Ff000Rentpcobrancaid = ff000.Ff000Rentpcobrancaid,
                       Ff000Pminentrenegociacao = ff000.Ff000Pminentrenegociacao,
                       Ff000Isrensomentetodos = ff000.Ff000Isrensomentetodos,
                       Ff000Renespecieid = ff000.Ff000Renespecieid,
                       Ff000Isrensempregerarvc = ff000.Ff000Isrensempregerarvc,
                       Ff00Formabxtesid = ff000.Ff00Formabxtesid,
                       F000Formaenvapi = ff000.F000Formaenvapi,
                       Ff000AgcobradoridApi = ff000.Ff000AgcobradoridApi,
                       Ff000TpcobrancaidApi = ff000.Ff000TpcobrancaidApi,
                       Ff000Ispermitecpfcnpjdup = ff000.Ff000Ispermitecpfcnpjdup,
                       Ff000PixcobFpagtoid = ff000.Ff000PixcobFpagtoid,

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

                       NavSy001 = sy001 != null ? new Csicp_Sy001
                       {
                           TenantId = sy001.TenantId,
                           Id = sy001.Id,
                           Sy001Usuario = sy001.Sy001Usuario,
                           Sy001Nome = sy001.Sy001Nome,
                           Sy001Senha = sy001.Sy001Senha,
                           Sy001Bloqueado = sy001.Sy001Bloqueado,
                           Sy001DataValidade = sy001.Sy001DataValidade,
                           Sy001Autalterarsenha = sy001.Sy001Autalterarsenha,
                           Sy001Altsenhapxlogin = sy001.Sy001Altsenhapxlogin,
                           Sy001ExpiraSenha = sy001.Sy001ExpiraSenha,
                           Sy001Dtexpiracaologin = sy001.Sy001Dtexpiracaologin,
                           Sy001Deptolotado = sy001.Sy001Deptolotado,
                           Sy001Cargo = sy001.Sy001Cargo,
                           Sy001Email = sy001.Sy001Email,
                           Sy001Imagem = sy001.Sy001Imagem,
                           Sy001Dataultimoacesso = sy001.Sy001Dataultimoacesso,
                           Userid = sy001.Userid,
                           Sy001IdiomaId = sy001.Sy001IdiomaId,
                           Sy001Senhacs = sy001.Sy001Senhacs,
                           Sy001Celular = sy001.Sy001Celular,
                       } : null,

                       NavSy001_2 = sy001_2 != null ? new Csicp_Sy001
                       {
                           TenantId = sy001_2.TenantId,
                           Id = sy001_2.Id,
                           Sy001Usuario = sy001_2.Sy001Usuario,
                           Sy001Nome = sy001_2.Sy001Nome,
                           Sy001Senha = sy001_2.Sy001Senha,
                           Sy001Bloqueado = sy001_2.Sy001Bloqueado,
                           Sy001DataValidade = sy001_2.Sy001DataValidade,
                           Sy001Autalterarsenha = sy001_2.Sy001Autalterarsenha,
                           Sy001Altsenhapxlogin = sy001_2.Sy001Altsenhapxlogin,
                           Sy001ExpiraSenha = sy001_2.Sy001ExpiraSenha,
                           Sy001Dtexpiracaologin = sy001_2.Sy001Dtexpiracaologin,
                           Sy001Deptolotado = sy001_2.Sy001Deptolotado,
                           Sy001Cargo = sy001_2.Sy001Cargo,
                           Sy001Email = sy001_2.Sy001Email,
                           Sy001Imagem = sy001_2.Sy001Imagem,
                           Sy001Dataultimoacesso = sy001_2.Sy001Dataultimoacesso,
                           Userid = sy001_2.Userid,
                           Sy001IdiomaId = sy001_2.Sy001IdiomaId,
                           Sy001Senhacs = sy001_2.Sy001Senhacs,
                           Sy001Celular = sy001_2.Sy001Celular,
                       } : null,

                       NavFF000BaseCalculo = ff000BaseCalc != null ? new CSICP_FF000Basecalc
                       {
                           Id = ff000BaseCalc.Id,
                           Label = ff000BaseCalc.Label,
                           Order = ff000BaseCalc.Order,
                           IsActive = ff000BaseCalc.IsActive,
                       } : null
                   };
        }
    }
}