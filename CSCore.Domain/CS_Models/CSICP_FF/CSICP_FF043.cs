using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF043
{
    private CSICP_FF043()
    {
    }

    public int TenantId { get; set; }

    public long Ff043Id { get; set; }

    public long Ff042Id { get; set; }

    public int? Ff043Parcela { get; set; }

    public DateTime? Ff043DataVencto { get; set; }

    public decimal? Ff043ValorParcela { get; set; }

    public DateTime? Ff043DataVenctoOri { get; set; }

    public string? Ff043Pfxtitulo { get; set; }

    public decimal? Ff043Titulo { get; set; }

    public string? Ff043Sfxtitulo { get; set; }

    public string? Ff043TituloCpId { get; set; }

    public static CSICP_FF043 Create(
        int InTenantID,
        long InFf042Id,
        decimal ValorParcela,
        int Parcela,
        DateTime DataVencimento,
        string Pfxtitulo,
        decimal? Protocolo
        )
    {
        var parcelaStr = Parcela.ToString();
        var sfxTitulo = parcelaStr.Length > 1 ? parcelaStr : "0" + parcelaStr;
        return new CSICP_FF043
        {
            Ff042Id = InFf042Id,
            TenantId = InTenantID,
            Ff043ValorParcela = ValorParcela,
            Ff043Parcela = Parcela,
            Ff043DataVencto = DataVencimento,
            Ff043Pfxtitulo = Pfxtitulo,
            Ff043Titulo = Protocolo,
            Ff043Sfxtitulo = sfxTitulo
        };
    }
}
