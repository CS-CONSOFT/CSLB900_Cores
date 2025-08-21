using CSCore.Domain.CS_Models.CSICP_DD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.EnviaNFeHercules.Repository.DD000
{
   public interface IDD000Repository
    {
        Task<CSICP_DD000> GetCertificadoESenha(int in_tenant, string in_estabID);
    }
}
