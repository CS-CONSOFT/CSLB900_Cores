using System;
using System.Collections.Generic;
using System.Text;

namespace CSLB900.MSTools
{
    public class CSResult<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        private CSResult() { }

        public static CSResult<T> Success(T data, string message = "")
        {
            return new CSResult<T>
            {
                IsSuccess = true,
                Data = data,
                Message = message
            };
        }

        public static CSResult<T> Failure(string message)
        {
            return new CSResult<T>
            {
                IsSuccess = false,
                Message = message
            };
        }


    }
}
