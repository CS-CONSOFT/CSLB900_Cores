using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy
{
    public interface IExportarArquivo
    {
        public Task Exportar(string gg032ID, int inTenantID);
    }
}
