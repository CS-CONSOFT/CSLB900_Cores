using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Ifs.CG.Repository.CG00X.CG009.Filtros
{
    internal class FiltroAnoCG009 : ICSFilter<CSICP_CG009>
    {
        private readonly int? _ano;

        public FiltroAnoCG009(int? ano)
        {
            _ano = ano;
        }

        public IQueryable<CSICP_CG009> Apply(IQueryable<CSICP_CG009> query)
        {
            if (_ano.HasValue)
            {
                query = query.Where(e => e.Cg009Ano == _ano.Value);
            }
            return query;
        }
    }
}