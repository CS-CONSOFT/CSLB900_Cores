using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CSCore.Ex
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                // Coletar todas as mensagens de erro
                var errorMessages = context.ModelState
                    .SelectMany(ms => ms.Value.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                // Criar a mensagem concatenada com &&
                string concatenatedErrors = string.Join(" && ", errorMessages);

                var response = new DtoApiResponse<object>
                {
                    Success = false,
                    Message = concatenatedErrors, // Mensagem com erros concatenados
                    Data = new { Errors = errorMessages } // Opcional: manter os erros separados também
                };

                context.Result = new BadRequestObjectResult(response);
            }
        }
    }




    

}
