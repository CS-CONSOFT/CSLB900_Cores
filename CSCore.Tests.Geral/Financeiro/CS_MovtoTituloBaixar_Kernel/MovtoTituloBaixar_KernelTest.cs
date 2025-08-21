using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_MovtoTituloBaixar_Kernel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;

namespace CSCore.Tests.Geral.Financeiro.CS_MovtoTituloBaixar_Kernel
{
    public class MovtoTituloBaixar_KernelTest : IDisposable
    {
        private readonly AppDbContext _context;
        private readonly IMovtoTituloBaixar_Kernel _service;
        private readonly string _connectionString;

        public MovtoTituloBaixar_KernelTest()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<MovtoTituloBaixar_KernelTest>()
                .Build();
            var connectionString = config.GetConnectionString("DefaultConnection");
            _connectionString = connectionString;

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new AppDbContext(options);
            _service = new MovtoTituloBaixar_Kernel(_context);
        }

        [Fact]
        public async Task Executar_MovimentoNaoEncontrado_DeveThrowKeyNotFoundException()
        {
            // Arrange
            var parametro = CriarParametroTeste();

            // Act & Assert
            var exception = await Assert.ThrowsAsync<KeyNotFoundException>(() => _service.Executar(parametro));
            Assert.Contains("Movimento não encontrado para Baixa", exception.Message);
        }

        [Fact]
        public async Task Executar_MovimentoJaBaixado_DeveThrowInvalidOperationException()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            await CriarMovimentoTeste(parametro.InFF103ID, parametro.InTenantID, jaBaixado: true);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _service.Executar(parametro));
            Assert.Contains("Movimento já baixado", exception.Message);
        }

        [Fact]
        public async Task Executar_MovimentoEstornado_DeveThrowInvalidOperationException()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            await CriarMovimentoTeste(parametro.InFF103ID, parametro.InTenantID, estornado: true);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _service.Executar(parametro));
            Assert.Contains("Movimento já estornado", exception.Message);
        }

        [Fact]
        public async Task Executar_MovimentoCancelado_DeveThrowInvalidOperationException()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            await CriarMovimentoTeste(parametro.InFF103ID, parametro.InTenantID, cancelado: true);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _service.Executar(parametro));
            Assert.Contains("Movimento já cancelado", exception.Message);
        }

        [Fact]
        public async Task Executar_ValorPagoSuperior_DeveThrowInvalidOperationException()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            await CriarMovimentoTeste(parametro.InFF103ID, parametro.InTenantID, valorPago: 1000, valorTitulo: 100);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _service.Executar(parametro));
            Assert.Contains("Valor pago é superior ao valor calculado", exception.Message);
        }

        [Fact]
        public async Task Executar_MovimentoValido_DeveExecutarComSucesso()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            await CriarMovimentoTeste(parametro.InFF103ID, parametro.InTenantID);

            // Act
            var resultado = await _service.Executar(parametro);

            // Assert
            Assert.True(resultado);
            
            var movimento = await _context.OsusrE9aCsicpFf103s
                .FirstAsync(x => x.Id == parametro.InFF103ID && x.TenantId == parametro.InTenantID);
            
            Assert.True(movimento.Ff103Baixado);
            Assert.Equal(1, movimento.Ff103Flagregistro);
        }

        private PrmMovtoTituloBaixarKernel CriarParametroTeste()
        {
            return new PrmMovtoTituloBaixarKernel
            {
                InTenantID = 135,
                InFF103ID = Guid.NewGuid().ToString(),
                InSTIDff102SitLiquidado = 1,
                InSTIDff102SitCancelado = 2,
                InSTIDff102SitRenegociado = 3,
                InSTIDff102SitProvisao = 4
            };
        }

        private async Task CriarMovimentoTeste(string id, int tenantId, bool jaBaixado = false, 
            bool estornado = false, bool cancelado = false, decimal valorPago = 100, decimal valorTitulo = 500)
        {
            var ff102 = new CSICP_FF102
            {
                Id = Guid.NewGuid().ToString(),
                TenantId = tenantId,
                Ff102VlLiqTitulo = valorTitulo,
                Ff102Situacaoid = 0 // Changed from null to 0
            };

            var ff103 = new CSICP_FF103
            {
                Id = id,
                TenantId = tenantId,
                Ff102Id = ff102.Id,
                Ff103Baixado = jaBaixado,
                Ff103Estornado = estornado,
                Ff103Cancelado = cancelado,
                Ff103ValorPago = valorPago,
                Ff103ValorMulta = 10,
                Ff103ValorTarifas = 5,
                Ff103ValorJuros = 15,
                Ff103ValorDesconto = 20,
                Ff103Flagregistro = 0
            };

            _context.OsusrE9aCsicpFf102s.Add(ff102);
            _context.OsusrE9aCsicpFf103s.Add(ff103);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}