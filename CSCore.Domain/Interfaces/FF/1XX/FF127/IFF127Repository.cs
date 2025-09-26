using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_QueryFilters;
using CSCore.Domain.Interfaces.FF._1XX.FF127;
using CSCore.Domain.Interfaces.PrmFiltros.FF125;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF127Repository : IGetListBase<CSICP_FF127, PrmFiltrosFF127Repo> 
    {
    }
}
