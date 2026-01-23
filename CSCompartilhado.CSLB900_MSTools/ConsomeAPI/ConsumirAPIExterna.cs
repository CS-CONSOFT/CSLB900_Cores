using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace CSLB900.MSTools.ConsomeAPI
{
    public interface IConsumirAPIExterna
    {
        Task<TRetorno?> Get<TRetorno>(string UrlBase, string Endpoint);
        Task<TRetorno?> Post<TRetorno, TRequisicao>(string UrlBase, string Endpoint, TRequisicao requisicao);
    }
    public class ConsumirAPIExterna: IConsumirAPIExterna
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ConsumirAPIExterna(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<TRetorno?> Get<TRetorno>(string UrlBase, string Endpoint)
        {
            var client = _httpClientFactory.CreateClient();
            int maxTentativas = 3;
            int delayMs = 1000;

            for (int tentativa = 1; tentativa <= maxTentativas; tentativa++)
            {
                try
                {
                    return await client.GetFromJsonAsync<TRetorno>($"{UrlBase}/{Endpoint}");
                }
                catch (HttpRequestException) when (tentativa < maxTentativas)
                {
                    await Task.Delay(delayMs);
                }
                catch (TaskCanceledException) when (tentativa < maxTentativas)
                {
                    await Task.Delay(delayMs);
                }
            }
            throw new Exception($"Falha ao consumir API após {maxTentativas} tentativas.");
        }

        public async Task<TRetorno?> Post<TRetorno, TRequisicao>(string UrlBase, string Endpoint, TRequisicao requisicao)
        {
            var client = _httpClientFactory.CreateClient();
            int maxTentativas = 3;
            int delayMs = 1000;

            for (int tentativa = 1; tentativa <= maxTentativas; tentativa++)
            {
                try
                {
                    var response = await client.PostAsJsonAsync($"{UrlBase}/{Endpoint}", requisicao);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadFromJsonAsync<TRetorno>();
                }
                catch (HttpRequestException) when (tentativa < maxTentativas)
                {
                    await Task.Delay(delayMs);
                }
                catch (TaskCanceledException) when (tentativa < maxTentativas)
                {
                    await Task.Delay(delayMs);
                }
            }
            throw new Exception($"Falha ao consumir API após {maxTentativas} tentativas.");
        }
    }
}