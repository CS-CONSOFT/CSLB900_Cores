using Microsoft.AspNetCore.SignalR;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.RabbitMQ.Hub.Ax
{
    public class BaseHub : Microsoft.AspNetCore.SignalR.Hub
    {

        public async Task JoinGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            Log.Information("👥 [SignalR] ConnectionId {ConnectionId} ENTROU no grupo {GroupName}",
                Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("ReceiveMessage", $"{Context.ConnectionId} entrou no grupo {groupName}.");
        }

        public async Task LeaveGroup(string groupName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
            Log.Information("👋 [SignalR] ConnectionId {ConnectionId} SAIU do grupo {GroupName}",
                Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("ReceiveMessage", $"{Context.ConnectionId} saiu do grupo {groupName}.");
        }

        // ✅ Log quando conectar
        public override async Task OnConnectedAsync()
        {
            var user = Context.User?.Identity?.Name ?? "Anônimo";

            Log.Information("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Log.Information("✅ [SignalR] CONEXÃO ESTABELECIDA");
            Log.Information("   ConnectionId: {ConnectionId}", Context.ConnectionId);
            Log.Information("   User: {User}", user);
            Log.Information("   UserAgent: {UserAgent}", Context.GetHttpContext()?.Request.Headers["User-Agent"].ToString());
            Log.Information("   Remote IP: {RemoteIp}", Context.GetHttpContext()?.Connection.RemoteIpAddress);
            Log.Information("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            await base.OnConnectedAsync();
        }
    }
}
