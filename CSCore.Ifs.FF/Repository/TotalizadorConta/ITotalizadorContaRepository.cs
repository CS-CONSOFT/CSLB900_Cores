using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.TotalizadorConta
{
    public interface ITotalizadorContaRepository
    {
        Task<DtoTotalizadorConta> GetTotalizadorContaAsync(int in_tenantID, string in_contaID,
            int in_StIDTpCobranca, int in_StIDFF102SitAberto, int in_StIDFF102SitBxParcial);
    }
}
