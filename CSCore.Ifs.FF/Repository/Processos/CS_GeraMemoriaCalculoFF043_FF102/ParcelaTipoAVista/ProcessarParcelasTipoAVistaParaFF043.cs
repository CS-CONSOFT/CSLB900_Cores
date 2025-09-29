using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.CalculoAdicaoDataStrategy;
using CSLB900.MSTools.Calculos;
using CSLB900.MSTools.GenerateId;
using System;

namespace CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102.ParcelaTipoAVista;

public class ProcessarParcelasTipoAVistaParaFF043 : ProcessarCalculoTipoAVista
{
    private readonly IGenerateProtocolo protocolo;
    private readonly AppDbContext _appDbContext;

    public ProcessarParcelasTipoAVistaParaFF043(IGenerateProtocolo protocolo, AppDbContext appDbContext, ICS_GenerateId generateId) : base(appDbContext, generateId)
    {
        this.protocolo = protocolo;
        this._appDbContext = appDbContext;
    }

    public override async Task Processar(
       string InControleID,
            DateOnly InData,
            int InTenantID,
            RetornoFinanciamento in_calculoFinanciamento,
       decimal? InValorEntrada = 0)
            {
        var entidade = CriarEntidade<CSICP_FF043>(
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


    public override TEntity? CriarEntidade<TEntity>(
        string InControleID,
        DateOnly InData,
        int InTenantID,
        RetornoFinanciamento in_calculoFinanciamento,
        int InAuxParcelaAtual,
        string InDiasPraAdicionar,
        decimal? InValorEntrada = 0)
        where TEntity : class
    {
        if (typeof(TEntity) != typeof(CSICP_FF043))
            return null;

        var entidade = CSICP_FF043.Create(
            InTenantID,
            long.Parse(InControleID),
            in_calculoFinanciamento.ValorFinanciado,
            Parcela: 1,
            InData.ToDateTime(new TimeOnly(0, 0)),
            string.Empty,
            Protocolo: null
            );
        return entidade as TEntity;
    }
    
    public override async Task PersistirAsync<TEntity>(List<TEntity> entidades)
    {
        await this._appDbContext.AddRangeAsync(entidades);
        // Não faz nada de commit, pois a persistência é gerenciada externamente no service
    }
}
