using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.ClinicTime.Motor.RabbitMQ.PublishObjects.ClinicTime
{
    public record Rbt_CS_AtualizaPosicaoPaciente
    {
        public string AgendaID { get; init; } = null!;
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
    }
}
