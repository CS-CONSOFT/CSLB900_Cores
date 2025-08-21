using CSLB900.MSTools.GenerateId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.LB900.AdapterGerarValores
{
    public class GerarNovoUUID : IGenerate
    {
        private readonly ICS_GenerateId cS_GenerateId;

        public GerarNovoUUID(ICS_GenerateId cS_GenerateId)
        {
            this.cS_GenerateId = cS_GenerateId;
        }

        public async Task<string> Generate(string _, string __, string ___)
        {
            return cS_GenerateId.GenerateUuId();
        }
    }
}
