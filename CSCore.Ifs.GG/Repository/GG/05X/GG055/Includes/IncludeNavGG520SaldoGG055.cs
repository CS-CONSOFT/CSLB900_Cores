using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._05X.GG055.Includes
{
    internal class IncludeNavGG520SaldoGG055 : ICSInclude<CSICP_GG055>
    {
        private readonly string? _includeProperty;
        public IncludeNavGG520SaldoGG055(string? includeProperty = null)
        {
            _includeProperty = includeProperty;
        }

        public IQueryable<CSICP_GG055> ApplyIncludes(IQueryable<CSICP_GG055> query)
        {
            return query.Include(e => e.Nav_GG520Saldo);
        }
    }
}
