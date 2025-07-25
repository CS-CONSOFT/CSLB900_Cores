using CSCore.Domain;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Compartilhado.Utilidade.SiteProperties
{
    public class VerificaSiteProperties(AppDbContext appDbContext) : IVerificaSiteProperties
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<bool> VerificaAsync(int tenant, string identificacao)
        {
            try
            {
                var siteProperties = from _aa001 in _appDbContext.OsusrE9aCsicpAa001s
                                     where _aa001.Aa001Identificacao == identificacao && _aa001.TenantId == tenant
                                     select new CSICP_AA001
                                     {
                                         Id = _aa001.Id,
                                         Aa001Conteudo = _aa001.Aa001Conteudo,
                                     };
                CSICP_AA001? aa001 = await siteProperties.FirstOrDefaultAsync();
                return bool.Parse(aa001 is null ? "false" : aa001.Aa001Conteudo is null ? "false" : aa001.Aa001Conteudo);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}
