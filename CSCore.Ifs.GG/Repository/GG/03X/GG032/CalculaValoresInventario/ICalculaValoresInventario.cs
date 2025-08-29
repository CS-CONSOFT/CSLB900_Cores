namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.CalculaValoresInventario
{
    public interface ICalculaValoresInventario
    {
        Task<string> Calcular(string InGG032ID, int InTenantID);
    }
}
