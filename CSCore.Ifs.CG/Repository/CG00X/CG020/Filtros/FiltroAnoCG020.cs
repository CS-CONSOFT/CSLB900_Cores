using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Compartilhado;
using System.Linq.Expressions;

namespace CSCore.Ifs.CG.Repository.CG00X.CG020.Filtros
{
    public class FiltroAnoCG020 : ICSFilter<CSICP_CG020>
    {
        private readonly int? _ano;

        public FiltroAnoCG020(int? ano)
        {
            _ano = ano;
        }

        public IQueryable<CSICP_CG020> Apply(IQueryable<CSICP_CG020> query)
        {
            if (_ano.HasValue)
            {
                query = query.Where(e => e.Cg020Ano == _ano.Value);
            }
            return query;
        }
    }
}