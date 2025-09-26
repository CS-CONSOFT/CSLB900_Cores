using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ex.Personalizada
{
    public class EmptyListException : SystemException
    {
        public int ErroCode { get; set; }

        public EmptyListException() : this(506)
        {
        }

        public EmptyListException(int erroCode)
        {
            ErroCode = erroCode;
        }

        public EmptyListException(int errorCode, string? message) : base(message)
        {
            ErroCode = errorCode;
        }

        public EmptyListException(string? message) : this(506,message)
        {
        }
    }
}
