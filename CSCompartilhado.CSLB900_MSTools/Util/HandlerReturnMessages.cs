
namespace CSLB900.MSTools.Util
{
    /**
     * 
     * Essa classe terá apenas métodos estáticos visando facilitar o acesso de alguns
     * componentes por toda a aplicação
     */

    public static class HandlerReturnMessages
    {
        public const string ENTITY_CREATED_MESSAGE = "Entidade foi gerada com sucesso!";
        public const string ENTITY_UPDATED_MESSAGE = "Entidade foi atualizada com sucesso!";
        public const string ENTITY_DELETED_MESSAGE = "Entidade foi deletada com sucesso!";
        public const string ENTITY_CHANGE_ACTIVE_MESSAGE = "Atributo IsAtivo da entidade foi atualizado com sucesso!";
        public const string ENTITY_GET_LIST_MESSAGE = "Recebendo lista de dados paginados";
        public const string ENTITY_GET_ID_MESSAGE = "Recebendo entidade por ID";
        public const string ENTITY_NOT_FOUND = "Entidade não encontrada!";
        public const string ENTITY_ALTER_PASSWORD = "Senha atualizada";
        public const string NULL_PROPERTY = "Propiedade não nula veio nula: ";
        public const string ERROR_CPF_CNPJ = "CPF/CNPJ incorreto. Verifique o tamanho dos caracteres!";
        public const string TENANT_HEADER_NAME = "Tenant_ID";
        public const string CODE_ALREADY_REGISTER = "Código já registrado!";
        public const string METHOD_NOT_ALLOWED = "Esse método não está permitido nessa classe";
        public const string LABEL_NOT_FOUND = "Label não encontrada";
        public const string ENTITIES_CREATED_MESSAGE = "Entidades foram geradas com sucesso!";
        public const string ENTITIES_DELETED_MESSAGE = "Entidades foram deletadas com sucesso!";
    }
}
