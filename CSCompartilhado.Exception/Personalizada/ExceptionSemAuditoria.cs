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
        /// Código específico desta exception.
        /// </summary>
        public int ErrorCode { get; }

        /// <summary>
        /// Construtor padrão da exception.
        /// </summary>
        public ExceptionSemAuditoria() : this(1001) // Código padrão
        {
        }

        /// <summary>
        /// Construtor com código de erro específico.
        /// </summary>
        /// <param name="errorCode">Código de erro específico.</param>
        public ExceptionSemAuditoria(int errorCode)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Construtor com mensagem personalizada.
        /// </summary>
        /// <param name="message">Mensagem de erro.</param>
        public ExceptionSemAuditoria(string? message) : this(1001, message)
        {
        }

        /// <summary>
        /// Construtor com código de erro e mensagem personalizada.
        /// </summary>
        /// <param name="errorCode">Código de erro específico.</param>
        /// <param name="message">Mensagem de erro.</param>
        public ExceptionSemAuditoria(int errorCode, string? message) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Construtor com mensagem e exception interna.
        /// </summary>
        /// <param name="message">Mensagem de erro.</param>
        /// <param name="innerException">Exception interna que causou esta exception.</param>
        public ExceptionSemAuditoria(string? message, Exception? innerException) : this(1001, message, innerException)
        {
        }

        /// <summary>
        /// Construtor com código de erro, mensagem e exception interna.
        /// </summary>
        /// <param name="errorCode">Código de erro específico.</param>
        /// <param name="message">Mensagem de erro.</param>
        /// <param name="innerException">Exception interna que causou esta exception.</param>
        public ExceptionSemAuditoria(int errorCode, string? message, Exception? innerException) : base(message, innerException)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Construtor para deserialização.
        /// </summary>
        /// <param name="info">Informações de serialização.</param>
        /// <param name="context">Contexto de streaming.</param>
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected ExceptionSemAuditoria(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            ErrorCode = info.GetInt32(nameof(ErrorCode));
        }

        /// <summary>
        /// Método para serialização.
        /// </summary>
        /// <param name="info">Informações de serialização.</param>
        /// <param name="context">Contexto de streaming.</param>
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(nameof(ErrorCode), ErrorCode);
        }

        /// <summary>
        /// Retorna uma representação em string da exception incluindo o código de erro.
        /// </summary>
        /// <returns>String formatada com o código de erro e mensagem.</returns>
        public override string ToString()
        {
            return $"[{ErrorCode}] {base.ToString()}";
        }
    }
}