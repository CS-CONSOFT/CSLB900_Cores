namespace CSCore.Ifs.Eventos.Repository
{
    public interface IGenerateProtocolo
    {
        public Task<decimal> Fcn_Protocolo(string empresaID, string arquivo, string textName, int inTenantID, bool hasToCommit = true);
        public Task<decimal> Fcn_Protocolo15(string empresaID, string arquivo, int inTenantID, bool hasToCommit = true);
        public Task<decimal> Fcn_Protocolo10(string empresaID, string arquivo, int InTenantID, bool hasToCommit = true);
        public Task<decimal> Fcn_ProtocoloGeral(string empresaID, int InTenantID, bool hasToCommit = true);
        
    }
}
