using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSCore.Ifs.Compartilhado.Utilidade.Sankhya
{
    public class SankhyaClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        private readonly string _authToken;

        public SankhyaClient(string baseUrl, string authToken, HttpClient httpClient)
        {
            _baseUrl = baseUrl;
            _authToken = authToken;
            _httpClient = httpClient;
        }

        public async Task<JsonDocument> GetAsync(object payload)
        {
            var url = $"{_baseUrl}/service.sbr?serviceName=CRUDServiceProvider.loadRecords";
            var jsonPayload = JsonSerializer.Serialize(payload);
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Add("Authorization", _authToken);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            try
            {
                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                return JsonDocument.Parse(json);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
