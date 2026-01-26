using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using System.Text.Json;
using CSLB900.MSTools.ConsomeAPI.Exceptions;

namespace CSLB900.MSTools.ConsomeAPI
{
    public interface IConsumirAPIExterna
    {
        Task<TRetorno?> Get<TRetorno>(string UrlBase, string Endpoint, Dictionary<string, object>? queryParams = null);
        Task<TRetorno?> Post<TRetorno, TRequisicao>(string UrlBase, string Endpoint, TRequisicao requisicao, Dictionary<string, object>? queryParams = null);
    }
    public class ConsumirAPIExterna: IConsumirAPIExterna
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ConsumirAPIExterna(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<TRetorno?> Get<TRetorno>(string UrlBase, string Endpoint, Dictionary<string, object>? queryParams = null)
        {
            var client = _httpClientFactory.CreateClient();
            int maxTentativas = 3;
            int delayMs = 1000;

            for (int tentativa = 1; tentativa <= maxTentativas; tentativa++)
            {
                try
                {
                    string endpointUrl = CriarEndpoint(UrlBase, Endpoint, queryParams);
                    return await client.GetFromJsonAsync<TRetorno>(endpointUrl);
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

        private static string CriarEndpoint(string UrlBase, string Endpoint, Dictionary<string, object>? queryParams)
        {
            var endpointUrl = $"{UrlBase}/{Endpoint}";
            if (queryParams != null && queryParams.Count > 0)
            {
                var queryString = string.Join("&", queryParams.Select(kvp => $"{kvp.Key}={Uri.EscapeDataString(kvp.Value.ToString() ?? string.Empty)}"));
                endpointUrl += "?" + queryString;
            }

            return endpointUrl;
        }

        public async Task<TRetorno?> Post<TRetorno, TRequisicao>(string UrlBase, string Endpoint, TRequisicao requisicao, Dictionary<string, object>? queryParams = null)
        {
            var client = _httpClientFactory.CreateClient();
            int maxTentativas = 3;
            int delayMs = 1000;
            Exception? ultimaExcecao = null;

            for (int tentativa = 1; tentativa <= maxTentativas; tentativa++)
            {
                try
                {
                    string endpointUrl = CriarEndpoint(UrlBase, Endpoint, queryParams);
                    
                    // ENVIA O OBJETO DIRETAMENTE (não serializa antes)
                    var response = await client.PostAsJsonAsync(endpointUrl, requisicao);

                    if (!response.IsSuccessStatusCode)
                    {
                        var erroResposta = await response.Content.ReadAsStringAsync();
                        var statusCode = (int)response.StatusCode;
                        
                        // Log para debug
                        var jsonDebug = JsonSerializer.Serialize(requisicao);
                        Console.WriteLine($"[ERRO {statusCode}] Endpoint: {endpointUrl}");
                        Console.WriteLine($"[ERRO {statusCode}] JSON enviado: {jsonDebug}");
                        Console.WriteLine($"[ERRO {statusCode}] Resposta: {erroResposta}");
                        
                        // Tenta parsear a resposta estruturada da API externa
                        try
                        {
                            var errorResponse = JsonSerializer.Deserialize<ApiExternaErrorResponse>(erroResposta, 
                                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                            
                            if (errorResponse != null)
                            {
                                throw new ApiExternaException(
                                    statusCode,
                                    errorResponse.Type,
                                    errorResponse.Title,
                                    errorResponse.Detail,
                                    errorResponse.Instance,
                                    errorResponse.Timestamp
                                );
                            }
                        }
                        catch (JsonException)
                        {
                            // Se não conseguir parsear, usa o tratamento padrão
                        }
                        
                        // Não faz retry em erros 4xx (erro do cliente)
                        if (statusCode >= 400 && statusCode < 500)
                        {
                            throw new Exception($"Erro {statusCode} ao consumir API. Resposta: {erroResposta}");
                        }
                        
                        // Para erros 5xx, tenta novamente
                        if (tentativa < maxTentativas)
                        {
                            await Task.Delay(delayMs);
                            continue;
                        }
                        
                        throw new Exception($"Erro {statusCode} após {maxTentativas} tentativas. Resposta: {erroResposta}");
                    }

                    return await response.Content.ReadFromJsonAsync<TRetorno>();
                }
                catch (HttpRequestException ex) when (tentativa < maxTentativas)
                {
                    ultimaExcecao = ex;
                    await Task.Delay(delayMs);
                }
                catch (TaskCanceledException ex) when (tentativa < maxTentativas)
                {
                    ultimaExcecao = ex;
                    await Task.Delay(delayMs);
                }
            }

            if (ultimaExcecao != null)
            {
                throw new Exception($"Falha ao consumir API após {maxTentativas} tentativas.", ultimaExcecao);
            }

            throw new Exception($"Falha ao consumir API após {maxTentativas} tentativas.");
        }
    }
    }