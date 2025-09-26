using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.GG.Repository.GG._05X.Coleta
{
    public interface IColetaBipagemRepo
    {
        Task<DtoColetaBipagem?> GetColetaBipagemExecutar(int InTenantID, PrmsColetaBipagem prmsColeta);

    }
}
