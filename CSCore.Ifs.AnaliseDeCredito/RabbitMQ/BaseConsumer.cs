using CSCore.Ifs.Compartilhado;
using MassTransit;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.AnaliseDeCredito.RabbitMQ
{
    public abstract class BaseConsumer<T> : IConsumer<T> where T : class
    {
        private readonly IRepoSaveLogServiceCenter _repoSaveLogServiceCenter;
        private static readonly HttpClient client = new();


        protected BaseConsumer(IRepoSaveLogServiceCenter repoSaveLogServiceCenter)
        {
            _repoSaveLogServiceCenter = repoSaveLogServiceCenter;
        }

        public virtual Task Consume(ConsumeContext<T> context)
        {
            return Task.CompletedTask;
        }

        private async Task SaveLogServiceCenter(int TenantID, string mensagem, string jsonParametros)
        {
            await _repoSaveLogServiceCenter.SalvarLogAsync(
                TenantID,
                "RabbitMQ_Consumer",
                "0",
                mensagem,
                jsonParametros);
        }

        private void LogMessage(ConsumeContext<T> context, string UsuarioID, int Tenant)
        {
            Log.Information(
                "\n====================[RabbitMQ - Consumer Recebeu Mensagem]====================\n" +
                "Consumer     : {Consumer}\n" +
                "TipoMensagem : {MessageType}\n" +
                "TenantID     : {TenantID}\n" +
                "UsuarioID    : {UsuarioID}\n" +
                "Timestamp    : {Ti mestamp}\n" +
                "Ambiente     : {Environment}\n" +
                "===============================================================================",
                this.GetType().Name,
                context.Message.GetType().Name,
                Tenant,
                UsuarioID,
                DateTime.UtcNow.ToLocalTime(),
                Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
        }

        protected async Task NotificarSucessoProcessamento(
            string UsuarioID,
            int Tenant,
            ConsumeContext<T> context,
            string Message,
            string Group,
            string Method,
            string JsonParametrosParaServiceCenter,
            string? IdReferencia = null)
        {
            LogMessage(context, UsuarioID, Tenant);
            var finalMessage = $"Sucesso ao processar {Group} - {Method}";
            var msg = new MessageDto
            {
                Content = finalMessage,
                GroupName = Group + "-" + UsuarioID,
                MethodName = Method,
                Message = Message,
                Success = true,
                IDReferente = IdReferencia
            };
            var result = await client.PostAsJsonAsync(
                "https://apidsv17.sophiaerp.cloud/signalR", msg);
            if (!result.IsSuccessStatusCode)
            {
                Log.Information($"Erro ao notificar API externa: {result.StatusCode} - {await result.Content.ReadAsStringAsync()}");
                finalMessage = finalMessage + " || ERRO AO NOTIFICAR VIA SIGNAL - " + $"Erro ao notificar API externa: {result.StatusCode} - {await result.Content.ReadAsStringAsync()}";
            }

            await SaveLogServiceCenter(
            Tenant,
             finalMessage,
             JsonParametrosParaServiceCenter);
        }

        protected async Task NotificarFalhaProcessamento(
             string UsuarioID,
            int Tenant,
                 ConsumeContext<T> context,
                 string Message,
                 string Group,
                 string Method,
                 string JsonParametrosParaServiceCenter,
                 string? IdReferencia = null)
        {
            LogMessage(context, UsuarioID, Tenant);

            var finalMessage = $"Falha ao processar {Group} - {Method}";
            var msg = new MessageDto
            {
                Content = finalMessage,
                GroupName = Group + "-" + UsuarioID,
                MethodName = Method,
                Message = Message,
                Success = false,
                IDReferente = IdReferencia
            };
            var result = await client.PostAsJsonAsync(
                    "https://apidsv17.sophiaerp.cloud/signalR", msg);
            if (!result.IsSuccessStatusCode)
            {
                Log.Information($"Erro ao notificar API externa: {result.StatusCode} - {await result.Content.ReadAsStringAsync()}");
                finalMessage = finalMessage + " || ERRO AO NOTIFICAR VIA SIGNAL - " + $"Erro ao notificar API externa: {result.StatusCode} - {await result.Content.ReadAsStringAsync()}";
            }

            await SaveLogServiceCenter(
             Tenant,
             finalMessage,
             JsonParametrosParaServiceCenter);
        }

    }

    public class MessageDto
    {
        public string Content { get; set; } = string.Empty;
        public string GroupName { get; set; } = string.Empty;
        public string MethodName { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public bool Success { get; set; }
        public string? IDReferente { get; set; } = string.Empty;
    }
}
