using CSBS101._82Application.Dto.BB00X.BB011;

namespace CSBS101._82Application.Dto.BB00X.BB036
{
    public class Dto_GetBB036
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

        public Dto_GetBB011? NavBb036Atividade { get; set; }
    }
}
