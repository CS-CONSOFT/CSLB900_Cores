using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;
using CSCore.Ex.Personalizada;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102.Parametros;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CSCore.Tests.Financeiro.Repository.Processos
{
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

            // Setup mocks
            _mockGenerateId.SetupSequence(x => x.GenerateUuId())
                .Returns("ff102-uuid-1")
                .Returns("ff104-uuid-1"); // One for FF102, one for FF104

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

            var parametros = new CS_005_GeraContasAPagarParametros(
                InTenantID: tenantId,
                InFF040_ID: ff040Id,
                InStID_FF040Sit_Registrado: situacaoRegistrado,
                InStID_FF102_Ent_Parcela: stIdFf102EntParcela,
                InStID_FF102_Sit_Aberto: stIdFf102SitAberto,
                InStID_FF102_Sit_Provisao: stIdFf102SitProvisao,
                InStID_FF102_Aut_PagamentoAutorizado: stIdFf102AutPagamentoAutorizado,
                InStID_FF102_Aut_PagamentoNaoAutorizado: stIdFf102AutPagamentoNaoAutorizado,
                InStID_Entities_SIM: stIdEntitiesSim,
                InStID_Entities_NAO: stIdEntitiesNao,
            InFormaPgtoID: "",
            InCondicaoPgtoID: ""
            );

            var ff040 = await _context.OsusrE9aCsicpFf040s.FirstAsync(f => f.Ff040Id == ff040Id);
            // Act & Assert
            await Assert.ThrowsAsync<EmptyListException>(async () =>
            {
                await _repository.CS_005_GeraContasAPagar(parametros, ff040);
            });
        }

        [Fact]
        public async Task CS_005_GeraContasAPagar_ShouldCreateFF102AndFF104_WhenDataIsValid()
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

            // FF040 (movimento)
            var ff040 = new CSICP_FF040
            {
                TenantId = tenantId,
                Ff040Id = ff040Id,
                Ff040Tiporegistro = 3,
                Ff040Protocolnumber = "123456",
                Ff040Texto = "Teste título",
                Ff040Empresaid = "EMPR",
                Ff040ContaId = "CONTA",
                Ff040CcustoId = "CCUSTO",
                Ff040UsuarioProprId = "USRPROP",
                Ff040AgcobradorId = "COBRADOR",
                Ff040ResponsavelId = "RESP",
                Ff040DataMovimento = new DateTime(2025, 1, 1),
                Ff040Isprovisao = false,
                Ff040EspecieId = "99",
                Ff040Vtransacao = 100m,
                Ff040Dbasevencto = new DateTime(2025, 1, 10)
            };
            _context.OsusrE9aCsicpFf040s.Add(ff040);

            // FF042 (forma de pagamento) -- use Create factory
            var ff042 = CSICP_FF042.Create(
                ff040Entity: ff040,
                formaPgtoID: "FORMA1",
                condicaoPgtoID: "COND1",
                NroParcelas: 1
            );
            _context.OsusrE9aCsicpFf042s.Add(ff042);

            // FF043 (memória de cálculo) -- use Create factory
            var ff043 = CSICP_FF043.Create(
                InTenantID: tenantId,
                InFf042Id: ff042.Ff042Id,
                ValorParcela: 123.45M,
                Parcela: 1,
                DataVencimento: new DateTime(2025, 2, 2),
                Pfxtitulo: "PFX",
                Protocolo: 1001
            );
            ff043.Ff043Id = 3;
            _context.OsusrE9aCsicpFf043s.Add(ff043);

            // FF000 (desabilita FCConfAut)
            _context.OsusrE9aCsicpFf000s.Add(new CSICP_FF000
            {
                Ff000Id = "zzzz",
                TenantId = tenantId,
                Ff000EstabId = "EMPR",
                Ff000Isdesabfcconfaut = false
            });




            await _context.SaveChangesAsync();

            var parametros = new CS_005_GeraContasAPagarParametros(
                InTenantID: tenantId,
                InFF040_ID: ff040Id,
                InStID_FF040Sit_Registrado: situacaoRegistrado,
                InStID_FF102_Ent_Parcela: stIdFf102EntParcela,
                InStID_FF102_Sit_Aberto: stIdFf102SitAberto,
                InStID_FF102_Sit_Provisao: stIdFf102SitProvisao,
                InStID_FF102_Aut_PagamentoAutorizado: stIdFf102AutPagamentoAutorizado,
                InStID_FF102_Aut_PagamentoNaoAutorizado: stIdFf102AutPagamentoNaoAutorizado,
                InStID_Entities_SIM: stIdEntitiesSim,
                InStID_Entities_NAO: stIdEntitiesNao,
            InFormaPgtoID: "",
            InCondicaoPgtoID: ""
            );

            // Act
            await _repository.CS_005_GeraContasAPagar(parametros, ff040);

            // Assert
            var ff043Reloaded = _context.OsusrE9aCsicpFf043s.First();
            Assert.Equal("ff102-uuid-1", ff043Reloaded.Ff043TituloCpId); // Titulo criado corretamente

            // Obs: FF102 e FF104 são criados apenas em memória, não persistidos no banco nesse método.
            // Para persistência, seria necessário adicionar um SaveChangesAsync no método de produção.
            // Se desejar testar persistência, ajuste o production code!
        }
    }
}