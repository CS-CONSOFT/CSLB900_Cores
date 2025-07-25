using CSCore.Domain.CS_Models.CSICP_TT;
using CSCore.Ifs.Compartilhado.Utilidade.Excel.ValidaInsertTT031Cesta;
using CSCore.Ifs.CS_Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace CSCore.Ifs.Compartilhado.Utilidade.Excel
{
    public class ExcelImpl(AppDbContext appDbContext, IValidaInsertTT031 validaInsertTT031) : IExcel
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly IValidaInsertTT031 _validaInsertTT031 = validaInsertTT031;


        //FormData
        public async Task<string> CS001_Import_Arquivo_xls(
            int in_tenant, string in_estabID, long in_tt030_id, IFormFile arquivoExcel)
        {
            var contadorLinhas = 0;
            using (var stream = arquivoExcel.OpenReadStream())
            {
                IWorkbook workbook;
                if (Path.GetExtension(arquivoExcel.FileName).ToLower() == ".xls")
                    workbook = new HSSFWorkbook(stream);
                else
                    workbook = new XSSFWorkbook(stream);
                var sheet = workbook.GetSheetAt(0);

                for (int i = 1; i <= sheet.LastRowNum; i++)
                {
                    contadorLinhas += 1;
                    var row = sheet.GetRow(i);
                    if (row is null) break;
                    if (row.Cells.Count == 0) break;

                    string codgProduto = row.GetCell(0)?.ToString() ?? string.Empty;
                    string qtdProduto = row.GetCell(1)?.ToString() ?? "0";
                    string valorProduto = row.GetCell(2)?.ToString() ?? "0";
                    string descProduto = row.GetCell(3)?.ToString() ?? "0";

                    
                    CSICP_TT031 tt031Validado = await _validaInsertTT031.Validar(
                        in_tenant,
                        in_tt030_id,
                        codgProduto,
                        int.Parse(qtdProduto),
                        int.Parse(valorProduto), 
                        int.Parse(descProduto),
                        in_estabID);


                    if (tt031Validado.Tt031Id is not null)
                    {
                        tt031Validado.CsQtd = int.Parse(qtdProduto);
                        _appDbContext.Update(tt031Validado);
                        continue;
                    }

                    _appDbContext.Add(tt031Validado);
                }
                await _appDbContext.SaveChangesAsync();
            }
            return $"Foram inseridas {contadorLinhas} na cesta multiuso!";
        }

       
    }
}
