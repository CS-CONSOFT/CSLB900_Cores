using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.ClinicTime.Motor.Prioridade
{

    public enum EnumStatusPaciente
    {
        NAO_CHEGOU, CHEGOU, SAIU, CHEGOU_E_SE_LOCOMOVEU_NO_LOCAL
    }
    public record EstadoAtualPaciente(EnumStatusPaciente StatusAtual, EnumStatusPaciente? StatusAnterior, Dictionary<EnumStatusPaciente, int> ContagemStatus);
    
    public static class ConfiguraStatusPaciente
    {
        private static EnumStatusPaciente StatusAtual { get; set; } = EnumStatusPaciente.NAO_CHEGOU;
        private static EnumStatusPaciente? StatusAnterior { get; set; } = null;
        public static EstadoAtualPaciente EstadoAtualPaciente { get; private set; } = null!;

        public static Dictionary<EnumStatusPaciente, int> ContagemStatus { get; private set; } = new Dictionary<EnumStatusPaciente, int>
        {
            { EnumStatusPaciente.NAO_CHEGOU, 0 },
            { EnumStatusPaciente.CHEGOU, 0 },
            { EnumStatusPaciente.SAIU, 0 }
        };

        public static void ResetarStatus()
        {
            ContagemStatus[EnumStatusPaciente.NAO_CHEGOU] = 0;
            EstadoAtualPaciente = new EstadoAtualPaciente(EnumStatusPaciente.NAO_CHEGOU, null, ContagemStatus);
        }

        public static void PacienteChegouESeLocomoveuNoLocal()
        {
            StatusAnterior = StatusAtual;
            StatusAtual = EnumStatusPaciente.CHEGOU_E_SE_LOCOMOVEU_NO_LOCAL;
            ContagemStatus[EnumStatusPaciente.CHEGOU_E_SE_LOCOMOVEU_NO_LOCAL]++;
            EstadoAtualPaciente = new EstadoAtualPaciente(StatusAtual, StatusAnterior, ContagemStatus);
        }

        public static void PacienteChegouAoLocal()
        {
            StatusAnterior = StatusAtual;
            StatusAtual = EnumStatusPaciente.CHEGOU;
            ContagemStatus[EnumStatusPaciente.CHEGOU]++;
            EstadoAtualPaciente = new EstadoAtualPaciente(StatusAtual, StatusAnterior, ContagemStatus);
        }

        public static void PacienteChegouESaiuDoLocal()
        {
            StatusAnterior = StatusAtual;
            StatusAtual = EnumStatusPaciente.SAIU;
            ContagemStatus[EnumStatusPaciente.SAIU]++;
            EstadoAtualPaciente = new EstadoAtualPaciente(StatusAtual, StatusAnterior, ContagemStatus);
        }
    }
}
