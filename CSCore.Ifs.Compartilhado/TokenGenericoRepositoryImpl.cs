using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.Interfaces;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Compartilhado
{
    public class TokenGenericoRepositoryImpl(AppDbContext appDbContext) : ITokenGenericoRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_AA030?> GetTokenGenericoPorLabel(string Token, int Tenant)
        {
            CSICP_Aa030Tptoken CurrentToken = await GetTpTokenPorLabel(Token);

            CSICP_AA030? CurrentAA030 = await _appDbContext.OsusrE9aCsicpAa030Tokens
                .Include(e => e.Aa030Tptoken)
                .Where(e => e.Aa030Tptokenid == CurrentToken.Id)
                .Where(e => e.TenantId == Tenant)
                .OrderByDescending(e => e.Aa030Descricao).FirstOrDefaultAsync();

            return CurrentAA030;
        }


        public async Task<CSICP_AA030?> GetTokenGenericoPorEstabelecimento(string? EstabelecimentoID, string Token, int Tenant)
        {
            CSICP_Aa030Tptoken CurrentToken = await GetTpTokenPorLabel(Token);

            IOrderedQueryable<CSICP_AA030> query = _appDbContext.OsusrE9aCsicpAa030Tokens
                .Include(e => e.Aa030Tptoken)
                .Where(e => e.Aa030Tptokenid == CurrentToken.Id)
                .Where(e => e.Aa030Estabid == EstabelecimentoID)
                .Where(e => e.TenantId == Tenant)
                .OrderByDescending(e => e.Aa030Descricao);

            if (EstabelecimentoID != null) query.Where(e => e.Aa030Estabid == EstabelecimentoID);


            CSICP_AA030? CurrentAA030 = await query.FirstOrDefaultAsync();

            return CurrentAA030;
        }

        public async Task<List<CSICP_Aa030Tptoken>> GetEstaticasToken()
        {
            return await _appDbContext.E9ACSICP_AA030TPToken
                .Where(e => e.IsActive == true).ToListAsync();
        }


        private async Task<CSICP_Aa030Tptoken> GetTpTokenPorLabel(string Token)
        {
            return await _appDbContext.E9ACSICP_AA030TPToken
                .Where(e => e.Label == Token)
                .Where(e => e.IsActive == true).FirstOrDefaultAsync() ?? throw new Exception("Token Inexistente");
        }
    }

}