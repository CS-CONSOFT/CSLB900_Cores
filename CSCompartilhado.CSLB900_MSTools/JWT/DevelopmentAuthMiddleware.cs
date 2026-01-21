using CSLB900.MSTools.Util;
using Microsoft.AspNetCore.Http;
using System.Reflection.Metadata;
using System.Security.Claims;

namespace CSLB900.MSTools.JWT;

/// <summary>
/// Middleware para simular autenticação em ambiente de desenvolvimento
/// </summary>
public class DevelopmentAuthMiddleware
{
    private readonly RequestDelegate _next;

    public DevelopmentAuthMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Verificar se já está autenticado
        if (!context.User.Identity?.IsAuthenticated ?? true)
        {
            // Obter userId e tenantId dos headers (para desenvolvimento)
            var userId = context.Request.Headers["X-UserId"].FirstOrDefault() ?? "59bd9971-31e5-4a0b-a7f2-a88ed5d7056b";
            var tenantId = context.Request.Headers["X-TenantId"].FirstOrDefault() ?? "135";

            // Criar claims simuladas
            var claims = new List<Claim>
            {
                new Claim(Constantes.USER_ID_JWT, userId),
                new Claim(Constantes.TENANT_ID_JWT, tenantId),
                new Claim(ClaimTypes.Name, "Developer User"),
                new Claim(ClaimTypes.Email, "dev@example.com")
            };

            var identity = new ClaimsIdentity(claims, "Development");
            var principal = new ClaimsPrincipal(identity);

            context.User = principal;
        }

        await _next(context);
    }
}