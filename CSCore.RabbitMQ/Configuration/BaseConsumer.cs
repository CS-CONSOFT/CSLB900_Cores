using MassTransit;

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

    public abstract class BaseConsumerV2<T> : IConsumer<T> where T : class, IConsumerUsuarioId
    {
        public virtual Task Consume(ConsumeContext<T> context)
        {
            LogMessage(context);
            return Task.CompletedTask;
        }

        public abstract void LogMessage(ConsumeContext<T> context);
    }

    public interface IConsumerUsuarioId
    {
        string UsuarioID { get; }
    }
}
