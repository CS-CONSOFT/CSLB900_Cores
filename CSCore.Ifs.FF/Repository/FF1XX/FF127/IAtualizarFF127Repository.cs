using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF127
{
    public interface IAtualizarFF127Repository
    {
        Task<bool> Atualiza_FF127(PrmAtualizaFF127Repository prmAtualizaFF126Repository);
        Task<string> CriaHistoricoFF127(
            CSICP_FF125 InFF125,
            CSICP_FF126 InFF126,
            string InNovoIDFF127,
            string? InSY001ID,
            string InProtocoloFF127,
            string? InBB006CobradorID);
    }
}
