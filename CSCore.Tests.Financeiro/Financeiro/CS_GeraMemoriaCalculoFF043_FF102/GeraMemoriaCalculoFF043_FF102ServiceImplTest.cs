using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

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

        _repository = new GeraMemoriaCalculoFF043_FF102RepositoryImpl(
            _context,
            _mockGenerateProtocolo.Object,
            _mockGenerateId.Object
        );
    }

    [Fact]
    public async Task GeraFormaPagtotoMemoriaCalculoFF043_FF102_Success()
    {
        // Arrange
        var prm = new PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository(
      InTenantID: 1,
      InEmpresaID: "EMP001",
      InFF040_ID: 12345,
      InDataBaseVencimento: DateTime.Now,
      InFormaPgtoID: "FORMA001",
      InCondicaoPgtoID: "COND001",
      InNroDeParcelas: 3,
      InFaturaTotal: 1000m,
      In_StID_bb008_tp_Dias: 1,
      In_StID_bb008_tp_ParcelaDias: 2,
      In_StID_bb008_tp_ParcelaMes: 3,
      In_StID_bb008_tp_A_vista: 4
  );

        _mockGenerateProtocolo
            .Setup(p =>
            p.Fcn_Protocolo10(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<bool>()))
            .ReturnsAsync(12345);

        _mockGenerateId
            .Setup(g => g.GenerateUuId())
            .Returns("UUID001");

        _context.OsusrE9aCsicpBb008s.Add(new CSICP_Bb008
        {
            TenantId = 1,
            Id = "COND001",
            Bb008Tipoid = 1,
            Bb008Condicao = "30;60;90"
        });

        _context.OsusrE9aCsicpFf040s.Add(new CSICP_FF040
        {
            TenantId = 1,
            Ff040Id = 12345
        });

        await _context.SaveChangesAsync();

        // Act
        await _repository.GeraFormaPagtotoMemoriaCalculoFF043_FF102(prm);
        await _context.SaveChangesAsync();
        // Assert
        var ff042 = await _context.OsusrE9aCsicpFf042s.FirstOrDefaultAsync();
        Assert.NotNull(ff042);
        Assert.Equal("COND001", ff042.Ff042Condicaoid);
        Assert.Equal(3, ff042.Ff042Nroparcelas);

        var ff043 = await _context.OsusrE9aCsicpFf043s.ToListAsync();
        Assert.NotEmpty(ff043);
    }

    [Fact]
    public async Task GeraFormaPagtotoMemoriaCalculoFF043_FF102_ThrowsException_WhenCondicaoPagamentoNotFound()
    {
        var prm = new PrmGeraFormPgtoMemoriaCalculoFF043_FF102Repository(
        InTenantID: 1,
        InEmpresaID: "EMP001",
        InFF040_ID: 12345,
        InDataBaseVencimento: DateTime.Now,
        InFormaPgtoID: "FORMA001",
        InCondicaoPgtoID: "INVALID",
        InNroDeParcelas: 3,
        InFaturaTotal: 1000m,
        In_StID_bb008_tp_Dias: 1,
        In_StID_bb008_tp_ParcelaDias: 2,
        In_StID_bb008_tp_ParcelaMes: 3,
        In_StID_bb008_tp_A_vista: 4
    );

        // Act & Assert
        await Assert.ThrowsAsync<KeyNotFoundException>(() =>
            _repository.GeraFormaPagtotoMemoriaCalculoFF043_FF102(prm));
    }
}