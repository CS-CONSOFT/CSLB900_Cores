using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.FF1XX;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace CSLB900.MSToolsTestes
{
    public class GerencialTitulosAReceberTests 
    {
        private readonly string _connectionString;
        

        public GerencialTitulosAReceberTests()
        {
            var config = new ConfigurationBuilder()
               .AddUserSecrets<FluxoDeCaixaTests>()
               .Build();
            var connectionString = config.GetConnectionString("DefaultConnection");
            _connectionString = connectionString;
        }

        [Fact]
        public async Task GetAnaliseIdadeContasReceberAsync_DeveRetornarAnaliseCorreta()
        {
            var _repository = new GerencialTitulosAReceber(new AppDbContext(
                new DbContextOptionsBuilder<AppDbContext>()
                    .UseSqlServer(_connectionString)
                    .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                    .Options));

            string[] estabs = { "a92b9e9c-53c1-4383-a72b-339fe4cc3c74", "08878f25-412d-4914-934f-f785d61b8b77" };
            // Act
            var resultado = await _repository.GetAnaliseIdadeContasReceberAsync(135, agruparPorEstabelecimento: true, filtroEstabelecimentos: estabs.ToList());
            var json = JsonSerializer.Serialize(resultado, new JsonSerializerOptions { WriteIndented = true });
            // Assert
            Assert.NotNull(resultado);
            Assert.Equal(4, resultado.Count);

            // Verifica faixa 0-30 dias
            var faixa0a30 = resultado.FirstOrDefault(x => x.FaixaIdade == "000 - 030 Dias");
            Assert.NotNull(faixa0a30);
            Assert.Equal(2, faixa0a30.QuantidadeTitulos);
            Assert.Equal(2500m, faixa0a30.TotalEmAberto); // 1000 + 1500

            // Verifica faixa 31-60 dias
            var faixa31a60 = resultado.FirstOrDefault(x => x.FaixaIdade == "0031 - 060 Dias");
            Assert.NotNull(faixa31a60);
            Assert.Equal(1, faixa31a60.QuantidadeTitulos);
            Assert.Equal(2000m, faixa31a60.TotalEmAberto);

            // Verifica faixa 61-90 dias
            var faixa61a90 = resultado.FirstOrDefault(x => x.FaixaIdade == "061 - 090 Dias");
            Assert.NotNull(faixa61a90);
            Assert.Equal(1, faixa61a90.QuantidadeTitulos);
            Assert.Equal(800m, faixa61a90.TotalEmAberto);

            // Verifica faixa maior que 90 dias
            var faixaMaior90 = resultado.FirstOrDefault(x => x.FaixaIdade == "Maior que 90 Dias");
            Assert.NotNull(faixaMaior90);
            Assert.Equal(2, faixaMaior90.QuantidadeTitulos);
            Assert.Equal(4200m, faixaMaior90.TotalEmAberto); // 3000 + 1200
        }
    }
}