using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF112RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF112>(appDbContext, "Id"), IFF112Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_FF112?> GetByIdAsync(int in_tenant, string id)
        {
            IQueryable<CSICP_FF112> query = GetQueryBase(in_tenant);
            CSICP_FF112? cSICP_FF112 = await query.FirstOrDefaultAsync(e => e.Id == id);
            return cSICP_FF112;
        }

        public async Task<(List<CSICP_FF112>, int)> GetListAsync(
            int in_tenant, int in_page, int in_pageSize, string? in_estabID, string? in_descCnab, string? in_bancoID, bool? in_isActive)
        {
            IQueryable<CSICP_FF112> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_estabID, in_descCnab, in_bancoID, in_isActive, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_page, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_FF112> FiltraQuandoExisteFiltro(
            string? in_estabID, string? in_descCnab, string? in_bancoID, bool? in_isActive, IQueryable<CSICP_FF112> query)
        {
            if (in_estabID != null)
                query = query.Where(e => e.Ff112Filialid!.Equals(in_estabID));
            if (in_descCnab != null)
                query = query.Where(e => e.Ff112Descregistro!.Contains(in_descCnab));
            if (in_bancoID != null)
                query = query.Where(e => e.Ff112Bancoid!.Contains(in_bancoID));
            //fazer o filtro isActive.
            //perguntar se é para fazer o filtro por "tipo operação" que está no outsystems mas não na issue.

            return query;
        }

        private IQueryable<CSICP_FF112> GetQueryBase(int in_tenant)
        {
            return from ff112 in _appDbContext.OsusrE9aCsicpFf112s
                   .AsNoTracking()

                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff112.Ff112Filialid equals bb001.Id into bb001_ff112_join
                   from bb001 in bb001_ff112_join.DefaultIfEmpty()

                   join bb006 in _appDbContext.OsusrE9aCsicpBb006s
                   on ff112.Ff112Bancoid equals bb006.Id into bb006_ff112_join
                   from bb006 in bb006_ff112_join.DefaultIfEmpty()

                   join ff112_C006 in _appDbContext.OsusrE9aCsicpFf112C006s
                   on ff112.Ff112Carteira equals ff112_C006.Id into ff112_C006_ff112_join
                   from ff112_C006 in ff112_C006_ff112_join.DefaultIfEmpty()

                   join ff112_C026 in _appDbContext.OsusrE9aCsicpFf112C026s
                   on ff112.Ff112Codgprotesto equals ff112_C026.Id into ff112_C026_ff112_join
                   from ff112_C026 in ff112_C026_ff112_join.DefaultIfEmpty()

                   join ff112_C028 in _appDbContext.OsusrE9aCsicpFf112C028s
                   on ff112.Ff112Codgbaixadevolucao equals ff112_C028.Id into ff112_C028_ff112_join
                   from ff112_C028 in ff112_C028_ff112_join.DefaultIfEmpty()

                   join ff112_cnab in _appDbContext.OsusrE9aCsicpFf112Cnabs
                   on ff112.Ff112CnabId equals ff112_cnab.Id into ff112_cnab_ff112_join
                   from ff112_cnab in ff112_cnab_ff112_join.DefaultIfEmpty()

                   join ff112_G005 in _appDbContext.OsusrE9aCsicpFf112G005s
                   on ff112.Ff112Tipoinscricao equals ff112_G005.Id into ff112_G005_ff112_join
                   from ff112_G005 in ff112_G005_ff112_join.DefaultIfEmpty()

                   join ff112_G025 in _appDbContext.OsusrE9aCsicpFf112G025s
                   on ff112.Ff112Tiposervico equals ff112_G025.Id into ff112_G025_ff112_join
                   from ff112_G025 in ff112_G025_ff112_join.DefaultIfEmpty()

                   join ff112_G028 in _appDbContext.OsusrE9aCsicpFf112G028s
                   on ff112.Ff112Tipooperacao equals ff112_G028.Id into ff112_G028_ff112_join
                   from ff112_G028 in ff112_G028_ff112_join.DefaultIfEmpty()

                   where ff112.TenantId == in_tenant
                   select new CSICP_FF112
                   {
                       TenantId = ff112.TenantId,
                       Id = ff112.Id,
                       Ff112Filialid = ff112.Ff112Filialid,
                       Ff112Bancoid = ff112.Ff112Bancoid,
                       Ff112Descregistro = ff112.Ff112Descregistro,
                       Ff112Ultlote = ff112.Ff112Ultlote,
                       Ff112Carteira = ff112.Ff112Carteira,
                       Ff112Convenio = ff112.Ff112Convenio,
                       Ff112Cadastramento = ff112.Ff112Cadastramento,
                       Ff112Documento = ff112.Ff112Documento,
                       Ff112Emissaobloqueto = ff112.Ff112Emissaobloqueto,
                       Ff112Distribuicaobloqueto = ff112.Ff112Distribuicaobloqueto,
                       Ff112Nrocontrato = ff112.Ff112Nrocontrato,
                       Ff112Moedapadrao = ff112.Ff112Moedapadrao,
                       Ff112Tipooperacao = ff112.Ff112Tipooperacao,
                       Ff112Tiposervico = ff112.Ff112Tiposervico,
                       Ff112Tipoinscricao = ff112.Ff112Tipoinscricao,
                       Ff112Codgprotesto = ff112.Ff112Codgprotesto,
                       Ff112Prazoprotesto = ff112.Ff112Prazoprotesto,
                       Ff112Codgbaixadevolucao = ff112.Ff112Codgbaixadevolucao,
                       Ff112Prazodevolucao = ff112.Ff112Prazodevolucao,
                       Ff112Versaocnab = ff112.Ff112Versaocnab,
                       Ff112Mensagem1 = ff112.Ff112Mensagem1,
                       Ff112Mensagem2 = ff112.Ff112Mensagem2,
                       Ff112Mensagem3 = ff112.Ff112Mensagem3,
                       Ff112Mensagem4 = ff112.Ff112Mensagem4,
                       IsActive = ff112.IsActive,
                       Ff112Codgmovimetoretorno = ff112.Ff112Codgmovimetoretorno,
                       Ff112Nrocarteira = ff112.Ff112Nrocarteira,
                       Ff112Varcarteira = ff112.Ff112Varcarteira,
                       Ff112Faixanossonro = ff112.Ff112Faixanossonro,
                       Ff112CnabId = ff112.Ff112CnabId,
                       Ff112PercJuros = ff112.Ff112PercJuros,
                       Ff112ValorJuros = ff112.Ff112ValorJuros,
                       Ff112PercMulta = ff112.Ff112PercMulta,
                       Ff112ValorMulta = ff112.Ff112ValorMulta,
                       Ff112PercDesconto = ff112.Ff112PercDesconto,
                       Ff112CnabCodDesconto = ff112.Ff112CnabCodDesconto,
                       Ff112CnabCodJurosMora = ff112.Ff112CnabCodJurosMora,
                       Ff112CnabCodMulta = ff112.Ff112CnabCodMulta,
                       Ff112Prazorecbto = ff112.Ff112Prazorecbto,
                       Ff112Boletoid = ff112.Ff112Boletoid,
                       Ff112Ccorrenteid = ff112.Ff112Ccorrenteid,
                       Ff112IdentAceite = ff112.Ff112IdentAceite,
                       Ff112Ismultempresa = ff112.Ff112Ismultempresa,
                       Ff112TpCobrEntrada = ff112.Ff112TpCobrEntrada,
                       Ff112TpCobrSaida = ff112.Ff112TpCobrSaida,
                       Ff112Prazonegativacao = ff112.Ff112Prazonegativacao,
                       Ff112OrgaoNeg = ff112.Ff112OrgaoNeg,
                       
                       NavBB001 = bb001 != null ? new CSICP_BB001
                       {
                           TenantId = bb001.TenantId,
                           Id = bb001.Id,
                           Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                           Bb001Razaosocial = bb001.Bb001Razaosocial,
                       } : null,
                   };
        }
    }
}