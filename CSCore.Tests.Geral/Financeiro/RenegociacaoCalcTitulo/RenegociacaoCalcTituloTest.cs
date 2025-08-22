using NPOI.SS.Formula.Functions;

namespace CSCore.Tests.Geral.Financeiro.RenegociacaoCalcTitulo
{
    using CSLB900.MSTools.GenerateId;
    using CSLB900.MSToolsTestes;
    using global::CSCore.Ifs.CS_Context;
    using global::CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos;
    using global::CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Interface;
    using global::CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Moq;
    using System;
    using System.Threading.Tasks;
    using Xunit;

    namespace CSCore.Ifs.FF.Tests.Repository.Processos.CS_Renegociacao_Calc_Titulos
    {
        public class Renegociacao_Calc_TitulosTests : IDisposable
        {
            private readonly AppDbContext _context;
            private readonly Mock<ICS_GenerateId> _mockGenerateId;
            private readonly IRenegociacao_Calc_Titulos _service;
            private readonly string _connectionString;

            public Renegociacao_Calc_TitulosTests()
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
                _service = new Renegociacao_Calc_Titulos(_context, _mockGenerateId.Object);

             
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

            private Prm_Renegociacao_Calc_Titulos CriarParametroTeste()
            {
                return new Prm_Renegociacao_Calc_Titulos
                {
                    in_tenantID = 135,
                    in_renegociacaoID = Guid.NewGuid().ToString(),
                    in_condicaoPagamento = "TESTE01",
                    in_StID_bb008_tp_Dias = 1,
                    in_StID_bb008_tp_ParcelaDias = 2,
                    in_StID_bb008_tp_ParcelaMes = 3,
                    in_StID_bb008_tp_A_vista = 4,
                    in_faturaTotal = 1000,
                    in_ChaveControle_ID = Guid.NewGuid().ToString(),
                    in_valorEntrada = 0,
                    in_data = DateTime.Now
                };
            }

            public void Dispose()
            {
                _context?.Dispose();
            }
        }
    }
}
