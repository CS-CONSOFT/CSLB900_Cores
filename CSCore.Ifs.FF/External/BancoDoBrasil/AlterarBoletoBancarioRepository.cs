using CSCore.Ifs.FF.External.BancoDoBrasil.Interface;
using CSCore.Ifs.FF.External.BancoDoBrasil.Interface.Impl;
using CSCore.Ifs.FF.External.Parametros;
using CSCore.Ifs.FF.External.Retornos;
using CSLB900.MSTools.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External.BancoDoBrasil
{
    public class AlterarBoletoBancarioRepository(
        IRefitBancoBrasil refitBancoBrasil
        ) : BancoDoBrasilServiceBaseImpl(refitBancoBrasil), IBancoDoBrasilAlterarBoleto
    {
        private readonly IRefitBancoBrasil _refitBancoBrasil = refitBancoBrasil;

        public async Task<AlterarBoletoBancarioResponse> AlterarBoletoBancario(string id, string appKey, string authorization, AlteraBoletoRequest requisicao)
        {
            try
            {
                var tokenAuth = await ObterTokenAutenticacao(authorization, appKey);
                var result = await _refitBancoBrasil.AlterarBoleto(appKey, tokenAuth, id, requisicao);

                if (!result.IsSuccessStatusCode)
                    throw new Exception("Erro ao criar boleto no Banco do Brasil: " + result.Error?.Content);

                var content = result.Content
                    ?? throw new Exception("Erro ao criar boleto no Banco do Brasil: " + result.Error?.Content);

                return content;
            }
            catch (Exception ex)
            {
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }
    }
}
