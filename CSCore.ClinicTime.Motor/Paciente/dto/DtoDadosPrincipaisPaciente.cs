using CSCore.ClinicTime.Motor.RabbitMQ.PublishObjects.ClinicTime;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.ClinicTime.Motor.Paciente.dto
{
    public record DtoPacienteCheknApp(string AgendaID, DateOnly AgendaData, string ProfissionalID, string PacienteID, string EstabelecimentoID, DateTime HoraChekinApp);
    public record DtoDadosPrincipaisPaciente
    {

        public string AgendaID { get; init; } = null!;
        public DateOnly AgendaData { get; init; }
        public TimeOnly AgendaHorarioInicio { get; set; }
        public TimeOnly AgendaHorarioFim { get; set; }

        public string ProfissionalId { get; init; } = null!;
        public string PacienteId { get; init; } = null!;
        public bool PacienteIsChekinLocal { get; init; } = false;
        public string EstabelecimentoId { get; init; } = null!;
        public double Latitude { get; init; }
        public double Longitude { get; init; }
        public double VelocidadeAtualPaciente { get; init; }
        public double DistanciaPacienteEstabelecimentoMetros { get; init; } = 0.0;



        public DtoDadosPrincipaisPaciente(
            string AGENDAID,
            DateOnly AgendaData,
            TimeOnly AgendaHorarioInicio,
            TimeOnly AgendaHorarioFim,
            string PacienteId,
            string ProfissionalId,
            string EstabelecimentoId,
            double latitude,
            double longitude,
            double VelocidadeAtualPaciente)
        {
            this.AgendaHorarioInicio = AgendaHorarioInicio;
            this.AgendaHorarioFim = AgendaHorarioFim;
            this.AgendaData = AgendaData;
            this.AgendaID = AGENDAID;
            this.PacienteId = PacienteId;
            this.ProfissionalId = ProfissionalId;
            this.EstabelecimentoId = EstabelecimentoId;
            Latitude = latitude;
            Longitude = longitude;
            this.VelocidadeAtualPaciente = VelocidadeAtualPaciente;
        }

  
        public static DtoDadosPrincipaisPaciente FromRbtMessage(Rbt_CS_AtualizaPosicaoPaciente rbt_CS_Atualiza)
        {
            return new DtoDadosPrincipaisPaciente(
                AGENDAID: rbt_CS_Atualiza.AgendaID,
                AgendaData: rbt_CS_Atualiza.AgendaData,
                AgendaHorarioInicio: rbt_CS_Atualiza.AgendaHorarioInicio,
                AgendaHorarioFim: rbt_CS_Atualiza.AgendaHorarioFim,
                PacienteId: rbt_CS_Atualiza.PacienteId,
                ProfissionalId: rbt_CS_Atualiza.ProfissionalId,
                EstabelecimentoId: rbt_CS_Atualiza.EstabelecimentoId,
                latitude: rbt_CS_Atualiza.Latitude,
                longitude: rbt_CS_Atualiza.Longitude,
                VelocidadeAtualPaciente: rbt_CS_Atualiza.VelocidadeAtualPaciente
            );
        }

        public static Rbt_CS_AtualizaPosicaoPaciente FromDto(DtoDadosPrincipaisPaciente _this)
        {
            return new Rbt_CS_AtualizaPosicaoPaciente
            {
                AgendaID = _this.AgendaID,
                AgendaData = _this.AgendaData,
                AgendaHorarioInicio = _this.AgendaHorarioInicio,
                AgendaHorarioFim = _this.AgendaHorarioFim,
                PacienteId = _this.PacienteId,
                ProfissionalId = _this.ProfissionalId,
                EstabelecimentoId = _this.EstabelecimentoId,
                Latitude = _this.Latitude,
                Longitude = _this.Longitude,
                VelocidadeAtualPaciente = _this.VelocidadeAtualPaciente,
                PacienteIsChekinLocal = _this.PacienteIsChekinLocal,
                DistanciaPacienteEstabelecimentoMetros = _this.DistanciaPacienteEstabelecimentoMetros
            };

        }

        public static DtoDadosPrincipaisPaciente DtoVazioPorFaltaDeUsoNesseMetodo() => new DtoDadosPrincipaisPaciente(
            AGENDAID: string.Empty,
            AgendaData: DateOnly.MinValue,
            AgendaHorarioInicio: TimeOnly.MinValue,
            AgendaHorarioFim: TimeOnly.MinValue,
            PacienteId: string.Empty,
            ProfissionalId: string.Empty,
            EstabelecimentoId: string.Empty,
            latitude: 0.0,
            longitude: 0.0,
            VelocidadeAtualPaciente: 0.0
        );
    }
}
