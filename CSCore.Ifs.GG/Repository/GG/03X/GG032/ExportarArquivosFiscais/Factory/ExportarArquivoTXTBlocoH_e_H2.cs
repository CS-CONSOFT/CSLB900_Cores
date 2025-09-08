using ClosedXML.Excel;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy.Template;
using NPOI.HPSF;
using System.Text;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy
{
    public class ExportarArquivoTXTBlocoH_e_H2 : ExportarArquivoTemplate, IExportarArquivo
    {
        private readonly AppDbContext _appDbContext;
        private Func<DtoArquivosFiscaisExcelGetInventario, bool> _InFuncIf;
        private string _NomeArquivo;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="appDbContext"></param>
        /// <param name="InFuncIf">O FuncIf é uma função de filtro, passada como parâmetro para a estratégia de exportação, que determina dinamicamente quais produtos do inventário devem ser incluídos em determinados registros do arquivo fiscal, conforme regras específicas de cada bloco (H ou H2).</param>
        public ExportarArquivoTXTBlocoH_e_H2(AppDbContext appDbContext,
            Func<DtoArquivosFiscaisExcelGetInventario, bool> InFuncIf, string NomeArquivo)
        {
            _appDbContext = appDbContext;
            _InFuncIf = InFuncIf;
            _NomeArquivo = NomeArquivo;
        }


        public async Task<(byte[], string filename)> Exportar(string gg032ID, int inTenantID)
        {
            (var produtosInventario, var protocolo) = await GetInventario(gg032ID, inTenantID, _appDbContext);
            using var file = File.AppendText(GetFilename(protocolo ?? "", _NomeArquivo, ExtensaoArquivo.TXT));

            var arqText = new StringBuilder();

            // Registro H990 - Cabeçalho do bloco
            var qtdLinhasH = ContarLinhasBloco(produtosInventario);
            arqText.AppendLine($"|H990|{qtdLinhasH}|");

            // H005 - Totais do inventário
            var h005 = FormatarRegistroH005(produtosInventario[0]);
            arqText.AppendLine(h005);

            // Registro H005 - Dados do inventário
            foreach (var produto in produtosInventario)
            {
                // H010 - Identificação do itemGg032_DataMovimento
                var h010 = FormatarRegistroH010(produto);
                arqText.AppendLine(h010);

                if (!_InFuncIf(produto))
                    continue;

                // H020 - Movimentação física do item
                var h020 = FormatarRegistroH020(produto);
                arqText.AppendLine(h020);
            }
            // Converter texto para bytes usando MemoryStream
            var fileName = GetFilename(protocolo ?? "", _NomeArquivo, ExtensaoArquivo.TXT);
            var textBytes = Encoding.UTF8.GetBytes(arqText.ToString());
            return (textBytes, fileName);
        }

    }
}
