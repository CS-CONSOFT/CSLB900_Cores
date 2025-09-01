using CSCore.Ifs.FF.Repository.GravaOcorrencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.AplicaSemJuros
{
    public interface IAplicaSemJurosRepository
    {
        Task<bool> ExecutarAplicaSemJuros(PrmGravaOcorrencia parametros);
    }
}
