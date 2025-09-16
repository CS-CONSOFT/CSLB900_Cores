using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.FF1XX.FF126;
using CSCore.Tests.Geral.Financeiro.RenegociacaoCalcTitulo.CSCore.Ifs.FF.Tests.Repository.Processos.CS_Renegociacao_Calc_Titulos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Xunit;

namespace CSCore.Tests.Geral.Financeiro.FF126
{
    public class AtualizaFF126RepositoryTest
    {
        private AppDbContext CreateDbContext()
        {
            var config = new ConfigurationBuilder()
                 .AddUserSecrets<Renegociacao_Calc_TitulosTests>()
                 .Build();
            var connectionString = config.GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(connectionString)
            .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
            .Options;

            return new AppDbContext(options);
        }

        [Fact(DisplayName = "Atualiza_FF126 executa sem exceção (funcional)")]
        public async Task Atualiza_FF126_Funcional()
        {
            var dbContext = CreateDbContext();
            var repo = new AtualizaFF126Repository(dbContext);
            var prm = PrmAtualizaFF126RepositoryFactory.Create();
            var responde = await repo.Atualiza_FF126(prm);
            Assert.True(responde);
        }
    }
}
