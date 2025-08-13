using CSCore.Domain;
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
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF131;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF131RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF131>(appDbContext, "Ff131Id"), IFF131Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<RepoDtoCSICP_FF131?> GetByIdAsync(int in_tenant, long in_ff131Id)
        {
            IQueryable<RepoDtoCSICP_FF131> query = GetQueryBase(in_tenant);
            RepoDtoCSICP_FF131? cSICP_FF131 = await query.FirstOrDefaultAsync(e => e.Ff131Id == in_ff131Id);
            return cSICP_FF131;
        }

        private IQueryable<RepoDtoCSICP_FF131> GetQueryBase(int in_tenant)
        {
            return from ff131 in _appDbContext.OsusrE9aCsicpFf131s
                   .AsNoTracking()

                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff131.Ff131Filialid equals bb001.Id into bb001_ff131_join
                   from bb001 in bb001_ff131_join.DefaultIfEmpty()

                   join bb012Conta in _appDbContext.OsusrE9aCsicpBb012s
                   on ff131.Ff131Contaid equals bb012Conta.Id into bb012Conta_ff131_join
                   from bb012Conta in bb012Conta_ff131_join.DefaultIfEmpty()

                   join bb012TomadorConta in _appDbContext.OsusrE9aCsicpBb012s
                   on ff131.Ff131TomadorContaid equals bb012TomadorConta.Id into bb012TomadorConta_ff131_join
                   from bb012TomadorConta in bb012TomadorConta_ff131_join.DefaultIfEmpty()

                   join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                   on ff131.Ff131Usuarioid equals sy001.Id into sy001_ff131_join
                   from sy001 in sy001_ff131_join.DefaultIfEmpty()

                   where ff131.TenantId == in_tenant
                   select new RepoDtoCSICP_FF131
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
                       Ff131Protocolo = ff131.Ff131Protocolo,

                       NavBB001Filial = bb001 != null ? new CSICP_BB001
                       {
                           TenantId = bb001.TenantId,
                           Id = bb001.Id,
                           Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                           Bb001Razaosocial = bb001.Bb001Razaosocial,
                       } : null,

                       NavBB012Conta = bb012Conta != null ? new CSICP_BB012
                       {
                           TenantId = bb012Conta.TenantId,
                           Id = bb012Conta.Id,
                           Bb012Codigo = bb012Conta.Bb012Codigo,
                           Bb012Descricao = bb012Conta.Bb012Descricao,
                       } : null,

                       NavBB012TomadorConta = bb012TomadorConta != null ? new CSICP_BB012
                       {
                           TenantId = bb012TomadorConta.TenantId,
                           Id = bb012TomadorConta.Id,
                           Bb012Codigo = bb012TomadorConta.Bb012Codigo,
                           Bb012Descricao = bb012TomadorConta.Bb012Descricao,
                       } : null,

                       NavSy001Usuario = sy001 != null ? new Csicp_Sy001
                       {
                           TenantId = sy001.TenantId,
                           Id = sy001.Id,
                           Sy001Nome = sy001.Sy001Nome,
                           Sy001Email = sy001.Sy001Email,
                       } : null
                   };
        }

        public async Task<(List<RepoDtoCSICP_FF131>, int)> GetListAsync(int in_tenant, int in_pageNumber, int in_pageSize, 
            string? in_estabId, DateTime? in_periodoInicial, DateTime? in_periodoFinal, string? in_protocolo, string? in_nomeContaCliente)
        {
            IQueryable<RepoDtoCSICP_FF131> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_estabId, in_periodoInicial, in_periodoFinal, in_protocolo, in_nomeContaCliente, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<RepoDtoCSICP_FF131> FiltraQuandoExisteFiltro(string? in_estabId, DateTime? in_periodoInicial,
            DateTime? in_periodoFinal, string? in_protocolo, string? in_nomeContaCliente, IQueryable<RepoDtoCSICP_FF131> query)
        {
            if (!string.IsNullOrEmpty(in_estabId))
                query = query.Where(e => e.Ff131Filialid == in_estabId);

            if (in_periodoInicial.HasValue)
                query = query.Where(e => e.Ff131Dregistro >= in_periodoInicial.Value);

            if (in_periodoFinal.HasValue)
                query = query.Where(e => e.Ff131Dregistro <= in_periodoFinal.Value);

            if (!string.IsNullOrEmpty(in_protocolo))
                query = query.Where(e => e.Ff131Protocolo != null && e.Ff131Protocolo.Contains(in_protocolo));

            if (!string.IsNullOrEmpty(in_nomeContaCliente))
                query = query.Where(e => e.Ff131Contaid != null && e.Ff131Contaid.Contains(in_nomeContaCliente));
            return query;
        }
    }
}
