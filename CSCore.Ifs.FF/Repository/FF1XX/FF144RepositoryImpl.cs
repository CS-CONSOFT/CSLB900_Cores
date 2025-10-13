using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF144RepositoryImpl : RepositorioBaseImpl<CSICP_FF144>, IFF144Repository
    {
        public FF144RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Ff144Id")
        {

        }  
    }
}
