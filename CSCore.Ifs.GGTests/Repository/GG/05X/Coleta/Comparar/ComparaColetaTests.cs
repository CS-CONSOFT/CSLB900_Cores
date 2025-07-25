using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.GG._05X.Coleta.Comparar;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Xunit;

namespace CSCore.Ifs.GG.Repository.GG._05X.Tests
{

    public class ComparaColetaTests
    {
        private readonly AppDbContext _appDbContext;
        private readonly IComparaColeta _comparaColeta;
        public ComparaColetaTests()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Test.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(connectionString)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .Options;

            _appDbContext = new AppDbContext(options);
            _comparaColeta = new ComparaColetaImpl(_appDbContext);

        }

        ParametrosCompararColeta parametrosCompararColeta = new()
        {
            TenantId = 135,
            NumeroProtocoloColeta01 = "20250050000000631",
            NumeroProtocoloColeta02 = "20250050000000632",
            IdCC081_CD_Criar = 1,
            IdGG054Sta_Aberto = 1
        };




        [Fact]
        public async Task Deve_Retornar_ProdutosDaColeta01QueNaoEstaoNaColeta02()
        {
            (List<CSICP_GG055> produtosSoNaColeta01,
                List<CSICP_GG055> _,
                List<CSICP_GG055> _,
                List<CSICP_GG055> _) = await _comparaColeta.CompararColeta(parametrosCompararColeta);
            produtosSoNaColeta01.Should().HaveCount(1);
        }


        [Fact]
        public async Task Deve_ProdutosDaColeta02NaoEstaoNaColeta01()
        {
            (List<CSICP_GG055> _,
               List<CSICP_GG055> produtosSoNaColeta02,
               List<CSICP_GG055> _,
               List<CSICP_GG055> _) = await _comparaColeta.CompararColeta(parametrosCompararColeta);
            produtosSoNaColeta02.Should().HaveCount(1);
        }

        [Fact]
        public async Task Deve_RetornarProdutosComQuantidadeDivergente_Quando_CompararColetasComProtocoloDiferentes()
        {

            (List<CSICP_GG055> _,
                List<CSICP_GG055> _,
                List<CSICP_GG055> produtosComQuantidadeDiferente,
                List<CSICP_GG055> _) = await _comparaColeta.CompararColeta(parametrosCompararColeta);
            produtosComQuantidadeDiferente.Should().HaveCount(1);
        }

        [Fact]
        public async Task Deve_RetornarTodosOsProdutosRelacionadosAsColetas_Quando_CompararColetas()
        {

            (List<CSICP_GG055> _,
                 List<CSICP_GG055> _,
                 List<CSICP_GG055> _,
                 List<CSICP_GG055> todosOsProdutos) = await _comparaColeta.CompararColeta(parametrosCompararColeta);
            todosOsProdutos.Should().HaveCount(4);
        }


    }
}
