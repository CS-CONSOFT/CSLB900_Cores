using CS.Core.Test.CSCore.Ifs.Basico;
using CSCore.Domain;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace CSCore.Ifs.Repository.BB.Tests
{

    public class BB065RepositoryTests
    {
        [Theory]
        [InlineData("2000-01-01", 24)]
        [InlineData("1990-06-15", 34)]
        [InlineData("2020-12-31", 3)]
        public void CalcularIdade_DeveRetornarIdadeAproximada(string data, int idadeEsperada)
        {
            // Arrange
            var context = FakeAppDbContext.CreateFakeContext();
            context.OsusrE9aCsicpBb012s.Add(new CSICP_BB012
            {
                Id = "1",
                TenantId = 1,
                Bb012IsActive = true,
                Bb012DataAniversario = new DateTime(2000, 1, 1)
            });
            context.SaveChanges();

            var repo = new BB065Repository(context);
            var dataAniversario = DateTime.Parse(data);

            // Act
            var idade = repo.CalcularIdade(dataAniversario);

            // Assert
            Assert.InRange(idade, idadeEsperada, idadeEsperada + 1);
        }

        [Fact]
        public async Task AtualizaFxEtaria_AtualizaValoresNoBanco()
        {
            // Arrange
            var context = FakeAppDbContext.CreateFakeContext();

            // Popule o contexto com dados necessários
            context.OsusrE9aCsicpBb065s.Add(new CSICP_Bb065
            {
                TenantId = 1,
                Bb065Id = 1,
                Bb064Fxetariaid = 10,
                Bb062Convenioid = 100
            });

            context.OsusrE9aCsicpBb061s.Add(new CSICP_Bb061
            {
                TenantId = 1,
                Bb061Id = 1,
                Bb060Convenioid = 100,
                Bb061Tipoassid = 1, // Titular
                Bb012Contaid = "conta1",
                Bb061Isactive = true,
            });

            context.OsusrE9aCsicpBb012s.Add(new CSICP_BB012
            {
                TenantId = 1,
                Id = "conta1",
                Bb012IsActive = true,
                Bb012DataAniversario = new DateTime(1990, 1, 1)
            });

            context.OsusrE9aCsicpBb066s.Add(new CSICP_Bb066
            {
                Bb066Fxetariaid = 10,
                Bb066Faixade = 0,
                Bb066Faixaate = 99,
                Bb066Valor = 123.45m
            });

            await context.SaveChangesAsync();

            var repo = new BB065Repository(context);

            // Act
            await repo.AtualizaFxEtaria(1, 10, 1, 2);

            // Assert
            var associado = await context.OsusrE9aCsicpBb061s.Where(e => e.Bb061Id == 1).FirstAsync();
            Assert.Equal(123.45m, associado.Bb061Valor);
        }
    }
}