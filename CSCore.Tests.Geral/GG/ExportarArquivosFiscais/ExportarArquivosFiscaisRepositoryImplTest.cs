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
        public async Task ExportarParaExcel_DevecriarArquivoComSucesso()
        {
            // Act
            await 
                _repository
                .ExportarParaExcel(TipoExportacao.XLS, InGG032_ID: "zzz0198f71244ad7a589036e300632ab183", InTenantID: 135);
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