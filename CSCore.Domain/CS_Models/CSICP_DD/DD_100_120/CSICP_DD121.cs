using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD121
{
    public int TenantId { get; set; }

    public string Dd121Id { get; set; } = null!;

    public string? Dd120Id { get; set; }

    public int? Dd121Tipo { get; set; }

    public string? Dd121ContaId { get; set; }

    public int? Dd121Tipodocto { get; set; }

    public string? Dd121CnpjCpf { get; set; }

    public string? Dd121Nome { get; set; }

    public string? Dd121Logradouro { get; set; }

    public string? Dd121Numero { get; set; }

    public string? Dd121Complemento { get; set; }

    public string? Dd121Perimetro { get; set; }

    public string? Dd121BairroId { get; set; }

    public string? Dd121Nomebairro { get; set; }

    public int? Dd121Cep { get; set; }

    public string? Dd121PaisId { get; set; }

    public string? Dd121UfId { get; set; }

    public string? Dd121CidadeId { get; set; }

    public decimal? Dd121IeRg { get; set; }

    public string? Dd121Suframa { get; set; }

    public string? Dd121Telefone { get; set; }

    public string? Dd121Email { get; set; }

    public string? Dd121IsSendEmail { get; set; }

    public bool? Dd121IsSendSms { get; set; }

    public string? Dd121Nrosms { get; set; }

    public virtual CSICP_DD120? Dd120 { get; set; }

    public virtual CSICP_DD041Docto? Dd121TipodoctoNavigation { get; set; }
}
