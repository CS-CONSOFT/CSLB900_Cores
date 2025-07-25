using CSCore.Ifs.FF.External.Parametros;
using GG104Materiais.C82Application.Service.BancoDoBrasil.Parametros;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External
{
    public interface IRefitBancoBrasil
    {
        [Post("/lb900/bb/v1/boletos")]
        Task<ApiResponse<RetornoCriaBoleto>> IncluiBoletoBancario(
           [Query("gwdevappkey")] string gwdevappkey,
           [Header("Authorization")] string authorization,
           [Body] CriaBoletoRequest requisicao
       );

        [Post("/lb900/bb/v1/auth")]
        Task<ApiResponse<ReturnPostLogin>> Auth([Header("Authorization")] string Authorization);
    }
}
