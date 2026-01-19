namespace CSSY103.C82Application.Attributes;

/// <summary>
/// Atributo para aplicar validação ABAC em endpoints
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
public class RequireAbacPermissionAttribute : Attribute
{
    public string ResourceId { get; }
    public string ActionName { get; }

    public RequireAbacPermissionAttribute(string resourceId, string actionName)
    {
        ResourceId = resourceId;
        ActionName = actionName;
    }
}