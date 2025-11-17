
namespace CSCore.RabbitMQ
{
    public static class RoutingKeys
    {
        public static string GetRoutingKey(string urlParaRoutingKey, string action)
        {
            string nomeDominio = "";
            if (urlParaRoutingKey != null || urlParaRoutingKey != "")
            {
                var url = urlParaRoutingKey!.Replace("https://", "")
                                           .Replace("http://", "");
                var partes = url.Split('.');
                nomeDominio = partes[0].Contains("/") ? partes[0].Split('/')[0] : partes[0];
            }
            return $"{nomeDominio}_{urlParaRoutingKey}_{action}";
        }

        public static (string routingKey, string dominio) GetRoutingKeyComDominio(string urlParaRoutingKey, string action)
        {
            string nomeDominio = "";
            if (urlParaRoutingKey != null || urlParaRoutingKey != "")
            {
                var url = urlParaRoutingKey!.Replace("https://", "")
                                           .Replace("http://", "");
                var partes = url.Split('.');
                nomeDominio = partes[0].Contains("/") ? partes[0].Split('/')[0] : partes[0];
            }
            return ($"{nomeDominio}_{urlParaRoutingKey}_{action}", nomeDominio);
        }

        public static string GetRoutingKey(string urlParaRoutingKey, object action)
        {
            throw new NotImplementedException();
        }

        public static string MovimentoEntradaSaida => "Action_Rabbit_CS_Entrada_Saida_Mvto_GG073";
        public static string ExMovimentoEntradaSaida => "Exchange_MateriaisMvtoEntradaSaida_GG073";
        public static string FilaMovimentoEntradaSaida => "Queue_MateriaisMvtoEntradaSaida_GG073";


        public static string ExProcessaAjusteDePreco => "Exchange_ProcessaAjusteDePreco_GG031";
        public static string FilaAjusteDePreco => "Queue_ProcessaAjusteDePreco_GG031";
        public static string ProcessaAjusteDePreco => "Action_ProcessaAjusteDePreco_GG031";

        public static string FilaProcessaBaixaGG071 => "Queue_ProcessaBaixaGG071";
        public static string ExProcessaBaixaGG071 => "Exchange_ProcessaBaixaGG071";
        public static string ProcessaBaixaGG071 => "Action_ProcessaBaixaGG071";

        public static string FilaBloquearDesbloquearInventarioGG032 => "Queue_BloquearDesbloquearInventarioGG032";
        public static string ExBloquearDesbloquearInventarioGG032 => "Exchange_BloquearDesbloquearInventarioGG032";
        public static string BloquearDesbloquearInventarioGG032 => "Action_BloquearDesbloquearInventarioGG032";

        public static string FilaProcessarInventarioGG032 => "Queue_ProcessarInventarioGG032";
        public static string ExProcessarInventarioGG032 => "Exchange_ProcessarInventarioGG032";
        public static string ProcessarInventarioGG032 => "Action_ProcessarInventarioGG032";

        public static string FilaProcessaGerarInventarioEmMassaGG032 => "Queue_ProcessaGerarInventarioEmMassaGG032";
        public static string ExProcessaGerarInventarioEmMassaGG032 => "Exchange_ProcessaGerarInventarioEmMassaGG032";
        public static string ProcessaGerarInventarioEmMassaGG032 => "Action_ProcessaGerarInventarioEmMassaGG032";

        public static string FilaProcessaGeraInventarioGG054 => "Queue_ProcessaGeraInventarioGG054";
        public static string ExProcessaGeraInventarioGG054 => "Exchange_ProcessaGeraInventarioGG054";
        public static string ProcessaGeraInventarioGG054 => "Action_ProcessaGeraInventarioGG054";

        public static string FilaProcessaAnaliseDeCredito => "Queue_ProcessaAnaliseDeCredito";
        public static string ExProcessaAnaliseDeCredito => "Exchange_ProcessaAnaliseDeCredito";
        public static string ProcessaAnaliseDeCredito => "Action_ProcessaAnaliseDeCredito";


        public static string FilaBBEnvioTitulo => "Queue_BBEnvioTitulo";
        public static string BBEnvioTitulo => "Action_BBEnvioTitulo";
        public static string ExBBEnvioTitulo => "Exchange_BBEnvioTitulo";

        // Banco do Brasil - Resposta de Títulos
        public static string BBEnvioTituloResponse => "Action_BB_EnvioTitulo_Response";
        public static string ExBBEnvioTituloResponse => "Exchange_BB_EnvioTitulo_Response";
        public static string FilaBBEnvioTituloResponse => "Queue_BB_EnvioTitulo_Response";




        //FINANCEIRO
        public static string FilaProcessaCartaDebito => "Queue_ProcessaCartaDebito";
        public static string ExchangeProcessaCartaDebito => "Exchange_ProcessaCartaDebito";
        public static string ActionProcessaCartaDebito => "Action_ProcessaCartaDebito";

        //PREVISAO GERAL
        public static string FilaProcessaPrevisaoGeral => "Queue_ProcessaPrevisaoGeral";
        public static string ExchangeProcessaPrevisaoGeral => "Exchange_ProcessaPrevisaoGeral";
        public static string ActionProcessaPrevisaoGeral => "Action_ProcessaPrevisaoGeral";

        //MEMORIA CALCULO FF043
        public static string FilaGeraMemoriaCalculoFF043 => "Queue_GeraMemoriaCalculoFF043";
        public static string ExchangeGeraMemoriaCalculoFF043 => "Exchange_GeraMemoriaCalculoFF043";
        public static string ActionGeraMemoriaCalculoFF043 => "Action_GeraMemoriaCalculoFF043";

        //MovtoTituloBaixarKernel
        public static string FilaMovtoTituloBaixarKernel => "Queue_MovtoTituloBaixarKernel";
        public static string ExchangeMovtoTituloBaixarKernel => "Exchange_MovtoTituloBaixarKernel";
        public static string ActionMovtoTituloBaixarKernel => "Action_MovtoTituloBaixarKernel";

        //SimulacaoRenegociacao
        public static string FilaSimulacaoRenegociacao => "Queue_SimulacaoRenegociacao";
        public static string ExchangeSimulacaoRenegociacao => "Exchange_SimulacaoRenegociacao";
        public static string ActionSimulacaoRenegociacao => "Action_SimulacaoRenegociacao";

        //RenegociacaoCriaTitulos
        public static string FilaRenegociacaoCriaTitulos => "Queue_RenegociacaoCriaTitulos";
        public static string ExchangeRenegociacaoCriaTitulos => "Exchange_RenegociacaoCriaTitulos";
        public static string ActionRenegociacaoCriaTitulos => "Action_RenegociacaoCriaTitulos";

        //PR34_GerarContasAPagar
        public static string FilaPR34_GerarContasAPagar => "Queue_PR34_GerarContasAPagar";
        public static string ExchangePR34_GerarContasAPagar => "Exchange_PR34_GerarContasAPagar";
        public static string ActionPR34_GerarContasAPagar => "Action_PR34_GerarContasAPagar";

        //PR119_Atualiza Saldo Mensal Contábil
        public static string FilaPR119_AtualizaSaldoMensalContabil => "Queue_PR119_AtualizaSaldoMensalContabil";
        public static string ExchangePR119_AtualizaSaldoMensalContabil => "Exchange_PR119_AtualizaSaldoMensalContabil";
        public static string ActionPR119_AtualizaSaldoMensalContabil => "Action_PR119_AtualizaSaldoMensalContabil";

        //PROCESSAR LOTE E ATUALIZA PESO REBANHO
        public static string FilaProcessaLoteEAtualizaPesoRebanho => "Queue_ProcessaLoteEAtualizaPesoRebanho";
        public static string ExchangeProcessaLoteEAtualizaPesoRebanho => "Exchange_ProcessaLoteEAtualizaPesoRebanho";
        public static string ActionProcessaLoteAtualizaPeso => "Action_ProcessaLoteEAtualizaPesoRebanho";
    }
}

