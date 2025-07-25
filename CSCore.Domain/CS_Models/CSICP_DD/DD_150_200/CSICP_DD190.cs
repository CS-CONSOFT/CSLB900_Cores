using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD190
{
    public int TenantId { get; set; }

    public long Dd190Id { get; set; }

    public string? Dd190Skid { get; set; }

    public string? Dd190Estabid { get; set; }

    public string? Dd190Contaclienteid { get; set; }

    public string? Dd190Protocolnumber { get; set; }

    public DateTime? Dd190Dmovto { get; set; }

    public DateTime? Dd190Dinicioexec { get; set; }

    public DateTime? Dd190Dfinalexec { get; set; }

    public string? Dd190Resptecnicoid { get; set; }

    public string? Dd190Descricao { get; set; }

    public decimal? Dd190Pandamento { get; set; }

    public string? Dd190Usuariopropid { get; set; }

    public DateTime? Dd190Dinclusao { get; set; }

    public string? Dd190Usuarioalt { get; set; }

    public DateTime? Dd190Dalteracao { get; set; }

    public string? Dd190CcustoId { get; set; }

    public string? Dd190AgcobradorId { get; set; }

    public string? Dd190CondPagtoId { get; set; }

    public string? Dd190ResponsavelId { get; set; }

    public string? Dd190FormapagtoId { get; set; }

    public decimal? Dd190Valorobra { get; set; }

    public int? Dd190Statusid { get; set; }

    public bool? Dd190Isgeradofinanc { get; set; }

    public int? Dd190Cep { get; set; }

    public string? Dd190Logradouro { get; set; }

    public string? Dd190Numero { get; set; }

    public string? Dd190Complemento { get; set; }

    public string? Dd190Perimetro { get; set; }

    public string? Dd190Bairro { get; set; }

    public string? Dd190PaisId { get; set; }

    public string? Dd190UfId { get; set; }

    public string? Dd190CidadeId { get; set; }

    public decimal? Dd190Thrtarefa { get; set; }

    public decimal? Dd190Threxec { get; set; }

    public decimal? Dd190Pexecucao { get; set; }

    public string? Dd190Tag { get; set; }

    public long? Dd190IdObrapai { get; set; }

    public long? Dd196Grupoid { get; set; }

    public string? Dd190Colorid { get; set; }

    public long? Dd190Tagid { get; set; }

    public virtual CSICP_DD190? Dd190IdObrapaiNavigation { get; set; }

    public virtual CSICP_DD191St? Dd190Status { get; set; }

    public virtual CSICP_DD204? Dd190TagNavigation { get; set; }

    public virtual CSICP_DD196? Dd196Grupo { get; set; }
}
