using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Factory.Template
{
    public abstract class ExportarArquivoTemplateExcel : ExportarArquivoTemplate
    {
        public abstract void AdicionarCabecalhoPlanilha(ClosedXML.Excel.IXLWorksheet worksheet);
    }
}
