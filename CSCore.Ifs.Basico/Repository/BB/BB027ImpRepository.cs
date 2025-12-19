using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.Basico.Repository.BB
{
    public class BB027ImpRepository : RepositorioBaseImplV2<CSICP_Bb027Imp>, IBB027ImpRepository
    {
        private readonly AppDbContext _appDbContext;

        public BB027ImpRepository(AppDbContext appDbContext)
            : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task<CSICP_Bb027Imp?> GetByIdAsync(int InTenantID, string InBB027ImpID)
        {
            return await CreateBaseQuery(InTenantID)
                .Where(e => e.Bb027bId == InBB027ImpID)
                .FirstOrDefaultAsync();
        }

        public async Task<(List<CSICP_Bb027Imp>, int)> GetListAsync(int InTenantID, PrmFiltrosBB027Imp prm)
        {
            IQueryable<CSICP_Bb027Imp> query = CreateBaseQuery(InTenantID);
            // Aplica filtros
            if (!string.IsNullOrEmpty(prm.BB027ID))
            {
                query = query.Where(e => e.Bb027Id == prm.BB027ID);
            }
            var queryCount = query;
            var count = queryCount.Count();
            query = query.OrderBy(e => e.Bb027Id);
            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_Bb027Imp> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb027Imps
                .AsSplitQuery()
                .AsNoTracking()
                // Navegações existentes básicas
                .Include(e => e.NavBB027bModbc)
                .Include(e => e.NavBB027bMotdesoneracao)
                .Include(e => e.NavBB027ImpTransacao)
                .Include(e => e.NavBB027ImpRegime)
                .Include(e => e.NavBB027ImpOrigem)
                .Include(e => e.NavBB027ImpCstIcms)
                .Include(e => e.NavBB027ImpCstIpi)
                .Include(e => e.NavBB027ImpCstPis)
                .Include(e => e.NavBB027ImpNatBcCredPis)
                .Include(e => e.NavBB027ImpCstCofins)
                .Include(e => e.NavBB027ImpNatBcCredCofins)
                .Include(e => e.NavBB027ImpUfDest)
                .Include(e => e.NavBB027ImpClasseConta)
                .Include(e => e.NavBB027ImpModalbcIcmsSt)
                .Include(e => e.NavBB027ImpMp255)
                .Include(e => e.NavBB027ImpCFOPStatica)
                .Include(e => e.NavBB027ImpCenquadIpi)
                .Include(e => e.NavBB027ImpVicmsdesonSub)
                .Include(e => e.NavBB027ImpIndpres)
                .Include(e => e.NavBB027ImpRfClasstrib)
                .Include(e => e.NavBB027ImpRflc)
                .Include(e => e.NavBB027ImpTpDebCre)
                .Include(e => e.NavBB027ImpRfClasstrib2)
                .Include(e => e.NavBB027ImpCCredPre)
                .Where(e => e.TenantId == tenant);
        }

        public Task CommitToDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
