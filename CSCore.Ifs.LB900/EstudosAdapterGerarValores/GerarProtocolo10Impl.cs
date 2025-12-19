using CSCore.Ifs.LB900.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.LB900.AdapterGerarValores
{
    public class GerarProtocolo10Impl : IGenerate
    {
        private readonly IGenerateProtocolo generateProtocolo;

        public GerarProtocolo10Impl(IGenerateProtocolo generateProtocolo)
        {
            this.generateProtocolo = generateProtocolo;
        }

        public async Task<string> Generate(string empresaID, string arquivo, string textName, int InTenantID)
        {
            decimal protocolo = await generateProtocolo.Fcn_Protocolo10(empresaID, arquivo, InTenantID);
            return protocolo.ToString();
        }
    }
}
