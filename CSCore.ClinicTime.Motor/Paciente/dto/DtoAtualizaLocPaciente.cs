using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.ClinicTime.Motor.Paciente.dto
{
    public record DtoAtualizaLocPaciente
    {
        public string ConsultaId { get; init; } = null!;
        public string ProfissionalId { get; init; } = null!;
        public string PacienteId { get; init; } = null!;
        public string EstabelecimentoId { get; init; } = null!;
        public double Latitude { get; init; }
        public double Longitude { get; init; }
        public double VelocidadeAtualPaciente { get; init; }


        public DtoAtualizaLocPaciente(string PacienteId, string ProfissionalId,string ConsultaID,string EstabelecimentoId, double latitude, double longitude, double VelocidadeAtualPaciente)
        {
            this.PacienteId = PacienteId;
            this.ProfissionalId = ProfissionalId;
            this.EstabelecimentoId = EstabelecimentoId;
            Latitude = latitude;
            Longitude = longitude;
            this.VelocidadeAtualPaciente = VelocidadeAtualPaciente;
            this.ConsultaId = ConsultaID;
        }
    }
}
