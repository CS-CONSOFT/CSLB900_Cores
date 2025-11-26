using CSCore.Domain.Interfaces.GG._03X;

using CSCore.RabbitMQ.Hub;
using CSCore.RabbitMQ.Hub.Ax;
using CSCore.RabbitMQ.PublishObjetos;
using CSLB900.MSTools.Util;
using MassTransit;
using Microsoft.AspNetCore.SignalR;

using Serilog;
using System.Text.Json;
namespace CSCore.RabbitMQ.Bus
{
    public class EvtBusProcessaAjustePrecoGG031 : IConsumer<Rbt_CS_ProcessaAjustePreco_GG031_Prm>
    {
        private readonly IGG031Repository _gg031Repository;
        private readonly IHubContext<HubNotification> _hubContext;


        public EvtBusProcessaAjustePrecoGG031(IGG031Repository gg031Repository, IHubContext<HubNotification> hubContext)
        {
            _gg031Repository = gg031Repository;
            _hubContext = hubContext;

        }

        public async Task Consume(ConsumeContext<Rbt_CS_ProcessaAjustePreco_GG031_Prm> context)
        {
            Log.Information("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
                    this.GetType().Name,
                    DateTime.UtcNow.ToLocalTime(),
                    context.Message.GetType().Name,
                    context.Message);

            try
            {
                await _gg031Repository.ProcessaAjustePreco(
                    context.Message.movimentoId,
                    context.Message.tenantId,
                    context.Message.in_StID_Gg030Status_Solicitado,
                    context.Message.in_StID_Gg023_Val_Venda,
                    context.Message.in_StID_Gg023_Val_CustoReal,
                    context.Message.in_StID_Gg023_Val_Custo,
                    context.Message.in_StID_Gg023_Val_Reposicao,
                    context.Message.in_StID_Gg023_Val_CustoMedio,
                    context.Message.in_StID_Gg023_Val_ECommmerce,
                    context.Message.in_StID_Gg030_Atendido
                );

                await _hubContext.Clients.Group("ajuste-de-preco-gg031-" + context.Message.usuarioID)
            .SendAsync(HubMethodNames.AJUSTE_PRECO_GG031, new
            {
                Success = false,
                Message = "Sucesso ao realizar ajuste de preço",
                Timestamp = DateTime.UtcNow
            });

                await _gg031Repository.SalvarLogAsync(
                    tenantId: context.Message.tenantId, 
                    nomeUsuario: context.Message.usuarioID,
                    severidade: "0",
                    mensagem: "AJUSTE_PRECO_GG031 processado com sucesso!");

            }
            catch (Exception ex)
            {
                await _gg031Repository.SalvarLogAsync(
                    tenantId: context.Message.tenantId,
                    nomeUsuario: context.Message.usuarioID,
                    severidade: "0",
                    mensagem: "Falha ao realizar ajuste de preço: " + HandlerExceptionMessage.CreateExceptionMessage(ex),
                    jsonBody: JsonSerializer.Serialize(context.Message));

                await _hubContext.Clients.Group("ajuste-de-preco-gg031-" + context.Message.usuarioID)
              .SendAsync(HubMethodNames.AJUSTE_PRECO_GG031, new
              {
                  Success = false,
                  Message = "Falha ao realizar ajuste de preço: " + HandlerExceptionMessage.CreateExceptionMessage(ex),
                  Timestamp = DateTime.UtcNow
              });
                throw;
            }
        }
    }
}
