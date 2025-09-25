using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.Calculos;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar
{
    public class ProcessarCalculoTituloTipoDias : IAuxProcessarCalculoTitulo
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICS_GenerateId _generateId;
        private readonly IEnumerable<string> _aux_condicaoPagtoDividida;
        private readonly decimal _work_valor_entrada;

        public ProcessarCalculoTituloTipoDias(
            AppDbContext appDbContext,
            ICS_GenerateId generateId,
            IEnumerable<string> aux_condicaoPagtoDividida,
            decimal work_valor_entrada)
        {
            _appDbContext = appDbContext;
            _generateId = generateId;
            _aux_condicaoPagtoDividida = aux_condicaoPagtoDividida;
            _work_valor_entrada = work_valor_entrada;
        }

        public virtual async Task Processar(
            /// <summary>
            /// Identificador do processo em que esse método será usado
            /// Ex. Ao processar ProcessarParcelasTipoParcelaDiasOuMes no processo de 
            /// Calculo da renegociação, esse ID será o ID da renegociação
            /// Já no gerar memória de cálculo FF043, será o ID da FF042
            /// Então é importante que esse ID seja passado para que a entidade que será criada
            /// tenha a referência correta
            /// </summary>
            string InControleID,
            DateOnly InData,
            int InTenantID,
            RetornoFinanciamento in_calculoFinanciamento,
            // <summary>
            /// Parâmetros necessários para o cálculo das parcelas quando se tem entrada, usado em CS_Renegociacao_Calc_Titulos
            /// </summary>
            decimal? InValorEntrada = 0)
        {
            int aux_parcela_atual = 0;
            List<CSICP_FF999> entidadesParaInserir = [];
            foreach (var current in _aux_condicaoPagtoDividida)
            {
                var entidade = CriarEntidade<CSICP_FF999>(
                    InControleID,
                    InData,
                    InTenantID,
                    in_calculoFinanciamento,
                    aux_parcela_atual,
                    current,
                    InValorEntrada);

                if (entidade is null) continue;

                entidadesParaInserir.Add(entidade);

                aux_parcela_atual += 1;
            }

            await PersistirAsync<CSICP_FF999>(entidadesParaInserir);
        }



        protected virtual TEntity? CriarEntidade<TEntity>(
            string InControleID,
            DateOnly InData,
            int InTenantID,
            RetornoFinanciamento in_calculoFinanciamento,
            int InAuxParcelaAtual,
            string InDiasPraAdicionar,
            decimal? InValorEntrada = 0) where TEntity : class
        {
            CSICP_FF999 work_ff999 = new()
            {
                Id = _generateId.GenerateUuId(),
                TenantId = InTenantID,
                Ff999IdControle = InControleID,
                Ff999Valorparcela = InValorEntrada,
                Ff999Parcela = InAuxParcelaAtual + 1,
                Ff999Datavencto = InData.ToDateTime(new TimeOnly(0, 0)).AddDays(int.Parse(InDiasPraAdicionar))
            };

            if (EhSemEntrada(_work_valor_entrada, InAuxParcelaAtual))
            {
                work_ff999.Ff999Valorparcela
                    = in_calculoFinanciamento.ValorParcela + in_calculoFinanciamento.ValorRestoParcela;
                in_calculoFinanciamento.ValorRestoParcela = 0;
            }
            return work_ff999 as TEntity;
        }

        protected virtual async Task PersistirAsync<TEntity>(List<TEntity> entidades)
        {
            entidades = entidades.Where(e => e != null).ToList();
            foreach (var item in entidades)
            {
                if (item is null) continue;
                _appDbContext.Add(item);
            }
            
            await _appDbContext.SaveChangesAsync();
        }


        private static bool EhSemEntrada(decimal work_valor_entrada, int aux_parcela_atual)
        {
            return aux_parcela_atual != 0 || work_valor_entrada == 0;
        }
    }
}
