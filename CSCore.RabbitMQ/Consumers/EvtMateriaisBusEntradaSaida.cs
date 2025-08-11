using CSCore.Application.Dto;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._07X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.GG.Repository.BaixaSaldo;
using CSCore.RabbitMQ.Hub;
using CSCore.RabbitMQ.Hub.Ax;
using CSLB900.MSTools.Util;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using Serilog;

namespace CSCore.Ifs.GG
{
    public class EvtMateriaisBusEntradaSaida(IBaixaSaldo baixaSaldo,
        IGG073Repository gg073Repo,
        IGenerateProtocolo generateProtocolo,
        IHubContext<HubBaixarEstoqueGG073> hubContext,
        AppDbContext appDbContext)
        : IConsumer<Rbt_CS_BaixaMvto_EntSaida>
    {
        private readonly IBaixaSaldo _baixaSaldo = baixaSaldo;
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly IGG073Repository _gg073Repo = gg073Repo;
        private readonly IGenerateProtocolo _generateProtocolo = generateProtocolo;
        private readonly IHubContext<HubBaixarEstoqueGG073> _hubContext = hubContext;
        public async Task Consume(ConsumeContext<Rbt_CS_BaixaMvto_EntSaida> context)
        {

            Log.Warning("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
                this.GetType().Name,
                DateTime.UtcNow.ToLocalTime(),
                context.Message.GetType().Name,
                context.Message);


            using (var transaction = await _appDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    List<CSICP_GG074> listaGG074 = context.Message.ListaGG074;
                    int contadorErro = 0;
                    CSICP_GG073 gg073Encontrada = context.Message.GG073Corrente;



                    foreach (var currentMovimentoGG074 in listaGG074)
                    {
                        decimal protocolo = await _generateProtocolo
                           .Fcn_ProtocoloGeral(context.Message.ParametrosBaixaSaldo.BB001_ID!);

                        context.Message.ParametrosBaixaSaldo.GG520_ID = currentMovimentoGG074.Gg074Saldoid;
                        context.Message.ParametrosBaixaSaldo.QuantidadeASerBaixada = currentMovimentoGG074.Gg074Qtd;
                        context.Message.ParametrosBaixaSaldo.Detalhe_Movimento_ID = currentMovimentoGG074.Gg074Id.ToString();
                        context.Message.ParametrosBaixaSaldo.ValorUnitario = currentMovimentoGG074.Gg074Vunitario;
                        context.Message.ParametrosBaixaSaldo.NavCurrentGG074 = currentMovimentoGG074;
                        context.Message.ParametrosBaixaSaldo.ProtocoloGG028 = protocolo;


                        STATUS_SALDO statusSaldo = await _baixaSaldo
                            .CS_BaixarSaldo(
                            context.Message.Tenant_ID,
                            context.Message.ParametrosBaixaSaldo.GG520_ID,
                            protocolo.ToString(),
                            context.Message.ParametrosBaixaSaldo.ProgramaOrigem,
                            context.Message.ParametrosBaixaSaldo.UsuarioID,
                            context.Message.ParametrosBaixaSaldo.NavCurrentGG074.Gg074Id.ToString(),
                            context.Message.ParametrosBaixaSaldo.Header_Movimento_ID,
                            context.Message.ParametrosBaixaSaldo.Movimento_DataMovimento,
                            context.Message.ParametrosBaixaSaldo.QuantidadeASerBaixada,
                            context.Message.ParametrosBaixaSaldo.NavCurrentGG074.Gg074Tmovid ?? 0,
                            context.Message.ParametrosBaixaSaldo.StID_GG073_EntSaida_Saida_ID,
                            context.Message.ParametrosBaixaSaldo.StID_GG028_EntSaida_Saida_ID,
                            context.Message.ParametrosBaixaSaldo.StID_GG028_EntSaida_Entrada_ID,
                            context.Message.ParametrosBaixaSaldo.StID_GG028_Nat_ID,
                            context.Message.ParametrosBaixaSaldo.StID_Estatica_SIM_Id);

                        if (statusSaldo == STATUS_SALDO.EM_CONTAGEM)
                        {
                            contadorErro += 1;
                            await _baixaSaldo.AtualizaStatusDaGG074(currentMovimentoGG074, (int)ESTADO_SALDO.INVENTARIO);
                        }


                        if (statusSaldo == STATUS_SALDO.SALDO_ZERO || statusSaldo == STATUS_SALDO.SALDO_NEGATIVO)
                        {
                            contadorErro += 1;
                            await _baixaSaldo.AtualizaStatusDaGG074(currentMovimentoGG074, (int)ESTADO_SALDO.SALDO_ZERO);
                        }

                        if (statusSaldo == STATUS_SALDO.ERRO)
                        {
                            contadorErro += 1;
                            continue;
                        }


                        if (statusSaldo == STATUS_SALDO.OK)
                            await _baixaSaldo.AtualizaStatusDaGG074(currentMovimentoGG074, (int)ESTADO_SALDO.BAIXADO);
                    }


                    if (contadorErro == 0)
                        gg073Encontrada!.Gg073Statusid = context.Message.ParametrosBaixaSaldo.StID_IdGG073Status_Fechado;


                    gg073Encontrada!.NavBB005 = null;
                    gg073Encontrada!.NavSY001 = null;
                    gg073Encontrada!.Gg073AlmoxmovdNavigation = null;
                    gg073Encontrada!.Gg073AlmoxmovsaidaNavigation = null;



                    await _gg073Repo
                        .UpdateGG073StatusId(gg073Encontrada, context.Message.ParametrosBaixaSaldo.StID_IdGG073Status_Fechado);

                    await _appDbContext.SaveChangesAsync();
                    await transaction.CommitAsync();

                    await _hubContext.Clients.Group(context.Message.Usuario_ID)
                    .SendAsync(HubMethodNames.PROCESSAR_BAIXA_ESTOQUE_GG073, new
                    {
                        Success = true,
                        Message = "Sucesso ao baixar estoque!",
                        Timestamp = DateTime.UtcNow
                    });

                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    await _hubContext.Clients.Group(context.Message.Usuario_ID)
                     .SendAsync(HubMethodNames.PROCESSAR_BAIXA_ESTOQUE_GG073, new
                     {
                         Success = false,
                         Message = "Falha ao baixar estoque!",
                         DetailsError = HandlerExceptionMessage.CreateExceptionMessage(ex),
                         Timestamp = DateTime.UtcNow
                     });
                }
            }
        }


    }
}
