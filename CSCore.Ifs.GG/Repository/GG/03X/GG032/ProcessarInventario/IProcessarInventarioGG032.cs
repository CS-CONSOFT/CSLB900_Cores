namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ProcessarInventario
{
    public interface IProcessarInventarioGG032
    {
        Task<bool> ProcessarInventario(PrmProcessarInventarioGG032 InPrmProcessarInventario);
    }
}
