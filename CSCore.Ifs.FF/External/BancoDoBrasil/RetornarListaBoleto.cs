using CSCore.Domain.Interfaces.Estatica;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.External;
using CSCore.Ifs.FF.External.BancoDoBrasil.Auth;
using CSCore.Ifs.FF.External.Parametros;
using CSCore.Ifs.FF.External.Retornos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External.BancoDoBrasil
{
    public class RetornarListaBoleto(
        IRefitBancoBrasil refitBancoBrasil,
        IAuthBancoBrasil authBancoBrasil
        ) : BancoBrasilAbstractClass
    {
        private readonly IRefitBancoBrasil _refitBancoBrasil = refitBancoBrasil;
        private readonly IAuthBancoBrasil _authBancoBrasil = authBancoBrasil;

        public override async Task<List<RetornoListarBoleto>> CS02_RetornarListaBoleto(
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

            ReturnPostLogin retornoPostLogin = await _authBancoBrasil.CS51_Auth_BancoBrasil(in_tokenAutenticacao: estabAuthToken);
            var resultListarBoleto = await _refitBancoBrasil.ListarBoletosBancarios(
                gwdevappkey,
                "Bearer " + retornoPostLogin.access_token, 
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

            if(!resultListarBoleto.IsSuccessStatusCode)
                throw new Exception("Erro ao criar boleto no Banco do Brasil: " + resultListarBoleto.Error?.Content);

            var content = resultListarBoleto.Content 
                ?? throw new Exception("Erro ao criar boleto no Banco do Brasil: " + resultListarBoleto.Error?.Content);

            return content;
        }
    }
}
