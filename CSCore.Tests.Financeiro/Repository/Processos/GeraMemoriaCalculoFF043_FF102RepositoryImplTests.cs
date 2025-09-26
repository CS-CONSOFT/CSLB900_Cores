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
    public async Task GeraFormaPagtotoMemoriaCalculoFF043_FF102_ShouldGenerateData()
    {
        // Arrange
        var prm = new PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository(
               InTenantID: 1,
               InEmpresaID: "1",
               InFF040_ID: 1,
               InDataBaseVencimento: DateTime.Now,
               InFormaPgtoID: "Cond1",
               InCondicaoPgtoID: "Cond1",
               InNroDeParcelas: 2,
               InFaturaTotal: 1000m,
               In_StID_bb008_tp_Dias: 0,
               In_StID_bb008_tp_ParcelaDias: 0,
               In_StID_bb008_tp_ParcelaMes: 0,
               In_StID_bb008_tp_A_vista: 0
           );

        _mockGenerateProtocolo.Setup(x => x.Fcn_Protocolo10(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), false))
            .ReturnsAsync(12345);

        // Act
        await _repository.GeraFormaPagtotoMemoriaCalculoFF043_FF102(prm);

        // Assert
        var ff042 = await _context.OsusrE9aCsicpFf042s.FirstOrDefaultAsync();
        Assert.NotNull(ff042);
        Assert.Equal(prm.InFormaPgtoID, ff042.Ff042Fpagtoid);
    }

    [Fact]
    public async Task CS_005_GeraContasAPagar_ShouldThrowException_WhenNoFF043Exists()
    {
        // Arrange
        int tenantId = 1;
        long ff040Id = 1;
        int situacaoRegistrado = 1;

        _context.OsusrE9aCsicpFf040s.Add(new CSICP_FF040
        {
            TenantId = tenantId,
            Ff040Id = ff040Id
        });

        await _context.SaveChangesAsync();

        // Act & Assert
        await Assert.ThrowsAsync<EmptyListException>(async () =>
        {
            await _repository.CS_005_GeraContasAPagar(tenantId, ff040Id, situacaoRegistrado);
        });
    }
}