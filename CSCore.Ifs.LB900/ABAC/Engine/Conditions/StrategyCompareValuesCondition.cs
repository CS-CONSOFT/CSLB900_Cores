using CSCore.Ifs.LB900.ABAC.Engine.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.LB900.ABAC.Engine.Conditions
{
    public enum CompareValuesConditionType
    {
        UserAttributes,
        ResourceAttributes,
        ContextAttributes,
        Idle
    }
    public interface IStrategyCompareValuesCondition
    {
        public bool Compare(string atributoParaComparar, DtoObjectValueCondition valorCorrenteCondicaoDoBanco);
    }
    public static class StrategyCompareValuesCondition
    {
        public static IStrategyCompareValuesCondition GetStrategy(CompareValuesConditionType operatorCondition)
        {
            return operatorCondition switch
            {
                CompareValuesConditionType.UserAttributes => new UserAttributesCompare(),
                CompareValuesConditionType.ResourceAttributes => new ResourceAttributesCompare(),
                CompareValuesConditionType.ContextAttributes => new ContextAttributesCompare(),
                CompareValuesConditionType.Idle => new IdleCompare(),
                _ => throw new NotImplementedException($"Operator '{operatorCondition}' not implemented in StrategyCompareValuesCondition.")
            };
        }
    }

    public class UserAttributesCompare : IStrategyCompareValuesCondition
    {
        public bool Compare(string atributoParaComparar, DtoObjectValueCondition valorCorrenteCondicaoDoBanco)
        {
           return valorCorrenteCondicaoDoBanco.CompareValues(atributoParaComparar);
        }
    }

    public class ResourceAttributesCompare : IStrategyCompareValuesCondition
    {
        public bool Compare(string atributoParaComparar, DtoObjectValueCondition valorCorrenteCondicaoDoBanco)
        {
            return valorCorrenteCondicaoDoBanco.CompareValues(atributoParaComparar);
        }
    }

    public class ContextAttributesCompare : IStrategyCompareValuesCondition
    {
        public bool Compare(string atributoParaComparar, DtoObjectValueCondition valorCorrenteCondicaoDoBanco)
        {
            return valorCorrenteCondicaoDoBanco.CompareValues(atributoParaComparar);
        }
    }

    public class IdleCompare : IStrategyCompareValuesCondition
    {
        public bool Compare(string conditionKey, DtoObjectValueCondition valorCorrenteCondicao)
        {
            return false;
        }
    }
}
