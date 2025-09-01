using CSCore.Ifs.CS_Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy
{

    public class ExportarArquivoFactory
    {
        public static IExportarArquivo ExportarArquivo(CSEnumTipoExportacaoArquivo tipoExportacao, AppDbContext appDbContext)
        {
            IExportarArquivo exportarArquivo = tipoExportacao switch
            {
                CSEnumTipoExportacaoArquivo.XLS_BLC_K => new ExportarArquivoExcelBlocoK(appDbContext),
                CSEnumTipoExportacaoArquivo.XLS_BLC_0200 => new ExportarArquivoExcelBloco0200(appDbContext),

                CSEnumTipoExportacaoArquivo.TXT_BLOCO_H2 => new ExportarArquivoTXTBlocoH_e_H2(appDbContext,InFuncIf: FuncIfBlocoH2()),

                CSEnumTipoExportacaoArquivo.TXT_BLOCO_H => new ExportarArquivoTXTBlocoH_e_H2(appDbContext, InFuncIf: FuncIfBlocoH()),

                CSEnumTipoExportacaoArquivo.XLS_SISPRO => new ExportarArquivoExcelSISPRO(appDbContext),
                _ => throw new NotImplementedException("Tipo de exportação não suportado")
            };
            return exportarArquivo;
        }

        private static Func<Template.DtoArquivosFiscaisExcelGetInventario, bool> FuncIfBlocoH()
        {
            return (produto) => produto.GG520_vBCSTRet > 0 && produto.Gg520Saldo > 0;
        }

        private static Func<Template.DtoArquivosFiscaisExcelGetInventario, bool> FuncIfBlocoH2()
        {
            return (produto) => produto.Gg520Saldo > 0 && produto.GG021_Perc_ICMS > 0 || produto.AliqICMS > 0;
        }
    }
}
