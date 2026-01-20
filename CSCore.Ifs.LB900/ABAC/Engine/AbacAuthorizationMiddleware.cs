using CSSY103.C82Application.Attributes;
using CSSY103.C82Application.Dto.ABAC.Engine;
using CSSY103.C82Application.Service.ABAC;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace CSSY103.C82Application.Middleware;

/// <summary>
/// Middleware para interceptar e validar permissões ABAC
/// </summary>
public class AbacAuthorizationMiddleware
{
    private readonly RequestDelegate _next;

    public AbacAuthorizationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(
        HttpContext context,
        AbacPermissionCacheService cacheService,
        AbacPermissionService permissionService)
    {
        // Pular rotas públicas
        var endpoint = context.GetEndpoint();
        if (endpoint?.Metadata.GetMetadata<AllowAnonymousAttribute>() != null)
        {
            await _next(context);
            return;
        }

        // Verificar se tem metadata de ABAC
        var abacMetadata = endpoint?.Metadata.GetMetadata<RequireAbacPermissionAttribute>();
        if (abacMetadata == null)
        {
            await _next(context);
            return;
        }

        // Extrair informações do usuário
        var userId = context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var tenantIdClaim = context.User.FindFirst("TenantId")?.Value;

        if (string.IsNullOrEmpty(userId) || !int.TryParse(tenantIdClaim, out var tenantId))
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsJsonAsync(new { error = "Unauthorized" });
            return;
        }

        // Verificar permissão (com cache)
        var hasPermission = await permissionService.CheckPermissionAsync(
            userId,
            abacMetadata.ResourceId,
            abacMetadata.ActionName,
            tenantId
        );

        if (!hasPermission.IsAllowed)
        {
            context.Response.StatusCode = 403;
            await context.Response.WriteAsJsonAsync(new
            {
                error = "Forbidden",
                message = $"You don't have permission to {abacMetadata.ActionName} on {abacMetadata.ResourceId}"
            });
            return;
        }

        await _next(context);
    }
}