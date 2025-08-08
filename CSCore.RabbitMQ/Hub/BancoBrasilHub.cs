namespace CSCore.RabbitMQ.Hub
{
    public class BancoBrasilHub : Microsoft.AspNetCore.SignalR.Hub
    {
        public async Task JoinGroup(string correlationId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, correlationId);
        }

        public async Task LeaveGroup(string correlationId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, correlationId);
        }
    }
}