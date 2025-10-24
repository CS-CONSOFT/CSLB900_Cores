using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR021Repository_LoteVsAnimal.ProcessaLote
{
    public class ProcessaLoteEAtualizaPeso : IProcessaLoteEAtualizaPeso
    {
        private readonly AppDbContext _appDbContext;

        public ProcessaLoteEAtualizaPeso(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task GetExecutaProcessoLote(int InTenantID, string InRR020IDLote)
        {
            // Busca RR021 com RR001 e RR022
            var listRR021 = await GetListRR021ComRR001eRR022ByLoteIdAsync(InTenantID, InRR020IDLote);

            // Processa cada registro
            foreach (var rr021 in listRR021)
            {
                // Verifica se tem RR022 e RR001 válidos
                if (rr021.NavRR022ControlePeso_RR021 != null &&
                    rr021.NavRR001Animal_RR021 != null)
                {
                    // Busca a entidade RR001
                    var rr001Entity = await _appDbContext.OsusrTo3CsicpRr001s
                        .Where(e => e.TenantId == InTenantID && e.Id == rr021.Rr021Animalid)
                        .FirstOrDefaultAsync();

                    if (rr001Entity != null)
                    {
                        // Atualiza os campos
                        rr001Entity.Rr001Dtultpeso = rr021.NavRR022ControlePeso_RR021.Rr022Dtpeso;
                        rr001Entity.Rr001Ultpeso = rr021.NavRR022ControlePeso_RR021.Rr022Peso;

                       _appDbContext.Update(rr001Entity);
                    }
                }
            }

            // Salva as alterações
            await _appDbContext.SaveChangesAsync();
        }
    
        // Novo método implementado
        public async Task<List<OsusrTo3CsicpRr021>> GetListRR021ComRR001eRR022ByLoteIdAsync(int In_TenantID, string In_LoteRR020ID)
        {
            var query = await _appDbContext.OsusrTo3CsicpRr021s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID && e.Rr021Loteid == In_LoteRR020ID)
                .Include(e => e.NavRR001Animal_RR021)
                .Include(e => e.NavRR022ControlePeso_RR021)
                .ToListAsync();

            return query;
        }
    }
}
