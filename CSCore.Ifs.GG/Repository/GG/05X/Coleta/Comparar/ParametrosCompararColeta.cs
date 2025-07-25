namespace CSCore.Ifs.GG.Repository.GG._05X.Coleta.Comparar
{
    public class ParametrosCompararColeta
    {
        public int TenantId { get; set; } = int.MinValue;
        public string NumeroProtocoloColeta01 { get; set; } = string.Empty;
        public string NumeroProtocoloColeta02 { get; set; } = string.Empty;
        public long IdCC081_CD_Criar { get; set; } = long.MinValue;
        public long IdGG054Sta_Aberto { get; set; } = long.MinValue;
    }
}
