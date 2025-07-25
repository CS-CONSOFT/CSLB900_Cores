namespace CSLB900.MSTools.Extensao
{
    public static class ExtensoesDeObjeto
    {
        public static DateTime? ConverteStringVaziaParaDataNula(this string? date)
        {
            if (string.IsNullOrEmpty(date))
                return null;

            if (date.ElementAt(2) == '/')
            {
                var dia = date.Substring(0, 2);
                var mes = date.Substring(3, 2);
                var ano = date.Substring(6, 4);
                date = $"{ano}-{mes}-{dia}"; // Formato ISO 8601: yyyy-MM-dd
            }

            return DateTime.TryParse(date, out DateTime result) ? result : (DateTime?)null;
        }


        public static int? ConverteStringVaziaParaIntNulo(this string? value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            return int.Parse(value);
        }


        public static int? ConverteIntNuloParaNulo(this int? valor)
        {
            if (valor == null)
                return null;

            return valor;
        }



        /// <summary>
        /// Percorre todas as propriedades de um objeto e converte valores padrão para nulo.
        /// - `string?`: Converte strings nuláveis vazias (`""`) para `null`, mas apenas se a propriedade for nullable.
        /// - `int?`: Converte `0` nuláveis para `null`.
        /// - `long?`: Converte `0` nuláveis para `null` (Havia um erro, pois tentava converter para `decimal?` em vez de `long?`, agora corrigido).
        /// </summary>
        /// <typeparam name="T">O tipo do objeto a ser processado.</typeparam>
        /// <param name="obj">O objeto cujas propriedades serão verificadas e possivelmente modificadas.</param>
        public static void ConverteValoresPadraoParaNulo<T>(this T obj)
        {
            if (obj == null) return;

            var properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.CanWrite)
                {
                    Type propertyType = property.PropertyType;
                    bool isNullable = !propertyType.IsValueType || Nullable.GetUnderlyingType(propertyType) != null;

                    if (propertyType == typeof(string) && isNullable)
                    {
                        var value = property.GetValue(obj) as string;
                        if (value == string.Empty || value == null)
                        {
                            property.SetValue(obj, null);
                        }
                    }
                    if (propertyType == typeof(int?))
                    {
                        var value = (int?)property.GetValue(obj);
                        if (value == 0 || value == null)
                        {
                            property.SetValue(obj, null);
                        }
                    }

                    if (propertyType == typeof(long?))
                    {
                        var value = (long?)property.GetValue(obj);
                        if (value == 0 || value == null)
                        {
                            property.SetValue(obj, null);
                        }
                    }
                }
            }
        }
    }
}
