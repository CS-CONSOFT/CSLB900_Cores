using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.FF1XX;
using CSCore.Ifs.FF.Repository.VisoesGeraisFinanceiro;
using GG104Materiais.C82Application.Service;
using GG104Materiais.C82Application.Service.VisoesGeraisFinanceiroService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace CSLB900.MSToolsTestes
{
    public class FluxoDeCaixaServiceTests
    {
        private readonly string _connectionString;

        public FluxoDeCaixaServiceTests()
        {
            var config = new ConfigurationBuilder()
              .AddUserSecrets<FluxoDeCaixaServiceTests>()
              .Build();
            var connectionString = config.GetConnectionString("DefaultConnection");
            _connectionString = connectionString;
        }

        [Fact]
        public async Task FluxoDeCaixaService_DeveFuncionar()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                 .UseSqlServer(_connectionString)
                 .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                 .Options;
            var context = new AppDbContext(options);

            var repository = new FluxoDeCaixa(context);
            var service = new FluxoDeCaixaService(repository);

            // Act - Teste do fluxo diário
            var resultDiario = await service.GetFluxoDeCaixaDiarioAsync(135, new DateTime(2025, 1, 1), new DateTime(2025, 12, 31), 10000);
            var jsonDiario = JsonSerializer.Serialize(resultDiario, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine("=== FLUXO DIÁRIO ===");
            Console.WriteLine(jsonDiario);

            // Act - Teste do fluxo mensal
            var resultMensal = await service.GetFluxoDeCaixaMensalAsync(135, new DateTime(2025, 1, 1), new DateTime(2025, 12, 31), 10000);
            var jsonMensal = JsonSerializer.Serialize(resultMensal, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine("=== FLUXO MENSAL ===");
            Console.WriteLine(jsonMensal);

            // Assert
            Assert.NotNull(resultDiario);
            Assert.NotNull(resultMensal);
        }
    }
}