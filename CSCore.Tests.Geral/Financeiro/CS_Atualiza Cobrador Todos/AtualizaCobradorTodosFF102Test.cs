using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Atualiza_Cobrador_Todos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CSCore.Tests.Geral.Financeiro.CS_Atualiza_Cobrador_Todos
{
    public class AtualizaCobradorTodosFF102Test : IDisposable
    {
        private readonly AppDbContext _context;
        private readonly IAtualizaCobradorTodosFF102 _service;
        private readonly string _connectionString;
        private readonly int _tenantId = 135;

        public AtualizaCobradorTodosFF102Test()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<AtualizaCobradorTodosFF102Test>()
                .Build();
            var connectionString = config.GetConnectionString("DefaultConnection");
            _connectionString = connectionString ?? throw new ArgumentNullException("Connection string não encontrada");

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(_connectionString)
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                .Options;

            _context = new AppDbContext(options);
            _service = new AtualizaCobradorTodosFF102(_context);
        }

        [Fact]
        public async Task Atualiza_Cobrador_Todos_ParametroNulo_DeveThrowArgumentNullException()
        {
            // Act & Assert
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => _service.Atualiza_Cobrador_Todos(null));
            Assert.Contains("Value cannot be null", exception.Message);
        }

        [Fact]
        public async Task Atualiza_Cobrador_Todos_FF011NaoEncontrada_DeveThrowKeyNotFoundException()
        {
            // Arrange - Remove todos os registros FF011 temporariamente
            var ff011Existentes = await _context.OsusrE9aCsicpFf011s
                .Where(x => x.TenantId == _tenantId)
                .ToListAsync();

            if (ff011Existentes.Any())
            {
                _context.OsusrE9aCsicpFf011s.RemoveRange(ff011Existentes);
                await _context.SaveChangesAsync();
            }

            var parametro = CriarParametroTeste();

            try
            {
                // Act & Assert
                var exception = await Assert.ThrowsAsync<KeyNotFoundException>(() => _service.Atualiza_Cobrador_Todos(parametro));
                Assert.Contains("FF011 não encontrada", exception.Message);
            }
            finally
            {
                // Cleanup - Restaura os registros FF011 se existiam
                if (ff011Existentes.Any())
                {
                    _context.OsusrE9aCsicpFf011s.AddRange(ff011Existentes);
                    await _context.SaveChangesAsync();
                }
            }
        }

        [Fact]
        public async Task Atualiza_Cobrador_Todos_ComTitulosEncontrados_DeveAtualizarCobrador()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            
            // Garante que existe pelo menos um FF011 para o teste
            await GarantirFF011Existe();

            // Busca títulos que atendem aos critérios antes da atualização
            var titulosAntesAtualizacao = await BuscarTitulosQueAtendemCriterios(parametro);
            
            if (!titulosAntesAtualizacao.Any())
            {
                Console.WriteLine("Nenhum título encontrado que atenda aos critérios. Teste será ignorado.");
                return; // Skip do teste se não houver dados
            }

            // Guarda os valores originais para restaurar depois
            var valoresOriginais = titulosAntesAtualizacao.Select(t => new 
            {
                Id = t.Id,
                AgCobradorIdOriginal = t.Ff102Agcobradorid,
                CodCobradorOriginal = t.Ff102Codcobrador
            }).ToList();

            Console.WriteLine($"Encontrados {titulosAntesAtualizacao.Count} títulos para atualizar");

            try
            {
                // Act
                await _service.Atualiza_Cobrador_Todos(parametro);

                // Assert
                var titulosAposAtualizacao = await _context.OsusrE9aCsicpFf102s
                    .Where(t => valoresOriginais.Select(v => v.Id).Contains(t.Id))
                    .ToListAsync();

                foreach (var titulo in titulosAposAtualizacao)
                {
                    Assert.Equal(parametro.InBB006_CobradorID, titulo.Ff102Agcobradorid);
                    Assert.Equal(parametro.InBB006_CodigoCobrador, titulo.Ff102Codcobrador);
                }

                Console.WriteLine($"Sucesso: {titulosAposAtualizacao.Count} títulos atualizados com o novo cobrador");
            }
            finally
            {
                // Cleanup - Restaura os valores originais
                foreach (var valorOriginal in valoresOriginais)
                {
                    var titulo = await _context.OsusrE9aCsicpFf102s.FindAsync(valorOriginal.Id);
                    if (titulo != null)
                    {
                        titulo.Ff102Agcobradorid = valorOriginal.AgCobradorIdOriginal;
                        titulo.Ff102Codcobrador = valorOriginal.CodCobradorOriginal;
                    }
                }
                await _context.SaveChangesAsync();
                Console.WriteLine("Valores originais restaurados");
            }
        }

        [Fact]
        public async Task Atualiza_Cobrador_Todos_ComFiltros_DeveRespeitarCriterios()
        {
            // Arrange
            var parametro = CriarParametroTeste();
            await GarantirFF011Existe();

            // Busca um título específico que atenda aos critérios
            var tituloTeste = await BuscarTituloEspecificoParaTeste(parametro);
            
            if (tituloTeste == null)
            {
                Console.WriteLine("Nenhum título específico encontrado para teste de filtros. Teste será ignorado.");
                return;
            }

            // Guarda valores originais
            var agCobradorOriginal = tituloTeste.Ff102Agcobradorid;
            var codCobradorOriginal = tituloTeste.Ff102Codcobrador;

            Console.WriteLine($"Testando filtros com título ID: {tituloTeste.Id}");
            Console.WriteLine($"- Data Vencimento: {tituloTeste.Ff102DataVencimento:dd/MM/yyyy}");
            Console.WriteLine($"- Situação: {tituloTeste.Ff102Situacaoid}");
            Console.WriteLine($"- Tipo Cobrança: {tituloTeste.Ff102Tpcobranca}");

            try
            {
                // Act
                await _service.Atualiza_Cobrador_Todos(parametro);

                // Assert
                var tituloAtualizado = await _context.OsusrE9aCsicpFf102s.FindAsync(tituloTeste.Id);
                Assert.NotNull(tituloAtualizado);
                
                // Verifica se foi atualizado (se atendia aos critérios)
                if (AtendeCriterios(tituloTeste, parametro))
                {
                    Assert.Equal(parametro.InBB006_CobradorID, tituloAtualizado.Ff102Agcobradorid);
                    Assert.Equal(parametro.InBB006_CodigoCobrador, tituloAtualizado.Ff102Codcobrador);
                    Console.WriteLine("✓ Título atualizado conforme esperado");
                }
                else
                {
                    Assert.Equal(agCobradorOriginal, tituloAtualizado.Ff102Agcobradorid);
                    Assert.Equal(codCobradorOriginal, tituloAtualizado.Ff102Codcobrador);
                    Console.WriteLine("✓ Título não foi atualizado (não atendia aos critérios)");
                }
            }
            finally
            {
                // Cleanup
                var titulo = await _context.OsusrE9aCsicpFf102s.FindAsync(tituloTeste.Id);
                if (titulo != null)
                {
                    titulo.Ff102Agcobradorid = agCobradorOriginal;
                    titulo.Ff102Codcobrador = codCobradorOriginal;
                    await _context.SaveChangesAsync();
                }
            }
        }

        private async Task<List<CSICP_FF102>> BuscarTitulosQueAtendemCriterios(PrmAtualizaCobradorTodos parametro)
        {
            var ff011 = await _context.OsusrE9aCsicpFf011s.FirstOrDefaultAsync();
            if (ff011 == null) return new List<CSICP_FF102>();

            var qepCurrdate = DateTime.Today;

            return await (from ff102 in _context.OsusrE9aCsicpFf102s
                          where ff102.Ff102Contaid == parametro.InBB012_ID
                             && ff102.Ff102Tpcobranca == parametro.InStIDFF102_Cob_Cobranca
                             && EF.Functions.DateDiffDay(ff102.Ff102DataVencimento, qepCurrdate) >= ff011.Ff011DiasAtrasosDe
                             && (ff102.Ff102Situacaoid == parametro.InStIDFF102_Sit_Aberto || 
                                 ff102.Ff102Situacaoid == parametro.InStIDFF102_Sit_BxParcial)
                          select ff102).ToListAsync();
        }

        private async Task<CSICP_FF102?> BuscarTituloEspecificoParaTeste(PrmAtualizaCobradorTodos parametro)
        {
            return await _context.OsusrE9aCsicpFf102s
                .Where(t => t.TenantId == _tenantId)
                .FirstOrDefaultAsync();
        }

        private bool AtendeCriterios(CSICP_FF102 titulo, PrmAtualizaCobradorTodos parametro)
        {
            var ff011 = _context.OsusrE9aCsicpFf011s.FirstOrDefault();
            if (ff011 == null) return false;

            var qepCurrdate = DateTime.Today;
            var diasAtraso = (qepCurrdate - titulo.Ff102DataVencimento.Date).Days;

            return titulo.Ff102Contaid == parametro.InBB012_ID
                && titulo.Ff102Tpcobranca == parametro.InStIDFF102_Cob_Cobranca
                && diasAtraso >= ff011.Ff011DiasAtrasosDe
                && (titulo.Ff102Situacaoid == parametro.InStIDFF102_Sit_Aberto || 
                    titulo.Ff102Situacaoid == parametro.InStIDFF102_Sit_BxParcial);
        }

        private async Task GarantirFF011Existe()
        {
            var ff011Existe = await _context.OsusrE9aCsicpFf011s
                .Where(x => x.TenantId == _tenantId)
                .AnyAsync();

            if (!ff011Existe)
            {
                var novoFF011 = new CSICP_FF011
                {
                    Id = Guid.NewGuid().ToString(),
                    TenantId = _tenantId,
                    Ff011DiasAtrasosDe = 0,
                    // Adicione outros campos obrigatórios conforme necessário
                };

                _context.OsusrE9aCsicpFf011s.Add(novoFF011);
                await _context.SaveChangesAsync();
            }
        }

        private PrmAtualizaCobradorTodos CriarParametroTeste()
        {
            return new PrmAtualizaCobradorTodos
            {
                InTenantID = _tenantId,
                InBB012_ID = null, // Será NULL conforme critério da consulta SQL original
                InBB006_CobradorID = "TESTE_COBRADOR_ID",
                InBB006_CodigoCobrador = "TESTE_COBRADOR_COD",
                InStIDFF102_Cob_Cobranca = 1, // Tipo cobrança = 1
                InStIDFF102_Sit_Aberto = 5,   // Situação Aberto
                InStIDFF102_Sit_BxParcial = 2 // Situação Baixa Parcial
            };
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}