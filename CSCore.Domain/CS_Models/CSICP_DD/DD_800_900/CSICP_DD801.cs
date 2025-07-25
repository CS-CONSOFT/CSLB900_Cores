using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD801
{
    public int TenantId { get; set; }

    public string Dd801Id { get; set; } = null!;

    public string? Dd801EmpresaId { get; set; }

    public string? Dd801KardexId { get; set; }

    public string? Dd801NfentradaId { get; set; }

    public int? Dd801QtdEtiquetas { get; set; }

    public decimal? Dd801Prcvenda { get; set; }

    public decimal? Dd801PrcvendaKdx { get; set; }

    public int? Dd801StatusPrecifId { get; set; }

    public bool? Dd801Imprimiu { get; set; }

    public DateTime? Dd801Dataimpressao { get; set; }

    public string? Dd801Quemimprimiu { get; set; }

    public string? Dd801Quematualizou { get; set; }

    public int? Dd801OrigemetiqId { get; set; }

    public string? Dd801IdModulo { get; set; }

    public DateTime? Dd801Datageracao { get; set; }

    public string? Dd801Formapagtoid1 { get; set; }

    public string? Dd801Cpagto1Id { get; set; }

    public decimal? Dd801Prcvenda1 { get; set; }

    public decimal? Dd801Prcparcela1 { get; set; }

    public decimal? Dd801Pjuros1 { get; set; }

    public string? Dd801Formapagtoid2 { get; set; }

    public string? Dd801Cpagto2Id { get; set; }

    public decimal? Dd801Prcvenda2 { get; set; }

    public decimal? Dd801Prcparcela2 { get; set; }

    public decimal? Dd801Pjuros2 { get; set; }

    public string? Dd801Formapagtoid3 { get; set; }

    public string? Dd801Cpagto3Id { get; set; }

    public decimal? Dd801Prcvenda3 { get; set; }

    public decimal? Dd801Prcparcela3 { get; set; }

    public decimal? Dd801Pjuros3 { get; set; }

    public string? Dd801Formapagtoid4 { get; set; }

    public string? Dd801Cpagto4Id { get; set; }

    public decimal? Dd801Prcvenda4 { get; set; }

    public decimal? Dd801Prcparcela4 { get; set; }

    public decimal? Dd801Pjuros4 { get; set; }

    public string? Dd801Formapagtoid5 { get; set; }

    public string? Dd801Cpagto5Id { get; set; }

    public decimal? Dd801Prcvenda5 { get; set; }

    public decimal? Dd801Prcparcela5 { get; set; }

    public decimal? Dd801Pjuros5 { get; set; }

    public string? Dd801Formapagtoid6 { get; set; }

    public string? Dd801Cpagto6Id { get; set; }

    public decimal? Dd801Prcvenda6 { get; set; }

    public decimal? Dd801Prcparcela6 { get; set; }

    public decimal? Dd801Pjuros6 { get; set; }

    public string? Dd801Formapagtoid7 { get; set; }

    public string? Dd801Cpagto7Id { get; set; }

    public decimal? Dd801Prcvenda7 { get; set; }

    public decimal? Dd801Prcparcela7 { get; set; }

    public decimal? Dd801Pjuros7 { get; set; }

    public string? Dd801Formapagtoid8 { get; set; }

    public string? Dd801Cpagto8Id { get; set; }

    public decimal? Dd801Prcvenda8 { get; set; }

    public decimal? Dd801Prcparcela8 { get; set; }

    public decimal? Dd801Pjuros8 { get; set; }

    public string? Dd801Formapagtoid9 { get; set; }

    public string? Dd801Cpagto9Id { get; set; }

    public decimal? Dd801Prcvenda9 { get; set; }

    public decimal? Dd801Prcparcela9 { get; set; }

    public decimal? Dd801Pjuros9 { get; set; }

    public string? Dd801Formapagtoid10 { get; set; }

    public string? Dd801Cpagto10Id { get; set; }

    public decimal? Dd801Prcvenda10 { get; set; }

    public decimal? Dd801Prcparcela10 { get; set; }

    public decimal? Dd801Pjuros10 { get; set; }

    public string? Dd801Formapagtoid11 { get; set; }

    public string? Dd801Cpagto11Id { get; set; }

    public decimal? Dd801Prcvenda11 { get; set; }

    public decimal? Dd801Prcparcela11 { get; set; }

    public decimal? Dd801Pjuros11 { get; set; }

    public string? Dd801Formapagtoid12 { get; set; }

    public string? Dd801Cpagto12Id { get; set; }

    public decimal? Dd801Prcvenda12 { get; set; }

    public decimal? Dd801Prcparcela12 { get; set; }

    public decimal? Dd801Pjuros12 { get; set; }

    public bool? Dd801Ismarcado { get; set; }

    public string? Gg019Codgbarraid { get; set; }

    public string? Dd801Codbarras { get; set; }

    public string? Dd801Usuariopropid { get; set; }

    public DateTime? Dd801Dcriadoem { get; set; }

    public string? Dd803Id { get; set; }

    public DateTime? Dd801Dvalidadeprom { get; set; }

    public virtual CSICP_DD801Otq? Dd801Origemetiq { get; set; }

    public virtual CSICP_DD803? Dd803 { get; set; }

}
