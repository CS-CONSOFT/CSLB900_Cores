using CSCore.Domain.Interfaces.FF.IVisoesGeraisFinanceiro;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.VisoesGeraisFinanceiro;
using GG104Materiais.C82Application.Service.VisoesGeraisFinanceiroService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace CSLB900.MSToolsTestes
{
    public class InadimplenciaServiceTests
    {
        private readonly string _connectionString;

        public InadimplenciaServiceTests()
        {
            var config = new ConfigurationBuilder()
              .AddUserSecrets<InadimplenciaServiceTests>()
              .Build();
            var connectionString = config.GetConnectionString("DefaultConnection");
            _connectionString = connectionString;
        }

        [Fact]
        public async Task InadimplenciaService_DeveFuncionar()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                 .UseSqlServer(_connectionString)
                 .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                 .Options;
            var context = new AppDbContext(options);
            
            var repository = new InadimplenciaRepository(context);
            var service = new InadimplenciaService(repository);

            // Arrange - Configurar período de teste (últimos 2 anos)
            var dataAtual = DateTime.Now.Date;
            var dataInicio = dataAtual.AddYears(-2);
            var dataFim = dataAtual;

            var request = new DtoInadimplenciaRequest
            {
                TenantId = 135,
                DataInicio = dataInicio,
                DataFim = dataFim,
                FiltroEstabelecimentos = null // Todos os estabelecimentos
            };

            Console.WriteLine($"=== TESTE INADIMPLÊNCIA - TENANT {request.TenantId} ===");
            Console.WriteLine($"Período: {dataInicio:dd/MM/yyyy} a {dataFim:dd/MM/yyyy}");
            Console.WriteLine();

            // Act - Teste da consulta de inadimplência
            var resultado = await service.GetInadimplenciaAsync(request);
            
            // Serializar resultado para visualização
            var jsonResultado = JsonSerializer.Serialize(resultado, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine("=== DADOS DE INADIMPLÊNCIA ===");
            Console.WriteLine(jsonResultado);
            Console.WriteLine();

            // Assert
            Assert.NotNull(resultado);
            
            if (resultado.Any())
            {
                Console.WriteLine("=== RESUMO ESTATÍSTICO ===");
                
                var totalTitulos = resultado.Sum(r => r.QuantidadeTitulosTotal);
                var totalValor = resultado.Sum(r => r.ValorTitulosTotal);
                var totalLiquidados = resultado.Sum(r => r.QuantidadeTitulosLiquidados);
                var totalValorLiquidados = resultado.Sum(r => r.ValorTitulosLiquidados);
                var totalInadimplentes = resultado.Sum(r => r.QuantidadeTitulosInadimplentes);
                var totalValorInadimplentes = resultado.Sum(r => r.ValorTitulosInadimplentes);
                var percentualGeralInadimplencia = totalTitulos > 0 ? (decimal)totalInadimplentes / totalTitulos * 100 : 0;
                
                Console.WriteLine($"Total de títulos no período: {totalTitulos:N0}");
                Console.WriteLine($"Valor total dos títulos: {totalValor:C}");
                Console.WriteLine($"Títulos liquidados: {totalLiquidados:N0} ({(totalTitulos > 0 ? (decimal)totalLiquidados / totalTitulos * 100 : 0):F2}%)");
                Console.WriteLine($"Valor liquidado: {totalValorLiquidados:C}");
                Console.WriteLine($"Títulos inadimplentes: {totalInadimplentes:N0} ({percentualGeralInadimplencia:F2}%)");
                Console.WriteLine($"Valor inadimplente: {totalValorInadimplentes:C}");
                Console.WriteLine();

                // Verificar estrutura dos dados
                var primeiroItem = resultado.First();
                Assert.True(primeiroItem.Ano > 0, "Ano deve ser maior que zero");
                Assert.True(primeiroItem.Mes >= 1 && primeiroItem.Mes <= 12, "Mês deve estar entre 1 e 12");
                Assert.False(string.IsNullOrEmpty(primeiroItem.AnoMes), "AnoMes não deve estar vazio");
                Assert.True(primeiroItem.QuantidadeTitulosTotal >= 0, "Quantidade de títulos deve ser >= 0");
                Assert.True(primeiroItem.ValorTitulosTotal >= 0, "Valor total deve ser >= 0");
                Assert.True(primeiroItem.PercentualInadimplencia >= 0 && primeiroItem.PercentualInadimplencia <= 100, 
                    "Percentual de inadimplência deve estar entre 0 e 100");

                Console.WriteLine("=== ANÁLISE POR PERÍODO ===");
                foreach (var item in resultado.OrderBy(r => r.Ano).ThenBy(r => r.Mes).Take(10))
                {
                    Console.WriteLine($"{item.AnoMes}: {item.QuantidadeTitulosTotal} títulos, " +
                                    $"{item.QuantidadeTitulosInadimplentes} inadimplentes ({item.PercentualInadimplencia:F2}%), " +
                                    $"Valor: {item.ValorTitulosTotal:C}");
                }

                if (resultado.Count > 10)
                {
                    Console.WriteLine($"... e mais {resultado.Count - 10} períodos");
                }

                // Encontrar período com maior inadimplência
                var maiorInadimplencia = resultado.OrderByDescending(r => r.PercentualInadimplencia).First();
                Console.WriteLine();
                Console.WriteLine($"=== PERÍODO COM MAIOR INADIMPLÊNCIA ===");
                Console.WriteLine($"{maiorInadimplencia.AnoMes}: {maiorInadimplencia.PercentualInadimplencia:F2}% " +
                                $"({maiorInadimplencia.QuantidadeTitulosInadimplentes} de {maiorInadimplencia.QuantidadeTitulosTotal} títulos)");
            }
            else
            {
                Console.WriteLine("Nenhum dado de inadimplência encontrado para o período informado.");
            }
        }

        [Fact]
        public async Task InadimplenciaService_ComFiltroEstabelecimento_DeveFuncionar()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                 .UseSqlServer(_connectionString)
                 .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                 .Options;
            var context = new AppDbContext(options);
            
            var repository = new InadimplenciaRepository(context);
            var service = new InadimplenciaService(repository);

            // Arrange - Teste com filtro específico de estabelecimentos
            var dataAtual = DateTime.Now.Date;
            var request = new DtoInadimplenciaRequest
            {
                TenantId = 135,
                DataInicio = dataAtual.AddYears(-1),
                DataFim = dataAtual,
                FiltroEstabelecimentos = new List<string> { "00001" } // Estabelecimento específico
            };

            Console.WriteLine($"=== TESTE INADIMPLÊNCIA COM FILTRO - TENANT {request.TenantId} ===");
            Console.WriteLine($"Estabelecimentos: {string.Join(", ", request.FiltroEstabelecimentos)}");
            Console.WriteLine($"Período: {request.DataInicio:dd/MM/yyyy} a {request.DataFim:dd/MM/yyyy}");
            Console.WriteLine();

            // Act
            var resultado = await service.GetInadimplenciaAsync(request);
            
            var jsonResultado = JsonSerializer.Serialize(resultado, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine("=== DADOS COM FILTRO DE ESTABELECIMENTO ===");
            Console.WriteLine(jsonResultado);

            // Assert
            Assert.NotNull(resultado);
            
            if (resultado.Any())
            {
                Console.WriteLine();
                Console.WriteLine($"=== RESUMO PARA ESTABELECIMENTO(S) FILTRADO(S) ===");
                Console.WriteLine($"Períodos encontrados: {resultado.Count}");
                Console.WriteLine($"Total de títulos: {resultado.Sum(r => r.QuantidadeTitulosTotal):N0}");
                Console.WriteLine($"Total inadimplentes: {resultado.Sum(r => r.QuantidadeTitulosInadimplentes):N0}");
                
                var percentualMedio = resultado.Where(r => r.QuantidadeTitulosTotal > 0)
                                              .Average(r => r.PercentualInadimplencia);
                Console.WriteLine($"Percentual médio de inadimplência: {percentualMedio:F2}%");
            }
            else
            {
                Console.WriteLine("Nenhum dado encontrado para os estabelecimentos filtrados.");
            }
        }

        [Fact]
        public async Task InadimplenciaService_ValidarPeriodoPersonalizado_DeveFuncionar()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                 .UseSqlServer(_connectionString)
                 .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                 .Options;
            var context = new AppDbContext(options);
            
            var repository = new InadimplenciaRepository(context);
            var service = new InadimplenciaService(repository);

            // Arrange - Teste com período específico
            var request = new DtoInadimplenciaRequest
            {
                TenantId = 135,
                DataInicio = new DateTime(2024, 1, 1),
                DataFim = new DateTime(2024, 6, 30),
                FiltroEstabelecimentos = null
            };

            Console.WriteLine($"=== TESTE PERÍODO PERSONALIZADO - PRIMEIRO SEMESTRE 2024 ===");
            Console.WriteLine($"TenantId: {request.TenantId}");
            Console.WriteLine($"Período: {request.DataInicio:dd/MM/yyyy} a {request.DataFim:dd/MM/yyyy}");
            Console.WriteLine();

            // Act
            var resultado = await service.GetInadimplenciaAsync(request);
            
            // Assert
            Assert.NotNull(resultado);
            
            if (resultado.Any())
            {
                // Verificar se todos os resultados estão dentro do período solicitado
                foreach (var item in resultado)
                {
                    var dataItem = new DateTime(item.Ano, item.Mes, 1);
                    Assert.True(dataItem >= request.DataInicio, $"Data {item.AnoMes} deve ser >= {request.DataInicio:MM/yyyy}");
                    Assert.True(dataItem <= request.DataFim, $"Data {item.AnoMes} deve ser <= {request.DataFim:MM/yyyy}");
                }
                
                Console.WriteLine($"=== INADIMPLÊNCIA NO PRIMEIRO SEMESTRE 2024 ===");
                foreach (var item in resultado.OrderBy(r => r.Mes))
                {
                    var mesNome = new DateTime(2024, item.Mes, 1).ToString("MMMM");
                    Console.WriteLine($"{mesNome}: {item.PercentualInadimplencia:F2}% " +
                                    $"({item.QuantidadeTitulosInadimplentes}/{item.QuantidadeTitulosTotal} títulos)");
                }
                
                Console.WriteLine();
                Console.WriteLine("✓ Todos os períodos estão dentro do intervalo solicitado");
            }
            else
            {
                Console.WriteLine("Nenhum dado encontrado para o período especificado.");
            }
        }

        [Fact]
        public async Task InadimplenciaService_ValidarCalculos_DeveFuncionar()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                 .UseSqlServer(_connectionString)
                 .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                 .Options;
            var context = new AppDbContext(options);
            
            var repository = new InadimplenciaRepository(context);
            var service = new InadimplenciaService(repository);

            // Arrange
            var request = new DtoInadimplenciaRequest
            {
                TenantId = 135,
                DataInicio = DateTime.Now.AddMonths(-6),
                DataFim = DateTime.Now
            };

            Console.WriteLine("=== TESTE DE VALIDAÇÃO DOS CÁLCULOS ===");

            // Act
            var resultado = await service.GetInadimplenciaAsync(request);
            
            // Assert
            Assert.NotNull(resultado);
            
            foreach (var item in resultado)
            {
                // Validar que a soma dos liquidados + inadimplentes não excede o total
                Assert.True(item.QuantidadeTitulosLiquidados + item.QuantidadeTitulosInadimplentes <= item.QuantidadeTitulosTotal,
                    $"Soma liquidados + inadimplentes não pode exceder total em {item.AnoMes}");
                
                // Validar percentual de inadimplência
                if (item.QuantidadeTitulosTotal > 0)
                {
                    var percentualCalculado = Math.Round((decimal)item.QuantidadeTitulosInadimplentes / item.QuantidadeTitulosTotal * 100, 2);
                    Assert.Equal(percentualCalculado, item.PercentualInadimplencia);
                }
                else
                {
                    Assert.Equal(0, item.PercentualInadimplencia);
                }
                
                // Validar que valores são não-negativos
                Assert.True(item.ValorTitulosTotal >= 0, $"Valor total deve ser >= 0 em {item.AnoMes}");
                Assert.True(item.ValorTitulosLiquidados >= 0, $"Valor liquidados deve ser >= 0 em {item.AnoMes}");
                Assert.True(item.ValorTitulosInadimplentes >= 0, $"Valor inadimplentes deve ser >= 0 em {item.AnoMes}");
            }
            
            Console.WriteLine($"✓ Validações matemáticas passaram para {resultado.Count} períodos");
            
            if (resultado.Any())
            {
                Console.WriteLine();
                Console.WriteLine("=== CONSISTÊNCIA DOS DADOS ===");
                
                var totalPeriodos = resultado.Count;
                var periodosComTitulos = resultado.Count(r => r.QuantidadeTitulosTotal > 0);
                var periodosComInadimplencia = resultado.Count(r => r.QuantidadeTitulosInadimplentes > 0);
                
                Console.WriteLine($"Períodos analisados: {totalPeriodos}");
                Console.WriteLine($"Períodos com títulos: {periodosComTitulos}");
                Console.WriteLine($"Períodos com inadimplência: {periodosComInadimplencia}");
                
                if (periodosComTitulos > 0)
                {
                    var percentualPeriodosComInadimplencia = (decimal)periodosComInadimplencia / periodosComTitulos * 100;
                    Console.WriteLine($"% períodos com inadimplência: {percentualPeriodosComInadimplencia:F1}%");
                }
            }
        }
    }
}