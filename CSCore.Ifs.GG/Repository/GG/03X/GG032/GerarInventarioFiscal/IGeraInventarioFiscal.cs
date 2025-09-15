using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.GerarInventarioFiscal
{
    public interface IGeraInventarioFiscal
    {
        Task<string> Executar(string InOriginalGG032ID, CSICP_GG032 InCopiaGG032, int InTenantID);
    }
}
