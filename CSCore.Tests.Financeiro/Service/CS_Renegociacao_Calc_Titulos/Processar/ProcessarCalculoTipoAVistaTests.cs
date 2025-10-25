using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Tests.Financeiro.Financeiro.CS_Renegociacao_Calc_Titulos.Processar;

public class ProcessarCalculoTipoAVistaTests
{
    private AppDbContext CreateInMemoryDb()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;
        return new AppDbContext(options);
    }

    private ICS_GenerateId CreateFakeIdGenerator()
    {
        return new FakeIdGenerator();
    }

    [Fact]
    public async Task Processar_CriaEntidadeESalvaNoBanco()
    {
        // Arrange
        var db = CreateInMemoryDb();
        var idGen = CreateFakeIdGenerator();
        var sut = new ProcessarCalculoTipoAVista(db, idGen);

        string controleId = "CTRL123";
        DateOnly data = DateOnly.FromDateTime(DateTime.Today);
        int tenantId = 1;
        RetornoFinanciamento financiamento = new() { ValorFinanciado = 1000m };

        // Act
        await sut.GerarMemoriaCalculo(controleId, data, tenantId, financiamento);

        // Assert
        var entidade = await db.Set<CSICP_FF999>().FirstOrDefaultAsync();
        Assert.NotNull(entidade);
        Assert.Equal(controleId, entidade.Ff999IdControle);
        Assert.Equal(tenantId, entidade.TenantId);
        Assert.Equal(1000m, entidade.Ff999Valorparcela);
        Assert.Equal(1, entidade.Ff999Parcela);
        Assert.Equal(data.ToDateTime(new TimeOnly(0, 0)), entidade.Ff999Datavencto);
    }

    [Fact]
    public async Task CriarEntidade_RetornaEntidadeCorreta()
    {
        // Arrange
        var db = CreateInMemoryDb();
        var idGen = CreateFakeIdGenerator();
        var sut = new ProcessarCalculoTipoAVista(db, idGen);

        string controleId = "CTRL999";
        DateOnly data = DateOnly.FromDateTime(DateTime.Today);
        int tenantId = 2;
        var financiamento = new RetornoFinanciamento { ValorFinanciado = 500m };

        // Act
        var entidade = sut.CriarEntidade<CSICP_FF999>(controleId, data, tenantId, financiamento, 1, "", 0);

        // Assert
        Assert.NotNull(entidade);
        Assert.Equal(controleId, entidade.Ff999IdControle);
        Assert.Equal(tenantId, entidade.TenantId);
        Assert.Equal(500m, entidade.Ff999Valorparcela);
        Assert.Equal(1, entidade.Ff999Parcela);
        Assert.Equal(data.ToDateTime(new TimeOnly(0, 0)), entidade.Ff999Datavencto);
    }

    // FakeIdGenerator para testes
    private class FakeIdGenerator : ICS_GenerateId
    {
        public string GenerateUuId() => Guid.NewGuid().ToString();
    }
}