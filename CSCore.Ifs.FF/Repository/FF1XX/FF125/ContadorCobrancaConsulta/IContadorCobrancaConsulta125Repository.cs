using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF125.ContadorCobrancaConsulta
{
    public interface IContadorCobrancaConsulta125Repository
    {
        Task<ListRepoDtoContadorCobrancaConsulta> CalcularContadorCobrancaConsulta( int InTenantID);
    }
}
