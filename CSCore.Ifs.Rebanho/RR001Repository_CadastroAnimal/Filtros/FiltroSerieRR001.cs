using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR001Repository_CadastroAnimal.Filtros
{
    internal class FiltroSerieRR001 : ICSFilter<OsusrTo3CsicpRr001>
    {
        private readonly string? _serie;

        public FiltroSerieRR001(string? serie)
        {
            _serie = serie;
        }

        public IQueryable<OsusrTo3CsicpRr001> Apply(IQueryable<OsusrTo3CsicpRr001> query)
        {
            if (!string.IsNullOrEmpty(_serie))
            {
                query = query.Where(e => e.Rr001Serie != null && 
                                         e.Rr001Serie.Contains(_serie));
            }
            return query;
        }
    }
}
