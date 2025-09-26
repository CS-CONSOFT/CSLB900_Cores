using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy;
using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Factory
{

    internal class ExportarArquivoTXTBloco2000 : ExportarArquivoTemplate, IExportarArquivo
    {
        private readonly AppDbContext _appDbContext;
        private string _NomeArquivo;

        public ExportarArquivoTXTBloco2000(AppDbContext appDbContext,string nomeArquivo)
        {
            _appDbContext = appDbContext;
            _NomeArquivo = nomeArquivo;
        }

        public async Task<(byte[], string filename)> Exportar(string gg032ID, int inTenantID)
        {
            (var produtosInventario, var protocolo) = await GetInventario(gg032ID, inTenantID, _appDbContext);
            using var file = File.AppendText(GetFilename(protocolo ?? "", _NomeArquivo, ExtensaoArquivo.TXT));

            var arqText = new StringBuilder();

            // Registro H005 - Dados do inventário
            foreach (var produto in produtosInventario)
            {
                // H010 - Identificação do itemGg032_DataMovimento
                var h010 = FormatarRegistro(produto);
                arqText.AppendLine(h010);
            }

            // Converter texto para bytes usando MemoryStream
            var fileName = GetFilename(protocolo ?? "", _NomeArquivo, ExtensaoArquivo.TXT);
            var textBytes = Encoding.UTF8.GetBytes(arqText.ToString());
            return (textBytes, fileName);
        }

        public virtual string FormatarRegistro(DtoArquivosFiscaisExcelGetInventario produto)
        {
            // Separador pipe
            var v_pipe = "|";
            // Montagem do registro conforme ordem solicitada
            var reg = "0200";
            var codItem = produto.Gg033Produto.ToString() ?? "";
            var descrItem = produto.Gg033DescricaoProduto ?? "";
            var codBarra = produto.EAN_Tributavel.ToString();
            var codAntItem = "";
            var unidInv = produto.Unidade ?? "";
            var tipoItem = produto.TpItem ?? "";
            var codNcm = produto.NCM.ToString();
            var exIpi = produto.EXNCM;
            var codGen = produto.Genero;
            var codLst = "";
            var aliqIcms = produto.AliqICMS.ToString();
            var cest = "";

            return $"{v_pipe}{reg}{v_pipe}{codItem}{v_pipe}{descrItem}{v_pipe}{codBarra}{v_pipe}{codAntItem}{v_pipe}{unidInv}{v_pipe}{tipoItem}{v_pipe}{codNcm}{v_pipe}{exIpi}{v_pipe}{codGen}{v_pipe}{codLst}{v_pipe}{aliqIcms}{v_pipe}{cest}{v_pipe}{Environment.NewLine}";
        }

        public virtual string FormatarDecimal(decimal? valor, int casasDecimais)
        {
            if (!valor.HasValue) return "0".PadLeft(casasDecimais + 1, '0');

            var valorFormatado = valor.Value.ToString($"F{casasDecimais}").Replace(",", "").Replace(".", "");
            return valorFormatado;
        }


    }
}
