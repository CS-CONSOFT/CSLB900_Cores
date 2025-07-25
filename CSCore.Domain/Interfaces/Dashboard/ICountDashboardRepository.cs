namespace CSCore.Domain.Interfaces.Dashboard
{
    public interface ICountDashboardRepository
    {

        /// <summary>
        /// Retorna os counts para o dashboard.
        /// O parametro de retorno (int int) representa RESPECTIVAMENTE: Count total, numero ativos
        /// A string do retorno é o nome da tabela que o count respectivo foi feito
        /// </summary>
        /// <param name="tenant"></param>
        /// <returns></returns>
        Task<Dictionary<string, (int, int)>> GetCountDashboard(int tenant);
    }
}
