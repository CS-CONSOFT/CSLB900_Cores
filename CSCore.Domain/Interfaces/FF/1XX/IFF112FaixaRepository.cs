using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF112FaixaRepository : IRepositorioBase<CSICP_FF112Faixa>
    {
        Task<CSICP_FF112Faixa?> GetByIdAsync(int in_tenant, string in_ff112FaixaId);
        Task<(List<CSICP_FF112Faixa>, int)> GetListAsync(
            int in_tenant, int in_pageNumber, int in_pageSize, string in_ff112Id);
    }
}
