using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.GG.Repository.GG._05X.GG055.Filtros
{
    internal class FiltroGG054IdGG055 : ICSFilter<CSICP_GG055>
    {
        private readonly long? _gg054Id;
        public FiltroGG054IdGG055(long? gg054ID)
        {
            _gg054Id = gg054ID;
        }
        public IQueryable<CSICP_GG055> Apply(IQueryable<CSICP_GG055> query)
        {
            if (_gg054Id.HasValue)
            {
                query = query.Where(e => e.Gg054Id == _gg054Id.Value);
            }
            return query;
        }
    }
}
