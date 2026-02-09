using CSCore.ClinicTime.Motor.EntidadesMock;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.ClinicTime.Motor
{
    public static class ConfigRedis
    {
        private const string STR_PACIENTES_ATENDIDOS = "pacientes-atendidos";
        public const string STR_LOCALIZACOES = "localizacao:sistema";
        public const string MBR_LOCALIZACAO_PACIENTES_MEMBRO = "paciente:";
        public const string MBR_LOCALIZACAO_CLINICA_MEMBRO = "clinica:";


        public const string STR_CONSULTA = "consulta:";
        public const string STR_FILA = "fila:";
        public const string STR_CONSULTA_CLINICA = "consulta:clinica:";
        public const string STR_CONSULTA_MEDICO = "consulta:medico:";

        public static string GetKeyPacientesAtendidos(DateOnly AgendaData, string AgendaID, string EstabID, string ProfID)
        {
            return $"{STR_PACIENTES_ATENDIDOS}:agenda:{AgendaData}:{AgendaID}:consulta:Estabelecimentos:{EstabID}:Profissionais:{ProfID}";
        }

        /// <summary>
        /// Esse metodo traz a chave para a estrutura
        /// consulta -> estabelecimentos -> [ESTAB_01, ESTAB_02] -> [PROFISIONAIS] -> PACIENTE DO PROFISSIONAL -> DADOS DO PACIENTE
        /// </summary>
        public static string GetKeyDadosPacientePorAgendaMedica(DateOnly agendaData, string AgendaID, string EstabID, string ProfID, string PacienteID)
        {
            return
                $"agenda:{agendaData}:{AgendaID}:consulta:Estabelecimentos:{EstabID}:" +
                $"Profissionais:{ProfID}:PacientesDados:{PacienteID}";
        }


        /// <summary>
        /// Retorna a chave que representa os valroes do sorted set que definem a fila de pacientes de um profssional em um estabelecimento em uma agenda
        /// </summary>
        /// <param name="AgendaID"></param>
        /// <param name="EstabID"></param>
        /// <param name="ProfissionalID"></param>
        /// <returns></returns>
        public static string GetKeyFila(string AgendaID,DateOnly AgendaData, string EstabID, string ProfissionalID )
        {
            return $"fila:Agenda:{AgendaData}:{AgendaID}:Estabelecimentos:{EstabID}:Profissionais:{ProfissionalID}";
        }

        public static string GetKeyGeoLocalizacoes()
        {
            return STR_LOCALIZACOES;
        }


        /// <summary>
        /// Isso é usado para criar a estrutura que armazena os dados de cada paciente, de cada consulta, de cada medico de cada estabelecimento.
        /// Paciente é filho de agenda, consulta, estabelecimento, medico. Essa estrutura é usada para atualizar a fila no sorted set.
        /// 
        /// Usada em 2 locais atualmente
        /// 1 - Ao finalizar a agenda, durante a sincronização MSSQL - Redis, iniciando os dados
        /// 2 - Sempre que a atualização do paciente muda no celular, atualizando os dados referentes a 
        /// distancia ate a clinica, tempo de chegada e velocidade, o que aumenta ou diminui o score total e redefine a posição dele na fila.
        /// 
        /// O metodo de redefinicao da fila é CalcularPrioridadeDaFila.RecalcularPrioridadeConsultaESalvaNoRedis
        /// </summary>
        public static HashEntry[] CriaEstruturaDeDadosDoPacienteDeUmaConsulta(
                bool isPcd,
                bool isIdoso,
                bool isGestante,
                bool isCheckinLocal,
                bool isCheckinApp,
                double distanciaAteClinica,
                double tempoAteClinica,
                double velocidadeAtual
            )
        {
            return new HashEntry[]
                {
            new("pacientePcd", isPcd),
            new("pacienteIdoso", isIdoso),
            new("pacienteGestante", isGestante),
            new("checkInApp", isCheckinApp),
            new("checkInNoLocal", isCheckinLocal),
            new("distanciaClinica_Metros", distanciaAteClinica),
            new("tempoChegada_Minutos", tempoAteClinica),
            new("velocidadeAtual_KMH", velocidadeAtual),
            new("ultimaAtualizacaoLoc", DateTime.UtcNow.ToString("O")),
            new("prioridadeEfetiva", 0m.ToString("F2")),
            new("tempoEmMinutosQueUsuarioEstaNoLocal", 0),
            new("horarioAtendimentoPaciente", "-"),
            new("paciente_em_consulta", false),
            new("horario_entrada_consulta", DateTime.UtcNow.ToString("t")),
            new("horario_saida_consulta", DateTime.UtcNow.ToString("t")),
            new("paciente_atendido", false),
                };
        }

        internal static RedisKey GetKeyJobsBackgroundPacienteAguardando(DateOnly AgendaData)
        {
            return $"dotnet-background-jobs:pacientes-aguardando-atendimento:{AgendaData}";
        }

        internal static RedisKey GetKeyEstabelecimentoConsultaDados(string estabelecimentoId)
        {
           return $"estabelecimento:{estabelecimentoId}:dados";
        }
    }
}
