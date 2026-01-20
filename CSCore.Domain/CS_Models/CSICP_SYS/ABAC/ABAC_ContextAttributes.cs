using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC
{
    public record ABAC_ContextAttributes
    {
        public string? Attributename { get; init; }

        public string? Attributevalue { get; init; }

        private ABAC_ContextAttributes()
        {
            
        }

        public ABAC_ContextAttributes(string? attributename, string? attributevalue)
        {
            Attributename = attributename;
            Attributevalue = attributevalue;
        }
    }
}
