using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.FF;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF140
{
    private CSICP_FF140() { }
    public int TenantId { get; set; }

    public long Ff140Id { get; set; }

    public DateTime? Ff140Data { get; set; }

    public string? Ff140Contaid { get; set; }

    public string? Ff140Especieid { get; set; }

    public string? Ff140Ccustoid { get; set; }

    public string? Ff140Usuarioproprieid { get; set; }

    public string? Ff140Agcobradorid { get; set; }

    public string? Ff140FpagtoId { get; set; }

    public string? Ff140Condicaoid { get; set; }

    public string? Ff140Tipocobrancaid { get; set; }

    public string? Ff140Descricao { get; set; }

    public string? Ff140Protocolnumber { get; set; }

    public decimal? Ff140Vrequisicao { get; set; }

    public string? Ff140Projetoid { get; set; }

    public int? Ff140Statusid { get; set; }

    public int? Ff140Execucaoid { get; set; }

    public int? Ff140Tpvinculoid { get; set; }

    public int? Ff140QtdeParcelas { get; set; }

    public string? Ff140Estabid { get; set; }

    public int? Ff140AdtoId { get; set; }

    //NavsGetList
    public CSICP_BB001? NavBB001EstabID { get; set; }
    public CSICP_Bb005? NavBB005CCustoID { get; set; }
    public CSICP_Bb006? NavBB006AgCobradorID { get; set; }
    public CSICP_Bb008? NavBB008CondicaoID { get; set; }
    public CSICP_Bb009? NavBB009TpCobrancaID { get; set; }
    public CSICP_BB012? NavBB012ContaID { get; set; }
    public CSICP_Bb026? NavBB026FPagto { get; set; }
    public CSICP_FF003? NavFF003EspecieID { get; set; }
    public Csicp_Sy001? NavSY001UsuarioPropID { get; set; }
    public OsusrE9aCsicpFf140Stum? NavFF140Status { get; set; }
    public OsusrE9aCsicpFf140Exe? NavFF140Exe { get; set; }
    public OsusrE9aCsicpFf140Vin? NavFF140Vinculo { get; set; }

    //NavsListGetByID
    public IEnumerable<CSICP_FF141>? NavListFF141 { get; set; }
    public IEnumerable<CSICP_FF143>? NavListFF143 { get; set; }
    public IEnumerable<CSICP_FF144> NavListFF144 { get; set; } = new List<CSICP_FF144>();

    public static CSICP_FF140 CreateInstance(
        int tenantId,
        long ff140Id,
        DateTime? ff140Data = null,
        string? ff140Contaid = null,
        string? ff140Especieid = null,
        string? ff140Ccustoid = null,
        string? ff140Usuarioproprieid = null,
        string? ff140Agcobradorid = null,
        string? ff140FpagtoId = null,
        string? ff140Condicaoid = null,
        string? ff140Tipocobrancaid = null,
        string? ff140Descricao = null,
        string? ff140Protocolnumber = null,
        decimal? ff140Vrequisicao = null,
        string? ff140Projetoid = null,
        int? ff140Statusid = null,
        int? ff140Execucaoid = null,
        int? ff140Tpvinculoid = null,
        int? ff140QtdeParcelas = null,
        string? ff140Estabid = null,
        int? ff140AdtoId = null)
    {
        return new CSICP_FF140
        {
            TenantId = tenantId,
            Ff140Id = ff140Id,
            Ff140Data = ff140Data,
            Ff140Contaid = ff140Contaid,
            Ff140Especieid = ff140Especieid,
            Ff140Ccustoid = ff140Ccustoid,
            Ff140Usuarioproprieid = ff140Usuarioproprieid,
            Ff140Agcobradorid = ff140Agcobradorid,
            Ff140FpagtoId = ff140FpagtoId,
            Ff140Condicaoid = ff140Condicaoid,
            Ff140Tipocobrancaid = ff140Tipocobrancaid,
            Ff140Descricao = ff140Descricao,
            Ff140Protocolnumber = ff140Protocolnumber,
            Ff140Vrequisicao = ff140Vrequisicao,
            Ff140Projetoid = ff140Projetoid,
            Ff140Statusid = ff140Statusid,
            Ff140Execucaoid = ff140Execucaoid,
            Ff140Tpvinculoid = ff140Tpvinculoid,
            Ff140QtdeParcelas = ff140QtdeParcelas,
            Ff140Estabid = ff140Estabid,
            Ff140AdtoId = ff140AdtoId
        };
    }

    public void ValidaStatusDoMovimentoLancandoErroSeForDiferenteDoParametro(int InStatusId, string? Messagem = null)
    {
        if (this.Ff140Statusid != InStatusId)
            throw new InvalidOperationException(Messagem != null ? Messagem : $"Status do movimento inválido. Status atual: {Ff140Statusid}, Status esperado: {InStatusId}");
    }

    public void ValidaStatusDoMovimentoLancandoErroSeForIgualDoParametro(int InStatusId, string? Messagem = null)
    {
        if (this.Ff140Statusid == InStatusId)
            throw new InvalidOperationException(Messagem != null ? Messagem : $"Status do movimento inválido. Status atual: {Ff140Statusid}, Status esperado: {InStatusId}");
    }


    public void ValidaRequisicaoMenorOuIgualAZeroLancandoErroSeFor(string? Messagem = null)
    {
        if (this.Ff140Vrequisicao <= 0)
            throw new InvalidOperationException(Messagem);
    }

    public void AlterarStatusDoMovimento(int novoStatusId)
    {
        this.Ff140Statusid = novoStatusId;
    }
}
