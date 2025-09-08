using ClosedXML.Excel;
using CSCore.Ifs.CS_Context;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy.Template
{
    public class DtoArquivosFiscaisExcelGetInventario
    {
        public string BB001_Id { get; set; } = string.Empty;
        public int Bb001Codigoempresa { get; set; } = 0;
        public string Bb001Razaosocial { get; set; } = string.Empty;
        public DateTime? Gg032Datamovimento { get; set; } = default;
        public string? Gg032Protocolo { get; set; } = default;
        public int Gg033Produto { get; set; } = 0;
        public decimal gg008PrecoCusto { get; set; } = 0;
        public string Gg033DescricaoProduto { get; set; } = string.Empty;
        public decimal EAN_Tributavel { get; set; } = 0;
        public decimal QtdInventario { get; set; } = 0;
        public decimal PrecoCusto { get; set; } = 0;
        public decimal PrecoVendaVarejo { get; set; } = 0;
        public decimal PrecoCustoReal { get; set; } = 0;
        public decimal TotalCusto { get; set; } = 0;
        public string RazaoSocial { get; set; } = string.Empty;
        public decimal TotalCustoReal { get; set; } = 0;
        public string NomePessoalEmpresarial { get; set; } = string.Empty;
        public string Codigodopais { get; set; } = string.Empty;
        public string CNPJCPF { get; set; } = string.Empty;
        public string InscricaoEstadual { get; set; } = string.Empty;
        public string Codigodomunicipio { get; set; } = string.Empty;
        public string SUFRAMA { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Numerodoimovel { get; set; } = string.Empty;
        public string Dadoscomplementaresdoendereco { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Unidade { get; set; } = string.Empty;
        public string UnDescricao { get; set; } = string.Empty;
        public string TpItem { get; set; } = string.Empty;
        public decimal NCM { get; set; } = 0;
        public string EXNCM { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public decimal AliqICMS { get; set; } = 0;
        public decimal Gg520Saldo { get; set; } = 0;
        public decimal GG021_Perc_ICMS { get; set; } = 0;
        public decimal GG520_vBCSTRet { get; set; } = 0;
        public string IndPropriedade { get; set; } = string.Empty;
    }

    public enum ExtensaoArquivo
    {
        TXT,
        XLSX
    }

    public class ExportarArquivoTemplate
    {
        protected virtual async Task<(List<DtoArquivosFiscaisExcelGetInventario> produtos, string? protocolo)> GetInventario(
            string InGG032ID, int InTenantID, AppDbContext _appDbContext)
        {
            var produtosDoInventario = await(
                from gg033 in _appDbContext.OsusrE9aCsicpGg033s.AsNoTracking()
                join bb001 in _appDbContext.E9ACSICP_BB001s on gg033.Gg033Filialid equals bb001.Id into bb001Join
                from bb001 in bb001Join.DefaultIfEmpty()
                join gg032 in _appDbContext.OsusrE9aCsicpGg032s on gg033.Gg032Id equals gg032.Id into gg032Join
                from gg032 in gg032Join.DefaultIfEmpty()

                join gg520 in _appDbContext.OsusrE9aCsicpGg520s on gg033.Gg033Saldoid equals gg520.Id into gg520Join
                from gg520 in gg520Join.DefaultIfEmpty()
                join gg008kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes on gg520.Gg520KardexId equals gg008kdx.Gg008Kardexid into gg008kdxJoin
                from gg008kdx in gg008kdxJoin.DefaultIfEmpty()
                join gg008 in _appDbContext.OsusrE9aCsicpGg008s on gg008kdx.Gg008Produtoid equals gg008.Id into gg008Join
                from gg008 in gg008Join.DefaultIfEmpty()
                join gg005 in _appDbContext.OsusrE9aCsicpGg005s on gg033.Gg033NnArtigoId equals gg005.Id into gg005Join
                from gg005 in gg005Join.DefaultIfEmpty()
                join gg006 in _appDbContext.OsusrE9aCsicpGg006s on gg033.Gg033NnMarcaId equals gg006.Id into gg006Join
                from gg006 in gg006Join.DefaultIfEmpty()
                join gg021 in _appDbContext.OsusrE9aCsicpGg021s on gg008.Gg008Ncmid equals gg021.Id into gg021Join
                from gg021 in gg021Join.DefaultIfEmpty()
                join spedItem in _appDbContext.OsusrNnxSpedInGenItems on gg021.Gg021GeneroId equals spedItem.Id into spedItemJoin
                from spedItem in spedItemJoin.DefaultIfEmpty()
                join statica in _appDbContext.E9ACSICP_Statica on bb001.Bb001Ramoempresa equals statica.Id into staticaJoin
                from statica in staticaJoin.DefaultIfEmpty()
                join gg007 in _appDbContext.OsusrE9aCsicpGg007s on gg008kdx.Gg008Unvendavarejoid equals gg007.Id into gg007Join
                from gg007 in gg007Join.DefaultIfEmpty()


                where gg033.Gg032Id == InGG032ID && gg033.TenantId == InTenantID
                orderby gg033.Gg033Codbarrasalfa, gg033.Gg033Produto
                select new DtoArquivosFiscaisExcelGetInventario
                {
                    Bb001Razaosocial = bb001.Bb001Razaosocial ?? "",
                    Gg032Datamovimento = gg032.Gg032Datamovimento,
                    Gg033Produto = gg033.Gg033Produto ?? 0,
                    Gg033DescricaoProduto = gg005.Gg005Descartigo ?? "" + gg006.Gg006Descmarca ?? "" + gg008.Gg008Referencia ?? "",
                    EAN_Tributavel = gg008kdx.Gg008EanTributavel ?? 0,
                    QtdInventario = gg033.Gg033Qtdinventario ?? 0,
                    PrecoCusto = gg033.Gg033Precocusto ?? 0,
                    PrecoCustoReal = gg033.Gg033Precocustoreal ?? 0,
                    TotalCusto = (gg033.Gg033Precocusto ?? 0) * (gg033.Gg033Qtdinventario ?? 0),
                    RazaoSocial = bb001.Bb001Razaosocial ?? "",
                    TotalCustoReal = (gg033.Gg033Precocustoreal ?? 0) * (gg033.Gg033Qtdinventario ?? 0),
                    NomePessoalEmpresarial = "",
                    Codigodopais ="",
                    CNPJCPF =  "",
                    InscricaoEstadual = "",
                    Codigodomunicipio = "",
                    SUFRAMA = "",
                    Logradouro = "",
                    Numerodoimovel = "",
                    Dadoscomplementaresdoendereco = "",
                    Bairro = "",
                    Unidade = gg007.Gg007Unidade ?? "",
                    UnDescricao = gg007.Gg007Descricao ?? "",
                    TpItem = "04", 
                    NCM = gg021.Gg021Ncm ?? 0,
                    EXNCM = gg021.Gg021ExNbm ?? "",
                    GG021_Perc_ICMS = gg021.Gg021PercIcms ?? 0,
                    Genero = spedItem.Codigo ?? "",
                    AliqICMS = gg008kdx.Gg008AliquotaIcms ?? 0,
                    IndPropriedade = "0" ,
                    Gg032Protocolo = gg032.Gg032Protocolnumber,
                    gg008PrecoCusto = gg008kdx.Gg008PrecoCusto ?? 0,
                    Gg520Saldo = gg520.Gg520Saldo,
                    PrecoVendaVarejo = gg008kdx.Gg008PrcVendavarejo ?? 0,
                    GG520_vBCSTRet = gg520.Gg520Vbcstret ?? 0,
                }).ToListAsync();

            if (produtosDoInventario.Count == 0 || !produtosDoInventario.Any()) 
                throw new KeyNotFoundException("Lista de produtos do inventário vazia");

            return (produtosDoInventario, produtosDoInventario[0].Gg032Protocolo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="protocolo">protocolo da gg032</param>
        /// <param name="nomeArquivo">passar sem a extensao</param>
        /// <param name="extensao">usar sem o ponto, apenas a extensao. Ex. XML</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        protected virtual string GetFilename(string protocolo,string nomeArquivo, ExtensaoArquivo extensao)
        {
            if (string.IsNullOrWhiteSpace(nomeArquivo))
                throw new ArgumentException("Nome do arquivo não pode ser nulo ou vazio.", nameof(nomeArquivo));


            string extensaoArquivo = extensao.ToString().ToLowerInvariant();
            if (nomeArquivo.Contains(extensaoArquivo))
                nomeArquivo = nomeArquivo.Replace(extensaoArquivo, string.Empty);


            return "Prt." + protocolo + "." + nomeArquivo + "." + extensaoArquivo;
        }

        protected virtual byte[] DownloadFileWithMemoryStream(XLWorkbook workbook, string filename)
        {
            using var stream = new MemoryStream();
            workbook.SaveAs(stream);
            stream.Position = 0;
            return stream.ToArray();
        }


        public virtual string FormatarRegistroH005(DtoArquivosFiscaisExcelGetInventario produto)
        {
            // Baseado nas propriedades visíveis no workflow
            var dtInv = produto.Gg032Datamovimento?.ToString("ddMMyyyy") ?? "";
            var vlInv = FormatarDecimal(produto.TotalCusto, 2);
            var motInv = "02"; // Motivo do inventário

            return $"|H005|{dtInv}|{vlInv}|{motInv}|";
        }

        public virtual string FormatarRegistroH010(DtoArquivosFiscaisExcelGetInventario produto)
        {
            // Baseado nas propriedades do workflow
            var codItem = produto.Gg033Produto.ToString() ?? "";
            var unid = produto.Unidade ?? "";
            var qtd = FormatarDecimal(produto.QtdInventario, 3);
            var vlUnit = FormatarDecimal(produto.PrecoCusto, 2);
            var vlItem = FormatarDecimal(produto.PrecoCusto * produto.QtdInventario, 2);
            var indProp = "0"; // Indicador de propriedade
            var codPart = ""; // Código do participante
            var txtCompl = produto.Gg033DescricaoProduto; // Texto complementar
            var codCta = "13100400ACLASSIF"; // Código da conta contábil
            var vlItemIR = "0"; // Código da conta contábil

            return $"|H010|{codItem}|{unid}|{qtd}|{vlUnit}|{vlItem}|{indProp}|{codPart}|{txtCompl}|{codCta}|{vlItemIR}|";
        }

        public virtual string FormatarRegistroH020(DtoArquivosFiscaisExcelGetInventario produto)
        {
            // Definir WorkpICMS baseado na lógica condicional
            var WorkpICMS = produto.AliqICMS > 0 ? produto.AliqICMS : produto.AliqICMS;

            // Baseado nas propriedades do workflow
            var cstIcms = "060"; // CST do ICMS
            var bcIcms = FormatarDecimal(produto.PrecoVendaVarejo * produto.Gg520Saldo, 2);
            var vlIcms = FormatarDecimal(((produto.PrecoVendaVarejo * produto.Gg520Saldo) * WorkpICMS) / 100, 2);

            return $"|H020|{cstIcms}|{bcIcms}|{vlIcms}|";
        }

        public virtual string FormatarDecimal(decimal? valor, int casasDecimais)
        {
            if (!valor.HasValue) return "0".PadLeft(casasDecimais + 1, '0');

            var valorFormatado = valor.Value.ToString($"F{casasDecimais}").Replace(",", "").Replace(".", "");
            return valorFormatado;
        }

        public virtual int ContarLinhasBloco(List<DtoArquivosFiscaisExcelGetInventario> produtos)
        {
            // Conta H005 (1) + H010 (1 por produto) + H020 (1 por produto) + H990 (1)
            return 1 + (produtos.Count * 2) + 1;
        }
    }
}
