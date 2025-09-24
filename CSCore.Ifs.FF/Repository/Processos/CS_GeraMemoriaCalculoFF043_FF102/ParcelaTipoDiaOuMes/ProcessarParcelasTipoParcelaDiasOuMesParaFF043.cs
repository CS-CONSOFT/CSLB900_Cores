using System;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.CalculoAdicaoDataStrategy;
using CSLB900.MSTools.Calculos;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;

public class ProcessarParcelasTipoParcelaDiasOuMesParaFF043 : ProcessarParcelasTipoParcelaDiasOuMes
{

    private readonly AppDbContext _appDbContext;

    private readonly decimal Fcn_Protocolo10;

    public ProcessarParcelasTipoParcelaDiasOuMesParaFF043(ProcessarParcelasTipoParcelaDiasOuMesParaFF043Input input)
           : base(input.GenerateId,
            input.Aux_condicaoPagtoDividida,
            input.Work_valor_entrada,
            input.AppDbContext,
            input.IncrementarDataStrategy)
    {
        this._appDbContext = input.AppDbContext;
        this.Fcn_Protocolo10 = input.Protocolo;   
    }


    /*ALTERANDO A ENTIDADE QUE SERÁ SALVA AO GERAR O CALCULO*/
    override protected TEntity? CriarEntidade<TEntity>(
        RetCalculoParcelasPorCondicao calculoCorrente, int InTenantID, string InIdControle) where TEntity : class
    {
        if (typeof(TEntity) != typeof(CSICP_FF043))
            throw new InvalidOperationException($"Tipo de entidade não suportado: {typeof(TEntity).Name}");

        var entidade = CSICP_FF043.Create(
            InTenantID: InTenantID,
            InFf042Id: long.Parse(InIdControle),
            ValorParcela: calculoCorrente.ValorParcela,
            Parcela: calculoCorrente.Parcela,
            DataVencimento: calculoCorrente.DataVencimento,
            Pfxtitulo: "",
            Protocolo: Fcn_Protocolo10
        );
        return entidade as TEntity;
    }

    /*ALTERANDO A ESTRATEGIA DE PERSISTENCIA, DELEGANDO ISSO, NESSE CASO, PARA O UNIT OF WORK, SEGUINDO O NOVO PADRAO*/
    override protected async Task PersistirAsync<TEntity>(List<TEntity> entidades)
    {
        await this._appDbContext.AddRangeAsync(entidades);
        // Não faz nada de commit, pois a persistência é gerenciada externamente no service
    }
}
