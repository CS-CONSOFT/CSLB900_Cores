using CSCore.Ifs.AnaliseDeCredito.NovaPasta;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Xunit;

namespace CSCore.Ifs.AnaliseCreditoTest
{
    public class QueryAnaliseTests
    {
        private readonly string _connectionString;

        public QueryAnaliseTests()
        {
            // Lê a string de conexão do segredo (User Secrets ou variável de ambiente)
            var config = new ConfigurationBuilder()
                .AddUserSecrets<QueryAnaliseTests>()
                .Build();

            _connectionString = config.GetConnectionString("DefaultConnection")!;
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("String de conexão não encontrada nos segredos.");
        }

        [Fact]
        public async Task GetAnaliseCreditoAsync_DeveRetornarResultadoValido()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(_connectionString)
                .LogTo(Console.WriteLine, LogLevel.Information) // Log para depuração
                .Options;

            await using var context = new AppDbContext(options);
            var service = new QueryAnaliseDeCredito(context);

            var parametros = new AnaliseCreditoParametros
            {
                Renda = 5000m,
                WC = 0.2m,
                WP = 0.25m,
                WE = 0.15m,
                WR = 0.4m,
                F = 0.5m,
                IDHR = 0.556m,
                ScoreClear = 656m,
                WS = 0.6m,
                WN = 0.4m
            };

            // Act
            var resultado = await service.GetAnaliseCreditoAsync(135, "9a7ba9e7-b84f-43ba-b7e5-bebc67765556", parametros);


            var json = JsonSerializer.Create();
            json.Serialize(Console.Out, resultado);

            // Assert
            Assert.NotNull(resultado);
            Assert.Equal("9a7ba9e7-b84f-43ba-b7e5-bebc67765556", resultado!.ContaId);
            Assert.True(resultado.Renda > 0);
            Assert.True(resultado.MediaCredito >= 0);
        }
    }
}
