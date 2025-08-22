using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.EnviaNFeHercules.Repository.DD000
{
    public class DD000RepositoryImpl : IDD000Repository
    {
        private readonly AppDbContext _appDbContext;

        public DD000RepositoryImpl(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<CSICP_DD000> GetCertificadoESenha(int in_tenant, string in_estabID)
        {
            CSICP_DD000? WorkCSICP_DD000 = await _appDbContext.OsusrTeiCsicpDd000s
                .Where(e => e.TenantId == in_tenant && e.Dd000FilialId == in_estabID)
                .Select(e => new CSICP_DD000
                {
                    Dd000Arqcertdigitalbinario = e.Dd000Arqcertdigitalbinario,
                    Dd000Senhacertdigital = e.Dd000Senhacertdigital
                }).FirstOrDefaultAsync() ?? throw new KeyNotFoundException("DD000 não encontrada!");

            return WorkCSICP_DD000;
        }
    }
}
