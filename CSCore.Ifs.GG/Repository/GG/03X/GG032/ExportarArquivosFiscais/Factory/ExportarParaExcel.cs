using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Factory.Template;
using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy;
using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy.Template;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais
{
    public class ExportarParaExcel : ExportarArquivoTemplateExcel, IExportarArquivo
    {
        private readonly AppDbContext _appDbContext;

        public ExportarParaExcel(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<(byte[], string filename)> Exportar(string gg032ID, int inTenantID)
        {
            (var produtosDoInventario, var protocolo) = await GetInventario(gg032ID, inTenantID, _appDbContext);
            using var workbook = new ClosedXML.Excel.XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Produtos do Inventário");

            AdicionarCabecalhoPlanilha(worksheet);

            int index = 2;
            foreach (var currentProduto in produtosDoInventario)
            {
                worksheet.Cell(index, 1).Value = currentProduto.Gg033Produto;                    // CodProduto
                worksheet.Cell(index, 2).Value = currentProduto.Gg033DescricaoProduto;           // DescricaoProduto
                worksheet.Cell(index, 3).Value = currentProduto.EAN_Tributavel;                  // EAN_Tributavel
                worksheet.Cell(index, 4).Value = currentProduto.Unidade;                         // Unidade
                worksheet.Cell(index, 5).Value = currentProduto.UnDescricao;                     // Un_Descricao
                worksheet.Cell(index, 6).Value = "04";                                              // TpItem
                worksheet.Cell(index, 7).Value = currentProduto.NCM;                             // NCM
                worksheet.Cell(index, 8).Value = currentProduto.EXNCM;                           // EX_NCM
                worksheet.Cell(index, 9).Value = currentProduto.Genero;                          // Genero
                worksheet.Cell(index, 10).Value = currentProduto.AliqICMS;                       // AliqICMS
                worksheet.Cell(index, 11).Value = currentProduto.IndPropriedade;                 // IndPropriedade
                worksheet.Cell(index, 12).Value = currentProduto.QtdInventario;                  // Qtd_Inventario
                worksheet.Cell(index, 13).Value = currentProduto.PrecoCusto;                     // Preco_Custo
                worksheet.Cell(index, 14).Value = currentProduto.PrecoCustoReal;                 // Preco_Custo_Real
                worksheet.Cell(index, 15).Value = currentProduto.TotalCusto;                     // Total_Custo
                worksheet.Cell(index, 16).Value = currentProduto.TotalCustoReal;                 // Total_Custo_Real
                worksheet.Cell(index, 17).Value = currentProduto.RazaoSocial;                    // Razao_Social
                worksheet.Cell(index, 18).Value = "";                                            // ContaContabil
                worksheet.Cell(index, 19).Value = "";                                            // DtIncAltCtb
                worksheet.Cell(index, 20).Value = "";                                            // CtaContabilNatureaza
                worksheet.Cell(index, 21).Value = "";                                            // TpContaCtb

                // Campos condicionais - vazios quando TpItem = "04" e IndPropriedade == "0"
                worksheet.Cell(index, 22).Value = string.IsNullOrEmpty(currentProduto.NomePessoalEmpresarial) ? "" : currentProduto.NomePessoalEmpresarial;           // Nome_Pessoal_Empresarial
                worksheet.Cell(index, 23).Value = string.IsNullOrEmpty(currentProduto.Codigodopais) ? "" : currentProduto.Codigodopais;                             // Codigodopais
                worksheet.Cell(index, 24).Value = string.IsNullOrEmpty(currentProduto.CNPJCPF) ? "" : currentProduto.CNPJCPF;                                       // CNPJ_CPF
                worksheet.Cell(index, 25).Value = string.IsNullOrEmpty(currentProduto.InscricaoEstadual) ? "" : currentProduto.InscricaoEstadual;                   // InscricaoEstadual
                worksheet.Cell(index, 26).Value = string.IsNullOrEmpty(currentProduto.Codigodomunicipio) ? "" : currentProduto.Codigodomunicipio;                   // Codigodomunicipio
                worksheet.Cell(index, 27).Value = string.IsNullOrEmpty(currentProduto.SUFRAMA) ? "" : currentProduto.SUFRAMA;                                       // SUFRAMA
                worksheet.Cell(index, 28).Value = string.IsNullOrEmpty(currentProduto.Logradouro) ? "" : currentProduto.Logradouro;                                 // Logradouro
                worksheet.Cell(index, 29).Value = string.IsNullOrEmpty(currentProduto.Numerodoimovel) ? "" : currentProduto.Numerodoimovel;                         // Numerodimovel
                worksheet.Cell(index, 30).Value = string.IsNullOrEmpty(currentProduto.Dadoscomplementaresdoendereco) ? "" : currentProduto.Dadoscomplementaresdoendereco; // Dadoscomplementaresdoendereco
                worksheet.Cell(index, 31).Value = string.IsNullOrEmpty(currentProduto.Bairro) ? "" : currentProduto.Bairro;                                         // Bairro
                worksheet.Cell(index, 32).Value = currentProduto.Codigodopais;                                            // CEP
                index++;
            }
            var filename = GetFilename(protocolo ?? "", "Arq", ExtensaoArquivo.XLSX);
            var bytesParaDownload = DownloadFileWithMemoryStream(workbook, filename);
            return (bytesParaDownload, filename);
        }



        protected override void AdicionarCabecalhoPlanilha(ClosedXML.Excel.IXLWorksheet worksheet)
        {
            string[] cabecalhos =
            [
                "CodProduto",
                "DescricaoProduto",
                "EAN_Tributavel",
                "Unidade",
                "Un_Descricao",
                "TpItem",
                "NCM",
                "EX_NCM",
                "Genero",
                "AliqICMS",
                "IndPropriedade",
                "Qtd_Inventario",
                "Preco_Custo",
                "Preco_Custo_Real",
                "Total_Custo",
                "Total_Custo_Real",
                "Razao_Social",
                "ContaContabil",
                "DtIncAltCtb",
                "CtaContabilNatureaza",
                "TpContaCtb",
                "Nome_Pessoal_Empresarial",
                "Codigodopais",
                "CNPJ_CPF",
                "InscricaoEstadual",
                "Codigodomunicipio",
                "SUFRAMA",
                "Logradouro",
                "Numerodimovel",
                "Dadoscomplementaresdoendereco",
                "Bairro",
                "CEP"
            ];

            for (int i = 0; i < cabecalhos.Length; i++)
            {
                worksheet.Cell(1, i + 1).Value = cabecalhos[i];
            }
        }
    }
}
