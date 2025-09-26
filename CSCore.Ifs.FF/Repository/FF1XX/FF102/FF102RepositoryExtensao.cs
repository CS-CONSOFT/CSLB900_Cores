using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF102
{
    public partial class FF102RepositoryImpl
    {
        public async Task AtualizaCobradorFF102(int InTenantID, string InTituloID,string InNovoCobradorSY001)
        {
            Domain.CS_Models.CSICP_FF.CSICP_FF102? WorkFF102 = await this._appDbContext.OsusrE9aCsicpFf102s
                .Where(e => e.TenantId == InTenantID)
                .Where(e => e.Id == InTituloID)
                .FirstOrDefaultAsync() ?? throw new KeyNotFoundException("WorkFF102 " + HandlerReturnMessages.ENTITY_NOT_FOUND);

            WorkFF102.Ff102Codcobrador = InNovoCobradorSY001;
        }
    }
}
