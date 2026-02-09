using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.Ifs.Rebanho.RR009Repository.Filtros
{
    internal class FiltroAnimalVirtualIdRR009 : ICSFilter<OsusrTo3CsicpRr009>
    {
        private readonly string? _animalVirtualId;

        public FiltroAnimalVirtualIdRR009(string? animalVirtualId)
        {
            _animalVirtualId = animalVirtualId;
        }

        public IQueryable<OsusrTo3CsicpRr009> Apply(IQueryable<OsusrTo3CsicpRr009> query)
        {
            if (!string.IsNullOrEmpty(_animalVirtualId))
            {
                query = query.Where(e => e.Rr001Virtualid != null &&
                                         e.Rr001Virtualid == _animalVirtualId);
            }
            return query;
        }
    }
}