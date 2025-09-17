using CSCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.Agenda_de_Cobranca
{
    public interface ISPCRepository
    {
        Task<RetornoPadraoProcessosVoid> AtualizaRegistroSPC(PrmRegistraSPC prm);
    }
}
