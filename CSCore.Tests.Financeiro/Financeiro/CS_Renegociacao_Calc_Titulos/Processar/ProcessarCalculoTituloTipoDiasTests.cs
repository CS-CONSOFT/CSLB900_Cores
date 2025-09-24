using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace CSCore.Tests.Financeiro.Financeiro.CS_Renegociacao_Calc_Titulos.Processar
{
    public class ProcessarCalculoTituloTipoDiasTests
    {
        private AppDbContext CreateInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            return new AppDbContext(options);
        }

        private Mock<ICS_GenerateId> CreateMockGenerateId()
        {
            var mock = new Mock<ICS_GenerateId>();
            mock.Setup(x => x.GenerateUuId()).Returns(() => Guid.NewGuid().ToString());
            return mock;
        }

        [Fact]
        public async Task Processar_DevePersistirParcelasCorretamente()
        {
            // Arrange
            var context = CreateInMemoryContext();
            var mockGenerateId = CreateMockGenerateId();
            var condicaoPagtoDividida = new List<string> { "0", "30", "60" };
            decimal valorEntrada = 100;
            var processor = new ProcessarCalculoTituloTipoDias(
                context,
                mockGenerateId.Object,
                condicaoPagtoDividida,
                valorEntrada);

            var retornoFinanciamento = new RetornoFinanciamento
            {
                ValorParcela = 200,
                ValorRestoParcela = 50
            };

            string controleId = "REN123";
            DateOnly dataBase = DateOnly.FromDateTime(DateTime.Today);
            int tenantId = 1;

            // Act
            await processor.Processar(
                controleId,
                dataBase,
                tenantId,
                retornoFinanciamento,
                valorEntrada);

            // Assert
            var parcelas = context.Set<CSICP_FF999>().Where(x => x.Ff999IdControle == controleId).OrderBy(x => x.Ff999Parcela).ToList();
            Assert.Equal(3, parcelas.Count);
            Assert.Equal(1, parcelas[0].Ff999Parcela); // Primeira parcela
            Assert.Equal(dataBase.ToDateTime(new TimeOnly(0, 0)), parcelas[0].Ff999Datavencto);
            Assert.Equal(250, parcelas[0].Ff999Valorparcela); // ValorParcela + ValorRestoParcela
            Assert.Equal(2, parcelas[1].Ff999Parcela); // Segunda parcela
            Assert.Equal(dataBase.ToDateTime(new TimeOnly(0, 0)).AddDays(30), parcelas[1].Ff999Datavencto);
            Assert.Equal(200, parcelas[1].Ff999Valorparcela); // ValorParcela
            Assert.Equal(3, parcelas[2].Ff999Parcela); // Terceira parcela
            Assert.Equal(dataBase.ToDateTime(new TimeOnly(0, 0)).AddDays(60), parcelas[2].Ff999Datavencto);
            Assert.Equal(200, parcelas[2].Ff999Valorparcela); // ValorParcela
        }

        [Fact]
        public async Task Processar_SemEntrada_DeveCalcularValoresCorretamente()
        {
            // Arrange
            var context = CreateInMemoryContext();
            var mockGenerateId = CreateMockGenerateId();
            var condicaoPagtoDividida = new List<string> { "0", "15" };
            decimal valorEntrada = 0;
            var processor = new ProcessarCalculoTituloTipoDias(
                context,
                mockGenerateId.Object,
                condicaoPagtoDividida,
                valorEntrada);

            var retornoFinanciamento = new RetornoFinanciamento
            {
                ValorParcela = 300,
                ValorRestoParcela = 20
            };

            string controleId = "REN456";
            DateOnly dataBase = DateOnly.FromDateTime(DateTime.Today);
            int tenantId = 2;

            // Act
            await processor.Processar(
                controleId,
                dataBase,
                tenantId,
                retornoFinanciamento,
                valorEntrada);

            // Assert
            var parcelas = context.Set<CSICP_FF999>().Where(x => x.Ff999IdControle == controleId).OrderBy(x => x.Ff999Parcela).ToList();
            Assert.Equal(2, parcelas.Count);
            Assert.All(parcelas, p => Assert.Equal(320, p.Ff999Valorparcela)); // ValorParcela + ValorRestoParcela
        }
    }
}
