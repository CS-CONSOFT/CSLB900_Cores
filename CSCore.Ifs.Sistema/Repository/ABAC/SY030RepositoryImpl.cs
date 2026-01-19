using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSCore.Domain.Interfaces.SY.ABAC;
using CSCore.Ifs.Compartilhado;
using CSCore.Ifs.CS_Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.Sistema.Repository.ABAC
{

    public class SY030RepositoryImpl : RepositoryBaseV2ComGets<OsusrE9aCsicpSy031>
    {
        public SY030RepositoryImpl(AppDbContext appDbContext, string IdIdentifierName = "Id", string TenantIdentifierName = "TenantId") : base(appDbContext, IdIdentifierName, TenantIdentifierName)
        {
        }

        public async Task<OsusrE9aCsicpSy031> GetAtributosDeUsuarioAPartirDaSY030(int InTenantID)
        {

        }
        
    }
}
