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
            return await _appDbContext.OsusrE9aCsicpBb027Imps
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Bb027Id == InBB027ImpID)
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
                .Include(e => e.NavBB027bFcalcicmsdes)
                .Include(e => e.NavBB027bModbc)
                .Include(e => e.NavBB027bMotdesoneracao)
                // Navegações para CSICP_Statica
                .Include(e => e.NavBB027ImpBaixaEstoque)
                .Include(e => e.NavBB027ImpGeraCReceber)
                .Include(e => e.NavBB027ImpAtualizaPrCompra)
                .Include(e => e.NavBB027ImpCalcSubstituicao)
                .Include(e => e.NavBB027ImpCalculaISS)
                .Include(e => e.NavBB027ImpAgregaSubsTrib)
                .Include(e => e.NavBB027ImpDIFA)
                .Include(e => e.NavBB027ImpICST)
                .Include(e => e.NavBB027ImpIRRF)
                .Include(e => e.NavBB027ImpPIS)
                .Include(e => e.NavBB027ImpCOFINS)
                .Include(e => e.NavBB027ImpIRPJ)
                .Include(e => e.NavBB027ImpICMSDiferido)
                .Include(e => e.NavBB027ImpGeraEstatistica)
                .Include(e => e.NavBB027ImpCalcAjusteICMS)
                .Include(e => e.NavBB027ImpCalcIS)
                // Navegações para outras tabelas BB027
                .Include(e => e.NavBB027ImpEntsai)
                .Include(e => e.NavBB027ImpCalcICMS)
                .Include(e => e.NavBB027ImpCalcIPI)
                .Include(e => e.NavBB027ImpSomaIPIBaseICMS)
                .Include(e => e.NavBB027ImpIPIBruto)
                .Include(e => e.NavBB027ImpBaseICMSBrutaLiq)
                .Include(e => e.NavBB027ImpBaseSubsBrutaLiq)
                // Navegações para SPED
                .Include(e => e.NavBB027ImpCFOPStatica)
                .Include(e => e.NavBB027ImpCFOPForaEstado)
                .Include(e => e.NavBB027ImpCodgAjusteICMS)
                // Navegação para BB027 pai (transação principal)
                .Include(e => e.NavBB027ImpTransacao)
                // Navegação para Regime
                .Include(e => e.NavBB027ImpRegime)
                .Where(e => e.TenantId == tenant);
        }
    }
}
