using CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_GerarTituloemMassa_Cancelar
{
    public class CSGerarTItuloemMassaCancelar : ICSGerarTItuloemMassaCancelar
    {
        private readonly AppDbContext appDbContext;

        public CSGerarTItuloemMassaCancelar(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<bool> CancelarGeracaoTitulosEmMassa(int tenantId, long ff040Id, int incsicp_ff040_sit_CANCELADO)
        {
            var ff040 = await appDbContext.OsusrE9aCsicpFf040s.FindAsync(ff040Id) 
                ?? throw new KeyNotFoundException($"FF040 com TenantID {tenantId} e FF040_ID {ff040Id} não encontrada.");

            var listaFF042 = await appDbContext.OsusrE9aCsicpFf042s
                .Where(e => e.TenantId == tenantId && e.Ff040Id == ff040Id)
                .ToListAsync();

            var WorkFF104 = await appDbContext.OsusrE9aCsicpFf104s
                .Where(e => e.TenantId == tenantId && e.Ff040Id == ff040Id)
                .ToListAsync();

            var distinctFF104List = WorkFF104.DistinctBy(e => e.Ff102Id).Select(e => e.Ff102Id);


            var listaTitulos = await appDbContext.OsusrE9aCsicpFf102s
                .Where(e => e.TenantId == tenantId && distinctFF104List.Contains(e.Id))
                .ToListAsync();

            appDbContext.RemoveRange(listaFF042);
            appDbContext.RemoveRange(WorkFF104);
            appDbContext.RemoveRange(listaTitulos);

            ff040.Ff040Situacaoid = incsicp_ff040_sit_CANCELADO;

            return true;

        }
    }
}
