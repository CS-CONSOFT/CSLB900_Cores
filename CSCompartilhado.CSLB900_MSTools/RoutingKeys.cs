
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
    }
}

