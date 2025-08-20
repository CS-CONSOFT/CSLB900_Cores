using NPOI.SS.Formula.Functions;

namespace CSCore.Tests.Geral.Financeiro.RenegociacaoCalcTitulo
{
    using CSCore.Ifs.FF.Repository.Processos.CS_EscreveValores;
    using CSLB900.MSTools.GenerateId;
    using CSLB900.MSToolsTestes;
    using global::CSCore.Ifs.CS_Context;
    using global::CSCore.Ifs.Eventos.Repository;
    using global::CSCore.Ifs.FF.Repository.Processos.CS_EscreveValores;
    using global::CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Cria_Titulos;
    using global::CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Cria_Titulos.Parametro;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Moq;
    using System;
    using System.Threading.Tasks;
    using Xunit;

    namespace CSCore.Ifs.FF.Tests.Repository.Processos.CS_Renegociacao_Calc_Titulos
    {
        public class EscreveValoresTest : IDisposable
        {
            private readonly AppDbContext _context;
            private readonly IEscreveValores _service;
            private readonly string _connectionString;

            public EscreveValoresTest()
            {
                var config = new ConfigurationBuilder()
                .AddUserSecrets<InadimplenciaServiceTests>()
                .Build();
                    var connectionString = config.GetConnectionString("DefaultConnection");
                    _connectionString = connectionString;

                var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(_connectionString)
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                .Options;

                _context = new AppDbContext(options);
            
                _service = new EscreveValores(_context);

            }



            [Fact]
            public async Task Executar_CondicaoPagamentoNaoEncontrada_DeveThrowExceptionSemAuditoria()
            {
                // Arrange
                var parametro = CriarParametroTeste();

                await _service.Executar(parametro);

            }

            private PrmEscreveValores CriarParametroTeste()
            {
                return new PrmEscreveValores
                {
                     InTenantID = 135,
                    InSTIDFF102SitAberto = 1,
                    InSTID102BxParcial = 1,
                    InFF017ID = "",
                };
            }

            public void Dispose()
            {
                _context?.Dispose();
            }
        }
    }
}
