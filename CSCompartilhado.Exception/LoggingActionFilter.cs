using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Json;

namespace CSS_FF105Financeiro.C10API.Filtros
{
    public class LoggingActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var jsonLog = new
            {
                parametros = context.ActionArguments,
                metodo = context.ActionDescriptor.DisplayName,
                classe = context.Controller.GetType().Name,
                hora = DateTime.UtcNow.ToLocalTime()
            };
            var json = JsonSerializer.Serialize(jsonLog);
            //Console.WriteLine($"LOG em {context.Controller.GetType().Name}: {json}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Opcional: log após execução
        }
    }
}
