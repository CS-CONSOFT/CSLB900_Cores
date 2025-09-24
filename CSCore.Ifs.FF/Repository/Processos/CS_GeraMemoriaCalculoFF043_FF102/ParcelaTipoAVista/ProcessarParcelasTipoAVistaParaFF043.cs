using System;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102.ParcelaTipoAVista;

public class ProcessarParcelasTipoAVistaParaFF043 : ProcessarCalculoTipoAVista
{
    private readonly decimal protocolo;
    private readonly AppDbContext _appDbContext;

    public ProcessarParcelasTipoAVistaParaFF043(decimal protocolo, AppDbContext appDbContext, ICS_GenerateId generateId) : base(appDbContext, generateId)
    {
        this.protocolo = protocolo;
        this._appDbContext = appDbContext;
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
            protocolo
            );
        return entidade as TEntity;
    }
    
    public override async Task PersistirAsync<TEntity>(List<TEntity> entidades)
    {
        await this._appDbContext.AddRangeAsync(entidades);
        // Não faz nada de commit, pois a persistência é gerenciada externamente no service
    }
}
