using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF128
{
    private CSICP_FF128()
    {
    }

    public int TenantId { get; set; }

    public string Ff128Id { get; set; } = null!;

    public string? Ff128CobradorId { get; set; }

    public string? Ff128AgcobradorId { get; set; }

    public DateTime? Ff128Dtregistro { get; set; }

    public string? Ff128Tituloid { get; set; }

    public DateTime? Ff128Dtprevisao { get; set; }

    public string? Ff128Mensagem { get; set; }

    public bool? Ff128Isactive { get; set; }

    public string Ff127Id { get; set; } = string.Empty;

    public int? Ff128Diasatrasoent { get; set; }

    public int? Ff128SitcobrancaentId { get; set; }

    public int? Ff128Sitcobranca { get; set; }

    public int? Ff128SituacaosaiId { get; set; }

    public string? Ff128Categoriaid { get; set; }

    public DateTime? Ff128Dtlimitevisita { get; set; }

    public DateTime? Ff128HoraRegistro { get; set; }


    public static CSICP_FF128 Create(
        string id,
        string tituloID,
        DateTime dataPrevisao,
        string mensagem,
        string novoIdFF127,
        int diasAtrasoEnt,
        int sitCobranca,
        int situacaoSaiId,
        string? cobradorId,
        string? agCobradorId
        )
    {
        var obj = new CSICP_FF128()
        {
            Ff128Id = id,
            Ff128Dtregistro = DateTime.UtcNow.ToLocalTime(),
            Ff128Tituloid = tituloID,
            Ff128Dtprevisao = dataPrevisao,
            Ff128Mensagem = mensagem,
            Ff128Isactive = true,
            Ff127Id = novoIdFF127,
            Ff128Diasatrasoent = diasAtrasoEnt,
            Ff128Sitcobranca = sitCobranca,
            Ff128SituacaosaiId = situacaoSaiId,
            Ff128AgcobradorId = agCobradorId,
            Ff128CobradorId = cobradorId,
            Ff128HoraRegistro = DateTime.UtcNow.ToLocalTime(),
        };

        return obj;
    }
}
