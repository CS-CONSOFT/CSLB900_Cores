using System.ComponentModel.DataAnnotations;

namespace CSCore.Ex
{
    public class Dto_CreateLog
    {
        [MaxLength(2000, ErrorMessage = "Mensagem de log excedeu limite de 2000")]
        public string? Message { get; set; }


        public string? Detail { get; set; }


        [MaxLength(50, ErrorMessage = "Detalhes do log não pode ultrapassar 50")]
        public string? DetailLabel { get; set; }

        //INTEGRATION
        public int? Integration_TenantId { get; set; }
        public DateTime? Integration_Instant { get; set; }

        public int? Integration_Duration { get; set; }

        public string? Integration_Source { get; set; }

        public string? Integration_Endpoint { get; set; }

        public string? Integration_Action { get; set; }

        public string? Integration_Type { get; set; }

        public bool? Integration_IsExpose { get; set; }

        public string? Integration_EspaceName { get; set; }

        public string? Integration_ApplicationName { get; set; }

        public Dto_CreateLog() { }

        public Dto_CreateLog(string? message, string? detail)
        {
            Message = message;
            Detail = detail;
        }
    }
}
