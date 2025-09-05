using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.CalculoAdicaoDataStrategy;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace CSCore.Tests.Geral.Financeiro.RenegociacaoCalcTitulo
{
    public class ProcessarParcelasTipoParcelaDiasOuMesTest : IDisposable
    {
        private readonly AppDbContext _context;
        private readonly Mock<ICS_GenerateId> _mockGenerateId;
        private string[] _generatedIds;
        private int _idCounter;

        public ProcessarParcelasTipoParcelaDiasOuMesTest()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new AppDbContext(options);
            _mockGenerateId = new Mock<ICS_GenerateId>();
            
            // Setup specific IDs for each test scenario
            _generatedIds = new string[]
            {
                "zz0199150dd73074d83cd950f62e8a2436",
                "zz0199150de50074ba42047d307d0dfd0",
                "zz0199150edaf17553c746e399c3e3eaa",
                "zz0199150e2b87ce387640a49dfd63ae",
                "zz01991510aa97b5034b8fdb841d2cada",
                "zz01991510aa17c9e0d4f9a8bfcfa74205",
                "zz01991510aa377ee946278346c82380",
                "zz019915143bfe753db3a2e1014649f24",
                "zz019915143c873f839d3e947a493d08a",
                "zz019915143c873f839d3e947a493d08b",
                "zz019915143c49c978b9689d644d930ae",
                "zz019915159f281d1930ca1243d4dfc0",
                "zz019915159482c98911f9801b320c2b",
                "zz019915159f778e816f86fa0c5434bb"
            };
            
            _idCounter = 0;
            _mockGenerateId.Setup(x => x.GenerateUuId())
                .Returns(() => _generatedIds[_idCounter++]);
        }

        [Fact]
        public async Task ProcessarParcelasDiasComEntrada_DeveGerarParcelasCorretas()
        {
            // Arrange
            var incrementarDataStrategy = new IncrementarDataTipoParcelaDiaStrategy();
            var aux_condicaoPagtoDividida = new string[] { "4", "10", "30" }; // 4 parcelas, 10 dias entrada, 30 dias intervalo
            var work_valor_entrada = 58.46m;
            
            var processor = new ProcessarParcelasTipoParcelaDiasOuMes(
                _mockGenerateId.Object,
                aux_condicaoPagtoDividida,
                work_valor_entrada,
                _context,
                incrementarDataStrategy
            );

            var parametro = new Prm_Renegociacao_Calc_Simulacao_Titulos
            {
                in_TenantID = 135,
                in_renegociacaoID = "zz2025000000000000052429",
                in_condicaoPagamento = "zz20250000000000000952668",
                in_data = new DateTime(2025, 6, 1),
                in_valorEntrada = work_valor_entrada,
                in_faturaTotal = 158.46m
            };

            var retornoFinanciamento = new RetornoFinanciamento
            {
                ValorFaturaTotal = 158.46m,
                ValorParcela = 33.33m,
                ValorRestoParcela = 0.01m,
                ValorFinanciado = 100.00m
            };

            // Act
            await processor.Processar(parametro, retornoFinanciamento);

            // Assert
            var parcelas = await _context.OsusrE9aCsicpFf999s
                .Where(f => f.Ff999IdControle == "zz2025000000000000052429")
                .OrderBy(f => f.Ff999Parcela)
                .ToListAsync();

            Assert.Equal(4, parcelas.Count);

            // Parcela 1 (com entrada)
            var parcela1 = parcelas[0];
            Assert.Equal("zz0199150dd73074d83cd950f62e8a2436", parcela1.Id);
            Assert.Equal(135, parcela1.TenantId);
            Assert.Equal("zz2025000000000000052429", parcela1.Ff999IdControle);
            Assert.Equal(1, parcela1.Ff999Parcela);
            Assert.Equal(new DateTime(2025, 6, 11), parcela1.Ff999Datavencto);
            Assert.Equal(58.47m, parcela1.Ff999Valorparcela);

            // Parcela 2
            var parcela2 = parcelas[1];
            Assert.Equal("zz0199150de50074ba42047d307d0dfd0", parcela2.Id);
            Assert.Equal(2, parcela2.Ff999Parcela);
            Assert.Equal(new DateTime(2025, 7, 11), parcela2.Ff999Datavencto);
            Assert.Equal(33.33m, parcela2.Ff999Valorparcela);

            // Parcela 3
            var parcela3 = parcelas[2];
            Assert.Equal("zz0199150edaf17553c746e399c3e3eaa", parcela3.Id);
            Assert.Equal(3, parcela3.Ff999Parcela);
            Assert.Equal(new DateTime(2025, 8, 10), parcela3.Ff999Datavencto);
            Assert.Equal(33.33m, parcela3.Ff999Valorparcela);

            // Parcela 4
            var parcela4 = parcelas[3];
            Assert.Equal("zz0199150e2b87ce387640a49dfd63ae", parcela4.Id);
            Assert.Equal(4, parcela4.Ff999Parcela);
            Assert.Equal(new DateTime(2025, 9, 9), parcela4.Ff999Datavencto);
            Assert.Equal(33.33m, parcela4.Ff999Valorparcela);
        }

        [Fact]
        public async Task ProcessarParcelasDiasSemEntrada_DeveGerarParcelasCorretas()
        {
            // Arrange
            _idCounter = 4; // Start from the 5th ID for this test
            var incrementarDataStrategy = new IncrementarDataTipoParcelaDiaStrategy();
            var aux_condicaoPagtoDividida = new string[] { "3", "0", "30" }; // 3 parcelas, 30 dias entrada, 30 dias intervalo
            var work_valor_entrada = 0m;
            
            var processor = new ProcessarParcelasTipoParcelaDiasOuMes(
                _mockGenerateId.Object,
                aux_condicaoPagtoDividida,
                work_valor_entrada,
                _context,
                incrementarDataStrategy
            );

            var parametro = new Prm_Renegociacao_Calc_Simulacao_Titulos
            {
                in_TenantID = 135,
                in_renegociacaoID = "zz2025000000000000052429",
                in_condicaoPagamento = "zz20250000000000000952669",
                in_data = new DateTime(2025, 6, 1),
                in_valorEntrada = 0m,
                in_faturaTotal = 158.46m
            };

            var retornoFinanciamento = new RetornoFinanciamento
            {
                ValorFaturaTotal = 158.46m,
                ValorParcela = 52.82m,
                ValorRestoParcela = 0m,
                ValorFinanciado = 158.46m
            };

            // Act
            await processor.Processar(parametro, retornoFinanciamento);

            // Assert
            var parcelas = await _context.OsusrE9aCsicpFf999s
                .Where(f => f.Ff999IdControle == "zz2025000000000000052429")
                .OrderBy(f => f.Ff999Parcela)
                .ToListAsync();

            Assert.Equal(3, parcelas.Count);

            // Parcela 1
            var parcela1 = parcelas[0];
            Assert.Equal("zz01991510aa97b5034b8fdb841d2cada", parcela1.Id);
            Assert.Equal(1, parcela1.Ff999Parcela);
            Assert.Equal(new DateTime(2025, 7, 1), parcela1.Ff999Datavencto);
            Assert.Equal(52.82m, parcela1.Ff999Valorparcela);

            // Parcela 2
            var parcela2 = parcelas[1];
            Assert.Equal("zz01991510aa17c9e0d4f9a8bfcfa74205", parcela2.Id);
            Assert.Equal(2, parcela2.Ff999Parcela);
            Assert.Equal(new DateTime(2025, 7, 31), parcela2.Ff999Datavencto);
            Assert.Equal(52.82m, parcela2.Ff999Valorparcela);

            // Parcela 3
            var parcela3 = parcelas[2];
            Assert.Equal("zz01991510aa377ee946278346c82380", parcela3.Id);
            Assert.Equal(3, parcela3.Ff999Parcela);
            Assert.Equal(new DateTime(2025, 8, 30), parcela3.Ff999Datavencto);
            Assert.Equal(52.82m, parcela3.Ff999Valorparcela);
        }

        [Fact]
        public async Task ProcessarParcelasMesComEntrada_DeveGerarParcelasCorretas()
        {
            // Arrange
            _idCounter = 7; // Start from the 8th ID for this test
            var incrementarDataStrategy = new IncrementarDataTipoParcelaMesStrategy();
            var aux_condicaoPagtoDividida = new string[] { "4", "1", "1" }; // 4 parcelas, 1 mês entrada, 1 mês intervalo
            var work_valor_entrada = 58.46m;
            
            var processor = new ProcessarParcelasTipoParcelaDiasOuMes(
                _mockGenerateId.Object,
                aux_condicaoPagtoDividida,
                work_valor_entrada,
                _context,
                incrementarDataStrategy
            );

            var parametro = new Prm_Renegociacao_Calc_Simulacao_Titulos
            {
                in_TenantID = 135,
                in_renegociacaoID = "zz2025000000000000052429",
                in_condicaoPagamento = "0c621c0f-0c08-46bc-9cf2-6e13189c8949",
                in_data = new DateTime(2025, 6, 1),
                in_valorEntrada = work_valor_entrada,
                in_faturaTotal = 158.46m
            };

            var retornoFinanciamento = new RetornoFinanciamento
            {
                ValorFaturaTotal = 158.46m,
                ValorParcela = 33.33m,
                ValorRestoParcela = 0.01m,
                ValorFinanciado = 100.00m
            };

            // Act
            await processor.Processar(parametro, retornoFinanciamento);

            // Assert
            var parcelas = await _context.OsusrE9aCsicpFf999s
                .Where(f => f.Ff999IdControle == "zz2025000000000000052429")
                .OrderBy(f => f.Ff999Parcela)
                .ToListAsync();

            Assert.Equal(4, parcelas.Count);

            // Parcela 1 (com entrada)
            var parcela1 = parcelas[0];
            Assert.Equal("zz019915143bfe753db3a2e1014649f24", parcela1.Id);
            Assert.Equal(1, parcela1.Ff999Parcela);
            Assert.Equal(new DateTime(2025, 7, 1), parcela1.Ff999Datavencto);
            Assert.Equal(58.47m, parcela1.Ff999Valorparcela);

            // Parcela 2
            var parcela2 = parcelas[1];
            Assert.Equal("zz019915143c873f839d3e947a493d08a", parcela2.Id);
            Assert.Equal(2, parcela2.Ff999Parcela);
            Assert.Equal(new DateTime(2025, 8, 1), parcela2.Ff999Datavencto);
            Assert.Equal(33.33m, parcela2.Ff999Valorparcela);

            // Parcela 3
            var parcela3 = parcelas[2];
            Assert.Equal("zz019915143c873f839d3e947a493d08b", parcela3.Id);
            Assert.Equal(3, parcela3.Ff999Parcela);
            Assert.Equal(new DateTime(2025, 9, 1), parcela3.Ff999Datavencto);
            Assert.Equal(33.33m, parcela3.Ff999Valorparcela);

            // Parcela 4
            var parcela4 = parcelas[3];
            Assert.Equal("zz019915143c49c978b9689d644d930ae", parcela4.Id);
            Assert.Equal(4, parcela4.Ff999Parcela);
            Assert.Equal(new DateTime(2025, 10, 1), parcela4.Ff999Datavencto);
            Assert.Equal(33.33m, parcela4.Ff999Valorparcela);
        }

        [Fact]
        public async Task ProcessarParcelasMesSemEntrada_DeveGerarParcelasCorretas()
        {
            // Arrange
            _idCounter = 11; // Start from the 12th ID for this test
            var incrementarDataStrategy = new IncrementarDataTipoParcelaMesStrategy();
            var aux_condicaoPagtoDividida = new string[] { "3", "0", "1" }; // 3 parcelas, 2 meses entrada, 1 mês intervalo
            var work_valor_entrada = 0m;
            
            var processor = new ProcessarParcelasTipoParcelaDiasOuMes(
                _mockGenerateId.Object,
                aux_condicaoPagtoDividida,
                work_valor_entrada,
                _context,
                incrementarDataStrategy
            );

            var parametro = new Prm_Renegociacao_Calc_Simulacao_Titulos
            {
                in_TenantID = 135,
                in_renegociacaoID = "zz2025000000000000052429",
                in_condicaoPagamento = "435bfc5e-60ac-48bc-b851-b0e69f4938c4",
                in_data = new DateTime(2025, 6, 1),
                in_valorEntrada = 0m,
                in_faturaTotal = 158.46m
            };

            var retornoFinanciamento = new RetornoFinanciamento
            {
                ValorFaturaTotal = 158.46m,
                ValorParcela = 52.82m,
                ValorRestoParcela = 0m,
                ValorFinanciado = 158.46m
            };

            // Act
            await processor.Processar(parametro, retornoFinanciamento);

            // Assert
            var parcelas = await _context.OsusrE9aCsicpFf999s
                .Where(f => f.Ff999IdControle == "zz2025000000000000052429")
                .OrderBy(f => f.Ff999Parcela)
                .ToListAsync();

            Assert.Equal(3, parcelas.Count);

            // Parcela 1
            var parcela1 = parcelas[0];
            Assert.Equal("zz019915159f281d1930ca1243d4dfc0", parcela1.Id);
            Assert.Equal(1, parcela1.Ff999Parcela);
            Assert.Equal(new DateTime(2025, 7, 1), parcela1.Ff999Datavencto);
            Assert.Equal(52.82m, parcela1.Ff999Valorparcela);

            // Parcela 2
            var parcela2 = parcelas[1];
            Assert.Equal("zz019915159482c98911f9801b320c2b", parcela2.Id);
            Assert.Equal(2, parcela2.Ff999Parcela);
            Assert.Equal(new DateTime(2025, 8, 1), parcela2.Ff999Datavencto);
            Assert.Equal(52.82m, parcela2.Ff999Valorparcela);

            // Parcela 3
            var parcela3 = parcelas[2];
            Assert.Equal("zz019915159f778e816f86fa0c5434bb", parcela3.Id);
            Assert.Equal(3, parcela3.Ff999Parcela);
            Assert.Equal(new DateTime(2025, 9, 1), parcela3.Ff999Datavencto);
            Assert.Equal(52.82m, parcela3.Ff999Valorparcela);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}