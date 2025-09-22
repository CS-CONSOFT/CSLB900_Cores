using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF._1XX.FF126
{
    public interface IFF126Repository
    {
        Task<string> GetFF126IdPeloTituloFF102(int InTenantID, string InFF102_ID);
    }
}
