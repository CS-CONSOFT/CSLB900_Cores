using CSCore.Domain.Interfaces.GG._07X;
using CSCore.Ifs.Eventos.PublishObjetos;
using MassTransit;

namespace CSCore.RabbitMQ.Bus
{
    public class EvtBusRbtProcessa_Baixa_GG071 : IConsumer<Rbt_CS_RI_Processa_Baixa_GG071_Prm>
    {
        private IGG071Repository _gg071Repository;

        public EvtBusRbtProcessa_Baixa_GG071(IGG071Repository gg071Repository)
        {
            _gg071Repository = gg071Repository;
        }

        public async Task Consume(ConsumeContext<Rbt_CS_RI_Processa_Baixa_GG071_Prm> context)
        {
            Log.Information("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
             this.GetType().Name,
             DateTime.UtcNow.ToLocalTime(),
             context.Message.GetType().Name,
             context.Message);
            await _gg071Repository.CS_RI_Processa_Baixa(
            context.Message.in_tenant ?? 0,
            context.Message.in_usuarioID ?? "",
            context.Message.in_RI_ID_gg071 ?? 0,
            context.Message.in_StID_csicp_gg071_sta_solicitado ?? 0,
            context.Message.in_StID_csicp_gg071_sta_erro ?? 0,
            context.Message.in_StID_gg028_natOperacao_ReqInterna_ID ?? 0,
            context.Message.in_StID_gg073_ent_saida_saida_ID ?? 0,
            context.Message.in_StID_gg028_ent_saida_saida_ID ?? 0,
            context.Message.in_StID_gg028_ent_saida_entrada_ID ?? 0,
            context.Message.in_StID_csicp_gg072_stq_Inventario ?? 0,
            context.Message.in_StID_csicp_gg072_stq_SemSaldo ?? 0,
            context.Message.in_StID_csicp_gg072_stq_Erro ?? 0,
            context.Message.in_StID_csicp_gg072_stq_Baixado ?? 0,
            context.Message.in_StID_csicp_gg071_StatusId_Erro ?? 0,
            context.Message.in_StID_csicp_gg071_StatusId_Atentido ?? 0,
            context.Message.in_StID_estatica_sim_id ?? 0
                );
        }
    }
}

