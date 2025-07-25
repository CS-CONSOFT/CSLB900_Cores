using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.GG._03X;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSCore.Ifs.GGTests.Repository.GG._03X
{
    public class GG031RepositoryImplTest
    {

        [Fact]
        public async Task TestaProcessaAjustePreco_DeveRetornarTrueSeNaoTiverErros()
        {
            var configuration = new ConfigurationBuilder()
               .AddUserSecrets<GG031RepositoryImplTest>() 
               .Build();

            var stringConexao = configuration.GetConnectionString("DefaultConnection");

            var dbContextFake = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(stringConexao)
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information) 
                .Options;

            var _appDbContext = new AppDbContext(dbContextFake);    

            var gg0031Impl = new GG031RepositoryImpl(_appDbContext);

            bool isOk = await gg0031Impl.ProcessaAjustePreco(
                    movimentoId: "zz20250000000000000860498",
                    tenantId: 135,
                    in_StID_Gg030Status_Solicitado: 1,
                    in_StID_Gg023_Val_Venda: 5,
                    in_StID_Gg023_Val_CustoReal: 3,
                    in_StID_Gg023_Val_Custo: 2,
                    in_StID_Gg023_Val_Reposicao: 4,
                    in_StID_Gg023_Val_CustoMedio: 1,
                    in_StID_Gg023_Val_ECommmerce: 6,
                    in_StID_Gg030_Atendido:3
                );
            isOk.Should().BeTrue("porque o teste deve passar sem erros de execução.");
        }


        [Fact]
        public async Task DeveRetornarMensagensDeErroQuandoMovimentoNaoEstiverSolicitado()
        {
            var configuration = new ConfigurationBuilder()
               .AddUserSecrets<GG031RepositoryImplTest>()
               .Build();

            var stringConexao = configuration.GetConnectionString("DefaultConnection");

            var dbContextFake = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(stringConexao)
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                .Options;

            var _appDbContext = new AppDbContext(dbContextFake);

            var gg0031Impl = new GG031RepositoryImpl(_appDbContext);

            var ex = await Assert.ThrowsAsync<Exception>(async () =>
                 await gg0031Impl.ProcessaAjustePreco(
                     movimentoId: "zz20250000000000000860113",
                     tenantId: 135,
                     in_StID_Gg030Status_Solicitado: 1,
                     in_StID_Gg023_Val_Venda: 5,
                     in_StID_Gg023_Val_CustoReal: 3,
                     in_StID_Gg023_Val_Custo: 2,
                     in_StID_Gg023_Val_Reposicao: 4,
                     in_StID_Gg023_Val_CustoMedio: 1,
                     in_StID_Gg023_Val_ECommmerce: 6,
                     in_StID_Gg030_Atendido: 3
                    )
            );

            Assert.Equal("Movimento não encontrado ou não está como solicitado", ex.Message);

        }


        [Fact]
        public async Task DeveRetornarMensagensDeErroQuandoMovimentoNaoEstiverSolicitado_Abortado()
        {
            var configuration = new ConfigurationBuilder()
               .AddUserSecrets<GG031RepositoryImplTest>()
               .Build();

            var stringConexao = configuration.GetConnectionString("DefaultConnection");

            var dbContextFake = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(stringConexao)
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                .Options;

            var _appDbContext = new AppDbContext(dbContextFake);

            var gg0031Impl = new GG031RepositoryImpl(_appDbContext);

            var ex = await Assert.ThrowsAsync<Exception>(async () =>
                 await gg0031Impl.ProcessaAjustePreco(
                     movimentoId: "zz20250000000000000860498",
                     tenantId: 135,
                     in_StID_Gg030Status_Solicitado: 1,
                     in_StID_Gg023_Val_Venda: 5,
                     in_StID_Gg023_Val_CustoReal: 3,
                     in_StID_Gg023_Val_Custo: 2,
                     in_StID_Gg023_Val_Reposicao: 4,
                     in_StID_Gg023_Val_CustoMedio: 1,
                     in_StID_Gg023_Val_ECommmerce: 6,
                     in_StID_Gg030_Atendido: 3
                    )
            );

            Assert.Equal("Abortado", ex.Message);

        }
    }
}
