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
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                if (InPrmEntradaCalculo == null)
                    throw new ArgumentNullException(nameof(InPrmEntradaCalculo), "Parâmetro de entrada não pode ser nulo");

                CSICP_FF102 WorkFF102 = await _appDbContext.OsusrE9aCsicpFf102s
                                 .Where(e => e.TenantId == InPrmEntradaCalculo.InTenantID && e.Id == InPrmEntradaCalculo.InFF102Id)
                                 .FirstOrDefaultAsync() ?? throw new KeyNotFoundException("Titulo não encontrado");

                ZerandoValoresFF102(WorkFF102);

                List<CSICP_FF103>? WorkListaFF103 = await _appDbContext.OsusrE9aCsicpFf103s
                    .Where(e =>
                    e.TenantId == InPrmEntradaCalculo.InTenantID
                    && e.Ff102Id == InPrmEntradaCalculo.InFF102Id &&
                    e.Ff103Baixado == true && e.Ff103Estornado == false)
                    .AsNoTracking()
                    .ToListAsync();

                bool FlagIsBaixaCancelamento = false;
                DateTime? FlagDataDaBaixa = null;

                if (ListaFF103Vazia(WorkListaFF103))
                    AtualizaValorLiquidoTitulo(WorkFF102);

                /*o foreach é bypassado caso a lista esteja vazia, então o que prevalece é a atribuição acima.
                 Caso a lista não esteja vazia, o que aconteceu na linha 37 é bypassado e acontece o fluxo do foreach*/
                foreach (var current in WorkListaFF103)
                {
                    if (IsCancelamento(current, InPrmEntradaCalculo))
                        FlagIsBaixaCancelamento = true;
                    AtualizaPropriedadesDaFF102(InPrmEntradaCalculo, WorkFF102, current);
                }

                AtualizaSituacaoTitulo(InPrmEntradaCalculo, WorkFF102, FlagIsBaixaCancelamento);

                await AtualizaDataVencimentoRealTitulo(InPrmEntradaCalculo, WorkFF102, FlagDataDaBaixa);

                //seta usuarioID
                //WorkFF102.Ff102Usuarioproprieid = InPrmEntradaCalculo.InSY001UsuarioID;

                _appDbContext.Update(WorkFF102);
                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
                // Se chegou até aqui, significa que a operação foi bem-sucedida
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                if (ex is InvalidOperationException) throw new InvalidOperationException(HandlerExceptionMessage.CreateExceptionMessage(ex));
                if (ex is KeyNotFoundException) throw new KeyNotFoundException(HandlerExceptionMessage.CreateExceptionMessage(ex));
                else throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }

        private static void ZerandoValoresFF102(CSICP_FF102 WorkFF102)
        {
            WorkFF102.Ff102TotalPagamentos = 0;
            WorkFF102.Ff102TotalMultaPaga = 0;
            WorkFF102.Ff102TotalJuros = 0;
            WorkFF102.Ff102TotalDescontos = 0;
            WorkFF102.Ff102TotalDevolucao = 0;
            WorkFF102.Ff102TotalDoacao = 0;
            WorkFF102.Ff102TotalTarifas = 0;
            WorkFF102.Ff102VlLiqTitulo = 0;
            WorkFF102.Ff102NoPagamentos = 0;
            WorkFF102.Ff102VlCorrmonetaria = 0;
            WorkFF102.Ff102VlHonorarios = 0;
        }



        /*METODOS PRIVADOS*/
        private static bool ListaFF103Vazia(List<CSICP_FF103> WorkListaFF103)
        {
            return WorkListaFF103.Count == 0;
        }

        private static void AtualizaPropriedadesDaFF102(
            PrmEntradaCalculoBaixa InPrmEntradaCalculo, CSICP_FF102 WorkFF102, CSICP_FF103 current)
        {

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

            AtualizaValorLiquidoTitulo(WorkFF102);

            
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
              await ChecaCalendarioContasReceber(InPrmEntradaCalculo.InTenantID, InFlagDataDaBaixa, InPrmEntradaCalculo.InBB001Id);
            WorkFF102.Ff102DataVencReal = auxData;
            
        }

        private static void AtualizaSituacaoTitulo(PrmEntradaCalculoBaixa InPrmEntradaCalculo, CSICP_FF102 WorkFF102, bool InFlagIsBaixaCancelamento)
        {
            WorkFF102.Ff102Situacaoid = ValorLiquidoTituloZerado(WorkFF102) ?
                            InPrmEntradaCalculo.InSTIDFF102Liquidado : ValorLiquidoTituloPositivo(WorkFF102) ?
                            //caso a flag cancelamento seja verdadeira, o título será considerado cancelado
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

        private static void AtualizaValorLiquidoTitulo(CSICP_FF102 WorkFF102)
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
