namespace CSLB900.MSTools.ConsomeAPI.Exceptions;

public class ApiExternaErrorResponse
{
    public string? Type { get; set; }
    public string? Title { get; set; }
    public int Status { get; set; }
    public string? Detail { get; set; }
    public string? Instance { get; set; }
    public string? Timestamp { get; set; }
}
