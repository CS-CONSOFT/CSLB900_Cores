namespace CSCore.Domain
{
    public class CSResult<T>
    {
        public bool IsSuccess { get; set; }
        public bool IsFailure => !IsSuccess;
        public string? Message { get; set; }
        public T? Data { get; set; }

        private CSResult()
        {
        }

        public static CSResult<T> Success(T data, string? message = null)
        {
            return new CSResult<T> { IsSuccess = true, Data = data, Message = message };
        }


        public static CSResult<T> Success(string? message = null)
        {
            return new CSResult<T> { IsSuccess = true,Message = message };
        }


        public static CSResult<T> Failure(string message)
        {
            return new CSResult<T> { IsSuccess = false, Message = message };
        }

        public override string ToString()
        {
            return IsSuccess ? $"Success: {Data}" : $"Failure: {Message}";
        }

        public void Deconstruct(out bool isSuccess, out T? data, out string? message)
        {
            isSuccess = IsSuccess;
            data = Data;
            message = Message;
        }

        public void Deconstruct(out bool isSuccess, out string? message)
        {
            isSuccess = IsSuccess;
            message = Message;
        }

        public void Deconstruct(out bool isSuccess, out T? data)
        {
            isSuccess = IsSuccess;
            data = Data;
        }

    }
}
