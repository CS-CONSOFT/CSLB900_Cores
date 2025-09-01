using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy
{
    public class ExportarArquivoExcelSISPRO : ExportarArquivoTemplate, IExportarArquivo
    {
        private readonly AppDbContext _appDbContext;

        public ExportarArquivoExcelSISPRO(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task Exportar(string gg032ID, int inTenantID)
        {
            var produtosInventario = await GetInventario(gg032ID, inTenantID, _appDbContext);
            if (produtosInventario.Count == 0 || !produtosInventario.Any()) return;
            using var workbook = new ClosedXML.Excel.XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Produtos do Inventário");

            AdicionarCabecalhoPlanilha(worksheet);


            var vlrTotalEstoque = produtosInventario.Sum(p => p.PrecoCusto * p.QtdInventario);
            int index = 2;
            foreach (var currentProduto in produtosInventario)
            {
                // 1. Estabelecimento
                worksheet.Cell(index, 1).Value = currentProduto.Bb001Codigoempresa.ToString();

                // 2. DataInventario
                worksheet.Cell(index, 2).Value = DateTime.Now.ToString("yyyy-MM-dd");

                // 3. VlrTotalEstoque
                worksheet.Cell(index, 3).Value = vlrTotalEstoque;

                // 4. CodProduto
                worksheet.Cell(index, 4).Value = currentProduto.Gg033Produto;

                // 5. Unidade
                worksheet.Cell(index, 5).Value = currentProduto.Unidade;

                // 6. Qtd
                worksheet.Cell(index, 6).Value = currentProduto.QtdInventario;

                // 7. VlrUnitario
                worksheet.Cell(index, 7).Value = currentProduto.PrecoCusto;

                // 8. ValorTotItem (PrecoCusto * QtdInventario)
                worksheet.Cell(index, 8).Value = currentProduto.PrecoCusto * currentProduto.QtdInventario;

                // 9. IndPropriedade
                worksheet.Cell(index, 9).Value = "";

                // 10. Participante
                worksheet.Cell(index, 10).Value = "";

                // 11. TextoComplementar
                worksheet.Cell(index, 11).Value = "";

                // 12. CodConta
                worksheet.Cell(index, 12).Value = "";

                // 13. VlrIR
                worksheet.Cell(index, 13).Value = 0;

                // 14. CSTICMS
                worksheet.Cell(index, 14).Value = "";

                // 15. BaseCalcICMS
                worksheet.Cell(index, 15).Value = 0;

                // 16. VlrICMS
                worksheet.Cell(index, 16).Value = 0;

                // 17. Origem
                worksheet.Cell(index, 17).Value = "";

                // 18. VlrICMSOF
                worksheet.Cell(index, 18).Value = 0;

                // 19. BaseCalcICMSST
                worksheet.Cell(index, 19).Value = 0;

                // 20. VlrICMSST
                worksheet.Cell(index, 20).Value = 0;

                // 21. ValorFCP
                worksheet.Cell(index, 21).Value = 0;

                index++;
            }
            workbook.SaveAs(GetFilePath("SISPRO." + produtosInventario[0].Gg032Protocolo, ExtensaoArquivo.XLSX));
        }

        public override void AdicionarCabecalhoPlanilha(ClosedXML.Excel.IXLWorksheet worksheet)
        {
            // Criação das colunas na primeira linha
            worksheet.Cell(1, 1).Value = "Estabelecimento";
            worksheet.Cell(1, 2).Value = "DataInventario";
            worksheet.Cell(1, 3).Value = "VlrTotalEstoque";
            worksheet.Cell(1, 4).Value = "CodProduto";
            worksheet.Cell(1, 5).Value = "Unidade";
            worksheet.Cell(1, 6).Value = "Qtd";
            worksheet.Cell(1, 7).Value = "VlrUnitario";
            worksheet.Cell(1, 8).Value = "ValorTotItem";
            worksheet.Cell(1, 9).Value = "IndPropriedade";
            worksheet.Cell(1, 10).Value = "Participante";
            worksheet.Cell(1, 11).Value = "TextoComplementar";
            worksheet.Cell(1, 12).Value = "CodConta";
            worksheet.Cell(1, 13).Value = "VlrIR";
            worksheet.Cell(1, 14).Value = "CSTICMS";
            worksheet.Cell(1, 15).Value = "BaseCalcICMS";
            worksheet.Cell(1, 16).Value = "VlrICMS";
            worksheet.Cell(1, 17).Value = "Origem";
            worksheet.Cell(1, 18).Value = "VlrICMSOF";
            worksheet.Cell(1, 19).Value = "BaseCalcICMSST";
            worksheet.Cell(1, 20).Value = "VlrICMSST";
            worksheet.Cell(1, 21).Value = "ValorFCP";
        }
    }
}
