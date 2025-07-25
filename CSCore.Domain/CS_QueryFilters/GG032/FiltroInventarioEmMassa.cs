namespace CSCore.Domain.CS_QueryFilters.GG032
{
    public class FiltroProdutoRequest
    {
        public string FilialID { get; set; } = string.Empty;
        public List<string> GrupoIds { get; set; } = [];
        public List<string> SubGrupoIds { get; set; } = [];
        public List<string> ClasseIds { get; set; } = [];
        public List<string> MarcaIds { get; set; } = [];
        public List<string> ArtigoIds { get; set; } = [];
        public int GG032_TipoInventarioId { get; set; }
        public int GG032_StatusID { get; set; }
        public string? UsuarioID { get; set; }
        public string AlmoxID { get; set; } = string.Empty;
        public TIPO_SALDO TipoSaldo { get; set; }
    }

    public enum TIPO_SALDO
    {
        COM_SALDO = 1,
        SEM_SALDO = 2,
        NEGATIVO_SALDO = 3
    }
}
