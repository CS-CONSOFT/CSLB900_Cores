using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.LB900
{
    public static class Verifica_ConfirmAutomatico
    {
        public static async Task<bool> Verifica(string In_FilialID, int In_TenantID, AppDbContext _appDbContext)
        {
            CSICP_FF000? WorkFF000 = await _appDbContext.OsusrE9aCsicpFf000s
                .Where(e => e.Ff000EstabId == In_FilialID && e.TenantId == In_TenantID)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            return WorkFF000 == null ? false : WorkFF000.Ff000Isdesabfcconfaut ?? false;
        }
    }
}
