using CSCore.Ifs.FF.External.Retornos;
using Microsoft.AspNetCore.Mvc;

namespace CSCore.Ifs.FF.External.BancoDoBrasil
{
    public abstract class BancoBrasilAbstractClass
    {
        public virtual Task CS01_Envio_Titulos(string in_ff102ID, int in_tenantID)
        {
            throw new NotImplementedException("Envio de títulos não implementado nesta classe.");
        }

        public virtual Task<List<RetornoListarBoleto>> CS02_RetornarListaBoleto(
            string gwdevappkey,
                      string authorization,
              string? indicadorSituacao,
              int agenciaBeneficiario,
              long contaBeneficiario,
              int? contaCaucao = null,
              int? carteiraConvenio = null,
              int? variacaoCarteiraConvenio = null,
              int? modalidadeCobranca = null,
              long? cnpjPagador = null,
              int? digitoCNPJPagador = null,
              long? cpfPagador = null,
              int? digitoCPFPagador = null,
              string? dataInicioVencimento = null,
              string? dataFimVencimento = null,
              string? dataInicioRegistro = null,
              string? dataFimRegistro = null,
              string? dataInicioMovimento = null,
              string? dataFimMovimento = null,
              int? codigoEstadoTituloCobranca = null,
              string? boletoVencido = null,
              long? indice = null

            )
        {
            throw new NotImplementedException("Retorno de lista de boletos não implementado nesta classe.");
        }
    }
}
