using Microsoft.AspNetCore.Http;

namespace CSCore.Ifs.Compartilhado.Utilidade.Excel
{
    public interface IExcel
    {
        Task<string> CS001_Import_Arquivo_xls(
            int in_tenant, string in_estabID, long in_tt030_id, IFormFile arquivoExcel);
    }
}
