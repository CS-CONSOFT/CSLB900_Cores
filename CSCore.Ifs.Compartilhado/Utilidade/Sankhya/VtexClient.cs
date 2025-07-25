using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSCore.Ifs.Compartilhado.Utilidade.Sankhya
{
    public class VtexClient
    {
        private readonly string _appKey;
        private readonly string _appToken;
        private readonly string _account;
        private readonly HttpClient _httpClient;
        public VtexClient(IConfiguration config, HttpClient httpClient)
        {
            _appKey = config["VTEX_APP_KEY"];
            _appToken = config["VTEX_APP_TOKEN"];
            _account = config["VTEX_ACCOUNT"];
            _httpClient = httpClient;
        }

        public async Task<JsonDocument> FetchCustomerDataAsync(string vtexOrderId)
        {
            var url = $"https://{_account}.myvtex.com/api/oms/pvt/orders/{vtexOrderId}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("X-VTEX-API-AppKey", _appKey);
            request.Headers.Add("X-VTEX-API-AppToken", _appToken);

            try
            {
                var response = await _httpClient.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonDocument.Parse(json);
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        public async Task<Dictionary<string, string>> CustomerPayloadDataAsync(string vtexOrderId)
        {
            var dados = await FetchCustomerDataAsync(vtexOrderId);
            if (dados == null) return null;

            var root = dados.RootElement;

            var dict = new Dictionary<string, string>
            {
                ["NOMEPARC"] = $"{root.GetProperty("clientProfileData").GetProperty("firstName").GetString()} {root.GetProperty("clientProfileData").GetProperty("lastName").GetString()}",
                ["CGC_CPF"] = root.GetProperty("clientProfileData").GetProperty("document").GetString(),
                ["TELEFONE"] = root.GetProperty("clientProfileData").GetProperty("phone").GetString(),
                ["ENDERECO"] = root.GetProperty("shippingData").GetProperty("address").GetProperty("street").GetString(),
                ["NUMEND"] = root.GetProperty("shippingData").GetProperty("address").GetProperty("number").GetString(),
                ["COMPLEMENTO"] = root.GetProperty("shippingData").GetProperty("address").GetProperty("complement").GetString(),
                ["BAIRRO"] = root.GetProperty("shippingData").GetProperty("address").GetProperty("neighborhood").GetString(),
                ["CIDADE"] = root.GetProperty("shippingData").GetProperty("address").GetProperty("city").GetString(),
                ["CEP"] = root.GetProperty("shippingData").GetProperty("address").GetProperty("postalCode").GetString()
            };
            return dict;
        }
    }
}
