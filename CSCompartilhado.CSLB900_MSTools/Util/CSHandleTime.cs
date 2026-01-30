using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLB900.MSTools.Util
{
    public static class CSHandleTime
    {
        /// <summary>
        /// Retorna a hora local atual formatada como uma string de 24 horas no formato "HH:mm".
        /// </summary>
        /// <returns>Uma string representando a hora local atual no formato de 24 horas (horas e minutos).</returns>
        public static string GetHoraAtualFormatada()=>DateTime.UtcNow.ToString("HH:mm");

        /// <summary>
        /// Retorna a data atual formatada como uma string no formato ISO 8601 "aaaa-MM-dd".
        /// </summary>
        /// <returns>Uma string representando a data atual no formato "aaaa-MM-dd".</returns>
        public static string GetDataAtualFormatada() => DateTime.UtcNow.ToString("yyyy-MM-dd");

        /// <summary>
        /// Determina se a hora local atual está dentro do horário comercial padrão, excluindo o horário de almoço.
        /// </summary>
        /// <remarks>Este método usa a hora do sistema local para avaliar a hora atual. Ele não
        /// leva em consideração intervalos para almoço ou feriados e assume que o horário comercial é das 8:00 às 18:00, excluindo
        /// as 18:00.</remarks>
        /// <returns>verdadeiro se a hora atual estiver entre 8:00 e 17:59; caso contrário, falso.</returns>
        public static bool EhHorarioComercialSemAlmoco() => DateTime.UtcNow.Hour >= 8 && DateTime.UtcNow.Hour < 18;


        /// <summary>
        /// Determina se a hora local atual está dentro do horário comercial padrão, excluindo o horário de almoço.
        /// </summary>
        /// <remarks>O horário comercial é considerado das 8:00 às 12:00 e das 14:00 às 18:00, horário local.
        // O horário de almoço, das 12:00 às 14:00, é excluído. O resultado é baseado no fuso horário local do sistema.
        // </remarks>
        /// <returns>verdadeiro se a hora atual estiver entre 8:00 e 12:00 ou entre 14:00 e 18:00; caso contrário, falso.</returns>
        public static bool EhHorarioComercialComAlmoco() => DateTime.UtcNow.Hour >= 8 && DateTime.UtcNow.Hour< 12 || DateTime.UtcNow.Hour >= 14 && DateTime.UtcNow.Hour <= 18;

        /// <summary>
        /// Retorna o nome do dia da semana atual em Tempo Universal Coordenado (UTC).
        /// </summary>
        /// <remarks>O valor retornado reflete o dia da semana com base no fuso horário UTC, e não na
        /// hora do sistema local.</remarks>
        /// <returns>Uma string representando o dia da semana atual em UTC, como "Monday" ou "Friday".</returns>
        public static string DiaDaSemanaAtual() => new CultureInfo("pt-BR").DateTimeFormat.GetDayName(DateTime.UtcNow.DayOfWeek);
    }
}
