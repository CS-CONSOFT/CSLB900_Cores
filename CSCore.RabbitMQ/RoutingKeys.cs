public static class RoutingKeys
{
    // ... outras routing keys existentes ...
    
    // Processamento Registro Peso Animal RR022
    public const string ExchangeProcessaRegistroPesoAnimalRebanho = "exchange_processa_registro_peso_animal_rebanho";
    public const string FilaProcessaRegistroPesoAnimalRebanho = "fila_processa_registro_peso_animal_rebanho";
    public const string ActionProcessaRegistroPesoAnimal = "action_processa_registro_peso_animal";
    
    // Processamento Lote e Atualiza Peso (já existente)
    public const string ExchangeProcessaLoteEAtualizaPesoRebanho = "exchange_processalote_atualizapeso_rebanho";
    public const string FilaProcessaLoteEAtualizaPesoRebanho = "fila_processalote_atualizapeso_rebanho";
    public const string ActionProcessaLoteAtualizaPeso = "action_processalote_atualizapeso";
}