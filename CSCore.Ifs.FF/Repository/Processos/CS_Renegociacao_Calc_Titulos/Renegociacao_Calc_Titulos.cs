using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ex.Personalizada;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using MathNet.Numerics;
using Microsoft.EntityFrameworkCore;
using NPOI.POIFS.Crypt.Dsig;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos
{
    public class Prm_Renegociacao_Calc_Titulos
    {
        public int in_tenantID { get; set; }
        public string in_renegociacaoID { get; set; } = string.Empty;
        public string in_condicaoPagamento { get; set; } = string.Empty;
        public int in_StID_bb008_tp_Dias { get; set; }
        public int in_StID_bb008_tp_ParcelaDias { get; set; }
        public int in_StID_bb008_tp_ParcelaMes { get; set; }
        public int in_StID_bb008_tp_A_vista { get; set; }
        public decimal in_faturaTotal { get; set; }
        public string in_ChaveControle_ID { get; set; } = string.Empty;
        public decimal in_valorEntrada { get; set; }
        public DateTime in_data { get; set; }
    }
    public class Renegociacao_Calc_Titulos
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


                int aux_parcela_atual = 0;
                if (EhTipoDias(in_Renegociacao_Calc_Titulos, work_bb008))
                    await ProcessarParcelasTipoDias(in_Renegociacao_Calc_Titulos, work_condicaoPagtoDividida, work_valor_entrada, calculoFinanciamento.ValorParcela, calculoFinanciamento.ValorRestoParcela, aux_parcela_atual);

                if (EhTipoParcelaDias(in_Renegociacao_Calc_Titulos, work_bb008))
                    await ProcessarParcelasTipoParcelaDias(in_Renegociacao_Calc_Titulos, work_condicaoPagtoDividida, work_valor_entrada, work_qtdParcelas, calculoFinanciamento, aux_parcela_atual);

                if (EhTipoParcelaMes(in_Renegociacao_Calc_Titulos, work_bb008))
                    await ProcessarParcelasTipoParcelaMes(in_Renegociacao_Calc_Titulos, work_condicaoPagtoDividida, work_valor_entrada, work_qtdParcelas, calculoFinanciamento, aux_parcela_atual);

                if (EhTipoAVista(in_Renegociacao_Calc_Titulos, work_bb008))
                    await ProcessaTipoAVista(in_Renegociacao_Calc_Titulos, calculoFinanciamento);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                if (ex is ExceptionSemAuditoria) throw new ExceptionSemAuditoria(1001, HandlerExceptionMessage.CreateExceptionMessage(ex));
                else throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }

        private async Task ProcessaTipoAVista(Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos, (decimal ValorParcela, decimal ValorRestoParcela, decimal ValorFinanciado) calculoFinanciamento)
        {
            CSICP_FF999 work_ff999 = new CSICP_FF999
            {
                Id = _generateId.GenerateUuId(),
                TenantId = in_Renegociacao_Calc_Titulos.in_tenantID,
                Ff999IdControle = in_Renegociacao_Calc_Titulos.in_ChaveControle_ID,
                Ff999Valorparcela = calculoFinanciamento.ValorFinanciado,
                Ff999Parcela = 1,
                Ff999Datavencto = in_Renegociacao_Calc_Titulos.in_data
            };
            _appDbContext.Add(work_ff999);
            await _appDbContext.SaveChangesAsync();
        }

        private async Task ProcessarParcelasTipoParcelaDias(Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos, string[] work_condicaoPagtoDividida, int work_valor_entrada, int work_qtdParcelas, (decimal ValorParcela, decimal ValorRestoParcela, decimal ValorFinanciado) calculoFinanciamento, int aux_parcela_atual)
        {
            await ProcessarParcelasTipoParcelaDiasMes(in_Renegociacao_Calc_Titulos, work_condicaoPagtoDividida, work_valor_entrada, work_qtdParcelas, calculoFinanciamento, aux_parcela_atual, isParcelaMes: false);
        }

        private async Task ProcessarParcelasTipoParcelaMes(Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos, string[] work_condicaoPagtoDividida, int work_valor_entrada, int work_qtdParcelas, (decimal ValorParcela, decimal ValorRestoParcela, decimal ValorFinanciado) calculoFinanciamento, int aux_parcela_atual)
        {
            await ProcessarParcelasTipoParcelaDiasMes(in_Renegociacao_Calc_Titulos, work_condicaoPagtoDividida, work_valor_entrada, work_qtdParcelas, calculoFinanciamento, aux_parcela_atual, isParcelaMes: true);
        }

        private async Task ProcessarParcelasTipoParcelaDiasMes(Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos, string[] work_condicaoPagtoDividida, int work_valor_entrada, int work_qtdParcelas, (decimal ValorParcela, decimal ValorRestoParcela, decimal ValorFinanciado) calculoFinanciamento, int aux_parcela_atual, bool isParcelaMes)
        {
            int aux_dias_mes_entrada = int.Parse(work_condicaoPagtoDividida[0]);
            int aux_dias_mes_intervalo = int.Parse(work_condicaoPagtoDividida[1]);

            while (aux_parcela_atual <= work_qtdParcelas)
            {
                CSICP_FF999 work_ff999 = new CSICP_FF999
                {
                    Id = _generateId.GenerateUuId(),
                    TenantId = in_Renegociacao_Calc_Titulos.in_tenantID,
                    Ff999IdControle = in_Renegociacao_Calc_Titulos.in_ChaveControle_ID,
                    Ff999Valorparcela = in_Renegociacao_Calc_Titulos.in_valorEntrada,
                    Ff999Parcela = aux_parcela_atual + 1,
                    Ff999Datavencto = isParcelaMes ? in_Renegociacao_Calc_Titulos.in_data.AddMonths(aux_dias_mes_entrada) : in_Renegociacao_Calc_Titulos.in_data.AddDays(aux_dias_mes_entrada)
                };
                if (!PossuiEntrada(work_valor_entrada, aux_parcela_atual, aux_dias_mes_entrada))
                {
                    work_ff999.Ff999Datavencto = isParcelaMes ? in_Renegociacao_Calc_Titulos.in_data.AddMonths(aux_dias_mes_intervalo): in_Renegociacao_Calc_Titulos.in_data.AddDays(aux_dias_mes_intervalo);
                    calculoFinanciamento.ValorParcela = 0;
                }
                _appDbContext.Add(work_ff999);
                aux_parcela_atual += 1;
            }
            await _appDbContext.SaveChangesAsync();
        }

        private static bool PossuiEntrada(int work_valor_entrada, int aux_parcela_atual, int aux_dias_mes_entrada)
        {
            return aux_parcela_atual == 1 && aux_dias_mes_entrada > 0 && work_valor_entrada > 0;
        }

        private async Task ProcessarParcelasTipoDias(
            Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos,
            string[] aux_condicaoPagtoDividida,
            int work_valor_entrada,
            decimal work_valor_parcela,
            decimal work_valor_resto_parcela,
            int aux_parcela_atual)
        {

            foreach (var current in aux_condicaoPagtoDividida)
            {
                CSICP_FF999 work_ff999 = new CSICP_FF999
                {
                    Id = _generateId.GenerateUuId(),
                    TenantId = in_Renegociacao_Calc_Titulos.in_tenantID,
                    Ff999IdControle = in_Renegociacao_Calc_Titulos.in_ChaveControle_ID,
                    Ff999Valorparcela = in_Renegociacao_Calc_Titulos.in_valorEntrada,
                    Ff999Parcela = aux_parcela_atual + 1,
                    Ff999Datavencto = in_Renegociacao_Calc_Titulos.in_data.AddDays(int.Parse(current))
                };

                if (EhSemEntrada(work_valor_entrada, aux_parcela_atual))
                {
                    work_ff999.Ff999Valorparcela = work_valor_parcela + work_valor_resto_parcela;
                    work_valor_resto_parcela = 0;
                }
                aux_parcela_atual += 1;
                _appDbContext.Add(work_ff999);
            }
            await _appDbContext.SaveChangesAsync();
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

        private static bool EhSemEntrada(int work_valor_entrada, int aux_parcela_atual)
        {
            return aux_parcela_atual != 0 || work_valor_entrada == 0;
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

        private static bool EhTipoParcelaDias(Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_ParcelaDias;
        }

        private static bool EhTipoParcelaMes(Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_ParcelaMes;
        }

        private static bool EhTipoAVista(Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_A_vista;
        }
    }
}
