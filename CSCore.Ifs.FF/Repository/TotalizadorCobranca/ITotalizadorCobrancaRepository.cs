using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.TotalizadorCobranca
{
    public interface ITotalizadorCobrancaRepository
    {
        Task<DtoTotalizadorCobranca> GetTotalizadorCobrancaAsync(int in_tenantID, string in_contaID);
    }
}
