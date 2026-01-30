namespace CSSY103.C82Application.Dto.ABAC.Engine;

/// <summary>
/// Resultado da avaliação de permissão
/// </summary>
public record AbacPermissionResult
{
    public bool IsAllowed { get; init; }
    public string Effect { get; init; } = "Deny";
    public string? Reason { get; init; }
    public string? PolicyId { get; init; }
    public string? RuleId { get; init; }

    public static AbacPermissionResult Allow(string reason, string? policyId = null, string? ruleId = null)
    {
        return new AbacPermissionResult
        {
            IsAllowed = true,
            Effect = "Allow",
            Reason = reason,
            PolicyId = policyId,
            RuleId = ruleId
        };
    }

    public static AbacPermissionResult Deny(string reason)
    {
        return new AbacPermissionResult
        {
            IsAllowed = false,
            Effect = "Deny",
            Reason = reason
        };
    }

    public static AbacPermissionResult Empty() { return new AbacPermissionResult { IsAllowed = false }; }
    public static AbacPermissionResult ValidationOk() { return new AbacPermissionResult { IsAllowed = true }; }
}