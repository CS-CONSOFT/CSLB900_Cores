using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Factory.Template;
using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy.Template;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy
{
    internal class ExportarArquivoExcelBloco0200 : ExportarArquivoTemplateExcel, IExportarArquivo
    {
        private readonly AppDbContext _appDbContext;

        public ExportarArquivoExcelBloco0200(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
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
                worksheet.Cell(index, 1).Value = currentProduto.Gg033Produto;
                worksheet.Cell(index, 2).Value = currentProduto.Gg033DescricaoProduto;
                worksheet.Cell(index, 3).Value = currentProduto.EAN_Tributavel.ToString();
                worksheet.Cell(index, 4).Value = currentProduto.QtdInventario;
                worksheet.Cell(index, 5).Value = currentProduto.PrecoCusto;
                worksheet.Cell(index, 6).Value = currentProduto.PrecoCustoReal;
                worksheet.Cell(index, 7).Value = currentProduto.TotalCusto;
                worksheet.Cell(index, 8).Value = currentProduto.RazaoSocial;
                worksheet.Cell(index, 9).Value = currentProduto.TotalCustoReal;
                worksheet.Cell(index, 10).Value = currentProduto.NomePessoalEmpresarial;
                worksheet.Cell(index, 11).Value = currentProduto.Codigodopais;
                worksheet.Cell(index, 12).Value = currentProduto.CNPJCPF;
                worksheet.Cell(index, 13).Value = currentProduto.InscricaoEstadual;
                worksheet.Cell(index, 14).Value = currentProduto.Codigodomunicipio;
                worksheet.Cell(index, 15).Value = currentProduto.SUFRAMA;
                worksheet.Cell(index, 16).Value = currentProduto.Logradouro;
                worksheet.Cell(index, 17).Value = currentProduto.Numerodoimovel;
                worksheet.Cell(index, 18).Value = currentProduto.Dadoscomplementaresdoendereco;
                worksheet.Cell(index, 19).Value = currentProduto.Bairro;
                worksheet.Cell(index, 20).Value = currentProduto.Unidade;
                worksheet.Cell(index, 21).Value = currentProduto.UnDescricao;
                worksheet.Cell(index, 22).Value = currentProduto.TpItem;
                worksheet.Cell(index, 23).Value = currentProduto.NCM;
                worksheet.Cell(index, 24).Value = currentProduto.EXNCM;
                worksheet.Cell(index, 25).Value = currentProduto.Genero;
                worksheet.Cell(index, 26).Value = currentProduto.AliqICMS;
                worksheet.Cell(index, 27).Value = currentProduto.IndPropriedade;
                index++;
            }

            var filename = GetFilename(protocolo ?? "", "Block-0200", ExtensaoArquivo.XLSX);
            var bytesParaDownload = DownloadFileWithMemoryStream(workbook, filename);
            return (bytesParaDownload, filename);
        }

        protected override void AdicionarCabecalhoPlanilha(ClosedXML.Excel.IXLWorksheet worksheet)
        {
            // Criação das colunas na primeira linha
            worksheet.Cell(1, 1).Value = "Cod Produto";
            worksheet.Cell(1, 2).Value = "Descricao Produto";
            worksheet.Cell(1, 3).Value = "EAN Tributavel";
            worksheet.Cell(1, 4).Value = "Qtd Inventario";
            worksheet.Cell(1, 5).Value = "Preco Custo";
            worksheet.Cell(1, 6).Value = "Preco Custo Real";
            worksheet.Cell(1, 7).Value = "Total Custo";
            worksheet.Cell(1, 8).Value = "Razao Social";
            worksheet.Cell(1, 9).Value = "Total Custo Real";
            worksheet.Cell(1, 10).Value = "Nome Pessoal Empresarial";
            worksheet.Cell(1, 11).Value = "Codigo do Pais";
            worksheet.Cell(1, 12).Value = "CNPJ CPF";
            worksheet.Cell(1, 13).Value = "Inscricao Estadual";
            worksheet.Cell(1, 14).Value = "Codigo do Municipio";
            worksheet.Cell(1, 15).Value = "SUFRAMA";
            worksheet.Cell(1, 16).Value = "Logradouro";
            worksheet.Cell(1, 17).Value = "Numero do Imovel";
            worksheet.Cell(1, 18).Value = "Dados Complementares do Endereco";
            worksheet.Cell(1, 19).Value = "Bairro";
            worksheet.Cell(1, 20).Value = "Unidade";
            worksheet.Cell(1, 21).Value = "Un Descricao";
            worksheet.Cell(1, 22).Value = "Tp Item";
            worksheet.Cell(1, 23).Value = "NCM";
            worksheet.Cell(1, 24).Value = "EX NCM";
            worksheet.Cell(1, 25).Value = "Genero";
            worksheet.Cell(1, 26).Value = "Aliq ICMS";
            worksheet.Cell(1, 27).Value = "Ind Propriedade";
        }
    }
}
