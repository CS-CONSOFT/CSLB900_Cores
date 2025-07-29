using Microsoft.EntityFrameworkCore.Diagnostics;
using Serilog;
using System.Data.Common;

namespace CSCore.Ifs.Compartilhado.CS_Context
{
    public class SerilogDbCommandInterceptor : DbCommandInterceptor
    {
        public override InterceptionResult<DbDataReader> ReaderExecuting(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<DbDataReader> result)
        {
            LogQuery(command, eventData);
            return base.ReaderExecuting(command, eventData, result);
        }

        private void LogQuery(DbCommand command, CommandEventData eventData)
        {
            // Tenta extrair o nome da tabela do comando SQL
            var sql = command.CommandText;
            string? tabela = null;

            // Busca por FROM [Tabela] ou INSERT INTO [Tabela]
            var fromIndex = sql.IndexOf("FROM [");
            if (fromIndex >= 0)
            {
                var start = fromIndex + 6;
                var end = sql.IndexOf("]", start);
                tabela = sql.Substring(start, end - start);
            }
            else
            {
                var insertIndex = sql.IndexOf("INTO [");
                if (insertIndex >= 0)
                {
                    var start = insertIndex + 6;
                    var end = sql.IndexOf("]", start);
                    tabela = sql.Substring(start, end - start);
                }
            }

            Log.Information("EFCore Query | Tabela: {Tabela} | SQL: {Sql}", tabela ?? "N/A", sql);
        }
    }
}
