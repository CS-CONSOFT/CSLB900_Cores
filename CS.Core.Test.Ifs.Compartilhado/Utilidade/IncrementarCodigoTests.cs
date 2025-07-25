using CSCore.Domain;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace CSCore.Ifs.CompartilhadoTests.Utilidade
{

    public class IncrementarCodigoTests
    {
        private AppDbContext _context;

        public IncrementarCodigoTests()
        {
            var configuration = new ConfigurationBuilder()
               .SetBasePath(@"Z:\Programacao\CSConsoft_iCorp\CS1_iCorpCloud_WebAPI\CSCore.Ifs.CompartilhadoTests")
               .AddJsonFile("appsettings.Test.json")
               .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(connectionString)
                .Options;
            _context = new AppDbContext(options);
        }

        [Fact]
        public void DeveRetornar_852_E_Passar_No_Test()
        {
            int novoCodigo =
                IncrementarCodigo
                .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo
                <CSICP_Bb005>(_context, 852, null, "Bb005Codigo", "Id");

            novoCodigo.Should().Be(852);
        }

        [Fact]
        public void DeveRetornar_IncrementarOCodigoPoisEleJaExiste()
        {
            int novoCodigo =
                IncrementarCodigo.IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb005>
                (_context, 999920, null, "Bb005Codigo", "Id");

            novoCodigo.Should().Be(999921);
        }

        [Fact]
        public void DeveRetornar_O_MaxCodigo_Mais_Um_Quando_For_Nulo_O_Novo_Codigo()
        {
            int? codigoMaximo = _context.OsusrE9aCsicpBb005s.Max(e => e.Bb005Codigo);

            int novoCodigo =
                IncrementarCodigo.IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb005>
                (_context, 999920, null, "Bb005Codigo", "Id");

            novoCodigo.Should().Be(codigoMaximo + 1);
        }

        [Fact]
        public void DeveRetornar_O_MaxCodigo_Mais_Um_Quando_For_Zero_O_Novo_Codigo()
        {
            int? codigoMaximo = _context.OsusrE9aCsicpBb005s.Max(e => e.Bb005Codigo);

            int novoCodigo =
                IncrementarCodigo.IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb005>(_context, 999920, null, "Bb005Codigo", "Id");

            novoCodigo.Should().Be(codigoMaximo + 1);
        }
    }
}