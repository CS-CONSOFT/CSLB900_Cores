using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.CG.Repository.CG00X.CG005.Filtros
{
    public class FiltroHistoricoResumidoCG005 : ICSFilter<CSICP_CG005>
    {
        private readonly string? _historicoResumido;

        public FiltroHistoricoResumidoCG005(string? historicoResumido)
        {
            _historicoResumido = historicoResumido;
        }

        public IQueryable<CSICP_CG005> Apply(IQueryable<CSICP_CG005> query)
        {
            if (!string.IsNullOrWhiteSpace(_historicoResumido))
            {
                query = query.Where(e => e.Cg005Historicoresumido != null && e.Cg005Historicoresumido.Contains(_historicoResumido));
            }

            return query;
        }
    }
}