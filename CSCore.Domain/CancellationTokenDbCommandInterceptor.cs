using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

namespace FF105Financeiro.C82Application.Interceptors
{
    /// <summary>
    /// Interceptor otimizado que injeta automaticamente o CancellationToken da requisição HTTP
    /// em todas as operações do Entity Framework, com mínimo impacto de performance.
    /// </summary>
    public class CancellationTokenDbCommandInterceptor : DbCommandInterceptor
    {
        // ⚡ Otimização: Apenas sobrescreve métodos async (que são os mais usados)
        // Métodos síncronos são ignorados para evitar overhead desnecessário

        public override async ValueTask<InterceptionResult<DbDataReader>> ReaderExecutingAsync(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<DbDataReader> result,
            CancellationToken cancellationToken = default)
        {
            // Obtém o token da requisição HTTP
            var httpToken = CancellationTokenHelper.GetCurrent();

            // ⚡ Otimização: Se não há token HTTP ou já está cancelado, retorna imediatamente
            if (httpToken == CancellationToken.None || !httpToken.CanBeCanceled)
            {
                return await base.ReaderExecutingAsync(command, eventData, result, cancellationToken);
            }

            // ⚡ Verifica cancelamento ANTES de criar linked token (economia de alocação)
            if (httpToken.IsCancellationRequested)
            {

                throw new OperationCanceledException(httpToken);
            }

            // ⚡ Só cria linked token se realmente necessário
            if (cancellationToken == default || cancellationToken == CancellationToken.None)
            {
                // Usa direto o token HTTP (sem alocação extra)
                return await base.ReaderExecutingAsync(command, eventData, result, httpToken);
            }

            // Apenas neste caso cria linked token (raro)
            using var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(httpToken, cancellationToken);
            return await base.ReaderExecutingAsync(command, eventData, result, linkedCts.Token);
        }

        public override async ValueTask<InterceptionResult<int>> NonQueryExecutingAsync(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<int> result,
            CancellationToken cancellationToken = default)
        {
            var httpToken = CancellationTokenHelper.GetCurrent();

            if (httpToken == CancellationToken.None || !httpToken.CanBeCanceled)
            {
                return await base.NonQueryExecutingAsync(command, eventData, result, cancellationToken);
            }

            if (httpToken.IsCancellationRequested)
            {
                throw new OperationCanceledException(httpToken);
            }

            if (cancellationToken == default || cancellationToken == CancellationToken.None)
            {
                return await base.NonQueryExecutingAsync(command, eventData, result, httpToken);
            }

            using var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(httpToken, cancellationToken);
            return await base.NonQueryExecutingAsync(command, eventData, result, linkedCts.Token);
        }

        public override async ValueTask<InterceptionResult<object>> ScalarExecutingAsync(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<object> result,
            CancellationToken cancellationToken = default)
        {
            var httpToken = CancellationTokenHelper.GetCurrent();

            if (httpToken == CancellationToken.None || !httpToken.CanBeCanceled)
            {
                return await base.ScalarExecutingAsync(command, eventData, result, cancellationToken);
            }

            if (httpToken.IsCancellationRequested)
            {
                throw new OperationCanceledException(httpToken);
            }

            if (cancellationToken == default || cancellationToken == CancellationToken.None)
            {
                return await base.ScalarExecutingAsync(command, eventData, result, httpToken);
            }

            using var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(httpToken, cancellationToken);
            return await base.ScalarExecutingAsync(command, eventData, result, linkedCts.Token);
        }
    }

    /// <summary>
    /// Helper estático para obter o CancellationToken da requisição HTTP atual
    /// Permite acesso ao token em qualquer camada da aplicação sem passar explicitamente
    /// </summary>
    public static class CancellationTokenHelper
    {
        private static IHttpContextAccessor? _httpContextAccessor;

        /// <summary>
        /// Inicializa o helper com o IHttpContextAccessor
        /// Deve ser chamado no Program.cs após a construção da aplicação
        /// </summary>
        public static void Initialize(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Obtém o CancellationToken da requisição HTTP atual
        /// </summary>
        /// <returns>
        /// CancellationToken da requisição ou CancellationToken.None se não estiver em contexto HTTP
        /// </returns>
        public static CancellationToken GetCurrent()
        {
            if (_httpContextAccessor?.HttpContext == null)
                return CancellationToken.None;

            // Tenta obter do Items primeiro (definido pelo ActionFilter)
            if (_httpContextAccessor.HttpContext.Items.TryGetValue("CancellationToken", out var token)
                && token is CancellationToken ct)
            {
                return ct;
            }

            // Fallback para RequestAborted
            return _httpContextAccessor.HttpContext.RequestAborted;
        }
    }

}