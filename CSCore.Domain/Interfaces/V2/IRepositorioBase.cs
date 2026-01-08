namespace CSCore.Domain.Interfaces.V2
{
    [Obsolete("Use IRepositorioBaseV2 instead")]
    public interface IRepositorioBase<TEntity>
        where TEntity : class
    {
        TEntity Create(TEntity entity);
        Task<int> BulkCreateAsync(List<TEntity> entities);
        Task<int> BulkCreateAsync(IEnumerable<TEntity> entities);
        Task<TEntity?> UpdateAsync(string id, int tenant, TEntity entity);
        Task<TEntity?> UpdateAsync(long id, int tenant, TEntity entity);
        Task<TEntity?> RemoveAsync(string id, int tenant);
        Task<TEntity?> RemoveAsync(long id, int tenant);
        object GetEntityId(TEntity entity);
        Task CommitToDatabase();

        Task SalvarLogAsync(
            int tenantId,
            string nomeUsuario,
            string severidade,
            string mensagem,
            string? jsonHeader = null,
            string? jsonQuery = null,
            string? jsonBody = null,
            bool isExibiu = false);
            }

    public interface IRepositorioBaseV2<TEntity>
    where TEntity : class
    {
        TEntity Create(TEntity entity);
        int CreateRange(List<TEntity> entity);
        Task<int> BulkCreateAsync(List<TEntity> entities);
        Task<int> BulkCreateAsync(IEnumerable<TEntity> entities);
        Task<TEntity?> UpdateAsync(string id, int tenant, TEntity entity);
        Task<TEntity?> UpdateAsync(long id, int tenant, TEntity entity);
        Task<TEntity?> RemoveAsync(string id, int tenant);
        Task<TEntity?> RemoveAsync(long id, int tenant);

        /// <summary>
        /// Recupera o ID da entidade passada como parâmetro.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        object GetEntityId(TEntity entity);

        Task SalvarLogAsync(
    int tenantId,
    string nomeUsuario,
    string severidade,
    string mensagem,
    string? jsonHeader = null,
    string? jsonQuery = null,
    string? jsonBody = null,
    bool isExibiu = false);


        /// <summary>
        /// Recupera o DbContext utilizado pelo repositório.
        /// Implementação padrão retorna null para compatibilidade com código existente.
        /// </summary>
        /// <returns>A instância do DbContext ou null se não implementado.</returns>
        object? GetDbContext() => null;
    }



    public enum TipoFiltroDinamico
    {
        Igual = 1,
        Diferente = 2,
        Maior = 3,
        Menos = 4
    }
    public record FiltrosDinamicos
    {
        /// <summary>
        /// O nome da propriedade da classe de entidade!
        /// </summary>
        public string NomePropriedade { get; set; } = string.Empty;

        /// <summary>
        /// Valor dessa propriedade para comparação!
        /// </summary>
        public object? ValorPropriedade { get; set; } = null;
        /// <summary>
        /// Igualdade a ser utilizada na comparação!
        /// </summary>
        public TipoFiltroDinamico TipoDeIgualdade { get; set; } = TipoFiltroDinamico.Igual;

    }

    /// <summary>
    /// Define métodos para recuperar entidades por identificador ou recuperar todas as entidades para um locatário (tenant) especificado.
    /// </summary>
    /// <remarks>Esta interface estende a interface base de repositório para fornecer operações assíncronas de recuperação
    /// que suportam cenários multi-tenant. As implementações devem garantir o isolamento dos locatários ao acessar as entidades.</remarks>
    /// <typeparam name="TEntity">O tipo da entidade gerenciada pelo repositório. Deve ser um tipo de referência.</typeparam>
    public interface IRepositorioBaseV2ComGets<TEntity> : IRepositorioBaseV2<TEntity>
    where TEntity : class
    {
        Task<TEntity?> GetByIdAsync(string id, int tenant);
        Task<TEntity?> GetByIdAsync(long id, int tenant);
        Task<IEnumerable<TEntity>> GetAllAsync(IEnumerable<FiltrosDinamicos> filtros);
    }
}
