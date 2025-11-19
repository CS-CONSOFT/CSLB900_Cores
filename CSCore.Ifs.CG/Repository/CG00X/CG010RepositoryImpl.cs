using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.CS_QueryFilters.GG032;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.CG.Repository.CG00X
{
    public interface ICG010Repository : IRepositorioBase<CSICP_CG010>
    {
        Task<CSICP_CG010?> GetByIdComFiltrosAsync(int InTenantID, string In_Cta_Ctb_id, int InAno, DateTime? InData, string TipoSaldo);
    }
    public class CG010RepositoryImpl :RepositorioBaseImpl<CSICP_CG010>, ICG010Repository
    {
        private readonly AppDbContext appDbContext;

        public CG010RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg010Id")
        {
            this.appDbContext = appDbContext;
        }

        public async Task <CSICP_CG010?> GetByIdComFiltrosAsync(int InTenantID, string In_Cta_Ctb_id, int InAno, DateTime? InData, string TipoSaldo)
        {
            var query = appDbContext.Osusr8dwCsicpCg010s
              .Where(e => e.Cg010ContaId == In_Cta_Ctb_id 
              && e.TenantId == InTenantID 
              && e.Cg010Ano == InAno 
              && e.Cg010Dia == InData
              && e.Cg010TipoSaldoId == TipoSaldo);

            return await query.FirstOrDefaultAsync();
        }
    }
}
