using CSCore.Domain.CS_Models.CSICP_AA;

namespace CSCore.Domain.Interfaces
{
    public interface ITokenGenericoRepository
    {
        Task<CSICP_AA030?> GetTokenGenericoPorLabel(string Token, int Tenant);
        Task<CSICP_AA030?> GetTokenGenericoPorEstabelecimento(string? EstabelecimentoID, string Token, int Tenant);
        Task<List<CSICP_Aa030Tptoken>> GetEstaticasToken();
    }
}
