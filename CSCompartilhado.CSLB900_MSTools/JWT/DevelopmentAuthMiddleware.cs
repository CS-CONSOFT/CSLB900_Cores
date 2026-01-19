using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace CSS_SY103Systems.Middleware;

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
            var userId = context.Request.Headers["X-Dev-UserId"].FirstOrDefault() ?? "development";
            var tenantId = context.Request.Headers["X-Dev-TenantId"].FirstOrDefault() ?? "135";

            // Criar claims simuladas
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userId),
                new Claim("TenantId", tenantId),
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