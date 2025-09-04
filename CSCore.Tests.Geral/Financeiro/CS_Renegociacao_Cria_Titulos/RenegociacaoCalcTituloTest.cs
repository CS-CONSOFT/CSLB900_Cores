using NPOI.SS.Formula.Functions;

namespace CSCore.Tests.Geral.Financeiro.RenegociacaoCalcTitulo
{
    using CSLB900.MSTools.GenerateId;
    using CSLB900.MSToolsTestes;
    using global::CSCore.Ifs.CS_Context;
    using global::CSCore.Ifs.Eventos.Repository;
    using global::CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Cria_Titulos;
    using global::CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Cria_Titulos.Parametro;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Moq;
    using System;
    using System.Threading.Tasks;
    using Xunit;

    namespace CSCore.Ifs.FF.Tests.Repository.Processos.CS_Renegociacao_Calc_Titulos
    {
        public class RenegociacaoCalcTituloTest : IDisposable
        {
            private readonly AppDbContext _context;
            private readonly Mock<ICS_GenerateId> _mockGenerateId;
            private readonly Mock<IGenerateProtocolo> _generateProtocolo;
            private readonly IRenegociacaoCriaTitulo _service;
            private readonly string _connectionString;

            public RenegociacaoCalcTituloTest()
            {
                var config = new ConfigurationBuilder()
                .AddUserSecrets<InadimplenciaServiceTests>()
                .Build();
                    var connectionString = config.GetConnectionString("DefaultConnection");
                    _connectionString = connectionString;

                var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(_connectionString)
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                .Options;


                SetupMockGenerateId();
                _context = new AppDbContext(options);
                _mockGenerateId = new Mock<ICS_GenerateId>();
                _service = new Renegociacao_Cria_Titulos(_context, _mockGenerateId.Object, new GenerateProtocoloServiceImpl(_context, _mockGenerateId.Object));

            }

            private void SetupMockGenerateId()
            {
                _mockGenerateId.Setup(x => x.GenerateUuId())
                    .Returns(() => Guid.NewGuid().ToString());
            }



            [Fact]
            public async Task Executar_CondicaoPagamentoNaoEncontrada_DeveThrowExceptionSemAuditoria()
            {
                // Arrange
                var parametro = CriarParametroTeste();

                await _service.Executar(parametro);

                // Act & Assert - Não deve lançar exceção
                var exception = await Record.ExceptionAsync(() => _service.Executar(parametro));
                Assert.Null(exception);
            }

            private Prm_Renegociacao_Cria_Titulo CriarParametroTeste()
            {
                return new Prm_Renegociacao_Cria_Titulo
                {
                    InTenantID = 135,
                    InFF017ID = "",
                    InFF999ControleID = "",
                    InSy001ID = "",
                    InBB001FilialID = "",
                    InStIDFF102EntEntrada = 0,
                    InStIDFF102EntParcela = 0,
                    InStIDFF102SitAberto = 0,
                    InSTIDFF102SitRenegociado = 0,
                    InSTIDFF102SitLiquidado = 0,
                    InSTIDStaticaSim = 0,
                    InSTIDStaticaNao = 0,
                    InSTIDFF102AutPgtoAutorizado = 0,
                    InSTIDFF102AutPgtoNaoAutorizado = 0,
                    InSTIDFf103TpBai = 0,
                    InEntLiquidada = false,
                };
            }

            public void Dispose()
            {
                _context?.Dispose();
            }
        }
    }
}
