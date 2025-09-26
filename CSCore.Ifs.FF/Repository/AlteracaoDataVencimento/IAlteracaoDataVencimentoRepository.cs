using CSCore.Ifs.FF.Repository.AlteracaoDataVencimento;

namespace CSCore.Ifs.FF.Repository.AlteracaoDataVencimento
{
    public interface IAlteracaoDataVencimentoRepository
    {
        Task<bool> ExecutarAlteracaoDataVencimento(PrmsAlteracaoDataVencimentoRepository InprmsAltDataVenc);
    }
}