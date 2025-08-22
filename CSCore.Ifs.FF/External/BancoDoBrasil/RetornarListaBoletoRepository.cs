using CSCore.Ifs.FF.External.BancoDoBrasil.Interface;
using CSCore.Ifs.FF.External.BancoDoBrasil.Interface.Impl;
using CSCore.Ifs.FF.External.Retornos;
using CSLB900.MSTools.Util;

namespace CSCore.Ifs.FF.External.BancoDoBrasil
{
    public class RetornarListaBoletoRepository(
        IRefitBancoBrasil refitBancoBrasil
        ) : BancoDoBrasilServiceBaseImpl(refitBancoBrasil), IBancoDoBrasilListarBoletos
    {
        private readonly IRefitBancoBrasil _refitBancoBrasil = refitBancoBrasil;

        public async Task<List<RetornoListarBoleto>> ListarBoletosBancarios(
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
            long? indice = null)
        {

            try
            {

                string tokenAcess = await ObterTokenAutenticacao(in_tokenAutenticacao: estabAuthToken, gwdevappkey);
                var resultListarBoleto = await _refitBancoBrasil.ListarBoletosBancarios(
                    gwdevappkey,
                    tokenAcess,
                    indicadorSituacao,
                    agenciaBeneficiario,
                    contaBeneficiario,
                    contaCaucao,
                    carteiraConvenio,
                    variacaoCarteiraConvenio,
                    modalidadeCobranca,
                    cnpjPagador,
                    digitoCNPJPagador,
                    cpfPagador,
                    digitoCPFPagador,
                    dataInicioVencimento,
                    dataFimVencimento,
                    dataInicioRegistro,
                    dataFimRegistro,
                    dataInicioMovimento,
                    dataFimMovimento,
                    codigoEstadoTituloCobranca,
                    boletoVencido,
                    indice);

                if (!resultListarBoleto.IsSuccessStatusCode)
                    throw new Exception("Erro ao criar boleto no Banco do Brasil: " + resultListarBoleto.Error?.Content);

                var content = resultListarBoleto.Content
                    ?? throw new Exception("Erro ao criar boleto no Banco do Brasil: " + resultListarBoleto.Error?.Content);

                return content;
            }
            catch (Exception ex)
            {
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }
    }
}
