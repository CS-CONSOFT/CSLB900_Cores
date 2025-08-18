using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ex.Personalizada
{
    /// <summary>
    /// Exception personalizada para situações onde uma operação de salvamento não deve ser executada.
    /// </summary>
    [Serializable]
    public class ExceptionSemAuditoria : SystemException
    {
        /// <summary>
        /// Construtor padrão da exception.
        /// </summary>
        public ExceptionSemAuditoria()
        {
        }

        /// <summary>
        /// Construtor com mensagem personalizada.
        /// </summary>
        /// <param name="message">Mensagem de erro.</param>
        public ExceptionSemAuditoria(string? message) : base(message)
        {
        }

        /// <summary>
        /// Construtor com mensagem e exception interna.
        /// </summary>
        /// <param name="message">Mensagem de erro.</param>
        /// <param name="innerException">Exception interna que causou esta exception.</param>
        public ExceptionSemAuditoria(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Construtor para deserialização.
        /// </summary>
        /// <param name="info">Informações de serialização.</param>
        /// <param name="context">Contexto de streaming.</param>
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected ExceptionSemAuditoria(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
