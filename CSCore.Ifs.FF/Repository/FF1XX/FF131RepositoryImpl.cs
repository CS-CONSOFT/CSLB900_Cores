using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using NPOI.OpenXmlFormats.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF119;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF131RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF131>(appDbContext, "Ff131Id"), IFF131Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_FF131?> GetByIdAsync(int in_tenant, long in_ff131Id)
        {
            IQueryable<CSICP_FF131> query = GetQueryBase(in_tenant);
            CSICP_FF131? cSICP_FF131 = await query.FirstOrDefaultAsync(e => e.Ff131Id == in_ff131Id);
            return cSICP_FF131;
        }

        private IQueryable<CSICP_FF131> GetQueryBase(int in_tenant)
        {
            return from ff131 in _appDbContext.OsusrE9aCsicpFf131s
                   .AsNoTracking()

                   where ff131.TenantId == in_tenant
                   select new CSICP_FF131
                   {
                       TenantId = ff131.TenantId,
                       Ff131Id = ff131.Ff131Id,
                       Ff131Filialid = ff131.Ff131Filialid,
                       Ff131Dregistro = ff131.Ff131Dregistro,
                       Ff131Contaid = ff131.Ff131Contaid,
                       Ff131TomadorContaid = ff131.Ff131TomadorContaid,
                       Ff131Usuarioid = ff131.Ff131Usuarioid,
                       Ff131Observacao = ff131.Ff131Observacao,
                       Ff131Isefetivado = ff131.Ff131Isefetivado,
                       Ff131Protocolo = ff131.Ff131Protocolo
                   };
        }

        public async Task<(List<CSICP_FF131>, int)> GetListAsync(int in_tenant, int in_pageNumber, int in_pageSize, string? in_estabId,
            DateTime? in_periodoInicial, DateTime? in_periodoFinal, string? in_protocolo, string? in_nomeContaCliente)
        {
            IQueryable<CSICP_FF131> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_estabId, in_periodoInicial, in_periodoFinal, in_protocolo, in_nomeContaCliente, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_FF131> FiltraQuandoExisteFiltro(string? in_estabId, DateTime? in_periodoInicial, DateTime? in_periodoFinal, string? in_protocolo, string? in_nomeContaCliente, IQueryable<CSICP_FF131> query)
        {
            if (!string.IsNullOrEmpty(in_estabId))
                query = query.Where(e => e.Ff131Filialid == in_estabId);

            return query;
        }
    }
}
