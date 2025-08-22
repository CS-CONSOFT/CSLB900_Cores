using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_EscreveValores;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Tests.Geral.Financeiro.CS_EscreveValores
{
    public class EscreveValoresTest : IDisposable
    {
        private readonly AppDbContext _context;
        private readonly IEscreveValores _service;

        public EscreveValoresTest()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new AppDbContext(options);
            _service = new EscreveValores(_context);
        }

        [Fact]
        public async Task Executar_RegistroNaoEncontrado_DeveThrowKeyNotFoundException()
        {
            // Arrange
            var parametro = CriarParametroTeste();

            // Act & Assert
            var exception = await Assert.ThrowsAsync<KeyNotFoundException>(() => _service.Executar(parametro));
            Assert.Contains("Nenhum registro encontrado para atualizar", exception.Message);
        }

        [Fact]
        public async Task Executar_ComDadosValidos_DeveAtualizarValoresCorretos()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            await CriarDadosTeste(parametro);

            // Act
            var resultado = await _service.Executar(parametro);

            // Assert
            Assert.True(resultado);
            
            var ff017Atualizado = await _context.OsusrE9aCsicpFf017s
                .FirstAsync(x => x.Id == parametro.InFF017ID && x.TenantId == parametro.InTenantID);
            
            Assert.Equal(1000, ff017Atualizado.Ff017TotalTitulos); // Soma dos valores dos títulos
            Assert.Equal(800, ff017Atualizado.Ff017TotalAberto);   // Soma dos valores abertos
            Assert.Equal(100, ff017Atualizado.Ff017TotalJuros);    // Soma dos juros
            Assert.Equal(50, ff017Atualizado.Ff017TotalMulta);     // Soma das multas
            Assert.Equal(700, ff017Atualizado.Ff017Totrenegociado); // Total aberto - descontos (800 - 100)
        }

        [Fact]
        public async Task Executar_ComMultiplosTitulos_DeveSomarValoresCorretamente()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            await CriarMultiplosTitulosTeste(parametro);

            // Act
            var resultado = await _service.Executar(parametro);

            // Assert
            Assert.True(resultado);
            
            var ff017Atualizado = await _context.OsusrE9aCsicpFf017s
                .FirstAsync(x => x.Id == parametro.InFF017ID && x.TenantId == parametro.InTenantID);
            
            // Verifica se os valores foram somados corretamente (2 títulos)
            Assert.Equal(1500, ff017Atualizado.Ff017TotalTitulos); // 1000 + 500
            Assert.Equal(1200, ff017Atualizado.Ff017TotalAberto);  // 800 + 400
            Assert.Equal(150, ff017Atualizado.Ff017TotalJuros);    // 100 + 50
            Assert.Equal(75, ff017Atualizado.Ff017TotalMulta);     // 50 + 25
        }

        [Fact]
        public async Task Executar_ComTitulosForaDasSituacoesEspecificadas_NaoDeveIncluirNaSoma()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            await CriarTituloComSituacaoDiferente(parametro);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<KeyNotFoundException>(() => _service.Executar(parametro));
            Assert.Contains("Nenhum registro encontrado para atualizar", exception.Message);
        }

        [Fact]
        public async Task Executar_ComValoresNulos_DeveTratarComoZero()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            await CriarDadosComValoresNulos(parametro);

            // Act
            var resultado = await _service.Executar(parametro);

            // Assert
            Assert.True(resultado);
            
            var ff017Atualizado = await _context.OsusrE9aCsicpFf017s
                .FirstAsync(x => x.Id == parametro.InFF017ID && x.TenantId == parametro.InTenantID);
            
            // Todos os valores devem ser 0 quando os campos são nulos
            Assert.Equal(0, ff017Atualizado.Ff017TotalTitulos);
            Assert.Equal(0, ff017Atualizado.Ff017TotalAberto);
            Assert.Equal(0, ff017Atualizado.Ff017TotalJuros);
            Assert.Equal(0, ff017Atualizado.Ff017TotalMulta);
        }

        private PrmEscreveValores CriarParametroTeste()
        {
            return new PrmEscreveValores
            {
                InTenantID = 135,
                InSTIDFF102SitAberto = 1,
                InSTID102BxParcial = 2,
                InFF017ID = Guid.NewGuid().ToString()
            };
        }

        private async Task CriarDadosTeste(PrmEscreveValores parametro)
        {
            // Criar FF017
            var ff017 = new CSICP_FF017
            {
                Id = parametro.InFF017ID,
                TenantId = parametro.InTenantID,
                Ff017TotalDescontos = 100 // Para testar o cálculo do renegociado
            };

            // Criar FF018 com situação aberta
            var ff018 = new CSICP_FF018
            {
                Id = Guid.NewGuid().ToString(),
                TenantId = parametro.InTenantID,
                Ff017Id = parametro.InFF017ID,
                Ff018Situacaotituloid = parametro.InSTIDFF102SitAberto,
                Ff018ValorTitulo = 1000,
                Ff018ValorAberto = 800,
                Ff018ValorJuros = 100,
                Ff018ValorMulta = 50
            };

            _context.OsusrE9aCsicpFf017s.Add(ff017);
            _context.OsusrE9aCsicpFf018s.Add(ff018);
            await _context.SaveChangesAsync();
        }

        private async Task CriarMultiplosTitulosTeste(PrmEscreveValores parametro)
        {
            // Criar FF017
            var ff017 = new CSICP_FF017
            {
                Id = parametro.InFF017ID,
                TenantId = parametro.InTenantID,
                Ff017TotalDescontos = 100
            };

            // Criar primeiro FF018
            var ff018_1 = new CSICP_FF018
            {
                Id = Guid.NewGuid().ToString(),
                TenantId = parametro.InTenantID,
                Ff017Id = parametro.InFF017ID,
                Ff018Situacaotituloid = parametro.InSTIDFF102SitAberto,
                Ff018ValorTitulo = 1000,
                Ff018ValorAberto = 800,
                Ff018ValorJuros = 100,
                Ff018ValorMulta = 50
            };

            // Criar segundo FF018
            var ff018_2 = new CSICP_FF018
            {
                Id = Guid.NewGuid().ToString(),
                TenantId = parametro.InTenantID,
                Ff017Id = parametro.InFF017ID,
                Ff018Situacaotituloid = parametro.InSTID102BxParcial,
                Ff018ValorTitulo = 500,
                Ff018ValorAberto = 400,
                Ff018ValorJuros = 50,
                Ff018ValorMulta = 25
            };

            _context.OsusrE9aCsicpFf017s.Add(ff017);
            _context.OsusrE9aCsicpFf018s.Add(ff018_1);
            _context.OsusrE9aCsicpFf018s.Add(ff018_2);
            await _context.SaveChangesAsync();
        }

        private async Task CriarTituloComSituacaoDiferente(PrmEscreveValores parametro)
        {
            // Criar FF017
            var ff017 = new CSICP_FF017
            {
                Id = parametro.InFF017ID,
                TenantId = parametro.InTenantID,
                Ff017TotalDescontos = 100
            };

            // Criar FF018 com situação que não será incluída na query (liquidado = 99)
            var ff018 = new CSICP_FF018
            {
                Id = Guid.NewGuid().ToString(),
                TenantId = parametro.InTenantID,
                Ff017Id = parametro.InFF017ID,
                Ff018Situacaotituloid = 99, // Situação não contemplada
                Ff018ValorTitulo = 1000,
                Ff018ValorAberto = 800,
                Ff018ValorJuros = 100,
                Ff018ValorMulta = 50
            };

            _context.OsusrE9aCsicpFf017s.Add(ff017);
            _context.OsusrE9aCsicpFf018s.Add(ff018);
            await _context.SaveChangesAsync();
        }

        private async Task CriarDadosComValoresNulos(PrmEscreveValores parametro)
        {
            // Criar FF017
            var ff017 = new CSICP_FF017
            {
                Id = parametro.InFF017ID,
                TenantId = parametro.InTenantID,
                Ff017TotalDescontos = 0
            };

            // Criar FF018 com valores nulos
            var ff018 = new CSICP_FF018
            {
                Id = Guid.NewGuid().ToString(),
                TenantId = parametro.InTenantID,
                Ff017Id = parametro.InFF017ID,
                Ff018Situacaotituloid = parametro.InSTIDFF102SitAberto,
                Ff018ValorTitulo = null,
                Ff018ValorAberto = null,
                Ff018ValorJuros = null,
                Ff018ValorMulta = null
            };

            _context.OsusrE9aCsicpFf017s.Add(ff017);
            _context.OsusrE9aCsicpFf018s.Add(ff018);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
