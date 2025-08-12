using CSCore.Ifs.FF.External.BancoDoBrasil.Interface;
using CSCore.Ifs.FF.External.BancoDoBrasil.Interface.Impl;
using CSCore.Ifs.FF.External.Parametros;
using CSCore.Ifs.FF.External.Retornos;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External.BancoDoBrasil
{
    public class CancelarBoletoRepository(
        IRefitBancoBrasil refitBancoBrasil
        ) : BancoDoBrasilServiceBaseImpl(refitBancoBrasil), IBancoDoBrasilCancelarBoleto
    {
        private readonly IRefitBancoBrasil _refitBancoBrasil = refitBancoBrasil;

        public async Task<RespostaBaixaBoleto> CancelarBoletoMethod
            (string gwdevappkey, string estabAuthToken,string idBoleto, int numeroConvenio, 
            RequisicaoBaixaBoleto? requisicaoCancelarBoleto)
        {
            var tokenAuth = await ObterTokenAutenticacao(estabAuthToken);
            ApiResponse<RespostaBaixaBoleto> apiResponse = await _refitBancoBrasil.CancelarBoleto(gwdevappkey, tokenAuth, idBoleto, requisicaoCancelarBoleto);
            if (!apiResponse.IsSuccessStatusCode)
                throw new Exception("Erro ao criar boleto no Banco do Brasil: " + apiResponse.Error?.Content);

            var content = apiResponse.Content
                ?? throw new Exception("Erro ao criar boleto no Banco do Brasil: " + apiResponse.Error?.Content);

            return content;
        }
    }
}
