using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;
using CSCore.Ex.Personalizada;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102;
using CSCore.Ifs.LB900.Repository;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;
using Moq;

public class GeraMemoriaCalculoFF043_FF102RepositoryImplTests
{
    private readonly AppDbContext _context;
    private readonly Mock<IGenerateProtocolo> _mockGenerateProtocolo;
    private readonly Mock<ICS_GenerateId> _mockGenerateId;
    private readonly GeraMemoriaCalculoFF043_FF102RepositoryImpl _repository;

    public GeraMemoriaCalculoFF043_FF102RepositoryImplTests()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _context = new AppDbContext(options);
        _mockGenerateProtocolo = new Mock<IGenerateProtocolo>();
        _mockGenerateId = new Mock<ICS_GenerateId>();
        _mockGenerateId.SetupSequence(x => x.GenerateUuId())
            .Returns("ff102-uuid-1")
            .Returns("ff104-uuid-1"); // For FF102 and FF104

        _repository = new GeraMemoriaCalculoFF043_FF102RepositoryImpl(
            _context,
            _mockGenerateProtocolo.Object,
            _mockGenerateId.Object
        );
    }

    [Fact]
    public async Task CS_005_GeraContasAPagar_ShouldThrowException_WhenFF042DoesNotExist()
    {
        // Arrange
        int tenantId = 1;
        long ff040Id = 2;
        var parametros = new CS_005_GeraContasAPagarParametros(
            InTenantID: tenantId,
            InFF040_ID: ff040Id,
            InStID_FF040Sit_Registrado: 1,
            InStID_FF102_Ent_Parcela: 2,
            InStID_FF102_Sit_Aberto: 3,
            InStID_FF102_Sit_Provisao: 4,
            InStID_FF102_Aut_PagamentoAutorizado: 5,
            InStID_FF102_Aut_PagamentoNaoAutorizado: 6,
            InStID_Entities_SIM: 7,
            InStID_Entities_NAO: 8,
            InFormaPgtoID: "",
            InCondicaoPgtoID: ""
        );

        _context.OsusrE9aCsicpFf040s.Add(new CSICP_FF040
        {
            TenantId = tenantId,
            Ff040Id = ff040Id
        });

        var ff040 = await _context.OsusrE9aCsicpFf040s.Where(e => e.Ff040Id == ff040Id).FirstAsync();

        await _context.SaveChangesAsync();

        // Act & Assert
        await Assert.ThrowsAsync<EmptyListException>(async () =>
        {
            await _repository.CS_005_GeraContasAPagar(parametros, ff040);
        });
    }

    [Fact]
    public async Task CS_005_GeraContasAPagar_ShouldThrowException_WhenFF043DoesNotExist()
    {
        // Arrange
        int tenantId = 1;
        long ff040Id = 3;
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

        var parametros = new CS_005_GeraContasAPagarParametros(
            InTenantID: tenantId,
            InFF040_ID: ff040Id,
            InStID_FF040Sit_Registrado: 1,
            InStID_FF102_Ent_Parcela: 2,
            InStID_FF102_Sit_Aberto: 3,
            InStID_FF102_Sit_Provisao: 4,
            InStID_FF102_Aut_PagamentoAutorizado: 5,
            InStID_FF102_Aut_PagamentoNaoAutorizado: 6,
            InStID_Entities_SIM: 7,
            InStID_Entities_NAO: 8,
            InFormaPgtoID: "",
            InCondicaoPgtoID: ""
        );

        // Act & Assert
        await Assert.ThrowsAsync<EmptyListException>(async () =>
        {
            await _repository.CS_005_GeraContasAPagar(parametros, ff040Entity);
        });
    }

    [Fact]
    public async Task CS_005_GeraContasAPagar_ShouldUpdateFF040_WhenAllEntitiesExist()
    {
        // Arrange
        int tenantId = 1;
        long ff040Id = 4;

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

        var parametros = new CS_005_GeraContasAPagarParametros(
            InTenantID: tenantId,
            InFF040_ID: ff040Id,
            InStID_FF040Sit_Registrado: 1,
            InStID_FF102_Ent_Parcela: 2,
            InStID_FF102_Sit_Aberto: 3,
            InStID_FF102_Sit_Provisao: 4,
            InStID_FF102_Aut_PagamentoAutorizado: 5,
            InStID_FF102_Aut_PagamentoNaoAutorizado: 6,
            InStID_Entities_SIM: 7,
            InStID_Entities_NAO: 8,
            InFormaPgtoID: "",
            InCondicaoPgtoID: ""
        );

        // Act
        await _repository.CS_005_GeraContasAPagar(parametros, ff040Entity);

        // Assert
        var updatedFF040 = await _context.OsusrE9aCsicpFf040s.FirstOrDefaultAsync(e => e.Ff040Id == ff040Id);
        Assert.NotNull(updatedFF040);
        Assert.Equal(1, updatedFF040.Ff040Situacaoid);
    }

    [Fact]
    public async Task CS_005_GeraContasAPagar_ShouldThrowException_WhenNoFF043Exists()
    {
        // Arrange
        int tenantId = 1;
        long ff040Id = 5;

        _context.OsusrE9aCsicpFf040s.Add(new CSICP_FF040
        {
            TenantId = tenantId,
            Ff040Id = ff040Id
        });

        var ff040 = await _context.OsusrE9aCsicpFf040s.Where(e => e.Ff040Id == ff040Id).FirstAsync();

        await _context.SaveChangesAsync();

        var parametros = new CS_005_GeraContasAPagarParametros(
            InTenantID: tenantId,
            InFF040_ID: ff040Id,
            InStID_FF040Sit_Registrado: 1,
            InStID_FF102_Ent_Parcela: 2,
            InStID_FF102_Sit_Aberto: 3,
            InStID_FF102_Sit_Provisao: 4,
            InStID_FF102_Aut_PagamentoAutorizado: 5,
            InStID_FF102_Aut_PagamentoNaoAutorizado: 6,
            InStID_Entities_SIM: 7,
            InStID_Entities_NAO: 8,
            InFormaPgtoID: "",
            InCondicaoPgtoID: ""
        );

        // Act & Assert
        await Assert.ThrowsAsync<EmptyListException>(async () =>
        {
            await _repository.CS_005_GeraContasAPagar(parametros, ff040);
        });
    }
}
