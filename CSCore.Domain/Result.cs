namespace CSCore.Domain
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public bool IsFailure => !IsSuccess;
        public string? Message { get; set; }
        public T? Data { get; set; }

        private Result()
        {
        }

        public static Result<T> Success(T data, string? message = null)
        {
            return new Result<T> { IsSuccess = true, Data = data, Message = message };
        }


        public static Result<T> Success(string? message = null)
        {
            return new Result<T> { IsSuccess = true,Message = message };
        }


        public static Result<T> Failure(string message)
        {
            return new Result<T> { IsSuccess = false, Message = message };
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
