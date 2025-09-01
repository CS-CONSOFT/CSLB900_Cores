using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy
{
    public class ExportarArquivoExcelStrategy : IExportarArquivo
    {
        private readonly AppDbContext _appDbContext;

        public ExportarArquivoExcelStrategy(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        private static readonly string FilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            "Downloads",
            "arquivo.xlsx");


        public async Task Exportar(string inGg032ID, int inTenantID)
        {
            var produtosDoInventario = await _appDbContext.OsusrE9aCsicpGg033s
                .AsNoTracking()
                .Where(e => e.Gg032Id == inGg032ID && e.TenantId == inTenantID)
                .ToListAsync();

            if (produtosDoInventario.Count == 0 || !produtosDoInventario.Any()) return;

            using var workbook = new ClosedXML.Excel.XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Produtos do Inventário");

            AdicionarCabecalhoPlanilha(worksheet);

            int index = 2;
            foreach (var currentProduto in produtosDoInventario)
            {
                index = AdicionarProdutoNaPlanilha(worksheet, index, currentProduto);
            }
            workbook.SaveAs(FilePath);



            //using var file = File.AppendText(FilePath);
            //file.WriteLine("Teste valter, produto: " + produtosDoInventario[0].Gg033Produto);
            //file.Close();
            ////File.Create(FilePath).Dispose();
        }

        private static int AdicionarProdutoNaPlanilha(ClosedXML.Excel.IXLWorksheet worksheet, int index, Domain.CS_Models.CSICP_GG.CSICP_GG033 currentProduto)
        {
            worksheet.Cell(index, 1).Value = currentProduto.Gg033Codigobarras;
            worksheet.Cell(index, 2).Value = "Descricao Produto";
            worksheet.Cell(index, 3).Value = "EAN Tributavel";
            worksheet.Cell(index, 4).Value = "Unidade";
            worksheet.Cell(index, 5).Value = "Un Descricao";
            worksheet.Cell(index, 6).Value = "Tp Item";
            worksheet.Cell(index, 7).Value = "NCM";
            worksheet.Cell(index, 8).Value = "EX NCM";
            worksheet.Cell(index, 9).Value = "Genero";
            worksheet.Cell(index, 10).Value = "Aliq ICMS";
            worksheet.Cell(index, 11).Value = "Ind Propriedade";
            worksheet.Cell(index, 12).Value = "Qtd Inventario";
            worksheet.Cell(index, 13).Value = currentProduto.Gg033Precocusto;
            worksheet.Cell(index, 14).Value = currentProduto.Gg033Precocustoreal;
            worksheet.Cell(index, 15).Value = "Total Custo";
            worksheet.Cell(index, 16).Value = "Total Custo Real";
            worksheet.Cell(index, 17).Value = "Razao Social";
            worksheet.Cell(index, 18).Value = "Conta Contabil";
            index++;
            return index;
        }

        private static void AdicionarCabecalhoPlanilha(ClosedXML.Excel.IXLWorksheet worksheet)
        {
            // Criação das colunas na primeira linha
            worksheet.Cell(1, 1).Value = "Cod Produto";
            worksheet.Cell(1, 2).Value = "Descricao Produto";
            worksheet.Cell(1, 3).Value = "EAN Tributavel";
            worksheet.Cell(1, 4).Value = "Unidade";
            worksheet.Cell(1, 5).Value = "Un Descricao";
            worksheet.Cell(1, 6).Value = "Tp Item";
            worksheet.Cell(1, 7).Value = "NCM";
            worksheet.Cell(1, 8).Value = "EX NCM";
            worksheet.Cell(1, 9).Value = "Genero";
            worksheet.Cell(1, 10).Value = "Aliq ICMS";
            worksheet.Cell(1, 11).Value = "Ind Propriedade";
            worksheet.Cell(1, 12).Value = "Qtd Inventario";
            worksheet.Cell(1, 13).Value = "Preco Custo";
            worksheet.Cell(1, 14).Value = "Preco Custo Real";
            worksheet.Cell(1, 15).Value = "Total Custo";
            worksheet.Cell(1, 16).Value = "Total Custo Real";
            worksheet.Cell(1, 17).Value = "Razao Social";
            worksheet.Cell(1, 18).Value = "Conta Contabil";
        }
    }
}
