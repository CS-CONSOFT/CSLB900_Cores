using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF04X.FF040.Filtros
{
    internal class FiltroSituacaoIDFF040 : ICSFilter<CSICP_FF040>
    {
        private readonly int? _situacaoID;
        public FiltroSituacaoIDFF040(int? situacaoID)
        {
            _situacaoID = situacaoID;
        }
        public IQueryable<CSICP_FF040> Apply(IQueryable<CSICP_FF040> query)
        {
            if (_situacaoID.HasValue)
            {
                query = query.Where(e => e.Ff040Situacaoid == _situacaoID);
            }
            return query;
        }
    }
}
