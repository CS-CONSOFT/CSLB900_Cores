namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ProcessarInventario
{
    public class PrmProcessarInventarioGG032
    {
        public int InTenant { get; set; }
        public string InInventarioId { get; set; } = string.Empty;
        public int InStIDGG032StaBloqueadoID { get; set; }
        public int InStIDGG032StaConcluidoID { get; set; }
        public int InStIDGG028EntSaidaSaidaID { get; set; }
        public int InStIDGG028EntSaidaEntradaID { get; set; }
        public int InStIDGG028NatInventarioID { get; set; }
    }
}
