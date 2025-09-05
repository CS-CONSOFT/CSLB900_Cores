using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.CalculoAdicaoDataStrategy;
using CSLB900.MSTools.Calculos;
using CSLB900.MSTools.GenerateId;
using System.Net.WebSockets;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar
{
    public class ProcessarParcelasTipoParcelaDiasOuMes : IAuxProcessarCalculoTitulo
    {
        private readonly ICS_GenerateId _generateId;
        private readonly string[] _aux_condicaoPagtoDividida;
        private readonly decimal _work_valor_entrada;
        private readonly AppDbContext _appDbContext;
        private readonly IIncrementarDataStrategy _incrementarDataStrategy;

        public ProcessarParcelasTipoParcelaDiasOuMes(
            ICS_GenerateId generateId,
            string[] aux_condicaoPagtoDividida,
            decimal work_valor_entrada,
            AppDbContext appDbContext,
            IIncrementarDataStrategy incrementarDataStrategy)
        {
            _generateId = generateId;
            _aux_condicaoPagtoDividida = aux_condicaoPagtoDividida;
            _work_valor_entrada = work_valor_entrada;
            _appDbContext = appDbContext;
            _incrementarDataStrategy = incrementarDataStrategy;
        }

        public async Task Processar(
            Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos,
            RetornoFinanciamento in_calculoFinanciamento)
        {

            var prm = new PrmCalculoParcelasPorCondicao
            {
                InCondicaoPagtoDividida = _aux_condicaoPagtoDividida,
                InFaturaTotal = in_calculoFinanciamento.ValorFaturaTotal,
                InValorEntrada = _work_valor_entrada,
                InDataCalculo = in_Renegociacao_Calc_Titulos.in_data
            };

            List<RetCalculoParcelasPorCondicao> listaCalculoParcelasPorCondicao = CalculoParcelasPorCondicao.Calcular(prm, _incrementarDataStrategy);
            List<CSICP_FF999> entidadesParaInserir = [];
            foreach (var calculoCorrente in listaCalculoParcelasPorCondicao)
            {
                CSICP_FF999 work_ff999 = new()
                {
                    Id = _generateId.GenerateUuId(),
                    TenantId = in_Renegociacao_Calc_Titulos.in_TenantID,
                    Ff999IdControle = in_Renegociacao_Calc_Titulos.in_renegociacaoID,
                    Ff999Valorparcela = calculoCorrente.ValorParcela,
                    Ff999Parcela = calculoCorrente.Parcela,
                    Ff999Datavencto = calculoCorrente.DataVencimento
                };
                entidadesParaInserir.Add(work_ff999);
            }
            
            _appDbContext.AddRange(entidadesParaInserir);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
