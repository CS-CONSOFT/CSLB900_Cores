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

        public static string MovimentoEntradaSaida => "CS_Entrada_Saida_Mvto";
        public static string ExMovimentoEntradaSaida => "Exchange_EvtMateriaisMvtoEntradaSaida_";
        public static string FilaMovimentoEntradaSaida => "Fila_EvtMateriaisMvtoEntradaSaida_GG073_";


        public static string ExGeraInventarioEmMassa => "Exchange_Evt_GerarInvetarioEmMassa_";
        public static string FilaGeraInventarioEmMassa => "Fila_GerarInvetarioEmMassa_GG032_";
        public static string GeraInventarioEmMassa => "CS_GERAR_INVENTARIO_MASSA";
    }
}
