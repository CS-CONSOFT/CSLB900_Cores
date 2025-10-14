using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Repository;

namespace CSCore.Ifs.Rebanho.RR001Repository_CadastroAnimal.Filtros
{
    internal class FiltroDataNascimentoRR001 : ICSFilter<OsusrTo3CsicpRr001>
    {
        private readonly DateTime? _dataNascimento;

        public FiltroDataNascimentoRR001(DateTime? dataNascimento)
        {
            _dataNascimento = dataNascimento;
        }

        public IQueryable<OsusrTo3CsicpRr001> Apply(IQueryable<OsusrTo3CsicpRr001> query)
        {
            if (_dataNascimento.HasValue)
            {
                query = query.Where(e => e.Rr001Dtnascimento.HasValue && 
                                         e.Rr001Dtnascimento.Value.Date == _dataNascimento.Value.Date);
            }
            return query;
        }
    }
}