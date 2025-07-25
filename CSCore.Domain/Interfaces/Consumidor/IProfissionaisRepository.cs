namespace CSCore.Domain.Interfaces.Consumidor
{
    public interface IProfissionaisRepository
    {
        Task<IEnumerable<CSICP_Bb055>> Get_ListadeProfissionais(int tenant, string? search, int page, int pageSize);
        Task Post_AplicarAvaliacao(CSICP_Bb056 entity);
        Task Post_RegistraProfissional(CSICP_Bb055 entity);
        Task PostRegistraClickProfissional(CSICP_Bb057 entity);
        Task<IEnumerable<CSICP_Bb056>> Get_ListadeProfissionaisAvaliacao(
            int tenant,
            string profissionalID);

    }
}
