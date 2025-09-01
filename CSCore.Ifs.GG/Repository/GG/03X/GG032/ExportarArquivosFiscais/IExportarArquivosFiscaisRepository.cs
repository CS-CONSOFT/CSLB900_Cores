using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais
{
    public interface IExportarArquivosFiscaisRepository
    {
        Task ExportarParaExcel(TipoExportacao tipoExportacao, string InGG032_ID, int InTenantID);
    }
}
