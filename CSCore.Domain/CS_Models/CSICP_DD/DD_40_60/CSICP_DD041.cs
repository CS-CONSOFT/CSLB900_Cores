using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD041
{
    public int TenantId { get; set; }

    public string Dd041Id { get; set; } = null!;

    public string? Dd040Id { get; set; }

    public int? Dd041Tipo { get; set; }

    public string? Dd041ContaId { get; set; }

    public int? Dd041Tipodocto { get; set; }

    public string? Dd041CnpjCpf { get; set; }

    public string? Dd041Nome { get; set; }

    public string? Dd041Logradouro { get; set; }

    public string? Dd041Numero { get; set; }

    public string? Dd041Complemento { get; set; }

    public string? Dd041Perimetro { get; set; }

    public string? Dd041BairroId { get; set; }

    public string? Dd041Nomebairro { get; set; }

    public int? Dd041Cep { get; set; }

    public string? Dd041PaisId { get; set; }

    public string? Dd041UfId { get; set; }

    public string? Dd041CidadeId { get; set; }

    public decimal? Dd041IeRg { get; set; }

    public string? Dd041Suframa { get; set; }

    public string? Dd041Telefone { get; set; }

    public string? Dd041Email { get; set; }

    public string? Dd041TransportadoraId { get; set; }

    public string? Dd041Nometransp { get; set; }

    public int? Dd041Modalidadefrete { get; set; }

    public string? Dd041Placaveiculo { get; set; }

    public string? Dd041Ufveiculo { get; set; }

    public string? Dd041Marcaveiculo { get; set; }

    public string? Dd041Numtransp { get; set; }

    public string? Dd041Placareboque { get; set; }

    public string? Dd041UfreboqueId { get; set; }

    public string? Dd041Numtranspreboq { get; set; }

    public string? Dd041Vagao { get; set; }

    public string? Dd041Balsa { get; set; }

    public string? Dd041EnderecoId { get; set; }

    public bool? Dd041SendEmail { get; set; }

    public bool? Dd041SendSms { get; set; }

    public string? Dd041UserOperadorId { get; set; }

    public DateTime? Dd041DataCaixa { get; set; }

    public string? Dd041Sms { get; set; }

    public string? Dd041Indfinal { get; set; }

    public string? Dd041IdentEstrangeiro { get; set; }


    //Relacionamentos Navs
    public CSICP_BB012? NavBB012Conta { get; set; }
    public CSICP_BB012? NavBB012Trasportadora { get; set; }
    public CSICP_DD041Docto? NavDD041Doc { get; set; }
    public CSICP_Aa028? NavAA028 { get; set; }
    public CSICP_Aa027? NavAA027 { get; set; }
    public CSICP_Aa025? NavAA025 { get; set; }

}
