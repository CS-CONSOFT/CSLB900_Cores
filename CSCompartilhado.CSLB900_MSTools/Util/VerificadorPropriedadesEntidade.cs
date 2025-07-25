using System.Reflection;

namespace CSLB900.MSTools.Util
{
    /// <summary>
    /// Classe responsavel por armazenar um método que é usado para verificar se uma entidade possui alguma propriedade passada na lista "nomesPropriedades"
    /// </summary>
    public static class VerificadorPropriedadesEntidade
    {
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="nomesPropriedades">Lista dos nomes das propriedes, deve ser separado por virgula</param>
        /// <returns></returns>
        public static (bool, PropertyInfo?) TemPropriedade<TEntity>(params string[] nomesPropriedades)
        {
            PropertyInfo[] properties = typeof(TEntity).GetProperties();

            foreach (var nomePropriedade in nomesPropriedades)
            {
                PropertyInfo? propertyInfo = properties
                   .Where(e => e.Name.Contains(nomePropriedade))
                   .FirstOrDefault();

                if (propertyInfo != null) return (true, propertyInfo);
            }
            return (false, null);
        }
    }
}
