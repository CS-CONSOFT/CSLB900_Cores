using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_TituloCalculoBaixa;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Tests.Geral.Financeiro.CS_TituloCalculoBaixa
{
    public class TituloCalculoBaixaTest : IDisposable
    {
        private readonly AppDbContext _context;
        private readonly ITituloCalculoBaixa _service;

        public TituloCalculoBaixaTest()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new AppDbContext(options);
            _service = new TituloCalculoBaixa(_context);
        }

        [Fact]
        public async Task Executar_ParametroNulo_DeveThrowArgumentNullException()
        {
            // Act & Assert
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => _service.Executar(null));
            Assert.Contains("Parâmetro de entrada não pode ser nulo", exception.Message);
        }

        [Fact]
        public async Task Executar_TituloNaoEncontrado_DeveThrowKeyNotFoundException()
        {
            // Arrange
            var parametro = CriarParametroTeste();

            // Act & Assert
            var exception = await Assert.ThrowsAsync<KeyNotFoundException>(() => _service.Executar(parametro));
            Assert.Contains("Titulo não encontrado", exception.Message);
        }

        [Fact]
        public async Task Executar_ComTituloSemMovimentos_DeveAtualizarApenasTitulo()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            var ff102 = await CriarTituloTeste(parametro.InFF102Id, parametro.InTenantID);

            // Act
            var resultado = await _service.Executar(parametro);

            // Assert
            Assert.True(resultado);
            
            var tituloAtualizado = await _context.OsusrE9aCsicpFf102s
                .FirstAsync(x => x.Id == parametro.InFF102Id);
            
            // Verifica se o valor líquido foi recalculado
            Assert.Equal(490, tituloAtualizado.Ff102VlLiqTitulo); // 500 - 10 (desconto)
        }

        [Fact]
        public async Task Executar_ComMovimentos_DeveAtualizarTituloComMovimentos()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            var ff102 = await CriarTituloTeste(parametro.InFF102Id, parametro.InTenantID);
            await CriarMovimentoTeste(ff102.Id, parametro.InTenantID, valorPago: 200, valorJuros: 50);

            // Act
            var resultado = await _service.Executar(parametro);

            // Assert
            Assert.True(resultado);
            
            var tituloAtualizado = await _context.OsusrE9aCsicpFf102s
                .FirstAsync(x => x.Id == parametro.InFF102Id);
            
            Assert.Equal(200, tituloAtualizado.Ff102TotalPagamentos);
            Assert.Equal(50, tituloAtualizado.Ff102TotalJuros);
            Assert.Equal(1, tituloAtualizado.Ff102NoPagamentos);
        }

        [Fact]
        public async Task Executar_TituloLiquidado_DeveAtualizarSituacao()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            var ff102 = await CriarTituloTeste(parametro.InFF102Id, parametro.InTenantID, valorTitulo: 100);
            await CriarMovimentoTeste(ff102.Id, parametro.InTenantID, valorPago: 100);

            // Act
            var resultado = await _service.Executar(parametro);

            // Assert
            Assert.True(resultado);
            
            var tituloAtualizado = await _context.OsusrE9aCsicpFf102s
                .FirstAsync(x => x.Id == parametro.InFF102Id);
            
            Assert.Equal(0, tituloAtualizado.Ff102VlLiqTitulo);
            Assert.Equal(parametro.InSTIDFF102Liquidado, tituloAtualizado.Ff102Situacaoid);
        }

        [Fact]
        public async Task Executar_TituloParcialmenteBaixado_DeveAtualizarSituacao()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            var ff102 = await CriarTituloTeste(parametro.InFF102Id, parametro.InTenantID, valorTitulo: 500);
            await CriarMovimentoTeste(ff102.Id, parametro.InTenantID, valorPago: 200);

            // Act
            var resultado = await _service.Executar(parametro);

            // Assert
            Assert.True(resultado);
            
            var tituloAtualizado = await _context.OsusrE9aCsicpFf102s
                .FirstAsync(x => x.Id == parametro.InFF102Id);
            
            Assert.True(tituloAtualizado.Ff102VlLiqTitulo > 0);
            Assert.Equal(parametro.InSTIDFF102BxParcial, tituloAtualizado.Ff102Situacaoid);
        }

        [Fact]
        public async Task Executar_MultiplosMovimentos_DeveAcumularValores()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            var ff102 = await CriarTituloTeste(parametro.InFF102Id, parametro.InTenantID);
            
            // Criar múltiplos movimentos
            await CriarMovimentoTeste(ff102.Id, parametro.InTenantID, valorPago: 100, valorJuros: 20);
            await CriarMovimentoTeste(ff102.Id, parametro.InTenantID, valorPago: 150, valorJuros: 30);

            // Act
            var resultado = await _service.Executar(parametro);

            // Assert
            Assert.True(resultado);
            
            var tituloAtualizado = await _context.OsusrE9aCsicpFf102s
                .FirstAsync(x => x.Id == parametro.InFF102Id);
            
            Assert.Equal(250, tituloAtualizado.Ff102TotalPagamentos); // 100 + 150
            Assert.Equal(50, tituloAtualizado.Ff102TotalJuros); // 20 + 30
            Assert.Equal(2, tituloAtualizado.Ff102NoPagamentos); // 2 movimentos
        }

        private PrmEntradaCalculoBaixa CriarParametroTeste()
        {
            return new PrmEntradaCalculoBaixa
            {
                InTenantID = 135,
                InFF102Id = Guid.NewGuid().ToString(),
                InBB001Id = "001",
                InSTIDFF102Liquidado = 1,
                InSTIDFF102BxParcial = 2,
                InSTIDFF102Aberto = 3,
                InSTIDFF103TpBaiCancelamento = 4,
                InSTIDFF103TpBaiDoacao = 5,
                InSTIDFF103TpBaiDevolucao = 6
            };
        }

        private async Task<CSICP_FF102> CriarTituloTeste(string id, int tenantId, decimal valorTitulo = 500)
        {
            var ff102 = new CSICP_FF102
            {
                Id = id,
                TenantId = tenantId,
                Ff102ValorTitulo = valorTitulo,
                Ff102VlDecrescimos = 10, // desconto de 10
                Ff102VlAcrescimos = 0,
                Ff102TotalPagamentos = 0,
                Ff102TotalJuros = 0,
                Ff102TotalMultaPaga = 0,
                Ff102TotalTarifas = 0,
                Ff102VlCorrmonetaria = 0,
                Ff102VlHonorarios = 0,
                Ff102ValorTaxaCartao = 0,
                Ff102TotalDescontos = 0,
                Ff102ValorDesagio = 0,
                Ff102TotalImpostosmenos = 0,
                Ff102NoPagamentos = 0,
                Ff102TotalDoacao = 0,
                Ff102TotalDevolucao = 0
            };

            _context.OsusrE9aCsicpFf102s.Add(ff102);
            await _context.SaveChangesAsync();
            return ff102;
        }

        private async Task CriarMovimentoTeste(string ff102Id, int tenantId, decimal valorPago = 100, 
            decimal valorJuros = 0, decimal valorMulta = 0, decimal valorDesconto = 0, decimal valorTarifas = 0)
        {
            var ff103 = new CSICP_FF103
            {
                Id = Guid.NewGuid().ToString(),
                TenantId = tenantId,
                Ff102Id = ff102Id,
                Ff103ValorPago = valorPago,
                Ff103ValorJuros = valorJuros,
                Ff103ValorMulta = valorMulta,
                Ff103ValorDesconto = valorDesconto,
                Ff103ValorTarifas = valorTarifas,
                Ff103VlCorrmonetaria = 0,
                Ff103VlHonorarios = 0,
                Ff103DataBaixa = DateTime.Now,
                Ff103Tpbaixaid = 1
            };

            _context.OsusrE9aCsicpFf103s.Add(ff103);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}