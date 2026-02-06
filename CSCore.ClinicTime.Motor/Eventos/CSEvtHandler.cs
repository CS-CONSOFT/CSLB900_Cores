using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.ClinicTime.Motor.Eventos
{
    public class PacienteChegouEventArgs : EventArgs
    {
        public string PacienteId { get; set; } = string.Empty;
        public string ProfissionalId { get; set; } = string.Empty;
        public string AgendaID { get; set; } = string.Empty;
        public double DistanciaMetros { get; set; }
        public DateOnly AgendaData { get; set; }
        public string EstabelecimentoId { get; set; } = string.Empty;
        public string AgendaId { get; set; } = string.Empty;
        public Dictionary<string, string> DictConsulta { get; set; } = null!;

    }

    public class AtualizarPosicaoPacienteNaFila : EventArgs
    {
        public string PacienteId { get; set; } = string.Empty;
        public string ProfissionalId { get; set; } = string.Empty;
        public string AgendaID { get; set; } = string.Empty;
        public DateOnly AgendaData { get; set; }
        public string EstabelecimentoId { get; set; } = string.Empty;

    }


    public static class CSEvtHandler
    {
        public static event EventHandler<PacienteChegouEventArgs>? EvtHandlerPacienteChegouAoLocalDaConsulta;
        public static event EventHandler<AtualizarPosicaoPacienteNaFila>? EvtHandlerAtualizarHorarioPacienteNaFila;
        public static void DispararPacienteChegouAoLocal(PacienteChegouEventArgs args)
        {
            EvtHandlerPacienteChegouAoLocalDaConsulta?.Invoke(null, args);
        }

        public static void DispararAtualizarHorarioPacienteNaFila(AtualizarPosicaoPacienteNaFila args)
        {
            EvtHandlerAtualizarHorarioPacienteNaFila?.Invoke(null, args);
        }


    }
}