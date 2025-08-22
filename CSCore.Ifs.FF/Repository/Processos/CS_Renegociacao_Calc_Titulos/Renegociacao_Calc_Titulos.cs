using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ex.Personalizada;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Interface;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar.Fabrica;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.AvaliarCondicaoPagamento;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using MathNet.Numerics;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos
{
   
    public class Renegociacao_Calc_Titulos : IRenegociacao_Calc_Titulos
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICS_GenerateId _generateId;

        public Renegociacao_Calc_Titulos(AppDbContext appDbContext, ICS_GenerateId generateId)
        {
            _appDbContext = appDbContext;
            _generateId = generateId;
        }

        public async Task<bool> Executar(Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                CSICP_FF017 work_ff017_renegociacao = await _appDbContext.OsusrE9aCsicpFf017s
                .Where(e => e.TenantId == in_Renegociacao_Calc_Titulos.in_tenantID
                && e.Id == in_Renegociacao_Calc_Titulos.in_renegociacaoID
                && e.Ff017Aberto == false)
                .FirstOrDefaultAsync() ?? throw new ExceptionSemAuditoria("Renegociação já processada!");

                CSICP_Bb008 work_bb008 = await _appDbContext.OsusrE9aCsicpBb008s
                    .Where(e => e.TenantId == in_Renegociacao_Calc_Titulos.in_tenantID
                    && e.Bb008CondicaoPagto == in_Renegociacao_Calc_Titulos.in_condicaoPagamento)
                    .FirstOrDefaultAsync() ?? throw new ExceptionSemAuditoria("Condição de pagamento não encontrada!");

                string[]? work_condicaoPagtoDividida = work_bb008.Bb008Condicao?.Split(';') ?? [];
                (int work_valor_entrada, int work_qtdParcelas) = CondicaoPagamentoAvaliador.AvaliarCondicaoPagamento(in_Renegociacao_Calc_Titulos, work_bb008, work_condicaoPagtoDividida);


                var calculoFinanciamento = FinanciamentoCalculator.CalcularValoresFinanciamento(
                    in_Renegociacao_Calc_Titulos.in_faturaTotal,
                    work_qtdParcelas,
                    work_valor_entrada);


                IAuxProcessarCalculoTitulo processarCalculoTitulo
                    = ProcessarRenegociacaoCalcTituloFactory
                    .Create(in_Renegociacao_Calc_Titulos, work_bb008, _appDbContext, _generateId, work_condicaoPagtoDividida,work_qtdParcelas, work_valor_entrada);

                await processarCalculoTitulo.Processar(in_Renegociacao_Calc_Titulos, calculoFinanciamento);

                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                if (ex is ExceptionSemAuditoria) throw new ExceptionSemAuditoria(1001, HandlerExceptionMessage.CreateExceptionMessage(ex));
                else throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }
    }
}
