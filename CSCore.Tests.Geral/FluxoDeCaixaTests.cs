using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.FF1XX;
using CSCore.Ifs.FF.Repository.VisoesGeraisFinanceiro;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace CSLB900.MSToolsTestes
{
    public class FluxoDeCaixaTests
    {
        private readonly string _connectionString;

        public FluxoDeCaixaTests()
        {
            var config = new ConfigurationBuilder()
              .AddUserSecrets<FluxoDeCaixaTests>()
              .Build();
            var connectionString = config.GetConnectionString("DefaultConnection");
            _connectionString = connectionString;
        }


        [Fact]
        public async Task GetFluxoDeCaixaDiarioAsync_RetornaFluxoCorreto()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                 .UseSqlServer(_connectionString)
                 .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                 .Options;
            var context = new AppDbContext(options);

            var repo = new FluxoDeCaixaRepository(context);

            // Act
            var result = await repo.GetFluxoDeCaixaDiarioAsync(135, new DateTime(2025, 1, 1), new DateTime(2025, 12, 31), 10000);
            // Serialização para JSON
            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true });
            Console.Write(json);

            var result2 = await repo.GetFluxoDeCaixaMensalAsync(135, new DateTime(2025, 1, 1), new DateTime(2025, 12, 31), 10000);
            // Serialização para JSON
            var json2 = JsonSerializer.Serialize(result2, new JsonSerializerOptions { WriteIndented = true });
            Console.Write(json2);


            // Assert
            Assert.Equal(2, result.Count);

            // Dia 01/08/2025: 100 (receber) - 50 (pagar) = 50
            Assert.Equal(new DateTime(2025, 1, 1), result[0].Data);
            Assert.Equal(50, result[0].TotalDia);
            Assert.Equal(50, result[0].SaldoAcumulado);

            // Dia 02/08/2025: 200 (receber)
            Assert.Equal(new DateTime(2025, 12, 31), result[1].Data);
            Assert.Equal(200, result[1].TotalDia);
            Assert.Equal(250, result[1].SaldoAcumulado);
        }
    }
}
