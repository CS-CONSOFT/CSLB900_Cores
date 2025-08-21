using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ex.Personalizada;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.Processos.CS_TituloCalculoBaixa
{
    public class TituloCalculoBaixa : ITituloCalculoBaixa
    {
        private readonly AppDbContext _appDbContext;

        public TituloCalculoBaixa(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Executar(PrmEntradaCalculoBaixa InPrmEntradaCalculo)
        {
            if (InPrmEntradaCalculo == null)
                throw new ArgumentNullException(nameof(InPrmEntradaCalculo), "Parâmetro de entrada não pode ser nulo");

            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                CSICP_FF102 WorkFF102 = await _appDbContext.OsusrE9aCsicpFf102s
                              .Where(e => e.TenantId == InPrmEntradaCalculo.InTenantID && e.Id == InPrmEntradaCalculo.InFF102Id)
                              .FirstOrDefaultAsync() ?? throw new KeyNotFoundException("Titulo não encontrado");

                List<CSICP_FF103>? WorkListaFF103 = await _appDbContext.OsusrE9aCsicpFf103s
                    .Where(e => e.TenantId == InPrmEntradaCalculo.InTenantID && e.Ff102Id == InPrmEntradaCalculo.InFF102Id)
                    .AsNoTracking()
                    .ToListAsync();

                bool FlagIsBaixaCancelamento = false;
                DateTime? FlagDataDaBaixa = null;

                if (ListaFF103Vazia(WorkListaFF103))
                    AtualizaDataEValorLiquidoTitulo(WorkFF102);

                /*o foreach é bypassado caso a lista esteja vazia, então o que prevalece é a atribuição acima.
                 Caso a lista não esteja vazia, o que aconteceu na linha 37 é bypassado e acontece o fluxo do foreach*/
                foreach (var current in WorkListaFF103)
                {
                    /*Duvida: a ff103 é uma lista, a gente ta atualizando a ff102 dentro do foreach a cada item da ff103,
                     mas o commit de atualizacao é feito ao final do fluxo, fora do foreach. Ou seja, o que seria salvo
                    seria apenas a ultima atribuição realizada pelo foreach.

                    Ex.
                    Iteracao 1 -> Valor = 1
                    Iteracao 2 -> Valor = 2
                    Iteracao 3 -> Valor = 3
                    Iteracao 4 -> Valor = 4
                    Iteracao 5 -> Valor = 5

                    Ao final do fluxo, o que seria salvo seria apenas o valor 5, pois é o ultimo valor atribuído.

                    O certo seria salvar todas as ff102 necessarias ou entao recuperar apenas 1 ff103
                     */
                    if (IsCancelamento(current, InPrmEntradaCalculo))
                        FlagIsBaixaCancelamento = true;
                    AtualizaPropriedadesDaFF102(InPrmEntradaCalculo, WorkFF102, current);
                }


                if (ValorLiquidoTituloPositivo(WorkFF102))
                    AtualizaSituacaoTitulo(InPrmEntradaCalculo, WorkFF102, FlagIsBaixaCancelamento);

                await AtualizaDataVencimentoRealTitulo(InPrmEntradaCalculo, WorkFF102, FlagDataDaBaixa);

                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                if (ex is KeyNotFoundException) throw new KeyNotFoundException(HandlerExceptionMessage.CreateExceptionMessage(ex));
                else throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }




        /*METODOS PRIVADOS*/
        private static bool ListaFF103Vazia(List<CSICP_FF103> WorkListaFF103)
        {
            return WorkListaFF103.Count == 0;
        }

        private static void AtualizaPropriedadesDaFF102(
            PrmEntradaCalculoBaixa InPrmEntradaCalculo, CSICP_FF102 WorkFF102, CSICP_FF103 current)
        {
            AtualizaDataEValorLiquidoTitulo(WorkFF102);

            WorkFF102.Ff102TotalPagamentos =
                (WorkFF102.Ff102TotalPagamentos ?? 0) + (current.Ff103ValorPago ?? 0);
            WorkFF102.Ff102TotalMultaPaga =
                (WorkFF102.Ff102TotalMultaPaga ?? 0) + (current.Ff103ValorMulta ?? 0);


            WorkFF102.Ff102TotalJuros =
                (WorkFF102.Ff102TotalJuros ?? 0) + (current.Ff103ValorJuros ?? 0);

            WorkFF102.Ff102TotalDescontos =
                (WorkFF102.Ff102TotalDescontos ?? 0) + (current.Ff103ValorDesconto ?? 0);

            WorkFF102.Ff102TotalTarifas =
                (WorkFF102.Ff102TotalTarifas ?? 0) + (current.Ff103ValorTarifas ?? 0);

            WorkFF102.Ff102VlCorrmonetaria =
                (WorkFF102.Ff102VlCorrmonetaria ?? 0) + (current.Ff103VlCorrmonetaria ?? 0);

            WorkFF102.Ff102VlHonorarios =
                (WorkFF102.Ff102VlHonorarios ?? 0) + (current.Ff103VlHonorarios ?? 0);


            WorkFF102.Ff102DataUltPagto = current.Ff103DataBaixa;

            WorkFF102.Ff102NoPagamentos =
                (WorkFF102.Ff102NoPagamentos ?? 0) + 1;

            AtualizaTotalDevolucaoOuDoacaoTitulo(InPrmEntradaCalculo.InSTIDFF103TpBaiDoacao, WorkFF102.Ff102TotalDoacao, current);
            AtualizaTotalDevolucaoOuDoacaoTitulo(InPrmEntradaCalculo.InSTIDFF103TpBaiDevolucao, WorkFF102.Ff102TotalDevolucao, current);
        }

        private static void AtualizaTotalDevolucaoOuDoacaoTitulo(int InSTIDCorrente, decimal? InTotal, CSICP_FF103 current)
        {
            InTotal = current.Ff103Tpbaixaid == InSTIDCorrente ?
                (InTotal ?? 0) + (current.Ff103ValorPago ?? 0) :
                (InTotal ?? 0);
        }

        private bool IsCancelamento(CSICP_FF103 InFF103, PrmEntradaCalculoBaixa InPrmEntradaCalcBx)
        {
            return InFF103.Ff103Tpbaixaid == InPrmEntradaCalcBx.InSTIDFF103TpBaiCancelamento;
        }


        private async Task AtualizaDataVencimentoRealTitulo(
            PrmEntradaCalculoBaixa InPrmEntradaCalculo, CSICP_FF102 WorkFF102, DateTime? InFlagDataDaBaixa)
        {
            DateTime? auxData =
              await ChecaCalendarioContasReceber(InPrmEntradaCalculo.InTenantID, InFlagDataDaBaixa, InPrmEntradaCalculo.InEstabID);
            WorkFF102.Ff102DataVencReal = auxData;
            
        }

        private static void AtualizaSituacaoTitulo(PrmEntradaCalculoBaixa InPrmEntradaCalculo, CSICP_FF102 WorkFF102, bool InFlagIsBaixaCancelamento)
        {
            WorkFF102.Ff102Situacaoid = ValorLiquidoTituloZerado(WorkFF102) ?
                            InPrmEntradaCalculo.InSTIDFF102Liquidado : ValorLiquidoTituloPositivo(WorkFF102) ?
                            InPrmEntradaCalculo.InSTIDFF102BxParcial : InFlagIsBaixaCancelamento ?
                            InPrmEntradaCalculo.InSTIDFF103TpBaiCancelamento : InPrmEntradaCalculo.InSTIDFF102Aberto;
        }

        private static bool ValorLiquidoTituloPositivo(CSICP_FF102 WorkFF102)
        {
            return WorkFF102.Ff102VlLiqTitulo > 0;
        }

        private static bool ValorLiquidoTituloZerado(CSICP_FF102 WorkFF102)
        {
            return WorkFF102.Ff102VlLiqTitulo == 0;
        }

        private static void AtualizaDataEValorLiquidoTitulo(CSICP_FF102 WorkFF102)
        {
            WorkFF102.Ff102VlLiqTitulo = Math.Round(
                   (WorkFF102.Ff102ValorTitulo ?? 0)
                   + (WorkFF102.Ff102VlAcrescimos ?? 0)
                   - (WorkFF102.Ff102VlDecrescimos ?? 0)
                   - (WorkFF102.Ff102TotalPagamentos ?? 0)
                   + (WorkFF102.Ff102TotalJuros ?? 0)
                   + (WorkFF102.Ff102TotalMultaPaga ?? 0)
                   + (WorkFF102.Ff102TotalTarifas ?? 0)
                   + (WorkFF102.Ff102VlCorrmonetaria ?? 0)
                   + (WorkFF102.Ff102VlHonorarios ?? 0)
                   - (WorkFF102.Ff102ValorTaxaCartao ?? 0)
                   - (WorkFF102.Ff102TotalDescontos ?? 0)
                   - (WorkFF102.Ff102ValorDesagio ?? 0)
                   - (WorkFF102.Ff102TotalImpostosmenos ?? 0), 2);

            WorkFF102.Ff102DataUltPagto = null;
        }

        private async Task<DateTime?> ChecaCalendarioContasReceber(int InTenantID, DateTime? InDataVencimento, string InEstabID)
        {

            CSICP_FF001? WorkFF001 = await _appDbContext.OsusrE9aCsicpFf001s.Where(e => e.TenantId == InTenantID 
            && e.Ff001Data == InDataVencimento && e.Ff001Filialid == InEstabID)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            return WorkFF001 is not null && InDataVencimento.HasValue
                ? InDataVencimento.Value.AddDays(1)
                : InDataVencimento;

        }
    }
}
