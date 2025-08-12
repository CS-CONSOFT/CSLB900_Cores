using CSCore.Ifs.FF.External.Parametros;
using CSCore.Ifs.FF.External.Retornos;
using Microsoft.AspNetCore.Mvc;
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

        [Get("/lb900/bb/v1/boletos")]
        Task<ApiResponse<List<RetornoListarBoleto>>> ListarBoletosBancarios(
             [Query("AppKey")] string gwdevappkey,
             [Header("Authorization")] string authorization,
            [Query] string? indicadorSituacao,
            [Query] int agenciaBeneficiario,
            [Query] long contaBeneficiario,
            [Query] int? contaCaucao = null,
            [Query] int? carteiraConvenio = null,
            [Query] int? variacaoCarteiraConvenio = null,
            [Query] int? modalidadeCobranca = null,
            [Query] long? cnpjPagador = null,
            [Query] int? digitoCNPJPagador = null,
            [Query] long? cpfPagador = null,
            [Query] int? digitoCPFPagador = null,
            [Query] string? dataInicioVencimento = null,
            [Query] string? dataFimVencimento = null,
            [Query] string? dataInicioRegistro = null,
            [Query] string? dataFimRegistro = null,
            [Query] string? dataInicioMovimento = null,
            [Query] string? dataFimMovimento = null,
            [Query] int? codigoEstadoTituloCobranca = null,
            [Query] string? boletoVencido = null,
            [Query] long? indice = null
            );

        [Post("/lb900/bb/v1/auth")]
        Task<ApiResponse<ReturnPostLogin>> Auth([Header("Authorization")] string Authorization);
    }
}
