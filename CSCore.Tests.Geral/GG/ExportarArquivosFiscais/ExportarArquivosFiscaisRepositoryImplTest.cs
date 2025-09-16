using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais;
using CSCore.Ifs.GG.Repository.GG._03X.GG032.ExportarArquivosFiscais.Strategy;
using CSCore.Tests.Geral.Financeiro.CS_MovtoTituloEstornar;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;

namespace CSCore.Tests.Geral.GG.ExportarArquivosFiscais
{
    public class ExportarArquivosFiscaisRepositoryImplTest : IDisposable
    {
        private readonly string _testDirectory;
        private readonly ExportarArquivosFiscaisRepositoryImpl _repository;
        private readonly AppDbContext _context;
        public ExportarArquivosFiscaisRepositoryImplTest()
        {
            var config = new ConfigurationBuilder()
              .AddUserSecrets<ExportarArquivosFiscaisRepositoryImplTest>()
              .Build();
            var connectionString = config.GetConnectionString("DefaultConnection");
       

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            _context = new AppDbContext(options);
            // Create a temporary directory for testing
            _testDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_testDirectory);
            
            _repository = new ExportarArquivosFiscaisRepositoryImpl(_context);
        }

        [Fact]
        public async Task ExportarParaExcelBlocoK_DevecriarArquivoComSucesso()
        {
            // Act
            await 
                _repository
                .Exportar(CSEnumTipoExportacaoArquivo.XLS_BLC_K, InGG032_ID: "zzz0198f71244ad7a589036e300632ab183", InTenantID: 135);
        }

        [Fact]
        public async Task ExportarParaExcelBloco0200_DevecriarArquivoComSucesso()
        {
            // Act
            await
                _repository
                .Exportar(CSEnumTipoExportacaoArquivo.TXT_BLC_0200, InGG032_ID: "zzz0198f71244ad7a589036e300632ab183", InTenantID: 135);
        }

        [Fact]
        public async Task ExportarParaExcelSISPRO_DevecriarArquivoComSucesso()
        {
            // Act
            await
                _repository
                .Exportar(CSEnumTipoExportacaoArquivo.XLS_SISPRO, InGG032_ID: "zzz0198f71244ad7a589036e300632ab183", InTenantID: 135);
        }


        [Fact]
        public async Task ExportarParaExcelBLOCOH2_DevecriarArquivoComSucesso()
        {
            // Act
            await
                _repository
                .Exportar(CSEnumTipoExportacaoArquivo.TXT_BLOCO_H2, InGG032_ID: "zzz0198f71244ad7a589036e300632ab183", InTenantID: 135);
        }

        [Fact]
        public async Task ExportarParaExcelBLOCOH_DevecriarArquivoComSucesso()
        {
            // Act
            await
                _repository
                .Exportar(CSEnumTipoExportacaoArquivo.TXT_BLOCO_H, InGG032_ID: "zzz0198f71244ad7a589036e300632ab183", InTenantID: 135);
        }





        public void Dispose()
        {
            // Clean up test directory
            if (Directory.Exists(_testDirectory))
            {
                Directory.Delete(_testDirectory, true);
            }
        }
    }
}