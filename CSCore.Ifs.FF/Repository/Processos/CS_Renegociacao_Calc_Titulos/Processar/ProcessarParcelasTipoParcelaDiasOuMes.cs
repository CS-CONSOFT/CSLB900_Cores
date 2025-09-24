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

            var condicaoPagamentoValidador = new CondicaoPagamentoDividia(_aux_condicaoPagtoDividida);
            var prm = new PrmCalculoParcelasPorCondicao
            {
                InCondicaoPagtoDividida = condicaoPagamentoValidador.GetCondicaoPagamento(),
                InFaturaTotal = in_calculoFinanciamento.ValorFaturaTotal,
                InValorEntrada = _work_valor_entrada,
                InDataCalculo = in_Renegociacao_Calc_Titulos.in_data
            };

            List<RetCalculoParcelasPorCondicao> listaCalculoParcelasPorCondicao = CalculoParcelasPorCondicao.Calcular(prm, _incrementarDataStrategy);
            List<CSICP_FF999> entidadesParaInserir = [];
            foreach (var calculoCorrente in listaCalculoParcelasPorCondicao)
            {
                var entidade = await CriarEntidade<CSICP_FF999>(calculoCorrente, in_Renegociacao_Calc_Titulos.in_TenantID, in_Renegociacao_Calc_Titulos.in_renegociacaoID);
                if(entidade is null)
                    continue;
                entidadesParaInserir.Add(entidade);
            }
            await PersistirAsync(entidadesParaInserir);
        }

        protected virtual Task<TEntity?> CriarEntidade<TEntity>(
            RetCalculoParcelasPorCondicao calculoCorrente,
            int InTenantID,
            string InIdControle)   where TEntity : class
        {
                var entidade = new CSICP_FF999
                {
                    Id = _generateId.GenerateUuId(),
                    TenantId = InTenantID,
                    Ff999IdControle = InIdControle,
                    Ff999Valorparcela = calculoCorrente.ValorParcela,
                    Ff999Parcela = calculoCorrente.Parcela,
                    Ff999Datavencto = calculoCorrente.DataVencimento
                };
                return Task.FromResult(entidade as TEntity);
        }
        
        protected virtual async Task PersistirAsync<TEntity>(List<TEntity> entidades)
        {
            _appDbContext.AddRange(entidades);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
