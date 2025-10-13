using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.FF.RequisicaoDespesa.PR_32_SoliticacaoRequisicaoDespesa;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.RequisicaoDespesa.PR_32_SoliticacaoRequisicaoDespesa;
using Microsoft.EntityFrameworkCore;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Tests.Financeiro.Repository.RequisicaoDespesa.PR_32_SoliticacaoRequisicaoDespesa
{
    public class PR_32_SoliticacaoRequisicaoDespesaRepositoryTest
    {
        private readonly AppDbContext _context;
        private readonly IPR_32_SoliticacaoRequisicaoDespesaRepository _repository;

        public PR_32_SoliticacaoRequisicaoDespesaRepositoryTest()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: new Guid().ToString())
                .Options;



            _context = new AppDbContext(options);
            _repository = new PR_32_SoliticacaoRequisicaoDespesaRepositoryImpl(_context);
        }

        [Fact]
        public async Task Testa_Se_FF140_Nao_Esta_Com_Status_Solicitado()
        {
            // Arrange
            var ff140status = new OsusrE9aCsicpFf140Stum
            {
                Id = 3,
                Label = "aberto",
                Order = 1,
                IsActive = true,
                Codgcs = 1,
            };

            var ff140 = CSICP_FF140.CreateInstance(ff140Id: 1, tenantId: 135, ff140Statusid: 3, ff140Descricao: "teste"); 

            _context.OsusrE9aCsicpFf140Sta.Add(ff140status);
            _context.OsusrE9aCsicpFf140s.Add(ff140);
            await _context.SaveChangesAsync();

            // Act
            var result = await _repository.SolicitarRD(135, 1,0, 1);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task Testa_Se_FF140_Esta_Com_Status_Solicitado()
        {
            // Arrange
            var ff140status = new OsusrE9aCsicpFf140Stum
            {
                Id = 1,
                Label = "Solicitado",
                Order = 1,
                IsActive = true,
                Codgcs = 1,
            };

            var ff140 = CSICP_FF140.CreateInstance(ff140Id: 3, tenantId: 135, ff140Statusid: 1, ff140Descricao: "teste");


            _context.OsusrE9aCsicpFf140Sta.Add(ff140status);

            _context.OsusrE9aCsicpFf140s.Add(ff140);
            await _context.SaveChangesAsync();

            // Assert
            var exeption = await Assert.ThrowsAsync<InvalidOperationException>(async () =>
            {
                await _repository.SolicitarRD(135, 3,0,1);
            });

            // Verificar a mensagem da exceção
            Assert.Equal("O Movimento já está SOLICITADO!", exeption.Message);
        }


        [Fact]
        public async Task ValidaRequisicaoMenorOuIgualAZeroLancandoErroSeFor()
        {
            var ff140 = CSICP_FF140.CreateInstance(ff140Id: 5, tenantId: 135, ff140Statusid: 1, ff140Descricao: "teste", ff140Vrequisicao: 0);
            _context.OsusrE9aCsicpFf140s.Add(ff140);
            await _context.SaveChangesAsync();

            // Assert
            var exeption = await Assert.ThrowsAsync<InvalidOperationException>(async () =>
            {
                await _repository.SolicitarRD(135, 5, 0, 3);
            });

            // Verificar a mensagem da exceção
            Assert.Equal("Não é possível solicitar movimento sem valor!", exeption.Message);
        }


        [Fact]
        public async Task ValidaAlteracaoDeStatus()
        {
            var ff140id = 6;
            var ff140 = CSICP_FF140.CreateInstance(ff140Id: ff140id, tenantId: 135, ff140Statusid: 1, ff140Descricao: "teste", ff140Vrequisicao: 1);
            _context.OsusrE9aCsicpFf140s.Add(ff140);
            await _context.SaveChangesAsync();

            // Assert
            await _repository.SolicitarRD(135, ff140id,7, 3);
            await _context.SaveChangesAsync();

            // Verificar a mensagem da exceçã
            var ff15 = await _context.OsusrE9aCsicpFf140s.Where(e => e.Ff140Id == ff140id).FirstAsync();
            
            Assert.Equal(ff15.Ff140Statusid, 7);
        }
    }
}
