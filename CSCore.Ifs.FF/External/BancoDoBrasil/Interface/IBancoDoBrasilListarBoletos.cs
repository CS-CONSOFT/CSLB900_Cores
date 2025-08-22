using CSCore.Ifs.FF.External.Retornos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External.BancoDoBrasil.Interface
{
    public interface IBancoDoBrasilListarBoletos : IBancoDoBrasilAuth
    {
        Task<List<RetornoListarBoleto>> ListarBoletosBancarios(
           string gwdevappkey,
           string estabAuthToken,
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
           long? indice = null);
    }
}
