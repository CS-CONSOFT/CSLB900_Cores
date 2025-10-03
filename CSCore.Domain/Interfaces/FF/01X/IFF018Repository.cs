using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.Calculos.CalculoAtrasoMultaJurosTitulos;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF018;

namespace CSCore.Domain.Interfaces.FF._01X
{
    public interface IFF018Repository : IRepositorioBase<CSICP_FF018>
    {
        Task<(List<CSICP_FF018>, int)> GetListAsync(int in_tenant, string in_ff017Id, int in_pageNumber, int in_pageSize, bool? devePaginar = true);
        Task<CSICP_FF018> GetById(int in_tenant, string ID);
         Task<bool> VarrerListaECalcularJuros(CSICP_FF017 WorkFF017,ICalculoAtrasoMultaJurosTitulos calculoAtraso);
    }
}
