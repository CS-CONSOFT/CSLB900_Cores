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

namespace CSCore.Ifs.FF.Repository
{
    public class FF005RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF005>(appDbContext, "Id"), IFF005Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_FF005?> GetByIdAsync(int tenant, string id)
        {
            IQueryable<CSICP_FF005> query = GetQueryBase(tenant);
            CSICP_FF005? cSICP_FF005 = await query.FirstOrDefaultAsync(e => e.Id == id);
            return cSICP_FF005;
        }

        public async Task<(List<CSICP_FF005>, int)> GetListAsync(int tenant, string? filialId, int page, int pageSize)
        {
            IQueryable<CSICP_FF005> query = GetQueryBase(tenant);
            query = FiltraQuandoExisteFiltro(filialId, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(page, pageSize);

            return(await query.ToListAsync(), count);
        }

        private static IQueryable<CSICP_FF005> FiltraQuandoExisteFiltro(string? filialId, IQueryable<CSICP_FF005> query)
        {
            if (filialId != null)
                query = query.Where(e => e.Ff005Filialid!.Equals(filialId));
            return query;
        }

        private IQueryable<CSICP_FF005> GetQueryBase(int tenant)
        {
            return from ff005 in _appDbContext.OsusrE9aCsicpFf005s

            join ff003 in _appDbContext.OsusrE9aCsicpFf003s
            on ff005.Ff003Especieid equals ff003.Id into ff003_ff005_join
            from ff003 in ff003_ff005_join.DefaultIfEmpty()

            join ff003TpEsp in _appDbContext.OsusrE9aCsicpFf003Tpesps
            on ff005.Ff005Tipo equals ff003TpEsp.Id into ff003TpEsp_ff005_join
            from ff003TpEsp in ff003TpEsp_ff005_join.DefaultIfEmpty()

            join aa037Imp in _appDbContext.E9ACSICP_AA037Imps
            on ff005.Ff005ImpostoId equals aa037Imp.Id into aa037Imp_ff005_join
            from aa037Imp in aa037Imp_ff005_join.DefaultIfEmpty()

            where ff005.TenantId == tenant

            select new CSICP_FF005
            {
                TenantId = ff005.TenantId,
                Id = ff005.Id,
                Ff005Filialid = ff005.Ff005Filialid,
                Ff005Tipo = ff005.Ff005Tipo,
                Ff003Especieid = ff005.Ff003Especieid,
                Ff005Sequencia = ff005.Ff005Sequencia,
                Ff005Contafornid = ff005.Ff005Contafornid,
                Ff005Diavencimento = ff005.Ff005Diavencimento,
                Ff005Pfx = ff005.Ff005Pfx,
                Ff005ImpostoId = ff005.Ff005ImpostoId,

                NavFF003 = ff003 != null ? new CSICP_FF003
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
                } : null,

                NavFF003TpEsp = ff003TpEsp != null ? new OsusrE9aCsicpFf003Tpesp
                {
                    Id = ff003TpEsp.Id,
                    Label = ff003TpEsp.Label,
                    Order = ff003TpEsp.Order,
                    IsActive = ff003TpEsp.IsActive,
                    IdPdv = ff003TpEsp.IdPdv,
                } : null,

                NavAA037Imp = aa037Imp != null ? new CSICP_AA037Imp
                {
                    Id = aa037Imp.Id,
                    Label = aa037Imp.Label,
                    Order = aa037Imp.Order,
                    IsActive = aa037Imp.IsActive,
                } : null
            };
        }
    }
}
