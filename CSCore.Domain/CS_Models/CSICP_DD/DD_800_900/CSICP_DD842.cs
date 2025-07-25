using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD842
{
    public int TenantId { get; set; }

    public long Dd842Id { get; set; }

    public long? Dd840Id { get; set; }

    public int? Dd842Tipo { get; set; }

    public string? Dd842ContaId { get; set; }

    public int? Dd842Tipodocto { get; set; }

    public string? Dd842CnpjCpf { get; set; }

    public string? Dd842Nome { get; set; }

    public string? Dd842Logradouro { get; set; }

    public string? Dd842Numero { get; set; }

    public string? Dd842Complemento { get; set; }

    public string? Dd842Perimetro { get; set; }

    public string? Dd842Nomebairro { get; set; }

    public int? Dd842Cep { get; set; }

    public string? Dd842PaisId { get; set; }

    public string? Dd842UfId { get; set; }

    public string? Dd842CidadeId { get; set; }

    public decimal? Dd842IeRg { get; set; }

    public string? Dd842Suframa { get; set; }

    public string? Dd842Telefone { get; set; }

    public string? Dd842Email { get; set; }

    public string? Dd842TransportadoraId { get; set; }

    public string? Dd842Nometransp { get; set; }

    public string? Dd842Placaveiculo { get; set; }

    public string? Dd842Ufveiculo { get; set; }

    public string? Dd842Marcaveiculo { get; set; }

    public string? Dd842Numtransp { get; set; }

    public string? Dd842Placareboque { get; set; }

    public string? Dd842UfreboqueId { get; set; }

    public string? Dd842Numtranspreboq { get; set; }

    public string? Dd842Vagao { get; set; }

    public string? Dd842Balsa { get; set; }

    public string? Dd842EnderecoId { get; set; }

    public bool? Dd842SendEmail { get; set; }

    public bool? Dd842SendSms { get; set; }

    public string? Dd842UserOperadorId { get; set; }

    public DateTime? Dd842DataCaixa { get; set; }

    public string? Dd842Sms { get; set; }

    public string? Dd842Indfinal { get; set; }

    public string? Dd842IdentEstrangeiro { get; set; }

    public virtual CSICP_DD840? Dd840 { get; set; }

    public virtual CSICP_DD041Docto? Dd842TipodoctoNavigation { get; set; }
}
