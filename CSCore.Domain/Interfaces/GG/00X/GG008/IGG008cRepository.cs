using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Domain.Interfaces.GG._00X
{
    public interface IGG008cRepository
    {
        public Task<(List<CSICP_GG008c>, int)> GetListRetornarImagensAsync(int tenant, string produtoGG008ID);
        public Task<(List<CSICP_GG008c>, int)> GetListRetornarCaracteristicaAsync(int tenant, string produtoGG008ID);
        public Task<(List<CSICP_GG008c>, int)> GetListRetornarFichaTecnicaAsync(int tenant, string produtoGG008ID);
        public Task<CSICP_GG008c?> GetByIdRetornarImagensAsync(int tenant, string produtoGG008ID, string imagemGG008cID);
        public Task<CSICP_GG008c?> GetByIdRetornarCaracteristicaAsync
            (int tenant, string produtoGG008ID, string? caracteristicaGG008cID);
        public Task<CSICP_GG008c?> GetByIdRetornarFichaTecnicaAsync
            (int tenant, string produtoGG008ID, string? fichaTecnicaGG008cID);

        public Task<CSICP_GG008c> CreateImagemAsync(CSICP_GG008c entity);
        public Task<CSICP_GG008c> UpdateImagemAsync(CSICP_GG008c entity);
        public Task DeleteImagemAsync(CSICP_GG008c entity);

        public Task<CSICP_GG008c> CreateFichaTecnicaAsync(CSICP_GG008c entity);
        public Task<CSICP_GG008c> UpdateFichaTecnicaAsync(CSICP_GG008c entity);

        public Task<CSICP_GG008c> CreateCaracteristicaAsync(CSICP_GG008c entity);
        public Task<CSICP_GG008c> UpdateCaracteristicaAsync(CSICP_GG008c entity);

    }
}
