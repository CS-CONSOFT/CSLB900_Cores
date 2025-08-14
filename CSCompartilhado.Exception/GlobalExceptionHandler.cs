using CSCore.Domain.CS_Models.CSICP_SYS;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using NPOI.OpenXmlFormats.Shared;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace CSCore.Ex
{
    public class GlobalExceptionHandler(AppDbContext appDbContext) : IActionFilter
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private const string REQUEST_BODY_KEY = "RequestBody";


        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Habilita buffering para permitir múltiplas leituras do body
            context.HttpContext.Request.EnableBuffering();

            // PRIORIDADE 1: Capturar dos ActionArguments (DTOs já deserializados)
            CaptureFromActionArguments(context);
        }


        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Values
                                               .SelectMany(v => v.Errors)
                                               .Select(e => e.ErrorMessage)
                                               .ToList();

                // Retorna uma resposta personalizada para erros de validação
                context.Result = new ObjectResult(new DtoApiResponse<object>
                {
                    Success = false,
                    Message = "Os dados enviados contêm erros de validação.",
                    Data = errors// Passa os erros de validação para o campo Data
                })
                {
                    StatusCode = StatusCodes.Status400BadRequest // Configura o código de status para 400 (Bad Request)
                };
                return; // Evita que o processo continue e sobrescreva a resposta
            }

            //TRATAR ERROS DE EXCECOES LANÇADAS
            if (ExisteExcecao(context))
            {
                var stopwatch = Stopwatch.StartNew();
                if (context.Exception is UnauthorizedAccessException)
                {
                    HandleException(context, stopwatch, StatusCodes.Status401Unauthorized);
                }
                else if (context.Exception is InvalidDataException)
                {
                    HandleException(context, stopwatch, StatusCodes.Status409Conflict);
                }
                else if (context.Exception is KeyNotFoundException)
                {
                    HandleException(context, stopwatch, StatusCodes.Status404NotFound);
                }
                else if (context.Exception is ArgumentOutOfRangeException)
                {
                    HandleException(context, stopwatch, StatusCodes.Status400BadRequest);
                }
                // Para Exception genéricas, analisa a mensagem
                else if (context.Exception is Exception ex)
                {
                    int statusCode = DetermineStatusCodeFromMessage(ex.Message);
                    HandleException(context, stopwatch, statusCode);
                }
                else
                {
                    HandleException(context, stopwatch, StatusCodes.Status500InternalServerError);
                }
                context.ExceptionHandled = true;
            }
        }

        private void CaptureFromActionArguments(ActionExecutingContext context)
        {
            try
            {
                 if (context.ActionArguments?.Any() == true)
                {
                    // Filtra apenas os argumentos que não são primitivos ou headers
                    var relevantArguments = new Dictionary<string, object>();

                    foreach (var arg in context.ActionArguments)
                    {
                        // Ignora tipos primitivos, strings simples e headers
                        if (!IsPrimitiveType(arg.Value?.GetType()) &&
                            !arg.Key.ToLowerInvariant().Contains("tenant") &&
                            !arg.Key.ToLowerInvariant().Contains("id") &&
                            arg.Value != null)
                        {
                            relevantArguments[arg.Key] = arg.Value;
                        }
                    }

                    if (relevantArguments.Any())
                    {
                        var jsonBody = JsonSerializer.Serialize(relevantArguments, new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                            WriteIndented = false
                        });

                        context.HttpContext.Items[REQUEST_BODY_KEY] = jsonBody;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao capturar dos ActionArguments: {ex.Message}");
            }
        }

        private static bool IsPrimitiveType(Type? type)
        {
            if (type == null) return true;

            return type.IsPrimitive ||
                   type == typeof(string) ||
                   type == typeof(DateTime) ||
                   type == typeof(decimal) ||
                   type == typeof(Guid) ||
                   type == typeof(int?) ||
                   type == typeof(long?) ||
                   type == typeof(bool?) ||
                   type == typeof(DateTime?) ||
                   type == typeof(decimal?) ||
                   type == typeof(Guid?);
        }

     

        private static int DetermineStatusCodeFromMessage(string message)
        {
            // Verifica mensagens exatas das constantes primeiro
            if (message == HandlerReturnMessages.ENTITY_NOT_FOUND ||
                message == HandlerReturnMessages.LABEL_NOT_FOUND)
            {
                return StatusCodes.Status404NotFound;
            }

            if (message == HandlerReturnMessages.CODE_ALREADY_REGISTER)
            {
                return StatusCodes.Status409Conflict;
            }

            if (message == HandlerReturnMessages.ERROR_CPF_CNPJ ||
                message.StartsWith(HandlerReturnMessages.NULL_PROPERTY))
            {
                return StatusCodes.Status400BadRequest;
            }

            if (message == HandlerReturnMessages.METHOD_NOT_ALLOWED)
            {
                return StatusCodes.Status405MethodNotAllowed;
            }

            // Verifica padrões comuns nas mensagens
            var lowerMessage = message.ToLowerInvariant();

            // 404 - Not Found
            if (lowerMessage.Contains("não encontrado") ||
                lowerMessage.Contains("not found") ||
                lowerMessage.Contains("nenhum produto") ||
                lowerMessage.Contains("entidade não encontrada") ||
                lowerMessage.Contains("coleta não encontrada"))
            {
                return StatusCodes.Status404NotFound;
            }

            // 409 - Conflict  
            if (lowerMessage.Contains("já existe") ||
                lowerMessage.Contains("duplicado") ||
                lowerMessage.Contains("conflito") ||
                lowerMessage.Contains("already exists") ||
                lowerMessage.Contains("código já") ||
                lowerMessage.Contains("este código"))
            {
                return StatusCodes.Status409Conflict;
            }

            // 400 - Bad Request
            if (lowerMessage.Contains("inválido") ||
                lowerMessage.Contains("invalid") ||
                lowerMessage.Contains("formato") ||
                lowerMessage.Contains("dados") ||
                lowerMessage.Contains("parâmetro") ||
                lowerMessage.Contains("cpf/cnpj") ||
                lowerMessage.Contains("propriedade") ||
                lowerMessage.Contains("tamanho dos caracteres"))
            {
                return StatusCodes.Status400BadRequest;
            }

            // 422 - Unprocessable Entity (regras de negócio)
            if (lowerMessage.Contains("só pode") ||
                lowerMessage.Contains("não é possível") ||
                lowerMessage.Contains("você só pode") ||
                lowerMessage.Contains("status") ||
                lowerMessage.Contains("regra") ||
                lowerMessage.Contains("validação") ||
                lowerMessage.Contains("publicado") ||
                lowerMessage.Contains("inventario não foi gerado"))
            {
                return StatusCodes.Status422UnprocessableEntity;
            }

            // 503 - Service Unavailable (problemas externos)
            if (lowerMessage.Contains("banco do brasil") ||
                lowerMessage.Contains("timeout") ||
                lowerMessage.Contains("conexão") ||
                lowerMessage.Contains("serviço indisponível") ||
                lowerMessage.Contains("erro ao criar boleto"))
            {
                return StatusCodes.Status503ServiceUnavailable;
            }

            // 405 - Method Not Allowed
            if (lowerMessage.Contains("método não") ||
                lowerMessage.Contains("não está permitido") ||
                lowerMessage.Contains("method not allowed"))
            {
                return StatusCodes.Status405MethodNotAllowed;
            }

            // Default: 500 - Internal Server Error
            return StatusCodes.Status500InternalServerError;
        }

        private static bool ExisteExcecao(ActionExecutedContext context)
        {
            return context.Exception != null;
        }

        private void HandleException(ActionExecutedContext context, Stopwatch stopwatch, int statusCode)
        {
            GenerateExceptionResponseToClient(context.HttpContext, statusCode, context.Exception!).Wait();
        }

        private static string CalcularSeveridade(int statusCode)
        {
            return statusCode switch
            {
                // Nível 1 - Informacional (não são erros realmente)
                >= 200 and <= 299 => "1",

                // Nível 2 - Erro do cliente - problemas menores
                400 or 401 or 403 or 404 or 405 or 409 or 422 => "2",

                // Nível 3 - Erro do cliente - problemas moderados
                >= 400 and <= 499 => "3",

                // Nível 4 - Erro do servidor - problemas graves
                500 or 502 or 503 => "4",

                // Nível 5 - Erro crítico do servidor
                >= 500 and <= 599 => "5",

                // Default para casos não mapeados
                _ => "-"
            };
        }

        private async Task GenerateExceptionResponseToClient(
         HttpContext context,
         int code,
         Exception ex)
        {
            string errorMessage = !string.IsNullOrEmpty(ex.InnerException?.Message)
                ? ex.InnerException.Message
                : ex.Message;

            context.Response.StatusCode = code;

            string? tenant = context.Request.Headers["Tenant_ID"][0];

            // Capturar e serializar headers (limitado a 10000 caracteres)
            string jsonHeader = "";
            try
            {
                var headersDict = context.Request.Headers.ToDictionary(h => h.Key, h => h.Value.ToString());

                // Adicionar informações extras do context.Request
                headersDict["RequestPath"] = context.Request.Path.ToString();
                headersDict["RequestHost"] = context.Request.Host.ToString();
                headersDict["RequestMethod"] = context.Request.Method;
                headersDict["RequestScheme"] = context.Request.Scheme;
                headersDict["RequestQueryString"] = context.Request.QueryString.ToString();
                headersDict["RequestContentType"] = context.Request.ContentType ?? "";
                headersDict["RequestContentLength"] = context.Request.ContentLength?.ToString() ?? "";
                headersDict["StackTrace"] = ex.StackTrace?.ToString() ?? "";

                jsonHeader = JsonSerializer.Serialize(headersDict);
                if (jsonHeader.Length > 10000)
                {
                    jsonHeader = jsonHeader.Substring(0, 10000);
                }
            }
            catch
            {
                jsonHeader = ""; // Em caso de erro na serialização, deixa vazio
            }

            // Capturar e serializar query parameters (limitado a 10000 caracteres)
            string? jsonQuery = null;
            try
            {
                if (context.Request.Query.Any())
                {
                    var queryDict = context.Request.Query.ToDictionary(q => q.Key, q => q.Value.ToString());
                    string serializedQuery = JsonSerializer.Serialize(queryDict);
                    if (serializedQuery.Length > 10000)
                    {
                        jsonQuery = serializedQuery.Substring(0, 10000);
                    }
                    else
                    {
                        jsonQuery = serializedQuery;
                    }
                }
                // Se não há query parameters, jsonQuery permanece null
            }
            catch
            {
                jsonQuery = null; // Em caso de erro na serialização, deixa null
            }

            // Capturar o body da requisição (limitado a 10000 caracteres)
            string? jsonBody = null;
            if (context.Items.TryGetValue(REQUEST_BODY_KEY, out var bodyObj) && bodyObj is string body && !string.IsNullOrEmpty(body))
            {
                if (body.Length > 10000)
                {
                    jsonBody = body.Substring(0, 10000);
                }
                else
                {
                    jsonBody = body;
                }
            }

            var numeroLinhasAfetadas = -1;
            try
            {
                string userName = context.User.Identity?.Name ?? "Localhost";
                string severidade = code.ToString();
                string mensagemErro = !string.IsNullOrEmpty(ex.InnerException?.Message)
                    ? ex.InnerException.Message
                    : ex.Message;

                // Usar SQL direto ao invés do Entity Framework
                using var connection = _appDbContext.Database.GetDbConnection();
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    await connection.OpenAsync();
                }

                using var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO OSUSR_E9A_CSICP_SY997 
                    (
                        TENANT_ID, 
                        SY997_DATAINC, 
                        SY997_NOMEUSUARIO, 
                        SY997_ISEXIBIU, 
                        SY997_SEVERIDADE, 
                        SY997_MENSAGEM, 
                        SY997_EXTERNAL_ID, 
                        JSON_HEADER, 
                        JSON_QUERY, 
                        JSON_BODY
                    )
                    VALUES 
                    (
                        @TenantId, 
                        @DataInc, 
                        @NomeUsuario, 
                        @IsExibiu, 
                        @Severidade, 
                        @Mensagem, 
                        @ExternalId, 
                        @JsonHeader, 
                        @JsonQuery, 
                        @JsonBody
                    )";

                // Adicionar parâmetros
                var tenantParam = command.CreateParameter();
                tenantParam.ParameterName = "@TenantId";
                tenantParam.Value = int.Parse(tenant ?? "-1");
                command.Parameters.Add(tenantParam);

                var dataIncParam = command.CreateParameter();
                dataIncParam.ParameterName = "@DataInc";
                dataIncParam.Value = DateTime.UtcNow.ToLocalTime();
                command.Parameters.Add(dataIncParam);

                var nomeUsuarioParam = command.CreateParameter();
                nomeUsuarioParam.ParameterName = "@NomeUsuario";
                nomeUsuarioParam.Value = userName.Length > 100 ? userName.Substring(0, 100) : userName;
                command.Parameters.Add(nomeUsuarioParam);

                var isExibiuParam = command.CreateParameter();
                isExibiuParam.ParameterName = "@IsExibiu";
                isExibiuParam.Value = false;
                command.Parameters.Add(isExibiuParam);

                var severidadeParam = command.CreateParameter();
                severidadeParam.ParameterName = "@Severidade";
                severidadeParam.Value = CalcularSeveridade(code);
                command.Parameters.Add(severidadeParam);

                var mensagemParam = command.CreateParameter();
                mensagemParam.ParameterName = "@Mensagem";
                mensagemParam.Value = mensagemErro ?? (object)DBNull.Value;
                command.Parameters.Add(mensagemParam);

                var externalIdParam = command.CreateParameter();
                externalIdParam.ParameterName = "@ExternalId";
                externalIdParam.Value = Guid.NewGuid().ToString();
                command.Parameters.Add(externalIdParam);

                var jsonHeaderParam = command.CreateParameter();
                jsonHeaderParam.ParameterName = "@JsonHeader";
                jsonHeaderParam.Value = jsonHeader ?? (object)DBNull.Value;
                command.Parameters.Add(jsonHeaderParam);

                var jsonQueryParam = command.CreateParameter();
                jsonQueryParam.ParameterName = "@JsonQuery";
                jsonQueryParam.Value = jsonQuery ?? (object)DBNull.Value;
                command.Parameters.Add(jsonQueryParam);

                var jsonBodyParam = command.CreateParameter();
                jsonBodyParam.ParameterName = "@JsonBody";
                jsonBodyParam.Value = jsonBody ?? (object)DBNull.Value;
                command.Parameters.Add(jsonBodyParam);

                numeroLinhasAfetadas = await command.ExecuteNonQueryAsync();
            }
            catch (Exception exx)
            {
                errorMessage = "Ao Salvar Log: " + (!string.IsNullOrEmpty(exx.InnerException?.Message)
                   ? exx.InnerException.Message
                   : exx.Message);
            }

            await context.Response.WriteAsJsonAsync(new DtoApiResponse<object>
            {
                TraceID = "",
                Success = false,
                Message = "Linhas afetadas: " + numeroLinhasAfetadas + " - Mensagens: " + errorMessage,
                CaminhoEndpoint = context.Request.Path,
                HeadersRequisicao = context.Request.Headers,

            }, new JsonSerializerOptions
            {
                PropertyNamingPolicy = null // Mantém a capitalização original
            });
        }
    }
}