using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy.Template;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy
{
    public class ExportarArquivoExcelBlocoK : ExportarArquivoTemplate, IExportarArquivo
    {
        private readonly AppDbContext _appDbContext;

        public ExportarArquivoExcelBlocoK(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }


        public async Task<(byte[], string filename)> Exportar(string inGg032ID, int inTenantID)
        {
            (var produtosDoInventario, var protocolo) = await GetInventario(inGg032ID, inTenantID, _appDbContext);
            using var workbook = new ClosedXML.Excel.XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Produtos do Inventário");

            AdicionarCabecalhoPlanilha(worksheet);

            int index = 2;
            foreach (var currentProduto in produtosDoInventario)
            {
                worksheet.Cell(index, 1).Value = currentProduto.Bb001Codigoempresa + "-" + currentProduto.Bb001Razaosocial;

                worksheet.Cell(index, 2).Value = new DateOnly(
                    currentProduto.Gg032Datamovimento!.Value.Year,
                    currentProduto.Gg032Datamovimento!.Value.Month,
                    1).ToString();

                worksheet.Cell(index, 3).Value = currentProduto.Gg032Datamovimento.ToString();
                worksheet.Cell(index, 4).Value = currentProduto.Gg033Produto;
                worksheet.Cell(index, 5).Value = produtosDoInventario.Count;
                worksheet.Cell(index, 6).Value = 0;
                worksheet.Cell(index, 7).Value = "";
                worksheet.Cell(index, 8).Value = "";
                index++;
            }
            var filename = GetFilename(protocolo ?? "", "Block-K", ExtensaoArquivo.XLSX);
            var bytesParaDownload = DownloadFileWithMemoryStream(workbook, filename);
            return (bytesParaDownload, filename);
        }



        public override void AdicionarCabecalhoPlanilha(ClosedXML.Excel.IXLWorksheet worksheet)
        {
            // Criação das colunas na primeira linha
            worksheet.Cell(1, 1).Value = "Estabelecimento";
            worksheet.Cell(1, 2).Value = "Periodo";
            worksheet.Cell(1, 3).Value = "DtEstqFinal";
            worksheet.Cell(1, 4).Value = "Item";
            worksheet.Cell(1, 5).Value = "Qtd_Inventario";
            worksheet.Cell(1, 6).Value = "Tipo_Estoque";
            worksheet.Cell(1, 7).Value = "Participante";
            worksheet.Cell(1, 8).Value = "Origem";
        }
    }
}
