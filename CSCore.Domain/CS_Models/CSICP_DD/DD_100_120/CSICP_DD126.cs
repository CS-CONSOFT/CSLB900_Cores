namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD126
{
    public int TenantId { get; set; }

    public string Dd126RegccredId { get; set; } = null!;

    public string? Dd126CartacreditoId { get; set; }

    public string? Dd126FilialId { get; set; }

    public string? Dd126UsuariopropId { get; set; }

    public DateTime? Dd126DataMovto { get; set; }

    public DateTime? Dd126DataCredito { get; set; }

    public decimal? Dd126VlrUtilizado { get; set; }

    public string? Dd126Historico { get; set; }

    public string? Dd126PdvId { get; set; }

    public int? Dd126TmovtoCcreId { get; set; }

    public string? Dd126UsoInternoWs { get; set; }

    public string? Dd126Protocolnumber { get; set; }

    public string? Dd142HashCalculador { get; set; }

    public virtual CSICP_DD125? Dd126Cartacredito { get; set; }

    public virtual CSICP_DD126Tmov? Nav_Dd126TmovtoCcre { get; set; }

}
