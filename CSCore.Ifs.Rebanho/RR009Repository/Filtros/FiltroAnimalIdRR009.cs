using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.Ifs.Rebanho.RR009Repository.Filtros
{
    internal class FiltroAnimalIdRR009 : ICSFilter<OsusrTo3CsicpRr009>
    {
        private readonly string? _animalId;

        public FiltroAnimalIdRR009(string? animalId)
        {
            _animalId = animalId;
        }

        public IQueryable<OsusrTo3CsicpRr009> Apply(IQueryable<OsusrTo3CsicpRr009> query)
        {
            if (!string.IsNullOrEmpty(_animalId))
            {
                query = query.Where(e => e.Rr001Id != null && e.Rr001Id == _animalId);
            }
            return query;
        }
    }
}