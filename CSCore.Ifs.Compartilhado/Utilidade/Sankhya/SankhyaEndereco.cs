using CSLB900.MSTools.Util;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSCore.Ifs.Compartilhado.Utilidade.Sankhya
{
    public static class SankhyaEndereco
    {
        public static async Task<string> FetchCodendAsync(string endereco, SankhyaClient client)
        {
            var (enderecoPrefixo, enderecoSufixo) = StringUtils.ExtrairPrefixoSufixoLogradouro(endereco);

            var rawAbbr = Abreviacoes.BuscarAbreviacoes(enderecoPrefixo);
            var possiveisNorm = new HashSet<string>(rawAbbr.Select(Abreviacoes.NormalizeAbbr));

            var payload = new
            {
                serviceName = "CRUDServiceProvider.loadRecords",
                requestBody = new
                {
                    dataSet = new
                    {
                        rootEntity = "Endereco",
                        includePresentationFields = "N",
                        offsetPage = "0",
                        criteria = new
                        {
                            // Usando "At" como nome de propriedade, ajuste conforme necessário
                            expression = new { At = $"NOMEEND = '{enderecoSufixo}'" }
                        },
                        entity = new
                        {
                            fieldset = new
                            {
                                list = "CODEND, NOMEEND, TIPO"
                            }
                        }
                    }
                }
            };

            var data = await client.GetAsync(payload);
            if (data == null) return null;

            var root = data.RootElement;
            if (!root.TryGetProperty("responseBody", out var responseBody) ||
                !responseBody.TryGetProperty("entities", out var entities) ||
                !entities.TryGetProperty("entity", out var entity))
            {
                return null;
            }

            IEnumerable<JsonElement> entityList = entity.ValueKind == JsonValueKind.Array
                ? entity.EnumerateArray()
                : new[] { entity };

            foreach (var item in entityList)
            {
                var codend = item.GetProperty("f0").GetProperty("$").GetString();
                var tipo = item.GetProperty("f2").GetProperty("$").GetString();
                if (possiveisNorm.Contains(Abreviacoes.NormalizeAbbr(tipo)))
                {
                    return codend;
                }
            }

            return null;
        }
    }
}
