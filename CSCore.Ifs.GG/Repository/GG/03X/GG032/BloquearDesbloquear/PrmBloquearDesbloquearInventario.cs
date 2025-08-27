namespace CSCore.Ifs.GG.Repository.GG._03X.GG032
{
    public class PrmBloquearDesbloquearInventario
    {
        public int InTenantID { get; set; }
        public string InInventarioID { get; set; } = string.Empty;
        public int InTipoAcaoInventario { get; set; }
        public int InSTIDCsicpGg032StaBloqueadoID { get; set; }
        public int InSTIDCsicpGg032StaSolicitadoID { get; set; }
    }
}
