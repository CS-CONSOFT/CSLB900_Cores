using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD110
{
    public int TenantId { get; set; }

    public string Dd110CargaId { get; set; } = null!;

    public string? Dd110FilialId { get; set; }

    public string? Dd110Descritivocarga { get; set; }

    public DateTime? Dd110DataCarga { get; set; }

    public decimal? Dd110PesoBruto { get; set; }

    public decimal? Dd110PesoLiquido { get; set; }

    public int? Dd110Volumes { get; set; }

    public string? Dd110VeiculoId { get; set; }

    public string? Dd110MotoristaId { get; set; }

    public string? Dd110Ajudante1Id { get; set; }

    public string? Dd110Ajudante2Id { get; set; }

    public string? Dd110Ajudante3Id { get; set; }

    public DateTime? Dd110DataSaida { get; set; }

    public DateTime? Dd110HoraSaida { get; set; }

    public int? Dd110KmSaida { get; set; }

    public DateTime? Dd110DataChegada { get; set; }

    public DateTime? Dd110HoraChegada { get; set; }

    public int? Dd110KmChegada { get; set; }

    public bool? Dd110Terceirizada { get; set; }

    public decimal? Dd110Valorfrete { get; set; }

    public int? Dd110StatusId { get; set; }

    public string? Dd110MotoristaUserid { get; set; }

    public decimal? Dd110PercIndiceminimo { get; set; }

    public string? Dd110PropuserId { get; set; }

    public int? Dd110QtdNfs { get; set; }

    public decimal? Dd110Tvalornfs { get; set; }

    public decimal? Dd110Tvlrcobranca { get; set; }

    public string? Dd110Protocolnumber { get; set; }

    public int? Dd110Modentregaid { get; set; }

    public bool? Dd110Issync { get; set; }

    public DateTime? Dd110DthrUltsync { get; set; }

    public string? Dd110Chaveacessonfe { get; set; }

    public string? Dd110Serie { get; set; }

    public int? Dd110NoNf { get; set; }

    public int? Dd110ModId { get; set; }

    public string? Dd110CtrlSerieNfId { get; set; }

    public decimal? NfeNprot { get; set; }

    public decimal? NfeNrec { get; set; }

    public decimal? NfeEpecNprot { get; set; }

    public string? Dd110Seguroid { get; set; }

    public decimal? MdfeNprot { get; set; }

    public decimal? MdfeNrec { get; set; }

    public decimal? MdfeEpecNprot { get; set; }

    public string? MdfeCstat { get; set; }

    public int? Dd110Mdfesit { get; set; }

    public DateTime? Dd110Dtemiss { get; set; }

    public DateTime? Dd110Dtautor { get; set; }

    public string? Dd110UfdestId { get; set; }

    public virtual CSICP_DD110Mdfe? Dd110MdfesitNavigation { get; set; }

    public virtual CSICP_DD110Mod? NavDD10Modentrega { get; set; }

    public virtual CSICP_DD110Status? NavDD110Status { get; set; }

  }
