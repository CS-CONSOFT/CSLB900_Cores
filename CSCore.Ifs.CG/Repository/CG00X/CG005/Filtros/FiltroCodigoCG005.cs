using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.CG.Repository.CG00X.CG005.Filtros
{
    public class FiltroCodigoCG005 : ICSFilter<CSICP_CG005>
    {
        private readonly int? _codigo;

        public FiltroCodigoCG005(int? codigo)
        {
            _codigo = codigo;
        }

        public IQueryable<CSICP_CG005> Apply(IQueryable<CSICP_CG005> query)
        {
            if (_codigo.HasValue)
            {
                query = query.Where(e => e.Cg005Codigo == _codigo.Value);
            }

            return query;
        }
    }
}