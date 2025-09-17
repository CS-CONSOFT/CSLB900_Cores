using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF127
{
    public interface IAtualizarFF127Repository
    {
        Task<bool> Atualiza_FF127(PrmAtualizaFF127Repository prmAtualizaFF126Repository);
    }
}
