using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral;
using CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.StrategyCalculaImposto.Dtos;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_DD;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Tests.Geral.MontaXmlCalculoRegimeGeral
{
    public class MontaXmlCalculoRegimeGeralTeste : IDisposable
    {
        private readonly AppDbContext _context;
        private readonly MontaXmlCalculoRegimeGeral _montaXml;

        public MontaXmlCalculoRegimeGeralTeste()
        {
            // Configura o contexto em memória
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: $"TestDb_{Guid.NewGuid()}")
                .Options;

            _context = new AppDbContext(options);
            _montaXml = new MontaXmlCalculoRegimeGeral(_context);

            // Seed dos dados de teste
            SeedTestData();
        }

        private void SeedTestData()
        {
            const int tenantId = 1;
            const string notaId = "NOTA001";

            // Dados estáticos
            var tpTriSimples = new E9ACSICP_BB001Tptri { Id = 1, Label = "Simples" };
            var impPis = new E9ACSICP_AA037Imp { Id = 1, Label = "PIS" };
            var impCofins = new E9ACSICP_AA037Imp { Id = 2, Label = "COFINS" };
            var impIss = new E9ACSICP_AA037Imp { Id = 3, Label = "ISS" };
            var impII = new E9ACSICP_AA037Imp { Id = 4, Label = "Imposto Importação" };
            var estaticaSim = new E9ACSICP_Statica { Id = 1, Label = "SIM" };

            _context.E9ACSICP_BB001Tptris.Add(tpTriSimples);
            _context.E9ACSICP_AA037Imps.AddRange(impPis, impCofins, impIss, impII);
            _context.E9ACSICP_Statica.Add(estaticaSim);

            // Empresa e Configuração Fiscal
            var empresa = new E9ACSICP_BB001 { Id = "EMP001" };
            var cfgFiscal = new E9ACSICP_BB001Cfgfi { Bb001EmpresaId = "EMP001", Bb001TptributacaoId = 1 };

            _context.E9ACSICP_BB001s.Add(empresa);
            _context.E9ACSICP_BB001Cfgfis.Add(cfgFiscal);

            // Conta (Cliente/Fornecedor)
            var conta = new OsusrE9aCsicpBb012 { Id = "CONTA001", bb012_RFEspecial_ID = "RFESP001" };
            var contaCidade = new OsusrE9aCsicpBb01206
            {
                Bb012Id = "CONTA001",
                Bb012CodigoCidade = 1,
                Bb012Uf = 1
            };
            var cidade = new OsusrE9aCsicpAa028 { Id = 1 };
            var uf = new OsusrE9aCsicpAa027 { Id = 1 };

            _context.OsusrE9aCsicpBb012s.Add(conta);
            _context.OsusrE9aCsicpBb01206s.Add(contaCidade);
            _context.OsusrE9aCsicpAa028s.Add(cidade);
            _context.OsusrE9aCsicpAa027s.Add(uf);

            // Nota Fiscal
            var tipoNota = new OsusrTeiCsicpDd040Tnt { Id = 1 };
            var nota = new OsusrTeiCsicpDd040
            {
                TenantId = tenantId,
                Dd040Id = notaId,
                Dd040Empresaid = "EMP001",
                Dd040ContaId = "CONTA001",
                Dd040TiponotaId = 1,
                DD040_TPDEBCREID = null
            };

            _context.OsusrTeiCsicpDd040Tnts.Add(tipoNota);
            _context.OsusrTeiCsicpDd040s.Add(nota);

            // Produto
            var produto = new OsusrE9aCsicpGg008 { Id = "PROD001", Gg008Ncmid = "NCM001" };
            var kardex = new OsusrE9aCsicpGg008Kdx { Gg008Kardexid = "KDX001", Gg008Produtoid = "PROD001" };
            var saldo = new OsusrE9aCsicpGg520
            {
                Id = "SALDO001",
                TenantId = tenantId,
                Gg520KardexId = "KDX001"
            };
            var ncm = new OsusrE9aCsicpGg021 { Id = "NCM001" };
            var unidade = new OsusrE9aCsicpGg007 { Id = "UN001" };

            _context.OsusrE9aCsicpGg008s.Add(produto);
            _context.OsusrE9aCsicpGg008Kdxes.Add(kardex);
            _context.OsusrE9aCsicpGg520s.Add(saldo);
            _context.OsusrE9aCsicpGg021s.Add(ncm);
            _context.OsusrE9aCsicpGg007s.Add(unidade);

            // Item da Nota (DD060 e DD061)
            var itemNota = new OsusrTeiCsicpDd060
            {
                Dd060Id = "ITEM001",
                Dd040Id = notaId,
                Dd060Saldoid = "SALDO001",
                Dd060UnId = "UN001",
                DD060_RFTRANSACAO_ID = "RFTRANS001",
                Dd060Isfixarcalcimp = false
            };

            var impostoItem = new OsusrTeiCsicpDd061
            {
                Dd060Id = "ITEM001",
                Dd061ImpostoId = 1,  // PIS
                Dd061Valorimposto = 100.00m
            };

            _context.OsusrTeiCsicpDd060s.Add(itemNota);
            _context.OsusrTeiCsicpDd061s.Add(impostoItem);

            // Regras Fiscais
            var regraFiscal = new OsusrE9aCsicpBb027Imp
            {
                Bb027Id = "RFTRANS001",
                Bb027bRflcId = "RFESP001",
                Bb027bUfDestId = null,
                Bb027bClassecontaId = null,
                Bb027bMp255Id = null,
                Bb027bMotdesoneracaoid = null,
                Bb027bRfclasstribId = 1,
                Bb027bIsRfclasstribId2 = 2,
                Bb027bTpdebcreid = 1
            };

            var classeTributaria = new OsusrE9aCsicpAa144 { Id = 1 };
            var classeTributariaIS = new OsusrE9aCsicpAa144 { Id = 2 };

            _context.OsusrE9aCsicpBb027Imps.Add(regraFiscal);
            _context.OsusrE9aCsicpAa144s.AddRange(classeTributaria, classeTributariaIS);

            _context.SaveChanges();
        }

        [Fact]
        public async Task CSRF01_Calculadora_OffLine_MontaDD040_DeveExecutarSemErro()
        {
            // Arrange
            const string notaId = "NOTA001";
            const int tenantId = 1;

            // Act
            await _montaXml.CSRF01_Calculadora_OffLine_MontaDD040(notaId, tenantId);

            // Assert
            var nota = await _context.OsusrTeiCsicpDd040s
                .FirstOrDefaultAsync(n => n.Dd040Id == notaId);

            Assert.NotNull(nota);
            Assert.Equal(1, nota.DD040_TPDEBCREID);
        }

        [Fact]
        public async Task CSRF01_Calculadora_OffLine_MontaDD040_NotaNaoEncontrada_DeveLancarException()
        {
            // Arrange
            const string notaIdInexistente = "NOTA_INEXISTENTE";
            const int tenantId = 1;

            // Act & Assert
            await Assert.ThrowsAsync<KeyNotFoundException>(
                () => _montaXml.CSRF01_Calculadora_OffLine_MontaDD040(notaIdInexistente, tenantId));
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}