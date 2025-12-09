using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG06X.CG062;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG06X.CG062
{
    public class CG062RepositoryImpl : RepositorioBaseImplV2<Osusr8dwCsicpCg062>, ICG062Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG062RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg062Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<Osusr8dwCsicpCg062?> GetByIdAsync(int InTenantID, long InCG062ID)
        {
            return await _appDbContext.Osusr8dwCsicpCg062s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Cg062Id == InCG062ID)
                .Include(e => e.NavCG005HistDeb_CG062)
                .Include(e => e.NavCG005HistCred_CG062)
                .Include(e => e.NavCG006ContaDeb_CG062)
                .Include(e => e.NavCG006ContaCred_CG062)
                .Include(e => e.NavCG011CtaGerencial_DebN2ID)
                .Include(e => e.NavCG011CtaGerencial_DebN3ID)
                .Include(e => e.NavCG011CtaGerencial_DebN4ID)
                .Include(e => e.NavCG011CtaGerencial_CredN2ID)
                .Include(e => e.NavCG011CtaGerencial_CredN3ID)
                .Include(e => e.NavCG011CtaGerencial_CredN4ID)
                .Include(e => e.NavCG060RegramentoID_CG062)
                .Include(e => e.NavCG054EventoValorTpID_CG062)
                .Include(e => e.NavCG054EventoValorTpDebID_CG062)
                .Include(e => e.NavCG054EventoValorTpCredID_CG062)
                .FirstOrDefaultAsync();
        }
        public async Task<(List<Osusr8dwCsicpCg062>, int)> GetListAsync(
            int InTenantID,
            int InPageNumber,
            int InPageSize)
        {
            IQueryable<Osusr8dwCsicpCg062> query = _appDbContext.Osusr8dwCsicpCg062s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID);

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.OrderByDescending(e => e.Cg062Id);
            query = query.PaginacaoNoBanco(InPageNumber, InPageSize);

            return (await query.ToListAsync(), count);
        }

        public async Task<int> CriarValoresCG062Async(int InTenantID, long InCG060ID, long? InCG050EventoID = null)
        {
            // 1. Verifica se CG060 existe e obtém o EventoID
            var eventoCg060 = await _appDbContext.Osusr8dwCsicpCg060s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Cg060Id == InCG060ID)
                .FirstOrDefaultAsync();

            if (eventoCg060 == null)
                throw new KeyNotFoundException($"Regramento CG060 com ID {InCG060ID} não encontrado.");

            // 2. Obtém a lista de CG054 (parâmetros/origem de valores)
            // Filtro: cg054_EventoTpID = cg060_EventoID
            var queryCg054 = _appDbContext.Osusr8dwCsicpCg054s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID 
                && e.Cg054Eventotpid == eventoCg060.Cg060Eventoid);

            var listaCg054 = await queryCg054.ToListAsync();

            if (!listaCg054.Any())
            {
                throw new KeyNotFoundException(
                $"Nenhum parâmetro CG054 encontrado para o Evento ID {eventoCg060.Cg060Eventoid} do Regramento CG060 ID {InCG060ID}.");
            }

            // 3. Para cada CG054 da lista, verifica se já existe CG062 e cria se necessário
            int registrosCriados = 0;
            foreach (var itemCg054 in listaCg054)
            {
                // Verifica se já existe um CG062 para este CG060 + CG054
                var existeCG062 = await _appDbContext.Osusr8dwCsicpCg062s
                    .AnyAsync(e => e.TenantId == InTenantID
                                && e.Cg062Regramentoid == InCG060ID
                                && e.Cg062Eventovalortpid == itemCg054.Cg054Id);

                // Se já existe, pula para o próximo (não cria duplicado)
                if (existeCG062)
                    continue;

                // Assign conforme OutSystems:
                // V_Rec_cg062.cg062_RegramentoID = Prm_CG060_ID
                // V_Rec_cg062.cg062_EventoValorTpID = Get_cg054.List.Current.csicp_cg054.cg054_Id
                var novoCg062 = new Osusr8dwCsicpCg062
                {
                    TenantId = InTenantID,
                    Cg062Regramentoid = InCG060ID,
                    Cg062Eventovalortpid = itemCg054.Cg054Id
                };

                _appDbContext.Osusr8dwCsicpCg062s.Add(novoCg062);
                registrosCriados++;
            }
                await _appDbContext.SaveChangesAsync();
                return registrosCriados;
        }
    }
    
}