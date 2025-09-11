using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF132Repository : IRepositorioBase<CSICP_FF132>
    {
        Task<(List<CSICP_FF132>, int)> GetListAsync(int in_tenant, long in_ff131Id, int in_pageNumber, int in_pageSize);
        Task ProcessarTomadorDeDivida(int in_tenant, long in_ff131Id);
    }
}
