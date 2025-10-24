using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLB900.MSTools.JWT
{
    public static class LerDadosDoJWT
    {
        public static string? ObterValorDoClaim(string jwtToken, string claimType)
        {
            if (jwtToken == null)
                return null;
            var parts = jwtToken.Split('.');
            if (parts.Length != 3)
                return null;
            var payload = parts[1];
            var paddedPayload = payload.PadRight(payload.Length + (4 - payload.Length % 4) % 4, '=');
            var jsonBytes = Convert.FromBase64String(paddedPayload);
            var jsonString = Encoding.UTF8.GetString(jsonBytes);
            var claims = System.Text.Json.JsonDocument.Parse(jsonString).RootElement;
            if (claims.TryGetProperty(claimType, out var claimValue))
            {
                return claimValue.GetString();
            }
            return null;
        }
    }
}
