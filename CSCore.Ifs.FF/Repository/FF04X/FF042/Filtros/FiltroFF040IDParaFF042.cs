using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF04X.FF042.Filtros
{
    internal class FiltroFF040IDParaFF042 : ICSFilter<CSICP_FF042>
    {
        private readonly long? _ff040ID;
        public FiltroFF040IDParaFF042(long ff040ID)
        {
            _ff040ID = ff040ID;
        }
        public IQueryable<CSICP_FF042> Apply(IQueryable<CSICP_FF042> query)
        {
            if (_ff040ID.HasValue) //verificar com o Valter esse filtro
            {
                query = query.Where(e => e.Ff040Id == _ff040ID);
            }
            return query;
        }
    }
}
