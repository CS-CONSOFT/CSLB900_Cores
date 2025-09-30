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

        public async Task<bool> Executar(Prm_Renegociacao_Calc_Simulacao_Titulos prmSimulacao)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                await RemoverItensRenegociacaoFF999(prmSimulacao);

                await ValidarRenegociacaoAberta(prmSimulacao);

                CSICP_Bb008 work_bb008 = await ObterCondicaoPagamentoBb008(prmSimulacao);

                string[]? work_condicaoPagtoDividida = work_bb008.Bb008Condicao?.Split(';') ?? [];

                int work_qtd_parcelas
                    = CondicaoPagamentoAvaliador
                    .AvaliarCondicaoPagamento(
                        prmSimulacao.in_StID_bb008_tp_ParcelaDias,
                        prmSimulacao.in_StID_bb008_tp_ParcelaMes,
                        prmSimulacao.in_StID_bb008_tp_Dias,
                        work_bb008,
                        work_condicaoPagtoDividida);


                RetornoFinanciamento calculoFinanciamento = FinanciamentoCalculator.CalcularValoresFinanciamento(
                    faturaTotal: prmSimulacao.in_faturaTotal,
                    qtdParcelas: work_qtd_parcelas,
                    valorEntrada: prmSimulacao.in_valorEntrada);

                var prm = new PrmRenegociacaoCalcTituloFactory
                {
                    prmSimulacao = prmSimulacao,
                    work_bb008 = work_bb008,
                    appDbContext = _appDbContext,
                    generateId = _generateId,
                    aux_condicaoPagtoDividida = work_condicaoPagtoDividida,
                    workQtdParcelas = work_qtd_parcelas,
                    work_valor_entrada = prmSimulacao.in_valorEntrada,
                };

                IAuxProcessarCalculoTitulo processarCalculoTitulo = ProcessarRenegociacaoCalcTituloFactory.Create(prm);

                await processarCalculoTitulo.Processar(
                    InControleID: prmSimulacao.in_renegociacaoID,
                    InData: DateOnly.FromDateTime(prmSimulacao.in_data),
                    InTenantID: prmSimulacao.in_TenantID,
                    ina_calculoFinanciamento: calculoFinanciamento,
                    InValorEntrada: prmSimulacao.in_valorEntrada);

                await transaction.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                if (ex is ExceptionSemAuditoria) throw new ExceptionSemAuditoria(1001, HandlerExceptionMessage.CreateExceptionMessage(ex));
                else throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }

        private async Task<CSICP_Bb008> ObterCondicaoPagamentoBb008(Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos)
        {
            return await _appDbContext.OsusrE9aCsicpBb008s
                                .Where(e => e.TenantId == in_Renegociacao_Calc_Titulos.in_TenantID
                                && e.Id == in_Renegociacao_Calc_Titulos.in_condicaoPagamento)
                                .FirstOrDefaultAsync() ?? throw new ExceptionSemAuditoria("Condição de pagamento não encontrada!");
        }

        private async Task ValidarRenegociacaoAberta(Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos)
        {
            CSICP_FF017 work_ff017_renegociacao = await _appDbContext.OsusrE9aCsicpFf017s
            .Where(e => e.TenantId == in_Renegociacao_Calc_Titulos.in_TenantID
            && e.Id == in_Renegociacao_Calc_Titulos.in_renegociacaoID
            && e.Ff017Aberto == true)
            .FirstOrDefaultAsync() ?? throw new ExceptionSemAuditoria("Renegociação já processada!");
        }

        private async Task RemoverItensRenegociacaoFF999(Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos)
        {
            List<CSICP_FF999> lista999DaRenegociacao
                = await _appDbContext.OsusrE9aCsicpFf999s
                .Where(e => e.TenantId == in_Renegociacao_Calc_Titulos.in_TenantID
                && e.Ff999IdControle == in_Renegociacao_Calc_Titulos.in_renegociacaoID)
                .ToListAsync();

            _appDbContext.OsusrE9aCsicpFf999s.RemoveRange(lista999DaRenegociacao);
        }
    }
}
