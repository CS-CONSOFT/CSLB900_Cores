using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;
using CSCore.Ex.Personalizada;
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
    public async Task CS_005_GeraContasAPagar_ShouldThrowException_WhenFF040DoesNotExist()
    {
        // Arrange
        int tenantId = 1;
        long ff040Id = 1;
        int situacaoRegistrado = 1;

        // Act & Assert
        await Assert.ThrowsAsync<KeyNotFoundException>(async () =>
        {
            await _repository.CS_005_GeraContasAPagar(tenantId, ff040Id, situacaoRegistrado);
        });
    }

    [Fact]
    public async Task CS_005_GeraContasAPagar_ShouldThrowException_WhenFF042DoesNotExist()
    {
        // Arrange
        int tenantId = 1;
        long ff040Id = 2;
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

    [Fact]
    public async Task CS_005_GeraContasAPagar_ShouldThrowException_WhenFF043DoesNotExist()
    {
        // Arrange
        int tenantId = 1;
        long ff040Id = 3;
        int situacaoRegistrado = 1;

        var ff040Entity = new CSICP_FF040
        {
            TenantId = tenantId,
            Ff040Id = ff040Id,
            Ff040Vtransacao = 1000m,
            Ff040Dbasevencto = DateTime.Now
        };

        var ff042 = CSICP_FF042.Create(
            ff040Entity: ff040Entity,
            formaPgtoID: "FormaPgtoExemplo",
            condicaoPgtoID: "CondicaoPgtoExemplo",
            NroParcelas: 3
        );

        ff042.Ff042Id = 3;

        _context.OsusrE9aCsicpFf040s.Add(ff040Entity);
        _context.OsusrE9aCsicpFf042s.Add(ff042);

        await _context.SaveChangesAsync();

        // Act & Assert
        await Assert.ThrowsAsync<EmptyListException>(async () =>
        {
            await _repository.CS_005_GeraContasAPagar(tenantId, ff040Id, situacaoRegistrado);
        });
    }

    [Fact]
    public async Task CS_005_GeraContasAPagar_ShouldUpdateFF040_WhenAllEntitiesExist()
    {
        // Arrange
        int tenantId = 1;
        long ff040Id = 4;
        int situacaoRegistrado = 1;

        var ff040Entity = new CSICP_FF040
        {
            TenantId = tenantId,
            Ff040Id = ff040Id,
            Ff040Vtransacao = 1000m,
            Ff040Dbasevencto = DateTime.Now
        };

        var ff042 = CSICP_FF042.Create(
            ff040Entity: ff040Entity,
            formaPgtoID: "FormaPgtoExemplo",
            condicaoPgtoID: "CondicaoPgtoExemplo",
            NroParcelas: 3
        );

        ff042.Ff042Id = 2;

        var ff043 = CSICP_FF043.Create(
            InTenantID: tenantId,
            InFf042Id: 2,
            ValorParcela: 333.33m,
            Parcela: 1,
            DataVencimento: DateTime.Now.AddDays(30),
            Pfxtitulo: "PrefixoExemplo",
            Protocolo: 12345m
        );

        _context.OsusrE9aCsicpFf040s.Add(ff040Entity);
        _context.OsusrE9aCsicpFf042s.Add(ff042);
        _context.OsusrE9aCsicpFf043s.Add(ff043);

        await _context.SaveChangesAsync();

        // Act
        await _repository.CS_005_GeraContasAPagar(tenantId, ff040Id, situacaoRegistrado);

        // Assert
        var updatedFF040 = await _context.OsusrE9aCsicpFf040s.FirstOrDefaultAsync(e => e.Ff040Id == ff040Id);
        Assert.NotNull(updatedFF040);
        Assert.Equal(situacaoRegistrado, updatedFF040.Ff040Situacaoid);
    }

    [Fact]
    public async Task CS_005_GeraContasAPagar_ShouldThrowException_WhenNoFF043Exists()
    {
        // Arrange
        int tenantId = 1;
        long ff040Id = 5;
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
      InCondicaoPgtoID: "CondicaoPgtoExemplo",
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
            Id = "CondicaoPgtoExemplo",
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
        Assert.Equal("CondicaoPgtoExemplo", ff042.Ff042Condicaoid);
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