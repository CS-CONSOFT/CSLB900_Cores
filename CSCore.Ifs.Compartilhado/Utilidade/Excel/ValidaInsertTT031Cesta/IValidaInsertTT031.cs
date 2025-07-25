using CSCore.Domain.CS_Models.CSICP_TT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.Compartilhado.Utilidade.Excel.ValidaInsertTT031Cesta
{
    public interface IValidaInsertTT031
    {
        Task<CSICP_TT031> Validar(
            int in_tenant,
            long in_tt030_id,
            string codgProduto, decimal? qtdProduto, decimal? valorProduto, decimal? descProduto, string in_estabId);
    }
}
