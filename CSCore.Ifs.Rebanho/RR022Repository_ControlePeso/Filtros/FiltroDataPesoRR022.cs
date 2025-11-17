using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.Rebanho.RR022Repository_ControlePeso.Filtros
{
    public class FiltroDataPesoRR022 : ICSFilter<OsusrTo3CsicpRr022>
    {
        private readonly DateTime? _dataPeso;

        public FiltroDataPesoRR022(DateTime? dataPeso)
        {
            _dataPeso = dataPeso;
        }

        public IQueryable<OsusrTo3CsicpRr022> Apply(IQueryable<OsusrTo3CsicpRr022> query)
        {
            if (_dataPeso.HasValue)
            {
                var dataInicio = _dataPeso.Value.Date;
                var dataFim = dataInicio.AddDays(1);
                query = query.Where(e => e.Rr022Dtpeso.HasValue && 
                                        e.Rr022Dtpeso.Value >= dataInicio && 
                                        e.Rr022Dtpeso.Value < dataFim);
            }
            return query;
        }
    }
}