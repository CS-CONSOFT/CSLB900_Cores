using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais
{
    public class ExportarArquivosFiscaisRepositoryImpl : IExportarArquivosFiscaisRepository
    {
        private readonly AppDbContext _appDbContext;

        public ExportarArquivosFiscaisRepositoryImpl(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<(byte[], string filename)> Exportar(CSEnumTipoExportacaoArquivo tipoExportacao, string InGG032_ID, int InTenantID)
        {
            IExportarArquivo instanciaExportar = ExportarArquivoFactory.ExportarArquivo(tipoExportacao, _appDbContext);
            return await instanciaExportar.Exportar(InGG032_ID, InTenantID);
        }
    }
}
