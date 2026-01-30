using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.Util;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.LB900.ABAC.Engine.ClassesAuxiliares
{
    public interface IHandleContextAttributes
    {
        IEnumerable<ABAC_ContextAttributes> GetListaContextAttributes();
    }
    public class HandleContextAttributes: IHandleContextAttributes
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public HandleContextAttributes(IHttpContextAccessor httpContextAccessor) 
        { 
            this._httpContextAccessor = httpContextAccessor;
        }

        public IEnumerable<ABAC_ContextAttributes> GetListaContextAttributes()
        {
            var strContext = "context.";
            var contexts = new List<ABAC_ContextAttributes>
            {
                new(strContext + "timeOfDay", CSHandleTime.GetHoraAtualFormatada()),
                new(strContext + "date", CSHandleTime.GetDataAtualFormatada()),
                new(strContext + "ipAddress", CSHandleSecurity.GetIPAddress()),
                new(strContext + "requestMethod", this._httpContextAccessor.HttpContext?.Request?.Method),
                new(strContext + "isBusinessHours", CSHandleTime.EhHorarioComercialSemAlmoco().ToString()),
                new(strContext + "dayOfWeek", CSHandleTime.DiaDaSemanaAtual()),
                new(strContext + "userAgent", this._httpContextAccessor.HttpContext?.Request.Headers["User-Agent"]),
            };

            return contexts;
        }
    }
}
