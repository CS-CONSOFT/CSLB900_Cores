using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.EstaticasLabel.GG;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.GG._05X.Coleta;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._05X.GG055
{
    public class ColetaBipagemRepo : IColetaBipagemRepo
    {
        private readonly AppDbContext _appDbContext;
        public ColetaBipagemRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<DtoColetaBipagem?> GetColetaBipagemExecutar(int InTenantID, PrmsColetaBipagem prmsColeta)
        {
            var produtos = await GetProdutosColeta(InTenantID, prmsColeta);
            
            if (produtos == null || !produtos.Any())
                return null;

            return produtos.FirstOrDefault();
        }

        private async Task<List<DtoColetaBipagem>> GetProdutosColeta(int InTenantID, PrmsColetaBipagem prmsColeta)
        {
            var query = from gg008 in _appDbContext.OsusrE9aCsicpGg008s // Ajustar nomes conforme seu contexto
                        
                        join gg008Kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes 
                        on gg008.Id equals gg008Kdx.Gg008Produtoid

                        join gg019 in _appDbContext.OsusrE9aCsicpGg019s 
                        on gg008.Id equals gg019.Gg019Produtoid

                        where gg008.TenantId == InTenantID
                           && gg008.Gg008IsActive == true
                           && gg008Kdx.Gg008Filialid == prmsColeta.FilialBB001ID
                           && gg019.Gg019Codbarrasalfa == prmsColeta.CodgBarras
                        orderby gg008.Gg008Descreduzida

                        select new DtoColetaBipagem
                        {
                            UNVendaVarejoID = gg008Kdx.Gg008Unvendavarejoid
                        };

            return await query.ToListAsync();
        }
    }
}
