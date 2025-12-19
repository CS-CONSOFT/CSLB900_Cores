using System;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSCore.Ifs.LB900.Repository;
using CSLB900.MSTools.CalculoAdicaoDataStrategy;
using CSLB900.MSTools.Calculos;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;

public class ProcessarParcelasTipoParcelaDiasOuMesParaFF043 : ProcessarParcelasTipoParcelaDiasOuMes
{

    private readonly AppDbContext _appDbContext;

    private readonly IGenerateProtocolo Fcn_Protocolo10;
    private readonly string[] _aux_condicaoPagtoDividida;
    private readonly string empresaID;
    private readonly decimal _work_valor_entrada;
    private readonly IIncrementarDataStrategy _incrementarDataStrategy;
    private readonly string PFX_FF003;

    public ProcessarParcelasTipoParcelaDiasOuMesParaFF043(ProcessarParcelasTipoParcelaDiasOuMesParaFF043Input input)
           : base(input.GenerateId,
            input.Aux_condicaoPagtoDividida,
            input.Work_valor_entrada,
            input.AppDbContext,
            input.IncrementarDataStrategy)
    {
        this._appDbContext = input.AppDbContext;
        this.Fcn_Protocolo10 = input.Protocolo;   
        this._aux_condicaoPagtoDividida = input.Aux_condicaoPagtoDividida;
        this._work_valor_entrada = input.Work_valor_entrada;
        this._incrementarDataStrategy = input.IncrementarDataStrategy;
        this.empresaID = input.EmpresaID;
        this.PFX_FF003 = input.PFX_FF003;
    }

    public override async Task GerarMemoriaCalculo(
    string InControleID,
    DateOnly InData,
    int InTenantID,
    RetornoFinanciamento in_calculoFinanciamento,
    decimal? _ = 0)
    {
        var condicaoPagamentoValidador = new CondicaoPagamentoDividia(_aux_condicaoPagtoDividida);
        var prm = new PrmCalculoParcelasPorCondicao
        {
            InCondicaoPagtoDividida = condicaoPagamentoValidador.GetCondicaoPagamento(),
            InFaturaTotal = in_calculoFinanciamento.ValorFaturaTotal,
            InValorEntrada = _work_valor_entrada,
            InDataCalculo = new DateTime(InData.Year, InData.Month, InData.Day),
        };

        List<RetCalculoParcelasPorCondicao> listaCalculoParcelasPorCondicao = CalculoParcelasPorCondicao.Calcular(prm, _incrementarDataStrategy);

        List<CSICP_FF043> entidadesParaInserir = new();
        decimal Protocolo = await this.Fcn_Protocolo10.Fcn_Protocolo10(empresaID, "CPAGAR", InTenantID);
        foreach (var calculoCorrente in listaCalculoParcelasPorCondicao)
        {
            var entidade = CriarEntidade<CSICP_FF043>(calculoCorrente, InTenantID, InControleID);
            entidade!.Ff043Titulo = Protocolo;
            if (entidade is null)
                continue;
            entidadesParaInserir.Add(entidade);
        }
        await PersistirAsync(entidadesParaInserir);
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
            Pfxtitulo: PFX_FF003,

            //setado dentro doforeach
            Protocolo: null
        );
        return entidade as TEntity;
    }

    /*ALTERANDO A ESTRATEGIA DE PERSISTENCIA, DELEGANDO ISSO, NESSE CASO, PARA O UNIT OF WORK, SEGUINDO O NOVO PADRAO*/
    override protected async Task PersistirAsync<TEntity>(List<TEntity> entidades)
    {
        if (entidades == null || entidades.Count == 0)
            return;
        foreach (var current in entidades)
        {
            if (current == null) continue;

            await this._appDbContext.AddAsync(current);
            // Não faz nada de commit, pois a persistência é gerenciada externamente no service    
        }

    }
}
