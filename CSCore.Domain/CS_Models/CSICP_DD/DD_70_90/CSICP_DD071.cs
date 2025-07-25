using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD071
{
    public int TenantId { get; set; }

    public string Dd071Id { get; set; } = null!;

    public string? Dd070Id { get; set; }

    public int? Dd071Tipo { get; set; }

    public string? Dd071ContaId { get; set; }

    public int? Dd071Tipodocto { get; set; }

    public string? Dd071CnpjCpf { get; set; }

    public decimal? Dd071IeRg { get; set; }

    public string? Dd071Nome { get; set; }

    public string? Dd071Logradouro { get; set; }

    public string? Dd071Numero { get; set; }

    public string? Dd071Complemento { get; set; }

    public string? Dd071Perimetro { get; set; }

    public string? Dd071BairroId { get; set; }

    public string? Dd071Nomebairro { get; set; }

    public int? Dd071Cep { get; set; }

    public string? Dd071PaisId { get; set; }

    public string? Dd071UfId { get; set; }

    public string? Dd071CidadeId { get; set; }

    public string? Dd071Telefone { get; set; }

    public string? Dd071Email { get; set; }

    public string? Dd071Suframa { get; set; }

    public int? Dd071Modalidadefrete { get; set; }

    public string? Dd071Placaveiculo { get; set; }

    public string? Dd071Ufveiculo { get; set; }

    public string? Dd071Marcaveiculo { get; set; }

    public string? Dd071Numtransp { get; set; }

    public string? Dd071Placareboque { get; set; }

    public string? Dd071UfreboqueId { get; set; }

    public string? Dd071Numtranspreboq { get; set; }

    public string? Dd071Vagao { get; set; }

    public string? Dd071Balsa { get; set; }

    public string? Dd071EnderecoId { get; set; }

    public bool? Dd070SendEmail { get; set; }

    public bool? Dd070SendSms { get; set; }

    public string? Dd070UserOperadorId { get; set; }

    public DateTime? Dd071DataCaixa { get; set; }

    public string? Dd071Sms { get; set; }

    public string? Dd071Indfinal { get; set; }

    public string? Dd071IdentEstrangeiro { get; set; }

    public virtual CSICP_DD070? Dd070 { get; set; }

    public virtual CSICP_DD041Frete? Dd071ModalidadefreteNavigation { get; set; }

    public virtual CSICP_DD041Docto? Dd071TipodoctoNavigation { get; set; }
}
