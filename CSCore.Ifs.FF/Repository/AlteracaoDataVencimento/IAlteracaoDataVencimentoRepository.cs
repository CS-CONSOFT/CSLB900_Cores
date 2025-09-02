using CSCore.Ifs.FF.Repository.AlteracaoDataVencimento;
using CSCore.Ifs.FF.Repository.GravaOcorrencia;

namespace CSCore.Ifs.FF.Repository.AlteracaoDataVencimento
{
    public interface IAlteracaoDataVencimentoRepository
    {
        Task<bool> ExecutarAlteracaoDataVencimento(PrmAlteracaoDataVencimento parametros, int in_tenantID);
    }
}