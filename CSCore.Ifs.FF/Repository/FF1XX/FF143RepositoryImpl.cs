using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public interface IFF143Repository : IRepositorioBase<CSICP_FF143>
    {
    }
    public class FF143RepositoryImpl : RepositorioBaseImpl<CSICP_FF143>, IFF143Repository
    {
        public FF143RepositoryImpl(AppDbContext context) : base(context)
        {
        }
    }
}
