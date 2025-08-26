using CSCore.Domain.Interfaces.GG._03X;
using CSCore.RabbitMQ.Hub.Ax;
using CSCore.RabbitMQ.PublishObjetos;
using CSLB900.MSTools.Util;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using Serilog;
namespace CSCore.RabbitMQ.Bus
{
    public class EvtBusProcessaAjustePrecoGG031 : IConsumer<Rbt_CS_ProcessaAjustePreco_GG031_Prm>
    {
        private readonly IGG031Repository _gg031Repository;

        public EvtBusProcessaAjustePrecoGG031(IGG031Repository gg031Repository)
        {
            _gg031Repository = gg031Repository;
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
            }
            catch (Exception ex)
            {
                await _hubContext.Clients.Group("gera-protocolo-ci-" + context.Message.InUsuarioID)
              .SendAsync(HubMethodNames.GERA_PROTOCOLO_CI, new
              {
                  Success = false,
                  Message = "Falha ao gerar protocolo CI: " + HandlerExceptionMessage.CreateExceptionMessage(ex),
                  Timestamp = DateTime.UtcNow
              });
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }
    }
}
