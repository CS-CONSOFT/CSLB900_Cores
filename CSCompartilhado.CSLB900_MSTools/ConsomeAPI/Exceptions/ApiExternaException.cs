namespace CSLB900.MSTools.ConsomeAPI.Exceptions;

public class ApiExternaException : Exception
{
    public int StatusCode { get; }
    public string? Type { get; }
    public string? Title { get; }
    public string? Detail { get; }
    public string? Instance { get; }
    public string? Timestamp { get; }

    public ApiExternaException(int statusCode, string? type, string? title, string? detail, string? instance, string? timestamp)
        : base($"Erro {statusCode}: {title} - {detail}")
    {
        StatusCode = statusCode;
        Type = type;
        Title = title;
        Detail = detail;
        Instance = instance;
        Timestamp = timestamp;
    }
}
