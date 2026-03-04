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
        public int NumeroPacientesTotalDessaAgenda { get; init; } = 0;

        public int PosicaoQuePacienteFoiInseridoNaFila { get; init; } = -1;
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
            int PosicaoQuePacienteFoiInseridoNaFila,
            int NumeroPacientesTotalDessaAgenda,
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
            this.NumeroPacientesTotalDessaAgenda = NumeroPacientesTotalDessaAgenda;
            this.PosicaoQuePacienteFoiInseridoNaFila = PosicaoQuePacienteFoiInseridoNaFila;
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

  
       
    }
}
