using System;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.Calculos;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102.ParcelaTipoDia;

public class ProcessarParcelasTipoParcelaDiaParaFF043 : ProcessarCalculoTituloTipoDias
{
  private readonly decimal protocolo;
  private readonly AppDbContext _appDbContext;
  private readonly IEnumerable<string> _aux_condicaoPagtoDividida;
  public ProcessarParcelasTipoParcelaDiaParaFF043(
    decimal protcolo,
    AppDbContext appDbContext,
    ICS_GenerateId generateId,
    IEnumerable<string> aux_condicaoPagtoDividida,
   decimal work_valor_entrada) :
    base(appDbContext, generateId, aux_condicaoPagtoDividida, work_valor_entrada)
  {
    this.protocolo = protcolo;
    this._appDbContext = appDbContext;
        this._aux_condicaoPagtoDividida = aux_condicaoPagtoDividida;
  }

    public override async Task Processar(string InControleID, DateOnly InData, int InTenantID, RetornoFinanciamento in_calculoFinanciamento, decimal? InValorEntrada = 0)
    {
        int aux_parcela_atual = 0;
        List<CSICP_FF043> entidadesParaInserir = [];
        foreach (var diasPraAdd in _aux_condicaoPagtoDividida)
        {
            var entidade = CSICP_FF043.Create(
               InTenantID: InTenantID,
               InFf042Id: long.Parse(InControleID),
               ValorParcela: InValorEntrada ?? 0m,
               Parcela: aux_parcela_atual,
               DataVencimento: InData.ToDateTime(new TimeOnly(0, 0)).AddDays(int.Parse(diasPraAdd)),
               Pfxtitulo: "",
               Protocolo: protocolo
           );

            if (entidade is null) continue;

            entidadesParaInserir.Add(entidade);

            aux_parcela_atual += 1;
        }

        await PersistirAsync<CSICP_FF043>(entidadesParaInserir);
    }

    override protected TEntity? CriarEntidade<TEntity>(
              string InControleID,
              DateOnly InData,
              int InTenantID,
              RetornoFinanciamento in_calculoFinanciamento,
              int InAuxParcelaAtual,
              string InDiasPraAdicionar,
              decimal? InValorEntrada = 0) where TEntity : class
        {
          if (typeof(TEntity) != typeof(CSICP_FF043))
            throw new InvalidOperationException($"Tipo de entidade não suportado: {typeof(TEntity).Name}");

          var entidade = CSICP_FF043.Create(
                InTenantID: InTenantID,
                InFf042Id: long.Parse(InControleID),
                ValorParcela: InValorEntrada ?? 0m,
                Parcela: InAuxParcelaAtual,
                DataVencimento: InData.ToDateTime(new TimeOnly(0, 0)).AddDays(int.Parse(InDiasPraAdicionar)),
                Pfxtitulo: "",
                Protocolo: protocolo
            );
            return entidade as TEntity;
        }

        override protected async Task PersistirAsync<TEntity>(List<TEntity> entidades)
        {
        foreach (var item in entidades)
        {
            if (item is null) continue;
            await _appDbContext.AddAsync(item);
        }

        // Não faz nada de commit, pois a persistência é gerenciada externamente no service
    }
}


