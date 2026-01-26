using CLT900DbCore.CSCore.Domain.ModelDBClinicTime;
using CSCore.Ex.Personalizada;
using CSLB900.MSTools.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Text;
using System.Text.Json;


namespace CSCore.Ex
{
    public class GlobalExceptionHandler
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionHandler> _logger;
        private const string REQUEST_BODY_KEY = "RequestBody";

        public GlobalExceptionHandler(
         RequestDelegate next,
         ILogger<GlobalExceptionHandler> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // Capturar request body antes de processar
                await CaptureRequestBodyAsync(context);

                // Continuar pipeline
                await _next(context);
            }
            catch (OperationCanceledException ex) when (context.RequestAborted.IsCancellationRequested)
            {
                // ✅ NÃO TRATA - Deixa o CancellationMiddleware tratar
                _logger.LogDebug("OperationCanceledException detectada - repassando para CancellationMiddleware");
                throw;
            }
            catch (TaskCanceledException ex) when (context.RequestAborted.IsCancellationRequested)
            {
                // ✅ NÃO TRATA - Deixa o CancellationMiddleware tratar
                _logger.LogDebug("TaskCanceledException detectada - repassando para CancellationMiddleware");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exceção não tratada capturada pelo middleware global");
                await HandleExceptionAsync(context, ex);
            }
          
        }


        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var statusCode = DetermineStatusCode(ex);
            var shouldSaveToDatabase = ShouldSaveException(ex);

            await GenerateExceptionResponseToClient(
                context,
                statusCode,
                ex,
                shouldSaveToDatabase);
        }

        private static int DetermineStatusCode(Exception ex) => ex switch
        {
            UnauthorizedAccessException => StatusCodes.Status401Unauthorized,
            InvalidDataException => StatusCodes.Status409Conflict,
            KeyNotFoundException => StatusCodes.Status404NotFound,
            ArgumentOutOfRangeException => StatusCodes.Status400BadRequest,
            ArgumentException => StatusCodes.Status400BadRequest,
            InvalidOperationException => StatusCodes.Status406NotAcceptable,
            ExceptionSemAuditoria exemptEx => DetermineStatusCodeFromMessage(exemptEx.Message),
            Exception genericEx => DetermineStatusCodeFromMessage(genericEx.Message),
            _ => StatusCodes.Status500InternalServerError
        };

        private static bool ShouldSaveException(Exception ex)
        {
            // Não salvar exceções que são só validação ou que implementam ExceptionSemAuditoria
            return ex is not ExceptionSemAuditoria;
        }

        private async Task CaptureRequestBodyAsync(HttpContext context)
        {
            if (context.Request.ContentLength > 0 &&
                context.Request.ContentType?.Contains("application/json") == true)
            {
                context.Request.EnableBuffering();

                using var reader = new StreamReader(
                    context.Request.Body,
                    Encoding.UTF8,
                    leaveOpen: true);

                var body = await reader.ReadToEndAsync();
                context.Request.Body.Position = 0;

                if (!string.IsNullOrEmpty(body))
                {
                    context.Items[REQUEST_BODY_KEY] = body;
                }
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
                lowerMessage.Contains("não encontrada") ||
                lowerMessage.Contains("not found") ||
                lowerMessage.Contains("nenhum produto") ||
                lowerMessage.Contains("entidade não encontrada") ||
                lowerMessage.Contains("nenhum registro encontrado") ||
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
                lowerMessage.Contains("inventario não foi gerado") ||
                lowerMessage.Contains("o movimento já está"))
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
 

  
        private async Task GenerateExceptionResponseToClient(
         HttpContext context,
         int code,
         Exception ex,
         bool? hasToSave = true)
        {
            string errorMessage = !string.IsNullOrEmpty(ex.InnerException?.Message)
                ? ex.InnerException.Message
                : ex.Message;

            context.Response.StatusCode = code;

            // Verificação segura do header Tenant_ID
            string? tenant = null;
            if (context.Request.Headers.TryGetValue("Tenant_ID", out var tenantValues) && tenantValues.Count > 0)
            {
                tenant = tenantValues[0];
            }

            if (hasToSave == true)
                errorMessage = await SaveExceptionLogAsync(context, code, ex, errorMessage, tenant);


            await context.Response.WriteAsJsonAsync(new DtoApiResponse<object>
            {
                Success = false,
                Message = errorMessage
            }, new JsonSerializerOptions
            {
                PropertyNamingPolicy = null // Mantém a capitalização original
            });
        }

        private async Task<string> SaveExceptionLogAsync(HttpContext context, int code, Exception ex, string errorMessage, string? tenant)
        {
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

                // Resolver o AppDbContext do escopo da requisição
                using var scope = context.RequestServices.CreateScope();
                var appDbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                // Usar SQL direto ao invés do Entity Framework
                using var connection = appDbContext.Database.GetDbConnection();
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
                severidadeParam.Value = severidade.Length > 50 ? severidade.Substring(0, 50) : severidade;
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

            return errorMessage;

        }
    }
}