namespace CSCore.Domain
{
    public partial class CSICP_Bb036
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Bb036Primeironome { get; set; }

        public string? Bb036Sobrenome { get; set; }

        public string? Bb036Empresa { get; set; }

        public string? Bb036Email { get; set; }

        public string? Bb036Emailsecundario { get; set; }

        public string? Bb036Titulo { get; set; }

        public string? Bb036Telefone { get; set; }

        public string? Bb036Celular { get; set; }

        public string? Bb036Fax { get; set; }

        public string? Bb036Site { get; set; }

        public string? Bb036Descricao { get; set; }

        public bool? Bb036IsActive { get; set; }

        public int? Bb036TratamentoId { get; set; }

        public int? Bb036SituacaoId { get; set; }

        public string? Bb036Atividadeid { get; set; }

        public CSICP_Bb011? Bb036Atividade { get; set; }

        //public ICollection<CSICP_Bb036Ender> OsusrE9aCsicpBb036Enders { get; set; } = new List<CSICP_Bb036Ender>();
    }
}
