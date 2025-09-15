
namespace CSCore.Ifs.FF.Repository.AplicaSemJuros
{
    public interface IAplicaSemJurosRepository
    {
        Task<bool> ExecutarAplicaSemJuros(PrmsAnaliseSemJurosRepository prmsAnaliseSJuros);
    }
}
