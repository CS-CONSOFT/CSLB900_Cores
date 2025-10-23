namespace CSCore.RabbitMQ.Hub.Ax
{
    public static class HubGroupNames
    {
        public static string BANCO_BRASIL_HUB_GRUPO = "BANCO_BRASIL_HUB_GRUPO";
        public static string FINANCEIRO_CONTAS_A_PAGAR = "FINANCEIRO_CONTAS_A_PAGAR";
    }

    public static class HubMethodNames
    {
        public static string PROCESSAR_BAIXA_ESTOQUE_GG073 = "PROCESSAR_BAIXA_ESTOQUE_GG073";
        public static string BLOQUEAR_DESBLOQUEAR_INVENTARIO_GG032 = "BLOQUEAR_DESBLOQUEAR_INVENTARIO_GG032";
        public static string ANALISE_CREDITO = "ANALISE_CREDITO";
        public static string GERA_PROTOCOLO_CI = "GERA_PROTOCOLO_CI";
        public static string AJUSTE_PRECO_GG031 = "AJUSTE_PRECO_GG031";
        public static string GERA_INVENTARIO_GG054 = "GERA_INVENTARIO_GG054";
        public static string PROCESSA_BAIXA_GG071 = "PROCESSA_BAIXA_GG071";
        public static string PROCESSAR_INVENTARIO_GG032 = "PROCESSAR_INVENTARIO_GG032";
        public static string GERAR_INVENTARIO_EM_MASSA_GG032 = "GERAR_INVENTARIO_EM_MASSA_GG032";

        //FINANCEIRO
        public static string FINANCEIRO_CONTAS_A_PAGAR_PROCESSAR_CARTA_DEBITO = "FINANCEIRO_CONTAS_A_PAGAR_PROCESSAR_CARTA_DEBITO";
    }
}
