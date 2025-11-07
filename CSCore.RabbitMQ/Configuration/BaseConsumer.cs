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
}
