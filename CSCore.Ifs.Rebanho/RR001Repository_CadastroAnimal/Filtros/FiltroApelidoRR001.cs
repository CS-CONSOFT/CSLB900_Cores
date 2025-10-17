using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Repository;

namespace CSCore.Ifs.Rebanho.RR001Repository_CadastroAnimal.Filtros
{
    internal class FiltroApelidoRR001 : ICSFilter<OsusrTo3CsicpRr001>
    {
        private readonly string? _apelido;

        public FiltroApelidoRR001(string? apelido)
        {
            _apelido = apelido;
        }

        public IQueryable<OsusrTo3CsicpRr001> Apply(IQueryable<OsusrTo3CsicpRr001> query)
        {
            if (!string.IsNullOrEmpty(_apelido))
            {
                query = query.Where(e => e.Rr001Apelido != null && 
                                         e.Rr001Apelido.Contains(_apelido));
            }
            return query;
        }
    }
}