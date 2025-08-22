namespace CSCore.Ifs.FF.External.BancoDoBrasil.Interface
{
    public interface IBancoBrasilEnvioTitulos : IBancoDoBrasilAuth
    {
        Task CS01_Envio_Titulos(string in_ff102ID, int in_tenantID, int in_tipoRegistro);
    }
}
