using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.ClinicTime.Motor.Paciente.dto
{
    public record DtoDadosPrincipaisPaciente
    {
        
        public string AgendaID { get; init; } = null!;
        public DateOnly AgendaData { get; init; }
        public string ProfissionalId { get; init; } = null!;
        public string PacienteId { get; init; } = null!;
        public bool PacientePCD { get; init; } = false;
        public bool PacienteIdoso { get; init; } = false;
        public bool PacienteGestante { get; init; } = false;
        public bool PacienteIsChekinApp { get; init; } = false;
        public bool PacienteIsChekinLocal { get; init; } = false;
        public string EstabelecimentoId { get; init; } = null!;
        public double Latitude { get; init; }
        public double Longitude { get; init; }
        public double VelocidadeAtualPaciente { get; init; }
        public double DistanciaPacienteEstabelecimentoMetros { get; init; } = 0.0;



        public DtoDadosPrincipaisPaciente(
            string AGENDAID,
            DateOnly AgendaData,
            string PacienteId,
            string ProfissionalId,
            string EstabelecimentoId,
            double latitude,
            double longitude, 
            double VelocidadeAtualPaciente)
        {
            this.AgendaData = AgendaData;
            this.AgendaID = AGENDAID;
            this.PacienteId = PacienteId;
            this.ProfissionalId = ProfissionalId;
            this.EstabelecimentoId = EstabelecimentoId;
            Latitude = latitude;
            Longitude = longitude;
            this.VelocidadeAtualPaciente = VelocidadeAtualPaciente;
        }

        public static DtoDadosPrincipaisPaciente DtoVazioPorFaltaDeUsoNesseMetodo() => new DtoDadosPrincipaisPaciente(
            AGENDAID: string.Empty,
            AgendaData: DateOnly.MinValue,
            PacienteId: string.Empty,
            ProfissionalId: string.Empty,
            EstabelecimentoId: string.Empty,
            latitude: 0.0,
            longitude: 0.0,
            VelocidadeAtualPaciente: 0.0
        );
    }
}
