using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Tests.Geral.Financeiro.RenegociacaoCalcTitulo
{
    public class ProcessarCalculoTituloTipoDiasTeste
    {
        private readonly AppDbContext _context;
        private readonly Mock<ICS_GenerateId> _mockGenerateID;
        public ProcessarCalculoTituloTipoDiasTeste()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: new Guid().ToString())
                .Options;

            _context = new AppDbContext(options);
            _mockGenerateID = new Mock<ICS_GenerateId>();
            _mockGenerateID.Setup(e => e.GenerateUuId()).Returns(new Guid().ToString());
        }


        public void TesteProcessarCalculoTituloTipoDias()
        {
            var auxCond = new string[]{ "15", "30", "45", "60", "75", "90", "105", "120", "135", "150", "165" };
            var processor = new ProcessarCalculoTituloTipoDias(_context, _mockGenerateID.Object, auxCond,work_valor_entrada: 0);


            var parametro = new Prm_Renegociacao_Calc_Simulacao_Titulos
            {
                in_TenantID = 135,
                in_renegociacaoID = "zz20250000000000000952429",
                in_condicaoPagamento = "058eca40-9f26-4422-92ac-f9b60f5b70b5",
                in_data = new DateTime(2025, 6, 1),
                in_valorEntrada = 0,
                in_faturaTotal = 158.46m
            };

            var retornoFinanciamento = new RetornoFinanciamento
            {
                ValorFaturaTotal = 158.46m,
                ValorParcela = 33.33m,
                ValorRestoParcela = 0.01m,
                ValorFinanciado = 100.00m
            };

            processor.Processar(parametro, retornoFinanciamento);
        }
    }
}
