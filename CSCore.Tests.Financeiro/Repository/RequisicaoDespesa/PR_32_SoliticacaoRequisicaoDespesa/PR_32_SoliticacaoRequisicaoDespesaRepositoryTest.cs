using CSCore.Domain.Interfaces.FF.PR_32_SoliticacaoRequisicaoDespesa;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.RequisicaoDespesa.PR_32_SoliticacaoRequisicaoDespesa;
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
        private readonly AppDbContext _dbMock;
        private readonly IPR_32_SoliticacaoRequisicaoDespesaRepository _repository;

        public PR_32_SoliticacaoRequisicaoDespesaRepositoryTest()
        {
            _dbMock = Substitute.For<AppDbContext>();
            _repository = new PR_32_SoliticacaoRequisicaoDespesaRepositoryImpl(_dbMock);
        }

        [Fact]
        public async Task Testa_Se_FF140_Esta_Com_Status_Solicitado_E_Lanca_ErroSeTiver()
        {
            await _repository.SolicitarRD(135);
        }
    }
}
