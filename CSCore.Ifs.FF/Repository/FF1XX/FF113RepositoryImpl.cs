using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF112;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF113;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF113RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF113>(appDbContext, "Id"), IFF113Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<RepoDtoCSICP_FF113?> GetByIdAsync(int in_tenant, string in_ff113Id)
        {
            IQueryable<RepoDtoCSICP_FF113> query = GetQueryBase(in_tenant);
            RepoDtoCSICP_FF113? cSICP_FF113 = await query.FirstOrDefaultAsync(e => e.Id == in_ff113Id);
            return cSICP_FF113;
        }

        private IQueryable<RepoDtoCSICP_FF113> GetQueryBase(int in_tenant)
        {
            return from ff113cnab in _appDbContext.OsusrE9aCsicpFf113s
                   .AsNoTracking()

                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff113cnab.Ff113Filialid equals bb001.Id into bb001_ff113cnab_Join
                   from bb001 in bb001_ff113cnab_Join.DefaultIfEmpty()

                   join ff112 in _appDbContext.OsusrE9aCsicpFf112s
                   on ff113cnab.Ff113RefConfBanco equals ff112.Id into ff112_ff113cnab_Join
                   from ff112 in ff112_ff113cnab_Join.DefaultIfEmpty()

                   join ff113tipo in _appDbContext.OsusrE9aCsicpFf113Tipos
                   on ff113cnab.Ff113Tipo equals ff113tipo.Id into ff113tipo_ff113cnab_Join
                   from ff113tipo in ff113tipo_ff113cnab_Join.DefaultIfEmpty()

                   join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                   on ff113cnab.Ff113Usuariopropr equals sy001.Id into sy001_ff113cnab_Join
                   from sy001 in sy001_ff113cnab_Join.DefaultIfEmpty()

                   join ff105bordero in _appDbContext.OsusrE9aCsicpFf105s
                   on ff113cnab.Ff113Borderoid equals ff105bordero.Id into ff105bordero_ff113cnab_Join
                   from ff105bordero in ff105bordero_ff113cnab_Join.DefaultIfEmpty()

                   join ff112_C004 in _appDbContext.OsusrE9aCsicpFf112C004s
                   on ff113cnab.Ff113Codgmovtoremessa equals ff112_C004.Id into ff112_C004_ff113cnab_Join
                   from ff112_C004 in ff112_C004_ff113cnab_Join.DefaultIfEmpty()

                   where ff113cnab.TenantId == in_tenant
                   select new RepoDtoCSICP_FF113
                   {
                       TenantId = ff113cnab.TenantId,
                       Id = ff113cnab.Id,
                       Ff113Usuariopropr = ff113cnab.Ff113Usuariopropr,
                       Ff113Filialid = ff113cnab.Ff113Filialid,
                       Ff113RefConfBanco = ff113cnab.Ff113RefConfBanco,
                       Ff113Dataregistro = ff113cnab.Ff113Dataregistro,
                       Ff113Nota = ff113cnab.Ff113Nota,
                       Ff113Lote = ff113cnab.Ff113Lote,
                       Ff113Desclote = ff113cnab.Ff113Desclote,
                       Ff113Borderoid = ff113cnab.Ff113Borderoid,
                       Ff113Tipo = ff113cnab.Ff113Tipo,
                       Ff113Retornoid = ff113cnab.Ff113Retornoid,
                       Nn015Bxtesourariaid = ff113cnab.Nn015Bxtesourariaid,
                       Ff113Codgmovtoremessa = ff113cnab.Ff113Codgmovtoremessa,

                       NavBB001 = bb001 != null ? new CSICP_BB001
                       {
                           TenantId = bb001.TenantId,
                           Id = bb001.Id,
                           Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                           Bb001Razaosocial = bb001.Bb001Razaosocial,
                       } : null,

                       NavFF112 = ff112 != null ? new CSICP_FF112
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
                           Ff112OrgaoNeg = ff112.Ff112OrgaoNeg
                       } : null,

                       NavFF113Tipo = ff113tipo != null ? new OsusrE9aCsicpFf113Tipo
                       {
                           Id = ff113tipo.Id,
                           Label = ff113tipo.Label,
                           Order = ff113tipo.Order,
                           IsActive = ff113tipo.IsActive
                       } : null,

                       NavSy001 = sy001 != null ? new Csicp_Sy001
                       {
                           TenantId = sy001.TenantId,
                           Id = sy001.Id,
                           Sy001Usuario = sy001.Sy001Usuario,
                           Sy001Nome = sy001.Sy001Nome
                       } : null,

                          NavFF105 = ff105bordero != null ? new CSICP_FF105
                          {
                            TenantId = ff105bordero.TenantId,
                            Id = ff105bordero.Id,
                            Ff105Filialid = ff105bordero.Ff105Filialid,
                            Ff105Descricaobordero = ff105bordero.Ff105Descricaobordero,
                            Ff105ClienteInicial = ff105bordero.Ff105ClienteInicial,
                            Ff105ClienteFinal = ff105bordero.Ff105ClienteFinal,
                            Ff105EmissaoInicial = ff105bordero.Ff105EmissaoInicial,
                            Ff105EmissaoFinal = ff105bordero.Ff105EmissaoFinal,
                            Ff105VenctoInicial = ff105bordero.Ff105VenctoInicial,
                            Ff105VenctoFinal = ff105bordero.Ff105VenctoFinal,
                            Ff105CodgcategIni = ff105bordero.Ff105CodgcategIni,
                            Ff105CodgcategFim = ff105bordero.Ff105CodgcategFim,
                            Ff105CodgrotaIni = ff105bordero.Ff105CodgrotaIni,
                            Ff105CodgrotaFim = ff105bordero.Ff105CodgrotaFim,
                            Ff105ValorMinimo = ff105bordero.Ff105ValorMinimo,
                            Ff105Agcobradorid = ff105bordero.Ff105Agcobradorid,
                            Ff105Tipocobrancaid = ff105bordero.Ff105Tipocobrancaid,
                            Ff105InstCobranca1 = ff105bordero.Ff105InstCobranca1,
                            Ff105InstCobranca2 = ff105bordero.Ff105InstCobranca2,
                            Ff105Agencia = ff105bordero.Ff105Agencia,
                            Ff105AgenciaDv = ff105bordero.Ff105AgenciaDv,
                            Ff105ContaCorrente = ff105bordero.Ff105ContaCorrente,
                            Ff105ContaDv = ff105bordero.Ff105ContaDv,
                            Ff105DataEnvio = ff105bordero.Ff105DataEnvio,
                            Ff105ValorBordero = ff105bordero.Ff105ValorBordero,
                            Ff105QtdTitulos = ff105bordero.Ff105QtdTitulos,
                            Ff105Fechado = ff105bordero.Ff105Fechado,
                            Ff105IsActive = ff105bordero.Ff105IsActive,
                            Ff105Status = ff105bordero.Ff105Status,
                            Ff105Protocolnumber = ff105bordero.Ff105Protocolnumber,
                            Ff105ApiId = ff105bordero.Ff105ApiId,
                            Ff105Statusapi = ff105bordero.Ff105Statusapi,
                            Ff105DataCriacao = ff105bordero.Ff105DataCriacao,
                          } : null,

                          NavFF112C004 = ff112_C004 != null ? new OsusrE9aCsicpFf112C004
                            {
                                Id = ff112_C004.Id,
                                Label = ff112_C004.Label,
                                Order = ff112_C004.Order,
                                IsActive = ff112_C004.IsActive,
                                Codgcnab = ff112_C004.Codgcnab,
                          } : null
                   };
        }

        public async Task<(List<RepoDtoCSICP_FF113>, int)> GetListAsync(
            int in_tenant, int in_pageNumber, int in_pageSize, string? in_estabId, DateTime? in_dataRegistroInicio, DateTime? in_dataRegistroFim, int? in_tipo)
        {
            IQueryable<RepoDtoCSICP_FF113> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_estabId, in_dataRegistroInicio, in_dataRegistroFim, in_tipo, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<RepoDtoCSICP_FF113> FiltraQuandoExisteFiltro(
            string? in_estabId, DateTime? in_dataRegistroInicio, DateTime? in_dataRegistroFim, int? in_tipo, IQueryable<RepoDtoCSICP_FF113> query)
        {
            if (in_estabId != null)
                query = query.Where(e => e.Ff113Filialid == in_estabId);

            if (in_dataRegistroInicio.HasValue || in_dataRegistroFim.HasValue)
            {
                query = query.Where(e =>
                    (!in_dataRegistroInicio.HasValue || e.Ff113Dataregistro >= in_dataRegistroInicio.Value) &&
                    (!in_dataRegistroFim.HasValue || e.Ff113Dataregistro <= in_dataRegistroFim.Value)
                );
            }

            if (in_tipo != null)
            {
                query = query.Where(e => e.Ff113Tipo == in_tipo);
            }

            return query;
        }
    }
}