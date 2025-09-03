using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar
{
    public class ProcessarParcelasTipoParcelaDiasOuMes : IAuxProcessarCalculoTitulo
    {
        private readonly ICS_GenerateId _generateId;
        private readonly string[] _aux_condicaoPagtoDividida;
        private readonly int _aux_qtd_parcelas;
        private readonly bool _isParcelaMes;
        private readonly decimal _work_valor_entrada;
        private readonly AppDbContext _appDbContext;

        public ProcessarParcelasTipoParcelaDiasOuMes(
            ICS_GenerateId generateId,
            string[] aux_condicaoPagtoDividida,
            int aux_qtd_parcelas,
            bool isParcelaMes,
            decimal work_valor_entrada,
            AppDbContext appDbContext)
        {
            _generateId = generateId;
            _aux_condicaoPagtoDividida = aux_condicaoPagtoDividida;
            _aux_qtd_parcelas = aux_qtd_parcelas;
            _isParcelaMes = isParcelaMes;
            _work_valor_entrada = work_valor_entrada;
            _appDbContext = appDbContext;
        }

        public async Task Processar(
            Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos,
            RetornoFinanciamento in_calculoFinanciamento)
        {

            int entrada = int.Parse(_aux_condicaoPagtoDividida[1]);
            int intervaloParcelas = int.Parse(_aux_condicaoPagtoDividida[2]);

            for (int parcelaAtual = 1; parcelaAtual <= _aux_qtd_parcelas; parcelaAtual++)
            {
                var isEntrada = PossuiEntrada(_work_valor_entrada, parcelaAtual, entrada);

                CSICP_FF999 work_ff999 = new CSICP_FF999
                {
                    Id = _generateId.GenerateUuId(),
                    TenantId = in_Renegociacao_Calc_Titulos.in_TenantID,
                    Ff999IdControle = in_Renegociacao_Calc_Titulos.in_renegociacaoID,
                    Ff999Valorparcela = in_Renegociacao_Calc_Titulos.in_valorEntrada + in_calculoFinanciamento.ValorRestoParcela,
                    Ff999Parcela = parcelaAtual,
                    Ff999Datavencto = _isParcelaMes ?
                   in_Renegociacao_Calc_Titulos.in_data.AddMonths(entrada)
                   : in_Renegociacao_Calc_Titulos.in_data.AddDays(entrada)
                };

                if (!isEntrada)
                {
                    if(parcelaAtual > 2 ) intervaloParcelas += intervaloParcelas;

                    work_ff999.Ff999Valorparcela =
                        in_calculoFinanciamento.ValorParcela;

                    in_calculoFinanciamento.ValorRestoParcela = 0;

                    work_ff999.Ff999Datavencto = _isParcelaMes ?
                    in_Renegociacao_Calc_Titulos.in_data.AddMonths(intervaloParcelas)
                    : in_Renegociacao_Calc_Titulos.in_data.AddDays(intervaloParcelas);
                }
                _appDbContext.Add(work_ff999);
   
            }
            await _appDbContext.SaveChangesAsync();
        }

        private static bool PossuiEntrada(
            decimal work_valor_entrada,
            int aux_parcela_atual,
            int aux_dias_mes_entrada)
        {
            return aux_parcela_atual == 1 && aux_dias_mes_entrada != 0 && work_valor_entrada > 0;
        }

    }
}
