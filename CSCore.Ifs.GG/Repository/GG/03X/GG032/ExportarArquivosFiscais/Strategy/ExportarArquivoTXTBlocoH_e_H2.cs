using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy.Template;
using System.Text;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy
{
    public class ExportarArquivoTXTBlocoH_e_H2 : ExportarArquivoTemplate, IExportarArquivo
    {
        private readonly AppDbContext _appDbContext;
        private Func<DtoArquivosFiscaisExcelGetInventario, bool> _InFuncIf;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="appDbContext"></param>
        /// <param name="InFuncIf">O FuncIf é uma função de filtro, passada como parâmetro para a estratégia de exportação, que determina dinamicamente quais produtos do inventário devem ser incluídos em determinados registros do arquivo fiscal, conforme regras específicas de cada bloco (H ou H2).</param>
        public ExportarArquivoTXTBlocoH_e_H2(AppDbContext appDbContext, Func<DtoArquivosFiscaisExcelGetInventario, bool> InFuncIf)
        {
            _appDbContext = appDbContext;
            _InFuncIf = InFuncIf;
        }


        public async Task Exportar(string gg032ID, int inTenantID)
        {
            var produtosInventario = await GetInventario(gg032ID, inTenantID, _appDbContext);

            string protocolo = produtosInventario.FirstOrDefault()?.Gg032Protocolo ?? "0";
            using var file = File.AppendText(GetFilePath("Prt."+ protocolo + ".CS.BlocoH", ExtensaoArquivo.TXT));

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

            // Escrever todo o conteúdo no arquivo
            file.Write(arqText.ToString());
            file.Close();
        }

    }
}
