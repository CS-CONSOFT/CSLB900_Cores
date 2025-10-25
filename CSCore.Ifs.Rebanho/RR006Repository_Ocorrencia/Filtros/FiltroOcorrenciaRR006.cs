using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR006Repository_Ocorrencia.Filtros
{
    internal class FiltroOcorrenciaRR006 : ICSFilter<OsusrTo3CsicpRr006>
    {
        private readonly string? _ocorrencia;

        public FiltroOcorrenciaRR006(string? ocorrencia)
        {
            _ocorrencia = ocorrencia;
        }

        public IQueryable<OsusrTo3CsicpRr006> Apply(IQueryable<OsusrTo3CsicpRr006> query)
        {
            if (!string.IsNullOrEmpty(_ocorrencia))
            {
                query = query.Where(e => e.Rr006Ocorrencia != null && 
                                         e.Rr006Ocorrencia.Contains(_ocorrencia));
            }
            return query;
        }
    }
}