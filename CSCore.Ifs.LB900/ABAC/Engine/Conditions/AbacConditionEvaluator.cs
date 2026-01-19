using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSCore.Ifs.LB900.ABAC.Engine.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSCore.Ifs.LB900.ABAC.Engine.Conditions
{
    public class AbacConditionEvaluator : IAbacStaticEvaluator
    {
        private AbacConditionEvaluator() { }
        public static IAbacStaticEvaluator Instance { get; } = new AbacConditionEvaluator();
        public bool EvaluateCondition(
              string conditionsJson,
              Dictionary<string, string> userAttributes,
              IEnumerable<ABAC_CSSPH_RESOURCEATRIB> resourceAttributes)
            {
                try
                {
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    var resourceAttrDict = resourceAttributes
                        .Where(a => !string.IsNullOrWhiteSpace(a.Attributename))
                        .ToDictionary(
                            a => a.Attributename!,
                            a => a.Attributevalue ?? ""
                        );

                    var conditions = JsonSerializer.Deserialize<Dictionary<string, DtoObjectValueCondition>>(conditionsJson, options);
                    if (conditions == null)
                        return true;


                    foreach (var condition in conditions)
                    {
                        var conditionMet = false;

                        // Verificar nos atributos do usuário
                        var atributoUsuario = userAttributes.GetValueOrDefault(condition.Key);
                        if (atributoUsuario != null)
                        {
                            conditionMet = condition.Value.CompareValues(atributoUsuario);
                            if (conditionMet == true) continue;
                            else return false;
                        }

                        var atributoRecurso = resourceAttrDict.GetValueOrDefault(condition.Key);
                        if (atributoRecurso != null)
                        {
                            conditionMet = condition.Value.CompareValues(atributoUsuario);
                            if (conditionMet == true) continue;
                            else return false;
                        }


                        if (!conditionMet)
                            return false;
                    }

                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
    }
}
