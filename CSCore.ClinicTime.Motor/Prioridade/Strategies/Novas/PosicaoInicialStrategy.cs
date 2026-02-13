using CSCore.ClinicTime.Motor.Paciente.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.ClinicTime.Motor.Prioridade.Strategies.Novas
{
    internal class PosicaoInicialStrategy : IPrioridadeStrategy
    {
        public string Nome => string.Empty;
        public decimal Peso => 1m;

        /// <summary>
        /// Essa estratégia atribui a prioridade com base na posição de inserção do paciente na fila.
        /// O calculo é feito de forma que o paciente que foi inserido primeiro na fila tenha a maior prioridade, e o paciente que foi inserido por último tenha a menor prioridade.
        /// Procura o paciente na posição de inserção na fila, se encontrar, atribui a prioridade com base no total de pacientes nessa agenda menos a posição do paciente mais 1.
        /// Isso é feito asim pois o paciente que foi inserido primeiro na fila tem a maior prioridade, e o paciente que foi inserido por último tem a menor prioridade.
        /// 10 - 1 + 1 = 10 (prioridade máxima para o paciente 1)
        /// 10 - 2 + 1 = 9 (prioridade para o paciente 2)
        /// 10 - 3 + 1 = 8 (prioridade para o paciente 3)
        /// 10 - 4 + 1 = 7 (prioridade para o paciente 4)
        /// assim por diante, até o paciente 10, que teria a prioridade 1 (10 - 10 + 1 = 1)
        /// Ao final multiplica a prioridade encontrada pelo peso fixo 5
        /// Entao:
        /// 
        /// </summary>
        /// <param name="consulta"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        public decimal CalcularPrioridade(Dictionary<string, string> consulta, DtoDadosPrincipaisPaciente dto)
        {
            if (consulta.TryGetValue("posicaoInsercaoPacienteNaFila", out var posicaoInsercaoPacienteNaFila) 
                && int.TryParse(posicaoInsercaoPacienteNaFila, out var posicaoPaciente))
            {
                var prioridade = 0m;
                for (int i = dto.NumeroPacientesTotalDessaAgenda; i > 0; i--)
                {
                    if(i == posicaoPaciente)
                    {
                        var prioridadeBase = dto.NumeroPacientesTotalDessaAgenda - posicaoPaciente + 1;
                        prioridade = prioridadeBase * Peso;
                    }
                }
                return prioridade;
            }
            return 0m;
        }
    }
}
