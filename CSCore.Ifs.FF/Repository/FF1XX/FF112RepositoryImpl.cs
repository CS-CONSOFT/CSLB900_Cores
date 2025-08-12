using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF112;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF112RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF112>(appDbContext, "Id"), IFF112Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<RepoDtoCSICP_FF112?> GetByIdAsync(int in_tenant, string in_ff112Id)
        {
            IQueryable<RepoDtoCSICP_FF112> query = GetQueryBase(in_tenant);
            RepoDtoCSICP_FF112? cSICP_FF112 = await query.FirstOrDefaultAsync(e => e.Id == in_ff112Id);
            return cSICP_FF112;
        }

        public async Task<(List<RepoDtoCSICP_FF112>, int)> GetListAsync(
            int in_tenant, int in_pageNumber, int in_pageSize, string? in_estabId, string? in_descCnab, string? in_bancoId, bool? in_isActive, int? in_tipoOperacao)
        {
            IQueryable<RepoDtoCSICP_FF112> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_estabId, in_descCnab, in_bancoId, in_isActive, in_tipoOperacao, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<RepoDtoCSICP_FF112> FiltraQuandoExisteFiltro(
            string? in_estabId, string? in_descCnab, string? in_bancoId, bool? in_isActive, int? in_tipoOperacao, IQueryable<RepoDtoCSICP_FF112> query)
        {
            if (in_estabId != null)
                query = query.Where(e => e.Ff112Filialid!.Equals(in_estabId));
            if (in_descCnab != null)
                query = query.Where(e => e.Ff112Descregistro!.Contains(in_descCnab));
            if (in_bancoId != null)
                query = query.Where(e => e.Ff112Bancoid!.Contains(in_bancoId));
            if (in_tipoOperacao != null)
                query = query.Where(e => e.Ff112Tipooperacao!.Equals(in_tipoOperacao));
            if (in_isActive != null)
                query = query.Where(e => e.IsActive ==in_isActive);

            return query;
        }

        private IQueryable<RepoDtoCSICP_FF112> GetQueryBase(int in_tenant)
        {
            return from ff112 in _appDbContext.OsusrE9aCsicpFf112s
                   .AsNoTracking()

                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff112.Ff112Filialid equals bb001.Id into bb001_ff112_join
                   from bb001 in bb001_ff112_join.DefaultIfEmpty()

                   join bb006 in _appDbContext.OsusrE9aCsicpBb006s
                   on ff112.Ff112Bancoid equals bb006.Id into bb006_ff112_join
                   from bb006 in bb006_ff112_join.DefaultIfEmpty()

                   join bb009ent in _appDbContext.OsusrE9aCsicpBb009s
                   on ff112.Ff112TpCobrEntrada equals bb009ent.Id into bb009ent_ff112_join
                   from bb009ent in bb009ent_ff112_join.DefaultIfEmpty()

                   join bb009sai in _appDbContext.OsusrE9aCsicpBb009s
                   on ff112.Ff112TpCobrSaida equals bb009sai.Id into bb009sai_ff112_join
                   from bb009sai in bb009sai_ff112_join.DefaultIfEmpty()

                   join ff112_C006 in _appDbContext.OsusrE9aCsicpFf112C006s
                   on ff112.Ff112Carteira equals ff112_C006.Id into ff112_C006_ff112_join
                   from ff112_C006 in ff112_C006_ff112_join.DefaultIfEmpty()

                   join ff112_C007 in _appDbContext.OsusrE9aCsicpFf112C007s
                   on ff112.Ff112Cadastramento equals ff112_C007.Id into ff112_C007_ff112_join
                   from ff112_C007 in ff112_C007_ff112_join.DefaultIfEmpty()

                   join ff112_C008 in _appDbContext.OsusrE9aCsicpFf112C008s
                   on ff112.Ff112Documento equals ff112_C008.Id into ff112_C008_ff112_join
                   from ff112_C008 in ff112_C008_ff112_join.DefaultIfEmpty()

                   join ff112_C009 in _appDbContext.OsusrE9aCsicpFf112C009s
                   on ff112.Ff112Emissaobloqueto equals ff112_C009.Id into ff112_C009_ff112_join
                   from ff112_C009 in ff112_C009_ff112_join.DefaultIfEmpty()

                   join ff112_C010 in _appDbContext.OsusrE9aCsicpFf112C010s
                   on ff112.Ff112Distribuicaobloqueto equals ff112_C010.Id into ff112_C010_ff112_join
                   from ff112_C010 in ff112_C010_ff112_join.DefaultIfEmpty()

                   join ff112_C026 in _appDbContext.OsusrE9aCsicpFf112C026s
                   on ff112.Ff112Codgprotesto equals ff112_C026.Id into ff112_C026_ff112_join
                   from ff112_C026 in ff112_C026_ff112_join.DefaultIfEmpty()

                   join ff112_C028 in _appDbContext.OsusrE9aCsicpFf112C028s
                   on ff112.Ff112Codgbaixadevolucao equals ff112_C028.Id into ff112_C028_ff112_join
                   from ff112_C028 in ff112_C028_ff112_join.DefaultIfEmpty()

                   join ff112_cnab in _appDbContext.OsusrE9aCsicpFf112Cnabs
                   on ff112.Ff112CnabId equals ff112_cnab.Id into ff112_cnab_ff112_join
                   from ff112_cnab in ff112_cnab_ff112_join.DefaultIfEmpty()

                   join ff112_OrgNeg in _appDbContext.OsusrE9aCsicpFf112OrgNegs
                   on ff112.Ff112OrgaoNeg equals ff112_OrgNeg.Id into ff112_OrgNeg_ff112_join
                   from ff112_OrgNeg in ff112_OrgNeg_ff112_join.DefaultIfEmpty()

                   join ff112_G005 in _appDbContext.OsusrE9aCsicpFf112G005s
                   on ff112.Ff112Tipoinscricao equals ff112_G005.Id into ff112_G005_ff112_join
                   from ff112_G005 in ff112_G005_ff112_join.DefaultIfEmpty()

                   join ff112_G025 in _appDbContext.OsusrE9aCsicpFf112G025s
                   on ff112.Ff112Tiposervico equals ff112_G025.Id into ff112_G025_ff112_join
                   from ff112_G025 in ff112_G025_ff112_join.DefaultIfEmpty()

                   join ff112_G028 in _appDbContext.OsusrE9aCsicpFf112G028s
                   on ff112.Ff112Tipooperacao equals ff112_G028.Id into ff112_G028_ff112_join
                   from ff112_G028 in ff112_G028_ff112_join.DefaultIfEmpty()

                   join ff102_C021 in _appDbContext.OsusrE9aCsicpFf102C021s
                   on ff112.Ff112CnabCodDesconto equals ff102_C021.Id into ff112_C021_ff112_join
                   from ff112_C021 in ff112_C021_ff112_join.DefaultIfEmpty()

                   join ff112_C029 in _appDbContext.OsusrE9aCsicpFf112C029s
                   on ff112.Ff112IdentAceite equals ff112_C029.Id into ff112_C029_ff112_join
                   from ff112_C029 in ff112_C029_ff112_join.DefaultIfEmpty()

                   join ff102_C018 in _appDbContext.OsusrE9aCsicpFf102C018s
                   on ff112.Ff112CnabCodJurosMora equals ff102_C018.Id into ff112_C018_ff112_join
                   from ff112_C018 in ff112_C018_ff112_join.DefaultIfEmpty()

                   join ff102_G073 in _appDbContext.OsusrE9aCsicpFf102G073s
                   on ff112.Ff112CnabCodMulta equals ff102_G073.Id into ff112_G073_ff112_join
                   from ff112_G073 in ff112_G073_ff112_join.DefaultIfEmpty()

                   where ff112.TenantId == in_tenant
                   select new RepoDtoCSICP_FF112
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

                       NavBB006 = bb006 != null ? new CSICP_Bb006
                       {
                           TenantId = bb006.TenantId,
                           Id = bb006.Id,
                           Bb006Codgbanco = bb006.Bb006Codgbanco,
                           Bb006Banco = bb006.Bb006Banco
                       } : null,

                       NavFF112C006 = ff112_C006 != null ? new OsusrE9aCsicpFf112C006
                       {
                           Id = ff112_C006.Id,
                           Label = ff112_C006.Label,
                           Order = ff112_C006.Order,
                           IsActive = ff112_C006.IsActive,
                           Conteudo = ff112_C006.Conteudo,
                           ContBb = ff112_C006.ContBb,
                       } : null,

                       NavFF112C007 = ff112_C007 != null ? new OsusrE9aCsicpFf112C007
                       {
                           Id = ff112_C007.Id,
                           Label = ff112_C007.Label,
                           Order = ff112_C007.Order,
                           IsActive = ff112_C007.IsActive,
                           Conteudo = ff112_C007.Conteudo,
                       } : null,

                       NavFF112C008 = ff112_C008 != null ? new OsusrE9aCsicpFf112C008
                       {
                           Id = ff112_C008.Id,
                           Label = ff112_C008.Label,
                           Order = ff112_C008.Order,
                           IsActive = ff112_C008.IsActive,
                           Conteudo = ff112_C008.Conteudo,
                       } : null,

                       NavFF112C009 = ff112_C009 != null ? new OsusrE9aCsicpFf112C009
                       {
                           Id = ff112_C009.Id,
                           Label = ff112_C009.Label,
                           Order = ff112_C009.Order,
                           IsActive = ff112_C009.IsActive,
                           Conteudo = ff112_C009.Conteudo,
                       } : null,

                       NavFF112C010 = ff112_C010 != null ? new OsusrE9aCsicpFf112C010
                       {
                           Id = ff112_C010.Id,
                           Label = ff112_C010.Label,
                           Order = ff112_C010.Order,
                           IsActive = ff112_C010.IsActive,
                           Conteudo = ff112_C010.Conteudo,
                       } : null, 

                       NavFF112C026 = ff112_C026 != null ? new OsusrE9aCsicpFf112C026
                       {
                           Id = ff112_C026.Id,
                           Label = ff112_C026.Label,
                           Order = ff112_C026.Order,
                           IsActive = ff112_C026.IsActive,
                           Conteudo = ff112_C026.Conteudo,
                           Santander = ff112_C026.Santander,
                       } : null,

                       NavFF112C028 = ff112_C028 != null ? new OsusrE9aCsicpFf112C028
                       {
                           Id = ff112_C028.Id,
                           Label = ff112_C028.Label,
                           Order = ff112_C028.Order,
                           IsActive = ff112_C028.IsActive,
                           Conteudo = ff112_C028.Conteudo,
                       } : null,

                       NavFF112Cnab = ff112_cnab != null ? new OsusrE9aCsicpFf112Cnab
                       {
                           Id = ff112_cnab.Id,
                           Label = ff112_cnab.Label,
                           Order = ff112_cnab.Order,
                           IsActive = ff112_cnab.IsActive
                       } : null,

                       NavFF112OrgNeg = ff112_OrgNeg != null ? new OsusrE9aCsicpFf112OrgNeg
                       {
                           Id = ff112_OrgNeg.Id,
                           Label = ff112_OrgNeg.Label,
                           Order = ff112_OrgNeg.Order,
                           IsActive = ff112_OrgNeg.IsActive,
                           CodgBb = ff112_OrgNeg.CodgBb
                       } : null,

                       NavFF112G005 = ff112_G005 != null ? new OsusrE9aCsicpFf112G005
                       {
                           Id = ff112_G005.Id,
                           Label = ff112_G005.Label,
                           Order = ff112_G005.Order,
                           IsActive = ff112_G005.IsActive,
                           Conteudo = ff112_G005.Conteudo
                       } : null,

                       NavFF112G025 = ff112_G025 != null ? new OsusrE9aCsicpFf112G025
                       {
                           Id = ff112_G025.Id,
                           Label = ff112_G025.Label,
                           Order = ff112_G025.Order,
                           IsActive = ff112_G025.IsActive,
                           Conteudo = ff112_G025.Conteudo
                       } : null,

                       NavFF112G028 = ff112_G028 != null ? new OsusrE9aCsicpFf112G028
                       {
                           Id = ff112_G028.Id,
                           Label = ff112_G028.Label,
                           Order = ff112_G028.Order,
                           IsActive = ff112_G028.IsActive,
                           Conteudo = ff112_G028.Conteudo
                       } : null,

                       NavFF102C021 = ff112_C021 != null ? new CSICP_FF102_C021
                       {
                           Id = ff112_C021.Id,
                           Label = ff112_C021.Label,
                           Order = ff112_C021.Order,
                           IsActive = ff112_C021.IsActive,
                           Conteudo = ff112_C021.Conteudo
                       } : null,

                       NavFF112C029 = ff112_C029 != null ? new OsusrE9aCsicpFf112C029
                       {
                           Id = ff112_C029.Id,
                           Label = ff112_C029.Label,
                           Order = ff112_C029.Order,
                           IsActive = ff112_C029.IsActive,
                           Conteudo = ff112_C029.Conteudo
                       } : null,

                       NavFF102C018 = ff112_C018 != null ? new CSICP_FF102_C018
                       {
                           Id = ff112_C018.Id,
                           Label = ff112_C018.Label,
                           Order = ff112_C018.Order,
                           IsActive = ff112_C018.IsActive,
                           Conteudo = ff112_C018.Conteudo
                       } : null,

                       NavFF102G073 = ff112_G073 != null ? new CSICP_FF102_G073
                       {
                           Id = ff112_G073.Id,
                           Label = ff112_G073.Label,
                           Order = ff112_G073.Order,
                           IsActive = ff112_G073.IsActive,
                           Conteudo = ff112_G073.Conteudo
                       } : null
                   };
        }
    }
}