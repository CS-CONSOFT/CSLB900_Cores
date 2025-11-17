using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.CG.Repository.CG00X.CG008.Filtros
{
    public class FiltroDescricaoCG008 : ICSFilter<CSICP_CG008>
    {
        private readonly string _descricao;

        public FiltroDescricaoCG008(string? descricao)
        {
            _descricao = descricao;
        }

        public IQueryable<CSICP_CG008> Apply(IQueryable<CSICP_CG008> query)
        {
            if (!string.IsNullOrEmpty(_descricao))
            {
                query = query.Where(e => e.Cg008Descricao != null && e.Cg008Descricao.Contains(_descricao));
            }
            return query;
        }
    }
}