//using CSCore.ClinicTime.Motor.Paciente;
//using CSCore.ClinicTime.Motor.Paciente.dto;
//using CSCore.ClinicTime.Motor.RabbitMQ.PublishObjects.ClinicTime;
//using MassTransit;
//using Microsoft.Extensions.Logging;

//namespace CSCore.ClinicTime.Motor.RabbitMQ.Consumers
//{
//    public class EvtConsumerAtualizaPosicaoPaciente : IConsumer<Rbt_CS_AtualizaPosicaoPaciente>
//    {
//        private readonly IClinicTimeMotorPaciente clinicTimeMotorPaciente;
//        private readonly ILogger<EvtConsumerAtualizaPosicaoPaciente> logger;

//        public EvtConsumerAtualizaPosicaoPaciente(
//            ILogger<EvtConsumerAtualizaPosicaoPaciente> logger,
//            IClinicTimeMotorPaciente clinicTimeMotorPaciente)
//        {
//            this.logger = logger;
//            this.clinicTimeMotorPaciente = clinicTimeMotorPaciente;
//        }

//        public async Task Consume(ConsumeContext<Rbt_CS_AtualizaPosicaoPaciente> context)
//        {
//            try
//            {
//                this.logger.LogInformation("Recebida mensagem de atualização de posição do paciente: {@Message}", context.Message);
//                var dto = DtoDadosPrincipaisPaciente.FromRbtMessage(context.Message);
//                this.logger.LogInformation("Convertida mensagem para DTO: {@Dto}", dto);
//                await clinicTimeMotorPaciente.AtualizaPosicaoDoPacienteAoSeMovimentar(dto);
//                this.logger.LogInformation("Processamento da mensagem de atualização de posição do paciente concluído para o pacienteId: {PacienteId}", dto.PacienteId);
//            }
//            catch (Exception ex)
//            {
//                this.logger.LogError(ex, "Erro ao processar mensagem de atualização de posição do paciente: {@Message}", context.Message);
//                throw;
//            }
//        }
//    }
//}