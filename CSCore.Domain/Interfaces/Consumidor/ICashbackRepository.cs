using CSCore.Domain.CS_Models.CSICP_DD;

namespace CSCore.Domain.Interfaces.Consumidor
{
    public interface ICashbackRepository
    {
        Task<List<CSICP_DD126>> Get_MovimentosCashback(int tenant, string? BB012_ID);
        Task<string?> GetSaldoCashback(int tenant, string? BB012_ID);
        Task<List<CSICP_DD142>> Get_CashbackConta
            (int tenant, string? BB012_ID, decimal? CPF, string LabelTipoCashback);
    }
}

