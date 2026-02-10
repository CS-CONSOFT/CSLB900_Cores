using CSCore.ClinicTime.Motor.Eventos;
using CSCore.ClinicTime.Motor.Paciente.dto;

namespace CSCore.ClinicTime.Motor.Prioridade.Strategies
{
    /// <summary>
    /// Estratégia de prioridade para check-in realizado no local
    /// Ela não é utilizada no foreach de estrategias que ocorre sempre que o paciente atualiza a localizacao porque
    /// no momento que ele fizer o chekin local, ele nao vai mais atualizar a localiação, logo nao passara por aqui.
    /// 
    /// Por isso, quando o sistema detecta que ele chegou ao local, um evento é disparado em CSEvtHandler.DispararPacienteChegouAoLocal na classe ProximidadePrioridadeStrategy
    /// e esse evento é tratado em CSEvtConsumerPacienteChegouAoLocal, recuperando o valor da prioriedade calculada salvo no redis e incrementando com o calculo realizado
    /// aqui nesse codigo, e entao salva a nova prioridade no redis.
    /// </summary>
    public class CheckInLocalPrioridadeStrategy : IPrioridadeStrategy
    {
        public string Nome => "CheckIn Local";
        public decimal Peso => 10000m;

        public decimal CalcularPrioridade(Dictionary<string, string> consulta, DtoDadosPrincipaisPaciente _)
        {
            consulta.TryGetValue("checkInNoLocal", out var checkInLocal);
            bool.TryParse(checkInLocal, out bool checkInLocalBool);
            bool estaNoLocal = checkInLocalBool;
            if (estaNoLocal)
            {
                return Peso;
            }
            return 0m;
        }
    }
}
