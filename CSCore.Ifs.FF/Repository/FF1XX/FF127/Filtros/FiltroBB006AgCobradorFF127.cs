using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF127.Filtros
{
    internal class FiltroBB006AgCobradorFF127 : ICSFilter<CSICP_FF127>
    {
        private readonly string? _bb006AgCobradorID;
        public FiltroBB006AgCobradorFF127(string? bb006AgeCobradorID)
        {
            _bb006AgCobradorID = bb006AgeCobradorID;
        }
        public IQueryable<CSICP_FF127> Apply(IQueryable<CSICP_FF127> query)
        {
            if (!string.IsNullOrEmpty(_bb006AgCobradorID))
            {
                query = query.Where(e => e.Ff127AgcobradorId == _bb006AgCobradorID);
            }
            return query;
        }
    }
}
