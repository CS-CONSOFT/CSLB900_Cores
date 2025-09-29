using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.Calculos;
using CSLB900.MSTools.GenerateId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar
{
    public class ProcessarCalculoTipoAVista : IAuxProcessarCalculoTitulo
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICS_GenerateId _generateId;

        public ProcessarCalculoTipoAVista(AppDbContext appDbContext, ICS_GenerateId generateId)
        {
            _appDbContext = appDbContext;
            _generateId = generateId;
        }

        public async virtual Task Processar(
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
            /// <summary>
            /// Parâmetros necessários para o cálculo das parcelas quando se tem entrada, usado em CS_Renegociacao_Calc_Titulos
            /// </summary>
            decimal? InValorEntrada = 0)
        {
            var entidade = CriarEntidade<CSICP_FF999>(
                InControleID,
                InData,
                InTenantID,
                in_calculoFinanciamento,
                InAuxParcelaAtual: 1,
                string.Empty,
                InValorEntrada);
            if (entidade != null)
                await PersistirAsync(entidade);
        }

        public virtual TEntity? CriarEntidade<TEntity>(
            string InControleID,
            DateOnly InData,
            int InTenantID,
            RetornoFinanciamento in_calculoFinanciamento,
            int InAuxParcelaAtual,
            string InDiasPraAdicionar,
            decimal? InValorEntrada = 0) where TEntity : class
        {
            CSICP_FF999 work_ff999 = new CSICP_FF999
            {
                Id = _generateId.GenerateUuId(),
                TenantId = InTenantID,
                Ff999IdControle = InControleID,
                Ff999Valorparcela = in_calculoFinanciamento.ValorFinanciado,
                Ff999Parcela = 1,
                Ff999Datavencto = InData.ToDateTime(new TimeOnly(0, 0)),
            };
            return work_ff999 as TEntity;
        }

        public virtual async Task PersistirAsync<TEntity>(List<TEntity> entidades)
        {
            _appDbContext.AddRange(entidades);
            await _appDbContext.SaveChangesAsync();
        }

        public virtual async Task PersistirAsync<TEntity>(TEntity entidade)
        {
            if (entidade != null)
            {
                _appDbContext.Add(entidade);
                await _appDbContext.SaveChangesAsync();
            }
            
        }
    }
}
