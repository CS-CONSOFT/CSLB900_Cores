using CSCore.Domain.CS_Models.CSICP_SYS;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
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
            ReadRequestBody(context.HttpContext);
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

            // Recupera o corpo da requisição armazenado nos Items
            string? requestBody = GetRequestBodyFromContext(context);

            CSICP_SY997_LOGS log = new CSICP_SY997_LOGS
            {
                Sy997ExternalId = null,
                Sy997Datainc = DateTime.UtcNow.ToLocalTime(),
                Sy997Nomeusuario = context.User.Identity?.Name ?? "Unknown",
                Sy997Mensagem = errorMessage + " || Caminho: " + context.Request.Path,
                Sy997Isexibiu = false,
                Sy997Severidade = CalcularSeveridade(code),
                TenantId = int.Parse(tenant ?? "-1")
            };
            _appDbContext.Add(log);
            var id = await _appDbContext.SaveChangesAsync();

            await context.Response.WriteAsJsonAsync(new DtoApiResponse<object>
            {
                TraceID = "",
                Success = false,
                Message = errorMessage,
                CaminhoEndpoint = context.Request.Path,
                HeadersRequisicao = context.Request.Headers,
                
            }, new JsonSerializerOptions
            {
                PropertyNamingPolicy = null // Mantém a capitalização original
            });
        }


        private void ReadRequestBody(HttpContext context)
        {
            var request = context.Request;

            // Só lê o corpo para métodos que enviam dados
            if (HasRequestBody(request.Method))
            {
                request.EnableBuffering();

                using var reader = new StreamReader(request.Body, Encoding.UTF8, leaveOpen: true);
                var body = reader.ReadToEndAsync().Result;

                // Armazena o corpo da requisição no Items para uso posterior
                context.Items[REQUEST_BODY_KEY] = body;

                Console.WriteLine($"Corpo da requisição: {body}");

                request.Body.Position = 0;
            }
        }

        private static bool HasRequestBody(string method)
        {
            return method.Equals("POST", StringComparison.OrdinalIgnoreCase) ||
                   method.Equals("PUT", StringComparison.OrdinalIgnoreCase);
        }

        private static string? GetRequestBodyFromContext(HttpContext context)
        {
            return context.Items.TryGetValue(REQUEST_BODY_KEY, out var body) ? body?.ToString() : null;
        }
    }
}