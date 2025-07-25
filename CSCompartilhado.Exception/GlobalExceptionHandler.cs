using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace CSCore.Ex
{
    public class GlobalExceptionHandler(ICS_ConsumingLog log) : IActionFilter
    {
        private readonly ICS_ConsumingLog _logService = log;


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
                    Data = errors // Passa os erros de validação para o campo Data
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
                else
                {
                    HandleException(context, stopwatch, StatusCodes.Status500InternalServerError);
                }
                context.ExceptionHandled = true;
            }
        }

        private static bool ExisteExcecao(ActionExecutedContext context)
        {
            return context.Exception != null;
        }

        private void HandleException(ActionExecutedContext context, Stopwatch stopwatch, int statusCode)
        {
            StopTimerRequestAndCallApiToCreateLog(context.HttpContext, stopwatch, context.Exception!);
            GenerateExceptionResponseToClient(context.HttpContext, statusCode, context.Exception!).Wait();
        }

        private static async Task GenerateExceptionResponseToClient(HttpContext context, int code, System.Exception ex)
        {
            string errorMessage = !string.IsNullOrEmpty(ex.InnerException?.Message)
                ? ex.InnerException.Message
                : ex.Message;
            context.Response.StatusCode = code;
            await context.Response.WriteAsJsonAsync(new DtoApiResponse<object>
            {
                Success = false,
                Message = errorMessage,
                Data = ex.StackTrace
            }, new JsonSerializerOptions
            {
                PropertyNamingPolicy = null // Mantém a capitalização original
            });
        }

        private void StopTimerRequestAndCallApiToCreateLog(HttpContext context, Stopwatch stopwatch, System.Exception ex)
        {
            stopwatch.Stop();
            var elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            var tenant = context.Request.Headers["Tenant_ID"].ToString();

            var dto = new Dto_CreateLog()
            {
                Message = ex.Message,
                Detail = ex.StackTrace,
                DetailLabel = context.Request.Path,
                Integration_Action = context.Request.Method,
                Integration_ApplicationName = "ERP",
                Integration_Endpoint = context.Request.Path,
                Integration_Instant = DateTime.Now,
                Integration_IsExpose = true,
                Integration_TenantId = int.TryParse(tenant, out var tenantId) ? tenantId : 0,
                Integration_Type = context.Request.Method,
                Integration_Duration = (int)elapsedMilliseconds
            };

            //_logService.CreateLogAsync(dto, int.Parse(tenant));
        }

        private void ReadRequestBody(HttpContext context)
        {
            var request = context.Request;
            request.EnableBuffering();

            using var reader = new StreamReader(request.Body, Encoding.UTF8, leaveOpen: true);
            var body = reader.ReadToEndAsync().Result;

            Console.WriteLine($"Corpo da requisição: {body}");

            request.Body.Position = 0;
        }
    }
}