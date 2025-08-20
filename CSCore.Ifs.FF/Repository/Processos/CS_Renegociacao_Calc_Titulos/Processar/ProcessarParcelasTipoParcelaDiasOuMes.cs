using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
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

        public ProcessarParcelasTipoParcelaDiasOuMes(ICS_GenerateId generateId, string[] aux_condicaoPagtoDividida, int aux_qtd_parcelas, bool isParcelaMes, decimal work_valor_entrada, AppDbContext appDbContext)
        {
            _generateId = generateId;
            _aux_condicaoPagtoDividida = aux_condicaoPagtoDividida;
            _aux_qtd_parcelas = aux_qtd_parcelas;
            _isParcelaMes = isParcelaMes;
            _work_valor_entrada = work_valor_entrada;
            _appDbContext = appDbContext;
        }

        public async Task Processar(
            Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos,
            (decimal ValorParcela, decimal ValorRestoParcela, decimal ValorFinanciado) in_calculoFinanciamento)
        {
            int aux_dias_mes_entrada = int.Parse(_aux_condicaoPagtoDividida[0]);
            int aux_dias_mes_intervalo = int.Parse(_aux_condicaoPagtoDividida[1]);
            int aux_parcela_atual = 0;
            while (aux_parcela_atual <= _aux_qtd_parcelas)
            {
                CSICP_FF999 work_ff999 = new CSICP_FF999
                {
                    Id = _generateId.GenerateUuId(),
                    TenantId = in_Renegociacao_Calc_Titulos.in_tenantID,
                    Ff999IdControle = in_Renegociacao_Calc_Titulos.in_ChaveControle_ID,
                    Ff999Valorparcela = in_Renegociacao_Calc_Titulos.in_valorEntrada,
                    Ff999Parcela = aux_parcela_atual + 1,
                    Ff999Datavencto = _isParcelaMes ? in_Renegociacao_Calc_Titulos.in_data.AddMonths(aux_dias_mes_entrada) : in_Renegociacao_Calc_Titulos.in_data.AddDays(aux_dias_mes_entrada)
                };
                if (!PossuiEntrada(_work_valor_entrada, aux_parcela_atual, aux_dias_mes_entrada))
                {
                    work_ff999.Ff999Datavencto = _isParcelaMes ? in_Renegociacao_Calc_Titulos.in_data.AddMonths(aux_dias_mes_intervalo) : in_Renegociacao_Calc_Titulos.in_data.AddDays(aux_dias_mes_intervalo);
                    in_calculoFinanciamento.ValorParcela = 0;
                }
                _appDbContext.Add(work_ff999);
                aux_parcela_atual += 1;
            }
            await _appDbContext.SaveChangesAsync();
        }

        private static bool PossuiEntrada(decimal work_valor_entrada, int aux_parcela_atual, int aux_dias_mes_entrada)
        {
            return aux_parcela_atual == 1 && aux_dias_mes_entrada > 0 && work_valor_entrada > 0;
        }

    }
}
