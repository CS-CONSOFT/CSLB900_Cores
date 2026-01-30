using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSCore.Domain.Interfaces.SY.ABAC;
using CSCore.Ifs.Compartilhado;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.LB900.ABAC.Repository
{

    public class SY030RepositoryImpl : RepositoryBaseV2ComGets<OsusrE9aCsicpSy030>
    {
        public SY030RepositoryImpl(AppDbContext appDbContext, string IdIdentifierName = "Id", string TenantIdentifierName = "TenantId") : base(appDbContext, IdIdentifierName, TenantIdentifierName)
        {
        }

        public async Task<IEnumerable<string>> GetAtributosDeUsuarioAPartirDaSY030(int InTenantID, string InUserID)
        {
            return await (from sy031 in _appDbContext.OsusrE9aCsicpSy031s
                        where sy031.TenantId == InTenantID && sy031.Sy031Usuarioid == InUserID
                          join sy030 in _appDbContext.OsusrE9aCsicpSy030s
                        on sy031.Sy031Grupoid equals sy030.Id
                        where sy030.Sy030Isactive == true
                        select sy030.Sy030Name).ToListAsync();
        }
    }
}
