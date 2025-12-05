using CSCore.Ifs.Compartilhado;
using CSCore.RabbitMQ.Hub;
using CSCore.RabbitMQ.Hub.Ax;
using DocumentFormat.OpenXml.InkML;
using MassTransit;
using Microsoft.AspNetCore.SignalR;

namespace CSCore.RabbitMQ.Configuration
{
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

    /*INTERFACES*/
    public interface IConsumerUsuarioId
    {
        string UsuarioID { get; }
    }

    public interface ITenantId
    {
        int InTenantID { get; }
    }
}
