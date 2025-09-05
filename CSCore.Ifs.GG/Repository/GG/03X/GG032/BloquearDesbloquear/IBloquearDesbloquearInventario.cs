namespace CSCore.Ifs.GG.Repository.GG._03X.GG032
{
    public interface IBloquearDesbloquearInventario
    {
        Task<bool> BloquearDesbloquearInventario(PrmBloquearDesbloquearInventario InPrmBloqDesbloq);
    }
}
