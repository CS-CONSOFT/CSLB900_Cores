using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSCore.Ifs.LB900.ABAC.Engine.dto;
using System.Text.Json;

namespace CSCore.Ifs.LB900.ABAC.Engine.Conditions
{
    public class AbacConditionEvaluator : IAbacStaticEvaluator
    {
        private AbacConditionEvaluator() { }
        public static IAbacStaticEvaluator Instance { get; } = new AbacConditionEvaluator();
        public bool EvaluateCondition(
              string conditionsJson,
              Dictionary<string, string> userAttributes,
              IEnumerable<ABAC_CSSPH_RESOURCEATRIB> resourceAttributes,
              IEnumerable<ABAC_ContextAttributes> contextAttributes)
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

                var dictContextAttributes = contextAttributes
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
                    //inicializa a estrategia de comparacao como idle, que retorna false sempre
                    var strategyCorrente = StrategyCompareValuesCondition.GetStrategy(CompareValuesConditionType.Idle);

                    if (atributoUsuario != null)
                    {
                        //passa a usar estrategia de usuario
                        strategyCorrente = StrategyCompareValuesCondition.GetStrategy(CompareValuesConditionType.UserAttributes);
                        conditionMet = strategyCorrente.Compare(atributoUsuario, condition.Value);
                        if (conditionMet == true) continue;
                        else return false;
                    }

                    var atributoRecurso = resourceAttrDict.GetValueOrDefault(condition.Key);
                    if (atributoRecurso != null)
                    {
                        //passa a usar estrategia de recurso
                        strategyCorrente = StrategyCompareValuesCondition.GetStrategy(CompareValuesConditionType.ResourceAttributes);
                        conditionMet = strategyCorrente.Compare(atributoRecurso, condition.Value);
                        if (conditionMet == true) continue;
                        else return false;
                    }

                    var contextRecurso = dictContextAttributes.GetValueOrDefault(condition.Key);
                    if (contextRecurso != null)
                    {
                        //passa a usar estrategia de recurso
                        strategyCorrente = StrategyCompareValuesCondition.GetStrategy(CompareValuesConditionType.ContextAttributes);
                        conditionMet = strategyCorrente.Compare(contextRecurso, condition.Value);
                        if (conditionMet == true) continue;
                        else return false;
                    }


                    if (!conditionMet)
                        return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
