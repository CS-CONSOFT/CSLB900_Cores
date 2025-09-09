using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Atualiza_Cobrador_Todos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CSCore.Tests.Geral.Financeiro.CS_Atualiza_Cobrador_Todos
{
    public class AtualizaCobradorTodosFF102Test 
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
        public async Task Atualiza_Cobrador_Todos_ComTitulosEncontrados_DeveAtualizarCobrador()
        {
            // Arrange
            var parametro = new PrmAtualizaCobradorTodos
            {
                InTenantID = _tenantId,
                InBB012_ID = "9a7ba9e7-b84f-43ba-b7e5-bebc67765556", // Será NULL conforme critério da consulta SQL original
                InBB006_CobradorID = "zz20250000000000000844716",
                InSY001_ID = "zz20250000000000000847442",
                InStIDFF102_Cob_Cobranca = 1, // Tipo cobrança = 1
                InStIDFF102_Sit_Aberto = 5,   // Situação Aberto
                InStIDFF102_Sit_BxParcial = 2 // Situação Baixa Parcial
            }
            ;
            // Act
            await _service.Atualiza_Cobrador_Todos(parametro);

        }
    }
}