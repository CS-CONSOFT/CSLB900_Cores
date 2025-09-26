using System;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.CalculoAdicaoDataStrategy;
using CSLB900.MSTools.Calculos;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;

public record ProcessarParcelasTipoParcelaDiasOuMesParaFF043Input(
        IGenerateProtocolo GenerateProtocolo,
        ICS_GenerateId GenerateId,
        string EmpresaID,
        string[] Aux_condicaoPagtoDividida,
        decimal Work_valor_entrada,
        AppDbContext AppDbContext,
        IIncrementarDataStrategy IncrementarDataStrategy
);

public class ProcessarParcelasTipoParcelaDiasOuMesParaFF043 : ProcessarParcelasTipoParcelaDiasOuMes
{
    private readonly IGenerateProtocolo generateProtocolo;
    private readonly AppDbContext _appDbContext;

    private readonly string _empresaID;
    public ProcessarParcelasTipoParcelaDiasOuMesParaFF043(ProcessarParcelasTipoParcelaDiasOuMesParaFF043Input input)
           : base(input.GenerateId,
            input.Aux_condicaoPagtoDividida,
            input.Work_valor_entrada,
            input.AppDbContext,
            input.IncrementarDataStrategy)
    {
        this.generateProtocolo = input.GenerateProtocolo;
        this._empresaID = input.EmpresaID;
        this._appDbContext = input.AppDbContext;
    }


    /*ALTERANDO A ENTIDADE QUE SERÁ SALVA AO GERAR O CALCULO*/
    override protected async Task<TEntity?> CriarEntidade<TEntity>(
        RetCalculoParcelasPorCondicao calculoCorrente, int InTenantID, string InIdControle) where TEntity : class
    {
        if (typeof(TEntity) != typeof(CSICP_FF043))
            throw new InvalidOperationException($"Tipo de entidade não suportado: {typeof(TEntity).Name}");

        var protcolo = await generateProtocolo.Fcn_Protocolo10(this._empresaID, "CPAGAR", InTenantID);

        var entidade = CSICP_FF043.Create(
            InTenantID: InTenantID,
            InFf042Id: long.Parse(InIdControle),
            ValorParcela: calculoCorrente.ValorParcela,
            Parcela: calculoCorrente.Parcela,
            DataVencimento: calculoCorrente.DataVencimento,
            Pfxtitulo: "",
            Protocolo: protcolo
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
