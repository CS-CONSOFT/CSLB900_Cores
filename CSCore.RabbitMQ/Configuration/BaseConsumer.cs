using CSCore.Ifs.Compartilhado;
using CSCore.RabbitMQ.Hub;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using Serilog;
using System.Net.Http.Json;

namespace CSCore.RabbitMQ.Configuration
{
    [Obsolete]
    public abstract class BaseConsumer<T> : IConsumer<T> where T : class
    {
        public virtual Task Consume(ConsumeContext<T> context)
        {
            LogMessage(context);
            return Task.CompletedTask;
        }

        public abstract void LogMessage(ConsumeContext<T> context);
    }

    /*NOVA CLASSE*/
    [Obsolete]
    public abstract class BaseConsumerV2<T> : IConsumer<T> where T : class, IConsumerUsuarioId, ITenantId
    {
        private readonly IHubContext<HubNotification> _hubContext;
        private readonly IRepoSaveLogServiceCenter _repoSaveLogServiceCenter;


        protected BaseConsumerV2(IHubContext<HubNotification> hubContext, IRepoSaveLogServiceCenter repoSaveLogServiceCenter)
        {
            _hubContext = hubContext;
            _repoSaveLogServiceCenter = repoSaveLogServiceCenter;
        }

        public virtual Task Consume(ConsumeContext<T> context)
        {
            LogMessage(context);
            return Task.CompletedTask;
        }

        public virtual async Task SaveLogServiceCenter(int TenantID, string mensagem, string jsonParametros)
        {
            await _repoSaveLogServiceCenter.SalvarLogAsync(
                TenantID,
                "RabbitMQ_Consumer",
                "0",
                mensagem,
                jsonParametros);
        }

        public abstract void LogMessage(ConsumeContext<T> context);
        public virtual async Task SendMessageToHub(string usuarioID, string hubGroupName, string hubMethodName, string message)
        {
            await _hubContext.Clients.Group(hubGroupName + usuarioID)
               .SendAsync(hubMethodName, new
               {
                   Success = true,
                   Message = message,
                   Timestamp = DateTime.UtcNow
               });
        }
    }


    /*NOVA CLASSE 2 */
    public abstract class BaseConsumerV3<T> : IConsumer<T> where T : class, IConsumerUsuarioId, ITenantId
    {
        private readonly IRepoSaveLogServiceCenter _repoSaveLogServiceCenter;
        private static readonly HttpClient client = new();

        protected BaseConsumerV3(IRepoSaveLogServiceCenter repoSaveLogServiceCenter)
        {
            _repoSaveLogServiceCenter = repoSaveLogServiceCenter;
        }

        public virtual Task Consume(ConsumeContext<T> context)
        {
            LogMessage(context);
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

        private void LogMessage(ConsumeContext<T> context)
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
                context.Message.InTenantID,
                context.Message.UsuarioID,
                DateTime.UtcNow.ToLocalTime(),
                Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
        }

        protected async Task NotificarSucessoProcessamento(
            ConsumeContext<T> context,
            string Message,
            string Group,
            string Method,
            string JsonParametrosParaServiceCenter,
            string? IdReferencia = null)
        {
            LogMessage(context);
            var finalMessage = $"Sucesso ao processar {Group} - {Method}";
            var msg = new MessageDto
            {
                Content = finalMessage,
                GroupName = Group + "-" + context.Message.UsuarioID,
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
             context.Message.InTenantID,
             finalMessage,
             JsonParametrosParaServiceCenter);
        }

        protected async Task NotificarFalhaProcessamento(
                 ConsumeContext<T> context,
                 string Message,
                 string Group,
                 string Method,
                 string JsonParametrosParaServiceCenter,
                 string? IdReferencia = null)
        {
            LogMessage(context);

            var finalMessage = $"Falha ao processar {Group} - {Method}";
            var msg = new MessageDto
            {
                Content = finalMessage,
                GroupName = Group + "-" + context.Message.UsuarioID,
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
                finalMessage = finalMessage + " || ERRO AO NOTIFICAR VIA SIGNAL - "+ $"Erro ao notificar API externa: {result.StatusCode} - {await result.Content.ReadAsStringAsync()}";
            }

            await SaveLogServiceCenter(
             context.Message.InTenantID,
             finalMessage,
             JsonParametrosParaServiceCenter);
        }

    }



    /*INTERFACES*/
    public interface IConsumerUsuarioId
    {
        string UsuarioID { get; }
    }

    public interface ITenantId
    {
        int InTenantID { get; }
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
