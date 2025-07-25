using CSCore.Ifs.AnaliseDeCredito;
using CSCore.Ifs.AnaliseDeCredito.NovaPasta;
using CSCore.Ifs.Compartilhado;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace CSCore.Ifs.AnaliseCreditoTest
{
    public class CreditoSemScoreTest
    {
        private readonly string _connectionString;

        public CreditoSemScoreTest()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<CreditoSemScoreTest>()
                .Build();
            var connectionString = config.GetConnectionString("DefaultConnection");
            _connectionString = connectionString ?? "";
        }

        [Fact]
        public async Task TestarAnaliseDeCreditoSemScore()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(_connectionString)
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                .Options;
            var context = new AppDbContext(options);

            var tokenGenericoRepo = new TokenGenericoRepositoryImpl(context);
            var scoreClear = new ScoreClearSale(tokenGenericoRepo);
            var queryAnalise = new QueryAnaliseDeCredito(context);
            var analise = new CreditoSemScore(context, scoreClear, queryAnalise);


            DtoOutRetorno dtoOutRetorno =
                await analise.ExecutarAnaliseCredito(true, 135, "zz20210000000000000414892");

            Console.WriteLine("Resultado da Análise de Crédito");
            Console.WriteLine("===============================");
            Console.WriteLine(dtoOutRetorno);
            Console.WriteLine("Resultado da Análise de Crédito");
            Console.WriteLine("===============================");

            Assert.NotNull(dtoOutRetorno);
        }
    }
}
