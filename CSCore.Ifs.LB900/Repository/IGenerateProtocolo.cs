namespace CSCore.Ifs.Eventos.Repository
{
    public interface IGenerateProtocolo
    {
        public Task<decimal> Fcn_Protocolo(string empresaID, string arquivo, string textName);
        public Task<decimal> Fcn_Protocolo15(string empresaID, string arquivo);
        public Task<decimal> Fcn_Protocolo10(string empresaID, string arquivo);
        public Task<decimal> Fcn_ProtocoloGeral(string empresaID);
    }
}
