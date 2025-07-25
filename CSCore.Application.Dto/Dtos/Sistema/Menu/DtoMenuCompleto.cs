namespace CSSY103.C82Application.Dto.Menu
{
    public class DtoMenuCompleto
    {
        public List<DtoMenuiCorpDisponiveis> corpDisponiveis { get; set; } = new List<DtoMenuiCorpDisponiveis>();
        public int count { get; set; } = 0;
        public DateTimeOffset Init { get; set; }
        public DateTimeOffset Final { get; set; }
    }
}
