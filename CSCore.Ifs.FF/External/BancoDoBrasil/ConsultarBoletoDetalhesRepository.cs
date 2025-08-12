using CSCore.Ifs.FF.External.BancoDoBrasil.Interface;
using CSCore.Ifs.FF.External.BancoDoBrasil.Interface.Impl;
using CSCore.Ifs.FF.External.Retornos;
using CSLB900.MSTools.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External.BancoDoBrasil
{
    public class ConsultarBoletoDetalhesRepository(
        IRefitBancoBrasil refitBancoBrasil
        ) : BancoDoBrasilServiceBaseImpl(refitBancoBrasil), IBancoDoBrasilConsultarBoletosDetalhes
    {
        private readonly IRefitBancoBrasil _refitBancoBrasil = refitBancoBrasil;
        public async Task<RetornoConsultarBoleto> ConsultarBoletosDetalhes(string gwdevappkey,
            string estabAuthToken, string idBoleto, int in_numeroConvenio)
        {
            try
            {
                string tokenAcess = await ObterTokenAutenticacao(estabAuthToken, gwdevappkey);
                var resultConsultarBoleto = await _refitBancoBrasil.ConsultarBoletosDetalhes(
                    gwdevappkey,
                    authorization: tokenAcess,
                    idBoleto, // id
                    in_numeroConvenio // numeroConvenio
                );
                if (!resultConsultarBoleto.IsSuccessStatusCode)
                    throw new Exception("Erro ao criar boleto no Banco do Brasil: " + resultConsultarBoleto.Error?.Content);

                var content = resultConsultarBoleto.Content
                    ?? throw new Exception("Erro ao criar boleto no Banco do Brasil: " + resultConsultarBoleto.Error?.Content);

                return content;
            }
            catch (Exception ex)
            {
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }
    }
}
