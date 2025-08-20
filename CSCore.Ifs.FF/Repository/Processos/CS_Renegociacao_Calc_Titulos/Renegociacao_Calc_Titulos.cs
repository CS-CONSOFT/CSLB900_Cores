using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ex.Personalizada;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Interface;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar.Fabrica;
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

        public async Task Executar(Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos)
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
                (int work_valor_entrada, int work_qtdParcelas) = AvaliarCondicaoPagamento(in_Renegociacao_Calc_Titulos, work_bb008, work_condicaoPagtoDividida);


                var calculoFinanciamento = CalcularValoresFinanciamento(
                    in_Renegociacao_Calc_Titulos.in_faturaTotal,
                    work_qtdParcelas,
                    work_valor_entrada);


                IAuxProcessarCalculoTitulo processarCalculoTitulo
                    = ProcessarRenegociacaoCalcTituloFactory
                    .Create(in_Renegociacao_Calc_Titulos, work_bb008,calculoFinanciamento, _appDbContext,
                    _generateId, work_condicaoPagtoDividida,work_qtdParcelas, work_valor_entrada);

                await processarCalculoTitulo.Processar(in_Renegociacao_Calc_Titulos, calculoFinanciamento);

            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                if (ex is ExceptionSemAuditoria) throw new ExceptionSemAuditoria(1001, HandlerExceptionMessage.CreateExceptionMessage(ex));
                else throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }

      


        private static (decimal ValorParcela, decimal ValorRestoParcela, decimal ValorFinanciado)
                         CalcularValoresFinanciamento(decimal faturaTotal, int qtdParcelas, int valorEntrada)
        {
            if (qtdParcelas <= 0)
                throw new ArgumentException("Quantidade de parcelas deve ser maior que zero.", nameof(qtdParcelas));

            decimal valorFinanciado;
            decimal valorParcela;
            decimal valorRestoParcela = 0;

            if (qtdParcelas == 1)
            {
                valorFinanciado = faturaTotal;
                valorParcela = valorFinanciado.Round(2);
            }
            else if (valorEntrada > 0)
            {
                valorFinanciado = faturaTotal - valorEntrada;
                var parcelasRestantes = qtdParcelas - 1;
                valorParcela = (valorFinanciado / parcelasRestantes).Round(2);
                valorRestoParcela = valorFinanciado - (valorParcela * parcelasRestantes);
            }
            else
            {
                valorFinanciado = faturaTotal;
                valorParcela = (valorFinanciado / qtdParcelas).Round(2);
                valorRestoParcela = valorFinanciado - (valorParcela * qtdParcelas);
            }

            return (valorParcela, valorRestoParcela, valorFinanciado);
        }

        private static (int aux_entrada, int aux_qtdParcelas) AvaliarCondicaoPagamento(
            Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos,
            CSICP_Bb008 work_bb008,
            string[]? aux_condicaoPagtoDividida)
        {
            int aux_qtdParcelas = 0;
            int aux_entrada = 0;

            if (EhTipoDias(in_Renegociacao_Calc_Titulos, work_bb008))
                aux_qtdParcelas = aux_condicaoPagtoDividida?.Length ?? 0;


            if (EhTipoParcelaDiasOuMes(in_Renegociacao_Calc_Titulos, work_bb008))
            {
                aux_qtdParcelas = int.Parse(aux_condicaoPagtoDividida?[0] ?? "0");
                aux_entrada = int.Parse(aux_condicaoPagtoDividida?[1] ?? "0");
            }

            return (aux_entrada, aux_qtdParcelas);
        }

        private static bool EhTipoParcelaDiasOuMes(Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_ParcelaDias || work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_ParcelaMes;
        }

        private static bool EhTipoDias(Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_Dias;
        }

    }
}
