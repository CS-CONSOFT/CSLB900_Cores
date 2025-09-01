using CSCore.Ifs.CS_Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy
{
    public enum TipoExportacao
    {
        XLS
    }
    public class ExportarArquivoStrategy
    {
        public static IExportarArquivo ExportarArquivo(TipoExportacao tipoExportacao, AppDbContext appDbContext)
        {
            IExportarArquivo exportarArquivo = tipoExportacao switch
            {
                TipoExportacao.XLS => new ExportarArquivoExcelStrategy(appDbContext),


                _ => throw new NotImplementedException("Tipo de exportação não suportado")
            };
            return exportarArquivo;
        }
    }
}
