



using CSCore.Domain;

namespace CSBS101._82Application.Dto.BB00X.BB03X.BB035
{
    public class Dto_GetBB035
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Bb035Primeironome { get; set; }

        public string? Bb035Sobrenome { get; set; }

        public string? Bb035Email { get; set; }

        public string? Bb035Titulo { get; set; }

        public string? Bb035Departamento { get; set; }

        public DateTime? Bb035DataAniversario { get; set; }

        public string? Bb035Telefone { get; set; }

        public string? Bb035Outrotelefone { get; set; }

        public string? Bb035Celular { get; set; }

        public string? Bb035Fax { get; set; }

        public string? Bb035Telefoneresidencia { get; set; }

        public string? Bb035Descricao { get; set; }

        public string? Bb035Assistente { get; set; }

        public string? Bb035Telefoneassist { get; set; }

        public string? Bb035Emailsecundario { get; set; }

        public string? Bb035Cpf { get; set; }

        public decimal? Bb035Rg { get; set; }

        public string? Bb035OrgaoExpedRg { get; set; }

        public DateTime? Bb035DataEmissaoRg { get; set; }

        public bool? Bb035IsActive { get; set; }

        public int? Bb035TratamentoId { get; set; }

        public int? Bb035OrigemcontatoId { get; set; }

        public int? Bb035CodgCliente7x { get; set; }

        public short? Bb035SeqCliente7x { get; set; }

        public CSICP_Bb035End? NavCSICP_BB035End { get; set; }
        public CSICP_Bb035Trat? NavCSICP_BB035Trat { get; set; } = null;
        public CSICP_Bb035Origem? NavCSICP_BB035Origem { get; set; }
    }

    public class Dto_GetBB035_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Bb035Primeironome { get; set; }

        public string? Bb035Sobrenome { get; set; }

    }
}
