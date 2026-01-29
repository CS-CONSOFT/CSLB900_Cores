using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

public enum RuleEffect
{
    Allow,
    Deny
}

public interface IAbacStaticEvaluator
{
   bool EvaluateCondition(string conditionsJson,
              Dictionary<string, string> userAttributes,
              IEnumerable<ABAC_CSSPH_RESOURCEATRIB> resourceAttributes,
              IEnumerable<ABAC_ContextAttributes> contextAttributes);
}

public partial class CSSPH_POLICIESRULES
{
    public int? TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Policyid { get; set; }

    public string? Rulename { get; set; }

    public string? Effect { get; set; }

    public int? Priority { get; set; }

    public string? Conditions { get; set; }

    public string? Actions { get; set; }

    public string? Resources { get; set; }




    #region // Métodos auxiliares para avaliação de regras ABAC

    public bool IsDeny()
    {
        if(this.Effect?.Equals("Deny", StringComparison.OrdinalIgnoreCase) == true) return true;
        return false;
    }

    public bool IsAllow()
    {
        if (this.Effect?.Equals("Allow", StringComparison.OrdinalIgnoreCase) == true) return true;
        return false;
    }


    public RuleEffect ValidarCondicao(
        IAbacStaticEvaluator abacStaticEvaluator,
        Dictionary<string, string> userAttributes,
        IEnumerable<ABAC_CSSPH_RESOURCEATRIB> resourceAttributes,
        IEnumerable<ABAC_ContextAttributes> contextAttributes) 
    {
        if (string.IsNullOrWhiteSpace(this.Conditions))
            return RuleEffect.Deny;
        return abacStaticEvaluator.EvaluateCondition(this.Conditions, userAttributes, resourceAttributes, contextAttributes) == true ? RuleEffect.Allow : RuleEffect.Deny;
    }

    public bool ARegraEhAplicadaAEsseRecurso(string resourceId, string? resourceName)
    {
        if (string.IsNullOrWhiteSpace(this.Resources))
            return true;
        try
        {
            // Wildcard completo
            if (this.Resources == "*")
                return true;

            // Match exato
            if (this.Resources == resourceId || this.Resources == resourceName)
                return true;

            // Pattern matching com wildcard
            if (this.Resources.Contains('*'))
            {
                /* 
                * Escapa os caracteres especiais do padrão para que sejam tratados como texto literal.
                * Em seguida, substitui o '*' por '.*', permitindo que o padrão funcione com qualquer sequência de caracteres
                * Por exemplo, 'produto-*' casa com 'produto-123', 'produto-abc', etc.
                * Depois, verifica se o resourceId ou resourceName corresponde ao padrão usando expressão regular, ignorando maiúsculas/minúsculas.
                * Se corresponder, retorna true.
                */
                var regex = "^" + Regex.Escape(this.Resources).Replace("\\*", ".*") + "$";
                if (Regex.IsMatch(resourceId, regex, RegexOptions.IgnoreCase))
                    return true;

                if (!string.IsNullOrWhiteSpace(resourceName) &&
                    Regex.IsMatch(resourceName, regex, RegexOptions.IgnoreCase))
                    return true;
            }


            return false;
        }
        catch
        {
            // Fallback: tentar como string simples
            return this.Resources == resourceId
                || this.Resources.Contains(resourceName ?? "")
                || this.Resources.Contains("*");
        }
    }

    public bool ARegraEhAplicadaAEssaAcao(string actionName)
    {
        if (string.IsNullOrWhiteSpace(this.Actions))
            return true; // Se não especificou ações, aplica a todas

        try
        {
            // Verifica se contém a ação ou wildcard
            return this.Actions == actionName || this.Actions == "*";
        }
        catch
        {
            return false;
        }
    }

}
    #endregion