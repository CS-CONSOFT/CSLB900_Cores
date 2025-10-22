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
    public interface IFF136RespositoryImpl : IRepositorioBase<CSICP_FF136>
    {
    }
    public class FF136RespositoryImpl : RepositorioBaseImpl<CSICP_FF136>, IFF136RespositoryImpl
    {
        private AppDbContext AppDbContext;

        public FF136RespositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Ff136RegccredId")
        {
            AppDbContext = appDbContext;
        }
    }
}
