using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF105RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF105>(appDbContext, "Id"), IFF105Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_FF105?> GetByIdAsync(int in_tenant, string id)
        {
            IQueryable<CSICP_FF105> query = GetQueryBase(in_tenant);
            CSICP_FF105? cSICP_FF105 = await query.FirstOrDefaultAsync(e => e.Id == id);
            return cSICP_FF105;
        }

        private IQueryable<CSICP_FF105> GetQueryBase(int in_tenant)
        {
            return from ff105 in _appDbContext.OsusrE9aCsicpFf105s
                   .AsNoTracking()
                   where ff105.TenantId == in_tenant
                   select new CSICP_FF105
                   {
                       TenantId = ff105.TenantId,
                       Id = ff105.Id,
                       Ff105Filialid = ff105.Ff105Filialid,
                       Ff105Descricaobordero = ff105.Ff105Descricaobordero,
                       Ff105ClienteInicial = ff105.Ff105ClienteInicial,
                       Ff105ClienteFinal = ff105.Ff105ClienteFinal,
                       Ff105EmissaoInicial = ff105.Ff105EmissaoInicial,
                       Ff105EmissaoFinal = ff105.Ff105EmissaoFinal,
                       Ff105VenctoInicial = ff105.Ff105VenctoInicial,
                       Ff105VenctoFinal = ff105.Ff105VenctoFinal,
                       Ff105CodgcategIni = ff105.Ff105CodgcategIni,
                       Ff105CodgcategFim = ff105.Ff105CodgcategFim,
                       Ff105CodgrotaIni = ff105.Ff105CodgrotaIni,
                       Ff105CodgrotaFim = ff105.Ff105CodgrotaFim,
                       Ff105ValorMinimo = ff105.Ff105ValorMinimo,
                       Ff105Agcobradorid = ff105.Ff105Agcobradorid,
                       Ff105Tipocobrancaid = ff105.Ff105Tipocobrancaid,
                       Ff105InstCobranca1 = ff105.Ff105InstCobranca1,
                       Ff105InstCobranca2 = ff105.Ff105InstCobranca2,
                       Ff105Agencia = ff105.Ff105Agencia,
                       Ff105AgenciaDv = ff105.Ff105AgenciaDv,
                       Ff105ContaCorrente = ff105.Ff105ContaCorrente,
                       Ff105ContaDv = ff105.Ff105ContaDv,
                       Ff105DataEnvio = ff105.Ff105DataEnvio,
                       Ff105ValorBordero = ff105.Ff105ValorBordero,
                       Ff105QtdTitulos = ff105.Ff105QtdTitulos,
                       Ff105Fechado = ff105.Ff105Fechado,
                       Ff105IsActive = ff105.Ff105IsActive,
                       Ff105Status = ff105.Ff105Status,
                       Ff105Protocolnumber = ff105.Ff105Protocolnumber,
                       Ff105ApiId = ff105.Ff105ApiId,
                       Ff105Statusapi = ff105.Ff105Statusapi,
                       Ff105DataCriacao = ff105.Ff105DataCriacao,
                   };
        }

        public async Task<(List<CSICP_FF105>, int)> GetListAsync(int in_tenant, int in_page, int in_pageSize, 
            string? in_estabID, string? in_descBordero, string? in_agCobradorID, DateTime? in_dataInicio, DateTime? in_dataFinal)

        {
            IQueryable<CSICP_FF105> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_estabID, in_descBordero, in_agCobradorID, in_dataInicio, in_dataFinal, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_page, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_FF105> FiltraQuandoExisteFiltro(string? in_estabID, string? in_descBordero, string? in_agCobradorID, 
            DateTime? in_dataInicio, DateTime? in_dataFinal, IQueryable<CSICP_FF105> query)
        {
            if (in_estabID != null)
                query = query.Where(e => e.Ff105Filialid!.Equals(in_estabID));
            if (in_descBordero != null)
                query = query.Where(e => e.Ff105Descricaobordero!.Contains(in_descBordero));
            if (in_agCobradorID != null)
                query = query.Where(e => e.Ff105Agcobradorid!.Equals(in_agCobradorID));
            if (in_dataInicio.HasValue)
                query = query.Where(e => e.Ff105EmissaoInicial >= in_dataInicio.Value);
            if (in_dataFinal.HasValue)
                query = query.Where(e => e.Ff105EmissaoFinal <= in_dataFinal.Value);
            return query;
        }
    }
}