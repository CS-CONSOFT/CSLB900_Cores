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

        public static string MovimentoEntradaSaida => "CS_Entrada_Saida_Mvto";
    }
}
