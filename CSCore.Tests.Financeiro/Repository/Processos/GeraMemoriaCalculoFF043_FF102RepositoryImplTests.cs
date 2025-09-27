using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;
using CSCore.Ex.Personalizada;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace CSCore.Tests.Financeiro.Repository.Processos;

public class GeraMemoriaCalculoFF043_FF102RepositoryImplTests
{
    private readonly AppDbContext _context;
    private readonly Mock<IGenerateProtocolo> _mockGenerateProtocolo;
    private readonly Mock<ICS_GenerateId> _mockGenerateId;
    private readonly GeraMemoriaCalculoFF043_FF102RepositoryImpl _repository;

    public GeraMemoriaCalculoFF043_FF102RepositoryImplTests()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new AppDbContext(options);
        _mockGenerateProtocolo = new Mock<IGenerateProtocolo>();
        _mockGenerateId = new Mock<ICS_GenerateId>();

        _repository = new GeraMemoriaCalculoFF043_FF102RepositoryImpl(_context, _mockGenerateProtocolo.Object, _mockGenerateId.Object);
    }


    [Fact]
    public async Task CS_005_GeraContasAPagar_ShouldThrowException_WhenNoFF043Exists()
    {
        // Arrange
        int tenantId = 1;
        long ff040Id = 1;
        int situacaoRegistrado = 1;
        int stIdFf102EntParcela = 2;
        int stIdFf102SitAberto = 3;
        int stIdFf102SitProvisao = 4;
        int stIdFf102AutPagamentoAutorizado = 5;
        int stIdFf102AutPagamentoNaoAutorizado = 6;
        int stIdEntitiesSim = 7;
        int stIdEntitiesNao = 8;

        _context.OsusrE9aCsicpFf040s.Add(new CSICP_FF040
        {
            TenantId = tenantId,
            Ff040Id = ff040Id
        });

        await _context.SaveChangesAsync();

        // Act & Assert
        await Assert.ThrowsAsync<EmptyListException>(async () =>
        {
            await _repository.CS_005_GeraContasAPagar(
                tenantId,
                ff040Id,
                situacaoRegistrado,
                stIdFf102EntParcela,
                stIdFf102SitAberto,
                stIdFf102SitProvisao,
                stIdFf102AutPagamentoAutorizado,
                stIdFf102AutPagamentoNaoAutorizado,
                stIdEntitiesSim,
                stIdEntitiesNao
            );
        });
    }
}