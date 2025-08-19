using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Cria_Titulos.Parametro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Cria_Titulos
{
    public interface IRenegociacaoCriaTitulo
    {
        Task Executar(Prm_Renegociacao_Cria_Titulo InPrmCriaTitulo);
    }
}
