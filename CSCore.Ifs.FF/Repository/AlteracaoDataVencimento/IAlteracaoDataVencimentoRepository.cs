using CSCore.Ifs.FF.Repository.AlteracaoDataVencimento;
using CSCore.Ifs.FF.Repository.GravaOcorrencia;

namespace CSCore.Ifs.FF.Repository.AlteracaoDataVencimento
{
    public interface IAlteracaoDataVencimentoRepository
    {
        Task<bool> ExecutarAlteracaoDataVencimento(PrmsAlteracaoDataVencimentoRepository InprmsAltDataVenc);
    }
}