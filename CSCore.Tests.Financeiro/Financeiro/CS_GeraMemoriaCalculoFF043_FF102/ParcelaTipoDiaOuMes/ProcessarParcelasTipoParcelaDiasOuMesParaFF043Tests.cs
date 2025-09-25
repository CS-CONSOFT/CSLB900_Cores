using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;
using CSLB900.MSTools.CalculoAdicaoDataStrategy;
using CSLB900.MSTools.Calculos;
using CSLB900.MSTools.GenerateId;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Tests.Financeiro.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102.ParcelaTipoDiaOuMes
{
    public class ProcessarParcelasTipoParcelaDiasOuMesParaFF043Tests
    {
        private AppDbContext CreateInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            return new AppDbContext(options);
        }

        private ProcessarParcelasTipoParcelaDiasOuMesParaFF043 CreateSut(
            AppDbContext? dbContext = null,
            decimal protocolo = 12345.67m)
        {
            var input = new ProcessarParcelasTipoParcelaDiasOuMesParaFF043Input(
                protocolo,
                Mock.Of<ICS_GenerateId>(),
                "01",
                new string[] { "A", "B" },
                100m,
                dbContext ?? CreateInMemoryDbContext(),
                Mock.Of<IIncrementarDataStrategy>()
            );
            return new ProcessarParcelasTipoParcelaDiasOuMesParaFF043(input);
        }

        [Fact]
        public void CriarEntidade_DeveCriarCSICP_FF043Corretamente()
        {
            // Arrange
            var sut = CreateSut();
            var calculo = new RetCalculoParcelasPorCondicao
            {
                ValorParcela = 200m,
                Parcela = 2,
                DataVencimento = DateTime.Today
            };
            int tenantId = 1;
            string idControle = "123";

            // Act
            var entidade = sut.InvokeCriarEntidade<CSICP_FF043>(calculo, tenantId, idControle);

            // Assert
            Assert.NotNull(entidade);
            Assert.IsType<CSICP_FF043>(entidade);
            var ff043 = entidade as CSICP_FF043;
            Assert.Equal(tenantId, ff043.TenantId);
            Assert.Equal(long.Parse(idControle), ff043.Ff042Id);
            Assert.Equal(calculo.ValorParcela, ff043.Ff043ValorParcela);
            Assert.Equal(calculo.Parcela, ff043.Ff043Parcela);
            Assert.Equal(calculo.DataVencimento, ff043.Ff043DataVencto);
            Assert.Equal("", ff043.Ff043Pfxtitulo);
            Assert.Equal(12345.67m, ff043.Ff043Titulo);
        }

        [Fact]
        public void CriarEntidade_DeveLancarExcecaoParaTipoInvalido()
        {
            // Arrange
            var sut = CreateSut();
            var calculo = new RetCalculoParcelasPorCondicao();
            int tenantId = 1;
            string idControle = "123";

            // Act & Assert
            var ex = Assert.Throws<InvalidOperationException>(() =>
                sut.InvokeCriarEntidade<DummyEntity>(calculo, tenantId, idControle)
            );
            Assert.Contains("Tipo de entidade não suportado", ex.Message);
        }

        // Métodos auxiliares para acessar protected
        private class DummyEntity { }

        public class TestableProcessarParcelas : ProcessarParcelasTipoParcelaDiasOuMesParaFF043
        {
            public TestableProcessarParcelas(ProcessarParcelasTipoParcelaDiasOuMesParaFF043Input input)
                : base(input) { }

            public TEntity? InvokeCriarEntidade<TEntity>(RetCalculoParcelasPorCondicao calculo, int tenantId, string idControle) where TEntity : class
                => base.CriarEntidade<TEntity>(calculo, tenantId, idControle);

            public Task InvokePersistirAsync<TEntity>(List<TEntity> entidades) => base.PersistirAsync(entidades);
        }
    }

    // Extensão para facilitar o acesso aos métodos protected
    public static class ProcessarParcelasTipoParcelaDiasOuMesParaFF043TestExtensions
    {
        private static AppDbContext CreateInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            return new AppDbContext(options);
        }

        public static TEntity? InvokeCriarEntidade<TEntity>(this ProcessarParcelasTipoParcelaDiasOuMesParaFF043 sut, RetCalculoParcelasPorCondicao calculo, int tenantId, string idControle) where TEntity : class
        {
            var testable = new ProcessarParcelasTipoParcelaDiasOuMesParaFF043Tests.TestableProcessarParcelas(
                new ProcessarParcelasTipoParcelaDiasOuMesParaFF043Input(
                    12345.67m,
                    Mock.Of<ICS_GenerateId>(),
                    "01",
                    new string[] { "A", "B" },
                    100m,
                    CreateInMemoryDbContext(),
                    Mock.Of<IIncrementarDataStrategy>()
                )
            );
            return testable.InvokeCriarEntidade<TEntity>(calculo, tenantId, idControle);
        }

        public static Task InvokePersistirAsync<TEntity>(this ProcessarParcelasTipoParcelaDiasOuMesParaFF043 sut, List<TEntity> entidades)
        {
            var testable = new ProcessarParcelasTipoParcelaDiasOuMesParaFF043Tests.TestableProcessarParcelas(
                new ProcessarParcelasTipoParcelaDiasOuMesParaFF043Input(
                    12345.67m,
                    Mock.Of<ICS_GenerateId>(),
                    "01",
                    new string[] { "A", "B" },
                    100m,
                    CreateInMemoryDbContext(),
                    Mock.Of<IIncrementarDataStrategy>()
                )
            );
            return testable.InvokePersistirAsync(entidades);
        }
    }
}