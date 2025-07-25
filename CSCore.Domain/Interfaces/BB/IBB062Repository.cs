namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB062Repository : IBaseCrud<CSICP_Bb062>
    {
        Task<CSICP_Bb062?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb062>> GetListAsync(int tenant, string? search);
        Task GerarTitulosConvenio(
            int in_tenant,
            string in_estabelecimentoID,
            long in_bb062_Id,
            int in_StID_bb1201_con_cartaoInternoID,
            int in_StID_bb062_sta_Fechado_ID,
            int in_StID_ff102_Ent_Parcela,
            int in_StID_ff102_Sit_Aberto);
    }
}
