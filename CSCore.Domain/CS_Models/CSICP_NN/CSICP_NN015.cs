using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.CS_Models.Staticas.NN;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_NN;

public partial class CSICP_NN015
{
    public int TenantId { get; set; }

    public string Nn015CrcpId { get; set; } = null!;

    public string? Nn015FilialId { get; set; }

    public int? Nn015Filial { get; set; }
    [ForeignKey("NavNN015Rp")]

    public int? Nn015TipoMovtoid { get; set; }
    public OsusrE9aCsicpNn015Rp? NavNN015Rp { get; set; }

    public decimal? Nn015Ciorigemestorno { get; set; }

    public DateTime? Nn015DataMovimento { get; set; }

    [ForeignKey("NavNN001")]

    public string? Nn015CtacorrenteId { get; set; }
    public CSICP_NN001? NavNN001 { get; set; }

    public int? Nn015CodgCcorrente { get; set; }

    public string? Nn015Documento { get; set; }

    public bool? Nn015Ischeque { get; set; }

    public int? Nn015NoCheque { get; set; }

    public string? Nn015Agencia { get; set; }

    public int? Nn015Banco { get; set; }

    public string? Nn015ContaId { get; set; }

    public int? Nn015Clientefornec { get; set; }

    public DateTime? Nn015BomPara { get; set; }

    public DateTime? Nn015Venctoinicial { get; set; }

    public DateTime? Nn015Venctofinal { get; set; }

    public decimal? Nn015TotalTitulo { get; set; }

    public decimal? Nn015TotalJuros { get; set; }

    public decimal? Nn015TotalMulta { get; set; }

    public decimal? Nn015TotalDescontos { get; set; }

    public decimal? Nn015TotalTaxa { get; set; }

    public decimal? Nn015TotalPago { get; set; }

    public string? Nn015Historico { get; set; }

    public string? Nn015Favorecido { get; set; }


    [ForeignKey("NavNN015Status")]
    public int? Nn015Status { get; set; }

    public OsusrE9aCsicpNn015Stum? NavNN015Status { get; set; }

    public string? Nn015GrupoId { get; set; }

    public string? Nn015ClasseId { get; set; }

    public string? Nn015CcustoId { get; set; }

    public string? Nn015AgcobradorId { get; set; }

    public int? Nn015Tipomovimento { get; set; }

    public bool? Nn015Isestorno { get; set; }

    public string? Nn015UsuariopropId { get; set; }

    public decimal? Nn015TotaljurosCalc { get; set; }

    public decimal? Nn015TotalmultaCalc { get; set; }

    public decimal? Nn015TotaltaxaCalc { get; set; }

    public string? Nn015Protocolnumber { get; set; }

    public DateTime? Nn015Dbaixatit { get; set; }

    public DateTime? Nn015Dcreditotit { get; set; }

    public decimal? Nn015TaxaAntecipacao { get; set; }

    public decimal? Nn015ValorTxAntcartao { get; set; }

    public decimal? Nn015Tcorrmonetaria { get; set; }

    public decimal? Nn015Thonorarios { get; set; }


    }
