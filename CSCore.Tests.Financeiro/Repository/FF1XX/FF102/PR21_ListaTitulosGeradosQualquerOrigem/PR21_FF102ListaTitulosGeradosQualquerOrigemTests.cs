//using CSCore.Domain.CS_Models.CSICP_FF;
//using CSCore.Domain.CS_Models.Staticas.FF;
//using CSCore.Ifs.CS_Context;
//using CSCore.Ifs.FF.Repository.FF1XX.FF102.ListaTitulosGeradosQualquerOrigem;
//using CSCore.Ifs.FF.Repository.FF1XX.FF102.PR21_ListaTitulosGeradosQualquerOrigem;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Xunit;
//using Xunit.Abstractions;

//namespace CSCore.Tests.Financeiro.Repository.FF1XX.FF102.PR21_ListaTitulosGeradosQualquerOrigem
//{
//    public class PR21_FF102ListaTitulosGeradosQualquerOrigemTests : IDisposable
//    {
//        private readonly AppDbContext _context;
//        private readonly PR21_FF102ListaTitulosGeradosQualquerOrigem _repository;
//        private readonly ITestOutputHelper _output;

//        public PR21_FF102ListaTitulosGeradosQualquerOrigemTests(ITestOutputHelper output)
//        {
//            _output = output;

//            var options = new DbContextOptionsBuilder<AppDbContext>()
//                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
//                .LogTo(message => _output.WriteLine(message), new[] { DbLoggerCategory.Database.Command.Name })
//                .EnableSensitiveDataLogging()
//                .EnableDetailedErrors()
//                .Options;

//            _context = new AppDbContext(options);
//            _repository = new PR21_FF102ListaTitulosGeradosQualquerOrigem(_context);
//        }

//        public void Dispose()
//        {
//            _context.Dispose();
//        }

//        #region Setup Methods

//        private async Task SeedDatabaseAsync()
//        {
//            _output.WriteLine("=== INICIANDO SEED DO BANCO ===");

//            // Seed FF102Sit (situações)
//            var ff102SitAberto = new CSICP_FF102Sit
//            {
//                Id = 1,
//                Label = "Aberto",
//                Order = 1,
//                IsActive = true,
//                Codgcs = 1
//            };

//            var ff102SitBaixado = new CSICP_FF102Sit
//            {
//                Id = 2,
//                Label = "Baixado",
//                Order = 2,
//                IsActive = true,
//                Codgcs = 2
//            };

//            _context.OsusrE9aCsicpFf102Sits.AddRange(ff102SitAberto, ff102SitBaixado);

//            await _context.SaveChangesAsync();
//            _output.WriteLine("=== SEED CONCLUÍDO ===");
//        }

//        private CSICP_FF102 CreateFF102Entity(
//            string id,
//            int tipoRegistro,
//            int situacaoId,
//            string filialId = "FILIAL001",
//            string pfx = "PFX",
//            decimal noTitulo = 123456,
//            string sfx = "01")
//        {
//            return CSICP_FF102.CreateInstance(
//                tenantId: 1,
//                id: id,
//                ff102VlLiqTitulo: 1000m,
//                ff102Nodiasliberacao: 0,
//                ff102DataEmissao: DateTime.Now.AddDays(-30),
//                ff102DataVencimento: DateTime.Now.AddDays(30),
//                ff102Situacaoid: situacaoId,
//                ff102Tiporegistro: tipoRegistro,
//                ff102Filialid: filialId,
//                ff102Pfx: pfx,
//                ff102NoTitulo: noTitulo,
//                ff102Sfx: sfx
//            );
//        }

//        private CSICP_FF104 CreateFF104Entity(
//            string id,
//            string ff102Id,
//            string? dd040Id = null,
//            string? cc040Id = null,
//            string? cc030Id = null,
//            long? bf010Id = null,
//            long? ff040Id = null)
//        {
//            var ff104 = CSICP_FF104.CreateInstance(
//                tenantId: 1,
//                id: id,
//                filialID: "FILIAL001",
//                ff102_id: ff102Id,
//                ff040_id: ff040Id,
//                pfx: "PFX",
//                sfx: "01",
//                noTitulo: 123456,
//                nfNoCupom: 987654,
//                dataEmissao: DateOnly.FromDateTime(DateTime.Now.AddDays(-30)),
//                valorNF: 1000m
//            );

//            // Configurar os IDs específicos após a criação
//            ff104.Dd040Id = dd040Id;
//            ff104.Cc040Id = cc040Id;
//            ff104.Cc030Id = cc030Id;
//            ff104.Bf010Id = bf010Id;
//            ff104.Ff040Id = ff040Id;

//            return ff104;
//        }

//        #endregion

//        #region DD040 Tests

//        [Fact]
//        public async Task Execute_DD040Origin_ShouldReturnTitulosWithCorrectDD040Id()
//        {
//            _output.WriteLine("=== TESTE: Execute_DD040Origin_ShouldReturnTitulosWithCorrectDD040Id ===");

//            // Arrange
//            await SeedDatabaseAsync();
//            string dd040IdControle = "DD040_001";

//            _output.WriteLine($"ID de Controle: {dd040IdControle}");

//            // Criar FF102 com tipo registro 1 (a receber)
//            var ff102_1 = CreateFF102Entity("FF102_001", tipoRegistro: 1, situacaoId: 1);
//            var ff104_1 = CreateFF104Entity("FF104_001", ff102_1.Id, dd040Id: dd040IdControle);

//            // Criar FF102 com tipo registro 2 (a pagar) 
//            var ff102_2 = CreateFF102Entity("FF102_002", tipoRegistro: 2, situacaoId: 1);
//            var ff104_2 = CreateFF104Entity("FF104_002", ff102_2.Id, dd040Id: dd040IdControle);

//            // Criar FF102 com tipo registro 3 (não deve aparecer)
//            var ff102_3 = CreateFF102Entity("FF102_003", tipoRegistro: 3, situacaoId: 1);
//            var ff104_3 = CreateFF104Entity("FF104_003", ff102_3.Id, dd040Id: dd040IdControle);

//            // Criar FF102 com DD040Id diferente (não deve aparecer)
//            var ff102_4 = CreateFF102Entity("FF102_004", tipoRegistro: 1, situacaoId: 1);
//            var ff104_4 = CreateFF104Entity("FF104_004", ff102_4.Id, dd040Id: "DD040_OUTRO");

//            _output.WriteLine("Adicionando registros FF102 e FF104...");
//            _context.OsusrE9aCsicpFf102s.AddRange(ff102_1, ff102_2, ff102_3, ff102_4);
//            _context.OsusrE9aCsicpFf104s.AddRange(ff104_1, ff104_2, ff104_3, ff104_4);

//            await _context.SaveChangesAsync();
//            _output.WriteLine("Registros salvos no banco de dados");

//            // Act
//            _output.WriteLine("=== EXECUTANDO QUERY PRINCIPAL ===");
//            var result = await _repository.Execute(PR21_EnumTipoOrigem.csicp_dd040, dd040IdControle, 135, 1, 999);
//            _output.WriteLine("=== QUERY EXECUTADA ===");

//            // Assert
//            _output.WriteLine($"Resultado: {result.Item1} registros encontrados");

//            Assert.NotNull(result);
//            Assert.Equal(2, result.Count);

//            foreach (var titulo in result)
//            {
//                _output.WriteLine($"Título encontrado: {titulo.Id}, Tipo: {titulo.Ff102Tiporegistro}, DD040Id: {titulo.NavFF104?.Dd040Id}");
//                Assert.NotNull(titulo.NavFF104);
//                Assert.Equal(dd040IdControle, titulo.NavFF104.Dd040Id);
//                Assert.True(titulo.Ff102Tiporegistro == 1 || titulo.Ff102Tiporegistro == 2);
//            }

//            // Verificar se as situações foram carregadas
//            Assert.All(result, titulo =>
//            {
//                _output.WriteLine($"Situação do título {titulo.Id}: {titulo.NavFF102Sit?.Label}");
//                Assert.NotNull(titulo.NavFF102Sit);
//                Assert.NotNull(titulo.NavFF102Sit.Label);
//            });
//        }

//        [Fact]
//        public async Task Execute_DD040Origin_WithDifferentFilters_ShowsExactSQL()
//        {
//            _output.WriteLine("=== TESTE: Execute_DD040Origin_WithDifferentFilters_ShowsExactSQL ===");

//            await SeedDatabaseAsync();

//            // Teste 1: Query sem registros
//            _output.WriteLine("\n--- TESTE 1: Query sem registros ---");
//            var result1 = await _repository.Execute(PR21_EnumTipoOrigem.csicp_dd040, "INEXISTENTE");
//            _output.WriteLine($"Resultado: {result1.Count} registros");

//            // Criar alguns dados de teste
//            var ff102_1 = CreateFF102Entity("FF102_001", tipoRegistro: 1, situacaoId: 1);
//            var ff104_1 = CreateFF104Entity("FF104_001", ff102_1.Id, dd040Id: "DD040_TEST");

//            var ff102_2 = CreateFF102Entity("FF102_002", tipoRegistro: 2, situacaoId: 2);
//            var ff104_2 = CreateFF104Entity("FF104_002", ff102_2.Id, dd040Id: "DD040_TEST");

//            var ff102_3 = CreateFF102Entity("FF102_003", tipoRegistro: 3, situacaoId: 1);
//            var ff104_3 = CreateFF104Entity("FF104_003", ff102_3.Id, dd040Id: "DD040_TEST");

//            _context.OsusrE9aCsicpFf102s.AddRange(ff102_1, ff102_2, ff102_3);
//            _context.OsusrE9aCsicpFf104s.AddRange(ff104_1, ff104_2, ff104_3);
//            await _context.SaveChangesAsync();

//            // Teste 2: Query com filtros
//            _output.WriteLine("\n--- TESTE 2: Query com registros ---");
//            var result2 = await _repository.Execute(PR21_EnumTipoOrigem.csicp_dd040, "DD040_TEST");
//            _output.WriteLine($"Resultado: {result2.Count} registros");

//            foreach (var titulo in result2)
//            {
//                _output.WriteLine($"- ID: {titulo.Id}, Tipo: {titulo.Ff102Tiporegistro}, Situação: {titulo.NavFF102Sit?.Label}");
//            }

//            // Assert
//            Assert.Equal(2, result2.Count); // Deve retornar apenas tipos 1 e 2
//            Assert.All(result2, t => Assert.True(t.Ff102Tiporegistro == 1 || t.Ff102Tiporegistro == 2));
//        }

//        [Fact]
//        public async Task Execute_DD040Origin_AnalyzeQueryPerformance()
//        {
//            _output.WriteLine("=== TESTE DE PERFORMANCE: Execute_DD040Origin_AnalyzeQueryPerformance ===");

//            await SeedDatabaseAsync();

//            // Criar dataset maior para análise de performance
//            var ff102List = new List<CSICP_FF102>();
//            var ff104List = new List<CSICP_FF104>();

//            _output.WriteLine("Criando 50 registros para teste de performance...");

//            for (int i = 1; i <= 50; i++)
//            {
//                var ff102 = CreateFF102Entity($"FF102_{i:000}",
//                    tipoRegistro: i % 3 == 0 ? 3 : (i % 2 == 0 ? 2 : 1),
//                    situacaoId: i % 2 == 0 ? 2 : 1,
//                    noTitulo: i);

//                var dd040Id = i <= 25 ? "DD040_PERF_TEST" : "DD040_OTHER";
//                var ff104 = CreateFF104Entity($"FF104_{i:000}", ff102.Id, dd040Id: dd040Id);

//                ff102List.Add(ff102);
//                ff104List.Add(ff104);
//            }

//            _context.OsusrE9aCsicpFf102s.AddRange(ff102List);
//            _context.OsusrE9aCsicpFf104s.AddRange(ff104List);
//            await _context.SaveChangesAsync();

//            _output.WriteLine("Registros criados. Executando query...");

//            // Executar query e medir tempo
//            var startTime = DateTime.UtcNow;
//            _output.WriteLine("=== INÍCIO DA EXECUÇÃO DA QUERY ===");

//            var result = await _repository.Execute(PR21_EnumTipoOrigem.csicp_dd040, "DD040_PERF_TEST");

//            _output.WriteLine("=== FIM DA EXECUÇÃO DA QUERY ===");
//            var executionTime = DateTime.UtcNow - startTime;

//            _output.WriteLine($"Tempo de execução: {executionTime.TotalMilliseconds} ms");
//            _output.WriteLine($"Registros retornados: {result.Count}");

//            // Análise dos resultados
//            var tipoRegistroCount = result.GroupBy(r => r.Ff102Tiporegistro)
//                                         .ToDictionary(g => g.Key, g => g.Count());

//            foreach (var kvp in tipoRegistroCount)
//            {
//                _output.WriteLine($"Tipo Registro {kvp.Key}: {kvp.Value} registros");
//            }

//            // Verificar que apenas tipos 1 e 2 foram retornados
//            Assert.All(result, r => Assert.True(r.Ff102Tiporegistro == 1 || r.Ff102Tiporegistro == 2));
//            Assert.True(result.Count > 0, "Deveria retornar alguns registros");
//            Assert.True(executionTime.TotalSeconds < 2, $"Query muito lenta: {executionTime.TotalSeconds}s");
//        }

//        #endregion

//        #region Exception Tests

//        [Fact]
//        public async Task Execute_UnsupportedOriginType_ShouldThrowNotImplementedException()
//        {
//            _output.WriteLine("=== TESTE: Execute_UnsupportedOriginType_ShouldThrowNotImplementedException ===");

//            // Arrange
//            await SeedDatabaseAsync();
//            string idControle = "TESTE_001";

//            _output.WriteLine($"Testando origem não suportada: {PR21_EnumTipoOrigem.csicp_cc040}");

//            // Act & Assert
//            var exception = await Assert.ThrowsAsync<NotImplementedException>(() =>
//                _repository.Execute(PR21_EnumTipoOrigem.csicp_cc040, idControle));

//            _output.WriteLine($"Exceção capturada corretamente: {exception.Message}");
//        }

//        #endregion
//    }
//}