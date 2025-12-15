using CSCore.Ifs.AnaliseDeCredito.AnaliseCredito;
using CSCore.Ifs.AnaliseDeCredito.RabbitMQ;
using CSCore.Ifs.Compartilhado;
using CSLB900.MSTools.Util;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using Serilog;
using System.Text.Json;

namespace CSCore.RabbitMQ.Consumers
{
    public class EvtBusAnaliseDeCredito(CreditoSemScore creditoSemScore,
       IRepoSaveLogServiceCenter repoSaveLogServiceCenter) : BaseConsumer<Rbt_CS_AnaliseCredito>(repoSaveLogServiceCenter)
    {
        private CreditoSemScore _creditoSemScore = creditoSemScore;

        public async Task Consume(ConsumeContext<Rbt_CS_AnaliseCredito> context)
        {
            Log.Information("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
                    this.GetType().Name,
                    DateTime.UtcNow.ToLocalTime(),
                    context.Message.GetType().Name,
                    context.Message);
            try
            {

                await _creditoSemScore.ExecutarAnaliseCredito(
                    context.Message.in_CalcularScoreClearsale,
                    context.Message.in_tenantID,
                    context.Message.in_conta_ID);


                await NotificarSucessoProcessamento(
                   UsuarioID: context.Message.in_usuarioID,
                   Tenant: context.Message.in_tenantID,
                   context: context,
                   Message: "Sucesso ao realizar analise de credito",
                   Group: "analise-de-credito",
                   Method: "ANALISE_CREDITO",
                  JsonParametrosParaServiceCenter: JsonSerializer.Serialize(new
                  {
                      PrmAnaliseDeCredito = context.Message
                  }));
            }
            catch (Exception ex)
            {
                await NotificarFalhaProcessamento(
                      UsuarioID: context.Message.in_usuarioID,
                      Tenant: context.Message.in_tenantID,
                      context: context,
                   Message: "Falha ao realizar analise de credito: " + HandlerExceptionMessage.CreateExceptionMessage(ex),
                   Group: "analise-de-credito",
                   Method: "ANALISE_CREDITO",
                  JsonParametrosParaServiceCenter: JsonSerializer.Serialize(new
                  {
                      PrmAnaliseDeCredito = context.Message
                  }));
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }
    }
}
