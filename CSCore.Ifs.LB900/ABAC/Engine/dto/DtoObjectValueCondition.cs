using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.LB900.ABAC.Engine.dto
{
    public record DtoObjectValueCondition
    {
        public string Value { get; set; } = string.Empty;
        public string Operator { get; set; } = string.Empty;

        /// <summary>
        /// usado para comparar o valor do atributo com o valor da condição
        /// </summary>
        /// <param name="attribute">Pode ser tanto de usuário, quanto de recurso</param>
        /// <returns></returns>
        public bool CompareValues(string? currentAttribute)
        {
            if(string.IsNullOrEmpty(currentAttribute)) return false;
            return ComparableStraegy.GetStrategy(this.Operator).Compare(currentAttribute, this.Value);
        }
    }

    interface IComparableStraegy
    {
        bool Compare(string? attributeValue, string conditionValue);
    }
    class ComparableStraegy
    {
        public static IComparableStraegy GetStrategy(string operatorType)
        {
            return operatorType.ToLower() switch
            {
                "equals" => new EqualsStrategy(),
                "contains" => new ContainsStrategy(),
                _ => new EqualsStrategy(),
            };
        }
    }

    class ContainsStrategy : IComparableStraegy
    {
        public bool Compare(string? attributeValue, string conditionValue)
        {
            if (string.IsNullOrEmpty(attributeValue)) return false;
            return attributeValue.Contains(conditionValue, StringComparison.OrdinalIgnoreCase);
        }
    }
    class EqualsStrategy : IComparableStraegy
    {
        public bool Compare(string? attributeValue, string conditionValue)
        {
            if (string.IsNullOrEmpty(attributeValue)) return false;
            return attributeValue.Equals(conditionValue, StringComparison.OrdinalIgnoreCase);
        }
    }
}

