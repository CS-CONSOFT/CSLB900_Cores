using CSCore.Domain.Interfaces.FF.PR_32_SoliticacaoRequisicaoDespesa;
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
        public async Task Testa_Se_FF140_Esta_Com_Status_Solicitado_E_Lanca_ErroSeTiver()
        {
            // Arrange
            var ff140status = new csicp_ff140



            // Act
            await _repository.SolicitarRD(135);
            // Assert

        }
    }
}
